using System;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x0200345C RID: 13404
	[Flags]
	public enum EWaitEntityPreloadResult
	{
		// Token: 0x04012D4F RID: 77135
		None = 0,
		// Token: 0x04012D50 RID: 77136
		Fail = 1,
		// Token: 0x04012D51 RID: 77137
		Timeout = 2,
		// Token: 0x04012D52 RID: 77138
		Cancel = 4,
		// Token: 0x04012D53 RID: 77139
		Finished = 8
	}
}
