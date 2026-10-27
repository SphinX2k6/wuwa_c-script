using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200277B RID: 10107
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class RoguelikeConfig : ConfigBase
{
	// Token: 0x06014B7A RID: 84858 RVA: 0x0053ECDB File Offset: 0x0053CEDB
	public RogueBuffPool? GetRogueBuffConfig(int id)
	{
		return ConfigRogueBuffPoolById.GetConfig(id, true);
	}

	// Token: 0x06014B7B RID: 84859 RVA: 0x0053ECE4 File Offset: 0x0053CEE4
	public RogueCharacter? GetRogueCharacterConfig(int id)
	{
		return ConfigRogueCharacterById.GetConfig(id, true);
	}

	// Token: 0x06014B7C RID: 84860 RVA: 0x0053ECF0 File Offset: 0x0053CEF0
	public RoguePokemon? GetRoguePhantomConfig(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return ConfigRoguePokemonById.GetConfig(id, true);
	}

	// Token: 0x06014B7D RID: 84861 RVA: 0x0053ED11 File Offset: 0x0053CF11
	public RogueAffix? GetRogueAffixConfig(int id)
	{
		return ConfigRogueAffixById.GetConfig(id, true);
	}

	// Token: 0x06014B7E RID: 84862 RVA: 0x0053ED1A File Offset: 0x0053CF1A
	public RogueCharacterBuff? GetRogueCharacterBuffConfig(int id)
	{
		return ConfigRogueCharacterBuffById.GetConfig(id, true);
	}

	// Token: 0x06014B7F RID: 84863 RVA: 0x0053ED23 File Offset: 0x0053CF23
	public IReadOnlyList<RogueTalentTree> GetRogueTalentTreeConfig()
	{
		return ConfigRogueTalentTreeAll.GetConfigList(true) ?? Array.Empty<RogueTalentTree>();
	}

	// Token: 0x06014B80 RID: 84864 RVA: 0x0053ED34 File Offset: 0x0053CF34
	public RogueTalentTree? GetRogueTalentTreeById(int id)
	{
		return ConfigRogueTalentTreeById.GetConfig(id, true);
	}

	// Token: 0x06014B81 RID: 84865 RVA: 0x0053ED3D File Offset: 0x0053CF3D
	public RogueTalentTreeDesc? GetRogueTalentTreeDescConfig(int id)
	{
		return ConfigRogueTalentTreeDescById.GetConfig(id, true);
	}

	// Token: 0x06014B82 RID: 84866 RVA: 0x0053ED46 File Offset: 0x0053CF46
	public RogueParam? GetRogueParamConfig(int id = 1)
	{
		return ConfigRogueParamById.GetConfig(id, true);
	}

	// Token: 0x06014B83 RID: 84867 RVA: 0x0053ED4F File Offset: 0x0053CF4F
	public RogueCurrency? GetRogueCurrencyConfig(int id)
	{
		return ConfigRogueCurrencyById.GetConfig(id, true);
	}

	// Token: 0x06014B84 RID: 84868 RVA: 0x0053ED58 File Offset: 0x0053CF58
	public IReadOnlyList<RogueSeasonReward> GetRogueSeasonReward(int seasonId)
	{
		return ConfigRogueSeasonRewardBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06014B85 RID: 84869 RVA: 0x0053ED61 File Offset: 0x0053CF61
	public IReadOnlyList<RogueToken> GetRogueTokenBySeasonId(int seasonId = 0)
	{
		return ConfigRogueTokenBySeasonId.GetConfigList(seasonId, true);
	}

	// Token: 0x06014B86 RID: 84870 RVA: 0x0053ED6A File Offset: 0x0053CF6A
	public RogueSeason? GetRogueSeasonConfigById(int id)
	{
		return ConfigRogueSeasonById.GetConfig(id, true);
	}

	// Token: 0x06014B87 RID: 84871 RVA: 0x0053ED73 File Offset: 0x0053CF73
	public IReadOnlyList<RogueSeason> GetRogueSeasonConfigList()
	{
		return ConfigRogueSeasonAll.GetConfigList(true);
	}

	// Token: 0x06014B88 RID: 84872 RVA: 0x0053ED7B File Offset: 0x0053CF7B
	public RogueEvent? GetRogueEventConfigById(int id)
	{
		return ConfigRogueEventById.GetConfig(id, true);
	}

	// Token: 0x06014B89 RID: 84873 RVA: 0x0053ED84 File Offset: 0x0053CF84
	public RogueQualityConfig? GetRogueQualityConfigByQualityId(int id)
	{
		return ConfigRogueQualityConfigById.GetConfig(id, true);
	}

	// Token: 0x06014B8A RID: 84874 RVA: 0x0053ED8D File Offset: 0x0053CF8D
	public ElementLevel? GetElementLevelConfigById(int level)
	{
		return ConfigElementLevelByLevel.GetConfig(level, true);
	}

	// Token: 0x06014B8B RID: 84875 RVA: 0x0053ED96 File Offset: 0x0053CF96
	public RogueRoomType? GetRoguelikeRoomTypeConfigById(int id)
	{
		return ConfigRogueRoomTypeById.GetConfig(id, true);
	}

	// Token: 0x06014B8C RID: 84876 RVA: 0x0053ED9F File Offset: 0x0053CF9F
	public RougePopularEntrie? GetRoguelikePopularEntriesById(int id)
	{
		return ConfigRougePopularEntrieById.GetConfig(id, true);
	}

	// Token: 0x06014B8D RID: 84877 RVA: 0x0053EDA8 File Offset: 0x0053CFA8
	public IReadOnlyList<RougePopularEntrie> GetRoguelikePopularEntries()
	{
		return ConfigRougePopularEntrieAll.GetConfigList(true);
	}

	// Token: 0x06014B8E RID: 84878 RVA: 0x0053EDB0 File Offset: 0x0053CFB0
	public RougeMiraclecreation? GetRoguelikeSpecialConfig(int id)
	{
		return ConfigRougeMiraclecreationById.GetConfig(id, true);
	}

	// Token: 0x06014B8F RID: 84879 RVA: 0x0053EDB9 File Offset: 0x0053CFB9
	public RougeMiraclecreationColor? GetRoguelikeMiraclecreationColorConfig(int id)
	{
		return ConfigRougeMiraclecreationColorById.GetConfig(id, true);
	}

	// Token: 0x06014B90 RID: 84880 RVA: 0x0053EDC2 File Offset: 0x0053CFC2
	public RoguePopularEntrieArg? GetRoguePopularEntrieArg(int seasonId, int instanceId)
	{
		return ConfigRoguePopularEntrieArgBySeasonIdAndInstId.GetConfig(seasonId, instanceId, true);
	}

	// Token: 0x06014B91 RID: 84881 RVA: 0x0053EDCC File Offset: 0x0053CFCC
	public RogueRoomShowConfig? GetRogueRoomShowConfig(int roomId)
	{
		return ConfigRogueRoomShowConfigById.GetConfig(roomId, true);
	}

	// Token: 0x06014B92 RID: 84882 RVA: 0x0053EDD5 File Offset: 0x0053CFD5
	public RogueRoomPool? GetRoguelikeRoomPoolConfig(int id)
	{
		return ConfigRogueRoomPoolById.GetConfig(id, true);
	}

	// Token: 0x06014B93 RID: 84883 RVA: 0x0053EDDE File Offset: 0x0053CFDE
	public RogueInst? GetRogueInstConfig(int instanceId)
	{
		return ConfigRogueInstByInstId.GetConfig(instanceId, true);
	}

	// Token: 0x06014B94 RID: 84884 RVA: 0x0053EDE7 File Offset: 0x0053CFE7
	public RogueHotEntryGroup? GetRogueHotEntryGroupConfig(int groupId)
	{
		return ConfigRogueHotEntryGroupByGroupId.GetConfig(groupId, true);
	}

	// Token: 0x06014B95 RID: 84885 RVA: 0x0053EDF0 File Offset: 0x0053CFF0
	public RogueHotEntry? GetRogueHotEntryConfig(int id)
	{
		return ConfigRogueHotEntryById.GetConfig(id, true);
	}

	// Token: 0x06014B96 RID: 84886 RVA: 0x0053EDF9 File Offset: 0x0053CFF9
	public RogueHotEntryOverview? GetRogueHotEntryOverviewConfig(int id)
	{
		return ConfigRogueHotEntryOverviewById.GetConfig(id, true);
	}

	// Token: 0x06014B97 RID: 84887 RVA: 0x0053EE02 File Offset: 0x0053D002
	public RogueHotEntryType? GetRogueHotEntryTypeConfig(int id)
	{
		return ConfigRogueHotEntryTypeById.GetConfig(id, true);
	}

	// Token: 0x06014B98 RID: 84888 RVA: 0x0053EE0B File Offset: 0x0053D00B
	public RogueSkill? GetRogueSkillConfig(int id)
	{
		return ConfigRogueSkillById.GetConfig(id, true);
	}

	// Token: 0x06014B99 RID: 84889 RVA: 0x0053EE14 File Offset: 0x0053D014
	public RogueTower? GetRogueTowerConfig(int id)
	{
		return ConfigRogueTowerById.GetConfig(id, true);
	}

	// Token: 0x06014B9A RID: 84890 RVA: 0x0053EE1D File Offset: 0x0053D01D
	public RogueTowerBuff? GetRogueTowerBuffConfig(int id)
	{
		return ConfigRogueTowerBuffById.GetConfig(id, true);
	}

	// Token: 0x17001B13 RID: 6931
	// (get) Token: 0x06014B9B RID: 84891 RVA: 0x0053EE26 File Offset: 0x0053D026
	[Nullable(1)]
	public static RoguelikeConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return RoguelikeConfig._Instance;
		}
	}

	// Token: 0x06014B9C RID: 84892 RVA: 0x0053EE2D File Offset: 0x0053D02D
	[NullableContext(1)]
	public static RoguelikeConfig GetOrCreateInstance()
	{
		if (RoguelikeConfig._Instance == null)
		{
			RoguelikeConfig.CreateInstance();
		}
		return RoguelikeConfig._Instance;
	}

	// Token: 0x06014B9D RID: 84893 RVA: 0x0053EE41 File Offset: 0x0053D041
	public static bool CreateInstance()
	{
		if (RoguelikeConfig._Instance != null)
		{
			return true;
		}
		RoguelikeConfig._Instance = new RoguelikeConfig();
		return true;
	}

	// Token: 0x06014B9E RID: 84894 RVA: 0x0053EE57 File Offset: 0x0053D057
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014B9F RID: 84895 RVA: 0x0053EE59 File Offset: 0x0053D059
	public static void ResetStaticDefaultValue()
	{
		RoguelikeConfig._Instance = null;
	}

	// Token: 0x06014BA0 RID: 84896 RVA: 0x0053EE61 File Offset: 0x0053D061
	static RoguelikeConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoguelikeConfig.CreateStaticDefaultValue), new Action(RoguelikeConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009BEB RID: 39915
	private static RoguelikeConfig _Instance;
}
