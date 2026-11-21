using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004BC RID: 1212
	[Flags]
	internal enum InternalTaskOptions
	{
		// Token: 0x04001064 RID: 4196
		None = 0,
		// Token: 0x04001065 RID: 4197
		InternalOptionsMask = 65280,
		// Token: 0x04001066 RID: 4198
		ContinuationTask = 512,
		// Token: 0x04001067 RID: 4199
		PromiseTask = 1024,
		// Token: 0x04001068 RID: 4200
		HiddenState = 2048,
		// Token: 0x04001069 RID: 4201
		LazyCancellation = 4096,
		// Token: 0x0400106A RID: 4202
		QueuedByRuntime = 8192,
		// Token: 0x0400106B RID: 4203
		DoNotDispose = 16384
	}
}
