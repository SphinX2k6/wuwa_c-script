using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000A06 RID: 2566
// (Invoke) Token: 0x06004478 RID: 17528
[EventRule(EEventName.OnFlySkinEquipToAllRoleResponse)]
internal delegate void Delegate_OnFlySkinEquipToAllRoleResponse(IReadOnlyList<RoleFlySkinChange> skinChanges);
