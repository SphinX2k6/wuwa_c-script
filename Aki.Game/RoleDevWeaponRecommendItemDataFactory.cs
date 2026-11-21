using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DB0 RID: 7600
public class RoleDevWeaponRecommendItemDataFactory
{
	// Token: 0x06012D87 RID: 77191 RVA: 0x00587C80 File Offset: 0x00585E80
	[NullableContext(1)]
	public static RoleDevWeaponRecommendItemDataBase Create(int roleId)
	{
		RoleDevWeaponRecommendItemDataBase roleDevWeaponRecommendItemDataBase;
		switch (RoleDevUtils.GetRoleDevDataTypeByRoleId(roleId))
		{
		case ERoleDevDataType.Obtained:
			roleDevWeaponRecommendItemDataBase = new ObtainedRoleDevWeaponRecommendItemData();
			roleDevWeaponRecommendItemDataBase.InitByRoleId(roleId);
			return roleDevWeaponRecommendItemDataBase;
		case ERoleDevDataType.Forecast:
			roleDevWeaponRecommendItemDataBase = new ForecastRoleDevWeaponRecommendItemData();
			roleDevWeaponRecommendItemDataBase.InitByRoleId(roleId);
			return roleDevWeaponRecommendItemDataBase;
		}
		roleDevWeaponRecommendItemDataBase = new NotObtainedRoleDevWeaponRecommendItemData();
		roleDevWeaponRecommendItemDataBase.InitByRoleId(roleId);
		return roleDevWeaponRecommendItemDataBase;
	}
}
