using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000245 RID: 581
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariableRuleIgnore]
	public class SplashRegionBlockConfig
	{
		// Token: 0x04000974 RID: 2420
		private const int SECS_PER_DAY = 86400;

		// Token: 0x04000975 RID: 2421
		private const int CACHE_TTL_DAYS = 30;

		// Token: 0x04000976 RID: 2422
		public static readonly bool Enabled = false;

		// Token: 0x04000977 RID: 2423
		public static readonly string[] BlockedRegions = new string[]
		{
			"TW",
			"KR"
		};

		// Token: 0x04000978 RID: 2424
		public static readonly int CacheTtlSecs = 2592000;

		// Token: 0x04000979 RID: 2425
		public static readonly int RequestTimeoutSecs = 3;

		// Token: 0x0400097A RID: 2426
		public static readonly bool FallbackBlockOnFailure = false;

		// Token: 0x0400097B RID: 2427
		public static readonly bool TestMode = false;

		// Token: 0x0400097C RID: 2428
		public static readonly string TestForcedRegion = "";

		// Token: 0x0400097D RID: 2429
		public static readonly SplashRegionGeoIpProvider[] GeoIpProviders = new SplashRegionGeoIpProvider[]
		{
			new SplashRegionGeoIpProvider("country.is", "https://api.country.is/", new Regex("\"country\"\\s*:\\s*\"(?<code>[A-Za-z]{2})\"")),
			new SplashRegionGeoIpProvider("ipinfo.io", "https://ipinfo.io/json", new Regex("\"country\"\\s*:\\s*\"(?<code>[A-Za-z]{2})\"")),
			new SplashRegionGeoIpProvider("ipapi.is", "https://api.ipapi.is/", new Regex("\"country_code\"\\s*:\\s*\"(?<code>[A-Za-z]{2})\""))
		};
	}
}
