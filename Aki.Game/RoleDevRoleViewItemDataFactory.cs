using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x0200281A RID: 10266
public class RoleDevRoleViewItemDataFactory
{
	// Token: 0x0601519F RID: 86431 RVA: 0x0055724C File Offset: 0x0055544C
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
