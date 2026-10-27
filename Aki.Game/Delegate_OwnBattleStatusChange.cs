using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000AC1 RID: 2753
// (Invoke) Token: 0x06004764 RID: 18276
[EventRule(EEventName.OwnBattleStatusChange)]
internal delegate void Delegate_OwnBattleStatusChange(IReadOnlyList<PhantomBattleRoleStatus> statusList);
