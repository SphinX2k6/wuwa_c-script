using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.FloroRanch;

// Token: 0x02000FFF RID: 4095
[NullableContext(1)]
[Nullable(0)]
[Model(1)]
public class FloroRanchModel : ModelBase
{
	// Token: 0x0600A329 RID: 41769 RVA: 0x002FE008 File Offset: 0x002FC208
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

	// Token: 0x0600A32A RID: 41770 RVA: 0x002FE060 File Offset: 0x002FC260
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

	// Token: 0x0600A32B RID: 41771 RVA: 0x002FE0A8 File Offset: 0x002FC2A8
	private void InitFloroRanchRarity()
	{
		this.FloroRanchRarityMap.Clear();
		foreach (FloroRanchRarity config in FloroRanchConfig.Instance.GetFloroRanchRarityConfigList())
		{
			FloroRanchRarityData value = new FloroRanchRarityData(config);
			this.FloroRanchRarityMap[config.Id] = value;
		}
	}

	// Token: 0x0600A32C RID: 41772 RVA: 0x002FE118 File Offset: 0x002FC318
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

	// Token: 0x0600A32D RID: 41773 RVA: 0x002FE17C File Offset: 0x002FC37C
	private void InitFloroRanchTerrain()
	{
		this.FloroRanchTerrainMap.Clear();
		foreach (FloroRanchTerrain config in FloroRanchConfig.Instance.GetFloroRanchTerrainConfigList())
		{
			FloroRanchTerrainData value = new FloroRanchTerrainData(config);
			this.FloroRanchTerrainMap[config.Id] = value;
		}
	}

	// Token: 0x0600A32E RID: 41774 RVA: 0x002FE1EC File Offset: 0x002FC3EC
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

	// Token: 0x0600A32F RID: 41775 RVA: 0x002FE250 File Offset: 0x002FC450
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

	// Token: 0x0600A330 RID: 41776 RVA: 0x002FE30C File Offset: 0x002FC50C
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

	// Token: 0x0600A331 RID: 41777 RVA: 0x002FE34C File Offset: 0x002FC54C
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

	// Token: 0x0600A332 RID: 41778 RVA: 0x002FE3F0 File Offset: 0x002FC5F0
	private void InitFloroRanchCardGroup()
	{
		this.FloroRanchCardGroupMap.Clear();
		foreach (FloroRanchCardGroup config in FloroRanchConfig.Instance.GetFloroRanchCardGroupConfigList())
		{
			FloroRanchCardGroupData value = new FloroRanchCardGroupData(config);
			this.FloroRanchCardGroupMap[config.Id] = value;
		}
	}

	// Token: 0x0600A333 RID: 41779 RVA: 0x002FE460 File Offset: 0x002FC660
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

	// Token: 0x0600A334 RID: 41780 RVA: 0x002FE4C4 File Offset: 0x002FC6C4
	private void InitFloroRanchCurrency()
	{
		this.FloroRanchCurrencyMap.Clear();
		foreach (FloroRanchCurrency config in FloroRanchConfig.Instance.GetFloroRanchCurrencyConfigList())
		{
			FloroRanchCurrencyConfigData value = new FloroRanchCurrencyConfigData(config);
			this.FloroRanchCurrencyMap[config.Id] = value;
		}
	}

	// Token: 0x0600A335 RID: 41781 RVA: 0x002FE534 File Offset: 0x002FC734
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

	// Token: 0x0600A336 RID: 41782 RVA: 0x002FE598 File Offset: 0x002FC798
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

	// Token: 0x0600A337 RID: 41783 RVA: 0x002FE654 File Offset: 0x002FC854
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

	// Token: 0x0600A338 RID: 41784 RVA: 0x002FE6B8 File Offset: 0x002FC8B8
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

	// Token: 0x0600A339 RID: 41785 RVA: 0x002FE6E9 File Offset: 0x002FC8E9
	public Dictionary<int, FloroRanchCardData> GetFloroRanchCardDataMap()
	{
		if (this.FloroRanchCardDataMap.Count <= 0)
		{
			this.InitFloroRanchCardData();
		}
		return this.FloroRanchCardDataMap;
	}

