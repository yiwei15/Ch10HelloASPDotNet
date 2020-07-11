using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloASPDotNet.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {
        // GET: / <controller>/
        //[HttpGet]
        //[Route("/helloworld/")]

        [HttpGet]
        [Route("/helloworld/index/")]
        public IActionResult Index()
        {
            //string html = "<h1>Hello World!</h1>";
            //return Content(html, "text/html");

            string html = "<form method='post' action='/helloworld/welcomepost'>" 
                          + "<input type='text' name='name' />" 
                          + "<select name='language'>"
                          + "<option value = 'English'>English</option>"
                          + "<option value = 'Spanish'>Spanish</option>"
                          + "<option value = 'French'>French</option>"
                          + "<option value = 'Chinese'>Chinese</option>"
                          + "<option value = 'Russian'>Russian</option>"
                          + "<input type='submit' value='Greet Me!' />" 
                          + "</form>";

            return Content(html, "text/html");
        }

        // GET: / helloworld/welcome
        [HttpGet]
        [Route("/helloworld/welcome/")]
      
        public IActionResult Welcome(string name = "World")
        {
            //return Content("<h1>Welcome to my app, " + name + "!<h1>", "text/html");
            string html = $"<h1>Welcome, {name}!<h1>";
            return Content(html, "text/html");
        }

        //POST/helloworld/welcomepost
        [HttpPost]
        [Route("/helloworld/welcomepost")]

        public IActionResult WelcomePost(string language = "English", string name = "World")
        {
            //return Content("<h1>Welcome to my app, " + name + "!<h1>", "text/html");
            string message = CreateMessage(language, name);
            return Content(message, "text/html");
        }

        public static string CreateMessage(string language, string name)
        {
            if (language == "English")
            {
                string html = $"<h1>Hello, {name}.<h1>";
                return html;
            }

            else if (language == "Spanish")
            {
                string html = $"<h1 style='color: red;'>Hola, {name}.<h1> ";
                return html;
            }
            else if (language == "French")
            {
                string html = $"<h1>Bonjour, {name}.<h1>";
                return html;
            }

            else if (language == "Chinese")
            {
                string html = $"<h1>Nihao, {name}.<h1>";
                return html;
            }

            else if (language == "Russian")
            {
                string html = $"<h1>Zdravstvuyte {name}.<h1>";
                return html;
            }
            else
            {
                return $"<h1>No language chosen.<h1>";
            }

        }
    }
}
