using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200077E RID: 1918
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ActivityMapTravelConfig : ConfigBase
{
	// Token: 0x060057E3 RID: 22499 RVA: 0x001CB8A8 File Offset: 0x001C9AA8
	public MapTravelConfig? GetActivityConfig(int activityId)
	{
		return ConfigMapTravelConfigByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x060057E4 RID: 22500 RVA: 0x001CB8B1 File Offset: 0x001C9AB1
	public MapLevelExp? GetLevelExpConfig(int id)
	{
		return ConfigMapLevelExpById.GetConfig(id, true);
	}

	// Token: 0x060057E5 RID: 22501 RVA: 0x001CB8BA File Offset: 0x001C9ABA
	public IReadOnlyList<MapLevelExp> GetAllLevelExpConfig(int activityId)
	{
		return ConfigMapLevelExpByActivityId.GetConfigList(activityId, true) ?? new MapLevelExp[0];
	}

	// Token: 0x060057E6 RID: 22502 RVA: 0x001CB8CD File Offset: 0x001C9ACD
	public TravelTask? GetTravelTaskConfig(int taskId)
	{
		return ConfigTravelTaskByTaskId.GetConfig(taskId, true);
	}

	// Token: 0x060057E7 RID: 22503 RVA: 0x001CB8D6 File Offset: 0x001C9AD6
	public IReadOnlyList<TravelTask> GetAllTravelTaskConfig(int activityId)
	{
		return ConfigTravelTaskByActivityId.GetConfigList(activityId, true) ?? new TravelTask[0];
	}

	// Token: 0x060057E8 RID: 22504 RVA: 0x001CB8E9 File Offset: 0x001C9AE9
	public TravelTaskArea? GetAreaConfig(int id)
	{
		return ConfigTravelTaskAreaById.GetConfig(id, true);
	}

	// Token: 0x060057E9 RID: 22505 RVA: 0x001CB8F2 File Offset: 0x001C9AF2
	public IReadOnlyList<TravelTaskArea> GetAllAreaConfig(int activityId)
	{
		return ConfigTravelTaskAreaByActivityId.GetConfigList(activityId, true) ?? new TravelTaskArea[0];
	}

	// Token: 0x060057EA RID: 22506 RVA: 0x001CB905 File Offset: 0x001C9B05
	public TravelPhantomQuest? GetQuestConfig(int id)
	{
		return ConfigTravelPhantomQuestById.GetConfig(id, true);
	}

	// Token: 0x060057EB RID: 22507 RVA: 0x001CB90E File Offset: 0x001C9B0E
	public TravelPhantomQuest? GetQuestConfigByMapMarkId(int markId)
	{
		return ConfigTravelPhantomQuestByMapMarkId.GetConfig(markId, true);
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x001CB917 File Offset: 0x001C9B17
	public IReadOnlyList<TravelPhantomQuest> GetAllQuestConfig(int activityId)
	{
		return ConfigTravelPhantomQuestByActivityId.GetConfigList(activityId, true) ?? new TravelPhantomQuest[0];
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x001CB92A File Offset: 0x001C9B2A
	public PhantomGain? GetPhantomConfig(int id)
	{
		return ConfigPhantomGainById.GetConfig(id, true);
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x001CB933 File Offset: 0x001C9B33
	public IReadOnlyList<PhantomGain> GetAllPhantomConfig(int activityId)
	{
		return ConfigPhantomGainByActivityId.GetConfigList(activityId, true) ?? new PhantomGain[0];
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x001CB946 File Offset: 0x001C9B46
	public IReadOnlyList<SoarChallenge> GetAllSoarChallengeConfig()
	{
		return ConfigSoarChallengeAll.GetConfigList(true) ?? new SoarChallenge[0];
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x001CB958 File Offset: 0x001C9B58
	public SoarChallenge? GetSoarChallengeConfig(int id)
	{
		return ConfigSoarChallengeById.GetConfig(id, true);
	}

	// Token: 0x17000B66 RID: 2918
	// (get) Token: 0x060057F1 RID: 22513 RVA: 0x001CB961 File Offset: 0x001C9B61
	public static ActivityMapTravelConfig Instance
	{
		get
		{
			return ActivityMapTravelConfig._Instance;
		}
	}

	// Token: 0x060057F2 RID: 22514 RVA: 0x001CB968 File Offset: 0x001C9B68
	public static ActivityMapTravelConfig GetOrCreateInstance()
	{
		if (ActivityMapTravelConfig._Instance == null)
		{
			ActivityMapTravelConfig.CreateInstance();
		}
		return ActivityMapTravelConfig._Instance;
	}

	// Token: 0x060057F3 RID: 22515 RVA: 0x001CB97C File Offset: 0x001C9B7C
	public static bool CreateInstance()
	{
		if (ActivityMapTravelConfig._Instance != null)
		{
			return true;
		}
		ActivityMapTravelConfig._Instance = new ActivityMapTravelConfig();
		return true;
	}

	// Token: 0x060057F4 RID: 22516 RVA: 0x001CB992 File Offset: 0x001C9B92
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060057F5 RID: 22517 RVA: 0x001CB994 File Offset: 0x001C9B94
	public static void ResetStaticDefaultValue()
	{
		ActivityMapTravelConfig._Instance = null;
	}

	// Token: 0x060057F6 RID: 22518 RVA: 0x001CB99C File Offset: 0x001C9B9C
	static ActivityMapTravelConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityMapTravelConfig.CreateStaticDefaultValue), new Action(ActivityMapTravelConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003C0B RID: 15371
	[Nullable(2)]
	private static ActivityMapTravelConfig _Instance;
}
