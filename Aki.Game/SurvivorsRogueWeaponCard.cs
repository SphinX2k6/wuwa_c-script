using System;

// Token: 0x02002B91 RID: 11153
public class SurvivorsRogueWeaponCard : SurvivorsRogueCardBaseData, ISurvivorsRogueWeaponCard, ISurvivorsRogueCardBase
{
	// Token: 0x060171DB RID: 94683 RVA: 0x005DCAE6 File Offset: 0x005DACE6
	public SurvivorsRogueWeaponCard()
	{
		base.Type = ESurvivorsRogueItemType.Weapon;
	}

	// Token: 0x17001F10 RID: 7952
	// (get) Token: 0x060171DC RID: 94684 RVA: 0x005DCAF5 File Offset: 0x005DACF5
	// (set) Token: 0x060171DD RID: 94685 RVA: 0x005DCAFD File Offset: 0x005DACFD
	public int? PropertyId { get; set; }

	// Token: 0x17001F11 RID: 7953
	// (get) Token: 0x060171DE RID: 94686 RVA: 0x005DCB06 File Offset: 0x005DAD06
	// (set) Token: 0x060171DF RID: 94687 RVA: 0x005DCB0E File Offset: 0x005DAD0E
	public int? LvUpCount { get; set; }

	// Token: 0x17001F12 RID: 7954
	// (get) Token: 0x060171E0 RID: 94688 RVA: 0x005DCB17 File Offset: 0x005DAD17
	// (set) Token: 0x060171E1 RID: 94689 RVA: 0x005DCB1F File Offset: 0x005DAD1F
	public bool? WeaponBondInfo { get; set; }
}
