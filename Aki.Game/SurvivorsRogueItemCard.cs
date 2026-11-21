using System;

// Token: 0x0200210F RID: 8463
public class SurvivorsRogueItemCard : SurvivorsRogueCardBaseData, ISurvivorsRogueItemCard, ISurvivorsRogueCardBase, ISurvivorsHandbookItemDataBase
{
	// Token: 0x06014C16 RID: 85014 RVA: 0x00609708 File Offset: 0x00607908
	public SurvivorsRogueItemCard()
	{
		base.Type = ESurvivorsRogueItemType.Normal;
	}

	// Token: 0x17001F6E RID: 8046
	// (get) Token: 0x06014C17 RID: 85015 RVA: 0x00609717 File Offset: 0x00607917
	// (set) Token: 0x06014C18 RID: 85016 RVA: 0x0060971F File Offset: 0x0060791F
	public bool? IsNew { get; set; }
}
