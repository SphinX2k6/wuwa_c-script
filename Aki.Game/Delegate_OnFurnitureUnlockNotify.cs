using System;
using System.Collections.Generic;

// Token: 0x02000CF5 RID: 3317
// (Invoke) Token: 0x06005034 RID: 20532
[EventRule(EEventName.OnFurnitureUnlockNotify)]
internal delegate void Delegate_OnFurnitureUnlockNotify(int handleId, IReadOnlyList<int> furnitureIds);
