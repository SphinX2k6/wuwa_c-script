using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012E6 RID: 4838
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityMoonChasingConfig : ConfigBase
{
	// Token: 0x0600858D RID: 34189 RVA: 0x001C728A File Offset: 0x001C548A
	public TrackMoonActivity? GetActivityMoonChasingConfig(int activityId)
	{
		return ConfigTrackMoonActivityById.GetConfig(activityId, true);
	}

	// Token: 0x0600858E RID: 34190 RVA: 0x001C7293 File Offset: 0x001C5493
	public IReadOnlyList<TrackMoonActivityReward> GetAllActivityMoonChasingRewardConfig()
	{
		return ConfigTrackMoonActivityRewardAll.GetConfigList(true) ?? new List<TrackMoonActivityReward>();
	}

	// Token: 0x0600858F RID: 34191 RVA: 0x001C72A4 File Offset: 0x001C54A4
	public TrackMoonActivityReward? GetActivityMoonChasingRewardConfigById(int id)
	{
		return ConfigTrackMoonActivityRewardById.GetConfig(id, true);
	}

	// Token: 0x17000B77 RID: 2935
	// (get) Token: 0x06008590 RID: 34192 RVA: 0x001C72AD File Offset: 0x001C54AD
	public static ActivityMoonChasingConfig Instance
	{
		get
		{
			return ActivityMoonChasingConfig._Instance;
		}
	}

	// Token: 0x06008591 RID: 34193 RVA: 0x001C72B4 File Offset: 0x001C54B4
	public static ActivityMoonChasingConfig GetOrCreateInstance()
	{
		if (ActivityMoonChasingConfig._Instance == null)
		{
			ActivityMoonChasingConfig.CreateInstance();
		}
		return ActivityMoonChasingConfig._Instance;
	}

	// Token: 0x06008592 RID: 34194 RVA: 0x001C72C8 File Offset: 0x001C54C8
	public static bool CreateInstance()
	{
		if (ActivityMoonChasingConfig._Instance != null)
		{
			return true;
		}
		ActivityMoonChasingConfig._Instance = new ActivityMoonChasingConfig();
		return true;
	}

	// Token: 0x06008593 RID: 34195 RVA: 0x001C72DE File Offset: 0x001C54DE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008594 RID: 34196 RVA: 0x001C72E0 File Offset: 0x001C54E0
	public static void ResetStaticDefaultValue()
	{
		ActivityMoonChasingConfig._Instance = null;
	}

	// Token: 0x06008595 RID: 34197 RVA: 0x001C72E8 File Offset: 0x001C54E8
	static ActivityMoonChasingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMoonChasingConfig.CreateStaticDefaultValue), new Action(ActivityMoonChasingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003BF4 RID: 15348
	[Nullable(2)]
	private static ActivityMoonChasingConfig _Instance;
}
