using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001833 RID: 6195
[NullableContext(1)]
[Nullable(0)]
public class CalabashCollectFilter : CommonFilter
{
	// Token: 0x0600B5BE RID: 46526 RVA: 0x00291C74 File Offset: 0x0028FE74
	protected object GetPhantomItemId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((CalabashDevelopRewardData)data).DevelopRewardData.MonsterId;
	}

	// Token: 0x0600B5BF RID: 46527 RVA: 0x00291C9C File Offset: 0x0028FE9C
	protected object GetPhantomRarity(object data, Dictionary<int, string> currentSelectMap)
	{
		int monsterId = ((CalabashDevelopRewardData)data).DevelopRewardData.MonsterId;
		return PhantomBattleModel.Instance.GetMonsterRarity(monsterId);
	}

	// Token: 0x0600B5C0 RID: 46528 RVA: 0x00291CD0 File Offset: 0x0028FED0
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
