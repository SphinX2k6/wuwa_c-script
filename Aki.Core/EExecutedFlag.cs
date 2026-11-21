using System;

// Token: 0x02000073 RID: 115
[Flags]
public enum EExecutedFlag
{
	// Token: 0x04000356 RID: 854
	None = 0,
	// Token: 0x04000357 RID: 855
	Create = 1,
	// Token: 0x04000358 RID: 856
	InitData = 2,
	// Token: 0x04000359 RID: 857
	Init = 4,
	// Token: 0x0400035A RID: 858
	Start = 8,
	// Token: 0x0400035B RID: 859
	Activate = 16,
	// Token: 0x0400035C RID: 860
	PostActivate = 32,
	// Token: 0x0400035D RID: 861
	End = 64,
	// Token: 0x0400035E RID: 862
	Clear = 128
}
