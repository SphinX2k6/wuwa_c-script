using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053E3 RID: 21475
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuData
	{
		// Token: 0x06036EA3 RID: 224931 RVA: 0x00D04048 File Offset: 0x00D02248
		public MenuData(MenuConfig metaConfig)
		{
			this.MetaConfig = metaConfig;
		}

		// Token: 0x170083CE RID: 33742
		// (get) Token: 0x06036EA4 RID: 224932 RVA: 0x00D04062 File Offset: 0x00D02262
		public int ConfigId
		{
			get
			{
				return this.MetaConfig.Id;
			}
		}

		// Token: 0x170083CF RID: 33743
		// (get) Token: 0x06036EA5 RID: 224933 RVA: 0x00D0406F File Offset: 0x00D0226F
		public int SubType
		{
			get
			{
				return this.MetaConfig.SubType;
			}
		}

		// Token: 0x170083D0 RID: 33744
		// (get) Token: 0x06036EA6 RID: 224934 RVA: 0x00D0407C File Offset: 0x00D0227C
		public string SubName
		{
			get
			{
				return this.MetaConfig.SubName;
			}
		}

		// Token: 0x170083D1 RID: 33745
		// (get) Token: 0x06036EA7 RID: 224935 RVA: 0x00D04089 File Offset: 0x00D02289
		public virtual string FunctionName
		{
			get
			{
				return this.MetaConfig.Name;
			}
		}

		// Token: 0x170083D2 RID: 33746
		// (get) Token: 0x06036EA8 RID: 224936 RVA: 0x00D04096 File Offset: 0x00D02296
		public int FunctionSort
		{
			get
			{
				return this.MetaConfig.FunctionSort;
			}
		}

		// Token: 0x170083D3 RID: 33747
		// (get) Token: 0x06036EA9 RID: 224937 RVA: 0x00D040A3 File Offset: 0x00D022A3
		public int SubSort
		{
			get
			{
				return this.MetaConfig.SubSort;
			}
		}

		// Token: 0x170083D4 RID: 33748
		// (get) Token: 0x06036EAA RID: 224938 RVA: 0x00D040B0 File Offset: 0x00D022B0
		public EFunction FunctionId
		{
			get
			{
				return (EFunction)this.MetaConfig.FunctionId;
			}
		}

		// Token: 0x170083D5 RID: 33749
		// (get) Token: 0x06036EAB RID: 224939 RVA: 0x00D040BD File Offset: 0x00D022BD
		public bool NeedScale
		{
			get
			{
				return this.MetaConfig.NeedScale;
			}
		}

		// Token: 0x170083D6 RID: 33750
		// (get) Token: 0x06036EAC RID: 224940 RVA: 0x00D040CA File Offset: 0x00D022CA
		public ESetType SetType
		{
			get
			{
				return (ESetType)this.MetaConfig.SetType;
			}
		}

		// Token: 0x170083D7 RID: 33751
		// (get) Token: 0x06036EAD RID: 224941 RVA: 0x00D040D7 File Offset: 0x00D022D7
		public float[] SliderRange
		{
			get
			{
				return this.MetaConfig.SliderRange();
			}
		}

		// Token: 0x170083D8 RID: 33752
		// (get) Token: 0x06036EAE RID: 224942 RVA: 0x00D040E4 File Offset: 0x00D022E4
		public float[] SliderRangeDisplay
		{
			get
			{
				if (this.MetaConfig.SliderRangeDisplayLength > 0)
				{
					return this.MetaConfig.SliderRangeDisplay();
				}
				return this.MetaConfig.SliderRange();
			}
		}

		// Token: 0x170083D9 RID: 33753
		// (get) Token: 0x06036EAF RID: 224943 RVA: 0x00D0410B File Offset: 0x00D0230B
		public float SliderDefault
		{
			get
			{
				return this.MetaConfig.SliderDefault;
			}
		}

		// Token: 0x170083DA RID: 33754
		// (get) Token: 0x06036EB0 RID: 224944 RVA: 0x00D04118 File Offset: 0x00D02318
		public int SliderDigits
		{
			get
			{
				return this.MetaConfig.Digits;
			}
		}

		// Token: 0x170083DB RID: 33755
		// (get) Token: 0x06036EB1 RID: 224945 RVA: 0x00D04125 File Offset: 0x00D02325
		public int OptionsDefault
		{
			get
			{
				return this.MetaConfig.OptionsDefault;
			}
		}

		// Token: 0x170083DC RID: 33756
		// (get) Token: 0x06036EB2 RID: 224946 RVA: 0x00D04132 File Offset: 0x00D02332
		public bool BtnDisableTipsEnable
		{
			get
			{
				return this.MetaConfig.BtnDisableTipsEnable;
			}
		}

		// Token: 0x170083DD RID: 33757
		// (get) Token: 0x06036EB3 RID: 224947 RVA: 0x00D0413F File Offset: 0x00D0233F
		public bool CanShowInLogin
		{
			get
			{
				return this.MetaConfig.CanShowInLogin;
			}
		}

		// Token: 0x170083DE RID: 33758
		// (get) Token: 0x06036EB4 RID: 224948 RVA: 0x00D0414C File Offset: 0x00D0234C
		protected string[] OptionsNameListInternal
		{
			get
			{
				return this.FilterImageQualityOptions<string>(this.MetaConfig.OptionsName());
			}
		}

		// Token: 0x170083DF RID: 33759
		// (get) Token: 0x06036EB5 RID: 224949 RVA: 0x00D0415F File Offset: 0x00D0235F
		protected int[] OptionsValueListInternal
		{
			get
			{
				return this.FilterImageQualityOptions<int>(this.MetaConfig.OptionsValue());
			}
		}

		// Token: 0x06036EB6 RID: 224950 RVA: 0x00D04174 File Offset: 0x00D02374
		private T[] FilterImageQualityOptions<[Nullable(2)] T>(T[] list)
		{
			int? num;
			if (this.FunctionId == EFunction.IMAGEQUALITY)
			{
				EGameQualitySettingLevel? maxQualityLevelByResourceTier = GameSettingsManager.Instance.GetMaxQualityLevelByResourceTier();
				num = ((maxQualityLevelByResourceTier == null) ? null : new int?((int)maxQualityLevelByResourceTier.Value));
			}
			else
			{
				if (this.FunctionId != EFunction.IMAGEDETAIL)
				{
					return list;
				}
				num = GameSettingsManager.Instance.GetMaxImageDetailByResourceTier();
			}
			if (num == null)
			{
				return list;
			}
			int[] array = this.MetaConfig.OptionsValue();
			List<T> list2 = new List<T>(list.Length);
			for (int i = 0; i < list.Length; i++)
			{
				if (i < array.Length && array[i] <= num.Value)
				{
					list2.Add(list[i]);
				}
			}
			return list2.ToArray();
		}

		// Token: 0x170083E0 RID: 33760
		// (get) Token: 0x06036EB7 RID: 224951 RVA: 0x00D0422D File Offset: 0x00D0242D
		public string SubImage
		{
			get
			{
				return this.MetaConfig.SubImage;
			}
		}

		// Token: 0x170083E1 RID: 33761
		// (get) Token: 0x06036EB8 RID: 224952 RVA: 0x00D0423A File Offset: 0x00D0243A
		public string FunctionImage
		{
			get
			{
				return this.MetaConfig.FunctionImage;
			}
		}

		// Token: 0x170083E2 RID: 33762
		// (get) Token: 0x06036EB9 RID: 224953 RVA: 0x00D04247 File Offset: 0x00D02447
		public virtual string ButtonTextId
		{
			get
			{
				return this.MetaConfig.ButtonText;
			}
		}

		// Token: 0x170083E3 RID: 33763
		// (get) Token: 0x06036EBA RID: 224954 RVA: 0x00D04254 File Offset: 0x00D02454
		public string ButtonViewName
		{
			get
			{
				return this.MetaConfig.OpenView;
			}
		}

		// Token: 0x170083E4 RID: 33764
		// (get) Token: 0x06036EBB RID: 224955 RVA: 0x00D04261 File Offset: 0x00D02461
		public int[] RelationFuncIds
		{
			get
			{
				return this.MetaConfig.RelationFunction();
			}
		}

		// Token: 0x170083E5 RID: 33765
		// (get) Token: 0x06036EBC RID: 224956 RVA: 0x00D0426E File Offset: 0x00D0246E
		public int[] AffectedValue
		{
			get
			{
				return this.MetaConfig.AffectedValue();
			}
		}

		// Token: 0x170083E6 RID: 33766
		// (get) Token: 0x06036EBD RID: 224957 RVA: 0x00D0427B File Offset: 0x00D0247B
		public Dictionary<int, int> AffectedFunction
		{
			get
			{
				return this.MetaConfig.AffectedFunction();
			}
		}

		// Token: 0x170083E7 RID: 33767
		// (get) Token: 0x06036EBE RID: 224958 RVA: 0x00D04288 File Offset: 0x00D02488
		public int[] DisableValue
		{
			get
			{
				return this.MetaConfig.DisableValue();
			}
		}

		// Token: 0x170083E8 RID: 33768
		// (get) Token: 0x06036EBF RID: 224959 RVA: 0x00D04295 File Offset: 0x00D02495
		public int[] DisableFunction
		{
			get
			{
				return this.MetaConfig.DisableFunction();
			}
		}

		// Token: 0x170083E9 RID: 33769
		// (get) Token: 0x06036EC0 RID: 224960 RVA: 0x00D042A2 File Offset: 0x00D024A2
		public string BtnDisableTips
		{
			get
			{
				return this.MetaConfig.BtnDisableTips;
			}
		}

		// Token: 0x170083EA RID: 33770
		// (get) Token: 0x06036EC1 RID: 224961 RVA: 0x00D042AF File Offset: 0x00D024AF
		public Dictionary<int, string> ValueTipsMap
		{
			get
			{
				return this.MetaConfig.ValueTipsMap();
			}
		}

		// Token: 0x170083EB RID: 33771
		// (get) Token: 0x06036EC2 RID: 224962 RVA: 0x00D042BC File Offset: 0x00D024BC
		public Dictionary<int, int> ClickedTipsMap
		{
			get
			{
				return this.MetaConfig.ClickedTipsMap();
			}
		}

		// Token: 0x170083EC RID: 33772
		// (get) Token: 0x06036EC3 RID: 224963 RVA: 0x00D042C9 File Offset: 0x00D024C9
		public bool IsDataCache
		{
			get
			{
				return this.MetaConfig.IsDataCache;
			}
		}

		// Token: 0x170083ED RID: 33773
		// (get) Token: 0x06036EC4 RID: 224964 RVA: 0x00D042D6 File Offset: 0x00D024D6
		public string ClickedTips
		{
			get
			{
				return this.MetaConfig.ClickedTips;
			}
		}

		// Token: 0x170083EE RID: 33774
		// (get) Token: 0x06036EC5 RID: 224965 RVA: 0x00D042E3 File Offset: 0x00D024E3
		private string DetailTextId
		{
			get
			{
				return this.MetaConfig.DetailText;
			}
		}

		// Token: 0x170083EF RID: 33775
		// (get) Token: 0x06036EC6 RID: 224966 RVA: 0x00D042F0 File Offset: 0x00D024F0
		public bool CanClickWhenDisable
		{
			get
			{
				return this.MetaConfig.CanDisableDetailShow;
			}
		}

		// Token: 0x170083F0 RID: 33776
		// (get) Token: 0x06036EC7 RID: 224967 RVA: 0x00D042FD File Offset: 0x00D024FD
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual string[] CustomTitleArgs
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return null;
			}
		}

		// Token: 0x06036EC8 RID: 224968 RVA: 0x00D04300 File Offset: 0x00D02500
		public bool GetEnable()
		{
			if (this.FunctionId == EFunction.MobileGamepadMode)
			{
				MenuModel instance = MenuModel.Instance;
				return instance != null && instance.GetDataCacheOrCurValue(EFunction.MobileGamepadMode).GetValueOrDefault() == 1;
			}
			if (this.FunctionId == EFunction.Filter)
			{
				MenuModel instance2 = MenuModel.Instance;
				return instance2 != null && instance2.GetDataCacheOrCurValue(EFunction.ImageDisplayMode).GetValueOrDefault() == 1;
			}
			if (this.FunctionId == EFunction.EyeProtection)
			{
				MenuModel instance3 = MenuModel.Instance;
				return instance3 != null && instance3.GetDataCacheOrCurValue(EFunction.ImageDisplayMode).GetValueOrDefault() == 2;
			}
			if (this.FunctionId == EFunction.HDR)
			{
				return UKuroGISystem.CheckWindowsSupportHDR();
			}
			if (this.CheckIsDisableFunctionInInstance())
			{
				return false;
			}
			foreach (KeyValuePair<EFunction, int[]> keyValuePair in this.OtherFunctionTargetDisableValueCache)
			{
				EFunction key = keyValuePair.Key;
				int[] value = keyValuePair.Value;
				MenuModel instance4 = MenuModel.Instance;
				float? num = (instance4 != null) ? instance4.GetDataCacheOrCurValueFloat(key) : null;
				if (num != null && MenuData.ContainsConfiguredValue(value, num.Value))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06036EC9 RID: 224969 RVA: 0x00D04444 File Offset: 0x00D02644
		private bool CheckIsDisableFunctionInInstance()
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			if (instanceId == 0)
			{
				return false;
			}
			InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
			InstanceDungeon? instanceDungeon = (instance != null) ? instance.GetConfig(instanceId) : null;
			if (instanceDungeon == null)
			{
				return false;
			}
			EFunction[] array = null;
			if (instanceDungeon.Value.InstSubType != 12)
			{
				MenuDefineInstSettings.disableSettingsInstMap.TryGetValue((EDungeonSubType)instanceDungeon.Value.InstSubType, out array);
			}
			else
			{
				MenuDefineInstSettings.disableSettingsWorldInstMap.TryGetValue((EWorldDungeonSubType)instanceDungeon.Value.WorldDungeonSubType, out array);
			}
			return array != null && Array.IndexOf<EFunction>(array, this.FunctionId) >= 0;
		}

		// Token: 0x170083F1 RID: 33777
		// (get) Token: 0x06036ECA RID: 224970 RVA: 0x00D044F0 File Offset: 0x00D026F0
		public virtual bool EnableRedDot
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06036ECB RID: 224971 RVA: 0x00D044F3 File Offset: 0x00D026F3
		public virtual void OnRefresh()
		{
		}

		// Token: 0x06036ECC RID: 224972 RVA: 0x00D044F5 File Offset: 0x00D026F5
		public virtual bool GetButtonEnable()
		{
			return true;
		}

		// Token: 0x06036ECD RID: 224973 RVA: 0x00D044F8 File Offset: 0x00D026F8
		public void CacheDisableState(EFunction targetFunction, int[] targetValues)
		{
			this.OtherFunctionTargetDisableValueCache[targetFunction] = targetValues;
		}

		// Token: 0x06036ECE RID: 224974 RVA: 0x00D04507 File Offset: 0x00D02707
		public void ResetDisableStateCache()
		{
			this.OtherFunctionTargetDisableValueCache.Clear();
		}

		// Token: 0x06036ECF RID: 224975 RVA: 0x00D04514 File Offset: 0x00D02714
		[NullableContext(2)]
		private string GetDisableOverrideTextForTarget(int targetFunctionId)
		{
			for (int i = 0; i < this.MetaConfig.DisableOverrideTextLength; i++)
			{
				DicIntString? dicIntString = this.MetaConfig.DisableOverrideText(i);
				if (dicIntString != null && dicIntString.Value.Key == targetFunctionId)
				{
					return dicIntString.Value.Value;
				}
			}
			return null;
		}

		// Token: 0x06036ED0 RID: 224976 RVA: 0x00D04570 File Offset: 0x00D02770
		[NullableContext(2)]
		public string GetDisableOverrideText()
		{
			if (this.GetEnable())
			{
				return null;
			}
			foreach (KeyValuePair<EFunction, int[]> keyValuePair in this.OtherFunctionTargetDisableValueCache)
			{
				EFunction key = keyValuePair.Key;
				int[] value = keyValuePair.Value;
				MenuModel instance = MenuModel.Instance;
				float? num = (instance != null) ? instance.GetDataCacheOrCurValueFloat(key) : null;
				if (num != null && MenuData.ContainsConfiguredValue(value, num.Value))
				{
					MenuModel instance2 = MenuModel.Instance;
					MenuData menuData = (instance2 != null) ? instance2.GetMenuDataByFunctionId((int)key) : null;
					if (menuData != null)
					{
						string disableOverrideTextForTarget = menuData.GetDisableOverrideTextForTarget((int)this.FunctionId);
						if (disableOverrideTextForTarget != null)
						{
							return disableOverrideTextForTarget;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06036ED1 RID: 224977 RVA: 0x00D04644 File Offset: 0x00D02844
		public bool CanAffectedFunction(float value)
		{
			return MenuData.ContainsConfiguredValue(this.AffectedValue, value) && this.AffectedFunction.Count > 0;
		}

		// Token: 0x06036ED2 RID: 224978 RVA: 0x00D04664 File Offset: 0x00D02864
		private static bool ContainsConfiguredValue(int[] configuredValues, float value)
		{
			for (int i = 0; i < configuredValues.Length; i++)
			{
				if ((float)configuredValues[i] == value)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036ED3 RID: 224979 RVA: 0x00D0468B File Offset: 0x00D0288B
		public bool HasDisableFunction()
		{
			return this.DisableFunction.Length != 0;
		}

		// Token: 0x170083F2 RID: 33778
		// (get) Token: 0x06036ED4 RID: 224980 RVA: 0x00D04697 File Offset: 0x00D02897
		public IReadOnlyList<string> OptionsNameList
		{
			get
			{
				return this.OptionsNameListInternal;
			}
		}

		// Token: 0x170083F3 RID: 33779
		// (get) Token: 0x06036ED5 RID: 224981 RVA: 0x00D0469F File Offset: 0x00D0289F
		public IReadOnlyList<int> OptionsValueList
		{
			get
			{
				return this.OptionsValueListInternal;
			}
		}

		// Token: 0x06036ED6 RID: 224982 RVA: 0x00D046A8 File Offset: 0x00D028A8
		public bool HasDetailText()
		{
			string detailTextId = this.DetailTextId;
			return !string.IsNullOrEmpty(detailTextId) && !StringUtils.IsBlank(detailTextId);
		}

		// Token: 0x06036ED7 RID: 224983 RVA: 0x00D046D1 File Offset: 0x00D028D1
		public int GetDetailPopId()
		{
			return this.MetaConfig.DetailPop;
		}

		// Token: 0x06036ED8 RID: 224984 RVA: 0x00D046DE File Offset: 0x00D028DE
		public bool ShowHelpBtn()
		{
			return this.MetaConfig.DetailPop > 0 || this.HasDetailText();
		}

		// Token: 0x06036ED9 RID: 224985 RVA: 0x00D046F6 File Offset: 0x00D028F6
		[NullableContext(2)]
		public string GetDetailTextId()
		{
			return this.DetailTextId;
		}

		// Token: 0x06036EDA RID: 224986 RVA: 0x00D046FE File Offset: 0x00D028FE
		public void SetDetailTextVisible(bool bVisible)
		{
			this.IsDetailTextVisible = bVisible;
		}

		// Token: 0x06036EDB RID: 224987 RVA: 0x00D04707 File Offset: 0x00D02907
		public bool GetIsDetailTextVisible()
		{
			return this.IsDetailTextVisible;
		}

		// Token: 0x06036EDC RID: 224988 RVA: 0x00D04710 File Offset: 0x00D02910
		public bool IsRecommendIndex(int index)
		{
			if (this.FunctionId != EFunction.IMAGEQUALITY)
			{
				return false;
			}
			if (MenuModel.Instance.IsImageQualityCustom)
			{
				return false;
			}
			EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			return recommendQualityLv != null && Array.IndexOf<int>(this.OptionsValueListInternal, (int)recommendQualityLv.Value) == index;
		}

		// Token: 0x06036EDD RID: 224989 RVA: 0x00D04764 File Offset: 0x00D02964
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<string, string> GetDetailSpritePath()
		{
			string text = (this.GetDetailPopId() > 0) ? "SP_BtnMenuDetailPop" : "SP_BtnMenuDetailText";
			string text2;
			if (!this.CanClickWhenDisable)
			{
				text2 = "SP_BtnMenuDetailLock";
			}
			else
			{
				text2 = text;
			}
			string text3;
			if (text == null)
			{
				text3 = null;
			}
			else
			{
				UiResourceConfig instance = UiResourceConfig.Instance;
				text3 = ((instance != null) ? instance.GetResourcePath(text) : null);
			}
			string text4;
			if (text2 == null)
			{
				text4 = null;
			}
			else
			{
				UiResourceConfig instance2 = UiResourceConfig.Instance;
				text4 = ((instance2 != null) ? instance2.GetResourcePath(text2) : null);
			}
			string text5 = text4;
			return new ValueTuple<string, string>(text3 ?? "", text5 ?? "");
		}

		// Token: 0x0401CF73 RID: 118643
		private MenuConfig MetaConfig;

		// Token: 0x0401CF74 RID: 118644
		private bool IsDetailTextVisible;

		// Token: 0x0401CF75 RID: 118645
		private readonly Dictionary<EFunction, int[]> OtherFunctionTargetDisableValueCache = new Dictionary<EFunction, int[]>();
	}
}
