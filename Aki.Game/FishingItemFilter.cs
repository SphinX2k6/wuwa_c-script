using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using FilterDefine;

// Token: 0x0200183B RID: 6203
[NullableContext(1)]
[Nullable(0)]
public class FishingItemFilter : CommonFilter
{
	// Token: 0x0600B5E1 RID: 46561 RVA: 0x002920E4 File Offset: 0x002902E4
	protected object GetFishingItemTech(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Tech;
	}

	// Token: 0x0600B5E2 RID: 46562 RVA: 0x002920F1 File Offset: 0x002902F1
	protected object GetFishingItemTime(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Time;
	}

	// Token: 0x0600B5E3 RID: 46563 RVA: 0x00292103 File Offset: 0x00290303
	protected object GetFishingItemArea(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Area;
	}

	// Token: 0x0600B5E4 RID: 46564 RVA: 0x00292110 File Offset: 0x00290310
	protected object GetFishingItemType(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Type;
	}

	// Token: 0x0600B5E5 RID: 46565 RVA: 0x00292124 File Offset: 0x00290324
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.FishingTech, new TFilterConfig(this.GetFishingItemTech));
		this.FilterMap.Add(FilterDefine.EFilterType.FishingTime, new TFilterConfig(this.GetFishingItemTime));
		this.FilterMap.Add(FilterDefine.EFilterType.FishingArea, new TFilterConfig(this.GetFishingItemArea));
		this.FilterMap.Add(FilterDefine.EFilterType.FishingType, new TFilterConfig(this.GetFishingItemType));
	}
}
