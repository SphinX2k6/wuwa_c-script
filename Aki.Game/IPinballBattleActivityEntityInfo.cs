using System;

// Token: 0x0200035B RID: 859
public interface IPinballBattleActivityEntityInfo : IPinballBattleCombatInfo, IPinballBattleConfigInfo
{
	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x06003009 RID: 12297
	// (set) Token: 0x0600300A RID: 12298
	int ConfigId { get; set; }

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x0600300B RID: 12299
	// (set) Token: 0x0600300C RID: 12300
	EPinballBattleMonsterDeathType DeathType { get; set; }
}
