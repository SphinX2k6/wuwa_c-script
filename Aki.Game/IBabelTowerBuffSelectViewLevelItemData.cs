using System;

// Token: 0x020005CC RID: 1484
public interface IBabelTowerBuffSelectViewLevelItemData
{
	// Token: 0x170009CB RID: 2507
	// (get) Token: 0x0600461A RID: 17946
	// (set) Token: 0x0600461B RID: 17947
	int LevelId { get; set; }

	// Token: 0x170009CC RID: 2508
	// (get) Token: 0x0600461C RID: 17948
	// (set) Token: 0x0600461D RID: 17949
	int BuffId { get; set; }

	// Token: 0x170009CD RID: 2509
	// (get) Token: 0x0600461E RID: 17950
	// (set) Token: 0x0600461F RID: 17951
	EBabelTowerBuffState State { get; set; }
}
