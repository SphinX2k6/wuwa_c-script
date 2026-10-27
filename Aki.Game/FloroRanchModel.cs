using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.FloroRanch;

// Token: 0x02001B40 RID: 6976
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class FloroRanchModel : ModelBase
{
	// Token: 0x0600CF18 RID: 53016 RVA: 0x002F2F30 File Offset: 0x002F1130
	public void SetActivityData(EFloroRanchActivityDataType activityType, FloroRanchActivityData activityData)
	{
		if (this.ActivityDataMap.ContainsKey(activityType))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "ActivityData already exists";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityType", activityType);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ActivityDataMap[activityType] = activityData;
	}

	// Token: 0x0600CF19 RID: 53017 RVA: 0x002F2F88 File Offset: 0x002F1188
	[NullableContext(2)]
	public FloroRanchActivityData GetActivityData(EFloroRanchActivityDataType activityType = EFloroRanchActivityDataType.Normal, bool bShowLog = true)
	{
		FloroRanchActivityData floroRanchActivityData;
		this.ActivityDataMap.TryGetValue(activityType, out floroRanchActivityData);
		if (floroRanchActivityData == null && bShowLog)
		{
			Log.Instance.Error(ELogModule.FloroRanch, ELogAuthor.BB, "FloroRanchActivityData is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}
		return floroRanchActivityData;
	}

	// Token: 0x0600CF1A RID: 53018 RVA: 0x002F2FD0 File Offset: 0x002F11D0
	private void InitFloroRanchRarity()
	{
		this.FloroRanchRarityMap.Clear();
		foreach (FloroRanchRarity config in FloroRanchConfig.Instance.GetFloroRanchRarityConfigList())
		{
			FloroRanchRarityData value = new FloroRanchRarityData(config);
			this.FloroRanchRarityMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF1B RID: 53019 RVA: 0x002F3040 File Offset: 0x002F1240
	[NullableContext(2)]
	public FloroRanchRarityData GetFloroRanchRarity(int id)
	{
		if (this.FloroRanchRarityMap.Count <= 0)
		{
			this.InitFloroRanchRarity();
		}
		FloroRanchRarityData result;
		if (this.FloroRanchRarityMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Invalid FloroRanchRarity";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF1C RID: 53020 RVA: 0x002F30A4 File Offset: 0x002F12A4
	private void InitFloroRanchTerrain()
	{
		this.FloroRanchTerrainMap.Clear();
		foreach (FloroRanchTerrain config in FloroRanchConfig.Instance.GetFloroRanchTerrainConfigList())
		{
			FloroRanchTerrainData value = new FloroRanchTerrainData(config);
			this.FloroRanchTerrainMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF1D RID: 53021 RVA: 0x002F3114 File Offset: 0x002F1314
	[NullableContext(2)]
	public FloroRanchTerrainData GetFloroRanchTerrain(int id)
	{
		if (this.FloroRanchTerrainMap.Count <= 0)
		{
			this.InitFloroRanchTerrain();
		}
		FloroRanchTerrainData result;
		if (this.FloroRanchTerrainMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Invalid FloroRanchTerrain";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF1E RID: 53022 RVA: 0x002F3178 File Offset: 0x002F1378
	private void InitFloroRanchAudio()
	{
		this.FloroRanchAudioMap.Clear();
		foreach (FloroRanchAudio config in FloroRanchConfig.Instance.GetFloroRanchAudioConfigList())
		{
			FloroRanchAudioData item = new FloroRanchAudioData(config);
			Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>> dictionary;
			if (!this.FloroRanchAudioMap.TryGetValue((EFloroRanchCharacterType)config.CharacterType, out dictionary))
			{
				dictionary = new Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>>();
				this.FloroRanchAudioMap[(EFloroRanchCharacterType)config.CharacterType] = dictionary;
			}
			List<FloroRanchAudioData> list;
			if (!dictionary.TryGetValue((EFloroRanchAudioType)config.Type, out list))
			{
				list = new List<FloroRanchAudioData>();
			}
			list.Add(item);
			dictionary[(EFloroRanchAudioType)config.Type] = list;
		}
	}

	// Token: 0x0600CF1F RID: 53023 RVA: 0x002F3234 File Offset: 0x002F1434
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FloroRanchAudioData> GetFloroRanchAudioListForCharacterAndType(EFloroRanchCharacterType characterType, EFloroRanchAudioType type)
	{
		if (this.FloroRanchAudioMap.Count <= 0)
		{
			this.InitFloroRanchAudio();
		}
		Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>> dictionary;
		List<FloroRanchAudioData> result;
		if (this.FloroRanchAudioMap.TryGetValue(characterType, out dictionary) && dictionary.TryGetValue(type, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0600CF20 RID: 53024 RVA: 0x002F3274 File Offset: 0x002F1474
	[NullableContext(2)]
	public unsafe FloroRanchAudioData GetFloroRanchRandomAudioDataByType(EFloroRanchAudioType type, EFloroRanchCharacterType characterType = EFloroRanchCharacterType.Floro)
	{
		List<FloroRanchAudioData> floroRanchAudioListForCharacterAndType = this.GetFloroRanchAudioListForCharacterAndType(characterType, type);
		if ((floroRanchAudioListForCharacterAndType == null || floroRanchAudioListForCharacterAndType.Count <= 0) && characterType != EFloroRanchCharacterType.Floro)
		{
			floroRanchAudioListForCharacterAndType = this.GetFloroRanchAudioListForCharacterAndType(EFloroRanchCharacterType.Floro, type);
		}
		if (floroRanchAudioListForCharacterAndType == null || floroRanchAudioListForCharacterAndType.Count <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "Invalid FloroRanchAudio";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("characterType", characterType);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return ObjectUtils.GetRandomArrayItem<FloroRanchAudioData>(floroRanchAudioListForCharacterAndType);
	}

	// Token: 0x0600CF21 RID: 53025 RVA: 0x002F3318 File Offset: 0x002F1518
	private void InitFloroRanchCardGroup()
	{
		this.FloroRanchCardGroupMap.Clear();
		foreach (FloroRanchCardGroup config in FloroRanchConfig.Instance.GetFloroRanchCardGroupConfigList())
		{
			FloroRanchCardGroupData value = new FloroRanchCardGroupData(config);
			this.FloroRanchCardGroupMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF22 RID: 53026 RVA: 0x002F3388 File Offset: 0x002F1588
	[NullableContext(2)]
	public FloroRanchCardGroupData GetFloroRanchCardGroup(int id)
	{
		if (this.FloroRanchCardGroupMap.Count <= 0)
		{
			this.InitFloroRanchCardGroup();
		}
		FloroRanchCardGroupData result;
		if (this.FloroRanchCardGroupMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Invalid FloroRanchCardGroup";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF23 RID: 53027 RVA: 0x002F33EC File Offset: 0x002F15EC
	private void InitFloroRanchCurrency()
	{
		this.FloroRanchCurrencyMap.Clear();
		foreach (FloroRanchCurrency config in FloroRanchConfig.Instance.GetFloroRanchCurrencyConfigList())
		{
			FloroRanchCurrencyConfigData value = new FloroRanchCurrencyConfigData(config);
			this.FloroRanchCurrencyMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF24 RID: 53028 RVA: 0x002F345C File Offset: 0x002F165C
	[NullableContext(2)]
	public FloroRanchCurrencyConfigData GetFloroRanchCurrencyConfig(ECurrencyType currencyType)
	{
		if (this.FloroRanchCurrencyMap.Count <= 0)
		{
			this.InitFloroRanchCurrency();
		}
		FloroRanchCurrencyConfigData result;
		if (this.FloroRanchCurrencyMap.TryGetValue((int)currencyType, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "Invalid FloroRanchCurrency";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("currencyType", currencyType);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF25 RID: 53029 RVA: 0x002F34C0 File Offset: 0x002F16C0
	private void InitFloroRanchCardData()
	{
		this.FloroRanchCardDataMap.Clear();
		this.FloroRanchRaceToCardDataMap.Clear();
		foreach (FloroRanchCard config in FloroRanchConfig.Instance.GetFloroRanchCardConfigList())
		{
			FloroRanchCardData floroRanchCardData = new FloroRanchCardData(config);
			this.FloroRanchCardDataMap[config.Id] = floroRanchCardData;
			if (floroRanchCardData.IsShowInHandBook)
			{
				int race = config.Race;
				if (!this.FloroRanchRaceToCardDataMap.ContainsKey(race))
				{
					this.FloroRanchRaceToCardDataMap[race] = new List<FloroRanchCardData>();
				}
				this.FloroRanchRaceToCardDataMap[race].Add(floroRanchCardData);
			}
		}
	}

	// Token: 0x0600CF26 RID: 53030 RVA: 0x002F357C File Offset: 0x002F177C
	[NullableContext(2)]
	public FloroRanchCardData GetFloroRanchCardData(int id)
	{
		if (this.FloroRanchCardDataMap.Count <= 0)
		{
			this.InitFloroRanchCardData();
		}
		FloroRanchCardData result;
		if (this.FloroRanchCardDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Invalid FloroRanchCardData";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF27 RID: 53031 RVA: 0x002F35E0 File Offset: 0x002F17E0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<FloroRanchCardData> GetFloroRanchCardDataListByRace(int race)
	{
		if (this.FloroRanchCardDataMap.Count <= 0)
		{
			this.InitFloroRanchCardData();
		}
		List<FloroRanchCardData> result;
		this.FloroRanchRaceToCardDataMap.TryGetValue(race, out result);
		return result;
	}

	// Token: 0x0600CF28 RID: 53032 RVA: 0x002F3611 File Offset: 0x002F1811
	public Dictionary<int, FloroRanchCardData> GetFloroRanchCardDataMap()
	{
		if (this.FloroRanchCardDataMap.Count <= 0)
		{
			this.InitFloroRanchCardData();
		}
		return this.FloroRanchCardDataMap;
	}

	// Token: 0x0600CF29 RID: 53033 RVA: 0x002F3630 File Offset: 0x002F1830
	private void InitFloroRanchToyData()
	{
		this.FloroRanchToyDataMap.Clear();
		foreach (FloroRanchToy config in FloroRanchConfig.Instance.GetFloroRanchToyConfigList())
		{
			FloroRanchToyData value = new FloroRanchToyData(config);
			this.FloroRanchToyDataMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF2A RID: 53034 RVA: 0x002F36A0 File Offset: 0x002F18A0
	[NullableContext(2)]
	public FloroRanchToyData GetFloroRanchToyData(int id)
	{
		if (this.FloroRanchToyDataMap.Count <= 0)
		{
			this.InitFloroRanchToyData();
		}
		FloroRanchToyData result;
		if (this.FloroRanchToyDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Invalid FloroRanchToyData";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF2B RID: 53035 RVA: 0x002F3703 File Offset: 0x002F1903
	public Dictionary<int, FloroRanchToyData> GetFloroRanchToyDataMap()
	{
		if (this.FloroRanchToyDataMap.Count <= 0)
		{
			this.InitFloroRanchToyData();
		}
		return this.FloroRanchToyDataMap;
	}

	// Token: 0x0600CF2C RID: 53036 RVA: 0x002F3720 File Offset: 0x002F1920
	private void InitFloroRanchSkillData()
	{
		this.FloroRanchSkillDataMap.Clear();
		foreach (FloroRanchSkill config in FloroRanchConfig.Instance.GetFloroRanchSkillConfigList())
		{
			FloroRanchSkillData value = new FloroRanchSkillData(config);
			this.FloroRanchSkillDataMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF2D RID: 53037 RVA: 0x002F3790 File Offset: 0x002F1990
	[NullableContext(2)]
	public FloroRanchSkillData GetFloroRanchSkillData(int id)
	{
		if (this.FloroRanchSkillDataMap.Count <= 0)
		{
			this.InitFloroRanchSkillData();
		}
		FloroRanchSkillData result;
		if (this.FloroRanchSkillDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.BB;
		string message = "Invalid FloroRanchSkillData";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF2E RID: 53038 RVA: 0x002F37F4 File Offset: 0x002F19F4
	public List<FloroRanchSkillData> GetFloroRanchSkillDataList()
	{
		if (this.FloroRanchSkillDataMap.Count <= 0)
		{
			this.InitFloroRanchSkillData();
		}
		List<FloroRanchSkillData> list = new List<FloroRanchSkillData>(this.FloroRanchSkillDataMap.Values);
		list.Sort((FloroRanchSkillData a, FloroRanchSkillData b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x0600CF2F RID: 53039 RVA: 0x002F384C File Offset: 0x002F1A4C
	private void InitFloroRanchRaceData()
	{
		this.FloroRanchRaceDataMap.Clear();
		this.FloroRanchRaceDataList = null;
		this.FloroRanchRaceDataListIncludeCommon = null;
		foreach (FloroRanchRace config in FloroRanchConfig.Instance.GetFloroRanchRaceConfigList())
		{
			FloroRanchRaceData value = new FloroRanchRaceData(config);
			this.FloroRanchRaceDataMap[config.Id] = value;
		}
	}

	// Token: 0x0600CF30 RID: 53040 RVA: 0x002F38CC File Offset: 0x002F1ACC
	[NullableContext(2)]
	public FloroRanchRaceData GetFloroRanchRaceData(int id)
	{
		if (this.FloroRanchRaceDataMap.Count <= 0)
		{
			this.InitFloroRanchRaceData();
		}
		FloroRanchRaceData result;
		if (this.FloroRanchRaceDataMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanch;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "Invalid FloroRanchRaceData";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CF31 RID: 53041 RVA: 0x002F3930 File Offset: 0x002F1B30
	public List<FloroRanchRaceData> GetFloroRanchRaceDataList(bool isIncludeCommonRace = false)
	{
		if (this.FloroRanchRaceDataMap.Count <= 0)
		{
			this.InitFloroRanchRaceData();
		}
		if (this.FloroRanchRaceDataList == null || this.FloroRanchRaceDataListIncludeCommon == null)
		{
			this.FloroRanchRaceDataList = new List<FloroRanchRaceData>();
			this.FloroRanchRaceDataListIncludeCommon = new List<FloroRanchRaceData>();
			foreach (FloroRanchRaceData floroRanchRaceData in this.FloroRanchRaceDataMap.Values)
			{
				if (!floroRanchRaceData.IsCommon)
				{
					this.FloroRanchRaceDataList.Add(floroRanchRaceData);
				}
				this.FloroRanchRaceDataListIncludeCommon.Add(floroRanchRaceData);
			}
			this.FloroRanchRaceDataList.Sort((FloroRanchRaceData a, FloroRanchRaceData b) => a.Id - b.Id);
			this.FloroRanchRaceDataListIncludeCommon.Sort((FloroRanchRaceData a, FloroRanchRaceData b) => a.Id - b.Id);
		}
		if (!isIncludeCommonRace)
		{
			return this.FloroRanchRaceDataList;
		}
		return this.FloroRanchRaceDataListIncludeCommon;
	}

	// Token: 0x0600CF32 RID: 53042 RVA: 0x002F3A44 File Offset: 0x002F1C44
	public Dictionary<int, FloroRanchRaceData> GetFloroRanchRaceDataMap()
	{
		if (this.FloroRanchRaceDataMap.Count <= 0)
		{
			this.InitFloroRanchRaceData();
		}
		return this.FloroRanchRaceDataMap;
	}

	// Token: 0x0600CF33 RID: 53043 RVA: 0x002F3A60 File Offset: 0x002F1C60
	public List<FloroRanchTaskTab> GetTaskTabList()
	{
		List<FloroRanchTaskTab> list = new List<FloroRanchTaskTab>(FloroRanchConfig.Instance.GetFloroRanchTaskTabConfigList());
		list.Sort((FloroRanchTaskTab a, FloroRanchTaskTab b) => b.Sort - a.Sort);
		return list;
	}

	// Token: 0x0600CF34 RID: 53044 RVA: 0x002F3A96 File Offset: 0x002F1C96
	public string GetCoinText(long coinNum)
	{
		if (coinNum <= (long)this.MaxCoinNum)
		{
			return coinNum.ToString();
		}
		return coinNum.ToString("0.00e+0");
	}

	// Token: 0x0600CF35 RID: 53045 RVA: 0x002F3AB8 File Offset: 0x002F1CB8
	public EFloroRanchActivityDataType GetActivityDataType(int activityId)
	{
		if (activityId == 0)
		{
			return EFloroRanchActivityDataType.Normal;
		}
		FloroRanchActivity? floroRanchActivityConfig = FloroRanchConfig.Instance.GetFloroRanchActivityConfig(activityId);
		if (floroRanchActivityConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanch;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "Invalid FloroRanchActivity";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return EFloroRanchActivityDataType.Normal;
		}
		return (EFloroRanchActivityDataType)floroRanchActivityConfig.Value.ActivityType;
	}

	// Token: 0x0600CF36 RID: 53046 RVA: 0x002F3B1F File Offset: 0x002F1D1F
	public ELocalStoragePlayerKey GetSkillStorageKeyByActivityType(EFloroRanchActivityDataType activityType)
	{
		if (activityType == EFloroRanchActivityDataType.Weekly)
		{
			return ELocalStoragePlayerKey.FloroRanchSkillIdWeekly;
		}
		return ELocalStoragePlayerKey.FloroRanchSkillId;
	}

	// Token: 0x1700114B RID: 4427
	// (get) Token: 0x0600CF37 RID: 53047 RVA: 0x002F3B30 File Offset: 0x002F1D30
	public static FloroRanchModel Instance
	{
		get
		{
			return FloroRanchModel._Instance;
		}
	}

	// Token: 0x0600CF38 RID: 53048 RVA: 0x002F3B37 File Offset: 0x002F1D37
	public static FloroRanchModel GetOrCreateInstance()
	{
		if (FloroRanchModel._Instance == null)
		{
			FloroRanchModel.CreateInstance();
		}
		return FloroRanchModel._Instance;
	}

	// Token: 0x0600CF39 RID: 53049 RVA: 0x002F3B4B File Offset: 0x002F1D4B
	public static bool CreateInstance()
	{
		if (FloroRanchModel._Instance != null)
		{
			return true;
		}
		FloroRanchModel._Instance = new FloroRanchModel();
		return true;
	}

	// Token: 0x0600CF3A RID: 53050 RVA: 0x002F3B61 File Offset: 0x002F1D61
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CF3B RID: 53051 RVA: 0x002F3B63 File Offset: 0x002F1D63
	public static void ResetStaticDefaultValue()
	{
		FloroRanchModel._Instance = null;
	}

	// Token: 0x0600CF3C RID: 53052 RVA: 0x002F3B6B File Offset: 0x002F1D6B
	static FloroRanchModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchModel.CreateStaticDefaultValue), new Action(FloroRanchModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005F44 RID: 24388
	private readonly Dictionary<EFloroRanchActivityDataType, FloroRanchActivityData> ActivityDataMap = new Dictionary<EFloroRanchActivityDataType, FloroRanchActivityData>();

	// Token: 0x04005F45 RID: 24389
	private readonly Dictionary<int, FloroRanchRarityData> FloroRanchRarityMap = new Dictionary<int, FloroRanchRarityData>();

	// Token: 0x04005F46 RID: 24390
	private readonly Dictionary<int, FloroRanchTerrainData> FloroRanchTerrainMap = new Dictionary<int, FloroRanchTerrainData>();

	// Token: 0x04005F47 RID: 24391
	private readonly Dictionary<EFloroRanchCharacterType, Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>>> FloroRanchAudioMap = new Dictionary<EFloroRanchCharacterType, Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>>>();

	// Token: 0x04005F48 RID: 24392
	private readonly Dictionary<int, FloroRanchCardGroupData> FloroRanchCardGroupMap = new Dictionary<int, FloroRanchCardGroupData>();

	// Token: 0x04005F49 RID: 24393
	private readonly Dictionary<int, FloroRanchCurrencyConfigData> FloroRanchCurrencyMap = new Dictionary<int, FloroRanchCurrencyConfigData>();

	// Token: 0x04005F4A RID: 24394
	private readonly Dictionary<int, FloroRanchCardData> FloroRanchCardDataMap = new Dictionary<int, FloroRanchCardData>();

	// Token: 0x04005F4B RID: 24395
	private readonly Dictionary<int, List<FloroRanchCardData>> FloroRanchRaceToCardDataMap = new Dictionary<int, List<FloroRanchCardData>>();

	// Token: 0x04005F4C RID: 24396
	private readonly Dictionary<int, FloroRanchToyData> FloroRanchToyDataMap = new Dictionary<int, FloroRanchToyData>();

	// Token: 0x04005F4D RID: 24397
	private readonly Dictionary<int, FloroRanchSkillData> FloroRanchSkillDataMap = new Dictionary<int, FloroRanchSkillData>();

	// Token: 0x04005F4E RID: 24398
	private readonly Dictionary<int, FloroRanchRaceData> FloroRanchRaceDataMap = new Dictionary<int, FloroRanchRaceData>();

	// Token: 0x04005F4F RID: 24399
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FloroRanchRaceData> FloroRanchRaceDataList;

	// Token: 0x04005F50 RID: 24400
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FloroRanchRaceData> FloroRanchRaceDataListIncludeCommon;

	// Token: 0x04005F51 RID: 24401
	private readonly int MaxCoinNum = 100000;

	// Token: 0x04005F52 RID: 24402
	[Nullable(2)]
	private static FloroRanchModel _Instance;
}
