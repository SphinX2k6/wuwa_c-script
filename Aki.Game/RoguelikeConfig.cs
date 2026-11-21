using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C66 RID: 7270
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RoguelikeConfig : ConfigBase
{
	// Token: 0x0601205D RID: 73821 RVA: 0x0054DB5B File Offset: 0x0054BD5B
	public RogueBuffPool? GetRogueBuffConfig(int id)
	{
		return ConfigRogueBuffPoolById.GetConfig(id, true);
	}

	// Token: 0x0601205E RID: 73822 RVA: 0x0054DB64 File Offset: 0x0054BD64
	public RogueCharacter? GetRogueCharacterConfig(int id)
	{
		return ConfigRogueCharacterById.GetConfig(id, true);
	}

	// Token: 0x0601205F RID: 73823 RVA: 0x0054DB70 File Offset: 0x0054BD70
	public RoguePokemon? GetRoguePhantomConfig(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return ConfigRoguePokemonById.GetConfig(id, true);
	}

	// Token: 0x06012060 RID: 73824 RVA: 0x0054DB91 File Offset: 0x0054BD91
	public RogueAffix? GetRogueAffixConfig(int id)
	{
		return ConfigRogueAffixById.GetConfig(id, true);
	}

	// Token: 0x06012061 RID: 73825 RVA: 0x0054DB9A File Offset: 0x0054BD9A
	public RogueCharacterBuff? GetRogueCharacterBuffConfig(int id)
	{
		return ConfigRogueCharacterBuffById.GetConfig(id, true);
	}

	// Token: 0x06012062 RID: 73826 RVA: 0x0054DBA3 File Offset: 0x0054BDA3
	public IReadOnlyList<RogueTalentTree> GetRogueTalentTreeConfig()
	{
		return ConfigRogueTalentTreeAll.GetConfigList(true) ?? Array.Empty<RogueTalentTree>();
	}

	// Token: 0x06012063 RID: 73827 RVA: 0x0054DBB4 File Offset: 0x0054BDB4
	public RogueTalentTree? GetRogueTalentTreeById(int id)
	{
		return ConfigRogueTalentTreeById.GetConfig(id, true);
	}

	// Token: 0x06012064 RID: 73828 RVA: 0x0054DBBD File Offset: 0x0054BDBD
	public RogueTalentTreeDesc? GetRogueTalentTreeDescConfig(int id)
	{
		return ConfigRogueTalentTreeDescById.GetConfig(id, true);
	}

	// Token: 0x06012065 RID: 73829 RVA: 0x0054DBC6 File Offset: 0x0054BDC6
	public RogueParam? GetRogueParamConfig(int id = 1)
	{
		return ConfigRogueParamById.GetConfig(id, true);
	}

	// Token: 0x06012066 RID: 73830 RVA: 0x0054DBCF File Offset: 0x0054BDCF
	public RogueCurrency? GetRogueCurrencyConfig(int id)
	{
		return ConfigRogueCurrencyById.GetConfig(id, true);
	}

	// Token: 0x06012067 RID: 73831 RVA: 0x0054DBD8 File Offset: 0x0054BDD8
	public IReadOnlyList<RogueSeasonReward> GetRogueSeasonReward(int seasonId)
	{
		return ConfigRogueSeasonRewardBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06012068 RID: 73832 RVA: 0x0054DBE1 File Offset: 0x0054BDE1
	public IReadOnlyList<RogueToken> GetRogueTokenBySeasonId(int seasonId = 0)
	{
		return ConfigRogueTokenBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06012069 RID: 73833 RVA: 0x0054DBEA File Offset: 0x0054BDEA
	public RogueSeason? GetRogueSeasonConfigById(int id)
	{
		return ConfigRogueSeasonById.GetConfig(id, true);
	}

	// Token: 0x0601206A RID: 73834 RVA: 0x0054DBF3 File Offset: 0x0054BDF3
	public IReadOnlyList<RogueSeason> GetRogueSeasonConfigList()
	{
		return ConfigRogueSeasonAll.GetConfigList(true);
	}

	// Token: 0x0601206B RID: 73835 RVA: 0x0054DBFB File Offset: 0x0054BDFB
	public RogueEvent? GetRogueEventConfigById(int id)
	{
		return ConfigRogueEventById.GetConfig(id, true);
	}

	// Token: 0x0601206C RID: 73836 RVA: 0x0054DC04 File Offset: 0x0054BE04
	public RogueQualityConfig? GetRogueQualityConfigByQualityId(int id)
	{
		return ConfigRogueQualityConfigById.GetConfig(id, true);
	}

	// Token: 0x0601206D RID: 73837 RVA: 0x0054DC0D File Offset: 0x0054BE0D
	public ElementLevel? GetElementLevelConfigById(int level)
	{
		return ConfigElementLevelByLevel.GetConfig(level, true);
	}

	// Token: 0x0601206E RID: 73838 RVA: 0x0054DC16 File Offset: 0x0054BE16
	public RogueRoomType? GetRoguelikeRoomTypeConfigById(int id)
	{
		return ConfigRogueRoomTypeById.GetConfig(id, true);
	}

	// Token: 0x0601206F RID: 73839 RVA: 0x0054DC1F File Offset: 0x0054BE1F
	public RougePopularEntrie? GetRoguelikePopularEntriesById(int id)
	{
		return ConfigRougePopularEntrieById.GetConfig(id, true);
	}

	// Token: 0x06012070 RID: 73840 RVA: 0x0054DC28 File Offset: 0x0054BE28
	public IReadOnlyList<RougePopularEntrie> GetRoguelikePopularEntries()
	{
		return ConfigRougePopularEntrieAll.GetConfigList(true);
	}

	// Token: 0x06012071 RID: 73841 RVA: 0x0054DC30 File Offset: 0x0054BE30
	public RougeMiraclecreation? GetRoguelikeSpecialConfig(int id)
	{
		return ConfigRougeMiraclecreationById.GetConfig(id, true);
	}

	// Token: 0x06012072 RID: 73842 RVA: 0x0054DC39 File Offset: 0x0054BE39
	public RougeMiraclecreationColor? GetRoguelikeMiraclecreationColorConfig(int id)
	{
		return ConfigRougeMiraclecreationColorById.GetConfig(id, true);
	}

	// Token: 0x06012073 RID: 73843 RVA: 0x0054DC42 File Offset: 0x0054BE42
	public RoguePopularEntrieArg? GetRoguePopularEntrieArg(int seasonId, int instanceId)
	{
		return ConfigRoguePopularEntrieArgBySeasonIdAndInstId.GetConfig(seasonId, instanceId, true);
	}

	// Token: 0x06012074 RID: 73844 RVA: 0x0054DC4C File Offset: 0x0054BE4C
	public RogueRoomShowConfig? GetRogueRoomShowConfig(int roomId)
	{
		return ConfigRogueRoomShowConfigById.GetConfig(roomId, true);
	}

	// Token: 0x06012075 RID: 73845 RVA: 0x0054DC55 File Offset: 0x0054BE55
	public RogueRoomPool? GetRoguelikeRoomPoolConfig(int id)
	{
		return ConfigRogueRoomPoolById.GetConfig(id, true);
	}

	// Token: 0x06012076 RID: 73846 RVA: 0x0054DC5E File Offset: 0x0054BE5E
	public RogueInst? GetRogueInstConfig(int instanceId)
	{
		return ConfigRogueInstByInstId.GetConfig(instanceId, true);
	}

	// Token: 0x06012077 RID: 73847 RVA: 0x0054DC67 File Offset: 0x0054BE67
	public RogueHotEntryGroup? GetRogueHotEntryGroupConfig(int groupId)
	{
		return ConfigRogueHotEntryGroupByGroupId.GetConfig(groupId, true);
	}

	// Token: 0x06012078 RID: 73848 RVA: 0x0054DC70 File Offset: 0x0054BE70
	public RogueHotEntry? GetRogueHotEntryConfig(int id)
	{
		return ConfigRogueHotEntryById.GetConfig(id, true);
	}

	// Token: 0x06012079 RID: 73849 RVA: 0x0054DC79 File Offset: 0x0054BE79
	public RogueHotEntryOverview? GetRogueHotEntryOverviewConfig(int id)
	{
		return ConfigRogueHotEntryOverviewById.GetConfig(id, true);
	}

	// Token: 0x0601207A RID: 73850 RVA: 0x0054DC82 File Offset: 0x0054BE82
	public RogueHotEntryType? GetRogueHotEntryTypeConfig(int id)
	{
		return ConfigRogueHotEntryTypeById.GetConfig(id, true);
	}

	// Token: 0x0601207B RID: 73851 RVA: 0x0054DC8B File Offset: 0x0054BE8B
	public RogueSkill? GetRogueSkillConfig(int id)
	{
		return ConfigRogueSkillById.GetConfig(id, true);
	}

	// Token: 0x0601207C RID: 73852 RVA: 0x0054DC94 File Offset: 0x0054BE94
	public RogueTower? GetRogueTowerConfig(int id)
	{
		return ConfigRogueTowerById.GetConfig(id, true);
	}

	// Token: 0x0601207D RID: 73853 RVA: 0x0054DC9D File Offset: 0x0054BE9D
	public RogueTowerBuff? GetRogueTowerBuffConfig(int id)
	{
		return ConfigRogueTowerBuffById.GetConfig(id, true);
	}

	// Token: 0x17001B4C RID: 6988
	// (get) Token: 0x0601207E RID: 73854 RVA: 0x0054DCA6 File Offset: 0x0054BEA6
	[Nullable(1)]
	public static RoguelikeConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoguelikeConfig._Instance;
		}
	}

	// Token: 0x0601207F RID: 73855 RVA: 0x0054DCAD File Offset: 0x0054BEAD
	[NullableContext(1)]
	public static RoguelikeConfig GetOrCreateInstance()
	{
		if (RoguelikeConfig._Instance == null)
		{
			RoguelikeConfig.CreateInstance();
		}
		return RoguelikeConfig._Instance;
	}

	// Token: 0x06012080 RID: 73856 RVA: 0x0054DCC1 File Offset: 0x0054BEC1
	public static bool CreateInstance()
	{
		if (RoguelikeConfig._Instance != null)
		{
			return true;
		}
		RoguelikeConfig._Instance = new RoguelikeConfig();
		return true;
	}

	// Token: 0x06012081 RID: 73857 RVA: 0x0054DCD7 File Offset: 0x0054BED7
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012082 RID: 73858 RVA: 0x0054DCD9 File Offset: 0x0054BED9
	public static void ResetStaticDefaultValue()
	{
		RoguelikeConfig._Instance = null;
	}

	// Token: 0x06012083 RID: 73859 RVA: 0x0054DCE1 File Offset: 0x0054BEE1
	static RoguelikeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeConfig.CreateStaticDefaultValue), new Action(RoguelikeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009D43 RID: 40259
	private static RoguelikeConfig _Instance;
}
