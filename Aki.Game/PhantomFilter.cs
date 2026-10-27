using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001841 RID: 6209
[NullableContext(1)]
[Nullable(0)]
public class PhantomFilter : CommonFilter
{
	// Token: 0x0600B5FC RID: 46588 RVA: 0x00292755 File Offset: 0x00290955
	protected object GetPhantomItemId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPhantomItemData)data).MonsterId;
	}

	// Token: 0x0600B5FD RID: 46589 RVA: 0x00292767 File Offset: 0x00290967
	protected object GetPhantomRarity(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPhantomItemData)data).Rarity;
	}

	// Token: 0x0600B5FE RID: 46590 RVA: 0x0029277C File Offset: 0x0029097C
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
