using System;

// Token: 0x02002E52 RID: 11858
// (Invoke) Token: 0x060194B6 RID: 103606
[AbilityEventRule(EAbilityEventName.AddBuffToOthers)]
internal delegate void Delegate_Ability_AddBuffToOthers(long buffId, Entity victim, Entity attacker, bool? bornBuff);
