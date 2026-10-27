using System;
using System.Runtime.CompilerServices;

// Token: 0x020034BC RID: 13500
[NullableContext(1)]
public interface IEntityToLoadParam
{
	// Token: 0x170028C5 RID: 10437
	// (get) Token: 0x0601D669 RID: 120425
	// (set) Token: 0x0601D66A RID: 120426
	long MaxLoadingCount { get; set; }

	// Token: 0x170028C6 RID: 10438
	// (get) Token: 0x0601D66B RID: 120427
	// (set) Token: 0x0601D66C RID: 120428
	long LoadingInterval { get; set; }

	// Token: 0x170028C7 RID: 10439
	// (get) Token: 0x0601D66D RID: 120429
	string MaxLoadingDebugName { get; }

	// Token: 0x170028C8 RID: 10440
	// (get) Token: 0x0601D66E RID: 120430
	string LoadingIntervalDebugName { get; }
}
