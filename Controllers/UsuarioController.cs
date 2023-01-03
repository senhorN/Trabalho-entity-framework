using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace ModeloAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        #region Data e Hora
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            //Objeto anonimo 
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };
            
            //retorne o metodo OK - 200
            return Ok(obj);
        }
        #endregion
        
        #region Apresentar
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem-vindo!";
            return Ok(new { mensagem });
        }
        #endregion
    }
}
