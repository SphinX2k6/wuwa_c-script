using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000975 RID: 2421
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRoleGuideConfig : ConfigBase
{
	// Token: 0x06006A3C RID: 27196 RVA: 0x00211D48 File Offset: 0x0020FF48
	public RoleGuideActivity? GetRoleTrialActivityConfig(int activityId)
	{
		return ConfigRoleGuideActivityById.GetConfig(activityId, true);
	}

	// Token: 0x17000D29 RID: 3369
	// (get) Token: 0x06006A3D RID: 27197 RVA: 0x00211D51 File Offset: 0x0020FF51
	public static ActivityRoleGuideConfig Instance
	{
		get
		{
			return ActivityRoleGuideConfig._Instance;
		}
	}

	// Token: 0x06006A3E RID: 27198 RVA: 0x00211D58 File Offset: 0x0020FF58
	public static ActivityRoleGuideConfig GetOrCreateInstance()
	{
		if (ActivityRoleGuideConfig._Instance == null)
		{
			ActivityRoleGuideConfig.CreateInstance();
		}
		return ActivityRoleGuideConfig._Instance;
	}

	// Token: 0x06006A3F RID: 27199 RVA: 0x00211D6C File Offset: 0x0020FF6C
	public static bool CreateInstance()
	{
		if (ActivityRoleGuideConfig._Instance != null)
		{
			return true;
		}
		ActivityRoleGuideConfig._Instance = new ActivityRoleGuideConfig();
		return true;
	}

	// Token: 0x06006A40 RID: 27200 RVA: 0x00211D82 File Offset: 0x0020FF82
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006A41 RID: 27201 RVA: 0x00211D84 File Offset: 0x0020FF84
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGuideConfig._Instance = null;
	}

	// Token: 0x06006A42 RID: 27202 RVA: 0x00211D8C File Offset: 0x0020FF8C
	static ActivityRoleGuideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGuideConfig.CreateStaticDefaultValue), new Action(ActivityRoleGuideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400430E RID: 17166
	[Nullable(2)]
	private static ActivityRoleGuideConfig _Instance;
}
