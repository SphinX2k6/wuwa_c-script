using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000A02 RID: 2562
// (Invoke) Token: 0x06004468 RID: 17512
[EventRule(EEventName.OnRoleFlyEquipChangeNotify)]
internal delegate void Delegate_OnRoleFlyEquipChangeNotify(IReadOnlyList<RoleFlySkinChange> skinChanges);
