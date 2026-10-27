using System;

// Token: 0x02002E51 RID: 11857
// (Invoke) Token: 0x060194B2 RID: 103602
[AbilityEventRule(EAbilityEventName.BuffStackInstigatorChanged)]
internal delegate void Delegate_Ability_BuffStackInstigatorChanged(long buffId, int oldStack, int newStack, Entity victim, Entity attacker);
