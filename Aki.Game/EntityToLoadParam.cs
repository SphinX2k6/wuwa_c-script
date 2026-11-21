using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A32 RID: 10802
[NullableContext(1)]
[Nullable(0)]
public class EntityToLoadParam : IEntityToLoadParam
{
	// Token: 0x17002C66 RID: 11366
	// (get) Token: 0x0601B379 RID: 111481 RVA: 0x0085B45A File Offset: 0x0085965A
	// (set) Token: 0x0601B37A RID: 111482 RVA: 0x0085B462 File Offset: 0x00859662
	public long MaxLoadingCount { get; set; } = 4L;

	// Token: 0x17002C67 RID: 11367
	// (get) Token: 0x0601B37B RID: 111483 RVA: 0x0085B46B File Offset: 0x0085966B
	// (set) Token: 0x0601B37C RID: 111484 RVA: 0x0085B473 File Offset: 0x00859673
	public long LoadingInterval { get; set; }

	// Token: 0x17002C68 RID: 11368
	// (get) Token: 0x0601B37D RID: 111485 RVA: 0x0085B47C File Offset: 0x0085967C
	// (set) Token: 0x0601B37E RID: 111486 RVA: 0x0085B484 File Offset: 0x00859684
	public string MaxLoadingDebugName { get; set; } = "MAX_LOADING_ENTITY_COUNT";

	// Token: 0x17002C69 RID: 11369
	// (get) Token: 0x0601B37F RID: 111487 RVA: 0x0085B48D File Offset: 0x0085968D
	// (set) Token: 0x0601B380 RID: 111488 RVA: 0x0085B495 File Offset: 0x00859695
	public string LoadingIntervalDebugName { get; set; } = "LOADING_INTERVAL";

	// Token: 0x0601B381 RID: 111489 RVA: 0x0085B49E File Offset: 0x0085969E
	public EntityToLoadParam()
	{
	}

	// Token: 0x0601B382 RID: 111490 RVA: 0x0085B4C4 File Offset: 0x008596C4
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