	// Token: 0x0600A33A RID: 41786 RVA: 0x002FE708 File Offset: 0x002FC908
	private void InitFloroRanchToyData()
	{
		this.FloroRanchToyDataMap.Clear();
		foreach (FloroRanchToy config in FloroRanchConfig.Instance.GetFloroRanchToyConfigList())
		{
			FloroRanchToyData value = new FloroRanchToyData(config);
			this.FloroRanchToyDataMap[config.Id] = value;
		}
	}

	// Token: 0x0600A33B RID: 41787 RVA: 0x002FE778 File Offset: 0x002FC978
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

	// Token: 0x0600A33C RID: 41788 RVA: 0x002FE7DB File Offset: 0x002FC9DB
	public Dictionary<int, FloroRanchToyData> GetFloroRanchToyDataMap()
	{
		if (this.FloroRanchToyDataMap.Count <= 0)
		{
			this.InitFloroRanchToyData();
		}
		return this.FloroRanchToyDataMap;
	}

	// Token: 0x0600A33D RID: 41789 RVA: 0x002FE7F8 File Offset: 0x002FC9F8
	private void InitFloroRanchSkillData()
	{
		this.FloroRanchSkillDataMap.Clear();
		foreach (FloroRanchSkill config in FloroRanchConfig.Instance.GetFloroRanchSkillConfigList())
		{
			FloroRanchSkillData value = new FloroRanchSkillData(config);
			this.FloroRanchSkillDataMap[config.Id] = value;
		}
	}

	// Token: 0x0600A33E RID: 41790 RVA: 0x002FE868 File Offset: 0x002FCA68
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

	// Token: 0x0600A33F RID: 41791 RVA: 0x002FE8CC File Offset: 0x002FCACC
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

	// Token: 0x0600A340 RID: 41792 RVA: 0x002FE924 File Offset: 0x002FCB24
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

	// Token: 0x0600A341 RID: 41793 RVA: 0x002FE9A4 File Offset: 0x002FCBA4
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

	// Token: 0x0600A342 RID: 41794 RVA: 0x002FEA08 File Offset: 0x002FCC08
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

	// Token: 0x0600A343 RID: 41795 RVA: 0x002FEB1C File Offset: 0x002FCD1C
	public Dictionary<int, FloroRanchRaceData> GetFloroRanchRaceDataMap()
	{
		if (this.FloroRanchRaceDataMap.Count <= 0)
		{
			this.InitFloroRanchRaceData();
		}
		return this.FloroRanchRaceDataMap;
	}

	// Token: 0x0600A344 RID: 41796 RVA: 0x002FEB38 File Offset: 0x002FCD38
	public List<FloroRanchTaskTab> GetTaskTabList()
	{
		List<FloroRanchTaskTab> list = new List<FloroRanchTaskTab>(FloroRanchConfig.Instance.GetFloroRanchTaskTabConfigList());
		list.Sort((FloroRanchTaskTab a, FloroRanchTaskTab b) => b.Sort - a.Sort);
		return list;
	}

	// Token: 0x0600A345 RID: 41797 RVA: 0x002FEB6E File Offset: 0x002FCD6E
	public string GetCoinText(long coinNum)
	{
		if (coinNum <= (long)this.MaxCoinNum)
		{
			return coinNum.ToString();
		}
		return coinNum.ToString("0.00e+0");
	}

	// Token: 0x0600A346 RID: 41798 RVA: 0x002FEB90 File Offset: 0x002FCD90
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

	// Token: 0x0600A347 RID: 41799 RVA: 0x002FEBF7 File Offset: 0x002FCDF7
	public ELocalStoragePlayerKey GetSkillStorageKeyByActivityType(EFloroRanchActivityDataType activityType)
	{
		if (activityType == EFloroRanchActivityDataType.Weekly)
		{
			return ELocalStoragePlayerKey.FloroRanchSkillIdWeekly;
		}
		return ELocalStoragePlayerKey.FloroRanchSkillId;
	}

	// Token: 0x17001170 RID: 4464
	// (get) Token: 0x0600A348 RID: 41800 RVA: 0x002FEC08 File Offset: 0x002FCE08
	public static FloroRanchModel Instance
	{
		get
		{
			return FloroRanchModel._Instance;
		}
	}

