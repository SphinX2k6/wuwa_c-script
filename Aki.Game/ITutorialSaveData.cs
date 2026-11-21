using System;

// Token: 0x020021A8 RID: 8616
public interface ITutorialSaveData
{
	// Token: 0x17002013 RID: 8211
	// (get) Token: 0x0601531A RID: 86810
	// (set) Token: 0x0601531B RID: 86811
	int TimeStamp { get; set; }

	// Token: 0x17002014 RID: 8212
	// (get) Token: 0x0601531C RID: 86812
	// (set) Token: 0x0601531D RID: 86813
	int TutorialId { get; set; }

	// Token: 0x17002015 RID: 8213
	// (get) Token: 0x0601531E RID: 86814
	// (set) Token: 0x0601531F RID: 86815
	bool HasRedDot { get; set; }

	// Token: 0x17002016 RID: 8214
	// (get) Token: 0x06015320 RID: 86816
	// (set) Token: 0x06015321 RID: 86817
	bool IsExcludedFromWiki { get; set; }
}
