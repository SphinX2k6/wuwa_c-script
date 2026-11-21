using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001DAE RID: 7598
public class RoleDevWeaponDevItemDataFactory
{
	// Token: 0x06012D6B RID: 77163 RVA: 0x00587AC4 File Offset: 0x00585CC4
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
