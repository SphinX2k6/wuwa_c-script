using System;

namespace System
{
	// Token: 0x0200012F RID: 303
	[Flags]
	internal enum ParseFlags
	{
		// Token: 0x04000440 RID: 1088
		HaveYear = 1,
		// Token: 0x04000441 RID: 1089
		HaveMonth = 2,
		// Token: 0x04000442 RID: 1090
		HaveDay = 4,
		// Token: 0x04000443 RID: 1091
		HaveHour = 8,
		// Token: 0x04000444 RID: 1092
		HaveMinute = 16,
		// Token: 0x04000445 RID: 1093
		HaveSecond = 32,
		// Token: 0x04000446 RID: 1094
		HaveTime = 64,
		// Token: 0x04000447 RID: 1095
		HaveDate = 128,
		// Token: 0x04000448 RID: 1096
		TimeZoneUsed = 256,
		// Token: 0x04000449 RID: 1097
		TimeZoneUtc = 512,
		// Token: 0x0400044A RID: 1098
		ParsedMonthName = 1024,
		// Token: 0x0400044B RID: 1099
		CaptureOffset = 2048,
		// Token: 0x0400044C RID: 1100
		YearDefault = 4096,
		// Token: 0x0400044D RID: 1101
		Rfc1123Pattern = 8192,
		// Token: 0x0400044E RID: 1102
		UtcSortPattern = 16384
	}
}
