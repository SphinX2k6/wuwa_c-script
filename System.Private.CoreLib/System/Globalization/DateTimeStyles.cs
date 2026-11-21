using System;

namespace System.Globalization
{
	// Token: 0x020002E4 RID: 740
	[Flags]
	public enum DateTimeStyles
	{
		// Token: 0x04000A77 RID: 2679
		None = 0,
		// Token: 0x04000A78 RID: 2680
		AllowLeadingWhite = 1,
		// Token: 0x04000A79 RID: 2681
		AllowTrailingWhite = 2,
		// Token: 0x04000A7A RID: 2682
		AllowInnerWhite = 4,
		// Token: 0x04000A7B RID: 2683
		AllowWhiteSpaces = 7,
		// Token: 0x04000A7C RID: 2684
		NoCurrentDateDefault = 8,
		// Token: 0x04000A7D RID: 2685
		AdjustToUniversal = 16,
		// Token: 0x04000A7E RID: 2686
		AssumeLocal = 32,
		// Token: 0x04000A7F RID: 2687
		AssumeUniversal = 64,
		// Token: 0x04000A80 RID: 2688
		RoundtripKind = 128
	}
}
