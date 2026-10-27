using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Cook;
using FilterDefine;

// Token: 0x02001838 RID: 6200
[NullableContext(1)]
[Nullable(0)]
public class CookFilter : CommonFilter
{
	// Token: 0x0600B5D2 RID: 46546 RVA: 0x00291E41 File Offset: 0x00290041
	protected object GetCookTypeList(object data, Dictionary<int, string> currentSelectMap)
	{
		if (((ICookItemData)data).MainType == ECookListType.Cooking)
		{
			return ((ICookingData)data).EffectType;
		}
		return 0;
	}

	// Token: 0x0600B5D3 RID: 46547 RVA: 0x00291E67 File Offset: 0x00290067
	protected object GetCookMenuList(object data, Dictionary<int, string> currentSelectMap)
	{
		if (((ICookItemData)data).MainType == ECookListType.Cooking)
		{
			return ((ICookingData)data).SubType;
		}
		return 0;
	}

	// Token: 0x0600B5D4 RID: 46548 RVA: 0x00291E8D File Offset: 0x0029008D
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.CookMenu, new TFilterConfig(this.GetCookMenuList));
		this.FilterMap.Add(FilterDefine.EFilterType.CookType, new TFilterConfig(this.GetCookTypeList));
	}
}
