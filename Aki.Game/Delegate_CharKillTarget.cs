using System;
using UnrealEngine;

// Token: 0x020002D1 RID: 721
// (Invoke) Token: 0x060027A4 RID: 10148
[EventRule(EEventName.CharKillTarget)]
internal delegate void Delegate_CharKillTarget(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition);
