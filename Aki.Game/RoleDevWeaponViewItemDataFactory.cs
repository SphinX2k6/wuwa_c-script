using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DB3 RID: 7603
public class RoleDevWeaponViewItemDataFactory
{
	// Token: 0x06012DA6 RID: 77222 RVA: 0x00587F48 File Offset: 0x00586148
	[NullableContext(1)]
	public static RoleDevWeaponViewItemDataBase Create(int roleId, RoleDevViewModel roleDevViewModel)
	{
		ERoleDevDataType roleDevDataTypeByRoleId = RoleDevUtils.GetRoleDevDataTypeByRoleId(roleId);
		RoleDevWeaponViewItemDataBase roleDevWeaponViewItemDataBase;
		switch (roleDevDataTypeByRoleId)
		{
		case ERoleDevDataType.Obtained:
			roleDevWeaponViewItemDataBase = new ObtainedRoleDevWeaponViewItemData();
			break;
		case ERoleDevDataType.NotObtained:
			roleDevWeaponViewItemDataBase = new NotObtainedRoleDevWeaponViewItemData();
			break;
		case ERoleDevDataType.Forecast:
			roleDevWeaponViewItemDataBase = new ForecastRoleDevWeaponViewItemData();
			break;
		default:
			roleDevWeaponViewItemDataBase = new NotObtainedRoleDevWeaponViewItemData();
			break;
		}
		roleDevWeaponViewItemDataBase.InitByRoleId(roleId, roleDevDataTypeByRoleId, roleDevViewModel);
		return roleDevWeaponViewItemDataBase;
	}
}
