using System;

// Token: 0x02001C05 RID: 7173
public interface IRacingBetsMatchTableDangoItemData
{
	// Token: 0x17001B20 RID: 6944
	// (get) Token: 0x06011D18 RID: 72984
	// (set) Token: 0x06011D19 RID: 72985
	int DangoId { get; set; }

	// Token: 0x17001B21 RID: 6945
	// (get) Token: 0x06011D1A RID: 72986
	// (set) Token: 0x06011D1B RID: 72987
	bool IsNeedCheer { get; set; }

	// Token: 0x17001B22 RID: 6946
	// (get) Token: 0x06011D1C RID: 72988
	// (set) Token: 0x06011D1D RID: 72989
	bool IsMatchFinished { get; set; }

	// Token: 0x17001B23 RID: 6947
	// (get) Token: 0x06011D1E RID: 72990
	// (set) Token: 0x06011D1F RID: 72991
	bool IsPromote { get; set; }

	// Token: 0x17001B24 RID: 6948
	// (get) Token: 0x06011D20 RID: 72992
	// (set) Token: 0x06011D21 RID: 72993
	bool IsNeedPlayLevelSequence { get; set; }

	// Token: 0x17001B25 RID: 6949
	// (get) Token: 0x06011D22 RID: 72994
	// (set) Token: 0x06011D23 RID: 72995
	bool IsCurMatch { get; set; }
}
