using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007CD RID: 1997
	public enum OperandType
	{
		// Token: 0x04001A82 RID: 6786
		InlineBrTarget,
		// Token: 0x04001A83 RID: 6787
		InlineField,
		// Token: 0x04001A84 RID: 6788
		InlineI,
		// Token: 0x04001A85 RID: 6789
		InlineI8,
		// Token: 0x04001A86 RID: 6790
		InlineMethod,
		// Token: 0x04001A87 RID: 6791
		InlineNone,
		// Token: 0x04001A88 RID: 6792
		[Obsolete("OperandType.InlinePhi has been deprecated and is not supported.")]
		InlinePhi,
		// Token: 0x04001A89 RID: 6793
		InlineR,
		// Token: 0x04001A8A RID: 6794
		InlineSig = 9,
		// Token: 0x04001A8B RID: 6795
		InlineString,
		// Token: 0x04001A8C RID: 6796
		InlineSwitch,
		// Token: 0x04001A8D RID: 6797
		InlineTok,
		// Token: 0x04001A8E RID: 6798
		InlineType,
		// Token: 0x04001A8F RID: 6799
		InlineVar,
		// Token: 0x04001A90 RID: 6800
		ShortInlineBrTarget,
		// Token: 0x04001A91 RID: 6801
		ShortInlineI,
		// Token: 0x04001A92 RID: 6802
		ShortInlineR,
		// Token: 0x04001A93 RID: 6803
		ShortInlineVar
	}
}
