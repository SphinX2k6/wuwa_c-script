using System;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02004863 RID: 18531
	public class WeatherDefines
	{
		// Token: 0x0401A0DE RID: 106718
		public const int REFRESH_WEATHER_TIMER_INTERVAL = 1000;

		// Token: 0x0200AB4D RID: 43853
		public enum EWeatherType
		{
			// Token: 0x040340D9 RID: 213209
			None,
			// Token: 0x040340DA RID: 213210
			Sunny,
			// Token: 0x040340DB RID: 213211
			Cloudy,
			// Token: 0x040340DC RID: 213212
			Rainy,
			// Token: 0x040340DD RID: 213213
			ThunderRain,
			// Token: 0x040340DE RID: 213214
			Snowy
		}
	}
}
