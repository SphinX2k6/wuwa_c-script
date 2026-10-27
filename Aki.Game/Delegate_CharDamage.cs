using System;
using UnrealEngine;

// Token: 0x020002D0 RID: 720
// (Invoke) Token: 0x060027A0 RID: 10144
[EventRule(EEventName.CharDamage)]
internal delegate void Delegate_CharDamage(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition);
