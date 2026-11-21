using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020020FE RID: 8446
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SurvivorsRogueModel : ModelBase
{
	// Token: 0x17001F20 RID: 7968
	// (get) Token: 0x06014B83 RID: 84867 RVA: 0x00608D21 File Offset: 0x00606F21
	// (set) Token: 0x06014B84 RID: 84868 RVA: 0x00608D2C File Offset: 0x00606F2C
	public int CurLevelId
	{
		get
		{
			return this.CurLevelIdInternal;
		}
		set
		{
			this.CurLevelIdInternal = value;
			this.MaxWaveNum = SurvivorsRogueConfig.Instance.GetMaxWaveNumByLevelId(value);
			this.WaveTypeArray = new int[this.MaxWaveNum];
			for (int i = 0; i < this.MaxWaveNum; i++)
			{
				this.WaveTypeArray[i] = SurvivorsRogueConfig.Instance.GetWaveType(value, i + 1);
			}
			this.CurComboConfig = SurvivorsRogueConfig.Instance.GetComboConfig(value);
		}
	}

	// Token: 0x17001F21 RID: 7969
	// (get) Token: 0x06014B85 RID: 84869 RVA: 0x00608D9A File Offset: 0x00606F9A
	public int CurRoleId
	{
		get
		{
			SurvivorsRoleGainData roleGainData = this.GainData.GetRoleGainData();
			if (roleGainData == null)
			{
				return 0;
			}
			return roleGainData.ConfigId;
		}
	}

	// Token: 0x17001F22 RID: 7970
	// (get) Token: 0x06014B86 RID: 84870 RVA: 0x00608DB2 File Offset: 0x00606FB2
	public int CurRoleLevel
	{
		get
		{
			SurvivorsRoleGainData roleGainData = this.GainData.GetRoleGainData();
			if (roleGainData == null)
			{
				return 0;
			}
			return roleGainData.Data.Level;
		}
	}

	// Token: 0x17001F23 RID: 7971
	// (get) Token: 0x06014B87 RID: 84871 RVA: 0x00608DCF File Offset: 0x00606FCF
	public int CurWaveRemainTime
	{
		get
		{
			return SurvivorsRogueConfig.Instance.GetWaveDuration(this.CurLevelId, this.CurWaveNum);
		}
	}

	// Token: 0x17001F24 RID: 7972
	// (get) Token: 0x06014B88 RID: 84872 RVA: 0x00608DE7 File Offset: 0x00606FE7
	public bool IsEndlessWave
	{
		get
		{
			return SurvivorsRogueConfig.Instance.GetWaveType(this.CurLevelId, this.CurWaveNum) == 2 && this.BattleData.EndlessWaveEnabled;
		}
	}

	// Token: 0x17001F25 RID: 7973
	// (get) Token: 0x06014B89 RID: 84873 RVA: 0x00608E0F File Offset: 0x0060700F
	public bool IsBonusWave
	{
		get
		{
			return SurvivorsRogueConfig.Instance.IsBonusWave(this.CurLevelId, this.CurWaveNum);
		}
	}

	// Token: 0x17001F26 RID: 7974
	// (get) Token: 0x06014B8A RID: 84874 RVA: 0x00608E27 File Offset: 0x00607027
	public int CurWaveNum
	{
		get
		{
			return this.BattleData.GetBatch();
		}
	}

	// Token: 0x06014B8B RID: 84875 RVA: 0x00608E34 File Offset: 0x00607034
	public unsafe void InitComboEnhanceCfg(IList<ComboParamInfo> params_)
	{
		if (params_ == null || params_.Count != 4)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.CK;
			string message = "幸存者连杀等级配置数量不匹配";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("合法数量", 4);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("实际数量", (params_ != null) ? params_.Count : 0);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		for (int i = 0; i < 4; i++)
		{
			this.ComboTimerFreezeTimeCfg[i] = params_[i].KeepTime;
			this.ComboDurationAdditionCfg[i] = params_[i].AddTime;
		}
	}

	// Token: 0x17001F27 RID: 7975
	// (get) Token: 0x06014B8C RID: 84876 RVA: 0x00608EED File Offset: 0x006070ED
	// (set) Token: 0x06014B8D RID: 84877 RVA: 0x00608EF8 File Offset: 0x006070F8
	public SurvivorsRogueModel.EWaveTipsState WaveTipsState
	{
		get
		{
			return this.WaveTipsStateInternal;
		}
		set
		{
			if (this.WaveTipsStateInternal == value)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SurvivorsRogue;
				ELogAuthor author = ELogAuthor.CK;
				string message = "重复设置WaveTipsState, 直接跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("State", value);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.WaveTipsStateInternal = value;
			EventSystem.Instance.Emit<int>(EEventName.SurvivorsRogueSwitchWaveTipsState, (int)value);
		}
	}

	// Token: 0x17001F28 RID: 7976
	// (get) Token: 0x06014B8E RID: 84878 RVA: 0x00608F56 File Offset: 0x00607156
	public bool NeedOpenActivityMainView
	{
		get
		{
			bool hasNewSettle = this.HasNewSettle;
			this.HasNewSettle = false;
			return hasNewSettle;
		}
	}

	// Token: 0x06014B8F RID: 84879 RVA: 0x00608F65 File Offset: 0x00607165
	public void SetCurrentActivityId(int id)
	{
		this.CurrentActivityIdInternal = id;
	}

	// Token: 0x06014B90 RID: 84880 RVA: 0x00608F6E File Offset: 0x0060716E
	public bool IsActivityOn()
	{
		return this.CurrentActivityIdInternal != 0;
	}

	// Token: 0x17001F29 RID: 7977
	// (get) Token: 0x06014B91 RID: 84881 RVA: 0x00608F79 File Offset: 0x00607179
	[Nullable(2)]
	public global::SurvivorsActivityData ActivityData
	{
		[NullableContext(2)]
		get
		{
			if (this.CurrentActivityIdInternal == 0)
			{
				return null;
			}
			return ActivityModel.Instance.GetActivityById(this.CurrentActivityIdInternal) as global::SurvivorsActivityData;
		}
	}

	// Token: 0x06014B92 RID: 84882 RVA: 0x00608F9A File Offset: 0x0060719A
	public void InitCommandQueue()
	{
		this.ClearCommandQueue();
		this.CommandQueue = new SurvivorsRogueCommandQueue();
	}

	// Token: 0x06014B93 RID: 84883 RVA: 0x00608FAD File Offset: 0x006071AD
	public void ClearCommandQueue()
	{
		if (this.CommandQueue != null)
		{
			this.CommandQueue.Clear();
			this.CommandQueue = null;
		}
	}

	// Token: 0x06014B94 RID: 84884 RVA: 0x00608FCC File Offset: 0x006071CC
	public void ClearGlobal()
	{
		this.ClearCommandQueue();
		this.BattleData.Clear();
		this.GainData.Clear();
		this.SelectLevelInfo = null;
		this.CurLevelIdInternal = 0;
		this.MaxWaveNum = 0;
		this.WaveTypeArray = Array.Empty<int>();
		this.WaveTipsStateInternal = SurvivorsRogueModel.EWaveTipsState.Default;
		this.NotTipsShopPurchaseAvailable = false;
		for (int i = 0; i < 4; i++)
		{
			this.ComboTimerFreezeTimeCfg[i] = 0;
			this.ComboDurationAdditionCfg[i] = 0;
		}
	}

	// Token: 0x06014B95 RID: 84885 RVA: 0x00609044 File Offset: 0x00607244
	public int GetRogueCurrencyItemId()
	{
		if (this.GetRogueActivityConfig() == null)
		{
			return 0;
		}
		SurvivorsActivityConfig? survivorsActivityConfig;
		return survivorsActivityConfig.GetValueOrDefault().CurrencyItemId;
	}

	// Token: 0x06014B96 RID: 84886 RVA: 0x00609074 File Offset: 0x00607274
	public SurvivorsActivityConfig? GetRogueActivityConfig()
	{
		if (!this.IsActivityOn())
		{
			return null;
		}
		return SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(this.CurrentActivityIdInternal);
	}

	// Token: 0x06014B97 RID: 84887 RVA: 0x006090A3 File Offset: 0x006072A3
	public bool GetDebugMode()
	{
		return false;
	}

	// Token: 0x06014B98 RID: 84888 RVA: 0x006090A6 File Offset: 0x006072A6
	public void SetDebugMode(bool bOn)
	{
		this.DebugMode = bOn;
	}

	// Token: 0x06014B99 RID: 84889 RVA: 0x006090AF File Offset: 0x006072AF
	public void SaveCacheHandbookClickedMap()
	{
		if (this.HandbookClickedMap != null)
		{
			LocalStorage.SetPlayer<Dictionary<int, Dictionary<int, HashSet<int>>>>(ELocalStoragePlayerKey.SurvivorsHandbookClicked, this.HandbookClickedMap);
		}
	}

	// Token: 0x06014B9A RID: 84890 RVA: 0x006090CC File Offset: 0x006072CC
	public bool GetItemIsNew(ESurvivorsRogueItemType type, int id)
	{
		if (this.HandbookClickedMap == null)
		{
			this.HandbookClickedMap = LocalStorage.GetPlayer<Dictionary<int, Dictionary<int, HashSet<int>>>>(ELocalStoragePlayerKey.SurvivorsHandbookClicked, null);
		}
		Dictionary<int, HashSet<int>> dictionary;
		HashSet<int> hashSet;
		return !this.GetItemIsLock(type, id) && (this.HandbookClickedMap == null || !this.HandbookClickedMap.TryGetValue(this.CurrentActivityIdInternal, out dictionary) || !dictionary.TryGetValue((int)type, out hashSet) || !hashSet.Contains(id));
	}

	// Token: 0x06014B9B RID: 84891 RVA: 0x00609138 File Offset: 0x00607338
	public void SetItemClicked(ESurvivorsRogueItemType type, int id)
	{
		if (this.HandbookClickedMap == null)
		{
			this.HandbookClickedMap = new Dictionary<int, Dictionary<int, HashSet<int>>>();
		}
		if (this.GetItemIsLock(type, id))
		{
			return;
		}
		int currentActivityIdInternal = this.CurrentActivityIdInternal;
		Dictionary<int, HashSet<int>> dictionary;
		if (!this.HandbookClickedMap.TryGetValue(currentActivityIdInternal, out dictionary))
		{
			dictionary = new Dictionary<int, HashSet<int>>();
			this.HandbookClickedMap[currentActivityIdInternal] = dictionary;
		}
		HashSet<int> hashSet;
		if (!dictionary.TryGetValue((int)type, out hashSet))
		{
			hashSet = new HashSet<int>();
			dictionary[(int)type] = hashSet;
		}
		hashSet.Add(id);
	}

	// Token: 0x06014B9C RID: 84892 RVA: 0x006091B0 File Offset: 0x006073B0
	public bool GetItemIsLock(ESurvivorsRogueItemType type, int id)
	{
		IReadOnlyDictionary<int, bool> readOnlyDictionary = null;
		if (type == ESurvivorsRogueItemType.Normal)
		{
			global::SurvivorsActivityData activityData = this.ActivityData;
			readOnlyDictionary = ((activityData != null) ? activityData.ItemMap : null);
		}
		else if (type == ESurvivorsRogueItemType.Character)
		{
			global::SurvivorsActivityData activityData2 = this.ActivityData;
			readOnlyDictionary = ((activityData2 != null) ? activityData2.RoleMap : null);
		}
		else if (type == ESurvivorsRogueItemType.Weapon)
		{
			global::SurvivorsActivityData activityData3 = this.ActivityData;
			readOnlyDictionary = ((activityData3 != null) ? activityData3.WeaponMap : null);
		}
		bool flag;
		return readOnlyDictionary == null || !readOnlyDictionary.TryGetValue(id, out flag) || !flag;
	}

	// Token: 0x06014B9D RID: 84893 RVA: 0x00609220 File Offset: 0x00607420
	public List<ISurvivorsAttributeUiData> GetRoleDefaultAttributeList(int roleId, [Nullable(2)] IList<int> propertyIds)
	{
		Aki.Config.SurvivorsRole? survivorsRole = SurvivorsRogueConfig.Instance.GetSurvivorsRole(roleId);
		int propId = survivorsRole.Value.PropId;
		int[] recommendPropertyArray = survivorsRole.Value.GetRecommendPropertyArray();
		Dictionary<EKSC_AttrType, float> attrsDataByPropertyConfig = KscUtil.GetAttrsDataByPropertyConfig(ConfigKSCBasePropertyById.GetConfig(propId, true).Value);
		List<ISurvivorsAttributeUiData> list = new List<ISurvivorsAttributeUiData>();
		if (propertyIds == null)
		{
			return list;
		}
		for (int i = 0; i < propertyIds.Count; i++)
		{
			int num = propertyIds[i];
			SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(num);
			float num3;
			float num2 = (attrsDataByPropertyConfig != null && attrsDataByPropertyConfig.TryGetValue((EKSC_AttrType)num, out num3)) ? num3 : 0f;
			bool isRecommend = recommendPropertyArray != null && Array.IndexOf<int>(recommendPropertyArray, num) >= 0;
			SurvivorsAttributeUiData item = new SurvivorsAttributeUiData
			{
				AttrId = propertyConfig.Value.Id,
				Value = (double)(propertyConfig.Value.IsBasePermyriad ? (num2 / 10000f) : num2),
				IsRecommend = isRecommend
			};
			list.Add(item);
		}
		list.Sort(delegate(ISurvivorsAttributeUiData dataA, ISurvivorsAttributeUiData dataB)
		{
			bool isRecommend2 = dataA.IsRecommend;
			bool isRecommend3 = dataB.IsRecommend;
			if (isRecommend2 == isRecommend3)
			{
				return dataA.AttrId - dataB.AttrId;
			}
			if (isRecommend2)
			{
				return -1;
			}
			return 1;
		});
		return list;
	}

	// Token: 0x17001F2A RID: 7978
	// (get) Token: 0x06014B9E RID: 84894 RVA: 0x0060935A File Offset: 0x0060755A
	public static SurvivorsRogueModel Instance
	{
		get
		{
			return SurvivorsRogueModel._Instance;
		}
	}

	// Token: 0x06014B9F RID: 84895 RVA: 0x00609361 File Offset: 0x00607561
	public static SurvivorsRogueModel GetOrCreateInstance()
	{
		if (SurvivorsRogueModel._Instance == null)
		{
			SurvivorsRogueModel.CreateInstance();
		}
		return SurvivorsRogueModel._Instance;
	}

	// Token: 0x06014BA0 RID: 84896 RVA: 0x00609375 File Offset: 0x00607575
	public static bool CreateInstance()
	{
		if (SurvivorsRogueModel._Instance != null)
		{
			return true;
		}
		SurvivorsRogueModel._Instance = new SurvivorsRogueModel();
		return true;
	}

	// Token: 0x06014BA1 RID: 84897 RVA: 0x0060938B File Offset: 0x0060758B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014BA2 RID: 84898 RVA: 0x0060938D File Offset: 0x0060758D
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueModel._Instance = null;
	}

	// Token: 0x06014BA3 RID: 84899 RVA: 0x00609395 File Offset: 0x00607595
	static SurvivorsRogueModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueModel.CreateStaticDefaultValue), new Action(SurvivorsRogueModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400B0BA RID: 45242
	public const int COMBO_LEVEL_CONFIG_LENGTH = 4;

	// Token: 0x0400B0BB RID: 45243
	public const int PERMYRIAD_RATIO = 10000;

	// Token: 0x0400B0BC RID: 45244
	private int CurLevelIdInternal;

	// Token: 0x0400B0BD RID: 45245
	public SurvivorsCombo? CurComboConfig;

	// Token: 0x0400B0BE RID: 45246
	public int MaxWaveNum;

	// Token: 0x0400B0BF RID: 45247
	public int[] WaveTypeArray = Array.Empty<int>();

	// Token: 0x0400B0C0 RID: 45248
	public readonly int[] ComboTimerFreezeTimeCfg = new int[4];

	// Token: 0x0400B0C1 RID: 45249
	public readonly int[] ComboDurationAdditionCfg = new int[4];

	// Token: 0x0400B0C2 RID: 45250
	private SurvivorsRogueModel.EWaveTipsState WaveTipsStateInternal;

	// Token: 0x0400B0C3 RID: 45251
	public bool HasNewSettle;

	// Token: 0x0400B0C4 RID: 45252
	private int CurrentActivityIdInternal;

	// Token: 0x0400B0C5 RID: 45253
	[Nullable(2)]
	public SurvivorsActivityDefine.SurvivorsLevelInfo SelectLevelInfo;

	// Token: 0x0400B0C6 RID: 45254
	public bool NotTipsShopPurchaseAvailable;

	// Token: 0x0400B0C7 RID: 45255
	public SurvivorsRogueBattleData BattleData = SurvivorsRogueBattleData.Create();

	// Token: 0x0400B0C8 RID: 45256
	public SurvivorsRogueGainData GainData = SurvivorsRogueGainData.Create();

	// Token: 0x0400B0C9 RID: 45257
	[Nullable(2)]
	public SurvivorsRogueCommandQueue CommandQueue;

	// Token: 0x0400B0CA RID: 45258
	private bool DebugMode;

	// Token: 0x0400B0CB RID: 45259
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, Dictionary<int, HashSet<int>>> HandbookClickedMap;

	// Token: 0x0400B0CC RID: 45260
	[Nullable(2)]
	private static SurvivorsRogueModel _Instance;

	// Token: 0x020083A4 RID: 33700
	[NullableContext(0)]
	public enum EWaveTipsState
	{
		// Token: 0x0402A7F2 RID: 174066
		Default,
		// Token: 0x0402A7F3 RID: 174067
		PopWaveTips,
		// Token: 0x0402A7F4 RID: 174068
		ResidentWaveTips,
		// Token: 0x0402A7F5 RID: 174069
		WaveCompleteTips
	}
}
