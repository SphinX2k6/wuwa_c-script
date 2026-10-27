using System;
using System.Collections.Generic;

// Token: 0x020003D4 RID: 980
// (Invoke) Token: 0x06002BB0 RID: 11184
[EventRule(EEventName.WeaponLevelUpReceiveItem)]
internal delegate void Delegate_WeaponLevelUpReceiveItem(IReadOnlyList<TItem> itemList);
