using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleDev;

// Token: 0x02002806 RID: 10246
public class RoleDevPhantomViewItemDataFactory
{
	// Token: 0x06015062 RID: 86114 RVA: 0x00552CF4 File Offset: 0x00550EF4
	[NullableContext(1)]
	public static RoleDevPhantomViewItemDataBase Create(int roleId, RoleDevViewModel roleDevViewModel)
	{
		ERoleDevDataType roleDevDataTypeByRoleId = RoleDevUtils.GetRoleDevDataTypeByRoleId(roleId);
		RoleDevPhantomViewItemDataBase roleDevPhantomViewItemDataBase;
		switch (roleDevDataTypeByRoleId)
		{
		case ERoleDevDataType.Obtained:
			roleDevPhantomViewItemDataBase = new ObtainedRoleDevPhantomData();
			break;
		case ERoleDevDataType.NotObtained:
			roleDevPhantomViewItemDataBase = new NotObtainedRoleDevPhantomData();
			break;
		case ERoleDevDataType.Forecast:
			roleDevPhantomViewItemDataBase = new ForecastRoleDevPhantomData();
			break;
		default:
			roleDevPhantomViewItemDataBase = new NotObtainedRoleDevPhantomData();
			break;
		}
		roleDevPhantomViewItemDataBase.InitByRoleId(roleId, roleDevDataTypeByRoleId, roleDevViewModel);
		return roleDevPhantomViewItemDataBase;
	}
}
