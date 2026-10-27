using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02000858 RID: 2136
// (Invoke) Token: 0x06003DC0 RID: 15808
[EventRule(EEventName.OnRefreshRewardViewItemList)]
internal delegate void Delegate_OnRefreshRewardViewItemList(IReadOnlyList<RewardItemData> itemList);
