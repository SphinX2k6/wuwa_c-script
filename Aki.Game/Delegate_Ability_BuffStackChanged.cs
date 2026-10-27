using System;

// Token: 0x02002E50 RID: 11856
// (Invoke) Token: 0x060194AE RID: 103598
[AbilityEventRule(EAbilityEventName.BuffStackChanged)]
internal delegate void Delegate_Ability_BuffStackChanged(long buffId, int oldStack, int newStack, Entity victim);
