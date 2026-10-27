using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleLangCustomModel;
using FilterDefine;

// Token: 0x02001845 RID: 6213
[NullableContext(1)]
[Nullable(0)]
public class RoleFilter : CommonFilter
{
	// Token: 0x0600B60C RID: 46604 RVA: 0x002929F0 File Offset: 0x00290BF0
	protected object GetElementConfigId(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((RoleDataBase)data).GetElementInfo().Value.Id;
	}

	// Token: 0x0600B60D RID: 46605 RVA: 0x00292A20 File Offset: 0x00290C20
	protected object GetWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		return ((RoleDataBase)data).GetRoleConfig().WeaponType;
	}

	// Token: 0x0600B60E RID: 46606 RVA: 0x00292A48 File Offset: 0x00290C48
	protected object GetRoleTagIdList(object data, Dictionary<int, string> currentSelectMap)
	{
		RoleDataBase roleDataBase = (RoleDataBase)data;
		return RoleModel.Instance.GetRoleTagByRoleInfo(roleDataBase.GetRoleConfig());
	}

	// Token: 0x0600B60F RID: 46607 RVA: 0x00292A6C File Offset: 0x00290C6C
	protected object GetRoleLangCustom(object data, Dictionary<int, string> currentSelectMap)
	{
		RoleInstance roleInstance = (RoleInstance)data;
		return RoleLangCustomModel.Instance.GetRoleLangType(roleInstance.GetRoleId());
	}

	// Token: 0x0600B610 RID: 46608 RVA: 0x00292A98 File Offset: 0x00290C98
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Element, new TFilterConfig(this.GetElementConfigId));
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.RoleTag, new TFilterConfig(this.GetRoleTagIdList));
		this.FilterMap.Add(FilterDefine.EFilterType.RoleLangCustomType, new TFilterConfig(this.GetRoleLangCustom));
	}
}
