using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000982 RID: 2434
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRoleTrialConfig : ConfigBase
{
	// Token: 0x06006AEA RID: 27370 RVA: 0x00213D8D File Offset: 0x00211F8D
	public RoleTrialActivity? GetRoleTrialActivityConfig(int activityId)
	{
		return ConfigRoleTrialActivityById.GetConfig(activityId, true);
	}

	// Token: 0x06006AEB RID: 27371 RVA: 0x00213D96 File Offset: 0x00211F96
	public RoleTrialInfo? GetRoleTrialInfoConfigByRoleId(int id)
	{
		return ConfigRoleTrialInfoById.GetConfig(id, true);
	}

	// Token: 0x06006AEC RID: 27372 RVA: 0x00213D9F File Offset: 0x00211F9F
	public RoleTrialRoleConfig? GetRoleTrialRoleConfigByRoleId(int roleId)
	{
		return ConfigRoleTrialRoleConfigByRoleId.GetConfig(roleId, true);
	}

	// Token: 0x06006AED RID: 27373 RVA: 0x00213DA8 File Offset: 0x00211FA8
	public RoleTrialUiConfig? GetRoleTrialUiConfigById(int configId)
	{
		return ConfigRoleTrialUiConfigById.GetConfig(configId, true);
	}

	// Token: 0x17000D2F RID: 3375
	// (get) Token: 0x06006AEE RID: 27374 RVA: 0x00213DB1 File Offset: 0x00211FB1
	public static ActivityRoleTrialConfig Instance
	{
		get
		{
			return ActivityRoleTrialConfig._Instance;
		}
	}

	// Token: 0x06006AEF RID: 27375 RVA: 0x00213DB8 File Offset: 0x00211FB8
	public static ActivityRoleTrialConfig GetOrCreateInstance()
	{
		if (ActivityRoleTrialConfig._Instance == null)
		{
			ActivityRoleTrialConfig.CreateInstance();
		}
		return ActivityRoleTrialConfig._Instance;
	}

	// Token: 0x06006AF0 RID: 27376 RVA: 0x00213DCC File Offset: 0x00211FCC
	public static bool CreateInstance()
	{
		if (ActivityRoleTrialConfig._Instance != null)
		{
			return true;
		}
		ActivityRoleTrialConfig._Instance = new ActivityRoleTrialConfig();
		return true;
	}

	// Token: 0x06006AF1 RID: 27377 RVA: 0x00213DE2 File Offset: 0x00211FE2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006AF2 RID: 27378 RVA: 0x00213DE4 File Offset: 0x00211FE4
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleTrialConfig._Instance = null;
	}

	// Token: 0x06006AF3 RID: 27379 RVA: 0x00213DEC File Offset: 0x00211FEC
	static ActivityRoleTrialConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleTrialConfig.CreateStaticDefaultValue), new Action(ActivityRoleTrialConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004332 RID: 17202
	[Nullable(2)]
	private static ActivityRoleTrialConfig _Instance;
}
