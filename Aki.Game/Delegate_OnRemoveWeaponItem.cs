using System;
using System.Collections.Generic;

// Token: 0x020006A1 RID: 1697
// (Invoke) Token: 0x060036E4 RID: 14052
[EventRule(EEventName.OnRemoveWeaponItem)]
internal delegate void Delegate_OnRemoveWeaponItem(IReadOnlyList<int> uniqueIdList);
