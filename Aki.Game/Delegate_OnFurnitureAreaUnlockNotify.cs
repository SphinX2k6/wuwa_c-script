using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000CF4 RID: 3316
// (Invoke) Token: 0x06005030 RID: 20528
[EventRule(EEventName.OnFurnitureAreaUnlockNotify)]
internal delegate void Delegate_OnFurnitureAreaUnlockNotify(int handleId, IReadOnlyList<AreaInfo> areaIds);
