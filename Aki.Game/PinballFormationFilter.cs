using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000CFB RID: 3323
[NullableContext(1)]
[Nullable(0)]
public class PinballFormationFilter : CommonFilter
{
	// Token: 0x060089EB RID: 35307 RVA: 0x0029CF60 File Offset: 0x0029B160
	protected object GetPinballRoleBd(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return PinballConfig.Instance.GetPinballRoleConfigById(id).Value.Bd;
	}

	// Token: 0x060089EC RID: 35308 RVA: 0x0029CF94 File Offset: 0x0029B194
	protected object GetPinballRoleClass(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return PinballConfig.Instance.GetPinballRoleConfigById(id).Value.GetPinballClassArray();
	}

	// Token: 0x060089ED RID: 35309 RVA: 0x0029CFC3 File Offset: 0x0029B1C3
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleBd, new TFilterConfig(this.GetPinballRoleBd));
		this.FilterMap.Add(FilterDefine.EFilterType.PinballRoleClass, new TFilterConfig(this.GetPinballRoleClass));
	}
}
