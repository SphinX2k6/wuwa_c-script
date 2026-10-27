using System;
using UnrealEngine;

// Token: 0x020002D2 RID: 722
// (Invoke) Token: 0x060027A8 RID: 10152
[EventRule(EEventName.CharBeKilled)]
internal delegate void Delegate_CharBeKilled(Entity attacker, Entity victim, RequirementPayload requirements, DamageResult damageResult, FVectorDouble damagePosition);
