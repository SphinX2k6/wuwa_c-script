using System;

// Token: 0x02001DF4 RID: 7668
public class LevelLayoutGridData : ILevelLayoutGridData
{
	// Token: 0x17001CC7 RID: 7367
	// (get) Token: 0x06012F1B RID: 77595 RVA: 0x0058D2ED File Offset: 0x0058B4ED
	// (set) Token: 0x06012F1C RID: 77596 RVA: 0x0058D2F5 File Offset: 0x0058B4F5
	public bool IsChosen { get; set; }

	// Token: 0x17001CC8 RID: 7368
	// (get) Token: 0x06012F1D RID: 77597 RVA: 0x0058D2FE File Offset: 0x0058B4FE
	// (set) Token: 0x06012F1E RID: 77598 RVA: 0x0058D306 File Offset: 0x0058B506
	public bool IsAvailable { get; set; }

	// Token: 0x17001CC9 RID: 7369
	// (get) Token: 0x06012F1F RID: 77599 RVA: 0x0058D30F File Offset: 0x0058B50F
	// (set) Token: 0x06012F20 RID: 77600 RVA: 0x0058D317 File Offset: 0x0058B517
	public int LevelContent { get; set; }
}
