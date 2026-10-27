using System;

// Token: 0x02001118 RID: 4376
public interface IBabelTowerBuffSelectViewLevelItemData
{
	// Token: 0x170009AB RID: 2475
	// (get) Token: 0x06007284 RID: 29316
	// (set) Token: 0x06007285 RID: 29317
	int LevelId { get; set; }

	// Token: 0x170009AC RID: 2476
	// (get) Token: 0x06007286 RID: 29318
	// (set) Token: 0x06007287 RID: 29319
	int BuffId { get; set; }

	// Token: 0x170009AD RID: 2477
	// (get) Token: 0x06007288 RID: 29320
	// (set) Token: 0x06007289 RID: 29321
	EBabelTowerBuffState State { get; set; }
}
