using System;

namespace System.Globalization
{
	// Token: 0x020002F3 RID: 755
	internal enum HebrewNumberParsingState
	{
		// Token: 0x04000AAD RID: 2733
		InvalidHebrewNumber,
		// Token: 0x04000AAE RID: 2734
		NotHebrewDigit,
		// Token: 0x04000AAF RID: 2735
		FoundEndOfHebrewNumber,
		// Token: 0x04000AB0 RID: 2736
		ContinueParsing
	}
}
