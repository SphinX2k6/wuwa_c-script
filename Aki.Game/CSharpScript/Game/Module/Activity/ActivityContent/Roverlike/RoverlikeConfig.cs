using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005063 RID: 20579
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RoverlikeConfig : ConfigBase
	{
		// Token: 0x06033845 RID: 211013 RVA: 0x00E6D51E File Offset: 0x00E6B71E
		public RoverRogueActivity? GetActivityParamConfig(int activityId)
		{
			return ConfigRoverRogueActivityById.GetConfig(activityId, true);
		}

		// Token: 0x06033846 RID: 211014 RVA: 0x00E6D527 File Offset: 0x00E6B727
		public RoverRogueRole? GetRoleConfig(int id)
		{
			return ConfigRoverRogueRoleById.GetConfig(id, true);
		}

		// Token: 0x06033847 RID: 211015 RVA: 0x00E6D530 File Offset: 0x00E6B730
		public RoverRogueIns? GetInsConfig(int instId)
		{
			return ConfigRoverRogueInsByInstId.GetConfig(instId, true);
		}

		// Token: 0x06033848 RID: 211016 RVA: 0x00E6D539 File Offset: 0x00E6B739
		public IReadOnlyList<RoverRogueIns> GetInsConfigList()
		{
			return ConfigRoverRogueInsAll.GetConfigList(true) ?? new List<RoverRogueIns>();
		}

		// Token: 0x06033849 RID: 211017 RVA: 0x00E6D54A File Offset: 0x00E6B74A
		public RoverRogueBless? GetBlessConfig(int id)
		{
			return ConfigRoverRogueBlessById.GetConfig(id, true);
		}

		// Token: 0x0603384A RID: 211018 RVA: 0x00E6D553 File Offset: 0x00E6B753
		public IReadOnlyList<RoverRogueBless> GetBlessConfigList()
		{
			return ConfigRoverRogueBlessAll.GetConfigList(true) ?? new List<RoverRogueBless>();
		}

		// Token: 0x0603384B RID: 211019 RVA: 0x00E6D564 File Offset: 0x00E6B764
		public RoverRogueBlessGroup? GetBlessGroupConfig(int id)
		{
			return ConfigRoverRogueBlessGroupById.GetConfig(id, true);
		}

		// Token: 0x0603384C RID: 211020 RVA: 0x00E6D56D File Offset: 0x00E6B76D
		public RoverRogueBlessRole? GetBlessRoleConfig(int id)
		{
			return ConfigRoverRogueBlessRoleById.GetConfig(id, true);
		}

		// Token: 0x0603384D RID: 211021 RVA: 0x00E6D576 File Offset: 0x00E6B776
		public IReadOnlyList<RoverRogueBlessRole> GetBlessRoleConfigListByUnlockInsId(int unlockInsId)
		{
			return ConfigRoverRogueBlessRoleByUnlockInsId.GetConfigList(unlockInsId, true) ?? new List<RoverRogueBlessRole>();
		}

		// Token: 0x0603384E RID: 211022 RVA: 0x00E6D588 File Offset: 0x00E6B788
		public IReadOnlyList<RoverRogueBlessRole> GetBlessRoleConfigList()
		{
			return ConfigRoverRogueBlessRoleAll.GetConfigList(true) ?? new List<RoverRogueBlessRole>();
		}

		// Token: 0x0603384F RID: 211023 RVA: 0x00E6D599 File Offset: 0x00E6B799
		public IReadOnlyList<RoverRogueRoleType> GetRoleTypeConfigList()
		{
			List<RoverRogueRoleType> list = new List<RoverRogueRoleType>(ConfigRoverRogueRoleTypeAll.GetConfigList(true) ?? new List<RoverRogueRoleType>());
			list.Sort((RoverRogueRoleType a, RoverRogueRoleType b) => a.Id - b.Id);
			return list;
		}

		// Token: 0x06033850 RID: 211024 RVA: 0x00E6D5D4 File Offset: 0x00E6B7D4
		public RoverRogueRoleType? GetRoleTypeConfig(int id)
		{
			foreach (RoverRogueRoleType value in this.GetRoleTypeConfigList())
			{
				if (value.Id == id)
				{
					return new RoverRogueRoleType?(value);
				}
			}
			return null;
		}

		// Token: 0x06033851 RID: 211025 RVA: 0x00E6D638 File Offset: 0x00E6B838
		public RoverRogueRoleEnhance? GetRoleEnhanceConfig(int id)
		{
			return ConfigRoverRogueRoleEnhanceById.GetConfig(id, true);
		}

		// Token: 0x06033852 RID: 211026 RVA: 0x00E6D641 File Offset: 0x00E6B841
		public IReadOnlyList<RoverRogueRoleEnhance> GetRoleEnhanceConfigList()
		{
			return ConfigRoverRogueRoleEnhanceAll.GetConfigList(true) ?? new List<RoverRogueRoleEnhance>();
		}

		// Token: 0x06033853 RID: 211027 RVA: 0x00E6D652 File Offset: 0x00E6B852
		public RoverRogueTalentTree? GetTalentTreeConfig(int id)
		{
			return ConfigRoverRogueTalentTreeById.GetConfig(id, true);
		}

		// Token: 0x06033854 RID: 211028 RVA: 0x00E6D65B File Offset: 0x00E6B85B
		public RoverRogueItem? GetItemConfig(int id)
		{
			return ConfigRoverRogueItemById.GetConfig(id, true);
		}

		// Token: 0x06033855 RID: 211029 RVA: 0x00E6D664 File Offset: 0x00E6B864
		public IReadOnlyList<RoverRogueItem> GetItemConfigList()
		{
			return ConfigRoverRogueItemAll.GetConfigList(true) ?? new List<RoverRogueItem>();
		}

		// Token: 0x06033856 RID: 211030 RVA: 0x00E6D675 File Offset: 0x00E6B875
		public RoverRogueLoot? GetLootConfig(int id)
		{
			return ConfigRoverRogueLootById.GetConfig(id, true);
		}

		// Token: 0x06033857 RID: 211031 RVA: 0x00E6D67E File Offset: 0x00E6B87E
		public IReadOnlyList<RoverRogueLoot> GetLootConfigListByActivityId(int activityId)
		{
			return ConfigRoverRogueLootByActivityId.GetConfigList(activityId, true) ?? new List<RoverRogueLoot>();
		}

		// Token: 0x06033858 RID: 211032 RVA: 0x00E6D690 File Offset: 0x00E6B890
		public RoverRogueEffect? GetEffectConfig(int id)
		{
			return ConfigRoverRogueEffectById.GetConfig(id, true);
		}

		// Token: 0x06033859 RID: 211033 RVA: 0x00E6D699 File Offset: 0x00E6B899
		public RoverRogueQuality? GetQualityConfig(int id)
		{
			return ConfigRoverRogueQualityById.GetConfig(id, true);
		}

		// Token: 0x0603385A RID: 211034 RVA: 0x00E6D6A2 File Offset: 0x00E6B8A2
		public IReadOnlyList<RoverRogueQuality> GetQualityConfigList()
		{
			List<RoverRogueQuality> list = new List<RoverRogueQuality>(ConfigRoverRogueQualityAll.GetConfigList(true) ?? new List<RoverRogueQuality>());
			list.Sort((RoverRogueQuality a, RoverRogueQuality b) => a.Id - b.Id);
			return list;
		}

		// Token: 0x0603385B RID: 211035 RVA: 0x00E6D6DD File Offset: 0x00E6B8DD
		public RoverRogueReward? GetRewardConfig(int id)
		{
			return ConfigRoverRogueRewardById.GetConfig(id, true);
		}

		// Token: 0x0603385C RID: 211036 RVA: 0x00E6D6E6 File Offset: 0x00E6B8E6
		public RoverRogueEventChoice? GetEventChoiceConfig(int id)
		{
			return ConfigRoverRogueEventChoiceById.GetConfig(id, true);
		}

		// Token: 0x0603385D RID: 211037 RVA: 0x00E6D6EF File Offset: 0x00E6B8EF
		public RoverRogueRoom? GetRoomConfig(int id)
		{
			return ConfigRoverRogueRoomById.GetConfig(id, true);
		}

		// Token: 0x0603385E RID: 211038 RVA: 0x00E6D6F8 File Offset: 0x00E6B8F8
		public RoverRogueRoomType? GetRoomTypeConfig(int id)
		{
			return ConfigRoverRogueRoomTypeById.GetConfig(id, true);
		}

		// Token: 0x0603385F RID: 211039 RVA: 0x00E6D701 File Offset: 0x00E6B901
		public IReadOnlyList<RoverRogueTalentTree> GetTalentTreeConfigList()
		{
			return ConfigRoverRogueTalentTreeAll.GetConfigList(true) ?? new List<RoverRogueTalentTree>();
		}

		// Token: 0x06033860 RID: 211040 RVA: 0x00E6D714 File Offset: 0x00E6B914
		public List<RoverRogueIns> GetAllLevelById(int activityId)
		{
			List<RoverRogueIns> list = new List<RoverRogueIns>();
			IEnumerable<RoverRogueIns> enumerable = this.GetInsConfigList() ?? new List<RoverRogueIns>();
			bool flag = activityId > 0;
			foreach (RoverRogueIns item in enumerable)
			{
				if (!flag || item.ActivityId == activityId)
				{
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06033861 RID: 211041 RVA: 0x00E6D784 File Offset: 0x00E6B984
		public IReadOnlyList<RoverRogueRoad> GetRoadByRoadType(int roadType)
		{
			return ConfigRoverRogueRoadByRoadType.GetConfigList(roadType, true) ?? new List<RoverRogueRoad>();
		}

		// Token: 0x06033862 RID: 211042 RVA: 0x00E6D796 File Offset: 0x00E6B996
		public RoverRogueCurrency? GetCurrencyConfig(int id)
		{
			return ConfigRoverRogueCurrencyById.GetConfig(id, true);
		}

		// Token: 0x170064A5 RID: 25765
		// (get) Token: 0x06033863 RID: 211043 RVA: 0x00E6D79F File Offset: 0x00E6B99F
		public static RoverlikeConfig Instance
		{
			get
			{
				return RoverlikeConfig._Instance;
			}
		}

		// Token: 0x06033864 RID: 211044 RVA: 0x00E6D7A6 File Offset: 0x00E6B9A6
		public static RoverlikeConfig GetOrCreateInstance()
		{
			if (RoverlikeConfig._Instance == null)
			{
				RoverlikeConfig.CreateInstance();
			}
			return RoverlikeConfig._Instance;
		}

		// Token: 0x06033865 RID: 211045 RVA: 0x00E6D7BA File Offset: 0x00E6B9BA
		public static bool CreateInstance()
		{
			if (RoverlikeConfig._Instance != null)
			{
				return true;
			}
			RoverlikeConfig._Instance = new RoverlikeConfig();
			return true;
		}

		// Token: 0x06033866 RID: 211046 RVA: 0x00E6D7D0 File Offset: 0x00E6B9D0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033867 RID: 211047 RVA: 0x00E6D7D2 File Offset: 0x00E6B9D2
		public static void ResetStaticDefaultValue()
		{
			RoverlikeConfig._Instance = null;
		}

		// Token: 0x06033868 RID: 211048 RVA: 0x00E6D7DA File Offset: 0x00E6B9DA
		static RoverlikeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeConfig.CreateStaticDefaultValue), new Action(RoverlikeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B5B7 RID: 112055
		[Nullable(2)]
		private static RoverlikeConfig _Instance;
	}
}
