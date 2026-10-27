using System;
using CSharpScript.Game.AI.StateMachine;

// Token: 0x020002B6 RID: 694
// (Invoke) Token: 0x06002738 RID: 10040
[EventRule(EEventName.ConditionDrivenSMTickLock)]
internal delegate void Delegate_ConditionDrivenSMTickLock(bool isLock, EConditionDrivenSmTickReason reason);
