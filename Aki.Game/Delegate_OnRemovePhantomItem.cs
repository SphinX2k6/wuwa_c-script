using System;
using System.Collections.Generic;

// Token: 0x020006A7 RID: 1703
// (Invoke) Token: 0x060036FC RID: 14076
[EventRule(EEventName.OnRemovePhantomItem)]
internal delegate void Delegate_OnRemovePhantomItem(IReadOnlyList<int> uniqueIdList);
