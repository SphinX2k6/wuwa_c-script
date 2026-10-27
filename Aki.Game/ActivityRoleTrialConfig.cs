using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014CA RID: 5322
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRoleTrialConfig : ConfigBase
{
	// Token: 0x06009710 RID: 38672 RVA: 0x0020A0A3 File Offset: 0x002082A3
	public RoleTrialActivity? GetRoleTrialActivityConfig(int activityId)
	{
		return ConfigRoleTrialActivityById.GetConfig(activityId, true);
	}

	// Token: 0x06009711 RID: 38673 RVA: 0x0020A0AC File Offset: 0x002082AC
	public RoleTrialInfo? GetRoleTrialInfoConfigByRoleId(int id)
	{
		return ConfigRoleTrialInfoById.GetConfig(id, true);
	}

	// Token: 0x06009712 RID: 38674 RVA: 0x0020A0B5 File Offset: 0x002082B5
	public RoleTrialRoleConfig? GetRoleTrialRoleConfigByRoleId(int roleId)
	{
		return ConfigRoleTrialRoleConfigByRoleId.GetConfig(roleId, true);
	}

	// Token: 0x06009713 RID: 38675 RVA: 0x0020A0BE File Offset: 0x002082BE
	public RoleTrialUiConfig? GetRoleTrialUiConfigById(int configId)
	{
		return ConfigRoleTrialUiConfigById.GetConfig(configId, true);
	}

	// Token: 0x17000D0E RID: 3342
	// (get) Token: 0x06009714 RID: 38676 RVA: 0x0020A0C7 File Offset: 0x002082C7
	public static ActivityRoleTrialConfig Instance
	{
		get
		{
			return ActivityRoleTrialConfig._Instance;
		}
	}

	// Token: 0x06009715 RID: 38677 RVA: 0x0020A0CE File Offset: 0x002082CE
	public static ActivityRoleTrialConfig GetOrCreateInstance()
	{
		if (ActivityRoleTrialConfig._Instance == null)
		{
			ActivityRoleTrialConfig.CreateInstance();
		}
		return ActivityRoleTrialConfig._Instance;
	}

	// Token: 0x06009716 RID: 38678 RVA: 0x0020A0E2 File Offset: 0x002082E2
	public static bool CreateInstance()
	{
		if (ActivityRoleTrialConfig._Instance != null)
		{
			return true;
		}
		ActivityRoleTrialConfig._Instance = new ActivityRoleTrialConfig();
		return true;
	}

	// Token: 0x06009717 RID: 38679 RVA: 0x0020A0F8 File Offset: 0x002082F8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009718 RID: 38680 RVA: 0x0020A0FA File Offset: 0x002082FA
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleTrialConfig._Instance = null;
	}

	// Token: 0x06009719 RID: 38681 RVA: 0x0020A102 File Offset: 0x00208302
	static ActivityRoleTrialConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleTrialConfig.CreateStaticDefaultValue), new Action(ActivityRoleTrialConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400428D RID: 17037
	[Nullable(2)]
	private static ActivityRoleTrialConfig _Instance;
}
