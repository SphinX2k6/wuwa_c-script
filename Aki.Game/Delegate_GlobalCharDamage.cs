using System;
using UnrealEngine;

// Token: 0x020002D4 RID: 724
// (Invoke) Token: 0x060027B0 RID: 10160
[EventRule(EEventName.GlobalCharDamage)]
internal delegate void Delegate_GlobalCharDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition);
