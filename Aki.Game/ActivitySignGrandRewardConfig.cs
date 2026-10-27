using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020013AC RID: 5036
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivitySignGrandRewardConfig : ConfigBase
{
	// Token: 0x06008D71 RID: 36209 RVA: 0x001E736E File Offset: 0x001E556E
	public ActivitySignGrandReward? GetById(int actId)
	{
		return ConfigActivitySignGrandRewardById.GetConfig(actId, true);
	}

	// Token: 0x17000BE5 RID: 3045
	// (get) Token: 0x06008D72 RID: 36210 RVA: 0x001E7377 File Offset: 0x001E5577
	public static ActivitySignGrandRewardConfig Instance
	{
		get
		{
			return ActivitySignGrandRewardConfig._Instance;
		}
	}

	// Token: 0x06008D73 RID: 36211 RVA: 0x001E737E File Offset: 0x001E557E
	public static ActivitySignGrandRewardConfig GetOrCreateInstance()
	{
		if (ActivitySignGrandRewardConfig._Instance == null)
		{
			ActivitySignGrandRewardConfig.CreateInstance();
		}
		return ActivitySignGrandRewardConfig._Instance;
	}

	// Token: 0x06008D74 RID: 36212 RVA: 0x001E7392 File Offset: 0x001E5592
	public static bool CreateInstance()
	{
		if (ActivitySignGrandRewardConfig._Instance != null)
		{
			return true;
		}
		ActivitySignGrandRewardConfig._Instance = new ActivitySignGrandRewardConfig();
		return true;
	}

	// Token: 0x06008D75 RID: 36213 RVA: 0x001E73A8 File Offset: 0x001E55A8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008D76 RID: 36214 RVA: 0x001E73AA File Offset: 0x001E55AA
	public static void ResetStaticDefaultValue()
	{
		ActivitySignGrandRewardConfig._Instance = null;
	}

	// Token: 0x06008D77 RID: 36215 RVA: 0x001E73B2 File Offset: 0x001E55B2
	static ActivitySignGrandRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySignGrandRewardConfig.CreateStaticDefaultValue), new Action(ActivitySignGrandRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003ECC RID: 16076
	[Nullable(2)]
	private static ActivitySignGrandRewardConfig _Instance;
}
