using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x0200069E RID: 1694
// (Invoke) Token: 0x060036D8 RID: 14040
[EventRule(EEventName.OnAddWeaponItemList)]
internal delegate void Delegate_OnAddWeaponItemList(IReadOnlyList<WeaponItem> weaponItem, bool bAddFromRole, bool bShowNewTips);
