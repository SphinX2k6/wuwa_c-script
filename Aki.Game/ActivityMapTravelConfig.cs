using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012CA RID: 4810
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityMapTravelConfig : ConfigBase
{
	// Token: 0x06008448 RID: 33864 RVA: 0x001C2A4C File Offset: 0x001C0C4C
	public MapTravelConfig? GetActivityConfig(int activityId)
	{
		return ConfigMapTravelConfigByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x06008449 RID: 33865 RVA: 0x001C2A55 File Offset: 0x001C0C55
	public MapLevelExp? GetLevelExpConfig(int id)
	{
		return ConfigMapLevelExpById.GetConfig(id, true);
	}

	// Token: 0x0600844A RID: 33866 RVA: 0x001C2A5E File Offset: 0x001C0C5E
	public IReadOnlyList<MapLevelExp> GetAllLevelExpConfig(int activityId)
	{
		return ConfigMapLevelExpByActivityId.GetConfigList(activityId, true) ?? new MapLevelExp[0];
	}

	// Token: 0x0600844B RID: 33867 RVA: 0x001C2A71 File Offset: 0x001C0C71
	public TravelTask? GetTravelTaskConfig(int taskId)
	{
		return ConfigTravelTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x0600844C RID: 33868 RVA: 0x001C2A7A File Offset: 0x001C0C7A
	public IReadOnlyList<TravelTask> GetAllTravelTaskConfig(int activityId)
	{
		return ConfigTravelTaskByActivityId.GetConfigList(activityId, true) ?? new TravelTask[0];
	}

	// Token: 0x0600844D RID: 33869 RVA: 0x001C2A8D File Offset: 0x001C0C8D
	public TravelTaskArea? GetAreaConfig(int id)
	{
		return ConfigTravelTaskAreaById.GetConfig(id, true);
	}

	// Token: 0x0600844E RID: 33870 RVA: 0x001C2A96 File Offset: 0x001C0C96
	public IReadOnlyList<TravelTaskArea> GetAllAreaConfig(int activityId)
	{
		return ConfigTravelTaskAreaByActivityId.GetConfigList(activityId, true) ?? new TravelTaskArea[0];
	}

	// Token: 0x0600844F RID: 33871 RVA: 0x001C2AA9 File Offset: 0x001C0CA9
	public TravelPhantomQuest? GetQuestConfig(int id)
	{
		return ConfigTravelPhantomQuestById.GetConfig(id, true);
	}

	// Token: 0x06008450 RID: 33872 RVA: 0x001C2AB2 File Offset: 0x001C0CB2
	public TravelPhantomQuest? GetQuestConfigByMapMarkId(int markId)
	{
		return ConfigTravelPhantomQuestByMapMarkId.GetConfig(markId, true);
	}

	// Token: 0x06008451 RID: 33873 RVA: 0x001C2ABB File Offset: 0x001C0CBB
	public IReadOnlyList<TravelPhantomQuest> GetAllQuestConfig(int activityId)
	{
		return ConfigTravelPhantomQuestByActivityId.GetConfigList(activityId, true) ?? new TravelPhantomQuest[0];
	}

	// Token: 0x06008452 RID: 33874 RVA: 0x001C2ACE File Offset: 0x001C0CCE
	public PhantomGain? GetPhantomConfig(int id)
	{
		return ConfigPhantomGainById.GetConfig(id, true);
	}

	// Token: 0x06008453 RID: 33875 RVA: 0x001C2AD7 File Offset: 0x001C0CD7
	public IReadOnlyList<PhantomGain> GetAllPhantomConfig(int activityId)
	{
		return ConfigPhantomGainByActivityId.GetConfigList(activityId, true) ?? new PhantomGain[0];
	}

	// Token: 0x06008454 RID: 33876 RVA: 0x001C2AEA File Offset: 0x001C0CEA
	public IReadOnlyList<SoarChallenge> GetAllSoarChallengeConfig()
	{
		return ConfigSoarChallengeAll.GetConfigList(true) ?? new SoarChallenge[0];
	}

	// Token: 0x06008455 RID: 33877 RVA: 0x001C2AFC File Offset: 0x001C0CFC
	public SoarChallenge? GetSoarChallengeConfig(int id)
	{
		return ConfigSoarChallengeById.GetConfig(id, true);
	}

	// Token: 0x17000B46 RID: 2886
	// (get) Token: 0x06008456 RID: 33878 RVA: 0x001C2B05 File Offset: 0x001C0D05
	public static ActivityMapTravelConfig Instance
	{
		get
		{
			return ActivityMapTravelConfig._Instance;
		}
	}

	// Token: 0x06008457 RID: 33879 RVA: 0x001C2B0C File Offset: 0x001C0D0C
	public static ActivityMapTravelConfig GetOrCreateInstance()
	{
		if (ActivityMapTravelConfig._Instance == null)
		{
			ActivityMapTravelConfig.CreateInstance();
		}
		return ActivityMapTravelConfig._Instance;
	}

	// Token: 0x06008458 RID: 33880 RVA: 0x001C2B20 File Offset: 0x001C0D20
	public static bool CreateInstance()
	{
		if (ActivityMapTravelConfig._Instance != null)
		{
			return true;
		}
		ActivityMapTravelConfig._Instance = new ActivityMapTravelConfig();
		return true;
	}

	// Token: 0x06008459 RID: 33881 RVA: 0x001C2B36 File Offset: 0x001C0D36
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600845A RID: 33882 RVA: 0x001C2B38 File Offset: 0x001C0D38
	public static void ResetStaticDefaultValue()
	{
		ActivityMapTravelConfig._Instance = null;
	}

	// Token: 0x0600845B RID: 33883 RVA: 0x001C2B40 File Offset: 0x001C0D40
	static ActivityMapTravelConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapTravelConfig.CreateStaticDefaultValue), new Action(ActivityMapTravelConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003B73 RID: 15219
	[Nullable(2)]
	private static ActivityMapTravelConfig _Instance;
}
