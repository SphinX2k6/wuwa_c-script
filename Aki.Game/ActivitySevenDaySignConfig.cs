using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014F6 RID: 5366
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivitySevenDaySignConfig : ConfigBase
{
	// Token: 0x06009909 RID: 39177 RVA: 0x00211B78 File Offset: 0x0020FD78
	public ActivitySign? GetActivitySignById(int actId)
	{
		return ConfigActivitySignById.GetConfig(actId, true);
	}

	// Token: 0x0600990A RID: 39178 RVA: 0x00211B84 File Offset: 0x0020FD84
	public OneItemConfig? GetActivityRewardByDay(int actId, int day)
	{
		ActivitySign? config = ConfigActivitySignById.GetConfig(actId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().SignRewards(day);
	}

	// Token: 0x17000D2B RID: 3371
	// (get) Token: 0x0600990B RID: 39179 RVA: 0x00211BBC File Offset: 0x0020FDBC
	public static ActivitySevenDaySignConfig Instance
	{
		get
		{
			return ActivitySevenDaySignConfig._Instance;
		}
	}

	// Token: 0x0600990C RID: 39180 RVA: 0x00211BC3 File Offset: 0x0020FDC3
	public static ActivitySevenDaySignConfig GetOrCreateInstance()
	{
		if (ActivitySevenDaySignConfig._Instance == null)
		{
			ActivitySevenDaySignConfig.CreateInstance();
		}
		return ActivitySevenDaySignConfig._Instance;
	}

	// Token: 0x0600990D RID: 39181 RVA: 0x00211BD7 File Offset: 0x0020FDD7
	public static bool CreateInstance()
	{
		if (ActivitySevenDaySignConfig._Instance != null)
		{
			return true;
		}
		ActivitySevenDaySignConfig._Instance = new ActivitySevenDaySignConfig();
		return true;
	}

	// Token: 0x0600990E RID: 39182 RVA: 0x00211BED File Offset: 0x0020FDED
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600990F RID: 39183 RVA: 0x00211BEF File Offset: 0x0020FDEF
	public static void ResetStaticDefaultValue()
	{
		ActivitySevenDaySignConfig._Instance = null;
	}

	// Token: 0x06009910 RID: 39184 RVA: 0x00211BF7 File Offset: 0x0020FDF7
	static ActivitySevenDaySignConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySevenDaySignConfig.CreateStaticDefaultValue), new Action(ActivitySevenDaySignConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004355 RID: 17237
	[Nullable(2)]
	private static ActivitySevenDaySignConfig _Instance;
}
