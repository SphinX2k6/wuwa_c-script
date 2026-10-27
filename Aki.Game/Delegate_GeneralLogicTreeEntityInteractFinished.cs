using System;
using System.Collections.Generic;

// Token: 0x0200055C RID: 1372
// (Invoke) Token: 0x060031D0 RID: 12752
[EventRule(EEventName.GeneralLogicTreeEntityInteractFinished)]
internal delegate void Delegate_GeneralLogicTreeEntityInteractFinished(int nodeId, IReadOnlyList<int> entityDataIds);
