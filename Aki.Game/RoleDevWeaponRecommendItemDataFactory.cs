using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002835 RID: 10293
public class RoleDevWeaponRecommendItemDataFactory
{
	// Token: 0x06015389 RID: 86921 RVA: 0x0055CF24 File Offset: 0x0055B124
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
