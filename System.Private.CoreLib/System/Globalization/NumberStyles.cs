using System;

namespace System.Globalization
{
	// Token: 0x02000306 RID: 774
	[Flags]
	public enum NumberStyles
	{
		// Token: 0x04000B2A RID: 2858
		None = 0,
		// Token: 0x04000B2B RID: 2859
		AllowLeadingWhite = 1,
		// Token: 0x04000B2C RID: 2860
		AllowTrailingWhite = 2,
		// Token: 0x04000B2D RID: 2861
		AllowLeadingSign = 4,
		// Token: 0x04000B2E RID: 2862
		AllowTrailingSign = 8,
		// Token: 0x04000B2F RID: 2863
		AllowParentheses = 16,
		// Token: 0x04000B30 RID: 2864
		AllowDecimalPoint = 32,
		// Token: 0x04000B31 RID: 2865
		AllowThousands = 64,
		// Token: 0x04000B32 RID: 2866
		AllowExponent = 128,
		// Token: 0x04000B33 RID: 2867
		AllowCurrencySymbol = 256,
		// Token: 0x04000B34 RID: 2868
		AllowHexSpecifier = 512,
		// Token: 0x04000B35 RID: 2869
		AllowBinarySpecifier = 1024,
		// Token: 0x04000B36 RID: 2870
		Integer = 7,
		// Token: 0x04000B37 RID: 2871
		HexNumber = 515,
		// Token: 0x04000B38 RID: 2872
		BinaryNumber = 1027,
		// Token: 0x04000B39 RID: 2873
		Number = 111,
		// Token: 0x04000B3A RID: 2874
		Float = 167,
		// Token: 0x04000B3B RID: 2875
		Currency = 383,
		// Token: 0x04000B3C RID: 2876
		Any = 511
	}
}
