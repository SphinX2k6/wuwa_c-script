using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001536 RID: 5430
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityTurntableConfig : ConfigBase
{
	// Token: 0x06009B26 RID: 39718 RVA: 0x002197BD File Offset: 0x002179BD
	public IReadOnlyList<TurntableAwards> GetTurntableAwardsByActivityId(int activityId)
	{
		return ConfigTurntableAwardsByActivityId.GetConfigList(activityId, true) ?? Array.Empty<TurntableAwards>();
	}

	// Token: 0x06009B27 RID: 39719 RVA: 0x002197CF File Offset: 0x002179CF
	public TurntableInfo? GetTurntableInfoByActivityId(int activityId)
	{
		return ConfigTurntableInfoById.GetConfig(activityId, true);
	}

	// Token: 0x06009B28 RID: 39720 RVA: 0x002197D8 File Offset: 0x002179D8
	public IReadOnlyList<TurntableActivity> GetTurntableActivityByActivityId(int activityId)
	{
		return ConfigTurntableActivityByActivityId.GetConfigList(activityId, true) ?? Array.Empty<TurntableActivity>();
	}

	// Token: 0x06009B29 RID: 39721 RVA: 0x002197EA File Offset: 0x002179EA
	public TurntableTask? GetTurntableTaskByTaskId(int taskId)
	{
		return ConfigTurntableTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x17000D4E RID: 3406
	// (get) Token: 0x06009B2A RID: 39722 RVA: 0x002197F3 File Offset: 0x002179F3
	public static ActivityTurntableConfig Instance
	{
		get
		{
			return ActivityTurntableConfig._Instance;
		}
	}

	// Token: 0x06009B2B RID: 39723 RVA: 0x002197FA File Offset: 0x002179FA
	public static ActivityTurntableConfig GetOrCreateInstance()
	{
		if (ActivityTurntableConfig._Instance == null)
		{
			ActivityTurntableConfig.CreateInstance();
		}
		return ActivityTurntableConfig._Instance;
	}

	// Token: 0x06009B2C RID: 39724 RVA: 0x0021980E File Offset: 0x00217A0E
	public static bool CreateInstance()
	{
		if (ActivityTurntableConfig._Instance != null)
		{
			return true;
		}
		ActivityTurntableConfig._Instance = new ActivityTurntableConfig();
		return true;
	}

	// Token: 0x06009B2D RID: 39725 RVA: 0x00219824 File Offset: 0x00217A24
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009B2E RID: 39726 RVA: 0x00219826 File Offset: 0x00217A26
	public static void ResetStaticDefaultValue()
	{
		ActivityTurntableConfig._Instance = null;
	}

	// Token: 0x06009B2F RID: 39727 RVA: 0x0021982E File Offset: 0x00217A2E
	static ActivityTurntableConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTurntableConfig.CreateStaticDefaultValue), new Action(ActivityTurntableConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04004439 RID: 17465
	[Nullable(2)]
	private static ActivityTurntableConfig _Instance;
}
