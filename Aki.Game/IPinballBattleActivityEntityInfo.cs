using System;

// Token: 0x02000EA6 RID: 3750
public interface IPinballBattleActivityEntityInfo : IPinballBattleCombatInfo, IPinballBattleConfigInfo
{
	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x06005C72 RID: 23666
	// (set) Token: 0x06005C73 RID: 23667
	int ConfigId { get; set; }

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x06005C74 RID: 23668
	// (set) Token: 0x06005C75 RID: 23669
	EPinballBattleMonsterDeathType DeathType { get; set; }
}
