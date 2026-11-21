using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;
using FilterDefine;

// Token: 0x02000CF0 RID: 3312
public class ComposeFilter : CommonFilter
{
	// Token: 0x060089BA RID: 35258 RVA: 0x0029C4F0 File Offset: 0x0029A6F0
	[NullableContext(1)]
	protected object GetComposeMenuList(object data, Dictionary<int, string> currentSelectMap)
	{
		IBaseItemData baseItemData = (IBaseItemData)data;
		if (baseItemData.MainType == EComposeListType.ReagentProduction)
		{
			return ((IReagentProductionData)data).SubType;
		}
		if (baseItemData.MainType == EComposeListType.Structure)
		{
			return ((IStructureData)data).SubType;
		}
		return 0;
	}

	// Token: 0x060089BB RID: 35259 RVA: 0x0029C53E File Offset: 0x0029A73E
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.ComposeMenu, new TFilterConfig(this.GetComposeMenuList));
	}
}
