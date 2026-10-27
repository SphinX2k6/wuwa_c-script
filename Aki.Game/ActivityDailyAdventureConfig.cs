using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200120A RID: 4618
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityDailyAdventureConfig : ConfigBase
{
	// Token: 0x06007B9F RID: 31647 RVA: 0x001A1590 File Offset: 0x0019F790
	public DailyAdventureActivity? GetActivityDailyAdventureConfig(int activityId)
	{
		return ConfigDailyAdventureActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06007BA0 RID: 31648 RVA: 0x001A1599 File Offset: 0x0019F799
	public DailyAdventureTask? GetDailyAdventureTaskConfig(int taskId)
	{
		return ConfigDailyAdventureTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x06007BA1 RID: 31649 RVA: 0x001A15A2 File Offset: 0x0019F7A2
	public DailyAdventurePoint? GetDailyAdventurePointConfig(int id)
	{
		return ConfigDailyAdventurePointById.GetConfig(id, true);
	}

	// Token: 0x17000A8E RID: 2702
	// (get) Token: 0x06007BA2 RID: 31650 RVA: 0x001A15AB File Offset: 0x0019F7AB
	public static ActivityDailyAdventureConfig Instance
	{
		get
		{
			return ActivityDailyAdventureConfig._Instance;
		}
	}

	// Token: 0x06007BA3 RID: 31651 RVA: 0x001A15B2 File Offset: 0x0019F7B2
	public static ActivityDailyAdventureConfig GetOrCreateInstance()
	{
		if (ActivityDailyAdventureConfig._Instance == null)
		{
			ActivityDailyAdventureConfig.CreateInstance();
		}
		return ActivityDailyAdventureConfig._Instance;
	}

	// Token: 0x06007BA4 RID: 31652 RVA: 0x001A15C6 File Offset: 0x0019F7C6
	public static bool CreateInstance()
	{
		if (ActivityDailyAdventureConfig._Instance != null)
		{
			return true;
		}
		ActivityDailyAdventureConfig._Instance = new ActivityDailyAdventureConfig();
		return true;
	}

	// Token: 0x06007BA5 RID: 31653 RVA: 0x001A15DC File Offset: 0x0019F7DC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007BA6 RID: 31654 RVA: 0x001A15DE File Offset: 0x0019F7DE
	public static void ResetStaticDefaultValue()
	{
		ActivityDailyAdventureConfig._Instance = null;
	}

	// Token: 0x06007BA7 RID: 31655 RVA: 0x001A15E6 File Offset: 0x0019F7E6
	static ActivityDailyAdventureConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityDailyAdventureConfig.CreateStaticDefaultValue), new Action(ActivityDailyAdventureConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040038A5 RID: 14501
	[Nullable(2)]
	private static ActivityDailyAdventureConfig _Instance;
}
