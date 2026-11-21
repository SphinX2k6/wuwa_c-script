using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004BD RID: 1213
	[Flags]
	public enum TaskContinuationOptions
	{
		// Token: 0x0400106D RID: 4205
		None = 0,
		// Token: 0x0400106E RID: 4206
		PreferFairness = 1,
		// Token: 0x0400106F RID: 4207
		LongRunning = 2,
		// Token: 0x04001070 RID: 4208
		AttachedToParent = 4,
		// Token: 0x04001071 RID: 4209
		DenyChildAttach = 8,
		// Token: 0x04001072 RID: 4210
		HideScheduler = 16,
		// Token: 0x04001073 RID: 4211
		LazyCancellation = 32,
		// Token: 0x04001074 RID: 4212
		RunContinuationsAsynchronously = 64,
		// Token: 0x04001075 RID: 4213
		NotOnRanToCompletion = 65536,
		// Token: 0x04001076 RID: 4214
		NotOnFaulted = 131072,
		// Token: 0x04001077 RID: 4215
		NotOnCanceled = 262144,
		// Token: 0x04001078 RID: 4216
		OnlyOnRanToCompletion = 393216,
		// Token: 0x04001079 RID: 4217
		OnlyOnFaulted = 327680,
		// Token: 0x0400107A RID: 4218
		OnlyOnCanceled = 196608,
		// Token: 0x0400107B RID: 4219
		ExecuteSynchronously = 524288
	}
}
