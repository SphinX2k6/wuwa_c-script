using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056D4 RID: 22228
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class KurotatoConfig : ConfigBase
	{
		// Token: 0x060388B6 RID: 231606 RVA: 0x00D6EC01 File Offset: 0x00D6CE01
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060388B7 RID: 231607 RVA: 0x00D6EC04 File Offset: 0x00D6CE04
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x060388B8 RID: 231608 RVA: 0x00D6EC07 File Offset: 0x00D6CE07
		public bool IsServerCtrlProperty(int propertyId)
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("KurotatoServerCtrlProperty");
			return intArrayConfig != null && intArrayConfig.Contains(propertyId);
		}

		// Token: 0x060388B9 RID: 231609 RVA: 0x00D6EC1F File Offset: 0x00D6CE1F
		public KurotatoItem? GetItemConfigByItemId(int itemId)
		{
			return ConfigKurotatoItemById.GetConfig(itemId, true);
		}

		// Token: 0x060388BA RID: 231610 RVA: 0x00D6EC28 File Offset: 0x00D6CE28
		[NullableContext(2)]
		public IReadOnlyList<KurotatoItem> GetItemConfigList()
		{
			return ConfigKurotatoItemAll.GetConfigList(true);
		}

		// Token: 0x060388BB RID: 231611 RVA: 0x00D6EC30 File Offset: 0x00D6CE30
		public KurotatoQuality? GetQualityByQuality(int quality)
		{
			return ConfigKurotatoQualityById.GetConfig(quality, true);
		}

		// Token: 0x060388BC RID: 231612 RVA: 0x00D6EC39 File Offset: 0x00D6CE39
		[NullableContext(2)]
		public IReadOnlyList<KurotatoQuality> GetQualityList()
		{
			return ConfigKurotatoQualityAll.GetConfigList(true);
		}

		// Token: 0x060388BD RID: 231613 RVA: 0x00D6EC44 File Offset: 0x00D6CE44
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

		// Token: 0x060388BE RID: 231614 RVA: 0x00D6ECA4 File Offset: 0x00D6CEA4
		public int GetHelpIdRoleInfo()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoRoleInfoHelpId").GetValueOrDefault();
		}

		// Token: 0x060388BF RID: 231615 RVA: 0x00D6ECC4 File Offset: 0x00D6CEC4
		public int GetHelpIdAttrInfo()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoAttrInfoHelpId").GetValueOrDefault();
		}

		// Token: 0x060388C0 RID: 231616 RVA: 0x00D6ECE4 File Offset: 0x00D6CEE4
		public int GetHelpIdAttrSelect()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoAttrSelectHelpId").GetValueOrDefault();
		}

		// Token: 0x060388C1 RID: 231617 RVA: 0x00D6ED04 File Offset: 0x00D6CF04
		public int GetHelpIdShop()
		{
			return ConfigCommonParamById.GetIntConfig("KurotatoShopHelpId").GetValueOrDefault();
		}

		// Token: 0x060388C2 RID: 231618 RVA: 0x00D6ED23 File Offset: 0x00D6CF23
		public KurotatoFormula? GetFormulaById(int id)
		{
			return ConfigKurotatoFormulaById.GetConfig(id, true);
		}

		// Token: 0x060388C3 RID: 231619 RVA: 0x00D6ED2C File Offset: 0x00D6CF2C
		public List<KurotatoExp> GetExpList()
		{
			List<KurotatoExp> list = ConfigKurotatoExpAll.GetConfigList(true).ToList<KurotatoExp>();
			list.Sort((KurotatoExp a, KurotatoExp b) => a.LevelExp - b.LevelExp);
			return list;
		}

		// Token: 0x060388C4 RID: 231620 RVA: 0x00D6ED60 File Offset: 0x00D6CF60
		public int GetExpByLevel(int level, int activityConfigId)
		{
			if (ConfigKurotatoExpByLevelAndActivityId.GetConfig(level, activityConfigId, true) == null)
			{
				return 0;
			}
			KurotatoExp? kurotatoExp;
			return kurotatoExp.GetValueOrDefault().LevelExp;
		}

		// Token: 0x060388C5 RID: 231621 RVA: 0x00D6ED90 File Offset: 0x00D6CF90
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

		// Token: 0x060388C6 RID: 231622 RVA: 0x00D6EDF4 File Offset: 0x00D6CFF4
		public KurotatoLevel? GetLevelConfig(int levelId)
		{
			return ConfigKurotatoLevelById.GetConfig(levelId, true);
		}

		// Token: 0x060388C7 RID: 231623 RVA: 0x00D6EDFD File Offset: 0x00D6CFFD
		[NullableContext(2)]
		public IReadOnlyList<KurotatoLevel> GetLevelListByDifficulty(int difficulty)
		{
			return ConfigKurotatoLevelByDifficulty.GetConfigList(difficulty, true);
		}

		// Token: 0x060388C8 RID: 231624 RVA: 0x00D6EE06 File Offset: 0x00D6D006
		[NullableContext(2)]
		public IReadOnlyList<KurotatoLevel> GetLevelList()
		{
			return ConfigKurotatoLevelAll.GetConfigList(true);
		}

		// Token: 0x060388C9 RID: 231625 RVA: 0x00D6EE0E File Offset: 0x00D6D00E
		public KurotatoLevelGroup? GetLevelGroupConfig(int id)
		{
			return ConfigKurotatoLevelGroupByGroupId.GetConfig(id, true);
		}

		// Token: 0x060388CA RID: 231626 RVA: 0x00D6EE17 File Offset: 0x00D6D017
		public KurotatoWeaponBuild? GetWeaponBuildById(int buildId)
		{
			return ConfigKurotatoWeaponBuildById.GetConfig(buildId, true);
		}

		// Token: 0x060388CB RID: 231627 RVA: 0x00D6EE20 File Offset: 0x00D6D020
		public KurotatoWeaponGroup? GetWeaponGroupById(int groupId)
		{
			return ConfigKurotatoWeaponGroupById.GetConfig(groupId, true);
		}

		// Token: 0x060388CC RID: 231628 RVA: 0x00D6EE29 File Offset: 0x00D6D029
		public KurotatoWeapon? GetWeaponConfigByWeaponId(int weaponId)
		{
			return ConfigKurotatoWeaponById.GetConfig(weaponId, true);
		}

		// Token: 0x060388CD RID: 231629 RVA: 0x00D6EE32 File Offset: 0x00D6D032
		[NullableContext(2)]
		public IReadOnlyList<KurotatoWeapon> GetWeaponConfigList()
		{
			return ConfigKurotatoWeaponAll.GetConfigList(true);
		}

		// Token: 0x060388CE RID: 231630 RVA: 0x00D6EE3C File Offset: 0x00D6D03C
		public KurotatoWeaponGroup? GetWeaponGroupConfigByWeaponId(int weaponId)
		{
			KurotatoWeapon? weaponConfigByWeaponId = this.GetWeaponConfigByWeaponId(weaponId);
			if (weaponConfigByWeaponId == null)
			{
				return null;
			}
			return this.GetWeaponGroupById(weaponConfigByWeaponId.Value.GroupId);
		}

		// Token: 0x060388CF RID: 231631 RVA: 0x00D6EE79 File Offset: 0x00D6D079
		public KurotatoEffect? GetEffectById(int effectId)
		{
			return ConfigKurotatoEffectById.GetConfig(effectId, true);
		}

		// Token: 0x060388D0 RID: 231632 RVA: 0x00D6EE82 File Offset: 0x00D6D082
		public KurotatoProperty? GetPropertyById(int propertyId)
		{
			return ConfigKurotatoPropertyById.GetConfig(propertyId, true);
		}

		// Token: 0x060388D1 RID: 231633 RVA: 0x00D6EE8B File Offset: 0x00D6D08B
		public KurotatoProperty? GetPropertyByName(string propertyName)
		{
			return ConfigKurotatoPropertyByName.GetConfig(propertyName, true);
		}

		// Token: 0x060388D2 RID: 231634 RVA: 0x00D6EE94 File Offset: 0x00D6D094
		public KurotatoProperty? GetPropertyByPropertyVarName(string propertyVarName)
		{
			return ConfigKurotatoPropertyByPropertyVarName.GetConfig(propertyVarName, true);
		}

		// Token: 0x060388D3 RID: 231635 RVA: 0x00D6EE9D File Offset: 0x00D6D09D
		public IReadOnlyList<KurotatoProperty> GetAllProperty()
		{
			return ConfigKurotatoPropertyAll.GetConfigList(true) ?? new List<KurotatoProperty>();
		}

		// Token: 0x060388D4 RID: 231636 RVA: 0x00D6EEAE File Offset: 0x00D6D0AE
		public KurotatoCharacter? GetCharacterById(int characterId)
		{
			return ConfigKurotatoCharacterById.GetConfig(characterId, true);
		}

		// Token: 0x060388D5 RID: 231637 RVA: 0x00D6EEB7 File Offset: 0x00D6D0B7
		[NullableContext(2)]
		public IReadOnlyList<KurotatoCharacter> GetCharacterList()
		{
			return ConfigKurotatoCharacterAll.GetConfigList(true);
		}

		// Token: 0x060388D6 RID: 231638 RVA: 0x00D6EEBF File Offset: 0x00D6D0BF
		[NullableContext(2)]
		public IReadOnlyList<KurotatoCharacter> GetCharacterListByActivityId(int activityId)
		{
			return ConfigKurotatoCharacterByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060388D7 RID: 231639 RVA: 0x00D6EEC8 File Offset: 0x00D6D0C8
		public KurotatoLevelCharacter? GetLevelCharacterByRoleIdAndLevelId(int roleId, int levelId)
		{
			IReadOnlyList<KurotatoLevelCharacter> configList = ConfigKurotatoLevelCharacterByCharacterIdAndLevelId.GetConfigList(roleId, levelId, true);
			if (configList == null || configList.Count == 0)
			{
				return null;
			}
			return new KurotatoLevelCharacter?(configList[0]);
		}

		// Token: 0x060388D8 RID: 231640 RVA: 0x00D6EEFF File Offset: 0x00D6D0FF
		[NullableContext(2)]
		public IReadOnlyList<KurotatoWaveLevel> GetWaveLevelConfigList()
		{
			return ConfigKurotatoWaveLevelAll.GetConfigList(true);
		}

		// Token: 0x060388D9 RID: 231641 RVA: 0x00D6EF07 File Offset: 0x00D6D107
		public KurotatoActivityConfig? GetActivityConfig(int activityId)
		{
			return ConfigKurotatoActivityConfigByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x060388DA RID: 231642 RVA: 0x00D6EF10 File Offset: 0x00D6D110
		public IReadOnlyList<KurotatoLevel> GetAllKurotatoLevelConfig()
		{
			return ConfigKurotatoLevelAll.GetConfigList(true) ?? new List<KurotatoLevel>();
		}

		// Token: 0x060388DB RID: 231643 RVA: 0x00D6EF21 File Offset: 0x00D6D121
		public KurotatoLevel? GetKurotatoLevelConfig(int levelId)
		{
			return ConfigKurotatoLevelById.GetConfig(levelId, true);
		}

		// Token: 0x060388DC RID: 231644 RVA: 0x00D6EF2A File Offset: 0x00D6D12A
		public IReadOnlyList<KurotatoLevelGroup> GetAllKurotatoLevelGroupConfig()
		{
			return ConfigKurotatoLevelGroupAll.GetConfigList(true) ?? new List<KurotatoLevelGroup>();
		}

		// Token: 0x060388DD RID: 231645 RVA: 0x00D6EF3B File Offset: 0x00D6D13B
		public KurotatoLevelGroup? GetKurotatoLevelGroupConfig(int groupId)
		{
			return ConfigKurotatoLevelGroupByGroupId.GetConfig(groupId, true);
		}

		// Token: 0x060388DE RID: 231646 RVA: 0x00D6EF44 File Offset: 0x00D6D144
		public KurotatoLevelSecondGroup? GetLevelSecondGroupConfig(int id)
		{
			return ConfigKurotatoLevelSecondGroupById.GetConfig(id, true);
		}

		// Token: 0x060388DF RID: 231647 RVA: 0x00D6EF4D File Offset: 0x00D6D14D
		[NullableContext(2)]
		public IReadOnlyList<KurotatoLevel> GetLevelListBySecondGroup(int secondGroupId)
		{
			return ConfigKurotatoLevelBySecondGroup.GetConfigList(secondGroupId, true);
		}

		// Token: 0x060388E0 RID: 231648 RVA: 0x00D6EF56 File Offset: 0x00D6D156
		public IReadOnlyList<KurotatoWave> GetAllWaveConfig()
		{
			return ConfigKurotatoWaveAll.GetConfigList(true) ?? new List<KurotatoWave>();
		}

		// Token: 0x060388E1 RID: 231649 RVA: 0x00D6EF68 File Offset: 0x00D6D168
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

		// Token: 0x060388E2 RID: 231650 RVA: 0x00D6EFD4 File Offset: 0x00D6D1D4
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

		// Token: 0x060388E3 RID: 231651 RVA: 0x00D6F054 File Offset: 0x00D6D254
		public KurotatoSpawn? GetSpawnById(int spawnId)
		{
			return ConfigKurotatoSpawnById.GetConfig(spawnId, true);
		}

		// Token: 0x060388E4 RID: 231652 RVA: 0x00D6F05D File Offset: 0x00D6D25D
		public KurotatoWaypoints? GetWaypointsById(int waypointsId)
		{
			return ConfigKurotatoWaypointsById.GetConfig(waypointsId, true);
		}

		// Token: 0x060388E5 RID: 231653 RVA: 0x00D6F066 File Offset: 0x00D6D266
		public KurotatoStructure? GetStructureConfigById(int structureId)
		{
			return ConfigKurotatoStructureById.GetConfig(structureId, true);
		}

		// Token: 0x060388E6 RID: 231654 RVA: 0x00D6F06F File Offset: 0x00D6D26F
		public KurotatoMonster? GetMonsterConfigById(int monsterId)
		{
			return ConfigKurotatoMonsterById.GetConfig(monsterId, true);
		}

		// Token: 0x060388E7 RID: 231655 RVA: 0x00D6F078 File Offset: 0x00D6D278
		public KurotatoMonsterType? GetMonsterTypeById(int monsterId)
		{
			return ConfigKurotatoMonsterTypeById.GetConfig(monsterId, true);
		}

		// Token: 0x060388E8 RID: 231656 RVA: 0x00D6F084 File Offset: 0x00D6D284
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

		// Token: 0x060388E9 RID: 231657 RVA: 0x00D6F178 File Offset: 0x00D6D378
		public IReadOnlyList<KurotatoMonsterTag> GetAllMonsterTagList()
		{
			return ConfigKurotatoMonsterTagAll.GetConfigList(true) ?? new List<KurotatoMonsterTag>();
		}

		// Token: 0x060388EA RID: 231658 RVA: 0x00D6F189 File Offset: 0x00D6D389
		public KurotatoMonsterTag? GetMonsterTagById(int tagId)
		{
			return ConfigKurotatoMonsterTagById.GetConfig(tagId, true);
		}

		// Token: 0x060388EB RID: 231659 RVA: 0x00D6F192 File Offset: 0x00D6D392
		public KurotatoMonsterRisk? GetMonsterRiskConfig(int typeId)
		{
			return ConfigKurotatoMonsterRiskById.GetConfig(typeId, true);
		}

		// Token: 0x060388EC RID: 231660 RVA: 0x00D6F19B File Offset: 0x00D6D39B
		public KurotatoMonsterBody? GetBodyTypeConfig(int bodyTypeId)
		{
			return ConfigKurotatoMonsterBodyById.GetConfig(bodyTypeId, true);
		}

		// Token: 0x060388ED RID: 231661 RVA: 0x00D6F1A4 File Offset: 0x00D6D3A4
		public KSCBaseProperty? GetBaseProperty(int id)
		{
			return ConfigKSCBasePropertyById.GetConfig(id, true);
		}

		// Token: 0x060388EE RID: 231662 RVA: 0x00D6F1AD File Offset: 0x00D6D3AD
		public KurotatoMonsterAttribute? GetMonsterAttribute(int id)
		{
			return ConfigKurotatoMonsterAttributeById.GetConfig(id, true);
		}

		// Token: 0x060388EF RID: 231663 RVA: 0x00D6F1B6 File Offset: 0x00D6D3B6
		public IReadOnlyList<KurotatoResAward> GetAllNormalRewardConfig()
		{
			return ConfigKurotatoResAwardAll.GetConfigList(true) ?? new List<KurotatoResAward>();
		}

		// Token: 0x060388F0 RID: 231664 RVA: 0x00D6F1C7 File Offset: 0x00D6D3C7
		public KurotatoResAward? GetNormalRewardConfigById(int rewardId)
		{
			return ConfigKurotatoResAwardById.GetConfig(rewardId, true);
		}

		// Token: 0x060388F1 RID: 231665 RVA: 0x00D6F1D0 File Offset: 0x00D6D3D0
		public IReadOnlyList<KurotatoLimitAward> GetAllLimitRewardConfig()
		{
			return ConfigKurotatoLimitAwardAll.GetConfigList(true) ?? new List<KurotatoLimitAward>();
		}

		// Token: 0x060388F2 RID: 231666 RVA: 0x00D6F1E1 File Offset: 0x00D6D3E1
		public KurotatoLimitAward? GetLimitRewardConfigById(int rewardId)
		{
			return ConfigKurotatoLimitAwardById.GetConfig(rewardId, true);
		}

		// Token: 0x060388F3 RID: 231667 RVA: 0x00D6F1EA File Offset: 0x00D6D3EA
		public IReadOnlyList<KurotatoRewardTab> GetAllRewardTabConfig()
		{
			return ConfigKurotatoRewardTabAll.GetConfigList(true) ?? new List<KurotatoRewardTab>();
		}

		// Token: 0x060388F4 RID: 231668 RVA: 0x00D6F1FB File Offset: 0x00D6D3FB
		public KurotatoRewardTab? GetRewardTabConfigById(int tabId)
		{
			return ConfigKurotatoRewardTabById.GetConfig(tabId, true);
		}

		// Token: 0x060388F5 RID: 231669 RVA: 0x00D6F204 File Offset: 0x00D6D404
		public IReadOnlyList<KurotatoScoreAward> GetAllKurotatoScoreAwardConfig()
		{
			return ConfigKurotatoScoreAwardAll.GetConfigList(true) ?? new List<KurotatoScoreAward>();
		}

		// Token: 0x060388F6 RID: 231670 RVA: 0x00D6F215 File Offset: 0x00D6D415
		public KurotatoScoreAward? GetKurotatoScoreAwardConfigById(int rewardId)
		{
			return ConfigKurotatoScoreAwardById.GetConfig(rewardId, true);
		}

		// Token: 0x060388F7 RID: 231671 RVA: 0x00D6F21E File Offset: 0x00D6D41E
		[NullableContext(2)]
		public IReadOnlyList<KurotatoHandbook> GetKurotatoHandBookListByActivityIdAndType(int activityId, EKurotatoHandBookType type)
		{
			return ConfigKurotatoHandbookByActivityIdAndType.GetConfigList(activityId, (int)type, true);
		}

		// Token: 0x060388F8 RID: 231672 RVA: 0x00D6F228 File Offset: 0x00D6D428
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

		// Token: 0x170087AC RID: 34732
		// (get) Token: 0x060388F9 RID: 231673 RVA: 0x00D6F278 File Offset: 0x00D6D478
		public static KurotatoConfig Instance
		{
			get
			{
				return KurotatoConfig._Instance;
			}
		}

		// Token: 0x060388FA RID: 231674 RVA: 0x00D6F27F File Offset: 0x00D6D47F
		public static KurotatoConfig GetOrCreateInstance()
		{
			if (KurotatoConfig._Instance == null)
			{
				KurotatoConfig.CreateInstance();
			}
			return KurotatoConfig._Instance;
		}

		// Token: 0x060388FB RID: 231675 RVA: 0x00D6F293 File Offset: 0x00D6D493
		public static bool CreateInstance()
		{
			if (KurotatoConfig._Instance != null)
			{
				return true;
			}
			KurotatoConfig._Instance = new KurotatoConfig();
			return true;
		}

		// Token: 0x060388FC RID: 231676 RVA: 0x00D6F2A9 File Offset: 0x00D6D4A9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060388FD RID: 231677 RVA: 0x00D6F2AB File Offset: 0x00D6D4AB
		public static void ResetStaticDefaultValue()
		{
			KurotatoConfig._Instance = null;
		}

		// Token: 0x060388FE RID: 231678 RVA: 0x00D6F2B3 File Offset: 0x00D6D4B3
		static KurotatoConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(KurotatoConfig.CreateStaticDefaultValue), new Action(KurotatoConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DB27 RID: 121639
		[Nullable(2)]
		private static KurotatoConfig _Instance;
	}
}
