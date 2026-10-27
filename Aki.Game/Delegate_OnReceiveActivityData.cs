using System;
using System.Collections.Generic;

// Token: 0x020007D6 RID: 2006
// (Invoke) Token: 0x06003BB8 RID: 15288
[EventRule(EEventName.OnReceiveActivityData)]
internal delegate void Delegate_OnReceiveActivityData(int type, IReadOnlyList<int> activityIds);
