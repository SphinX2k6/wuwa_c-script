using System;

namespace System.Globalization
{
	// Token: 0x020002DD RID: 733
	[Flags]
	internal enum DateTimeFormatFlags
	{
		// Token: 0x04000A0D RID: 2573
		None = 0,
		// Token: 0x04000A0E RID: 2574
		UseGenitiveMonth = 1,
		// Token: 0x04000A0F RID: 2575
		UseLeapYearMonth = 2,
		// Token: 0x04000A10 RID: 2576
		UseSpacesInMonthNames = 4,
		// Token: 0x04000A11 RID: 2577
		UseHebrewRule = 8,
		// Token: 0x04000A12 RID: 2578
		UseSpacesInDayNames = 16,
		// Token: 0x04000A13 RID: 2579
		UseDigitPrefixInTokens = 32,
		// Token: 0x04000A14 RID: 2580
		NotInitialized = -1
	}
}
