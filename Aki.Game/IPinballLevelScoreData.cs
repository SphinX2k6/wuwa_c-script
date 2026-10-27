using System;

// Token: 0x020013F3 RID: 5107
public interface IPinballLevelScoreData
{
	// Token: 0x17000C1B RID: 3099
	// (get) Token: 0x06009053 RID: 36947
	// (set) Token: 0x06009054 RID: 36948
	int CurScore { get; set; }

	// Token: 0x17000C1C RID: 3100
	// (get) Token: 0x06009055 RID: 36949
	// (set) Token: 0x06009056 RID: 36950
	int ConfigScore { get; set; }

	// Token: 0x17000C1D RID: 3101
	// (get) Token: 0x06009057 RID: 36951
	// (set) Token: 0x06009058 RID: 36952
	int ConfigDropId { get; set; }
}
