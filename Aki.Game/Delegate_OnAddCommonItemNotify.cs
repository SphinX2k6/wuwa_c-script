using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000697 RID: 1687
// (Invoke) Token: 0x060036BC RID: 14012
[EventRule(EEventName.OnAddCommonItemNotify)]
internal delegate void Delegate_OnAddCommonItemNotify(IReadOnlyList<IProto_NormalItem> normalItemList);
