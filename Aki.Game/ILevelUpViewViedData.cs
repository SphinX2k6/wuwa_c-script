using System;

// Token: 0x02002067 RID: 8295
public interface ILevelUpViewViedData
{
	// Token: 0x1700141E RID: 5150
	// (get) Token: 0x0601053A RID: 66874
	// (set) Token: 0x0601053B RID: 66875
	bool AddExp { get; set; }

	// Token: 0x1700141F RID: 5151
	// (get) Token: 0x0601053C RID: 66876
	// (set) Token: 0x0601053D RID: 66877
	int PreLevel { get; set; }

	// Token: 0x17001420 RID: 5152
	// (get) Token: 0x0601053E RID: 66878
	// (set) Token: 0x0601053F RID: 66879
	int PreExp { get; set; }

	// Token: 0x17001421 RID: 5153
	// (get) Token: 0x06010540 RID: 66880
	// (set) Token: 0x06010541 RID: 66881
	int CurLevel { get; set; }

	// Token: 0x17001422 RID: 5154
	// (get) Token: 0x06010542 RID: 66882
	// (set) Token: 0x06010543 RID: 66883
	int CurExp { get; set; }
}
