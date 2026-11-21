using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using FilterDefine;

// Token: 0x02000CF4 RID: 3316
[NullableContext(1)]
[Nullable(0)]
public class FishingItemFilter : CommonFilter
{
	// Token: 0x060089CC RID: 35276 RVA: 0x0029C804 File Offset: 0x0029AA04
	protected object GetFishingItemTech(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Tech;
	}

	// Token: 0x060089CD RID: 35277 RVA: 0x0029C811 File Offset: 0x0029AA11
	protected object GetFishingItemTime(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Time;
	}

	// Token: 0x060089CE RID: 35278 RVA: 0x0029C823 File Offset: 0x0029AA23
	protected object GetFishingItemArea(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Area;
	}

	// Token: 0x060089CF RID: 35279 RVA: 0x0029C830 File Offset: 0x0029AA30
	protected object GetFishingItemType(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IFishingHandBookItemData)data).Type;
	}

	// Token: 0x060089D0 RID: 35280 RVA: 0x0029C844 File Offset: 0x0029AA44
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.FishingTech, new TFilterConfig(this.GetFishingItemTech));
		this.FilterMap.Add(FilterDefine.EFilterType.FishingTime, new TFilterConfig(this.GetFishingItemTime));
		this.FilterMap.Add(FilterDefine.EFilterType.FishingArea, new TFilterConfig(this.GetFishingItemArea));
		this.FilterMap.Add(FilterDefine.EFilterType.FishingType, new TFilterConfig(this.GetFishingItemType));
	}
}
