using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043C6 RID: 17350
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuData
	{
		// Token: 0x0602BDEA RID: 179690 RVA: 0x00C531BC File Offset: 0x00C513BC
		public MenuData(MenuConfig metaConfig)
		{
			this.MetaConfig = metaConfig;
		}

		// Token: 0x0602BDEB RID: 179691 RVA: 0x00C531D8 File Offset: 0x00C513D8
		[return: TupleElementNames(new string[]
		{
			"DeviceId",
			"Names",
			"Values"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		private ValueTuple<int, string[], int[]>? GetTestImageQualityOptions()
		{
			if (this.FunctionId != EFunction.IMAGEQUALITY || !GameSettingsManager.Instance.IsImageQualityUnlockedForTesting())
			{
				return null;
			}
			EGameDeviceType? imageQualityTestDeviceId = GameSettingsDeviceRender.Instance.GetImageQualityTestDeviceId();
			if (imageQualityTestDeviceId == null)
			{
				return null;
			}
			int? num = (this.TestImageQualityOptions != null) ? new int?(this.TestImageQualityOptions.GetValueOrDefault().Item1) : null;
			int value = (int)imageQualityTestDeviceId.Value;
			if (!(num.GetValueOrDefault() == value & num != null))
			{
				IReadOnlyList<DeviceRenderFeature> deviceRenderFeatureConfigListByDeviceId = GameSettingsConfig.Instance.GetDeviceRenderFeatureConfigListByDeviceId((int)imageQualityTestDeviceId.Value);
				if (deviceRenderFeatureConfigListByDeviceId == null || deviceRenderFeatureConfigListByDeviceId.Count == 0)
				{
					return null;
				}
				HashSet<int> hashSet = new HashSet<int>();
				foreach (DeviceRenderFeature deviceRenderFeature in deviceRenderFeatureConfigListByDeviceId)
				{
					hashSet.Add(deviceRenderFeature.QualityType);
				}
				IReadOnlyList<MenuConfig> menuConfigListByFunctionId = MenuBaseConfig.Instance.GetMenuConfigListByFunctionId(10);
				if (menuConfigListByFunctionId == null)
				{
					return null;
				}
				SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
				foreach (MenuConfig menuConfig in menuConfigListByFunctionId)
				{
					string[] array = menuConfig.OptionsName();
					int[] array2 = menuConfig.OptionsValue();
					for (int i = 0; i < array2.Length; i++)
					{
						if (hashSet.Contains(array2[i]) && i < array.Length)
						{
							sortedDictionary[array2[i]] = array[i];
						}
					}
				}
				if (sortedDictionary.Count == 0)
				{
					return null;
				}
				string[] array3 = new string[sortedDictionary.Count];
				int[] array4 = new int[sortedDictionary.Count];
				int num2 = 0;
				foreach (KeyValuePair<int, string> keyValuePair in sortedDictionary)
				{
					array4[num2] = keyValuePair.Key;
					array3[num2] = keyValuePair.Value;
					num2++;
				}
				this.TestImageQualityOptions = new ValueTuple<int, string[], int[]>?(new ValueTuple<int, string[], int[]>((int)imageQualityTestDeviceId.Value, array3, array4));
			}
			return this.TestImageQualityOptions;
		}

		// Token: 0x1700579A RID: 22426
		// (get) Token: 0x0602BDEC RID: 179692 RVA: 0x00C53438 File Offset: 0x00C51638
		public int ConfigId
		{
			get
			{
				return this.MetaConfig.Id;
			}
		}

		// Token: 0x1700579B RID: 22427
		// (get) Token: 0x0602BDED RID: 179693 RVA: 0x00C53445 File Offset: 0x00C51645
		public int SubType
		{
			get
			{
				return this.MetaConfig.SubType;
			}
		}

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x0602BDEE RID: 179694 RVA: 0x00C53452 File Offset: 0x00C51652
		public string SubName
		{
			get
			{
				return this.MetaConfig.SubName;
			}
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x0602BDEF RID: 179695 RVA: 0x00C5345F File Offset: 0x00C5165F
		public virtual string FunctionName
		{
			get
			{
				return this.MetaConfig.Name;
			}
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x0602BDF0 RID: 179696 RVA: 0x00C5346C File Offset: 0x00C5166C
		public int FunctionSort
		{
			get
			{
				return this.MetaConfig.FunctionSort;
			}
		}

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x0602BDF1 RID: 179697 RVA: 0x00C53479 File Offset: 0x00C51679
		public int SubSort
		{
			get
			{
				return this.MetaConfig.SubSort;
			}
		}

		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x0602BDF2 RID: 179698 RVA: 0x00C53486 File Offset: 0x00C51686
		public EFunction FunctionId
		{
			get
			{
				return (EFunction)this.MetaConfig.FunctionId;
			}
		}

		// Token: 0x170057A1 RID: 22433
		// (get) Token: 0x0602BDF3 RID: 179699 RVA: 0x00C53493 File Offset: 0x00C51693
		public bool NeedScale
		{
			get
			{
				return this.MetaConfig.NeedScale;
			}
		}

		// Token: 0x170057A2 RID: 22434
		// (get) Token: 0x0602BDF4 RID: 179700 RVA: 0x00C534A0 File Offset: 0x00C516A0
		public ESetType SetType
		{
			get
			{
				return (ESetType)this.MetaConfig.SetType;
			}
		}

		// Token: 0x170057A3 RID: 22435
		// (get) Token: 0x0602BDF5 RID: 179701 RVA: 0x00C534AD File Offset: 0x00C516AD
		public float[] SliderRange
		{
			get
			{
				return this.MetaConfig.SliderRange();
			}
		}

		// Token: 0x170057A4 RID: 22436
		// (get) Token: 0x0602BDF6 RID: 179702 RVA: 0x00C534BA File Offset: 0x00C516BA
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

		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x0602BDF7 RID: 179703 RVA: 0x00C534E1 File Offset: 0x00C516E1
		public float SliderDefault
		{
			get
			{
				return this.MetaConfig.SliderDefault;
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x0602BDF8 RID: 179704 RVA: 0x00C534EE File Offset: 0x00C516EE
		public int SliderDigits
		{
			get
			{
				return this.MetaConfig.Digits;
			}
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x0602BDF9 RID: 179705 RVA: 0x00C534FB File Offset: 0x00C516FB
		public int OptionsDefault
		{
			get
			{
				return this.MetaConfig.OptionsDefault;
			}
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x0602BDFA RID: 179706 RVA: 0x00C53508 File Offset: 0x00C51708
		public bool BtnDisableTipsEnable
		{
			get
			{
				return this.MetaConfig.BtnDisableTipsEnable;
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x0602BDFB RID: 179707 RVA: 0x00C53515 File Offset: 0x00C51715
		public bool CanShowInLogin
		{
			get
			{
				return this.MetaConfig.CanShowInLogin;
			}
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x0602BDFC RID: 179708 RVA: 0x00C53524 File Offset: 0x00C51724
		protected string[] OptionsNameListInternal
		{
			get
			{
				ValueTuple<int, string[], int[]>? valueTuple;
				return ((this.GetTestImageQualityOptions() != null) ? valueTuple.GetValueOrDefault().Item2 : null) ?? this.FilterImageQualityOptions<string>(this.MetaConfig.OptionsName());
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x0602BDFD RID: 179709 RVA: 0x00C53568 File Offset: 0x00C51768
		protected int[] OptionsValueListInternal
		{
			get
			{
				ValueTuple<int, string[], int[]>? valueTuple;
				return ((this.GetTestImageQualityOptions() != null) ? valueTuple.GetValueOrDefault().Item3 : null) ?? this.FilterImageQualityOptions<int>(this.MetaConfig.OptionsValue());
			}
		}

		// Token: 0x0602BDFE RID: 179710 RVA: 0x00C535AC File Offset: 0x00C517AC
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

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x0602BDFF RID: 179711 RVA: 0x00C53665 File Offset: 0x00C51865
		public string SubImage
		{
			get
			{
				return this.MetaConfig.SubImage;
			}
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x0602BE00 RID: 179712 RVA: 0x00C53672 File Offset: 0x00C51872
		public string FunctionImage
		{
			get
			{
				return this.MetaConfig.FunctionImage;
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x0602BE01 RID: 179713 RVA: 0x00C5367F File Offset: 0x00C5187F
		public virtual string ButtonTextId
		{
			get
			{
				return this.MetaConfig.ButtonText;
			}
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x0602BE02 RID: 179714 RVA: 0x00C5368C File Offset: 0x00C5188C
		public string ButtonViewName
		{
			get
			{
				return this.MetaConfig.OpenView;
			}
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x0602BE03 RID: 179715 RVA: 0x00C53699 File Offset: 0x00C51899
		public int[] RelationFuncIds
		{
			get
			{
				return this.MetaConfig.RelationFunction();
			}
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x0602BE04 RID: 179716 RVA: 0x00C536A6 File Offset: 0x00C518A6
		public int[] AffectedValue
		{
			get
			{
				return this.MetaConfig.AffectedValue();
			}
		}

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x0602BE05 RID: 179717 RVA: 0x00C536B3 File Offset: 0x00C518B3
		public Dictionary<int, int> AffectedFunction
		{
			get
			{
				return this.MetaConfig.AffectedFunction();
			}
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x0602BE06 RID: 179718 RVA: 0x00C536C0 File Offset: 0x00C518C0
		public int[] DisableValue
		{
			get
			{
				return this.MetaConfig.DisableValue();
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x0602BE07 RID: 179719 RVA: 0x00C536CD File Offset: 0x00C518CD
		public int[] DisableFunction
		{
			get
			{
				return this.MetaConfig.DisableFunction();
			}
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x0602BE08 RID: 179720 RVA: 0x00C536DA File Offset: 0x00C518DA
		public string BtnDisableTips
		{
			get
			{
				return this.MetaConfig.BtnDisableTips;
			}
		}

		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x0602BE09 RID: 179721 RVA: 0x00C536E7 File Offset: 0x00C518E7
		public Dictionary<int, string> ValueTipsMap
		{
			get
			{
				return this.MetaConfig.ValueTipsMap();
			}
		}

		// Token: 0x170057B7 RID: 22455
		// (get) Token: 0x0602BE0A RID: 179722 RVA: 0x00C536F4 File Offset: 0x00C518F4
		public Dictionary<int, int> ClickedTipsMap
		{
			get
			{
				return this.MetaConfig.ClickedTipsMap();
			}
		}

		// Token: 0x170057B8 RID: 22456
		// (get) Token: 0x0602BE0B RID: 179723 RVA: 0x00C53701 File Offset: 0x00C51901
		public bool IsDataCache
		{
			get
			{
				return this.MetaConfig.IsDataCache;
			}
		}

		// Token: 0x170057B9 RID: 22457
		// (get) Token: 0x0602BE0C RID: 179724 RVA: 0x00C5370E File Offset: 0x00C5190E
		public string ClickedTips
		{
			get
			{
				return this.MetaConfig.ClickedTips;
			}
		}

		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x0602BE0D RID: 179725 RVA: 0x00C5371B File Offset: 0x00C5191B
		private string DetailTextId
		{
			get
			{
				return this.MetaConfig.DetailText;
			}
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x0602BE0E RID: 179726 RVA: 0x00C53728 File Offset: 0x00C51928
		public bool CanClickWhenDisable
		{
			get
			{
				return this.MetaConfig.CanDisableDetailShow;
			}
		}

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x0602BE0F RID: 179727 RVA: 0x00C53735 File Offset: 0x00C51935
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

		// Token: 0x0602BE10 RID: 179728 RVA: 0x00C53738 File Offset: 0x00C51938
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

		// Token: 0x0602BE11 RID: 179729 RVA: 0x00C5387C File Offset: 0x00C51A7C
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

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x0602BE12 RID: 179730 RVA: 0x00C53928 File Offset: 0x00C51B28
		public virtual bool EnableRedDot
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0602BE13 RID: 179731 RVA: 0x00C5392B File Offset: 0x00C51B2B
		public virtual void OnRefresh()
		{
		}

		// Token: 0x0602BE14 RID: 179732 RVA: 0x00C5392D File Offset: 0x00C51B2D
		public virtual bool GetButtonEnable()
		{
			return true;
		}

		// Token: 0x0602BE15 RID: 179733 RVA: 0x00C53930 File Offset: 0x00C51B30
		public void CacheDisableState(EFunction targetFunction, int[] targetValues)
		{
			this.OtherFunctionTargetDisableValueCache[targetFunction] = targetValues;
		}

		// Token: 0x0602BE16 RID: 179734 RVA: 0x00C5393F File Offset: 0x00C51B3F
		public void ResetDisableStateCache()
		{
			this.OtherFunctionTargetDisableValueCache.Clear();
		}

		// Token: 0x0602BE17 RID: 179735 RVA: 0x00C5394C File Offset: 0x00C51B4C
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

		// Token: 0x0602BE18 RID: 179736 RVA: 0x00C539A8 File Offset: 0x00C51BA8
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

		// Token: 0x0602BE19 RID: 179737 RVA: 0x00C53A7C File Offset: 0x00C51C7C
		public bool CanAffectedFunction(float value)
		{
			return MenuData.ContainsConfiguredValue(this.AffectedValue, value) && this.AffectedFunction.Count > 0;
		}

		// Token: 0x0602BE1A RID: 179738 RVA: 0x00C53A9C File Offset: 0x00C51C9C
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

		// Token: 0x0602BE1B RID: 179739 RVA: 0x00C53AC3 File Offset: 0x00C51CC3
		public bool HasDisableFunction()
		{
			return this.DisableFunction.Length != 0;
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x0602BE1C RID: 179740 RVA: 0x00C53ACF File Offset: 0x00C51CCF
		public IReadOnlyList<string> OptionsNameList
		{
			get
			{
				return this.OptionsNameListInternal;
			}
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x0602BE1D RID: 179741 RVA: 0x00C53AD7 File Offset: 0x00C51CD7
		public IReadOnlyList<int> OptionsValueList
		{
			get
			{
				return this.OptionsValueListInternal;
			}
		}

		// Token: 0x0602BE1E RID: 179742 RVA: 0x00C53AE0 File Offset: 0x00C51CE0
		public bool HasDetailText()
		{
			string detailTextId = this.DetailTextId;
			return !string.IsNullOrEmpty(detailTextId) && !StringUtils.IsBlank(detailTextId);
		}

		// Token: 0x0602BE1F RID: 179743 RVA: 0x00C53B09 File Offset: 0x00C51D09
		public int GetDetailPopId()
		{
			return this.MetaConfig.DetailPop;
		}

		// Token: 0x0602BE20 RID: 179744 RVA: 0x00C53B16 File Offset: 0x00C51D16
		public bool ShowHelpBtn()
		{
			return this.MetaConfig.DetailPop > 0 || this.HasDetailText();
		}

		// Token: 0x0602BE21 RID: 179745 RVA: 0x00C53B2E File Offset: 0x00C51D2E
		[NullableContext(2)]
		public string GetDetailTextId()
		{
			return this.DetailTextId;
		}

		// Token: 0x0602BE22 RID: 179746 RVA: 0x00C53B36 File Offset: 0x00C51D36
		public void SetDetailTextVisible(bool bVisible)
		{
			this.IsDetailTextVisible = bVisible;
		}

		// Token: 0x0602BE23 RID: 179747 RVA: 0x00C53B3F File Offset: 0x00C51D3F
		public bool GetIsDetailTextVisible()
		{
			return this.IsDetailTextVisible;
		}

		// Token: 0x0602BE24 RID: 179748 RVA: 0x00C53B48 File Offset: 0x00C51D48
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

		// Token: 0x0602BE25 RID: 179749 RVA: 0x00C53B9C File Offset: 0x00C51D9C
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

		// Token: 0x04017A0B RID: 96779
		private MenuConfig MetaConfig;

		// Token: 0x04017A0C RID: 96780
		[TupleElementNames(new string[]
		{
			"DeviceId",
			"Names",
			"Values"
		})]
		[Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		private ValueTuple<int, string[], int[]>? TestImageQualityOptions;

		// Token: 0x04017A0D RID: 96781
		private bool IsDetailTextVisible;

		// Token: 0x04017A0E RID: 96782
		private readonly Dictionary<EFunction, int[]> OtherFunctionTargetDisableValueCache = new Dictionary<EFunction, int[]>();
	}
}
