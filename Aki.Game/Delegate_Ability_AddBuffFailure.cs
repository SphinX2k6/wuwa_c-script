using System;

// Token: 0x02002E53 RID: 11859
// (Invoke) Token: 0x060194BA RID: 103610
[AbilityEventRule(EAbilityEventName.AddBuffFailure)]
internal delegate void Delegate_Ability_AddBuffFailure(long buffId, Entity victim, Entity attacker, int stackCount, long? bulletContextId);
