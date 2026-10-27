using System;
using UnrealEngine;

// Token: 0x02000CDF RID: 3295
// (Invoke) Token: 0x06004FDC RID: 20444
[EventRule(EEventName.MotorSubStateModeChange)]
internal delegate void Delegate_MotorSubStateModeChange(EMotorSubState oldState, EMotorSubState newState);
