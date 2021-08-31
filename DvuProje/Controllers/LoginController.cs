using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DvuProje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Islem()
        {
            return View();
        }
        public ActionResult forgot()
        {
            return View(); // şifremi unuttum
        }
        
        public ActionResult register()
        {
            return View(); // yeni hesap
        }
        public ActionResult reset()
        {
            return View(); // yeni hesap
        }


    }
}