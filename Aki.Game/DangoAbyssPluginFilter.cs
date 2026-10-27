using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using FilterDefine;

// Token: 0x02001839 RID: 6201
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssPluginFilter : CommonFilter
{
	// Token: 0x0600B5D6 RID: 46550 RVA: 0x00291EC9 File Offset: 0x002900C9
	protected object GetDangoAbyssPluginQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((AbyssPluginItemInfo)data).GetQuality();
	}

	// Token: 0x0600B5D7 RID: 46551 RVA: 0x00291EDC File Offset: 0x002900DC
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

	// Token: 0x0600B5D8 RID: 46552 RVA: 0x00291F24 File Offset: 0x00290124
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

	// Token: 0x0600B5D9 RID: 46553 RVA: 0x00291FA4 File Offset: 0x002901A4
	protected object GetDangoAbyssPluginEquipState(object data, Dictionary<int, string> currentSelectMap)
	{
		return (((AbyssPluginItemInfo)data).GetRoleId() > 0) ? 1 : -1;
	}

	// Token: 0x0600B5DA RID: 46554 RVA: 0x00291FBD File Offset: 0x002901BD
	protected object GetDangoAbyssPluginLockState(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((AbyssPluginItemInfo)data).GetIsLock() ? 1 : -1;
	}

	// Token: 0x0600B5DB RID: 46555 RVA: 0x00291FD5 File Offset: 0x002901D5
	protected object GetDangoAbyssPluginDeprecateState(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((AbyssPluginItemInfo)data).GetIsDeprecated() ? 1 : -1;
	}

	// Token: 0x0600B5DC RID: 46556 RVA: 0x00291FF0 File Offset: 0x002901F0
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
