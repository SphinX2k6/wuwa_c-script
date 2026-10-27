using System;
using System.Collections.Generic;

// Token: 0x02000399 RID: 921
// (Invoke) Token: 0x06002AC4 RID: 10948
[EventRule(EEventName.RoleRefreshAttribute)]
internal delegate void Delegate_RoleRefreshAttribute(IReadOnlyDictionary<int, int> baseAttr, IReadOnlyDictionary<int, int> addAttr);
