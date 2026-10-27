using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014C1 RID: 5313
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRoleGuideConfig : ConfigBase
{
	// Token: 0x060096A7 RID: 38567 RVA: 0x00208DDC File Offset: 0x00206FDC
	public RoleGuideActivity? GetRoleTrialActivityConfig(int activityId)
	{
		return ConfigRoleGuideActivityById.GetConfig(activityId, true);
	}

	// Token: 0x17000D09 RID: 3337
	// (get) Token: 0x060096A8 RID: 38568 RVA: 0x00208DE5 File Offset: 0x00206FE5
	public static ActivityRoleGuideConfig Instance
	{
		get
		{
			return ActivityRoleGuideConfig._Instance;
		}
	}

	// Token: 0x060096A9 RID: 38569 RVA: 0x00208DEC File Offset: 0x00206FEC
	public static ActivityRoleGuideConfig GetOrCreateInstance()
	{
		if (ActivityRoleGuideConfig._Instance == null)
		{
			ActivityRoleGuideConfig.CreateInstance();
		}
		return ActivityRoleGuideConfig._Instance;
	}

	// Token: 0x060096AA RID: 38570 RVA: 0x00208E00 File Offset: 0x00207000
	public static bool CreateInstance()
	{
		if (ActivityRoleGuideConfig._Instance != null)
		{
			return true;
		}
		ActivityRoleGuideConfig._Instance = new ActivityRoleGuideConfig();
		return true;
	}

	// Token: 0x060096AB RID: 38571 RVA: 0x00208E16 File Offset: 0x00207016
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060096AC RID: 38572 RVA: 0x00208E18 File Offset: 0x00207018
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGuideConfig._Instance = null;
	}

	// Token: 0x060096AD RID: 38573 RVA: 0x00208E20 File Offset: 0x00207020
	static ActivityRoleGuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGuideConfig.CreateStaticDefaultValue), new Action(ActivityRoleGuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004276 RID: 17014
	[Nullable(2)]
	private static ActivityRoleGuideConfig _Instance;
}
