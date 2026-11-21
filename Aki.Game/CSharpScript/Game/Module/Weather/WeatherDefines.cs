using System;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02003794 RID: 14228
	public class WeatherDefines
	{
		// Token: 0x04014792 RID: 83858
		public const int REFRESH_WEATHER_TIMER_INTERVAL = 1000;

		// Token: 0x020094FB RID: 38139
		public enum EWeatherType
		{
			// Token: 0x0402E851 RID: 190545
			None,
			// Token: 0x0402E852 RID: 190546
			Sunny,
			// Token: 0x0402E853 RID: 190547
			Cloudy,
			// Token: 0x0402E854 RID: 190548
			Rainy,
			// Token: 0x0402E855 RID: 190549
			ThunderRain,
			// Token: 0x0402E856 RID: 190550
			Snowy
		}
	}
}
