using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000971 RID: 2417
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRoleGiveConfig : ConfigBase
{
	// Token: 0x06006A13 RID: 27155 RVA: 0x002111EC File Offset: 0x0020F3EC
	public TrackMoonPhaseActivity? GetActivityUniversalConfig(int activityId)
	{
		return null;
	}

	// Token: 0x17000D27 RID: 3367
	// (get) Token: 0x06006A14 RID: 27156 RVA: 0x00211202 File Offset: 0x0020F402
	public static ActivityRoleGiveConfig Instance
	{
		get
		{
			return ActivityRoleGiveConfig._Instance;
		}
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x00211209 File Offset: 0x0020F409
	public static ActivityRoleGiveConfig GetOrCreateInstance()
	{
		if (ActivityRoleGiveConfig._Instance == null)
		{
			ActivityRoleGiveConfig.CreateInstance();
		}
		return ActivityRoleGiveConfig._Instance;
	}

	// Token: 0x06006A16 RID: 27158 RVA: 0x0021121D File Offset: 0x0020F41D
	public static bool CreateInstance()
	{
		if (ActivityRoleGiveConfig._Instance != null)
		{
			return true;
		}
		ActivityRoleGiveConfig._Instance = new ActivityRoleGiveConfig();
		return true;
	}

	// Token: 0x06006A17 RID: 27159 RVA: 0x00211233 File Offset: 0x0020F433
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006A18 RID: 27160 RVA: 0x00211235 File Offset: 0x0020F435
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGiveConfig._Instance = null;
	}

	// Token: 0x06006A19 RID: 27161 RVA: 0x0021123D File Offset: 0x0020F43D
	static ActivityRoleGiveConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGiveConfig.CreateStaticDefaultValue), new Action(ActivityRoleGiveConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004304 RID: 17156
	[Nullable(2)]
	private static ActivityRoleGiveConfig _Instance;
}