	// Token: 0x0600A349 RID: 41801 RVA: 0x002FEC0F File Offset: 0x002FCE0F
	public static FloroRanchModel GetOrCreateInstance()
	{
		if (FloroRanchModel._Instance == null)
		{
			FloroRanchModel.CreateInstance();
		}
		return FloroRanchModel._Instance;
	}

	// Token: 0x0600A34A RID: 41802 RVA: 0x002FEC23 File Offset: 0x002FCE23
	public static bool CreateInstance()
	{
		if (FloroRanchModel._Instance != null)
		{
			return true;
		}
		FloroRanchModel._Instance = new FloroRanchModel();
		return true;
	}

	// Token: 0x0600A34B RID: 41803 RVA: 0x002FEC39 File Offset: 0x002FCE39
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A34C RID: 41804 RVA: 0x002FEC3B File Offset: 0x002FCE3B
	public static void ResetStaticDefaultValue()
	{
		FloroRanchModel._Instance = null;
	}

	// Token: 0x0600A34D RID: 41805 RVA: 0x002FEC43 File Offset: 0x002FCE43
	static FloroRanchModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FloroRanchModel.CreateStaticDefaultValue), new Action(FloroRanchModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006013 RID: 24595
	private readonly Dictionary<EFloroRanchActivityDataType, FloroRanchActivityData> ActivityDataMap = new Dictionary<EFloroRanchActivityDataType, FloroRanchActivityData>();

	// Token: 0x04006014 RID: 24596
	private readonly Dictionary<int, FloroRanchRarityData> FloroRanchRarityMap = new Dictionary<int, FloroRanchRarityData>();

	// Token: 0x04006015 RID: 24597
	private readonly Dictionary<int, FloroRanchTerrainData> FloroRanchTerrainMap = new Dictionary<int, FloroRanchTerrainData>();

	// Token: 0x04006016 RID: 24598
	private readonly Dictionary<EFloroRanchCharacterType, Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>>> FloroRanchAudioMap = new Dictionary<EFloroRanchCharacterType, Dictionary<EFloroRanchAudioType, List<FloroRanchAudioData>>>();

	// Token: 0x04006017 RID: 24599
	private readonly Dictionary<int, FloroRanchCardGroupData> FloroRanchCardGroupMap = new Dictionary<int, FloroRanchCardGroupData>();

	// Token: 0x04006018 RID: 24600
	private readonly Dictionary<int, FloroRanchCurrencyConfigData> FloroRanchCurrencyMap = new Dictionary<int, FloroRanchCurrencyConfigData>();

	// Token: 0x04006019 RID: 24601
	private readonly Dictionary<int, FloroRanchCardData> FloroRanchCardDataMap = new Dictionary<int, FloroRanchCardData>();

	// Token: 0x0400601A RID: 24602
	private readonly Dictionary<int, List<FloroRanchCardData>> FloroRanchRaceToCardDataMap = new Dictionary<int, List<FloroRanchCardData>>();

	// Token: 0x0400601B RID: 24603
	private readonly Dictionary<int, FloroRanchToyData> FloroRanchToyDataMap = new Dictionary<int, FloroRanchToyData>();

	// Token: 0x0400601C RID: 24604
	private readonly Dictionary<int, FloroRanchSkillData> FloroRanchSkillDataMap = new Dictionary<int, FloroRanchSkillData>();

	// Token: 0x0400601D RID: 24605
	private readonly Dictionary<int, FloroRanchRaceData> FloroRanchRaceDataMap = new Dictionary<int, FloroRanchRaceData>();

	// Token: 0x0400601E RID: 24606
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FloroRanchRaceData> FloroRanchRaceDataList;

	// Token: 0x0400601F RID: 24607
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<FloroRanchRaceData> FloroRanchRaceDataListIncludeCommon;

	// Token: 0x04006020 RID: 24608
	private readonly int MaxCoinNum = 100000;

	// Token: 0x04006021 RID: 24609
	[Nullable(2)]
	private static FloroRanchModel _Instance;
}
