using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002B82 RID: 11138
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SurvivorsRogueModel : ModelBase
{
	// Token: 0x17001EC8 RID: 7880
	// (get) Token: 0x06017152 RID: 94546 RVA: 0x005DC145 File Offset: 0x005DA345
	// (set) Token: 0x06017153 RID: 94547 RVA: 0x005DC150 File Offset: 0x005DA350
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

	// Token: 0x17001EC9 RID: 7881
	// (get) Token: 0x06017154 RID: 94548 RVA: 0x005DC1BE File Offset: 0x005DA3BE
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

	// Token: 0x17001ECA RID: 7882
	// (get) Token: 0x06017155 RID: 94549 RVA: 0x005DC1D6 File Offset: 0x005DA3D6
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

	// Token: 0x17001ECB RID: 7883
	// (get) Token: 0x06017156 RID: 94550 RVA: 0x005DC1F3 File Offset: 0x005DA3F3
	public int CurWaveRemainTime
	{
		get
		{
			return SurvivorsRogueConfig.Instance.GetWaveDuration(this.CurLevelId, this.CurWaveNum);
		}
	}

	// Token: 0x17001ECC RID: 7884
	// (get) Token: 0x06017157 RID: 94551 RVA: 0x005DC20B File Offset: 0x005DA40B
	public bool IsEndlessWave
	{
		get
		{
			return SurvivorsRogueConfig.Instance.GetWaveType(this.CurLevelId, this.CurWaveNum) == 2 && this.BattleData.EndlessWaveEnabled;
		}
	}

	// Token: 0x17001ECD RID: 7885
	// (get) Token: 0x06017158 RID: 94552 RVA: 0x005DC233 File Offset: 0x005DA433
	public bool IsBonusWave
	{
		get
		{
			return SurvivorsRogueConfig.Instance.IsBonusWave(this.CurLevelId, this.CurWaveNum);
		}
	}

	// Token: 0x17001ECE RID: 7886
	// (get) Token: 0x06017159 RID: 94553 RVA: 0x005DC24B File Offset: 0x005DA44B
	public int CurWaveNum
	{
		get
		{
			return this.BattleData.GetBatch();
		}
	}

	// Token: 0x0601715A RID: 94554 RVA: 0x005DC258 File Offset: 0x005DA458
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

	// Token: 0x17001ECF RID: 7887
	// (get) Token: 0x0601715B RID: 94555 RVA: 0x005DC311 File Offset: 0x005DA511
	// (set) Token: 0x0601715C RID: 94556 RVA: 0x005DC31C File Offset: 0x005DA51C
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

	// Token: 0x17001ED0 RID: 7888
	// (get) Token: 0x0601715D RID: 94557 RVA: 0x005DC37A File Offset: 0x005DA57A
	public bool NeedOpenActivityMainView
	{
		get
		{
			bool hasNewSettle = this.HasNewSettle;
			this.HasNewSettle = false;
			return hasNewSettle;
		}
	}

	// Token: 0x0601715E RID: 94558 RVA: 0x005DC389 File Offset: 0x005DA589
	public void SetCurrentActivityId(int id)
	{
		this.CurrentActivityIdInternal = id;
	}

	// Token: 0x0601715F RID: 94559 RVA: 0x005DC392 File Offset: 0x005DA592
	public bool IsActivityOn()
	{
		return this.CurrentActivityIdInternal != 0;
	}

	// Token: 0x17001ED1 RID: 7889
	// (get) Token: 0x06017160 RID: 94560 RVA: 0x005DC39D File Offset: 0x005DA59D
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

	// Token: 0x06017161 RID: 94561 RVA: 0x005DC3BE File Offset: 0x005DA5BE
	public void InitCommandQueue()
	{
		this.ClearCommandQueue();
		this.CommandQueue = new SurvivorsRogueCommandQueue();
	}

	// Token: 0x06017162 RID: 94562 RVA: 0x005DC3D1 File Offset: 0x005DA5D1
	public void ClearCommandQueue()
	{
		if (this.CommandQueue != null)
		{
			this.CommandQueue.Clear();
			this.CommandQueue = null;
		}
	}

	// Token: 0x06017163 RID: 94563 RVA: 0x005DC3F0 File Offset: 0x005DA5F0
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

	// Token: 0x06017164 RID: 94564 RVA: 0x005DC468 File Offset: 0x005DA668
	public int GetRogueCurrencyItemId()
	{
		if (this.GetRogueActivityConfig() == null)
		{
			return 0;
		}
		SurvivorsActivityConfig? survivorsActivityConfig;
		return survivorsActivityConfig.GetValueOrDefault().CurrencyItemId;
	}

	// Token: 0x06017165 RID: 94565 RVA: 0x005DC498 File Offset: 0x005DA698
	public SurvivorsActivityConfig? GetRogueActivityConfig()
	{
		if (!this.IsActivityOn())
		{
			return null;
		}
		return SurvivorsRogueConfig.Instance.GetSurvivorsActivityConfigByActivityId(this.CurrentActivityIdInternal);
	}

	// Token: 0x06017166 RID: 94566 RVA: 0x005DC4C7 File Offset: 0x005DA6C7
	public bool GetDebugMode()
	{
		return false;
	}

	// Token: 0x06017167 RID: 94567 RVA: 0x005DC4CA File Offset: 0x005DA6CA
	public void SetDebugMode(bool bOn)
	{
		this.DebugMode = bOn;
	}

	// Token: 0x06017168 RID: 94568 RVA: 0x005DC4D3 File Offset: 0x005DA6D3
	public void SaveCacheHandbookClickedMap()
	{
		if (this.HandbookClickedMap != null)
		{
			LocalStorage.SetPlayer<Dictionary<int, Dictionary<int, HashSet<int>>>>(ELocalStoragePlayerKey.SurvivorsHandbookClicked, this.HandbookClickedMap);
		}
	}

	// Token: 0x06017169 RID: 94569 RVA: 0x005DC4F0 File Offset: 0x005DA6F0
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

	// Token: 0x0601716A RID: 94570 RVA: 0x005DC55C File Offset: 0x005DA75C
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

	// Token: 0x0601716B RID: 94571 RVA: 0x005DC5D4 File Offset: 0x005DA7D4
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

	// Token: 0x0601716C RID: 94572 RVA: 0x005DC644 File Offset: 0x005DA844
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
			bool isRecommend = recommendPropertyArray != null && recommendPropertyArray.Contains(num);
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

	// Token: 0x17001ED2 RID: 7890
	// (get) Token: 0x0601716D RID: 94573 RVA: 0x005DC778 File Offset: 0x005DA978
	public static SurvivorsRogueModel Instance
	{
		get
		{
			return SurvivorsRogueModel._Instance;
		}
	}

	// Token: 0x0601716E RID: 94574 RVA: 0x005DC77F File Offset: 0x005DA97F
	public static SurvivorsRogueModel GetOrCreateInstance()
	{
		if (SurvivorsRogueModel._Instance == null)
		{
			SurvivorsRogueModel.CreateInstance();
		}
		return SurvivorsRogueModel._Instance;
	}

	// Token: 0x0601716F RID: 94575 RVA: 0x005DC793 File Offset: 0x005DA993
	public static bool CreateInstance()
	{
		if (SurvivorsRogueModel._Instance != null)
		{
			return true;
		}
		SurvivorsRogueModel._Instance = new SurvivorsRogueModel();
		return true;
	}

	// Token: 0x06017170 RID: 94576 RVA: 0x005DC7A9 File Offset: 0x005DA9A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06017171 RID: 94577 RVA: 0x005DC7AB File Offset: 0x005DA9AB
	public static void ResetStaticDefaultValue()
	{
		SurvivorsRogueModel._Instance = null;
	}

	// Token: 0x06017172 RID: 94578 RVA: 0x005DC7B3 File Offset: 0x005DA9B3
	static SurvivorsRogueModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SurvivorsRogueModel.CreateStaticDefaultValue), new Action(SurvivorsRogueModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400ACB3 RID: 44211
	public const int COMBO_LEVEL_CONFIG_LENGTH = 4;

	// Token: 0x0400ACB4 RID: 44212
	public const int PERMYRIAD_RATIO = 10000;

	// Token: 0x0400ACB5 RID: 44213
	private int CurLevelIdInternal;

	// Token: 0x0400ACB6 RID: 44214
	public SurvivorsCombo? CurComboConfig;

	// Token: 0x0400ACB7 RID: 44215
	public int MaxWaveNum;

	// Token: 0x0400ACB8 RID: 44216
	public int[] WaveTypeArray = Array.Empty<int>();

	// Token: 0x0400ACB9 RID: 44217
	public readonly int[] ComboTimerFreezeTimeCfg = new int[4];

	// Token: 0x0400ACBA RID: 44218
	public readonly int[] ComboDurationAdditionCfg = new int[4];

	// Token: 0x0400ACBB RID: 44219
	private SurvivorsRogueModel.EWaveTipsState WaveTipsStateInternal;

	// Token: 0x0400ACBC RID: 44220
	public bool HasNewSettle;

	// Token: 0x0400ACBD RID: 44221
	private int CurrentActivityIdInternal;

	// Token: 0x0400ACBE RID: 44222
	[Nullable(2)]
	public SurvivorsActivityDefine.SurvivorsLevelInfo SelectLevelInfo;

	// Token: 0x0400ACBF RID: 44223
	public bool NotTipsShopPurchaseAvailable;

	// Token: 0x0400ACC0 RID: 44224
	public SurvivorsRogueBattleData BattleData = SurvivorsRogueBattleData.Create();

	// Token: 0x0400ACC1 RID: 44225
	public SurvivorsRogueGainData GainData = SurvivorsRogueGainData.Create();

	// Token: 0x0400ACC2 RID: 44226
	[Nullable(2)]
	public SurvivorsRogueCommandQueue CommandQueue;

	// Token: 0x0400ACC3 RID: 44227
	private bool DebugMode;

	// Token: 0x0400ACC4 RID: 44228
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<int, Dictionary<int, HashSet<int>>> HandbookClickedMap;

	// Token: 0x0400ACC5 RID: 44229
	[Nullable(2)]
	private static SurvivorsRogueModel _Instance;

	// Token: 0x02009161 RID: 37217
	[NullableContext(0)]
	public enum EWaveTipsState
	{
		// Token: 0x0402F0ED RID: 192749
		Default,
		// Token: 0x0402F0EE RID: 192750
		PopWaveTips,
		// Token: 0x0402F0EF RID: 192751
		ResidentWaveTips,
		// Token: 0x0402F0F0 RID: 192752
		WaveCompleteTips
	}
}
