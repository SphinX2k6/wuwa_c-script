using System;
using System.Collections.Generic;

// Token: 0x0200065C RID: 1628
// (Invoke) Token: 0x060035D0 RID: 13776
[EventRule(EEventName.OnAggroRemoved)]
internal delegate void Delegate_OnAggroRemoved(IReadOnlyList<int> entityIds);
