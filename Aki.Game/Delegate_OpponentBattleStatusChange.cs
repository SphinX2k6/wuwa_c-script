using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000AC6 RID: 2758
// (Invoke) Token: 0x06004778 RID: 18296
[EventRule(EEventName.OpponentBattleStatusChange)]
internal delegate void Delegate_OpponentBattleStatusChange(IReadOnlyList<PhantomBattleRoleStatus> statusList);
