using System;
using System.Collections.Generic;
using Aki.Protocol;

// Token: 0x02000D0F RID: 3343
// (Invoke) Token: 0x0600509C RID: 20636
[EventRule(EEventName.OnPayShopConditionFinish)]
internal delegate void Delegate_OnPayShopConditionFinish(List<Aki.Protocol.PayShopItem> shopItemList);
