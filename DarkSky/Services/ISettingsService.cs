﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSky.Services
{
	public interface ISettingsService
	{
		public bool IsLoggedIn { get; set; }
	}
}