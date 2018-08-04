using System;
using System.Net.Http;

namespace MicroservicePortal.Web.Services
{
    public class EventService
    {
        private readonly Uri _uri = new Uri(@"https://ms-portal-eventapi.azurewebsites.net/api/events/item/4faa643b-307a-4277-879e-3bff8bb23146");
        public void TriggerEvent()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                var response = httpClient.GetStringAsync(_uri).Result;
            }
        }
    }
}