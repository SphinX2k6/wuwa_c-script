using System;

// Token: 0x0200271A RID: 10010
public interface IRacingBetsMatchTableDangoItemData
{
	// Token: 0x17001AE8 RID: 6888
	// (get) Token: 0x06014836 RID: 84022
	// (set) Token: 0x06014837 RID: 84023
	int DangoId { get; set; }

	// Token: 0x17001AE9 RID: 6889
	// (get) Token: 0x06014838 RID: 84024
	// (set) Token: 0x06014839 RID: 84025
	bool IsNeedCheer { get; set; }

	// Token: 0x17001AEA RID: 6890
	// (get) Token: 0x0601483A RID: 84026
	// (set) Token: 0x0601483B RID: 84027
	bool IsMatchFinished { get; set; }

	// Token: 0x17001AEB RID: 6891
	// (get) Token: 0x0601483C RID: 84028
	// (set) Token: 0x0601483D RID: 84029
	bool IsPromote { get; set; }

	// Token: 0x17001AEC RID: 6892
	// (get) Token: 0x0601483E RID: 84030
	// (set) Token: 0x0601483F RID: 84031
	bool IsNeedPlayLevelSequence { get; set; }

	// Token: 0x17001AED RID: 6893
	// (get) Token: 0x06014840 RID: 84032
	// (set) Token: 0x06014841 RID: 84033
	bool IsCurMatch { get; set; }
}
