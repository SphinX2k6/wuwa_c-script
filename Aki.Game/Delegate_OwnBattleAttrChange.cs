using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000AC2 RID: 2754
// (Invoke) Token: 0x06004768 RID: 18280
[EventRule(EEventName.OwnBattleAttrChange)]
internal delegate void Delegate_OwnBattleAttrChange(IReadOnlyList<PhantomBattleCardAttr> attrList);
