using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200097A RID: 2426
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class RoleSkinTrialConfig : ConfigBase
{
	// Token: 0x06006A6B RID: 27243 RVA: 0x002126F9 File Offset: 0x002108F9
	public RoleSkinTrialInfo? GetRoleSkinTrialInfoByRoleId(int roleId)
	{
		return ConfigRoleSkinTrialInfoByRoleId.GetConfig(roleId, true);
	}

	// Token: 0x06006A6C RID: 27244 RVA: 0x00212702 File Offset: 0x00210902
	public RoleSkinTrialInfo? GetRoleSkinTrialInfoById(int id)
	{
		return ConfigRoleSkinTrialInfoById.GetConfig(id, true);
	}

	// Token: 0x06006A6D RID: 27245 RVA: 0x0021270B File Offset: 0x0021090B
	public RoleSkinTrialActivity? GetRoleSkinTrialActivityByActivityId(int activityId)
	{
		return ConfigRoleSkinTrialActivityById.GetConfig(activityId, true);
	}

	// Token: 0x06006A6E RID: 27246 RVA: 0x00212714 File Offset: 0x00210914
	public RoleSkinTrialUiConfig? GetRoleSkinTrialUiConfigById(int id)
	{
		return ConfigRoleSkinTrialUiConfigById.GetConfig(id, true);
	}

	// Token: 0x17000D2C RID: 3372
	// (get) Token: 0x06006A6F RID: 27247 RVA: 0x0021271D File Offset: 0x0021091D
	public static RoleSkinTrialConfig Instance
	{
		get
		{
			return RoleSkinTrialConfig._Instance;
		}
	}

	// Token: 0x06006A70 RID: 27248 RVA: 0x00212724 File Offset: 0x00210924
	public static RoleSkinTrialConfig GetOrCreateInstance()
	{
		if (RoleSkinTrialConfig._Instance == null)
		{
			RoleSkinTrialConfig.CreateInstance();
		}
		return RoleSkinTrialConfig._Instance;
	}

	// Token: 0x06006A71 RID: 27249 RVA: 0x00212738 File Offset: 0x00210938
	public static bool CreateInstance()
	{
		if (RoleSkinTrialConfig._Instance != null)
		{
			return true;
		}
		RoleSkinTrialConfig._Instance = new RoleSkinTrialConfig();
		return true;
	}

	// Token: 0x06006A72 RID: 27250 RVA: 0x0021274E File Offset: 0x0021094E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006A73 RID: 27251 RVA: 0x00212750 File Offset: 0x00210950
	public static void ResetStaticDefaultValue()
	{
		RoleSkinTrialConfig._Instance = null;
	}

	// Token: 0x06006A74 RID: 27252 RVA: 0x00212758 File Offset: 0x00210958
	static RoleSkinTrialConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSkinTrialConfig.CreateStaticDefaultValue), new Action(RoleSkinTrialConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400431C RID: 17180
	[Nullable(2)]
	private static RoleSkinTrialConfig _Instance;
}
