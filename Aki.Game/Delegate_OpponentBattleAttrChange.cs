using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000AC7 RID: 2759
// (Invoke) Token: 0x0600477C RID: 18300
[EventRule(EEventName.OpponentBattleAttrChange)]
internal delegate void Delegate_OpponentBattleAttrChange(IReadOnlyList<PhantomBattleCardAttr> attrList);
