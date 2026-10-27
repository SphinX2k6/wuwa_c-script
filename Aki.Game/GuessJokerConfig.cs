using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001047 RID: 4167
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GuessJokerConfig : ConfigBase
{
	// Token: 0x06006AE2 RID: 27362 RVA: 0x001582BC File Offset: 0x001564BC
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

	// Token: 0x06006AE3 RID: 27363 RVA: 0x00158314 File Offset: 0x00156514
	public IReadOnlyList<GuessJokerLevel> GetJokerLevelList()
	{
		IReadOnlyList<GuessJokerLevel> configList = ConfigGuessJokerLevelAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<GuessJokerLevel>();
		}
		return configList;
	}

	// Token: 0x06006AE4 RID: 27364 RVA: 0x00158334 File Offset: 0x00156534
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

	// Token: 0x06006AE5 RID: 27365 RVA: 0x001583D4 File Offset: 0x001565D4
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

	// Token: 0x06006AE6 RID: 27366 RVA: 0x0015842C File Offset: 0x0015662C
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

	// Token: 0x06006AE7 RID: 27367 RVA: 0x001584CC File Offset: 0x001566CC
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

	// Token: 0x06006AE8 RID: 27368 RVA: 0x00158524 File Offset: 0x00156724
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

	// Token: 0x06006AE9 RID: 27369 RVA: 0x0015857C File Offset: 0x0015677C
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

	// Token: 0x06006AEA RID: 27370 RVA: 0x001585D4 File Offset: 0x001567D4
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

	// Token: 0x06006AEB RID: 27371 RVA: 0x00158670 File Offset: 0x00156870
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

	// Token: 0x06006AEC RID: 27372 RVA: 0x001586C8 File Offset: 0x001568C8
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

	// Token: 0x17000899 RID: 2201
	// (get) Token: 0x06006AED RID: 27373 RVA: 0x0015871B File Offset: 0x0015691B
	public static GuessJokerConfig Instance
	{
		get
		{
			return GuessJokerConfig._Instance;
		}
	}

	// Token: 0x06006AEE RID: 27374 RVA: 0x00158722 File Offset: 0x00156922
	public static GuessJokerConfig GetOrCreateInstance()
	{
		if (GuessJokerConfig._Instance == null)
		{
			GuessJokerConfig.CreateInstance();
		}
		return GuessJokerConfig._Instance;
	}

	// Token: 0x06006AEF RID: 27375 RVA: 0x00158736 File Offset: 0x00156936
	public static bool CreateInstance()
	{
		if (GuessJokerConfig._Instance != null)
		{
			return true;
		}
		GuessJokerConfig._Instance = new GuessJokerConfig();
		return true;
	}

	// Token: 0x06006AF0 RID: 27376 RVA: 0x0015874C File Offset: 0x0015694C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006AF1 RID: 27377 RVA: 0x0015874E File Offset: 0x0015694E
	public static void ResetStaticDefaultValue()
	{
		GuessJokerConfig._Instance = null;
	}

	// Token: 0x06006AF2 RID: 27378 RVA: 0x00158756 File Offset: 0x00156956
	static GuessJokerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuessJokerConfig.CreateStaticDefaultValue), new Action(GuessJokerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04003137 RID: 12599
	private List<IGuessJokerNpcAndChairInfo> NpcAndChairMatchInfo = new List<IGuessJokerNpcAndChairInfo>();

	// Token: 0x04003138 RID: 12600
	[Nullable(2)]
	private static GuessJokerConfig _Instance;
}
