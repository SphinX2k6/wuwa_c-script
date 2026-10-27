using System;
using System.Collections.Generic;

// Token: 0x020008E3 RID: 2275
// (Invoke) Token: 0x06003FEC RID: 16364
[EventRule(EEventName.OnSignalDeviceLinkingCheck)]
internal delegate void Delegate_OnSignalDeviceLinkingCheck(bool result, IReadOnlyList<int> indexArray);
