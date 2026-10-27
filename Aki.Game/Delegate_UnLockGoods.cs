using System;
using System.Collections.Generic;

// Token: 0x02000617 RID: 1559
// (Invoke) Token: 0x060034BC RID: 13500
[EventRule(EEventName.UnLockGoods)]
internal delegate void Delegate_UnLockGoods(IReadOnlyDictionary<int, HashSet<int>> payShopMap);
