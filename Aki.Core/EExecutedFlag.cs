using System;

// Token: 0x02000072 RID: 114
[Flags]
public enum EExecutedFlag
{
	// Token: 0x0400033E RID: 830
	None = 0,
	// Token: 0x0400033F RID: 831
	Create = 1,
	// Token: 0x04000340 RID: 832
	InitData = 2,
	// Token: 0x04000341 RID: 833
	Init = 4,
	// Token: 0x04000342 RID: 834
	Start = 8,
	// Token: 0x04000343 RID: 835
	Activate = 16,
	// Token: 0x04000344 RID: 836
	PostActivate = 32,
	// Token: 0x04000345 RID: 837
	End = 64,
	// Token: 0x04000346 RID: 838
	Clear = 128
}
