using System;
using System.Collections.Generic;

// Token: 0x02000659 RID: 1625
// (Invoke) Token: 0x060035C4 RID: 13764
[EventRule(EEventName.OnAggroAdd)]
internal delegate void Delegate_OnAggroAdd(IReadOnlyList<int> entityIds);
