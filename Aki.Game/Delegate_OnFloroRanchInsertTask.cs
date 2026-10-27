using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000A44 RID: 2628
// (Invoke) Token: 0x06004570 RID: 17776
[EventRule(EEventName.OnFloroRanchInsertTask)]
internal delegate void Delegate_OnFloroRanchInsertTask(IReadOnlyList<FloroRanchPlayTask> taskList);
