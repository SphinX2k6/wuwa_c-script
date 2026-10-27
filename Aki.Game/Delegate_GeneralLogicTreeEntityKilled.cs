using System;
using System.Collections.Generic;

// Token: 0x0200055D RID: 1373
// (Invoke) Token: 0x060031D4 RID: 12756
[EventRule(EEventName.GeneralLogicTreeEntityKilled)]
internal delegate void Delegate_GeneralLogicTreeEntityKilled(int nodeId, IReadOnlyList<int> entityDataIds);
