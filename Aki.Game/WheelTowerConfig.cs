using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001656 RID: 5718
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class WheelTowerConfig : ConfigBase
{
	// Token: 0x0600A086 RID: 41094 RVA: 0x002361F1 File Offset: 0x002343F1
	public NewTowerParam? GetTowerConfig(int cycleId)
	{
		return ConfigNewTowerParamByCycleId.GetConfig(cycleId, true);
	}

	// Token: 0x0600A087 RID: 41095 RVA: 0x002361FA File Offset: 0x002343FA
	public NewTowerLevel? GetLevelConfigById(int levelId)
	{
		return ConfigNewTowerLevelById.GetConfig(levelId, true);
	}

	// Token: 0x0600A088 RID: 41096 RVA: 0x00236203 File Offset: 0x00234403
	public IReadOnlyList<NewTowerLevel> GetLevelConfigListByCycleId(int cycleId)
	{
		return ConfigNewTowerLevelByCycleId.GetConfigList(cycleId, true);
	}

	// Token: 0x0600A089 RID: 41097 RVA: 0x0023620C File Offset: 0x0023440C
	public NewTowerWave? GetWaveConfigById(int waveId)
	{
		return ConfigNewTowerWaveById.GetConfig(waveId, true);
	}

	// Token: 0x0600A08A RID: 41098 RVA: 0x00236215 File Offset: 0x00234415
	public IReadOnlyList<NewTowerWave> GetWaveConfigListByLevelId(int levelId)
	{
		return ConfigNewTowerWaveByLevel.GetConfigList(levelId, true);
	}

	// Token: 0x0600A08B RID: 41099 RVA: 0x0023621E File Offset: 0x0023441E
	public NewTowerBossBuff? GetBossBuffConfigById(int buffId)
	{
		return ConfigNewTowerBossBuffById.GetConfig(buffId, true);
	}

	// Token: 0x0600A08C RID: 41100 RVA: 0x00236227 File Offset: 0x00234427
	public NewTowerBuff? GetBuffConfigById(int buffId)
	{
		return ConfigNewTowerBuffById.GetConfig(buffId, true);
	}

	// Token: 0x0600A08D RID: 41101 RVA: 0x00236230 File Offset: 0x00234430
	public NewTowerScoreReward? GetRewardConfigById(int rewardId)
	{
		return ConfigNewTowerScoreRewardById.GetConfig(rewardId, true);
	}

	// Token: 0x0600A08E RID: 41102 RVA: 0x00236239 File Offset: 0x00234439
	public IReadOnlyList<NewTowerScoreReward> GetRewardConfigListByLevelId(int levelId)
	{
		return ConfigNewTowerScoreRewardByLevelId.GetConfigList(levelId, true);
	}

	// Token: 0x0600A08F RID: 41103 RVA: 0x00236242 File Offset: 0x00234442
	public IReadOnlyList<NewTowerRole> GetRoleConfigList()
	{
		return ConfigNewTowerRoleAll.GetConfigList(true);
	}

	// Token: 0x0600A090 RID: 41104 RVA: 0x0023624A File Offset: 0x0023444A
	public NewTowerRole? GetRoleConfigByRoleId(int roleId)
	{
		return ConfigNewTowerRoleById.GetConfig(roleId, true);
	}

	// Token: 0x0600A091 RID: 41105 RVA: 0x00236253 File Offset: 0x00234453
	public NewTowerTag? GetTagConfigByTagId(int tagId)
	{
		return ConfigNewTowerTagById.GetConfig(tagId, true);
	}

	// Token: 0x0600A092 RID: 41106 RVA: 0x0023625C File Offset: 0x0023445C
	public NewTowerBossBuff? GetBossBuffConfig(int id)
	{
		return ConfigNewTowerBossBuffById.GetConfig(id, true);
	}

	// Token: 0x0600A093 RID: 41107 RVA: 0x00236265 File Offset: 0x00234465
	public NewTowerSeason? GetSeasonConfig(int seasonId)
	{
		return ConfigNewTowerSeasonById.GetConfig(seasonId, true);
	}

	// Token: 0x0600A094 RID: 41108 RVA: 0x00236270 File Offset: 0x00234470
	public int GetSeasonScoreItemId(int seasonId)
	{
		if (this.GetSeasonConfig(seasonId) == null)
		{
			return 0;
		}
		NewTowerSeason? newTowerSeason;
		return newTowerSeason.GetValueOrDefault().ScoreItem;
	}

	// Token: 0x0600A095 RID: 41109 RVA: 0x0023629F File Offset: 0x0023449F
	public IReadOnlyList<NewTowerSeason> GetAllSeasonConfigs()
	{
		return ConfigNewTowerSeasonAll.GetConfigList(true);
	}

	// Token: 0x0600A096 RID: 41110 RVA: 0x002362A7 File Offset: 0x002344A7
	public NewTowerSeasonAward? GetSeasonTaskRewardConfig(int taskId)
	{
		return ConfigNewTowerSeasonAwardById.GetConfig(taskId, true);
	}

	// Token: 0x0600A097 RID: 41111 RVA: 0x002362B0 File Offset: 0x002344B0
	public NewTowerSeasonSAward? GetSeasonScoreRewardConfig(int rewardId)
	{
		return ConfigNewTowerSeasonSAwardById.GetConfig(rewardId, true);
	}

	// Token: 0x0600A098 RID: 41112 RVA: 0x002362B9 File Offset: 0x002344B9
	public IReadOnlyList<NewTowerSeasonSAward> GetSeasonScoreRewardConfigList(int seasonId)
	{
		return ConfigNewTowerSeasonSAwardBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x0600A099 RID: 41113 RVA: 0x002362C2 File Offset: 0x002344C2
	public NewTowerTeamFeature? GetTeamFeatureConfig(int id)
	{
		return ConfigNewTowerTeamFeatureById.GetConfig(id, true);
	}

	// Token: 0x0600A09A RID: 41114 RVA: 0x002362CB File Offset: 0x002344CB
	[NullableContext(1)]
	public NewTowerScoreLevel? GetScoreLevelConfigByLevel(string level)
	{
		return ConfigNewTowerScoreLevelByLevel.GetConfig(level, true);
	}

	// Token: 0x0600A09B RID: 41115 RVA: 0x002362D4 File Offset: 0x002344D4
	public NewTowerScoreLevel? GetScoreLevelConfigById(int id)
	{
		return ConfigNewTowerScoreLevelById.GetConfig(id, true);
	}

	// Token: 0x0600A09C RID: 41116 RVA: 0x002362DD File Offset: 0x002344DD
	public NewTowerMedal? GetMedalConfigById(int id)
	{
		return ConfigNewTowerMedalById.GetConfig(id, true);
	}

	// Token: 0x0600A09D RID: 41117 RVA: 0x002362E6 File Offset: 0x002344E6
	public IReadOnlyList<NewTowerMedal> GetMedalConfigListByGroupId(int groupId)
	{
		return ConfigNewTowerMedalByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600A09E RID: 41118 RVA: 0x002362EF File Offset: 0x002344EF
	public IReadOnlyList<NewTowerMedal> GetMedalConfigListBySeasonId(int seasonId)
	{
		return ConfigNewTowerMedalBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x17000D8C RID: 3468
	// (get) Token: 0x0600A09F RID: 41119 RVA: 0x002362F8 File Offset: 0x002344F8
	[Nullable(1)]
	public static WheelTowerConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return WheelTowerConfig._Instance;
		}
	}

	// Token: 0x0600A0A0 RID: 41120 RVA: 0x002362FF File Offset: 0x002344FF
	[NullableContext(1)]
	public static WheelTowerConfig GetOrCreateInstance()
	{
		if (WheelTowerConfig._Instance == null)
		{
			WheelTowerConfig.CreateInstance();
		}
		return WheelTowerConfig._Instance;
	}

	// Token: 0x0600A0A1 RID: 41121 RVA: 0x00236313 File Offset: 0x00234513
	public static bool CreateInstance()
	{
		if (WheelTowerConfig._Instance != null)
		{
			return true;
		}
		WheelTowerConfig._Instance = new WheelTowerConfig();
		return true;
	}

	// Token: 0x0600A0A2 RID: 41122 RVA: 0x00236329 File Offset: 0x00234529
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A0A3 RID: 41123 RVA: 0x0023632B File Offset: 0x0023452B
	public static void ResetStaticDefaultValue()
	{
		WheelTowerConfig._Instance = null;
	}

	// Token: 0x0600A0A4 RID: 41124 RVA: 0x00236333 File Offset: 0x00234533
	static WheelTowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WheelTowerConfig.CreateStaticDefaultValue), new Action(WheelTowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400493F RID: 18751
	private static WheelTowerConfig _Instance;
}
