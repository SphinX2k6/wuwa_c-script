using System;
using Aki.Protocol;

// Token: 0x0200069B RID: 1691
// (Invoke) Token: 0x060036CC RID: 14028
[EventRule(EEventName.OnCommonItemCountRefresh)]
internal delegate void Delegate_OnCommonItemCountRefresh(IProto_NormalItem normalItem, int count, int lastCount);
