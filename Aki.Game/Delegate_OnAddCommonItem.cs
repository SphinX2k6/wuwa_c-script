using System;
using Aki.Protocol;

// Token: 0x02000695 RID: 1685
// (Invoke) Token: 0x060036B4 RID: 14004
[EventRule(EEventName.OnAddCommonItem)]
internal delegate void Delegate_OnAddCommonItem(IProto_NormalItem normalItem, bool isShowNewTips);
