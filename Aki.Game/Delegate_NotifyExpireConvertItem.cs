using System;
using System.Collections.Generic;

// Token: 0x020006AD RID: 1709
// (Invoke) Token: 0x06003714 RID: 14100
[EventRule(EEventName.NotifyExpireConvertItem)]
internal delegate void Delegate_NotifyExpireConvertItem(IReadOnlyList<TItem> beforeItemList, IReadOnlyList<TItem> afterItemList);
