using System;
using System.Collections.Generic;

// Token: 0x020007EB RID: 2027
// (Invoke) Token: 0x06003C0C RID: 15372
[EventRule(EEventName.OnActivityClose)]
internal delegate void Delegate_OnActivityClose(IReadOnlySet<int> closeActivities);
