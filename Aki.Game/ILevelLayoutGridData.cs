using System;

// Token: 0x02001DF3 RID: 7667
public interface ILevelLayoutGridData
{
	// Token: 0x17001CC4 RID: 7364
	// (get) Token: 0x06012F15 RID: 77589
	// (set) Token: 0x06012F16 RID: 77590
	bool IsChosen { get; set; }

	// Token: 0x17001CC5 RID: 7365
	// (get) Token: 0x06012F17 RID: 77591
	// (set) Token: 0x06012F18 RID: 77592
	bool IsAvailable { get; set; }

	// Token: 0x17001CC6 RID: 7366
	// (get) Token: 0x06012F19 RID: 77593
	// (set) Token: 0x06012F1A RID: 77594
	int LevelContent { get; set; }
}
