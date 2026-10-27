using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014C6 RID: 5318
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RoleSkinTrialConfig : ConfigBase
{
	// Token: 0x060096D6 RID: 38614 RVA: 0x0020978D File Offset: 0x0020798D
	public RoleSkinTrialInfo? GetRoleSkinTrialInfoByRoleId(int roleId)
	{
		return ConfigRoleSkinTrialInfoByRoleId.GetConfig(roleId, true);
	}

	// Token: 0x060096D7 RID: 38615 RVA: 0x00209796 File Offset: 0x00207996
	public RoleSkinTrialInfo? GetRoleSkinTrialInfoById(int id)
	{
		return ConfigRoleSkinTrialInfoById.GetConfig(id, true);
	}

	// Token: 0x060096D8 RID: 38616 RVA: 0x0020979F File Offset: 0x0020799F
	public RoleSkinTrialActivity? GetRoleSkinTrialActivityByActivityId(int activityId)
	{
		return ConfigRoleSkinTrialActivityById.GetConfig(activityId, true);
	}

	// Token: 0x060096D9 RID: 38617 RVA: 0x002097A8 File Offset: 0x002079A8
	public RoleSkinTrialUiConfig? GetRoleSkinTrialUiConfigById(int id)
	{
		return ConfigRoleSkinTrialUiConfigById.GetConfig(id, true);
	}

	// Token: 0x17000D0C RID: 3340
	// (get) Token: 0x060096DA RID: 38618 RVA: 0x002097B1 File Offset: 0x002079B1
	public static RoleSkinTrialConfig Instance
	{
		get
		{
			return RoleSkinTrialConfig._Instance;
		}
	}

	// Token: 0x060096DB RID: 38619 RVA: 0x002097B8 File Offset: 0x002079B8
	public static RoleSkinTrialConfig GetOrCreateInstance()
	{
		if (RoleSkinTrialConfig._Instance == null)
		{
			RoleSkinTrialConfig.CreateInstance();
		}
		return RoleSkinTrialConfig._Instance;
	}

	// Token: 0x060096DC RID: 38620 RVA: 0x002097CC File Offset: 0x002079CC
	public static bool CreateInstance()
	{
		if (RoleSkinTrialConfig._Instance != null)
		{
			return true;
		}
		RoleSkinTrialConfig._Instance = new RoleSkinTrialConfig();
		return true;
	}

	// Token: 0x060096DD RID: 38621 RVA: 0x002097E2 File Offset: 0x002079E2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060096DE RID: 38622 RVA: 0x002097E4 File Offset: 0x002079E4
	public static void ResetStaticDefaultValue()
	{
		RoleSkinTrialConfig._Instance = null;
	}

	// Token: 0x060096DF RID: 38623 RVA: 0x002097EC File Offset: 0x002079EC
	static RoleSkinTrialConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinTrialConfig.CreateStaticDefaultValue), new Action(RoleSkinTrialConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004284 RID: 17028
	[Nullable(2)]
	private static RoleSkinTrialConfig _Instance;
}
