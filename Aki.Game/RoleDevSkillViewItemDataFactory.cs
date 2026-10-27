using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002820 RID: 10272
public class RoleDevSkillViewItemDataFactory
{
	// Token: 0x06015229 RID: 86569 RVA: 0x00558BAC File Offset: 0x00556DAC
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
