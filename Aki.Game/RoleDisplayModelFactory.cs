using System;
using System.Runtime.CompilerServices;

// Token: 0x02001D8D RID: 7565
[NullableContext(1)]
[Nullable(0)]
public class RoleDisplayModelFactory : IStaticVariableResetter
{
	// Token: 0x06012B0F RID: 76559 RVA: 0x00580A60 File Offset: 0x0057EC60
	static RoleDisplayModelFactory()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDisplayModelFactory.CreateStaticDefaultValue), new Action(RoleDisplayModelFactory.ResetStaticDefaultValue));
	}

	// Token: 0x17001C2D RID: 7213
	// (get) Token: 0x06012B10 RID: 76560 RVA: 0x00580A7F File Offset: 0x0057EC7F
	public static RoleDisplayModelFactory Instance
	{
		get
		{
			if (RoleDisplayModelFactory.InstanceInternal == null)
			{
				RoleDisplayModelFactory.InstanceInternal = new RoleDisplayModelFactory();
			}
			return RoleDisplayModelFactory.InstanceInternal;
		}
	}

	// Token: 0x06012B11 RID: 76561 RVA: 0x00580A97 File Offset: 0x0057EC97
	public static void CreateStaticDefaultValue()
	{
		RoleDisplayModelFactory.InstanceInternal = null;
	}

	// Token: 0x06012B12 RID: 76562 RVA: 0x00580A9F File Offset: 0x0057EC9F
	public static void ResetStaticDefaultValue()
	{
		RoleDisplayModelFactory.InstanceInternal = null;
	}

	// Token: 0x06012B13 RID: 76563 RVA: 0x00580AA8 File Offset: 0x0057ECA8
	public RoleDisplayModelBase BuildRoleDisplayModel(int roleId, bool forceRuntime = false)
	{
		if (RoleDevUtils.GetRoleTypeTagByRoleId(roleId) == ERoleTypeTag.Forecast)
		{
			ForecastRoleDisplayModel forecastRoleDisplayModel = new ForecastRoleDisplayModel();
			forecastRoleDisplayModel.InitByRoleId(roleId);
			return forecastRoleDisplayModel;
		}
		RuntimeRoleDisplayModel runtimeRoleDisplayModel = new RuntimeRoleDisplayModel();
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		if (roleDataById != null)
		{
			runtimeRoleDisplayModel.InitByRoleData(roleDataById);
		}
		else
		{
			runtimeRoleDisplayModel.InitByRoleId(roleId);
		}
		return runtimeRoleDisplayModel;
	}

	// Token: 0x0400A21C RID: 41500
	[Nullable(2)]
	private static RoleDisplayModelFactory InstanceInternal;
}
