using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Cook;
using FilterDefine;

// Token: 0x02000CF1 RID: 3313
[NullableContext(1)]
[Nullable(0)]
public class CookFilter : CommonFilter
{
	// Token: 0x060089BD RID: 35261 RVA: 0x0029C561 File Offset: 0x0029A761
	protected object GetCookTypeList(object data, Dictionary<int, string> currentSelectMap)
	{
		if (((ICookItemData)data).MainType == ECookListType.Cooking)
		{
			return ((ICookingData)data).EffectType;
		}
		return 0;
	}

	// Token: 0x060089BE RID: 35262 RVA: 0x0029C587 File Offset: 0x0029A787
	protected object GetCookMenuList(object data, Dictionary<int, string> currentSelectMap)
	{
		if (((ICookItemData)data).MainType == ECookListType.Cooking)
		{
			return ((ICookingData)data).SubType;
		}
		return 0;
	}

	// Token: 0x060089BF RID: 35263 RVA: 0x0029C5AD File Offset: 0x0029A7AD
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.CookMenu, new TFilterConfig(this.GetCookMenuList));
		this.FilterMap.Add(FilterDefine.EFilterType.CookType, new TFilterConfig(this.GetCookTypeList));
	}
}
