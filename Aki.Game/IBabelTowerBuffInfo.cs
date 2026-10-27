using System;

// Token: 0x0200112E RID: 4398
public interface IBabelTowerBuffInfo
{
	// Token: 0x170009C7 RID: 2503
	// (get) Token: 0x06007360 RID: 29536
	// (set) Token: 0x06007361 RID: 29537
	int Id { get; set; }

	// Token: 0x170009C8 RID: 2504
	// (get) Token: 0x06007362 RID: 29538
	// (set) Token: 0x06007363 RID: 29539
	EBabelTowerBuffState State { get; set; }

	// Token: 0x170009C9 RID: 2505
	// (get) Token: 0x06007364 RID: 29540
	// (set) Token: 0x06007365 RID: 29541
	int? LevelId { get; set; }

	// Token: 0x170009CA RID: 2506
	// (get) Token: 0x06007366 RID: 29542
	// (set) Token: 0x06007367 RID: 29543
	bool IsRecommend { get; set; }
}
