using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000860 RID: 2144
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivitySignGrandRewardConfig : ConfigBase
{
	// Token: 0x06006107 RID: 24839 RVA: 0x001EFFBE File Offset: 0x001EE1BE
	public ActivitySignGrandReward? GetById(int actId)
	{
		return ConfigActivitySignGrandRewardById.GetConfig(actId, true);
	}

	// Token: 0x17000C05 RID: 3077
	// (get) Token: 0x06006108 RID: 24840 RVA: 0x001EFFC7 File Offset: 0x001EE1C7
	public static ActivitySignGrandRewardConfig Instance
	{
		get
		{
			return ActivitySignGrandRewardConfig._Instance;
		}
	}

	// Token: 0x06006109 RID: 24841 RVA: 0x001EFFCE File Offset: 0x001EE1CE
	public static ActivitySignGrandRewardConfig GetOrCreateInstance()
	{
		if (ActivitySignGrandRewardConfig._Instance == null)
		{
			ActivitySignGrandRewardConfig.CreateInstance();
		}
		return ActivitySignGrandRewardConfig._Instance;
	}

	// Token: 0x0600610A RID: 24842 RVA: 0x001EFFE2 File Offset: 0x001EE1E2
	public static bool CreateInstance()
	{
		if (ActivitySignGrandRewardConfig._Instance != null)
		{
			return true;
		}
		ActivitySignGrandRewardConfig._Instance = new ActivitySignGrandRewardConfig();
		return true;
	}

	// Token: 0x0600610B RID: 24843 RVA: 0x001EFFF8 File Offset: 0x001EE1F8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600610C RID: 24844 RVA: 0x001EFFFA File Offset: 0x001EE1FA
	public static void ResetStaticDefaultValue()
	{
		ActivitySignGrandRewardConfig._Instance = null;
	}

	// Token: 0x0600610D RID: 24845 RVA: 0x001F0002 File Offset: 0x001EE202
	static ActivitySignGrandRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySignGrandRewardConfig.CreateStaticDefaultValue), new Action(ActivitySignGrandRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003F64 RID: 16228
	[Nullable(2)]
	private static ActivitySignGrandRewardConfig _Instance;
}
