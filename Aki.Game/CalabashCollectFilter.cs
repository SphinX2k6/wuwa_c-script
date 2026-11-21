using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000CEC RID: 3308
[NullableContext(1)]
[Nullable(0)]
public class CalabashCollectFilter : CommonFilter
{
	// Token: 0x060089A9 RID: 35241 RVA: 0x0029C394 File Offset: 0x0029A594
	protected object GetPhantomItemId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((CalabashDevelopRewardData)data).DevelopRewardData.MonsterId;
	}

	// Token: 0x060089AA RID: 35242 RVA: 0x0029C3BC File Offset: 0x0029A5BC
	protected object GetPhantomRarity(object data, Dictionary<int, string> currentSelectMap)
	{
		int monsterId = ((CalabashDevelopRewardData)data).DevelopRewardData.MonsterId;
		return PhantomBattleModel.Instance.GetMonsterRarity(monsterId);
	}

	// Token: 0x060089AB RID: 35243 RVA: 0x0029C3F0 File Offset: 0x0029A5F0
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Phantom, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.PhantomRarity, new TFilterConfig(this.GetPhantomRarity));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity1, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity2, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity3, new TFilterConfig(this.GetPhantomItemId));
		this.FilterMap.Add(FilterDefine.EFilterType.VisionRarity4, new TFilterConfig(this.GetPhantomItemId));
	}
}
