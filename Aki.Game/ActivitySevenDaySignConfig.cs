using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020009AE RID: 2478
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivitySevenDaySignConfig : ConfigBase
{
	// Token: 0x06006CE3 RID: 27875 RVA: 0x0021B868 File Offset: 0x00219A68
	public ActivitySign? GetActivitySignById(int actId)
	{
		return ConfigActivitySignById.GetConfig(actId, true);
	}

	// Token: 0x06006CE4 RID: 27876 RVA: 0x0021B874 File Offset: 0x00219A74
	public OneItemConfig? GetActivityRewardByDay(int actId, int day)
	{
		ActivitySign? config = ConfigActivitySignById.GetConfig(actId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().SignRewards(day);
	}

	// Token: 0x17000D4C RID: 3404
	// (get) Token: 0x06006CE5 RID: 27877 RVA: 0x0021B8AC File Offset: 0x00219AAC
	public static ActivitySevenDaySignConfig Instance
	{
		get
		{
			return ActivitySevenDaySignConfig._Instance;
		}
	}

	// Token: 0x06006CE6 RID: 27878 RVA: 0x0021B8B3 File Offset: 0x00219AB3
	public static ActivitySevenDaySignConfig GetOrCreateInstance()
	{
		if (ActivitySevenDaySignConfig._Instance == null)
		{
			ActivitySevenDaySignConfig.CreateInstance();
		}
		return ActivitySevenDaySignConfig._Instance;
	}

	// Token: 0x06006CE7 RID: 27879 RVA: 0x0021B8C7 File Offset: 0x00219AC7
	public static bool CreateInstance()
	{
		if (ActivitySevenDaySignConfig._Instance != null)
		{
			return true;
		}
		ActivitySevenDaySignConfig._Instance = new ActivitySevenDaySignConfig();
		return true;
	}

	// Token: 0x06006CE8 RID: 27880 RVA: 0x0021B8DD File Offset: 0x00219ADD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006CE9 RID: 27881 RVA: 0x0021B8DF File Offset: 0x00219ADF
	public static void ResetStaticDefaultValue()
	{
		ActivitySevenDaySignConfig._Instance = null;
	}

	// Token: 0x06006CEA RID: 27882 RVA: 0x0021B8E7 File Offset: 0x00219AE7
	static ActivitySevenDaySignConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySevenDaySignConfig.CreateStaticDefaultValue), new Action(ActivitySevenDaySignConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040043FA RID: 17402
	[Nullable(2)]
	private static ActivitySevenDaySignConfig _Instance;
}
