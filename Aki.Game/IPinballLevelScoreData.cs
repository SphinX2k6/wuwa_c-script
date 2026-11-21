using System;

// Token: 0x020008A7 RID: 2215
public interface IPinballLevelScoreData
{
	// Token: 0x17000C3B RID: 3131
	// (get) Token: 0x060063E8 RID: 25576
	// (set) Token: 0x060063E9 RID: 25577
	int CurScore { get; set; }

	// Token: 0x17000C3C RID: 3132
	// (get) Token: 0x060063EA RID: 25578
	// (set) Token: 0x060063EB RID: 25579
	int ConfigScore { get; set; }

	// Token: 0x17000C3D RID: 3133
	// (get) Token: 0x060063EC RID: 25580
	// (set) Token: 0x060063ED RID: 25581
	int ConfigDropId { get; set; }
}
