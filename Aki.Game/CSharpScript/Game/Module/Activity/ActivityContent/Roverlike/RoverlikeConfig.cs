using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060E5 RID: 24805
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RoverlikeConfig : ConfigBase
	{
		// Token: 0x0603EB83 RID: 256899 RVA: 0x00F26686 File Offset: 0x00F24886
		public RoverRogueActivity? GetActivityParamConfig(int activityId)
		{
			return ConfigRoverRogueActivityById.GetConfig(activityId, true);
		}

		// Token: 0x0603EB84 RID: 256900 RVA: 0x00F2668F File Offset: 0x00F2488F
		public RoverRogueRole? GetRoleConfig(int id)
		{
			return ConfigRoverRogueRoleById.GetConfig(id, true);
		}

		// Token: 0x0603EB85 RID: 256901 RVA: 0x00F26698 File Offset: 0x00F24898
		public RoverRogueIns? GetInsConfig(int instId)
		{
			return ConfigRoverRogueInsByInstId.GetConfig(instId, true);
		}

		// Token: 0x0603EB86 RID: 256902 RVA: 0x00F266A1 File Offset: 0x00F248A1
		public IReadOnlyList<RoverRogueIns> GetInsConfigList()
		{
			return ConfigRoverRogueInsAll.GetConfigList(true) ?? new List<RoverRogueIns>();
		}

		// Token: 0x0603EB87 RID: 256903 RVA: 0x00F266B2 File Offset: 0x00F248B2
		public RoverRogueBless? GetBlessConfig(int id)
		{
			return ConfigRoverRogueBlessById.GetConfig(id, true);
		}

		// Token: 0x0603EB88 RID: 256904 RVA: 0x00F266BB File Offset: 0x00F248BB
		public IReadOnlyList<RoverRogueBless> GetBlessConfigList()
		{
			return ConfigRoverRogueBlessAll.GetConfigList(true) ?? new List<RoverRogueBless>();
		}

		// Token: 0x0603EB89 RID: 256905 RVA: 0x00F266CC File Offset: 0x00F248CC
		public RoverRogueBlessGroup? GetBlessGroupConfig(int id)
		{
			return ConfigRoverRogueBlessGroupById.GetConfig(id, true);
		}

		// Token: 0x0603EB8A RID: 256906 RVA: 0x00F266D5 File Offset: 0x00F248D5
		public RoverRogueBlessRole? GetBlessRoleConfig(int id)
		{
			return ConfigRoverRogueBlessRoleById.GetConfig(id, true);
		}

		// Token: 0x0603EB8B RID: 256907 RVA: 0x00F266DE File Offset: 0x00F248DE
		public IReadOnlyList<RoverRogueBlessRole> GetBlessRoleConfigListByUnlockInsId(int unlockInsId)
		{
			return ConfigRoverRogueBlessRoleByUnlockInsId.GetConfigList(unlockInsId, true) ?? new List<RoverRogueBlessRole>();
		}

		// Token: 0x0603EB8C RID: 256908 RVA: 0x00F266F0 File Offset: 0x00F248F0
		public IReadOnlyList<RoverRogueBlessRole> GetBlessRoleConfigList()
		{
			return ConfigRoverRogueBlessRoleAll.GetConfigList(true) ?? new List<RoverRogueBlessRole>();
		}

		// Token: 0x0603EB8D RID: 256909 RVA: 0x00F26701 File Offset: 0x00F24901
		public IReadOnlyList<RoverRogueRoleType> GetRoleTypeConfigList()
		{
			List<RoverRogueRoleType> list = (ConfigRoverRogueRoleTypeAll.GetConfigList(true) ?? new List<RoverRogueRoleType>()).ToList<RoverRogueRoleType>();
			list.Sort((RoverRogueRoleType a, RoverRogueRoleType b) => a.Id - b.Id);
			return list;
		}

		// Token: 0x0603EB8E RID: 256910 RVA: 0x00F2673C File Offset: 0x00F2493C
		public RoverRogueRoleType? GetRoleTypeConfig(int id)
		{
			return this.GetRoleTypeConfigList().Cast<RoverRogueRoleType?>().FirstOrDefault((RoverRogueRoleType? cfg) => cfg.Value.Id == id);
		}

		// Token: 0x0603EB8F RID: 256911 RVA: 0x00F26772 File Offset: 0x00F24972
		public RoverRogueRoleEnhance? GetRoleEnhanceConfig(int id)
		{
			return ConfigRoverRogueRoleEnhanceById.GetConfig(id, true);
		}

		// Token: 0x0603EB90 RID: 256912 RVA: 0x00F2677B File Offset: 0x00F2497B
		public IReadOnlyList<RoverRogueRoleEnhance> GetRoleEnhanceConfigList()
		{
			return ConfigRoverRogueRoleEnhanceAll.GetConfigList(true) ?? new List<RoverRogueRoleEnhance>();
		}

		// Token: 0x0603EB91 RID: 256913 RVA: 0x00F2678C File Offset: 0x00F2498C
		public RoverRogueTalentTree? GetTalentTreeConfig(int id)
		{
			return ConfigRoverRogueTalentTreeById.GetConfig(id, true);
		}

		// Token: 0x0603EB92 RID: 256914 RVA: 0x00F26795 File Offset: 0x00F24995
		public RoverRogueItem? GetItemConfig(int id)
		{
			return ConfigRoverRogueItemById.GetConfig(id, true);
		}

		// Token: 0x0603EB93 RID: 256915 RVA: 0x00F2679E File Offset: 0x00F2499E
		public IReadOnlyList<RoverRogueItem> GetItemConfigList()
		{
			return ConfigRoverRogueItemAll.GetConfigList(true) ?? new List<RoverRogueItem>();
		}

		// Token: 0x0603EB94 RID: 256916 RVA: 0x00F267AF File Offset: 0x00F249AF
		public RoverRogueLoot? GetLootConfig(int id)
		{
			return ConfigRoverRogueLootById.GetConfig(id, true);
		}

		// Token: 0x0603EB95 RID: 256917 RVA: 0x00F267B8 File Offset: 0x00F249B8
		public IReadOnlyList<RoverRogueLoot> GetLootConfigListByActivityId(int activityId)
		{
			return ConfigRoverRogueLootByActivityId.GetConfigList(activityId, true) ?? new List<RoverRogueLoot>();
		}

		// Token: 0x0603EB96 RID: 256918 RVA: 0x00F267CA File Offset: 0x00F249CA
		public RoverRogueEffect? GetEffectConfig(int id)
		{
			return ConfigRoverRogueEffectById.GetConfig(id, true);
		}

		// Token: 0x0603EB97 RID: 256919 RVA: 0x00F267D3 File Offset: 0x00F249D3
		public RoverRogueQuality? GetQualityConfig(int id)
		{
			return ConfigRoverRogueQualityById.GetConfig(id, true);
		}

		// Token: 0x0603EB98 RID: 256920 RVA: 0x00F267DC File Offset: 0x00F249DC
		public IReadOnlyList<RoverRogueQuality> GetQualityConfigList()
		{
			List<RoverRogueQuality> list = (ConfigRoverRogueQualityAll.GetConfigList(true) ?? new List<RoverRogueQuality>()).ToList<RoverRogueQuality>();
			list.Sort((RoverRogueQuality a, RoverRogueQuality b) => a.Id - b.Id);
			return list;
		}

		// Token: 0x0603EB99 RID: 256921 RVA: 0x00F26817 File Offset: 0x00F24A17
		public RoverRogueReward? GetRewardConfig(int id)
		{
			return ConfigRoverRogueRewardById.GetConfig(id, true);
		}

		// Token: 0x0603EB9A RID: 256922 RVA: 0x00F26820 File Offset: 0x00F24A20
		public RoverRogueEventChoice? GetEventChoiceConfig(int id)
		{
			return ConfigRoverRogueEventChoiceById.GetConfig(id, true);
		}

		// Token: 0x0603EB9B RID: 256923 RVA: 0x00F26829 File Offset: 0x00F24A29
		public RoverRogueRoom? GetRoomConfig(int id)
		{
			return ConfigRoverRogueRoomById.GetConfig(id, true);
		}

		// Token: 0x0603EB9C RID: 256924 RVA: 0x00F26832 File Offset: 0x00F24A32
		public RoverRogueRoomType? GetRoomTypeConfig(int id)
		{
			return ConfigRoverRogueRoomTypeById.GetConfig(id, true);
		}

		// Token: 0x0603EB9D RID: 256925 RVA: 0x00F2683B File Offset: 0x00F24A3B
		public IReadOnlyList<RoverRogueTalentTree> GetTalentTreeConfigList()
		{
			return ConfigRoverRogueTalentTreeAll.GetConfigList(true) ?? new List<RoverRogueTalentTree>();
		}

		// Token: 0x0603EB9E RID: 256926 RVA: 0x00F2684C File Offset: 0x00F24A4C
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

		// Token: 0x0603EB9F RID: 256927 RVA: 0x00F268BC File Offset: 0x00F24ABC
		public IReadOnlyList<RoverRogueRoad> GetRoadByRoadType(int roadType)
		{
			return ConfigRoverRogueRoadByRoadType.GetConfigList(roadType, true) ?? new List<RoverRogueRoad>();
		}

		// Token: 0x0603EBA0 RID: 256928 RVA: 0x00F268CE File Offset: 0x00F24ACE
		public RoverRogueCurrency? GetCurrencyConfig(int id)
		{
			return ConfigRoverRogueCurrencyById.GetConfig(id, true);
		}

		// Token: 0x17009143 RID: 37187
		// (get) Token: 0x0603EBA1 RID: 256929 RVA: 0x00F268D7 File Offset: 0x00F24AD7
		public static RoverlikeConfig Instance
		{
			get
			{
				return RoverlikeConfig._Instance;
			}
		}

		// Token: 0x0603EBA2 RID: 256930 RVA: 0x00F268DE File Offset: 0x00F24ADE
		public static RoverlikeConfig GetOrCreateInstance()
		{
			if (RoverlikeConfig._Instance == null)
			{
				RoverlikeConfig.CreateInstance();
			}
			return RoverlikeConfig._Instance;
		}

		// Token: 0x0603EBA3 RID: 256931 RVA: 0x00F268F2 File Offset: 0x00F24AF2
		public static bool CreateInstance()
		{
			if (RoverlikeConfig._Instance != null)
			{
				return true;
			}
			RoverlikeConfig._Instance = new RoverlikeConfig();
			return true;
		}

		// Token: 0x0603EBA4 RID: 256932 RVA: 0x00F26908 File Offset: 0x00F24B08
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603EBA5 RID: 256933 RVA: 0x00F2690A File Offset: 0x00F24B0A
		public static void ResetStaticDefaultValue()
		{
			RoverlikeConfig._Instance = null;
		}

		// Token: 0x0603EBA6 RID: 256934 RVA: 0x00F26912 File Offset: 0x00F24B12
		static RoverlikeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RoverlikeConfig.CreateStaticDefaultValue), new Action(RoverlikeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020C8A RID: 134282
		[Nullable(2)]
		private static RoverlikeConfig _Instance;
	}
}
