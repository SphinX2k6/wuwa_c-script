using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001262 RID: 4706
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FarmGoldConfig : ConfigBase
{
	// Token: 0x06007FF1 RID: 32753 RVA: 0x001B1228 File Offset: 0x001AF428
	public FarmGoldMapMark GetFarmGoldMarkByActivityId(int id)
	{
		return ConfigFarmGoldMapMarkByActivityId.GetConfig(id, true).Value;
	}

	// Token: 0x06007FF2 RID: 32754 RVA: 0x001B1244 File Offset: 0x001AF444
	public IReadOnlyList<FarmGoldActivity> GetAllFarmGoldActivity()
	{
		return ConfigFarmGoldActivityAll.GetConfigList(true) ?? new List<FarmGoldActivity>();
	}

	// Token: 0x06007FF3 RID: 32755 RVA: 0x001B1255 File Offset: 0x001AF455
	public FarmGoldActivity GetFarmGoldConfigByActivityIdAndInstId(int activityId, int instId)
	{
		return ConfigFarmGoldActivityByActivityIdAndInstanceId.GetConfigList(activityId, instId, true)[0];
	}

	// Token: 0x06007FF4 RID: 32756 RVA: 0x001B1265 File Offset: 0x001AF465
	public FarmGoldScore? GetScoreConfigById(int id)
	{
		return ConfigFarmGoldScoreById.GetConfig(id, true);
	}

	// Token: 0x06007FF5 RID: 32757 RVA: 0x001B126E File Offset: 0x001AF46E
	public IReadOnlyList<FarmGoldScore> GetScoreConfigByActivityId(int activityId)
	{
		return ConfigFarmGoldScoreByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x06007FF6 RID: 32758 RVA: 0x001B1277 File Offset: 0x001AF477
	public IReadOnlyList<FarmGoldDifficulty> GetFarmGoldAllDifficult()
	{
		return ConfigFarmGoldDifficultyAll.GetConfigList(true) ?? new List<FarmGoldDifficulty>();
	}

	// Token: 0x06007FF7 RID: 32759 RVA: 0x001B1288 File Offset: 0x001AF488
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

	// Token: 0x06007FF8 RID: 32760 RVA: 0x001B12FC File Offset: 0x001AF4FC
	public FarmGoldDifficulty GetFarmGoldDifficultById(int id)
	{
		return ConfigFarmGoldDifficultyById.GetConfig(id, true).Value;
	}

	// Token: 0x06007FF9 RID: 32761 RVA: 0x001B1318 File Offset: 0x001AF518
	public string GetFarmGoldEntranceName()
	{
		return ConfigCommonParamById.GetStringConfig("FarmGoldEntranceName") ?? "";
	}

	// Token: 0x06007FFA RID: 32762 RVA: 0x001B132D File Offset: 0x001AF52D
	public string GetFarmGoldEntranceSpritePath()
	{
		return ConfigCommonParamById.GetStringConfig("FarmGoldEntranceSpritePath") ?? "";
	}

	// Token: 0x06007FFB RID: 32763 RVA: 0x001B1344 File Offset: 0x001AF544
	public int GetFarmGoldEntranceHelpId()
	{
		return ConfigCommonParamById.GetIntConfig("FarmGoldEntranceHelpId").GetValueOrDefault();
	}

	// Token: 0x17000AE9 RID: 2793
	// (get) Token: 0x06007FFC RID: 32764 RVA: 0x001B1363 File Offset: 0x001AF563
	public static FarmGoldConfig Instance
	{
		get
		{
			return FarmGoldConfig._Instance;
		}
	}

	// Token: 0x06007FFD RID: 32765 RVA: 0x001B136A File Offset: 0x001AF56A
	public static FarmGoldConfig GetOrCreateInstance()
	{
		if (FarmGoldConfig._Instance == null)
		{
			FarmGoldConfig.CreateInstance();
		}
		return FarmGoldConfig._Instance;
	}

	// Token: 0x06007FFE RID: 32766 RVA: 0x001B137E File Offset: 0x001AF57E
	public static bool CreateInstance()
	{
		if (FarmGoldConfig._Instance != null)
		{
			return true;
		}
		FarmGoldConfig._Instance = new FarmGoldConfig();
		return true;
	}

	// Token: 0x06007FFF RID: 32767 RVA: 0x001B1394 File Offset: 0x001AF594
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008000 RID: 32768 RVA: 0x001B1396 File Offset: 0x001AF596
	public static void ResetStaticDefaultValue()
	{
		FarmGoldConfig._Instance = null;
	}

	// Token: 0x06008001 RID: 32769 RVA: 0x001B139E File Offset: 0x001AF59E
	static FarmGoldConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FarmGoldConfig.CreateStaticDefaultValue), new Action(FarmGoldConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003A2A RID: 14890
	[Nullable(2)]
	private static FarmGoldConfig _Instance;
}
