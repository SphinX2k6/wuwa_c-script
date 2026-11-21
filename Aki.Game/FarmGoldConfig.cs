using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000716 RID: 1814
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FarmGoldConfig : ConfigBase
{
	// Token: 0x06005388 RID: 21384 RVA: 0x001B9EF8 File Offset: 0x001B80F8
	public FarmGoldMapMark GetFarmGoldMarkByActivityId(int id)
	{
		return ConfigFarmGoldMapMarkByActivityId.GetConfig(id, true).Value;
	}

	// Token: 0x06005389 RID: 21385 RVA: 0x001B9F14 File Offset: 0x001B8114
	public IReadOnlyList<FarmGoldActivity> GetAllFarmGoldActivity()
	{
		return ConfigFarmGoldActivityAll.GetConfigList(true) ?? new List<FarmGoldActivity>();
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x001B9F25 File Offset: 0x001B8125
	public FarmGoldActivity GetFarmGoldConfigByActivityIdAndInstId(int activityId, int instId)
	{
		return ConfigFarmGoldActivityByActivityIdAndInstanceId.GetConfigList(activityId, instId, true)[0];
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x001B9F35 File Offset: 0x001B8135
	public FarmGoldScore? GetScoreConfigById(int id)
	{
		return ConfigFarmGoldScoreById.GetConfig(id, true);
	}

	// Token: 0x0600538C RID: 21388 RVA: 0x001B9F3E File Offset: 0x001B813E
	public IReadOnlyList<FarmGoldScore> GetScoreConfigByActivityId(int activityId)
	{
		return ConfigFarmGoldScoreByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x0600538D RID: 21389 RVA: 0x001B9F47 File Offset: 0x001B8147
	public IReadOnlyList<FarmGoldDifficulty> GetFarmGoldAllDifficult()
	{
		return ConfigFarmGoldDifficultyAll.GetConfigList(true) ?? new List<FarmGoldDifficulty>();
	}

	// Token: 0x0600538E RID: 21390 RVA: 0x001B9F58 File Offset: 0x001B8158
	public IReadOnlyList<FarmGoldDifficulty> GetFarmGoldDifficultList(int activityId, int instId)
	{
		List<FarmGoldDifficulty> list = new List<FarmGoldDifficulty>();
		foreach (int p0Id in this.GetFarmGoldConfigByActivityIdAndInstId(activityId, instId).DifficultyOptionsIter())
		{
			FarmGoldDifficulty? config = ConfigFarmGoldDifficultyById.GetConfig(p0Id, true);
			if (config != null)
			{
				list.Add(config.Value);
			}
		}
		return list;
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x001B9FCC File Offset: 0x001B81CC
	public FarmGoldDifficulty GetFarmGoldDifficultById(int id)
	{
		return ConfigFarmGoldDifficultyById.GetConfig(id, true).Value;
	}

	// Token: 0x06005390 RID: 21392 RVA: 0x001B9FE8 File Offset: 0x001B81E8
	public string GetFarmGoldEntranceName()
	{
		return ConfigCommonParamById.GetStringConfig("FarmGoldEntranceName") ?? "";
	}

	// Token: 0x06005391 RID: 21393 RVA: 0x001B9FFD File Offset: 0x001B81FD
	public string GetFarmGoldEntranceSpritePath()
	{
		return ConfigCommonParamById.GetStringConfig("FarmGoldEntranceSpritePath") ?? "";
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x001BA014 File Offset: 0x001B8214
	public int GetFarmGoldEntranceHelpId()
	{
		return ConfigCommonParamById.GetIntConfig("FarmGoldEntranceHelpId").GetValueOrDefault();
	}

	// Token: 0x17000B09 RID: 2825
	// (get) Token: 0x06005393 RID: 21395 RVA: 0x001BA033 File Offset: 0x001B8233
	public static FarmGoldConfig Instance
	{
		get
		{
			return FarmGoldConfig._Instance;
		}
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x001BA03A File Offset: 0x001B823A
	public static FarmGoldConfig GetOrCreateInstance()
	{
		if (FarmGoldConfig._Instance == null)
		{
			FarmGoldConfig.CreateInstance();
		}
		return FarmGoldConfig._Instance;
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x001BA04E File Offset: 0x001B824E
	public static bool CreateInstance()
	{
		if (FarmGoldConfig._Instance != null)
		{
			return true;
		}
		FarmGoldConfig._Instance = new FarmGoldConfig();
		return true;
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x001BA064 File Offset: 0x001B8264
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005397 RID: 21399 RVA: 0x001BA066 File Offset: 0x001B8266
	public static void ResetStaticDefaultValue()
	{
		FarmGoldConfig._Instance = null;
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x001BA06E File Offset: 0x001B826E
	static FarmGoldConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FarmGoldConfig.CreateStaticDefaultValue), new Action(FarmGoldConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003AC2 RID: 15042
	[Nullable(2)]
	private static FarmGoldConfig _Instance;
}
