using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020013DA RID: 5082
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityPhantomCollectConfig : ConfigBase
{
	// Token: 0x06008F76 RID: 36726 RVA: 0x001F020E File Offset: 0x001EE40E
	public PhantomCollectActivity? GetPhantomCollectConfig(int activityId)
	{
		return ConfigPhantomCollectActivityById.GetConfig(activityId, true);
	}

	// Token: 0x06008F77 RID: 36727 RVA: 0x001F0217 File Offset: 0x001EE417
	public PhantomCollectTaskDesc? GetPhantomCollectTaskDesc(int taskType)
	{
		return ConfigPhantomCollectTaskDescById.GetConfig(taskType, true);
	}

	// Token: 0x17000C04 RID: 3076
	// (get) Token: 0x06008F78 RID: 36728 RVA: 0x001F0220 File Offset: 0x001EE420
	public static ActivityPhantomCollectConfig Instance
	{
		get
		{
			return ActivityPhantomCollectConfig._Instance;
		}
	}

	// Token: 0x06008F79 RID: 36729 RVA: 0x001F0227 File Offset: 0x001EE427
	public static ActivityPhantomCollectConfig GetOrCreateInstance()
	{
		if (ActivityPhantomCollectConfig._Instance == null)
		{
			ActivityPhantomCollectConfig.CreateInstance();
		}
		return ActivityPhantomCollectConfig._Instance;
	}

	// Token: 0x06008F7A RID: 36730 RVA: 0x001F023B File Offset: 0x001EE43B
	public static bool CreateInstance()
	{
		if (ActivityPhantomCollectConfig._Instance != null)
		{
			return true;
		}
		ActivityPhantomCollectConfig._Instance = new ActivityPhantomCollectConfig();
		return true;
	}

	// Token: 0x06008F7B RID: 36731 RVA: 0x001F0251 File Offset: 0x001EE451
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008F7C RID: 36732 RVA: 0x001F0253 File Offset: 0x001EE453
	public static void ResetStaticDefaultValue()
	{
		ActivityPhantomCollectConfig._Instance = null;
	}

	// Token: 0x06008F7D RID: 36733 RVA: 0x001F025B File Offset: 0x001EE45B
	static ActivityPhantomCollectConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityPhantomCollectConfig.CreateStaticDefaultValue), new Action(ActivityPhantomCollectConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003F73 RID: 16243
	[Nullable(2)]
	private static ActivityPhantomCollectConfig _Instance;
}
