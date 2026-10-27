using System;
using System.Runtime.CompilerServices;

// Token: 0x020002D8 RID: 728
// (Invoke) Token: 0x060027C0 RID: 10176
[EventRule(EEventName.OnBuffTriggerEvent)]
internal delegate void Delegate_OnBuffTriggerEvent(EBuffTriggerType passiveEffectType, [Nullable(2)] BaseBuffComponent opponentBuffComp, Partial_RequirementPayload payload);
