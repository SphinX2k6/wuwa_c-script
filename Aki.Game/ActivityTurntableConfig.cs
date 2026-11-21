using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020009EE RID: 2542
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityTurntableConfig : ConfigBase
{
	// Token: 0x06006F04 RID: 28420 RVA: 0x0022355E File Offset: 0x0022175E
	public IReadOnlyList<TurntableAwards> GetTurntableAwardsByActivityId(int activityId)
	{
		return ConfigTurntableAwardsByActivityId.GetConfigList(activityId, true) ?? Array.Empty<TurntableAwards>();
	}

	// Token: 0x06006F05 RID: 28421 RVA: 0x00223570 File Offset: 0x00221770
	public TurntableInfo? GetTurntableInfoByActivityId(int activityId)
	{
		return ConfigTurntableInfoById.GetConfig(activityId, true);
	}

	// Token: 0x06006F06 RID: 28422 RVA: 0x00223579 File Offset: 0x00221779
	public IReadOnlyList<TurntableActivity> GetTurntableActivityByActivityId(int activityId)
	{
		return ConfigTurntableActivityByActivityId.GetConfigList(activityId, true) ?? Array.Empty<TurntableActivity>();
	}

	// Token: 0x06006F07 RID: 28423 RVA: 0x0022358B File Offset: 0x0022178B
	public TurntableTask? GetTurntableTaskByTaskId(int taskId)
	{
		return ConfigTurntableTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x17000D6F RID: 3439
	// (get) Token: 0x06006F08 RID: 28424 RVA: 0x00223594 File Offset: 0x00221794
	public static ActivityTurntableConfig Instance
	{
		get
		{
			return ActivityTurntableConfig._Instance;
		}
	}

	// Token: 0x06006F09 RID: 28425 RVA: 0x0022359B File Offset: 0x0022179B
	public static ActivityTurntableConfig GetOrCreateInstance()
	{
		if (ActivityTurntableConfig._Instance == null)
		{
			ActivityTurntableConfig.CreateInstance();
		}
		return ActivityTurntableConfig._Instance;
	}

	// Token: 0x06006F0A RID: 28426 RVA: 0x002235AF File Offset: 0x002217AF
	public static bool CreateInstance()
	{
		if (ActivityTurntableConfig._Instance != null)
		{
			return true;
		}
		ActivityTurntableConfig._Instance = new ActivityTurntableConfig();
		return true;
	}

	// Token: 0x06006F0B RID: 28427 RVA: 0x002235C5 File Offset: 0x002217C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006F0C RID: 28428 RVA: 0x002235C7 File Offset: 0x002217C7
	public static void ResetStaticDefaultValue()
	{
		ActivityTurntableConfig._Instance = null;
	}

	// Token: 0x06006F0D RID: 28429 RVA: 0x002235CF File Offset: 0x002217CF
	static ActivityTurntableConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTurntableConfig.CreateStaticDefaultValue), new Action(ActivityTurntableConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040044DF RID: 17631
	[Nullable(2)]
	private static ActivityTurntableConfig _Instance;
}
