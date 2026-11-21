using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x02000CF2 RID: 3314
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginFilter : CommonFilter
{
	// Token: 0x060089C1 RID: 35265 RVA: 0x0029C5E9 File Offset: 0x0029A7E9
	protected object GetDangoAbyssPluginQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((AbyssPluginItemInfo)data).GetQuality();
	}

	// Token: 0x060089C2 RID: 35266 RVA: 0x0029C5FC File Offset: 0x0029A7FC
	protected object GetDangoAbyssPluginProp(object data, Dictionary<int, string> currentSelectMap)
	{
		ConfigPropValue[] prop = ((AbyssPluginItemInfo)data).GetProp();
		List<int> list = new List<int>();
		foreach (ConfigPropValue configPropValue in prop)
		{
			list.Add(configPropValue.Id);
		}
		return list.ToArray();
	}

	// Token: 0x060089C3 RID: 35267 RVA: 0x0029C644 File Offset: 0x0029A844
	protected object GetDangoAbyssPluginTag(object data, Dictionary<int, string> currentSelectMap)
	{
		AbyssItem? abyssItem = ((AbyssPluginItemInfo)data).GetConfig().As<AbyssItem>();
		List<int> list = new List<int>();
		foreach (int item in abyssItem.Value.AddTag().Keys)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	// Token: 0x060089C4 RID: 35268 RVA: 0x0029C6C4 File Offset: 0x0029A8C4
	protected object GetDangoAbyssPluginEquipState(object data, Dictionary<int, string> currentSelectMap)
	{
		return (((AbyssPluginItemInfo)data).GetRoleId() > 0) ? 1 : -1;
	}

	// Token: 0x060089C5 RID: 35269 RVA: 0x0029C6DD File Offset: 0x0029A8DD
	protected object GetDangoAbyssPluginLockState(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((AbyssPluginItemInfo)data).GetIsLock() ? 1 : -1;
	}

	// Token: 0x060089C6 RID: 35270 RVA: 0x0029C6F5 File Offset: 0x0029A8F5
	protected object GetDangoAbyssPluginDeprecateState(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((AbyssPluginItemInfo)data).GetIsDeprecated() ? 1 : -1;
	}

	// Token: 0x060089C7 RID: 35271 RVA: 0x0029C710 File Offset: 0x0029A910
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.DangoAbyssPluginQuality, new TFilterConfig(this.GetDangoAbyssPluginQuality));
		this.FilterMap.Add(FilterDefine.EFilterType.DangoAbyssPluginProp, new TFilterConfig(this.GetDangoAbyssPluginProp));
		this.FilterMap.Add(FilterDefine.EFilterType.DangoAbyssPluginTag, new TFilterConfig(this.GetDangoAbyssPluginTag));
		this.FilterMap.Add(FilterDefine.EFilterType.DangoAbyssPluginEquipState, new TFilterConfig(this.GetDangoAbyssPluginEquipState));
		this.FilterMap.Add(FilterDefine.EFilterType.DangoAbyssPluginLockState, new TFilterConfig(this.GetDangoAbyssPluginLockState));
		this.FilterMap.Add(FilterDefine.EFilterType.DangoAbyssPluginDeprecateState, new TFilterConfig(this.GetDangoAbyssPluginDeprecateState));
	}
}
