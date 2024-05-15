using Microsoft.AspNetCore.Mvc;

namespace rztk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
