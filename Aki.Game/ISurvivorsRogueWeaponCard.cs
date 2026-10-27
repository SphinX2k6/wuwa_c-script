using System;

// Token: 0x02002B90 RID: 11152
public interface ISurvivorsRogueWeaponCard : ISurvivorsRogueCardBase
{
	// Token: 0x17001F0B RID: 7947
	// (get) Token: 0x060171D6 RID: 94678
	ESurvivorsRogueItemType Type { get; }

	// Token: 0x17001F0C RID: 7948
	// (get) Token: 0x060171D7 RID: 94679
	int Id { get; }

	// Token: 0x17001F0D RID: 7949
	// (get) Token: 0x060171D8 RID: 94680
	int? PropertyId { get; }

	// Token: 0x17001F0E RID: 7950
	// (get) Token: 0x060171D9 RID: 94681
	int? LvUpCount { get; }

	// Token: 0x17001F0F RID: 7951
	// (get) Token: 0x060171DA RID: 94682
	bool? WeaponBondInfo { get; }
}
