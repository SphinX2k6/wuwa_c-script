using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002838 RID: 10296
public class RoleDevWeaponViewItemDataFactory
{
	// Token: 0x060153A8 RID: 86952 RVA: 0x0055D1EC File Offset: 0x0055B3EC
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
