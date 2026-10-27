using System;
using System.Runtime.CompilerServices;

// Token: 0x02002812 RID: 10258
[NullableContext(1)]
[Nullable(0)]
public class RoleDisplayModelFactory : IStaticVariableResetter
{
	// Token: 0x0601510F RID: 86287 RVA: 0x00555C60 File Offset: 0x00553E60
	static RoleDisplayModelFactory()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleDisplayModelFactory.CreateStaticDefaultValue), new Action(RoleDisplayModelFactory.ResetStaticDefaultValue));
	}

	// Token: 0x17001BD5 RID: 7125
	// (get) Token: 0x06015110 RID: 86288 RVA: 0x00555C7F File Offset: 0x00553E7F
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

	// Token: 0x06015111 RID: 86289 RVA: 0x00555C97 File Offset: 0x00553E97
	public static void CreateStaticDefaultValue()
	{
		RoleDisplayModelFactory.InstanceInternal = null;
	}

	// Token: 0x06015112 RID: 86290 RVA: 0x00555C9F File Offset: 0x00553E9F
	public static void ResetStaticDefaultValue()
	{
		RoleDisplayModelFactory.InstanceInternal = null;
	}

	// Token: 0x06015113 RID: 86291 RVA: 0x00555CA8 File Offset: 0x00553EA8
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

	// Token: 0x04009E33 RID: 40499
	[Nullable(2)]
	private static RoleDisplayModelFactory InstanceInternal;
}
