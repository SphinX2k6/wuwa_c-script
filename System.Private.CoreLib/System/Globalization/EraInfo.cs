using System;

namespace System.Globalization
{
	// Token: 0x020002ED RID: 749
	internal sealed class EraInfo
	{
		// Token: 0x060036FD RID: 14077 RVA: 0x000B404C File Offset: 0x000B224C
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear)
		{
			this.era = era;
			this.yearOffset = yearOffset;
			this.minEraYear = minEraYear;
			this.maxEraYear = maxEraYear;
			this.ticks = new DateTime(startYear, startMonth, startDay).Ticks;
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x000B4098 File Offset: 0x000B2298
		internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName)
		{
			this.era = era;
			this.yearOffset = yearOffset;
			this.minEraYear = minEraYear;
			this.maxEraYear = maxEraYear;
			this.ticks = new DateTime(startYear, startMonth, startDay).Ticks;
			this.eraName = eraName;
			this.abbrevEraName = abbrevEraName;
			this.englishEraName = englishEraName;
		}

		// Token: 0x04000A91 RID: 2705
		internal int era;

		// Token: 0x04000A92 RID: 2706
		internal long ticks;

		// Token: 0x04000A93 RID: 2707
		internal int yearOffset;

		// Token: 0x04000A94 RID: 2708
		internal int minEraYear;

		// Token: 0x04000A95 RID: 2709
		internal int maxEraYear;

		// Token: 0x04000A96 RID: 2710
		internal string eraName;

		// Token: 0x04000A97 RID: 2711
		internal string abbrevEraName;

		// Token: 0x04000A98 RID: 2712
		internal string englishEraName;
	}
}
