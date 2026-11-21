using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200214A RID: 8522
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class TowerClimbConfig : ConfigBase
{
	// Token: 0x06014EC4 RID: 85700 RVA: 0x00617F98 File Offset: 0x00616198
	public int GetAreaFloorNumber(int season, int difficulty, int area)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = 0;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty && towerConfig.AreaNum == area)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06014EC5 RID: 85701 RVA: 0x00618008 File Offset: 0x00616208
	public int GetDifficultyFloorNumber(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = 0;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x06014EC6 RID: 85702 RVA: 0x0061806C File Offset: 0x0061626C
	public int GetDifficultyLastFloor(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = -1;
		int num2 = -1;
		int result = -1;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty)
				{
					if (num < towerConfig.AreaNum)
					{
						num = towerConfig.AreaNum;
						num2 = -1;
					}
					if (num2 < towerConfig.Floor)
					{
						result = towerConfig.Id;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06014EC7 RID: 85703 RVA: 0x006180FC File Offset: 0x006162FC
	public int[] GetDifficultyAllFloor(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		List<int> list = new List<int>();
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty)
				{
					list.Add(towerConfig.Id);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06014EC8 RID: 85704 RVA: 0x00618174 File Offset: 0x00616374
	public int[] GetDifficultyAllAreaFirstFloor(int season, int difficulty)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		int num = -1;
		List<int> list = new List<int>();
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == difficulty && num != towerConfig.AreaNum)
				{
					list.Add(towerConfig.Id);
					num = towerConfig.AreaNum;
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06014EC9 RID: 85705 RVA: 0x00618200 File Offset: 0x00616400
	public int[] GetDifficultyAreaAllFloor(int season, int difficulty, int area)
	{
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList((difficulty == 3) ? season : 0, true);
		List<int> list = new List<int>();
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (difficulty == towerConfig.Difficulty && area == towerConfig.AreaNum)
				{
					list.Add(towerConfig.Id);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06014ECA RID: 85706 RVA: 0x00618280 File Offset: 0x00616480
	[NullableContext(2)]
	public IReadOnlyList<IntPair> GetDifficultyReward(int difficulty, int rewardGroup)
	{
		if (rewardGroup == 0)
		{
			return null;
		}
		IReadOnlyList<TowerSeasonReward> configList = ConfigTowerSeasonRewardByDifficulty.GetConfigList(difficulty, true);
		if (configList == null)
		{
			return null;
		}
		foreach (TowerSeasonReward towerSeasonReward in configList)
		{
			if (towerSeasonReward.RewardGroup == rewardGroup)
			{
				return towerSeasonReward.Reward();
			}
		}
		return null;
	}

	// Token: 0x06014ECB RID: 85707 RVA: 0x006182EC File Offset: 0x006164EC
	public string GetTowerBuffDesc(long buffId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetTowerBuffConfig(buffId).Value.Desc, null);
	}

	// Token: 0x06014ECC RID: 85708 RVA: 0x00618318 File Offset: 0x00616518
	public string GetTowerBuffName(long buffId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(this.GetTowerBuffConfig(buffId).Value.Name, null);
	}

	// Token: 0x06014ECD RID: 85709 RVA: 0x00618344 File Offset: 0x00616544
	[NullableContext(2)]
	public string GetTowerBuffIcon(long buffId)
	{
		TowerBuff? towerBuffConfig = this.GetTowerBuffConfig(buffId);
		if (towerBuffConfig == null)
		{
			return null;
		}
		return towerBuffConfig.GetValueOrDefault().Icon;
	}

	// Token: 0x06014ECE RID: 85710 RVA: 0x00618374 File Offset: 0x00616574
	public TowerBuff? GetTowerBuffConfig(long buffId)
	{
		TowerBuff? config = ConfigTowerBuffById.GetConfig(buffId, true);
		if (config != null)
		{
			return config;
		}
		return null;
	}

	// Token: 0x06014ECF RID: 85711 RVA: 0x006183A0 File Offset: 0x006165A0
	[NullableContext(2)]
	public IReadOnlyList<int> GetFloorTarget(int floorId)
	{
		TowerConfig? config = ConfigTowerConfigById.GetConfig(floorId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().TargetConfig();
	}

	// Token: 0x06014ED0 RID: 85712 RVA: 0x006183CF File Offset: 0x006165CF
	public TowerTarget? GetTargetConfig(int targetId)
	{
		return ConfigTowerTargetById.GetConfig(targetId, true);
	}

	// Token: 0x06014ED1 RID: 85713 RVA: 0x006183D8 File Offset: 0x006165D8
	public int GetNextFloorInArea(int towerId)
	{
		TowerConfig? config = ConfigTowerConfigById.GetConfig(towerId, true);
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList(config.Value.Season, true);
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == config.Value.Difficulty && towerConfig.AreaNum == config.Value.AreaNum && towerConfig.Floor > config.Value.Floor)
				{
					return towerConfig.Id;
				}
			}
			return 0;
		}
		return 0;
	}

	// Token: 0x06014ED2 RID: 85714 RVA: 0x00618494 File Offset: 0x00616694
	public int GetLastFloorInArea(int towerId)
	{
		TowerConfig? config = ConfigTowerConfigById.GetConfig(towerId, true);
		if (config.Value.Floor == 1)
		{
			return 0;
		}
		IReadOnlyList<TowerConfig> configList = ConfigTowerConfigBySeason.GetConfigList(config.Value.Season, true);
		int result = 0;
		if (configList != null)
		{
			foreach (TowerConfig towerConfig in configList)
			{
				if (towerConfig.Difficulty == config.Value.Difficulty && towerConfig.AreaNum == config.Value.AreaNum && towerConfig.Floor < config.Value.Floor)
				{
					result = towerConfig.Id;
				}
			}
		}
		return result;
	}

	// Token: 0x06014ED3 RID: 85715 RVA: 0x00618564 File Offset: 0x00616764
	public TowerConfig? GetTowerInfo(int towerId)
	{
		return ConfigTowerConfigById.GetConfig(towerId, true);
	}

	// Token: 0x06014ED4 RID: 85716 RVA: 0x0061856D File Offset: 0x0061676D
	public TowerSeason? GetTowerSeason(int seasonId)
	{
		return ConfigTowerSeasonById.GetConfig(seasonId, true);
	}

	// Token: 0x06014ED5 RID: 85717 RVA: 0x00618578 File Offset: 0x00616778
	public string GetTowerAreaName(int towerId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(ConfigTowerConfigById.GetConfig(towerId, true).Value.AreaName, null);
	}

	// Token: 0x06014ED6 RID: 85718 RVA: 0x006185A4 File Offset: 0x006167A4
	public string GetNewTowerDifficultTitle(int difficultId)
	{
		switch (difficultId)
		{
		case 1:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_1", null) ?? string.Empty;
		case 2:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_2", null) ?? string.Empty;
		case 3:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_3", null) ?? string.Empty;
		case 4:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_4", null) ?? string.Empty;
		default:
			return ConfigMultiTextLang.GetLocalTextNew("NewTower_Diffcult_1", null) ?? string.Empty;
		}
	}

	// Token: 0x17001FBC RID: 8124
	// (get) Token: 0x06014ED7 RID: 85719 RVA: 0x00618633 File Offset: 0x00616833
	public static TowerClimbConfig Instance
	{
		get
		{
			return TowerClimbConfig._Instance;
		}
	}

	// Token: 0x06014ED8 RID: 85720 RVA: 0x0061863A File Offset: 0x0061683A
	public static TowerClimbConfig GetOrCreateInstance()
	{
		if (TowerClimbConfig._Instance == null)
		{
			TowerClimbConfig.CreateInstance();
		}
		return TowerClimbConfig._Instance;
	}

	// Token: 0x06014ED9 RID: 85721 RVA: 0x0061864E File Offset: 0x0061684E
	public static bool CreateInstance()
	{
		if (TowerClimbConfig._Instance != null)
		{
			return true;
		}
		TowerClimbConfig._Instance = new TowerClimbConfig();
		return true;
	}

	// Token: 0x06014EDA RID: 85722 RVA: 0x00618664 File Offset: 0x00616864
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014EDB RID: 85723 RVA: 0x00618666 File Offset: 0x00616866
	public static void ResetStaticDefaultValue()
	{
		TowerClimbConfig._Instance = null;
	}

	// Token: 0x06014EDC RID: 85724 RVA: 0x0061866E File Offset: 0x0061686E
	static TowerClimbConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TowerClimbConfig.CreateStaticDefaultValue), new Action(TowerClimbConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B24E RID: 45646
	[Nullable(2)]
	private static TowerClimbConfig _Instance;
}
