using System;

// Token: 0x020005E2 RID: 1506
public interface IBabelTowerBuffInfo
{
	// Token: 0x170009E7 RID: 2535
	// (get) Token: 0x060046F7 RID: 18167
	// (set) Token: 0x060046F8 RID: 18168
	int Id { get; set; }

	// Token: 0x170009E8 RID: 2536
	// (get) Token: 0x060046F9 RID: 18169
	// (set) Token: 0x060046FA RID: 18170
	EBabelTowerBuffState State { get; set; }

	// Token: 0x170009E9 RID: 2537
	// (get) Token: 0x060046FB RID: 18171
	// (set) Token: 0x060046FC RID: 18172
	int? LevelId { get; set; }

	// Token: 0x170009EA RID: 2538
	// (get) Token: 0x060046FD RID: 18173
	// (set) Token: 0x060046FE RID: 18174
	bool IsRecommend { get; set; }
}
