using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000CFC RID: 3324
[NullableContext(1)]
[Nullable(0)]
public class PinballRoleSelectFilter : CommonFilter
{
	// Token: 0x060089EF RID: 35311 RVA: 0x0029D000 File Offset: 0x0029B200
	protected object GetPinballRoleBd(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPinballRoleSelectGridItemData)data).ItemData.BdId.GetValueOrDefault();
	}

	// Token: 0x060089F0 RID: 35312 RVA: 0x0029D02A File Offset: 0x0029B22A
	protected object GetPinballRoleClass(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((IPinballRoleSelectGridItemData)data).ClassIdList;
	}

	// Token: 0x060089F1 RID: 35313 RVA: 0x0029D037 File Offset: 0x0029B237
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleBd, new TFilterConfig(this.GetPinballRoleBd));
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleClass, new TFilterConfig(this.GetPinballRoleClass));
	}
}
