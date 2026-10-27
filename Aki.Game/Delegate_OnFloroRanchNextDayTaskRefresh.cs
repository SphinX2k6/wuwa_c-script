using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000A43 RID: 2627
// (Invoke) Token: 0x0600456C RID: 17772
[EventRule(EEventName.OnFloroRanchNextDayTaskRefresh)]
internal delegate void Delegate_OnFloroRanchNextDayTaskRefresh(IReadOnlyList<FloroRanchPlayTask> taskList);
