using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001843 RID: 6211
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectFilter : CommonFilter
{
	// Token: 0x0600B604 RID: 46596 RVA: 0x002928C8 File Offset: 0x00290AC8
	protected object GetPinballRoleBd(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPinballRoleSelectGridItemData)data).ItemData.BdId.GetValueOrDefault();
	}

	// Token: 0x0600B605 RID: 46597 RVA: 0x002928F2 File Offset: 0x00290AF2
	protected object GetPinballRoleClass(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPinballRoleSelectGridItemData)data).ClassIdList;
	}

	// Token: 0x0600B606 RID: 46598 RVA: 0x002928FF File Offset: 0x00290AFF
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleBd, new TFilterConfig(this.GetPinballRoleBd));
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleClass, new TFilterConfig(this.GetPinballRoleClass));
	}
}
