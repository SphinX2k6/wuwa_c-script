using System;

// Token: 0x02002B93 RID: 11155
public class SurvivorsRogueItemCard : SurvivorsRogueCardBaseData, ISurvivorsRogueItemCard, ISurvivorsRogueCardBase, ISurvivorsHandbookItemDataBase
{
	// Token: 0x060171E5 RID: 94693 RVA: 0x005DCB28 File Offset: 0x005DAD28
	public SurvivorsRogueItemCard()
	{
		base.Type = ESurvivorsRogueItemType.Normal;
	}

	// Token: 0x17001F16 RID: 7958
	// (get) Token: 0x060171E6 RID: 94694 RVA: 0x005DCB37 File Offset: 0x005DAD37
	// (set) Token: 0x060171E7 RID: 94695 RVA: 0x005DCB3F File Offset: 0x005DAD3F
	public bool? IsNew { get; set; }
}
