using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200151C RID: 5404
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityTimePointRewardConfig : ConfigBase
{
	// Token: 0x06009A1A RID: 39450 RVA: 0x002157D5 File Offset: 0x002139D5
	public TimePointRewardActivity? GetTimePointRewardById(int id)
	{
		return ConfigTimePointRewardActivityById.GetConfig(id, true);
	}

	// Token: 0x06009A1B RID: 39451 RVA: 0x002157DE File Offset: 0x002139DE
	public TimePointRewardConfig? GetConfigByActivityId(int actId)
	{
		return ConfigTimePointRewardConfigByActivityId.GetConfig(actId, true);
	}

	// Token: 0x06009A1C RID: 39452 RVA: 0x002157E7 File Offset: 0x002139E7
	[NullableContext(2)]
	public IReadOnlyList<TimePointRewardActivity> GetTimePointRewardListByActivityId(int actId)
	{
		return ConfigTimePointRewardActivityByActivityId.GetConfigList(actId, true);
	}

	// Token: 0x17000D40 RID: 3392
	// (get) Token: 0x06009A1D RID: 39453 RVA: 0x002157F0 File Offset: 0x002139F0
	public static ActivityTimePointRewardConfig Instance
	{
		get
		{
			return ActivityTimePointRewardConfig._Instance;
		}
	}

	// Token: 0x06009A1E RID: 39454 RVA: 0x002157F7 File Offset: 0x002139F7
	public static ActivityTimePointRewardConfig GetOrCreateInstance()
	{
		if (ActivityTimePointRewardConfig._Instance == null)
		{
			ActivityTimePointRewardConfig.CreateInstance();
		}
		return ActivityTimePointRewardConfig._Instance;
	}

	// Token: 0x06009A1F RID: 39455 RVA: 0x0021580B File Offset: 0x00213A0B
	public static bool CreateInstance()
	{
		if (ActivityTimePointRewardConfig._Instance != null)
		{
			return true;
		}
		ActivityTimePointRewardConfig._Instance = new ActivityTimePointRewardConfig();
		return true;
	}

	// Token: 0x06009A20 RID: 39456 RVA: 0x00215821 File Offset: 0x00213A21
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009A21 RID: 39457 RVA: 0x00215823 File Offset: 0x00213A23
	public static void ResetStaticDefaultValue()
	{
		ActivityTimePointRewardConfig._Instance = null;
	}

	// Token: 0x06009A22 RID: 39458 RVA: 0x0021582B File Offset: 0x00213A2B
	static ActivityTimePointRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityTimePointRewardConfig.CreateStaticDefaultValue), new Action(ActivityTimePointRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040043D3 RID: 17363
	[Nullable(2)]
	private static ActivityTimePointRewardConfig _Instance;
}
