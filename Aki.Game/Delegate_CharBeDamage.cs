using System;
using UnrealEngine;

// Token: 0x020002D3 RID: 723
// (Invoke) Token: 0x060027AC RID: 10156
[EventRule(EEventName.CharBeDamage)]
internal delegate void Delegate_CharBeDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition);
