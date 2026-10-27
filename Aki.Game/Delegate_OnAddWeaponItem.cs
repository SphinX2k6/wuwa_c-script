using System;
using Aki.Protocol;

// Token: 0x0200069D RID: 1693
// (Invoke) Token: 0x060036D4 RID: 14036
[EventRule(EEventName.OnAddWeaponItem)]
internal delegate void Delegate_OnAddWeaponItem(WeaponItem weaponItem, bool bAddFromRole, bool bShowNewTips);
