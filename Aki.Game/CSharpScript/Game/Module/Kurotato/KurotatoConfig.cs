using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046AB RID: 18091
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class KurotatoConfig : ConfigBase
	{
		// Token: 0x0602D7C6 RID: 186310 RVA: 0x00CBD1C5 File Offset: 0x00CBB3C5
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602D7C7 RID: 186311 RVA: 0x00CBD1C8 File Offset: 0x00CBB3C8
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x0602D7C8 RID: 186312 RVA: 0x00CBD1CC File Offset: 0x00CBB3CC
		public bool IsServerCtrlProperty(int propertyId)
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("KurotatoServerCtrlProperty");
			if (intArrayConfig == null)
			{
				return false;
			}
			for (int i = 0; i < intArrayConfig.Count; i++)
			{
				if (intArrayConfig[i] == propertyId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602D7C9 RID: 186313 RVA: 0x00CBD207 File Offset: 0x00CBB407
		public KurotatoItem? GetItemConfigByItemId(int itemId)
		{
			return ConfigKurotatoItemById.GetConfig(itemId, true);
		}

		// Token: 0x0602D7CA RID: 186314 RVA: 0x00CBD210 File Offset: 0x00CBB410
		[NullableContext(2)]
		public IReadOnlyList<KurotatoItem> GetItemConfigList()
		{
			return ConfigKurotatoItemAll.GetConfigList(true);
		}

		// Token: 0x0602D7CB RID: 186315 RVA: 0x00CBD218 File Offset: 0x00CBB418
		public KurotatoQuality? GetQualityByQuality(int quality)
		{
			return ConfigKurotatoQualityById.GetConfig(quality, true);
		}

		// Token: 0x0602D7CC RID: 186316 RVA: 0x00CBD221 File Offset: 0x00CBB421
		[NullableContext(2)]
		public IReadOnlyList<KurotatoQuality> GetQualityList()
		{
			return ConfigKurotatoQualityAll.GetConfigList(true);
		}

		// Token: 0x0602D7CD RID: 186317 RVA: 0x00CBD22C File Offset: 0x00CBB42C
		public int GetMaxQualityByGroupId(int groupId)
		{
			IReadOnlyList<KurotatoWeapon> configList = ConfigKurotatoWeaponByGroupId.GetConfigList(groupId, true);
			int num = 0;
			if (configList == null)
			{
				return num;
			}
			foreach (KurotatoWeapon kurotatoWeapon in configList)
			{
				num = Math.Max(num, kurotatoWeapon.Quality);
			}
			return num;
		}

		// Token: 0x0602D7CE RID: 186318 RVA: 0x00CBD28C File Offset: 0x00CBB48C
		public int GetHelpIdRoleInfo()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoRoleInfoHelpId").GetValueOrDefault();
		}

		// Token: 0x0602D7CF RID: 186319 RVA: 0x00CBD2AC File Offset: 0x00CBB4AC
		public int GetHelpIdAttrInfo()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoAttrInfoHelpId").GetValueOrDefault();
		}

		// Token: 0x0602D7D0 RID: 186320 RVA: 0x00CBD2CC File Offset: 0x00CBB4CC
		public int GetHelpIdAttrSelect()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoAttrSelectHelpId").GetValueOrDefault();
		}

		// Token: 0x0602D7D1 RID: 186321 RVA: 0x00CBD2EC File Offset: 0x00CBB4EC
		public int GetHelpIdShop()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoShopHelpId").GetValueOrDefault();
		}

		// Token: 0x0602D7D2 RID: 186322 RVA: 0x00CBD30B File Offset: 0x00CBB50B
		public KurotatoFormula? GetFormulaById(int id)
		{
			return ConfigKurotatoFormulaById.GetConfig(id, true);
		}

		// Token: 0x0602D7D3 RID: 186323 RVA: 0x00CBD314 File Offset: 0x00CBB514
		public List<KurotatoExp> GetExpList()
		{
			List<KurotatoExp> list = new List<KurotatoExp>(ConfigKurotatoExpAll.GetConfigList(true));
			list.Sort((KurotatoExp a, KurotatoExp b) => a.LevelExp - b.LevelExp);
			return list;
		}

		// Token: 0x0602D7D4 RID: 186324 RVA: 0x00CBD348 File Offset: 0x00CBB548
		public int GetExpByLevel(int level, int activityConfigId)
		{
			if (ConfigKurotatoExpByLevelAndActivityId.GetConfig(level, activityConfigId, true) == null)
			{
				return 0;
			}
			KurotatoExp? kurotatoExp;
			return kurotatoExp.GetValueOrDefault().LevelExp;
		}

		// Token: 0x0602D7D5 RID: 186325 RVA: 0x00CBD378 File Offset: 0x00CBB578
		public int GetMaxLevel(int activityConfigId)
		{
			IEnumerable<KurotatoExp> configList = ConfigKurotatoExpAll.GetConfigList(true);
			int num = 1;
			foreach (KurotatoExp kurotatoExp in configList)
			{
				if (kurotatoExp.ActivityId == activityConfigId)
				{
					num = Math.Max(num, kurotatoExp.RoleLevel);
				}
			}
			return num;
		}

		// Token: 0x0602D7D6 RID: 186326 RVA: 0x00CBD3DC File Offset: 0x00CBB5DC
		public KurotatoLevel? GetLevelConfig(int levelId)
		{
			return ConfigKurotatoLevelById.GetConfig(levelId, true);
		}

		// Token: 0x0602D7D7 RID: 186327 RVA: 0x00CBD3E5 File Offset: 0x00CBB5E5
		[NullableContext(2)]
		public IReadOnlyList<KurotatoLevel> GetLevelListByDifficulty(int difficulty)
		{
			return ConfigKurotatoLevelByDifficulty.GetConfigList(difficulty, true);
		}

		// Token: 0x0602D7D8 RID: 186328 RVA: 0x00CBD3EE File Offset: 0x00CBB5EE
		[NullableContext(2)]
		public IReadOnlyList<KurotatoLevel> GetLevelList()
		{
			return ConfigKurotatoLevelAll.GetConfigList(true);
		}

		// Token: 0x0602D7D9 RID: 186329 RVA: 0x00CBD3F6 File Offset: 0x00CBB5F6
		public KurotatoLevelGroup? GetLevelGroupConfig(int id)
		{
			return ConfigKurotatoLevelGroupByGroupId.GetConfig(id, true);
		}

		// Token: 0x0602D7DA RID: 186330 RVA: 0x00CBD3FF File Offset: 0x00CBB5FF
		public KurotatoWeaponBuild? GetWeaponBuildById(int buildId)
		{
			return ConfigKurotatoWeaponBuildById.GetConfig(buildId, true);
		}

		// Token: 0x0602D7DB RID: 186331 RVA: 0x00CBD408 File Offset: 0x00CBB608
		public KurotatoWeaponGroup? GetWeaponGroupById(int groupId)
		{
			return ConfigKurotatoWeaponGroupById.GetConfig(groupId, true);
		}

		// Token: 0x0602D7DC RID: 186332 RVA: 0x00CBD411 File Offset: 0x00CBB611
		public KurotatoWeapon? GetWeaponConfigByWeaponId(int weaponId)
		{
			return ConfigKurotatoWeaponById.GetConfig(weaponId, true);
		}

		// Token: 0x0602D7DD RID: 186333 RVA: 0x00CBD41A File Offset: 0x00CBB61A
		[NullableContext(2)]
		public IReadOnlyList<KurotatoWeapon> GetWeaponConfigList()
		{
			return ConfigKurotatoWeaponAll.GetConfigList(true);
		}

		// Token: 0x0602D7DE RID: 186334 RVA: 0x00CBD424 File Offset: 0x00CBB624
		public KurotatoWeaponGroup? GetWeaponGroupConfigByWeaponId(int weaponId)
		{
			KurotatoWeapon? weaponConfigByWeaponId = this.GetWeaponConfigByWeaponId(weaponId);
			if (weaponConfigByWeaponId == null)
			{
				return null;
			}
			return this.GetWeaponGroupById(weaponConfigByWeaponId.Value.GroupId);
		}

		// Token: 0x0602D7DF RID: 186335 RVA: 0x00CBD461 File Offset: 0x00CBB661
		public KurotatoEffect? GetEffectById(int effectId)
		{
			return ConfigKurotatoEffectById.GetConfig(effectId, true);
		}

		// Token: 0x0602D7E0 RID: 186336 RVA: 0x00CBD46A File Offset: 0x00CBB66A
		public KurotatoProperty? GetPropertyById(int propertyId)
		{
			return ConfigKurotatoPropertyById.GetConfig(propertyId, true);
		}

		// Token: 0x0602D7E1 RID: 186337 RVA: 0x00CBD473 File Offset: 0x00CBB673
		public KurotatoProperty? GetPropertyByName(string propertyName)
		{
			return ConfigKurotatoPropertyByName.GetConfig(propertyName, true);
		}

		// Token: 0x0602D7E2 RID: 186338 RVA: 0x00CBD47C File Offset: 0x00CBB67C
		public KurotatoProperty? GetPropertyByPropertyVarName(string propertyVarName)
		{
			return ConfigKurotatoPropertyByPropertyVarName.GetConfig(propertyVarName, true);
		}

		// Token: 0x0602D7E3 RID: 186339 RVA: 0x00CBD485 File Offset: 0x00CBB685
		public IReadOnlyList<KurotatoProperty> GetAllProperty()
		{
			return ConfigKurotatoPropertyAll.GetConfigList(true) ?? new List<KurotatoProperty>();
		}

		// Token: 0x0602D7E4 RID: 186340 RVA: 0x00CBD496 File Offset: 0x00CBB696
		public KurotatoCharacter? GetCharacterById(int characterId)
		{
			return ConfigKurotatoCharacterById.GetConfig(characterId, true);
		}

		// Token: 0x0602D7E5 RID: 186341 RVA: 0x00CBD49F File Offset: 0x00CBB69F
		[NullableContext(2)]
		public IReadOnlyList<KurotatoCharacter> GetCharacterList()
		{
			return ConfigKurotatoCharacterAll.GetConfigList(true);
		}

		// Token: 0x0602D7E6 RID: 186342 RVA: 0x00CBD4A7 File Offset: 0x00CBB6A7
		[NullableContext(2)]
		public IReadOnlyList<KurotatoCharacter> GetCharacterListByActivityId(int activityId)
		{
			return ConfigKurotatoCharacterByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0602D7E7 RID: 186343 RVA: 0x00CBD4B0 File Offset: 0x00CBB6B0
		public KurotatoLevelCharacter? GetLevelCharacterByRoleIdAndLevelId(int roleId, int levelId)
		{
			IReadOnlyList<KurotatoLevelCharacter> configList = ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.GetConfigList(roleId, levelId, true);
			if (configList == null || configList.Count == 0)
			{
				return null;
			}
			return new KurotatoLevelCharacter?(configList[0]);
		}

		// Token: 0x0602D7E8 RID: 186344 RVA: 0x00CBD4E7 File Offset: 0x00CBB6E7
		[NullableContext(2)]
		public IReadOnlyList<KurotatoWaveLevel> GetWaveLevelConfigList()
		{
			return ConfigKurotatoWaveLevelAll.GetConfigList(true);
		}

		// Token: 0x0602D7E9 RID: 186345 RVA: 0x00CBD4EF File Offset: 0x00CBB6EF
		public KurotatoActivityConfig? GetActivityConfig(int activityId)
		{
			return ConfigKurotatoActivityConfigByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x0602D7EA RID: 186346 RVA: 0x00CBD4F8 File Offset: 0x00CBB6F8
		public IReadOnlyList<KurotatoLevel> GetAllKurotatoLevelConfig()
		{
			return ConfigKurotatoLevelAll.GetConfigList(true) ?? new List<KurotatoLevel>();
		}

		// Token: 0x0602D7EB RID: 186347 RVA: 0x00CBD509 File Offset: 0x00CBB709
		public KurotatoLevel? GetKurotatoLevelConfig(int levelId)
		{
			return ConfigKurotatoLevelById.GetConfig(levelId, true);
		}

		// Token: 0x0602D7EC RID: 186348 RVA: 0x00CBD512 File Offset: 0x00CBB712
		public IReadOnlyList<KurotatoLevelGroup> GetAllKurotatoLevelGroupConfig()
		{
			return ConfigKurotatoLevelGroupAll.GetConfigList(true) ?? new List<KurotatoLevelGroup>();
		}

		// Token: 0x0602D7ED RID: 186349 RVA: 0x00CBD523 File Offset: 0x00CBB723
		public KurotatoLevelGroup? GetKurotatoLevelGroupConfig(int groupId)
		{
			return ConfigKurotatoLevelGroupByGroupId.GetConfig(groupId, true);
		}

		// Token: 0x0602D7EE RID: 186350 RVA: 0x00CBD52C File Offset: 0x00CBB72C
		public KurotatoLevelSecondGroup? GetLevelSecondGroupConfig(int id)
		{
			return ConfigKurotatoLevelSecondGroupById.GetConfig(id, true);
		}

		// Token: 0x0602D7EF RID: 186351 RVA: 0x00CBD535 File Offset: 0x00CBB735
		[NullableContext(2)]
		public IReadOnlyList<KurotatoLevel> GetLevelListBySecondGroup(int secondGroupId)
		{
			return ConfigKurotatoLevelBySecondGroup.GetConfigList(secondGroupId, true);
		}

		// Token: 0x0602D7F0 RID: 186352 RVA: 0x00CBD53E File Offset: 0x00CBB73E
		public IReadOnlyList<KurotatoWave> GetAllWaveConfig()
		{
			return ConfigKurotatoWaveAll.GetConfigList(true) ?? new List<KurotatoWave>();
		}

		// Token: 0x0602D7F1 RID: 186353 RVA: 0x00CBD550 File Offset: 0x00CBB750
		public List<KurotatoWave> GetWaveByLevelId(int levelId)
		{
			IReadOnlyList<KurotatoWave> configList = ConfigKurotatoWaveAll.GetConfigList(true);
			if (configList == null)
			{
				return new List<KurotatoWave>();
			}
			List<KurotatoWave> list = new List<KurotatoWave>();
			foreach (KurotatoWave item in configList)
			{
				if (item.Level == levelId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x0602D7F2 RID: 186354 RVA: 0x00CBD5BC File Offset: 0x00CBB7BC
		public KurotatoWave? GetMonsterByLevelIdAndWaveId(int levelId, int waveId)
		{
			IReadOnlyList<KurotatoWave> configList = ConfigKurotatoWaveAll.GetConfigList(true);
			if (configList == null)
			{
				return null;
			}
			foreach (KurotatoWave value in configList)
			{
				if (value.Level == levelId && value.Wave == waveId)
				{
					return new KurotatoWave?(value);
				}
			}
			return null;
		}

		// Token: 0x0602D7F3 RID: 186355 RVA: 0x00CBD63C File Offset: 0x00CBB83C
		public KurotatoSpawn? GetSpawnById(int spawnId)
		{
			return ConfigKurotatoSpawnById.GetConfig(spawnId, true);
		}

		// Token: 0x0602D7F4 RID: 186356 RVA: 0x00CBD645 File Offset: 0x00CBB845
		public KurotatoWaypoints? GetWaypointsById(int waypointsId)
		{
			return ConfigKurotatoWaypointsById.GetConfig(waypointsId, true);
		}

		// Token: 0x0602D7F5 RID: 186357 RVA: 0x00CBD64E File Offset: 0x00CBB84E
		public KurotatoStructure? GetStructureConfigById(int structureId)
		{
			return ConfigKurotatoStructureById.GetConfig(structureId, true);
		}

		// Token: 0x0602D7F6 RID: 186358 RVA: 0x00CBD657 File Offset: 0x00CBB857
		public KurotatoMonster? GetMonsterConfigById(int monsterId)
		{
			return ConfigKurotatoMonsterById.GetConfig(monsterId, true);
		}

		// Token: 0x0602D7F7 RID: 186359 RVA: 0x00CBD660 File Offset: 0x00CBB860
		public KurotatoMonsterType? GetMonsterTypeById(int monsterId)
		{
			return ConfigKurotatoMonsterTypeById.GetConfig(monsterId, true);
		}

		// Token: 0x0602D7F8 RID: 186360 RVA: 0x00CBD66C File Offset: 0x00CBB86C
		public bool WaveHasRiskType(KurotatoWave waveConfig, EKurotatoRiskType riskType)
		{
			foreach (int spawnId in waveConfig.MonsterSpawnGroupIter())
			{
				KurotatoSpawn? spawnById = this.GetSpawnById(spawnId);
				if (spawnById != null)
				{
					foreach (int monsterId in spawnById.Value.MonsterIdsIter())
					{
						KurotatoMonster? monsterConfigById = this.GetMonsterConfigById(monsterId);
						if (monsterConfigById != null)
						{
							KurotatoMonsterType? monsterTypeById = this.GetMonsterTypeById(monsterConfigById.Value.MonsterType);
							if (monsterTypeById != null && monsterTypeById.Value.RiskType == (int)riskType)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0602D7F9 RID: 186361 RVA: 0x00CBD760 File Offset: 0x00CBB960
		public IReadOnlyList<KurotatoMonsterTag> GetAllMonsterTagList()
		{
			return ConfigKurotatoMonsterTagAll.GetConfigList(true) ?? new List<KurotatoMonsterTag>();
		}

		// Token: 0x0602D7FA RID: 186362 RVA: 0x00CBD771 File Offset: 0x00CBB971
		public KurotatoMonsterTag? GetMonsterTagById(int tagId)
		{
			return ConfigKurotatoMonsterTagById.GetConfig(tagId, true);
		}

		// Token: 0x0602D7FB RID: 186363 RVA: 0x00CBD77A File Offset: 0x00CBB97A
		public KurotatoMonsterRisk? GetMonsterRiskConfig(int typeId)
		{
			return ConfigKurotatoMonsterRiskById.GetConfig(typeId, true);
		}

		// Token: 0x0602D7FC RID: 186364 RVA: 0x00CBD783 File Offset: 0x00CBB983
		public KurotatoMonsterBody? GetBodyTypeConfig(int bodyTypeId)
		{
			return ConfigKurotatoMonsterBodyById.GetConfig(bodyTypeId, true);
		}

		// Token: 0x0602D7FD RID: 186365 RVA: 0x00CBD78C File Offset: 0x00CBB98C
		public KSCBaseProperty? GetBaseProperty(int id)
		{
			return ConfigKSCBasePropertyById.GetConfig(id, true);
		}

		// Token: 0x0602D7FE RID: 186366 RVA: 0x00CBD795 File Offset: 0x00CBB995
		public KurotatoMonsterAttribute? GetMonsterAttribute(int id)
		{
			return ConfigKurotatoMonsterAttributeById.GetConfig(id, true);
		}

		// Token: 0x0602D7FF RID: 186367 RVA: 0x00CBD79E File Offset: 0x00CBB99E
		public IReadOnlyList<KurotatoResAward> GetAllNormalRewardConfig()
		{
			return ConfigKurotatoResAwardAll.GetConfigList(true) ?? new List<KurotatoResAward>();
		}

		// Token: 0x0602D800 RID: 186368 RVA: 0x00CBD7AF File Offset: 0x00CBB9AF
		public KurotatoResAward? GetNormalRewardConfigById(int rewardId)
		{
			return ConfigKurotatoResAwardById.GetConfig(rewardId, true);
		}

		// Token: 0x0602D801 RID: 186369 RVA: 0x00CBD7B8 File Offset: 0x00CBB9B8
		public IReadOnlyList<KurotatoLimitAward> GetAllLimitRewardConfig()
		{
			return ConfigKurotatoLimitAwardAll.GetConfigList(true) ?? new List<KurotatoLimitAward>();
		}

		// Token: 0x0602D802 RID: 186370 RVA: 0x00CBD7C9 File Offset: 0x00CBB9C9
		public KurotatoLimitAward? GetLimitRewardConfigById(int rewardId)
		{
			return ConfigKurotatoLimitAwardById.GetConfig(rewardId, true);
		}

		// Token: 0x0602D803 RID: 186371 RVA: 0x00CBD7D2 File Offset: 0x00CBB9D2
		public IReadOnlyList<KurotatoRewardTab> GetAllRewardTabConfig()
		{
			return ConfigKurotatoRewardTabAll.GetConfigList(true) ?? new List<KurotatoRewardTab>();
		}

		// Token: 0x0602D804 RID: 186372 RVA: 0x00CBD7E3 File Offset: 0x00CBB9E3
		public KurotatoRewardTab? GetRewardTabConfigById(int tabId)
		{
			return ConfigKurotatoRewardTabById.GetConfig(tabId, true);
		}

		// Token: 0x0602D805 RID: 186373 RVA: 0x00CBD7EC File Offset: 0x00CBB9EC
		public IReadOnlyList<KurotatoScoreAward> GetAllKurotatoScoreAwardConfig()
		{
			return ConfigKurotatoScoreAwardAll.GetConfigList(true) ?? new List<KurotatoScoreAward>();
		}

		// Token: 0x0602D806 RID: 186374 RVA: 0x00CBD7FD File Offset: 0x00CBB9FD
		public KurotatoScoreAward? GetKurotatoScoreAwardConfigById(int rewardId)
		{
			return ConfigKurotatoScoreAwardById.GetConfig(rewardId, true);
		}

		// Token: 0x0602D807 RID: 186375 RVA: 0x00CBD806 File Offset: 0x00CBBA06
		[NullableContext(2)]
		public IReadOnlyList<KurotatoHandbook> GetKurotatoHandBookListByActivityIdAndType(int activityId, EKurotatoHandBookType type)
		{
			return ConfigKurotatoHandbookByActivityIdAndType.GetConfigList(activityId, (int)type, true);
		}

		// Token: 0x0602D808 RID: 186376 RVA: 0x00CBD810 File Offset: 0x00CBBA10
		public int GetMonsterRiskType(int configId)
		{
			KurotatoMonster? config = ConfigKurotatoMonsterById.GetConfig(configId, true);
			if (config == null)
			{
				return 0;
			}
			KurotatoMonsterType? config2 = ConfigKurotatoMonsterTypeById.GetConfig(config.Value.MonsterType, true);
			if (config2 == null)
			{
				return 0;
			}
			return config2.Value.RiskType;
		}

		// Token: 0x17005B74 RID: 23412
		// (get) Token: 0x0602D809 RID: 186377 RVA: 0x00CBD860 File Offset: 0x00CBBA60
		public static KurotatoConfig Instance
		{
			get
			{
				return KurotatoConfig._Instance;
			}
		}

		// Token: 0x0602D80A RID: 186378 RVA: 0x00CBD867 File Offset: 0x00CBBA67
		public static KurotatoConfig GetOrCreateInstance()
		{
			if (KurotatoConfig._Instance == null)
			{
				KurotatoConfig.CreateInstance();
			}
			return KurotatoConfig._Instance;
		}

		// Token: 0x0602D80B RID: 186379 RVA: 0x00CBD87B File Offset: 0x00CBBA7B
		public static bool CreateInstance()
		{
			if (KurotatoConfig._Instance != null)
			{
				return true;
			}
			KurotatoConfig._Instance = new KurotatoConfig();
			return true;
		}

		// Token: 0x0602D80C RID: 186380 RVA: 0x00CBD891 File Offset: 0x00CBBA91
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602D80D RID: 186381 RVA: 0x00CBD893 File Offset: 0x00CBBA93
		public static void ResetStaticDefaultValue()
		{
			KurotatoConfig._Instance = null;
		}

		// Token: 0x0602D80E RID: 186382 RVA: 0x00CBD89B File Offset: 0x00CBBA9B
		static KurotatoConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoConfig.CreateStaticDefaultValue), new Action(KurotatoConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040185BD RID: 99773
		[Nullable(2)]
		private static KurotatoConfig _Instance;
	}
}
