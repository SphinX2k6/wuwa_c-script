using System;

// Token: 0x02002878 RID: 10360
public interface ILevelLayoutGridData
{
	// Token: 0x17001C6C RID: 7276
	// (get) Token: 0x06015517 RID: 87319
	// (set) Token: 0x06015518 RID: 87320
	bool IsChosen { get; set; }

	// Token: 0x17001C6D RID: 7277
	// (get) Token: 0x06015519 RID: 87321
	// (set) Token: 0x0601551A RID: 87322
	bool IsAvailable { get; set; }

	// Token: 0x17001C6E RID: 7278
	// (get) Token: 0x0601551B RID: 87323
	// (set) Token: 0x0601551C RID: 87324
	int LevelContent { get; set; }
}
