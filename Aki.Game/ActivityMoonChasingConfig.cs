using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200079A RID: 1946
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityMoonChasingConfig : ConfigBase
{
	// Token: 0x06005928 RID: 22824 RVA: 0x001D00F6 File Offset: 0x001CE2F6
	public TrackMoonActivity? GetActivityMoonChasingConfig(int activityId)
	{
		return ConfigTrackMoonActivityById.GetConfig(activityId, true);
	}

	// Token: 0x06005929 RID: 22825 RVA: 0x001D00FF File Offset: 0x001CE2FF
	public IReadOnlyList<TrackMoonActivityReward> GetAllActivityMoonChasingRewardConfig()
	{
		return ConfigTrackMoonActivityRewardAll.GetConfigList(true) ?? new List<TrackMoonActivityReward>();
	}

	// Token: 0x0600592A RID: 22826 RVA: 0x001D0110 File Offset: 0x001CE310
	public TrackMoonActivityReward? GetActivityMoonChasingRewardConfigById(int id)
	{
		return ConfigTrackMoonActivityRewardById.GetConfig(id, true);
	}

	// Token: 0x17000B97 RID: 2967
	// (get) Token: 0x0600592B RID: 22827 RVA: 0x001D0119 File Offset: 0x001CE319
	public static ActivityMoonChasingConfig Instance
	{
		get
		{
			return ActivityMoonChasingConfig._Instance;
		}
	}

	// Token: 0x0600592C RID: 22828 RVA: 0x001D0120 File Offset: 0x001CE320
	public static ActivityMoonChasingConfig GetOrCreateInstance()
	{
		if (ActivityMoonChasingConfig._Instance == null)
		{
			ActivityMoonChasingConfig.CreateInstance();
		}
		return ActivityMoonChasingConfig._Instance;
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x001D0134 File Offset: 0x001CE334
	public static bool CreateInstance()
	{
		if (ActivityMoonChasingConfig._Instance != null)
		{
			return true;
		}
		ActivityMoonChasingConfig._Instance = new ActivityMoonChasingConfig();
		return true;
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x001D014A File Offset: 0x001CE34A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x001D014C File Offset: 0x001CE34C
	public static void ResetStaticDefaultValue()
	{
		ActivityMoonChasingConfig._Instance = null;
	}

	// Token: 0x06005930 RID: 22832 RVA: 0x001D0154 File Offset: 0x001CE354
	static ActivityMoonChasingConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMoonChasingConfig.CreateStaticDefaultValue), new Action(ActivityMoonChasingConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003C8C RID: 15500
	[Nullable(2)]
	private static ActivityMoonChasingConfig _Instance;
}
