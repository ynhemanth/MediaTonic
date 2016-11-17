using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;

namespace MediaTonicWebApp.Controllers
{
    public class PettingGameController : ApiController
    {
        //[AcceptVerbs("GET")]
        [HttpGet]
        //[Route("PettingAnimals/PettingGame")]
        public HttpResponseMessage PettingAnimals()
        {
            string text = "Petting animals makes them happy";
            return new HttpResponseMessage() { Content = new StringContent(text, Encoding.UTF8, "text/html") };
        }

        //[AcceptVerbs("GET", "POST")]
        [HttpGet]
        //[Route("api/PettingGame/FeeingAnimals/val")]
        public HttpResponseMessage FeeingAnimals(int val)
        {
            string text = "Feeing animals makes them "+val.ToString()+" times less hungry";
            return new HttpResponseMessage() { Content = new StringContent(text, Encoding.UTF8, "text/html") };
        }

        [AcceptVerbs("GET")]
        //[Route("PettingAnimals/PettingGame")]
        public HttpResponseMessage HappinessHungerCalculator(string level)
        {
            string text = "Animal's Happiness is"+level+" Animal's hunger is "+level;
            return new HttpResponseMessage() { Content = new StringContent(text, Encoding.UTF8, "text/html") };
        }

        [AcceptVerbs("GET")]
        //[Route("PettingAnimals/PettingGame")]
        public HttpResponseMessage AllHappinessHungerCalculator(string level1, string level2, string level3)
        {
            string text = "First Animal's Happiness is" + level1 + " First Animal's hunger is " + level1 +
                          " <br /><br />Second Animal's Happiness is" + level2 + " Second Animal's hunger is " + level2 +
                          "<br /><br /> Third Animal's Happiness is" + level3 + " Third Animal's hunger is " + level3;
            return new HttpResponseMessage() { Content = new StringContent(text, Encoding.UTF8, "text/html") };
        }
    }
}
