using System;

// Token: 0x020008AA RID: 2218
public class PinballLevelScoreData : IPinballLevelScoreData
{
	// Token: 0x17000C4F RID: 3151
	// (get) Token: 0x06006412 RID: 25618 RVA: 0x001FB634 File Offset: 0x001F9834
	// (set) Token: 0x06006413 RID: 25619 RVA: 0x001FB63C File Offset: 0x001F983C
	public int CurScore { get; set; }

	// Token: 0x17000C50 RID: 3152
	// (get) Token: 0x06006414 RID: 25620 RVA: 0x001FB645 File Offset: 0x001F9845
	// (set) Token: 0x06006415 RID: 25621 RVA: 0x001FB64D File Offset: 0x001F984D
	public int ConfigScore { get; set; }

	// Token: 0x17000C51 RID: 3153
	// (get) Token: 0x06006416 RID: 25622 RVA: 0x001FB656 File Offset: 0x001F9856
	// (set) Token: 0x06006417 RID: 25623 RVA: 0x001FB65E File Offset: 0x001F985E
	public int ConfigDropId { get; set; }
}
