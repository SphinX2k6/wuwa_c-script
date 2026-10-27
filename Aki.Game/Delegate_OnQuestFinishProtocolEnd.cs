using System;
using System.Collections.Generic;

// Token: 0x02000574 RID: 1396
// (Invoke) Token: 0x06003230 RID: 12848
[EventRule(EEventName.OnQuestFinishProtocolEnd)]
internal delegate void Delegate_OnQuestFinishProtocolEnd(IReadOnlyList<int> questIds);
