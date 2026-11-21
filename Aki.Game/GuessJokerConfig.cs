using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020004FB RID: 1275
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GuessJokerConfig : ConfigBase
{
	// Token: 0x06003E77 RID: 15991 RVA: 0x00160BE4 File Offset: 0x0015EDE4
	public GuessJokerLevel? GetJokerLevelById(int levelId)
	{
		GuessJokerLevel? config = ConfigGuessJokerLevelById.GetConfig(levelId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerLevel表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", levelId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003E78 RID: 15992 RVA: 0x00160C3C File Offset: 0x0015EE3C
	public IReadOnlyList<GuessJokerLevel> GetJokerLevelList()
	{
		IReadOnlyList<GuessJokerLevel> configList = ConfigGuessJokerLevelAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<GuessJokerLevel>();
		}
		return configList;
	}

	// Token: 0x06003E79 RID: 15993 RVA: 0x00160C5C File Offset: 0x0015EE5C
	public List<IGuessJokerNpcAndChairInfo> GetNpcAndChairMatchInfo()
	{
		if (this.NpcAndChairMatchInfo.Count > 0)
		{
			return this.NpcAndChairMatchInfo;
		}
		List<IGuessJokerNpcAndChairInfo> list = new List<IGuessJokerNpcAndChairInfo>();
		IReadOnlyList<GuessJokerAiConfig> configList = ConfigGuessJokerAiConfigAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<IGuessJokerNpcAndChairInfo>();
		}
		foreach (GuessJokerAiConfig guessJokerAiConfig in configList)
		{
			list.Add(new GuessJokerNpcAndChairInfo
			{
				NpcId = guessJokerAiConfig.NpcId,
				ChairId = guessJokerAiConfig.ChairId
			});
		}
		this.NpcAndChairMatchInfo = list;
		return this.NpcAndChairMatchInfo;
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x00160CFC File Offset: 0x0015EEFC
	public JokerDeck? GetJokerDeck(int cardId)
	{
		JokerDeck? config = ConfigJokerDeckById.GetConfig(cardId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "JokerDeck表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", cardId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x00160D54 File Offset: 0x0015EF54
	public GuessJokerLevel? GetJokerLevelByNpcId(int npcId)
	{
		IReadOnlyList<GuessJokerLevel> configList = ConfigGuessJokerLevelAll.GetConfigList(true);
		if (configList == null)
		{
			return null;
		}
		foreach (GuessJokerLevel value in configList)
		{
			int aiRole = value.AiRole;
			GuessJokerAiConfig? jokerAiConfigByRoleId = this.GetJokerAiConfigByRoleId(aiRole);
			if (jokerAiConfigByRoleId != null && jokerAiConfigByRoleId.GetValueOrDefault().NpcId == npcId)
			{
				return new GuessJokerLevel?(value);
			}
		}
		return null;
	}

	// Token: 0x06003E7C RID: 15996 RVA: 0x00160DF4 File Offset: 0x0015EFF4
	public JokerSkill? GetJokerSkill(int skillId)
	{
		JokerSkill? config = ConfigJokerSkillById.GetConfig(skillId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "JokerSkill表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", skillId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003E7D RID: 15997 RVA: 0x00160E4C File Offset: 0x0015F04C
	public GuessJokerAiConfig? GetJokerAiConfigByRoleId(int roleId)
	{
		GuessJokerAiConfig? config = ConfigGuessJokerAiConfigById.GetConfig(roleId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerAiConfig表无效roleId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003E7E RID: 15998 RVA: 0x00160EA4 File Offset: 0x0015F0A4
	public GuessJokerAiConfig? GetJokerAiConfigByEntityId(int entityId)
	{
		GuessJokerAiConfig? config = ConfigGuessJokerAiConfigByNpcId.GetConfig(entityId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerAiConfig表无效entityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003E7F RID: 15999 RVA: 0x00160EFC File Offset: 0x0015F0FC
	public GuessJokerAIPlotConfig? GetJokerAiPlotConfig(EGuessJokerPlayerType playerType, EGuessJokerPlotTiming timing, int extraParam = 0)
	{
		int num = (playerType == EGuessJokerPlayerType.Ai) ? GuessJokerGamePlayModel.Instance.GetRoleId() : 0;
		IReadOnlyList<GuessJokerAIPlotConfig> configList = ConfigGuessJokerAIPlotConfigAll.GetConfigList(true);
		if (configList == null)
		{
			return null;
		}
		foreach (GuessJokerAIPlotConfig value in configList)
		{
			if (value.RoleId == num && value.State == (int)timing && value.ExtraParam == extraParam)
			{
				return new GuessJokerAIPlotConfig?(value);
			}
		}
		return null;
	}

	// Token: 0x06003E80 RID: 16000 RVA: 0x00160F98 File Offset: 0x0015F198
	public GuessJokerPlotConfig? GetJokerPlotConfig(int plotId)
	{
		GuessJokerPlotConfig? config = ConfigGuessJokerPlotConfigById.GetConfig(plotId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerPlotConfig表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", plotId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x00160FF0 File Offset: 0x0015F1F0
	public GuessJokerParam? GetJokerParam(string key)
	{
		GuessJokerParam? config = ConfigGuessJokerParamByKey.GetConfig(key, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "GuessJokerParam表无效key";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x06003E82 RID: 16002 RVA: 0x00161043 File Offset: 0x0015F243
	public static GuessJokerConfig Instance
	{
		get
		{
			return GuessJokerConfig._Instance;
		}
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x0016104A File Offset: 0x0015F24A
	public static GuessJokerConfig GetOrCreateInstance()
	{
		if (GuessJokerConfig._Instance == null)
		{
			GuessJokerConfig.CreateInstance();
		}
		return GuessJokerConfig._Instance;
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x0016105E File Offset: 0x0015F25E
	public static bool CreateInstance()
	{
		if (GuessJokerConfig._Instance != null)
		{
			return true;
		}
		GuessJokerConfig._Instance = new GuessJokerConfig();
		return true;
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x00161074 File Offset: 0x0015F274
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x00161076 File Offset: 0x0015F276
	public static void ResetStaticDefaultValue()
	{
		GuessJokerConfig._Instance = null;
	}

	// Token: 0x06003E87 RID: 16007 RVA: 0x0016107E File Offset: 0x0015F27E
	static GuessJokerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerConfig.CreateStaticDefaultValue), new Action(GuessJokerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040031D0 RID: 12752
	private List<IGuessJokerNpcAndChairInfo> NpcAndChairMatchInfo = new List<IGuessJokerNpcAndChairInfo>();

	// Token: 0x040031D1 RID: 12753
	[Nullable(2)]
	private static GuessJokerConfig _Instance;
}
