using AppNotas.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoCompras
{
    public class AppSettings
    {
        public static string ApiFirebase = "https://ventatest1-e788b-default-rtdb.firebaseio.com/";
        private static string KeyAplication = "AIzaSyAk0U21H0EWOYvAFQOV4sgSa8HTecayflA";


        public static ResponseAuthentication oAuthentication { get; set; }
        private static string ApiUrlGoogleApis = "https://identitytoolkit.googleapis.com/v1/";

        public static string ApiAuthentication(string tipo)
        {
            if (tipo == "LOGIN")
                return ApiUrlGoogleApis + "accounts:signInWithPassword?key=" + KeyAplication;
            else if (tipo == "SIGNIN")
                return ApiUrlGoogleApis + "accounts:signUp?key=" + KeyAplication;
            else
                return "";
        }

    }
}
