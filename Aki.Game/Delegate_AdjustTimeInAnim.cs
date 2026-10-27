using System;

// Token: 0x02000522 RID: 1314
// (Invoke) Token: 0x060030E8 RID: 12520
[EventRule(EEventName.AdjustTimeInAnim)]
internal delegate void Delegate_AdjustTimeInAnim(double curSecond, double setSecond, Action callback);
