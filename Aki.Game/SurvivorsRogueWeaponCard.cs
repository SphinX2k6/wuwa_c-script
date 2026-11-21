using System;

// Token: 0x0200210D RID: 8461
public class SurvivorsRogueWeaponCard : SurvivorsRogueCardBaseData, ISurvivorsRogueWeaponCard, ISurvivorsRogueCardBase
{
	// Token: 0x06014C0C RID: 85004 RVA: 0x006096C6 File Offset: 0x006078C6
	public SurvivorsRogueWeaponCard()
	{
		base.Type = ESurvivorsRogueItemType.Weapon;
	}

	// Token: 0x17001F68 RID: 8040
	// (get) Token: 0x06014C0D RID: 85005 RVA: 0x006096D5 File Offset: 0x006078D5
	// (set) Token: 0x06014C0E RID: 85006 RVA: 0x006096DD File Offset: 0x006078DD
	public int? PropertyId { get; set; }

	// Token: 0x17001F69 RID: 8041
	// (get) Token: 0x06014C0F RID: 85007 RVA: 0x006096E6 File Offset: 0x006078E6
	// (set) Token: 0x06014C10 RID: 85008 RVA: 0x006096EE File Offset: 0x006078EE
	public int? LvUpCount { get; set; }

	// Token: 0x17001F6A RID: 8042
	// (get) Token: 0x06014C11 RID: 85009 RVA: 0x006096F7 File Offset: 0x006078F7
	// (set) Token: 0x06014C12 RID: 85010 RVA: 0x006096FF File Offset: 0x006078FF
	public bool? WeaponBondInfo { get; set; }
}
