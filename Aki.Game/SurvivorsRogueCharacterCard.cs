using System;

// Token: 0x02002B8F RID: 11151
public class SurvivorsRogueCharacterCard : SurvivorsRogueCardBaseData, ISurvivorsRogueCharacterCard, ISurvivorsRogueCardBase
{
	// Token: 0x060171D1 RID: 94673 RVA: 0x005DCAB5 File Offset: 0x005DACB5
	public SurvivorsRogueCharacterCard()
	{
		base.Type = ESurvivorsRogueItemType.Character;
	}

	// Token: 0x17001F09 RID: 7945
	// (get) Token: 0x060171D2 RID: 94674 RVA: 0x005DCAC4 File Offset: 0x005DACC4
	// (set) Token: 0x060171D3 RID: 94675 RVA: 0x005DCACC File Offset: 0x005DACCC
	public int? PropertyId { get; set; }

	// Token: 0x17001F0A RID: 7946
	// (get) Token: 0x060171D4 RID: 94676 RVA: 0x005DCAD5 File Offset: 0x005DACD5
	// (set) Token: 0x060171D5 RID: 94677 RVA: 0x005DCADD File Offset: 0x005DACDD
	public int? LvUpCount { get; set; }
}
