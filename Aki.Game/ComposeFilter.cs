using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;
using FilterDefine;

// Token: 0x02001837 RID: 6199
public class ComposeFilter : CommonFilter
{
	// Token: 0x0600B5CF RID: 46543 RVA: 0x00291DD0 File Offset: 0x0028FFD0
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

	// Token: 0x0600B5D0 RID: 46544 RVA: 0x00291E1E File Offset: 0x0029001E
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.ComposeMenu, new TFilterConfig(this.GetComposeMenuList));
	}
}
