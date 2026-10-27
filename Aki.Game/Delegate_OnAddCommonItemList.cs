using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000696 RID: 1686
// (Invoke) Token: 0x060036B8 RID: 14008
[EventRule(EEventName.OnAddCommonItemList)]
internal delegate void Delegate_OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList);
