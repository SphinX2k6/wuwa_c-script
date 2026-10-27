using System;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02004534 RID: 17716
	[Flags]
	public enum EWaitEntityPreloadResult
	{
		// Token: 0x0401871C RID: 100124
		None = 0,
		// Token: 0x0401871D RID: 100125
		Fail = 1,
		// Token: 0x0401871E RID: 100126
		Timeout = 2,
		// Token: 0x0401871F RID: 100127
		Cancel = 4,
		// Token: 0x04018720 RID: 100128
		Finished = 8
	}
}
