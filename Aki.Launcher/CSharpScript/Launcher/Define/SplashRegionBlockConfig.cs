using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024A RID: 586
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class SplashRegionBlockConfig
	{
		// Token: 0x040009BC RID: 2492
		private const int SECS_PER_DAY = 86400;

		// Token: 0x040009BD RID: 2493
		private const int CACHE_TTL_DAYS = 30;

		// Token: 0x040009BE RID: 2494
		public static readonly bool Enabled = false;

		// Token: 0x040009BF RID: 2495
		public static readonly string[] BlockedRegions = new string[]
		{
			"TW",
			"KR"
		};

		// Token: 0x040009C0 RID: 2496
		public static readonly int CacheTtlSecs = 2592000;

		// Token: 0x040009C1 RID: 2497
		public static readonly int RequestTimeoutSecs = 3;

		// Token: 0x040009C2 RID: 2498
		public static readonly bool FallbackBlockOnFailure = false;

		// Token: 0x040009C3 RID: 2499
		public static readonly bool TestMode = false;

		// Token: 0x040009C4 RID: 2500
		public static readonly string TestForcedRegion = "";

		// Token: 0x040009C5 RID: 2501
		public static readonly SplashRegionGeoIpProvider[] GeoIpProviders = new SplashRegionGeoIpProvider[]
		{
			new SplashRegionGeoIpProvider("country.is", "https://api.country.is/", new Regex("\"country\"\\s*:\\s*\"(?<code>[A-Za-z]{2})\"")),
			new SplashRegionGeoIpProvider("ipinfo.io", "https://ipinfo.io/json", new Regex("\"country\"\\s*:\\s*\"(?<code>[A-Za-z]{2})\"")),
			new SplashRegionGeoIpProvider("ipapi.is", "https://api.ipapi.is/", new Regex("\"country_code\"\\s*:\\s*\"(?<code>[A-Za-z]{2})\""))
		};
	}
}
