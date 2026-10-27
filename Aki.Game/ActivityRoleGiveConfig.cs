using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014BD RID: 5309
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityRoleGiveConfig : ConfigBase
{
	// Token: 0x0600967E RID: 38526 RVA: 0x00208280 File Offset: 0x00206480
	public TrackMoonPhaseActivity? GetActivityUniversalConfig(int activityId)
	{
		return null;
	}

	// Token: 0x17000D07 RID: 3335
	// (get) Token: 0x0600967F RID: 38527 RVA: 0x00208296 File Offset: 0x00206496
	public static ActivityRoleGiveConfig Instance
	{
		get
		{
			return ActivityRoleGiveConfig._Instance;
		}
	}

	// Token: 0x06009680 RID: 38528 RVA: 0x0020829D File Offset: 0x0020649D
	public static ActivityRoleGiveConfig GetOrCreateInstance()
	{
		if (ActivityRoleGiveConfig._Instance == null)
		{
			ActivityRoleGiveConfig.CreateInstance();
		}
		return ActivityRoleGiveConfig._Instance;
	}

	// Token: 0x06009681 RID: 38529 RVA: 0x002082B1 File Offset: 0x002064B1
	public static bool CreateInstance()
	{
		if (ActivityRoleGiveConfig._Instance != null)
		{
			return true;
		}
		ActivityRoleGiveConfig._Instance = new ActivityRoleGiveConfig();
		return true;
	}

	// Token: 0x06009682 RID: 38530 RVA: 0x002082C7 File Offset: 0x002064C7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009683 RID: 38531 RVA: 0x002082C9 File Offset: 0x002064C9
	public static void ResetStaticDefaultValue()
	{
		ActivityRoleGiveConfig._Instance = null;
	}

	// Token: 0x06009684 RID: 38532 RVA: 0x002082D1 File Offset: 0x002064D1
	static ActivityRoleGiveConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleGiveConfig.CreateStaticDefaultValue), new Action(ActivityRoleGiveConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400426C RID: 17004
	[Nullable(2)]
	private static ActivityRoleGiveConfig _Instance;
}
