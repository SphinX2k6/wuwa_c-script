using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002833 RID: 10291
public class RoleDevWeaponDevItemDataFactory
{
	// Token: 0x0601536D RID: 86893 RVA: 0x0055CD68 File Offset: 0x0055AF68
	[NullableContext(1)]
	public static RoleDevWeaponDevItemDataBase Create(int roleId)
	{
		RoleDevWeaponDevItemDataBase roleDevWeaponDevItemDataBase;
		switch (RoleDevUtils.GetRoleDevDataTypeByRoleId(roleId))
		{
		case ERoleDevDataType.Obtained:
			roleDevWeaponDevItemDataBase = new ObtainedRoleDevWeaponDevData();
			roleDevWeaponDevItemDataBase.InitByRoleId(roleId, ERoleDevDataType.Obtained);
			return roleDevWeaponDevItemDataBase;
		case ERoleDevDataType.Forecast:
			roleDevWeaponDevItemDataBase = new ForecastRoleDevWeaponDevData();
			roleDevWeaponDevItemDataBase.InitByRoleId(roleId, ERoleDevDataType.Forecast);
			return roleDevWeaponDevItemDataBase;
		}
		roleDevWeaponDevItemDataBase = new NotObtainedRoleDevWeaponDevData();
		roleDevWeaponDevItemDataBase.InitByRoleId(roleId, ERoleDevDataType.NotObtained);
		return roleDevWeaponDevItemDataBase;
	}
}
