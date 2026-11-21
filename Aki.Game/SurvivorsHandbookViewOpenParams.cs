using System;

// Token: 0x02002113 RID: 8467
public class SurvivorsHandbookViewOpenParams : ISurvivorsHandbookViewOpenParams
{
	// Token: 0x17001F77 RID: 8055
	// (get) Token: 0x06014C25 RID: 85029 RVA: 0x00609763 File Offset: 0x00607963
	// (set) Token: 0x06014C26 RID: 85030 RVA: 0x0060976B File Offset: 0x0060796B
	public ESurvivorsRogueItemType SelectTabType { get; set; }

	// Token: 0x17001F78 RID: 8056
	// (get) Token: 0x06014C27 RID: 85031 RVA: 0x00609774 File Offset: 0x00607974
	// (set) Token: 0x06014C28 RID: 85032 RVA: 0x0060977C File Offset: 0x0060797C
	public int? SelectCfgId { get; set; }
}
