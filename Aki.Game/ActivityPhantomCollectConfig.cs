using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200088E RID: 2190
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityPhantomCollectConfig : ConfigBase
{
	// Token: 0x0600630B RID: 25355 RVA: 0x001F8D46 File Offset: 0x001F6F46
	public PhantomCollectActivity? GetPhantomCollectConfig(int activityId)
	{
		return ConfigPhantomCollectActivityById.GetConfig(activityId, true);
	}

	// Token: 0x0600630C RID: 25356 RVA: 0x001F8D4F File Offset: 0x001F6F4F
	public PhantomCollectTaskDesc? GetPhantomCollectTaskDesc(int taskType)
	{
		return ConfigPhantomCollectTaskDescById.GetConfig(taskType, true);
	}

	// Token: 0x17000C24 RID: 3108
	// (get) Token: 0x0600630D RID: 25357 RVA: 0x001F8D58 File Offset: 0x001F6F58
	public static ActivityPhantomCollectConfig Instance
	{
		get
		{
			return ActivityPhantomCollectConfig._Instance;
		}
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x001F8D5F File Offset: 0x001F6F5F
	public static ActivityPhantomCollectConfig GetOrCreateInstance()
	{
		if (ActivityPhantomCollectConfig._Instance == null)
		{
			ActivityPhantomCollectConfig.CreateInstance();
		}
		return ActivityPhantomCollectConfig._Instance;
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x001F8D73 File Offset: 0x001F6F73
	public static bool CreateInstance()
	{
		if (ActivityPhantomCollectConfig._Instance != null)
		{
			return true;
		}
		ActivityPhantomCollectConfig._Instance = new ActivityPhantomCollectConfig();
		return true;
	}

	// Token: 0x06006310 RID: 25360 RVA: 0x001F8D89 File Offset: 0x001F6F89
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006311 RID: 25361 RVA: 0x001F8D8B File Offset: 0x001F6F8B
	public static void ResetStaticDefaultValue()
	{
		ActivityPhantomCollectConfig._Instance = null;
	}

	// Token: 0x06006312 RID: 25362 RVA: 0x001F8D93 File Offset: 0x001F6F93
	static ActivityPhantomCollectConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPhantomCollectConfig.CreateStaticDefaultValue), new Action(ActivityPhantomCollectConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400400B RID: 16395
	[Nullable(2)]
	private static ActivityPhantomCollectConfig _Instance;
}
