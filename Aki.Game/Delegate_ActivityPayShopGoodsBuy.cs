using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x0200061C RID: 1564
// (Invoke) Token: 0x060034D0 RID: 13520
[EventRule(EEventName.ActivityPayShopGoodsBuy)]
internal delegate void Delegate_ActivityPayShopGoodsBuy(int payShopId, IReadOnlyList<ActivityBuyItem> buyItems, string version);
