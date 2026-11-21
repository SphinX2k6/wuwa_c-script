using System;

namespace System.Reflection
{
	// Token: 0x0200070C RID: 1804
	[Flags]
	internal enum PInvokeAttributes
	{
		// Token: 0x0400158E RID: 5518
		NoMangle = 1,
		// Token: 0x0400158F RID: 5519
		CharSetMask = 6,
		// Token: 0x04001590 RID: 5520
		CharSetNotSpec = 0,
		// Token: 0x04001591 RID: 5521
		CharSetAnsi = 2,
		// Token: 0x04001592 RID: 5522
		CharSetUnicode = 4,
		// Token: 0x04001593 RID: 5523
		CharSetAuto = 6,
		// Token: 0x04001594 RID: 5524
		BestFitUseAssem = 0,
		// Token: 0x04001595 RID: 5525
		BestFitEnabled = 16,
		// Token: 0x04001596 RID: 5526
		BestFitDisabled = 32,
		// Token: 0x04001597 RID: 5527
		BestFitMask = 48,
		// Token: 0x04001598 RID: 5528
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x04001599 RID: 5529
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x0400159A RID: 5530
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x0400159B RID: 5531
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x0400159C RID: 5532
		SupportsLastError = 64,
		// Token: 0x0400159D RID: 5533
		CallConvMask = 1792,
		// Token: 0x0400159E RID: 5534
		CallConvWinapi = 256,
		// Token: 0x0400159F RID: 5535
		CallConvCdecl = 512,
		// Token: 0x040015A0 RID: 5536
		CallConvStdcall = 768,
		// Token: 0x040015A1 RID: 5537
		CallConvThiscall = 1024,
		// Token: 0x040015A2 RID: 5538
		CallConvFastcall = 1280,
		// Token: 0x040015A3 RID: 5539
		MaxValue = 65535
	}
}
