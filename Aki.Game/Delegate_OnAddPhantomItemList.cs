using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x020006A4 RID: 1700
// (Invoke) Token: 0x060036F0 RID: 14064
[EventRule(EEventName.OnAddPhantomItemList)]
internal delegate void Delegate_OnAddPhantomItemList(IReadOnlyList<PhantomItem> weaponItem, bool isCatch);
