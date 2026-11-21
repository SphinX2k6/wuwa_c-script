using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02001D95 RID: 7573
public class RoleDevRoleViewItemDataFactory
{
	// Token: 0x06012B9F RID: 76703 RVA: 0x0058204C File Offset: 0x0058024C
	[NullableContext(1)]
	public static RoleDevRoleViewItemDataBase Create(int roleId)
	{
		RoleDevRoleViewItemDataBase roleDevRoleViewItemDataBase;
		switch (RoleDevUtils.GetRoleDevDataTypeByRoleId(roleId))
		{
		case ERoleDevDataType.Obtained:
			roleDevRoleViewItemDataBase = new ObtainedRoleDevRoleData();
			roleDevRoleViewItemDataBase.InitByRoleId(roleId, ERoleDevDataType.Obtained);
			return roleDevRoleViewItemDataBase;
		case ERoleDevDataType.Forecast:
			roleDevRoleViewItemDataBase = new ForecastRoleDevRoleData();
			roleDevRoleViewItemDataBase.InitByRoleId(roleId, ERoleDevDataType.Forecast);
			return roleDevRoleViewItemDataBase;
		}
		roleDevRoleViewItemDataBase = new NotObtainedRoleDevRoleData();
		roleDevRoleViewItemDataBase.InitByRoleId(roleId, ERoleDevDataType.NotObtained);
		return roleDevRoleViewItemDataBase;
	}
}
