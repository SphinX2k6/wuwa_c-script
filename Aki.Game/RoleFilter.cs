using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleLangCustomModel;
using FilterDefine;

// Token: 0x02000CFE RID: 3326
[NullableContext(1)]
[Nullable(0)]
public class RoleFilter : CommonFilter
{
	// Token: 0x060089F7 RID: 35319 RVA: 0x0029D128 File Offset: 0x0029B328
	protected object GetElementConfigId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((RoleDataBase)data).GetElementInfo().Value.Id;
	}

	// Token: 0x060089F8 RID: 35320 RVA: 0x0029D158 File Offset: 0x0029B358
	protected object GetWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((RoleDataBase)data).GetRoleConfig().WeaponType;
	}

	// Token: 0x060089F9 RID: 35321 RVA: 0x0029D180 File Offset: 0x0029B380
	protected object GetRoleTagIdList(object data, Dictionary<int, string> currentSelectMap)
	{
		RoleDataBase roleDataBase = (RoleDataBase)data;
		return RoleModel.Instance.GetRoleTagByRoleInfo(roleDataBase.GetRoleConfig());
	}

	// Token: 0x060089FA RID: 35322 RVA: 0x0029D1A4 File Offset: 0x0029B3A4
	protected object GetRoleLangCustom(object data, Dictionary<int, string> currentSelectMap)
	{
		RoleInstance roleInstance = (RoleInstance)data;
		return RoleLangCustomModel.Instance.GetRoleLangType(roleInstance.GetRoleId());
	}

	// Token: 0x060089FB RID: 35323 RVA: 0x0029D1D0 File Offset: 0x0029B3D0
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Element, new TFilterConfig(this.GetElementConfigId));
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.RoleTag, new TFilterConfig(this.GetRoleTagIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.RoleLangCustomType, new TFilterConfig(this.GetRoleLangCustom));
	}
}
