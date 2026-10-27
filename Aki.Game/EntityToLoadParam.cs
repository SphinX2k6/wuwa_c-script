using System;
using System.Runtime.CompilerServices;

// Token: 0x020034BE RID: 13502
[NullableContext(1)]
[Nullable(0)]
public class EntityToLoadParam : IEntityToLoadParam
{
	// Token: 0x170028CE RID: 10446
	// (get) Token: 0x0601D67A RID: 120442 RVA: 0x00833FB2 File Offset: 0x008321B2
	// (set) Token: 0x0601D67B RID: 120443 RVA: 0x00833FBA File Offset: 0x008321BA
	public long MaxLoadingCount { get; set; } = 4L;

	// Token: 0x170028CF RID: 10447
	// (get) Token: 0x0601D67C RID: 120444 RVA: 0x00833FC3 File Offset: 0x008321C3
	// (set) Token: 0x0601D67D RID: 120445 RVA: 0x00833FCB File Offset: 0x008321CB
	public long LoadingInterval { get; set; }

	// Token: 0x170028D0 RID: 10448
	// (get) Token: 0x0601D67E RID: 120446 RVA: 0x00833FD4 File Offset: 0x008321D4
	// (set) Token: 0x0601D67F RID: 120447 RVA: 0x00833FDC File Offset: 0x008321DC
	public string MaxLoadingDebugName { get; set; } = "MAX_LOADING_ENTITY_COUNT";

	// Token: 0x170028D1 RID: 10449
	// (get) Token: 0x0601D680 RID: 120448 RVA: 0x00833FE5 File Offset: 0x008321E5
	// (set) Token: 0x0601D681 RID: 120449 RVA: 0x00833FED File Offset: 0x008321ED
	public string LoadingIntervalDebugName { get; set; } = "LOADING_INTERVAL";

	// Token: 0x0601D682 RID: 120450 RVA: 0x00833FF6 File Offset: 0x008321F6
	public EntityToLoadParam()
	{
	}

	// Token: 0x0601D683 RID: 120451 RVA: 0x0083401C File Offset: 0x0083221C
	[NullableContext(2)]
	public EntityToLoadParam(IEntityToLoadParam entityToLoadParam = null, long? maxLoadingCount = null, long? loadingInterval = null, string maxLoadingDebugName = null, string loadingIntervalDebugName = null)
	{
		if (entityToLoadParam != null)
		{
			this.MaxLoadingCount = entityToLoadParam.MaxLoadingCount;
			this.LoadingInterval = entityToLoadParam.LoadingInterval;
			this.MaxLoadingDebugName = entityToLoadParam.MaxLoadingDebugName;
			this.LoadingIntervalDebugName = entityToLoadParam.LoadingIntervalDebugName;
			return;
		}
		this.MaxLoadingCount = (maxLoadingCount ?? this.MaxLoadingCount);
		this.LoadingInterval = (loadingInterval ?? this.LoadingInterval);
		this.MaxLoadingDebugName = (maxLoadingDebugName ?? this.MaxLoadingDebugName);
		this.LoadingIntervalDebugName = (loadingIntervalDebugName ?? this.LoadingIntervalDebugName);
	}
}
