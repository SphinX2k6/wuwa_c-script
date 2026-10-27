using System;
using Aki.Protocol;

// Token: 0x02000DB1 RID: 3505
// (Invoke) Token: 0x06005324 RID: 21284
[EventRule(EEventName.OnGiantStableValueChange)]
internal delegate void Delegate_OnGiantStableValueChange(GiantEcoNetType? ecology, double oldVal, double newVal);
