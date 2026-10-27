using System;

// Token: 0x02002B97 RID: 11159
public class SurvivorsHandbookViewOpenParams : ISurvivorsHandbookViewOpenParams
{
	// Token: 0x17001F1F RID: 7967
	// (get) Token: 0x060171F4 RID: 94708 RVA: 0x005DCB83 File Offset: 0x005DAD83
	// (set) Token: 0x060171F5 RID: 94709 RVA: 0x005DCB8B File Offset: 0x005DAD8B
	public ESurvivorsRogueItemType SelectTabType { get; set; }

	// Token: 0x17001F20 RID: 7968
	// (get) Token: 0x060171F6 RID: 94710 RVA: 0x005DCB94 File Offset: 0x005DAD94
	// (set) Token: 0x060171F7 RID: 94711 RVA: 0x005DCB9C File Offset: 0x005DAD9C
	public int? SelectCfgId { get; set; }
}
