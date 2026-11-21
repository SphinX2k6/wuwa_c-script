using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FE9 RID: 4073
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FloroRanchConfig : ConfigBase
{
	// Token: 0x0600A258 RID: 41560 RVA: 0x002FAEB8 File Offset: 0x002F90B8
	public FloroRanchActivity? GetFloroRanchActivityConfig(int activityId)
	{
		FloroRanchActivity? config = ConfigFloroRanchActivityById.GetConfig(activityId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchActivity表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A259 RID: 41561 RVA: 0x002FAF10 File Offset: 0x002F9110
	public IReadOnlyList<FloroRanchIns> GetFloroRanchDungeonConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchIns> configList = ConfigFloroRanchInsByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchIns表 无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchIns>();
		}
		return configList;
	}

	// Token: 0x0600A25A RID: 41562 RVA: 0x002FAF60 File Offset: 0x002F9160
	public FloroRanchSubIns? GetFloroRanchSubDungeonConfig(int id)
	{
		FloroRanchSubIns? config = ConfigFloroRanchSubInsById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchSubIns表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A25B RID: 41563 RVA: 0x002FAFB8 File Offset: 0x002F91B8
	public IReadOnlyList<FloroRanchRarity> GetFloroRanchRarityConfigList()
	{
		IReadOnlyList<FloroRanchRarity> configList = ConfigFloroRanchRarityAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchRarity表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchRarity>();
		}
		return configList;
	}

	// Token: 0x0600A25C RID: 41564 RVA: 0x002FAFF8 File Offset: 0x002F91F8
	public FloroRanchRace? GetFloroRanchRaceConfig(int id)
	{
		FloroRanchRace? config = ConfigFloroRanchRaceById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchRace表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A25D RID: 41565 RVA: 0x002FB050 File Offset: 0x002F9250
	public IReadOnlyList<FloroRanchRace> GetFloroRanchRaceConfigList()
	{
		IReadOnlyList<FloroRanchRace> configList = ConfigFloroRanchRaceAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchRace表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchRace>();
		}
		return configList;
	}

	// Token: 0x0600A25E RID: 41566 RVA: 0x002FB090 File Offset: 0x002F9290
	public FloroRanchCard? GetFloroRanchCardConfig(int id)
	{
		FloroRanchCard? config = ConfigFloroRanchCardById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchCard表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A25F RID: 41567 RVA: 0x002FB0E8 File Offset: 0x002F92E8
	public IReadOnlyList<FloroRanchCard> GetFloroRanchCardConfigList()
	{
		IReadOnlyList<FloroRanchCard> configList = ConfigFloroRanchCardAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchCard表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchCard>();
		}
		return configList;
	}

	// Token: 0x0600A260 RID: 41568 RVA: 0x002FB128 File Offset: 0x002F9328
	public FloroRanchToy? GetFloroRanchToyConfig(int id)
	{
		FloroRanchToy? config = ConfigFloroRanchToyById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchToy表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A261 RID: 41569 RVA: 0x002FB180 File Offset: 0x002F9380
	public IReadOnlyList<FloroRanchToy> GetFloroRanchToyConfigList()
	{
		IReadOnlyList<FloroRanchToy> configList = ConfigFloroRanchToyAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchToy表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchToy>();
		}
		return configList;
	}

	// Token: 0x0600A262 RID: 41570 RVA: 0x002FB1C0 File Offset: 0x002F93C0
	public IReadOnlyList<FloroRanchTerrain> GetFloroRanchTerrainConfigList()
	{
		IReadOnlyList<FloroRanchTerrain> configList = ConfigFloroRanchTerrainAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchTerrain表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchTerrain>();
		}
		return configList;
	}

	// Token: 0x0600A263 RID: 41571 RVA: 0x002FB200 File Offset: 0x002F9400
	public FloroRanchSkill? GetFloroRanchSkillConfig(int id)
	{
		FloroRanchSkill? config = ConfigFloroRanchSkillById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchSkill表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A264 RID: 41572 RVA: 0x002FB258 File Offset: 0x002F9458
	public IReadOnlyList<FloroRanchSkill> GetFloroRanchSkillConfigList()
	{
		IReadOnlyList<FloroRanchSkill> configList = ConfigFloroRanchSkillAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchSkill表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchSkill>();
		}
		return configList;
	}

	// Token: 0x0600A265 RID: 41573 RVA: 0x002FB298 File Offset: 0x002F9498
	public IReadOnlyList<FloroRanchTech> GetFloroRanchTechnologyConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchTech> configList = ConfigFloroRanchTechByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTech表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchTech>();
		}
		return configList;
	}

	// Token: 0x0600A266 RID: 41574 RVA: 0x002FB2E8 File Offset: 0x002F94E8
	public IReadOnlyList<FloroRanchTask> GetFloroRanchTaskConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchTask> configList = ConfigFloroRanchTaskByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTask表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchTask>();
		}
		return configList;
	}

	// Token: 0x0600A267 RID: 41575 RVA: 0x002FB338 File Offset: 0x002F9538
	public IReadOnlyList<FloroRanchReward> GetFloroRanchRewardConfigList(int activityId)
	{
		IReadOnlyList<FloroRanchReward> configList = ConfigFloroRanchRewardByActivityId.GetConfigList(activityId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchReward表无效activityId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<FloroRanchReward>();
		}
		return configList;
	}

	// Token: 0x0600A268 RID: 41576 RVA: 0x002FB388 File Offset: 0x002F9588
	public IReadOnlyList<FloroRanchFilterType> GetFloroRanchFilterTypeConfigList()
	{
		IReadOnlyList<FloroRanchFilterType> configList = ConfigFloroRanchFilterTypeAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.LRC, "FloroRanchFilterType表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchFilterType>();
		}
		return configList;
	}

	// Token: 0x0600A269 RID: 41577 RVA: 0x002FB3C8 File Offset: 0x002F95C8
	public IReadOnlyList<FloroRanchCardGroup> GetFloroRanchCardGroupConfigList()
	{
		IReadOnlyList<FloroRanchCardGroup> configList = ConfigFloroRanchCardGroupAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchCardGroup表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchCardGroup>();
		}
		return configList;
	}

	// Token: 0x0600A26A RID: 41578 RVA: 0x002FB408 File Offset: 0x002F9608
	public IReadOnlyList<FloroRanchCurrency> GetFloroRanchCurrencyConfigList()
	{
		IReadOnlyList<FloroRanchCurrency> configList = ConfigFloroRanchCurrencyAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.LRC, "FloroRanchCurrency表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchCurrency>();
		}
		return configList;
	}

	// Token: 0x0600A26B RID: 41579 RVA: 0x002FB448 File Offset: 0x002F9648
	public FloroRanchBuff? GetFloroRanchBuffById(int id)
	{
		FloroRanchBuff? config = ConfigFloroRanchBuffById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchBuff表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A26C RID: 41580 RVA: 0x002FB4A0 File Offset: 0x002F96A0
	public FloroRanchWeeklyEvent? GetFloroRanchWeeklyEventById(int id)
	{
		FloroRanchWeeklyEvent? config = ConfigFloroRanchWeeklyEventById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchWeeklyEvent表获取失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A26D RID: 41581 RVA: 0x002FB4F8 File Offset: 0x002F96F8
	public FloroRanchWeeklyChoice? GetFloroRanchWeeklyChoiceById(int id)
	{
		FloroRanchWeeklyChoice? config = ConfigFloroRanchWeeklyChoiceById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchWeeklyChoice表获取失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A26E RID: 41582 RVA: 0x002FB550 File Offset: 0x002F9750
	public IReadOnlyList<FloroRanchAudio> GetFloroRanchAudioConfigList()
	{
		IReadOnlyList<FloroRanchAudio> configList = ConfigFloroRanchAudioAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchAudio表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchAudio>();
		}
		return configList;
	}

	// Token: 0x0600A26F RID: 41583 RVA: 0x002FB590 File Offset: 0x002F9790
	public IReadOnlyList<FloroRanchTaskTab> GetFloroRanchTaskTabConfigList()
	{
		IReadOnlyList<FloroRanchTaskTab> configList = ConfigFloroRanchTaskTabAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.CXJ, "FloroRanchTaskTab表获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<FloroRanchTaskTab>();
		}
		return configList;
	}

	// Token: 0x0600A270 RID: 41584 RVA: 0x002FB5D0 File Offset: 0x002F97D0
	public FloroRanchTag? GetFloroRanchTagConfig(int tagId)
	{
		FloroRanchTag? config = ConfigFloroRanchTagById.GetConfig(tagId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchTag表无效tagId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagId", tagId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x0600A271 RID: 41585 RVA: 0x002FB628 File Offset: 0x002F9828
	public FloroRanchAction? GetFloroRanchActionConfig(int actionId)
	{
		FloroRanchAction? config = ConfigFloroRanchActionById.GetConfig(actionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.BB;
			string message = "FloroRanchAction表无效actionId";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", actionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x1700115C RID: 4444
	// (get) Token: 0x0600A272 RID: 41586 RVA: 0x002FB680 File Offset: 0x002F9880
	public static FloroRanchConfig Instance
	{
		get
		{
			return FloroRanchConfig._Instance;
		}
	}

	// Token: 0x0600A273 RID: 41587 RVA: 0x002FB687 File Offset: 0x002F9887
	public static FloroRanchConfig GetOrCreateInstance()
	{
		if (FloroRanchConfig._Instance == null)
		{
			FloroRanchConfig.CreateInstance();
		}
		return FloroRanchConfig._Instance;
	}

	// Token: 0x0600A274 RID: 41588 RVA: 0x002FB69B File Offset: 0x002F989B
	public static bool CreateInstance()
	{
		if (FloroRanchConfig._Instance != null)
		{
			return true;
		}
		FloroRanchConfig._Instance = new FloroRanchConfig();
		return true;
	}

	// Token: 0x0600A275 RID: 41589 RVA: 0x002FB6B1 File Offset: 0x002F98B1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A276 RID: 41590 RVA: 0x002FB6B3 File Offset: 0x002F98B3
	public static void ResetStaticDefaultValue()
	{
		FloroRanchConfig._Instance = null;
	}

	// Token: 0x0600A277 RID: 41591 RVA: 0x002FB6BB File Offset: 0x002F98BB
	static FloroRanchConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchConfig.CreateStaticDefaultValue), new Action(FloroRanchConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005F60 RID: 24416
	[Nullable(2)]
	private static FloroRanchConfig _Instance;
}
