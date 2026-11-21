using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020006BE RID: 1726
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityDailyAdventureConfig : ConfigBase
{
	// Token: 0x06004F35 RID: 20277 RVA: 0x001AA248 File Offset: 0x001A8448
	public DailyAdventureActivity? GetActivityDailyAdventureConfig(int activityId)
	{
		return ConfigDailyAdventureActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06004F36 RID: 20278 RVA: 0x001AA251 File Offset: 0x001A8451
	public DailyAdventureTask? GetDailyAdventureTaskConfig(int taskId)
	{
		return ConfigDailyAdventureTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x06004F37 RID: 20279 RVA: 0x001AA25A File Offset: 0x001A845A
	public DailyAdventurePoint? GetDailyAdventurePointConfig(int id)
	{
		return ConfigDailyAdventurePointById.GetConfig(id, true);
	}

	// Token: 0x17000AAE RID: 2734
	// (get) Token: 0x06004F38 RID: 20280 RVA: 0x001AA263 File Offset: 0x001A8463
	public static ActivityDailyAdventureConfig Instance
	{
		get
		{
			return ActivityDailyAdventureConfig._Instance;
		}
	}

	// Token: 0x06004F39 RID: 20281 RVA: 0x001AA26A File Offset: 0x001A846A
	public static ActivityDailyAdventureConfig GetOrCreateInstance()
	{
		if (ActivityDailyAdventureConfig._Instance == null)
		{
			ActivityDailyAdventureConfig.CreateInstance();
		}
		return ActivityDailyAdventureConfig._Instance;
	}

	// Token: 0x06004F3A RID: 20282 RVA: 0x001AA27E File Offset: 0x001A847E
	public static bool CreateInstance()
	{
		if (ActivityDailyAdventureConfig._Instance != null)
		{
			return true;
		}
		ActivityDailyAdventureConfig._Instance = new ActivityDailyAdventureConfig();
		return true;
	}

	// Token: 0x06004F3B RID: 20283 RVA: 0x001AA294 File Offset: 0x001A8494
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004F3C RID: 20284 RVA: 0x001AA296 File Offset: 0x001A8496
	public static void ResetStaticDefaultValue()
	{
		ActivityDailyAdventureConfig._Instance = null;
	}

	// Token: 0x06004F3D RID: 20285 RVA: 0x001AA29E File Offset: 0x001A849E
	static ActivityDailyAdventureConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDailyAdventureConfig.CreateStaticDefaultValue), new Action(ActivityDailyAdventureConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400393E RID: 14654
	[Nullable(2)]
	private static ActivityDailyAdventureConfig _Instance;
}
