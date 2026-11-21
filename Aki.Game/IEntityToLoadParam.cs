using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A30 RID: 10800
[NullableContext(1)]
public interface IEntityToLoadParam
{
	// Token: 0x17002C5D RID: 11357
	// (get) Token: 0x0601B368 RID: 111464
	// (set) Token: 0x0601B369 RID: 111465
	long MaxLoadingCount { get; set; }

	// Token: 0x17002C5E RID: 11358
	// (get) Token: 0x0601B36A RID: 111466
	// (set) Token: 0x0601B36B RID: 111467
	long LoadingInterval { get; set; }

	// Token: 0x17002C5F RID: 11359
	// (get) Token: 0x0601B36C RID: 111468
	string MaxLoadingDebugName { get; }

	// Token: 0x17002C60 RID: 11360
	// (get) Token: 0x0601B36D RID: 111469
	string LoadingIntervalDebugName { get; }
}
