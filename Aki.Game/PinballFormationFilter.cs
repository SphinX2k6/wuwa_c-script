using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001842 RID: 6210
[NullableContext(1)]
[Nullable(0)]
public class PinballFormationFilter : CommonFilter
{
	// Token: 0x0600B600 RID: 46592 RVA: 0x00292828 File Offset: 0x00290A28
	protected object GetPinballRoleBd(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return PinballConfig.Instance.GetPinballRoleConfigById(id).Value.Bd;
	}

	// Token: 0x0600B601 RID: 46593 RVA: 0x0029285C File Offset: 0x00290A5C
	protected object GetPinballRoleClass(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return PinballConfig.Instance.GetPinballRoleConfigById(id).Value.GetPinballClassArray();
	}

	// Token: 0x0600B602 RID: 46594 RVA: 0x0029288B File Offset: 0x00290A8B
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleBd, new TFilterConfig(this.GetPinballRoleBd));
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleClass, new TFilterConfig(this.GetPinballRoleClass));
	}
}
