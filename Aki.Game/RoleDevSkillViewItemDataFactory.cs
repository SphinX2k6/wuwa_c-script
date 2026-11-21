using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D9B RID: 7579
public class RoleDevSkillViewItemDataFactory
{
	// Token: 0x06012C27 RID: 76839 RVA: 0x005838C0 File Offset: 0x00581AC0
	[NullableContext(1)]
	public static RoleDevSkillViewItemDataBase Create(int roleId, RoleDevViewModel roleDevViewModel)
	{
		ERoleDevDataType roleDevDataTypeByRoleId = RoleDevUtils.GetRoleDevDataTypeByRoleId(roleId);
		RoleDevSkillViewItemDataBase roleDevSkillViewItemDataBase;
		switch (roleDevDataTypeByRoleId)
		{
		case ERoleDevDataType.Obtained:
			roleDevSkillViewItemDataBase = new ObtainedRoleDevSkillData();
			break;
		case ERoleDevDataType.NotObtained:
			roleDevSkillViewItemDataBase = new NotObtainedRoleDevSkillData();
			break;
		case ERoleDevDataType.Forecast:
			roleDevSkillViewItemDataBase = new ForecastRoleDevSkillData();
			break;
		default:
			roleDevSkillViewItemDataBase = new NotObtainedRoleDevSkillData();
			break;
		}
		roleDevSkillViewItemDataBase.InitByRoleId(roleId, roleDevDataTypeByRoleId, roleDevViewModel);
		return roleDevSkillViewItemDataBase;
	}
}
