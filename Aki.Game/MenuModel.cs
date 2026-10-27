using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Module.Menu.Views;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002208 RID: 8712
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MenuModel : ModelBase
{
	// Token: 0x1700158A RID: 5514
	// (get) Token: 0x06010F6B RID: 69483 RVA: 0x004216E8 File Offset: 0x0041F8E8
	// (set) Token: 0x06010F6C RID: 69484 RVA: 0x00421743 File Offset: 0x0041F943
	public bool IsImageQualityCustom
	{
		get
		{
			if (this.IsImageQualityCustomInternal == null)
			{
				int valueOrDefault = this.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY).GetValueOrDefault();
				this.IsImageQualityCustomInternal = new bool?(!GameSettingsManager.Instance.CheckIsMatchQualityRecommend((EGameQualitySettingLevel)valueOrDefault, new Func<EFunction, int?>(this.GetDataCacheOrCurValue)));
			}
			return this.IsImageQualityCustomInternal.Value;
		}
		set
		{
			this.IsImageQualityCustomInternal = new bool?(value);
		}
	}

	// Token: 0x1700158B RID: 5515
	// (set) Token: 0x06010F6D RID: 69485 RVA: 0x00421751 File Offset: 0x0041F951
	public bool? IsImageQualityCustomNullable
	{
		set
		{
			this.IsImageQualityCustomInternal = value;
		}
	}

	// Token: 0x1700158C RID: 5516
	// (get) Token: 0x06010F6E RID: 69486 RVA: 0x0042175C File Offset: 0x0041F95C
	public Dictionary<int, float[]> FilterSettingValuesCache
	{
		get
		{
			if (this.FilterSettingValuesCacheInternal == null)
			{
				Dictionary<int, float[]> global = LocalStorage.GetGlobal<Dictionary<int, float[]>>(ELocalStorageGlobalKey.FilterSettingValues, null);
				this.FilterSettingValuesCacheInternal = new Dictionary<int, float[]>();
				IReadOnlyList<FilterSetting> configList = ConfigFilterSettingAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (FilterSetting filterSetting in configList)
					{
						float[] array = new float[MenuDefine.filterSettingParams.Length];
						foreach (EFilterSettingValueIndex efilterSettingValueIndex in MenuDefine.filterSettingParams)
						{
							float filterDefaultValue = FilterSettingController.Instance.GetFilterDefaultValue(filterSetting.Id, efilterSettingValueIndex);
							float[] array2;
							if (global != null && global.TryGetValue(filterSetting.Id, out array2) && array2 != null && efilterSettingValueIndex < (EFilterSettingValueIndex)array2.Length)
							{
								array[(int)efilterSettingValueIndex] = array2[(int)efilterSettingValueIndex];
							}
							else
							{
								array[(int)efilterSettingValueIndex] = filterDefaultValue;
							}
						}
						this.FilterSettingValuesCacheInternal[filterSetting.Id] = array;
					}
				}
			}
			return this.FilterSettingValuesCacheInternal;
		}
	}

	// Token: 0x1700158D RID: 5517
	// (get) Token: 0x06010F6F RID: 69487 RVA: 0x00421864 File Offset: 0x0041FA64
	// (set) Token: 0x06010F70 RID: 69488 RVA: 0x00421894 File Offset: 0x0041FA94
	public int FilterSettingIdCache
	{
		get
		{
			if (this.FilterSettingIdCacheInternal == null)
			{
				this.FilterSettingIdCacheInternal = new int?(LocalStorage.GetGlobal<int>(ELocalStorageGlobalKey.FilterSettingId, 1));
			}
			return this.FilterSettingIdCacheInternal.Value;
		}
		set
		{
			this.FilterSettingIdCacheInternal = new int?(value);
		}
	}

	// Token: 0x06010F71 RID: 69489 RVA: 0x004218A2 File Offset: 0x0041FAA2
	protected override bool OnInit()
	{
		this.Initialize();
		return true;
	}

	// Token: 0x06010F72 RID: 69490 RVA: 0x004218AB File Offset: 0x0041FAAB
	protected override bool OnClear()
	{
		this.MenuDataMainTypeMap.Clear();
		Dictionary<int, MainType> mainConfig = this.MainConfig;
		if (mainConfig != null)
		{
			mainConfig.Clear();
		}
		return true;
	}

	// Token: 0x06010F73 RID: 69491 RVA: 0x004218CC File Offset: 0x0041FACC
	public void Initialize()
	{
		this.InitCommonParameter();
		if (GameSettingsManager.Instance.IsValid(EFunction.RayTracing, true))
		{
			int? num = new int?(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracing, 0, true));
			this.IsRayTracingOpenChecked = (num != null && num.Value > 0);
		}
	}

	// Token: 0x06010F74 RID: 69492 RVA: 0x00421925 File Offset: 0x0041FB25
	public void ReInit()
	{
		this.MenuDataMainTypeMap.Clear();
		Dictionary<int, MainType> mainConfig = this.MainConfig;
		if (mainConfig != null)
		{
			mainConfig.Clear();
		}
		this.Initialize();
	}

	// Token: 0x06010F75 RID: 69493 RVA: 0x0042194C File Offset: 0x0041FB4C
	private void InitCommonParameter()
	{
		this.LowShake = (float)ConfigCommonParamById.GetIntConfig("LowShake").Value / 100f;
		this.MiddleShake = (float)ConfigCommonParamById.GetIntConfig("MiddleShake").Value / 100f;
		this.HighShake = (float)ConfigCommonParamById.GetIntConfig("HighShake").Value / 100f;
		this.AllowResolutionList = ConfigCommonParamById.GetIntArrayConfig("AllowResolutionList").ToList<int>();
	}

	// Token: 0x06010F76 RID: 69494 RVA: 0x004219CC File Offset: 0x0041FBCC
	public void CreateConfigByBaseConfig()
	{
		foreach (KeyValuePair<EFunction, MenuConfig> keyValuePair in GameSettingsManager.Instance.ValidApplyConfigMap)
		{
			EFunction key = keyValuePair.Key;
			MenuConfig value = keyValuePair.Value;
			if (this.CheckActiveCondition(value))
			{
				int mainType = value.MainType;
				MenuData menuData = this.BuildDataByType(value);
				this.MenuDataFunctionMap[key] = menuData;
				List<MenuData> list;
				if (this.MenuDataMainTypeMap.TryGetValue((EMainType)mainType, out list) && list != null && list.Count > 0)
				{
					list.Add(menuData);
				}
				else
				{
					this.MenuDataMainTypeMap[(EMainType)mainType] = new List<MenuData>
					{
						menuData
					};
				}
			}
		}
		foreach (KeyValuePair<EFunction, MenuData> keyValuePair2 in this.MenuDataFunctionMap)
		{
			EFunction key2 = keyValuePair2.Key;
			MenuData value2 = keyValuePair2.Value;
			foreach (int num in value2.DisableFunction)
			{
				MenuData menuData2;
				if (!this.MenuDataFunctionMap.TryGetValue((EFunction)num, out menuData2) || menuData2 == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Menu;
					ELogAuthor author = ELogAuthor.WZ;
					string message = "目标设置项并未在UI中开启";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("target functionId", num);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					menuData2.CacheDisableState(key2, value2.DisableValue);
				}
			}
		}
		foreach (EMainType mainType2 in this.MenuDataMainTypeMap.Keys)
		{
			this.DataSort((int)mainType2);
		}
	}

	// Token: 0x06010F77 RID: 69495 RVA: 0x00421BB8 File Offset: 0x0041FDB8
	private MenuData BuildDataByType(MenuConfig config)
	{
		if (config.FunctionId == 51506)
		{
			return new MenuVersionCheckData(config);
		}
		return new MenuData(config);
	}

	// Token: 0x06010F78 RID: 69496 RVA: 0x00421BD8 File Offset: 0x0041FDD8
	private bool CheckActiveCondition(MenuConfig config)
	{
		if (Info.Instance.IsPs5Platform() && config.Ps5Hide == 1)
		{
			return false;
		}
		if (Info.Instance.IsXboxPlatform() && !Info.Instance.IsWinGDKPlatform() && config.XboxHide == 1)
		{
			return false;
		}
		if (Info.Instance.IsXboxPlatform() && Info.Instance.IsWinGDKPlatform() && config.WinGDKHide == 1)
		{
			return false;
		}
		if (Info.Instance.IsIosPlatform() && this.CheckIosReviewShield(config.Id))
		{
			return false;
		}
		FeatureRestrictionTemplate featureRestrictionTemplate;
		if (this.Function2FeatureTemplateMap.TryGetValue((EFunction)config.FunctionId, out featureRestrictionTemplate) && featureRestrictionTemplate != null && featureRestrictionTemplate.Check())
		{
			return false;
		}
		if (Application.Instance.IsPublicationApp() && config.MainType == 4)
		{
			return false;
		}
		if (config.FunctionId == 129 || config.FunctionId == 134)
		{
			return false;
		}
		if (Platform.Instance.IsCloudGame())
		{
			return this.CheckShowImageSettingInCloudGame(config);
		}
		return this.CheckActiveConditionImp(config);
	}

	// Token: 0x06010F79 RID: 69497 RVA: 0x00421CD8 File Offset: 0x0041FED8
	private bool CheckActiveConditionImp(MenuConfig config)
	{
		return config.ConditionGroup == 0 || LevelGeneralController.Instance.CheckCondition(config.ConditionGroup.ToString(), null, true, Array.Empty<object>());
	}

	// Token: 0x06010F7A RID: 69498 RVA: 0x00421D10 File Offset: 0x0041FF10
	private bool CheckIosReviewShield(int configId)
	{
		IReadOnlyList<int> iosReviewShieldMenuArray = CommonConfig.Instance.GetIosReviewShieldMenuArray();
		return iosReviewShieldMenuArray != null && iosReviewShieldMenuArray.Contains(configId) && BaseConfigController.Instance.GetIosAuditFirstDownloadTip();
	}

	// Token: 0x06010F7B RID: 69499 RVA: 0x00421D3A File Offset: 0x0041FF3A
	private bool CheckShowImageSettingInCloudGame(MenuConfig menuConfig)
	{
		if (menuConfig.MainType != 2)
		{
			return this.CheckActiveConditionImp(menuConfig);
		}
		return MenuDefine.cloudGameImageShowSettingsSet.Contains((EFunction)menuConfig.FunctionId);
	}

	// Token: 0x06010F7C RID: 69500 RVA: 0x00421D5F File Offset: 0x0041FF5F
	public void ClearMenuDataMap()
	{
		this.MenuDataMainTypeMap.Clear();
	}

	// Token: 0x06010F7D RID: 69501 RVA: 0x00421D6C File Offset: 0x0041FF6C
	private void DataSort(int mainType)
	{
		List<MenuData> list;
		if (!this.MenuDataMainTypeMap.TryGetValue((EMainType)mainType, out list) || list == null || list.Count == 0)
		{
			return;
		}
		list.Sort(delegate(MenuData a, MenuData b)
		{
			if (a.SubSort == b.SubSort)
			{
				return a.FunctionSort - b.FunctionSort;
			}
			return a.SubSort - b.SubSort;
		});
		this.MenuDataMainTypeMap[(EMainType)mainType] = list;
	}

	// Token: 0x06010F7E RID: 69502 RVA: 0x00421DC8 File Offset: 0x0041FFC8
	public unsafe int[] GetMainTypeList([Nullable(2)] TMenuItemFilter filter = null)
	{
		this.MainConfig = MenuBaseConfig.Instance.GetMainConfig();
		List<int> list = new List<int>();
		foreach (KeyValuePair<EMainType, List<MenuData>> keyValuePair in this.MenuDataMainTypeMap)
		{
			EMainType key = keyValuePair.Key;
			List<MenuData> value = keyValuePair.Value;
			if (filter != null)
			{
				bool flag = false;
				foreach (MenuData data in value)
				{
					if (filter(data))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			else if (value.Count <= 0)
			{
				continue;
			}
			MainType mainType;
			if (this.MainConfig == null || !this.MainConfig.TryGetValue((int)key, out mainType))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Menu;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "未能获得主类型配置（MainType）";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("main type id", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MainConfigs", this.MainConfig);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else
			{
				list.Add((int)key);
			}
		}
		list.Sort(delegate(int a, int b)
		{
			if (this.MainConfig == null)
			{
				return 0;
			}
			MainType mainType2;
			this.MainConfig.TryGetValue(a, out mainType2);
			MainType mainType3;
			this.MainConfig.TryGetValue(b, out mainType3);
			if (!this.MainConfig.ContainsKey(a) || !this.MainConfig.ContainsKey(b))
			{
				return 0;
			}
			return mainType2.MainSort - mainType3.MainSort;
		});
		return list.ToArray();
	}

	// Token: 0x06010F7F RID: 69503 RVA: 0x00421F58 File Offset: 0x00420158
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<MenuData> GetTargetConfigData(int mainType, TMenuItemFilter filter = null)
	{
		List<MenuData> list;
		if (!this.MenuDataMainTypeMap.TryGetValue((EMainType)mainType, out list) || list == null)
		{
			return null;
		}
		if (filter == null)
		{
			return list;
		}
		List<MenuData> list2 = new List<MenuData>();
		foreach (MenuData menuData in list)
		{
			if (filter(menuData))
			{
				list2.Add(menuData);
			}
		}
		return list2;
	}

	// Token: 0x06010F80 RID: 69504 RVA: 0x00421FD0 File Offset: 0x004201D0
	public MainType? GetTargetMainInfo(int mainType)
	{
		if (this.MainConfig == null)
		{
			return null;
		}
		MainType value;
		if (this.MainConfig.TryGetValue(mainType, out value))
		{
			return new MainType?(value);
		}
		return null;
	}

	// Token: 0x06010F81 RID: 69505 RVA: 0x00422010 File Offset: 0x00420210
	[NullableContext(2)]
	public MenuData GetMenuDataByFunctionId(int functionId)
	{
		MenuData result;
		if (this.MenuDataFunctionMap.TryGetValue((EFunction)functionId, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06010F82 RID: 69506 RVA: 0x00422030 File Offset: 0x00420230
	public bool IsInMenuDataByFunctionId(EFunction functionId)
	{
		return this.MenuDataFunctionMap.ContainsKey(functionId);
	}

	// Token: 0x06010F83 RID: 69507 RVA: 0x00422040 File Offset: 0x00420240
	private int GetSettingScoreDelta(int current, int recommended, int[] scoreTable)
	{
		int num = MathUtils.Instance.Clamp(current, 0, scoreTable.Length - 1);
		int num2 = MathUtils.Instance.Clamp(recommended, 0, scoreTable.Length - 1);
		return scoreTable[num] - scoreTable[num2];
	}

	// Token: 0x06010F84 RID: 69508 RVA: 0x00422078 File Offset: 0x00420278
	[return: TupleElementNames(new string[]
	{
		"recommended",
		"fieldMappings",
		"FunctionId",
		"Key",
		"ScoreTable"
	})]
	[return: Nullable(new byte[]
	{
		0,
		1,
		1,
		1,
		0,
		1,
		1
	})]
	private ValueTuple<Dictionary<string, int>, List<ValueTuple<EFunction, string, int[]>>> GetRenderRecommendedAndFieldMappings(Dictionary<EFunction, int> valueMap)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		dictionary.Add("ShadowQuality", 0);
		dictionary.Add("NiagaraQuality", 0);
		dictionary.Add("ImageDetail", 0);
		dictionary.Add("SceneAo", 0);
		dictionary.Add("AntiAliasing", 0);
		dictionary.Add("VolumeFog", 0);
		dictionary.Add("VolumeLight", 0);
		dictionary.Add("MotionBlur", 0);
		dictionary.Add("MetalFxEnable", 0);
		dictionary.Add("BloomEnable", 0);
		dictionary.Add("NpcDensity", 0);
		dictionary.Add("SuperResolution", 0);
		dictionary.Add("RayTracingGI", 0);
		dictionary.Add("RayTracingReflection", 0);
		dictionary.Add("RayTracedShadow", 0);
		dictionary.Add("LoadingRangeScaleLevel", 0);
		dictionary.Add("AnisoLevel", 0);
		List<ValueTuple<EFunction, string, int[]>> list = new List<ValueTuple<EFunction, string, int[]>>
		{
			new ValueTuple<EFunction, string, int[]>(EFunction.SHADOWQUALITY, "ShadowQuality", MenuDefine.shadowQualityScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.NIAGARAQUALITY, "NiagaraQuality", MenuDefine.niagaraQualityScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.IMAGEDETAIL, "ImageDetail", MenuDefine.imageDetailScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.SCENEAO, "SceneAo", MenuDefine.sceneAoScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.ANTIALISING, "AntiAliasing", MenuDefine.antiAliasingScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.VOLUMEFOG, "VolumeFog", MenuDefine.volumeFogScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.VOLUMELIGHT, "VolumeLight", MenuDefine.volumeLightScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.MOTIONBLUR, "MotionBlur", MenuDefine.motionBlurScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.METALFX, "MetalFxEnable", MenuDefine.metalFxScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.BLOOM, "BloomEnable", MenuDefine.bloomScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.NPCDENSITY, "NpcDensity", MenuDefine.npcDensityScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.VegetationDensity, "VegetationDensity", MenuDefine.vegetationDensityScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.SUPERRESOLUTION, "SuperResolution", MenuDefine.superResolutionScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.RayTracedGI, "RayTracingGI", MenuDefine.rayTracingGIScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.RayTracedReflection, "RayTracingReflection", MenuDefine.rayTracingReflectionScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.RayTracedShadow, "RayTracedShadow", MenuDefine.rayTracedShadowScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.LOADINGRANGESCALELEVEL, "LoadingRangeScaleLevel", MenuDefine.pcLoadingRangeScores),
			new ValueTuple<EFunction, string, int[]>(EFunction.AnisoLevel, "AnisoLevel", MenuDefine.anisotropyScores)
		};
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>(dictionary);
		foreach (KeyValuePair<EFunction, int> keyValuePair in valueMap)
		{
			EFunction funcId = keyValuePair.Key;
			int value = keyValuePair.Value;
			ValueTuple<EFunction, string, int[]>? valueTuple = list.FirstOrNull(([TupleElementNames(new string[]
			{
				"FunctionId",
				"Key",
				"ScoreTable"
			})] ValueTuple<EFunction, string, int[]> m) => m.Item1 == funcId);
			if (valueTuple != null)
			{
				dictionary2[valueTuple.Value.Item2] = value;
			}
		}
		return new ValueTuple<Dictionary<string, int>, List<ValueTuple<EFunction, string, int[]>>>(dictionary2, list);
	}

	// Token: 0x06010F85 RID: 69509 RVA: 0x004223A8 File Offset: 0x004205A8
	private int GetQualitySettingDeltaScorePcPlatform()
	{
		EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
		if (recommendQualityLv == null)
		{
			return 0;
		}
		DeviceRenderFeature? deviceRenderFeature = GameSettingsDeviceRender.Instance.GetDeviceRenderFeature(recommendQualityLv.Value);
		if (deviceRenderFeature == null)
		{
			return 0;
		}
		Dictionary<EFunction, int> otherChangedValue = GameSettingsDeviceRender.Instance.GetOtherChangedValue(deviceRenderFeature.Value);
		ValueTuple<Dictionary<string, int>, List<ValueTuple<EFunction, string, int[]>>> renderRecommendedAndFieldMappings = this.GetRenderRecommendedAndFieldMappings(otherChangedValue);
		Dictionary<string, int> item = renderRecommendedAndFieldMappings.Item1;
		List<ValueTuple<EFunction, string, int[]>> item2 = renderRecommendedAndFieldMappings.Item2;
		int num = 0;
		foreach (ValueTuple<EFunction, string, int[]> valueTuple in item2)
		{
			EFunction item3 = valueTuple.Item1;
			int num2 = item[valueTuple.Item2];
			int? num3 = new int?(this.GetDataCacheOrCurValue(valueTuple.Item1).GetValueOrDefault());
			int[] array = valueTuple.Item3;
			if (item3 == EFunction.SUPERRESOLUTION)
			{
				EFunction efunction = item3;
				EFunction efunction2 = item3;
				ValueTuple<EFunction, EFunction, int> valueTuple2 = GameSettingsDeviceRender.Instance.MapSuperResolutionRecommendValue(efunction, efunction2, num2);
				efunction = valueTuple2.Item1;
				efunction2 = valueTuple2.Item2;
				num2 = valueTuple2.Item3;
				int? num4 = new int?(this.GetDataCacheOrCurValue(efunction).GetValueOrDefault());
				int? num5 = new int?(this.GetDataCacheOrCurValue(efunction2).GetValueOrDefault());
				if (efunction == EFunction.FSR)
				{
					array = MenuDefine.superResolutionScores;
					num2 = MenuDefine.superResolutionScores.Length - 2;
					if (num4.GetValueOrDefault() == 1)
					{
						num3 = new int?(MenuDefine.superResolutionScores.Length - 2);
					}
				}
				else
				{
					array = ((efunction == EFunction.NVIDIADLSS) ? MenuDefine.nvidiaSuperResolutionScores : MenuDefine.superResolutionScores);
					if (num2 == 99)
					{
						num2 = 2;
					}
					else
					{
						num2 += 2;
					}
					if (num5.GetValueOrDefault() == 99)
					{
						num3 = new int?(2);
					}
					else
					{
						num3 = new int?(num5.Value + 2);
					}
				}
				int? num6 = num4;
				int num7 = 0;
				if (num6.GetValueOrDefault() == num7 & num6 != null)
				{
					num3 = new int?(array.Length - 1);
				}
			}
			if (item3 == EFunction.RayTracedGI || item3 == EFunction.RayTracedReflection || item3 == EFunction.RayTracedShadow)
			{
				int? num6 = num3;
				int num7 = 0;
				if (num6.GetValueOrDefault() > num7 & num6 != null)
				{
					num3 = new int?(this.GetDataCacheOrCurValue(EFunction.RayTracing).GetValueOrDefault());
					float currentValue = 4000f / (float)GameSettingsDeviceRender.Instance.DeviceScore;
					float num8 = MathUtils.Instance.Clamp(currentValue, 0.6f, 3f);
					int num9 = (int)((float)this.GetSettingScoreDelta(num3.Value, num2, valueTuple.Item3) * num8);
					num += num9;
					this.ImageWeightMap[(int)item3] = num9;
					continue;
				}
			}
			int settingScoreDelta = this.GetSettingScoreDelta(num3.Value, num2, array);
			num += settingScoreDelta;
			this.ImageWeightMap[(int)item3] = settingScoreDelta;
		}
		int? num10 = new int?(this.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY).GetValueOrDefault());
		EGameQualitySettingLevel valueOrDefault = GameSettingsDeviceRender.Instance.GetRecommendQualityLv().GetValueOrDefault();
		int settingScoreDelta2 = this.GetSettingScoreDelta(num10.Value, (int)valueOrDefault, MenuDefine.pcQualityLevelScores);
		int? num11 = new int?(this.GetDataCacheOrCurValue(EFunction.RESOLUTION).GetValueOrDefault(2));
		FIntPoint resolutionByList = GameSettingsDeviceRender.Instance.GetResolutionByList(num11.Value);
		float num12 = ((float)(resolutionByList.X * resolutionByList.Y) / 3686400f - 1f) * 40f;
		MenuModel instance = MenuModel.Instance;
		int? num13 = new int?(((instance != null) ? instance.GetDataCacheOrCurValue(EFunction.HIGHESTFPS) : null).GetValueOrDefault());
		float num14 = ((float)GameSettingsDeviceRender.Instance.GetFrameByList(num13.Value) - 60f) / 60f * 40f;
		num += settingScoreDelta2 + (int)num12 + (int)num14;
		return num;
	}

	// Token: 0x06010F86 RID: 69510 RVA: 0x00422780 File Offset: 0x00420980
	public int GetQualitySettingScoreMobilePlatform()
	{
		int? num = new int?(this.GetDataCacheOrCurValue(EFunction.MOBILERESOLUTION).GetValueOrDefault());
		float num2 = MenuDefine.mobileResolutionScores[num.Value];
		MenuModel instance = MenuModel.Instance;
		int? num3 = new int?(((instance != null) ? instance.GetDataCacheOrCurValue(EFunction.HIGHESTFPS) : null).GetValueOrDefault());
		float num4 = (float)GameSettingsDeviceRender.Instance.GetFrameByList(num3.Value) / 30f;
		int? num5 = new int?(this.GetDataCacheOrCurValue(EFunction.SHADOWQUALITY).GetValueOrDefault());
		int? num6 = new int?(this.GetDataCacheOrCurValue(EFunction.NIAGARAQUALITY).GetValueOrDefault());
		int? num7 = new int?(this.GetDataCacheOrCurValue(EFunction.IMAGEDETAIL).GetValueOrDefault());
		int? num8 = new int?(this.GetDataCacheOrCurValue(EFunction.SCENEAO).GetValueOrDefault());
		int? num9 = new int?(this.GetDataCacheOrCurValue(EFunction.ANTIALISING).GetValueOrDefault());
		int? num10 = new int?(this.GetDataCacheOrCurValue(EFunction.VOLUMEFOG).GetValueOrDefault());
		int? num11 = new int?(this.GetDataCacheOrCurValue(EFunction.VOLUMELIGHT).GetValueOrDefault());
		int? num12 = new int?(this.GetDataCacheOrCurValue(EFunction.MOTIONBLUR).GetValueOrDefault());
		int? num13 = new int?(this.GetDataCacheOrCurValue(EFunction.FSR).GetValueOrDefault());
		int? num14 = new int?(this.GetDataCacheOrCurValue(EFunction.HarmonySuperResolution).GetValueOrDefault());
		int? num15 = new int?(this.GetDataCacheOrCurValue(EFunction.METALFX).GetValueOrDefault());
		int? num16 = new int?(this.GetDataCacheOrCurValue(EFunction.BLOOM).GetValueOrDefault());
		int? num17 = new int?(this.GetDataCacheOrCurValue(EFunction.NPCDENSITY).GetValueOrDefault());
		float num18 = (float)MenuDefine.qualityLevelScores[(int)GameSettingsDeviceRender.Instance.GameQualitySettingLevel];
		int num19 = MenuDefine.shadowQualityScores[MathUtils.Instance.Clamp(num5.Value, 0, MenuDefine.shadowQualityScores.Length - 1)];
		this.ImageWeightMap[54] = num19;
		int num20 = MenuDefine.niagaraQualityScores[MathUtils.Instance.Clamp(num6.Value, 0, MenuDefine.niagaraQualityScores.Length - 1)];
		this.ImageWeightMap[55] = num20;
		int num21 = MenuDefine.imageDetailScores[MathUtils.Instance.Clamp(num7.Value, 0, MenuDefine.imageDetailScores.Length - 1)];
		this.ImageWeightMap[56] = num21;
		int num22 = MenuDefine.sceneAoScores[MathUtils.Instance.Clamp(num8.Value, 0, MenuDefine.sceneAoScores.Length - 1)];
		this.ImageWeightMap[58] = num22;
		int num23 = MenuDefine.antiAliasingScores[MathUtils.Instance.Clamp(num9.Value, 0, MenuDefine.antiAliasingScores.Length - 1)];
		this.ImageWeightMap[57] = num23;
		int num24 = MenuDefine.volumeFogScores[MathUtils.Instance.Clamp(num10.Value, 0, MenuDefine.volumeFogScores.Length - 1)];
		this.ImageWeightMap[63] = num24;
		int num25 = MenuDefine.volumeLightScores[MathUtils.Instance.Clamp(num11.Value, 0, MenuDefine.volumeLightScores.Length - 1)];
		this.ImageWeightMap[64] = num25;
		int num26 = MenuDefine.motionBlurScores[MathUtils.Instance.Clamp(num12.Value, 0, MenuDefine.motionBlurScores.Length - 1)];
		this.ImageWeightMap[65] = num26;
		int num27 = MenuDefine.amdFsrScores[MathUtils.Instance.Clamp(num13.Value, 0, MenuDefine.amdFsrScores.Length - 1)];
		this.ImageWeightMap[87] = num27;
		int num28 = MenuDefine.harmonySuperResolutionScores[MathUtils.Instance.Clamp(num14.Value, 0, MenuDefine.harmonySuperResolutionScores.Length - 1)];
		this.ImageWeightMap[20301] = num28;
		int num29 = MenuDefine.metalFxScores[MathUtils.Instance.Clamp(num15.Value, 0, MenuDefine.metalFxScores.Length - 1)];
		this.ImageWeightMap[127] = num29;
		int num30 = MenuDefine.bloomScores[MathUtils.Instance.Clamp(num16.Value, 0, MenuDefine.bloomScores.Length - 1)];
		this.ImageWeightMap[132] = num30;
		int num31 = MenuDefine.npcDensityScores[MathUtils.Instance.Clamp(num17.Value, 0, MenuDefine.npcDensityScores.Length - 1)];
		this.ImageWeightMap[79] = num31;
		int value = MenuDefine.vegetationDensityScores[MathUtils.Instance.Clamp(num17.Value, 0, MenuDefine.vegetationDensityScores.Length - 1)];
		this.ImageWeightMap[20035] = value;
		int? num32 = new int?(this.GetDataCacheOrCurValue(EFunction.LOADINGRANGESCALELEVEL).GetValueOrDefault());
		int num33 = MenuDefine.mobileLoadingRangeScores[MathUtils.Instance.Clamp(num32.Value, 0, MenuDefine.mobileLoadingRangeScores.Length - 1)];
		this.ImageWeightMap[20611] = num33;
		int? num34 = new int?(this.GetDataCacheOrCurValue(EFunction.AnisoLevel).GetValueOrDefault());
		int num35 = MenuDefine.anisotropyScores[MathUtils.Instance.Clamp(num34.Value, 0, MenuDefine.anisotropyScores.Length - 1)];
		this.ImageWeightMap[20004] = num35;
		return (int)((num18 + (float)num19 + (float)num20 + (float)num21 + (float)num22 + (float)num23 + (float)num24 + (float)num25 + (float)num26 + (float)num27 + (float)num28 + (float)num29 + (float)num30 + (float)num31 + (float)num33 + (float)num35) * num2 * num4);
	}

	// Token: 0x06010F87 RID: 69511 RVA: 0x00422CE0 File Offset: 0x00420EE0
	public unsafe float GetLoadPercentage()
	{
		if (Info.Instance.IsMobilePlatform())
		{
			return (float)this.GetQualitySettingScoreMobilePlatform() * 100f / (float)GameSettingsDeviceRender.Instance.DeviceScore;
		}
		if (Info.Instance.IsPcPlatform())
		{
			int qualitySettingDeltaScorePcPlatform = this.GetQualitySettingDeltaScorePcPlatform();
			float num = 60f;
			int currentValue = 0;
			EGameQualitySettingLevel? recommendQualityLv = GameSettingsDeviceRender.Instance.GetRecommendQualityLv();
			if (recommendQualityLv != null)
			{
				currentValue = (int)recommendQualityLv.Value;
			}
			float num2 = MenuDefine.pcQualityLevelWeights[MathUtils.Instance.Clamp(currentValue, 0, MenuDefine.pcQualityLevelWeights.Length - 1)];
			float num3 = 0.25f * num2;
			float num4 = num + (float)qualitySettingDeltaScorePcPlatform * num3;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.LQX;
			string message = "负载条评估";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("deviceWeight", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("deltaScore", qualitySettingDeltaScorePcPlatform);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("scaleFactor", num3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("finalLoad", num4);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			return num4;
		}
		return 0f;
	}

	// Token: 0x06010F88 RID: 69512 RVA: 0x00422E20 File Offset: 0x00421020
	public unsafe GameQualityLoadInfo GetGameQualityLoadInfo()
	{
		float num = this.GetLoadPercentage();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Render;
		ELogAuthor author = ELogAuthor.ZJF;
		string message = "图像配置负载信息";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DeviceScore", GameSettingsDeviceRender.Instance.DeviceScore);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("LoadPercentage", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		num = MathUtils.Instance.Clamp(num, 0f, 100f);
		if (num > 80f)
		{
			return new GameQualityLoadInfo
			{
				Desc = "Text_SettingLoadOver_text",
				Percentage = (int)num,
				BarColor = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarRed.SP_BarRed"
			};
		}
		if (num > 60f)
		{
			return new GameQualityLoadInfo
			{
				Desc = "Text_SettingLoadLaggy_text",
				Percentage = (int)num,
				BarColor = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarOrange.SP_BarOrange"
			};
		}
		return new GameQualityLoadInfo
		{
			Desc = "Text_SettingLoadFluid_text",
			Percentage = (int)num,
			BarColor = "/Game/Aki/UI/UIResources/UiSet/Atlas/SP_BarGreen.SP_BarGreen"
		};
	}

	// Token: 0x06010F89 RID: 69513 RVA: 0x00422F2B File Offset: 0x0042112B
	public bool GetGamepadOperationPreferences()
	{
		return LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.GamepadOperationPreferences, false);
	}

	// Token: 0x06010F8A RID: 69514 RVA: 0x00422F35 File Offset: 0x00421135
	public void CleanFilterCache()
	{
		this.FilterSettingValuesCacheInternal = null;
		this.FilterSettingIdCacheInternal = null;
		this.FilterChangedMap.Clear();
	}

	// Token: 0x06010F8B RID: 69515 RVA: 0x00422F58 File Offset: 0x00421158
	public int GetFilterIndexByConfigId(int id)
	{
		IReadOnlyList<FilterSetting> configList = ConfigFilterSettingAll.GetConfigList(true);
		if (configList == null)
		{
			return 0;
		}
		for (int i = 0; i < configList.Count; i++)
		{
			if (id == configList[i].Id)
			{
				return i;
			}
		}
		return 0;
	}

	// Token: 0x06010F8C RID: 69516 RVA: 0x00422F98 File Offset: 0x00421198
	public int? GetDataCacheOrCurValue(EFunction id)
	{
		float num;
		if (this.TempDataCache.TryGetValue(id, out num))
		{
			return new int?((int)num);
		}
		if (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
		{
			OneOf<int, float, double>? initValue = GameSettingsManager.Instance.GetInitValue(id, false);
			if (initValue != null)
			{
				return new int?(initValue.Value.Match<int>((int i) => i, (float f) => (int)f, (double d) => (int)d));
			}
		}
		return GameSettingsManager.Instance.GetCurrentValue(id, true, true);
	}

	// Token: 0x06010F8D RID: 69517 RVA: 0x00423064 File Offset: 0x00421264
	public float? GetDataCacheOrCurValueFloat(EFunction id)
	{
		float value;
		if (this.TempDataCache.TryGetValue(id, out value))
		{
			return new float?(value);
		}
		if (!GameSettingsManager.Instance.IsGameSettingsAppliedOnOpenLoading)
		{
			OneOf<int, float, double>? initValue = GameSettingsManager.Instance.GetInitValue(id, false);
			if (initValue != null)
			{
				return new float?(initValue.Value.Match<float>((int i) => (float)i, (float f) => f, (double d) => (float)d));
			}
		}
		if (GameSettingsManager.Instance.IsFloatSetting(id))
		{
			return GameSettingsManager.Instance.GetCurrentValueFloat(id, true, true);
		}
		int? currentValue = GameSettingsManager.Instance.GetCurrentValue(id, true, true);
		if (currentValue == null)
		{
			return null;
		}
		return new float?((float)currentValue.GetValueOrDefault());
	}

	// Token: 0x06010F8E RID: 69518 RVA: 0x00423169 File Offset: 0x00421369
	public bool IsDataCacheContains(EFunction id)
	{
		return this.TempDataCache.ContainsKey(id);
	}

	// Token: 0x06010F8F RID: 69519 RVA: 0x00423177 File Offset: 0x00421377
	public bool HasDataCache()
	{
		return this.TempDataCache.Count > 0;
	}

	// Token: 0x06010F90 RID: 69520 RVA: 0x00423187 File Offset: 0x00421387
	public void AddDataToTempCache(EFunction id, float value)
	{
		if (this.TempDataCache.ContainsKey(id))
		{
			this.TempDataCache[id] = value;
		}
		else
		{
			this.TempDataCache.Add(id, value);
		}
		EventSystem.Instance.Emit<EFunction>(EEventName.RefreshMenuSetting, id);
	}

	// Token: 0x06010F91 RID: 69521 RVA: 0x004231C4 File Offset: 0x004213C4
	public void AddDataToTempOrSetValue(EFunction id, int value)
	{
		MenuData menuDataByFunctionId = this.GetMenuDataByFunctionId((int)id);
		if (menuDataByFunctionId != null && menuDataByFunctionId.IsDataCache)
		{
			this.AddDataToTempCache(id, (float)value);
			return;
		}
		GameSettingsManager.Instance.HandleValueChange(id, value, EGameSettingsApplyReason.WhenUi);
	}

	// Token: 0x06010F92 RID: 69522 RVA: 0x004231F2 File Offset: 0x004213F2
	public void InitDataCache()
	{
		this.TempDataCache.Clear();
	}

	// Token: 0x06010F93 RID: 69523 RVA: 0x00423200 File Offset: 0x00421400
	[NullableContext(0)]
	public UniTask<int> ApplyDataCache()
	{
		MenuModel.<ApplyDataCache>d__70 <ApplyDataCache>d__;
		<ApplyDataCache>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<ApplyDataCache>d__.<>4__this = this;
		<ApplyDataCache>d__.<>1__state = -1;
		<ApplyDataCache>d__.<>t__builder.Start<MenuModel.<ApplyDataCache>d__70>(ref <ApplyDataCache>d__);
		return <ApplyDataCache>d__.<>t__builder.Task;
	}

	// Token: 0x06010F94 RID: 69524 RVA: 0x00423244 File Offset: 0x00421444
	public int GetFilterConfigIdByIndex(int index)
	{
		IReadOnlyList<FilterSetting> configList = ConfigFilterSettingAll.GetConfigList(true);
		if (configList == null)
		{
			return 1;
		}
		if (index >= 0 && index < configList.Count)
		{
			return configList[index].Id;
		}
		return 1;
	}

	// Token: 0x06010F95 RID: 69525 RVA: 0x0042327C File Offset: 0x0042147C
	public string[] GetTopLoadImpactSettings(int maxItems = 4)
	{
		if (this.ImageWeightMap == null || this.ImageWeightMap.Count == 0)
		{
			return new string[0];
		}
		return (from kvp in this.ImageWeightMap
		orderby kvp.Value descending
		select kvp).Take(maxItems).Select(delegate(KeyValuePair<int, int> kvp)
		{
			MenuData menuData;
			if (this.MenuDataFunctionMap.TryGetValue((EFunction)kvp.Key, out menuData) && menuData != null)
			{
				return menuData.FunctionName;
			}
			return "";
		}).ToArray<string>();
	}

	// Token: 0x1700158E RID: 5518
	// (get) Token: 0x06010F96 RID: 69526 RVA: 0x004232EB File Offset: 0x004214EB
	public static MenuModel Instance
	{
		get
		{
			return MenuModel._Instance;
		}
	}

	// Token: 0x06010F97 RID: 69527 RVA: 0x004232F2 File Offset: 0x004214F2
	public static MenuModel GetOrCreateInstance()
	{
		if (MenuModel._Instance == null)
		{
			MenuModel.CreateInstance();
		}
		return MenuModel._Instance;
	}

	// Token: 0x06010F98 RID: 69528 RVA: 0x00423306 File Offset: 0x00421506
	public static bool CreateInstance()
	{
		if (MenuModel._Instance != null)
		{
			return true;
		}
		MenuModel._Instance = new MenuModel();
		return true;
	}

	// Token: 0x06010F99 RID: 69529 RVA: 0x0042331C File Offset: 0x0042151C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010F9A RID: 69530 RVA: 0x0042331E File Offset: 0x0042151E
	public static void ResetStaticDefaultValue()
	{
		MenuModel._Instance = null;
	}

	// Token: 0x06010F9B RID: 69531 RVA: 0x00423326 File Offset: 0x00421526
	static MenuModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MenuModel.CreateStaticDefaultValue), new Action(MenuModel.ResetStaticDefaultValue));
	}

	// Token: 0x040080F6 RID: 33014
	private readonly Dictionary<EMainType, List<MenuData>> MenuDataMainTypeMap = new Dictionary<EMainType, List<MenuData>>();

	// Token: 0x040080F7 RID: 33015
	private readonly Dictionary<EFunction, MenuData> MenuDataFunctionMap = new Dictionary<EFunction, MenuData>();

	// Token: 0x040080F8 RID: 33016
	private readonly Dictionary<EFunction, float> TempDataCache = new Dictionary<EFunction, float>();

	// Token: 0x040080F9 RID: 33017
	[Nullable(2)]
	private Dictionary<int, MainType> MainConfig;

	// Token: 0x040080FA RID: 33018
	private readonly Dictionary<int, int> ImageWeightMap = new Dictionary<int, int>();

	// Token: 0x040080FB RID: 33019
	public bool IsEdited;

	// Token: 0x040080FC RID: 33020
	private bool? IsImageQualityCustomInternal;

	// Token: 0x040080FD RID: 33021
	public CSharpScript.Game.Module.Menu.EInputControllerType KeySettingInputControllerType;

	// Token: 0x040080FE RID: 33022
	public bool IsWaitForKeyInput;

	// Token: 0x040080FF RID: 33023
	public float LowShake;

	// Token: 0x04008100 RID: 33024
	public float MiddleShake;

	// Token: 0x04008101 RID: 33025
	public float HighShake;

	// Token: 0x04008102 RID: 33026
	public int SimulatedPlatform = -1;

	// Token: 0x04008103 RID: 33027
	[Nullable(2)]
	public List<int> AllowResolutionList;

	// Token: 0x04008104 RID: 33028
	public float QualityInfoPercentage;

	// Token: 0x04008105 RID: 33029
	public bool IsOpenedImageOverloadConfirmBox;

	// Token: 0x04008106 RID: 33030
	public bool IsRayTracingOpenChecked;

	// Token: 0x04008107 RID: 33031
	public bool NeedRayTracingSubChange;

	// Token: 0x04008108 RID: 33032
	public bool IsVulkanOpenChecked;

	// Token: 0x04008109 RID: 33033
	public bool IsAnisoLevelOpenChecked;

	// Token: 0x0400810A RID: 33034
	private readonly Dictionary<EFunction, FeatureRestrictionTemplate> Function2FeatureTemplateMap = new Dictionary<EFunction, FeatureRestrictionTemplate>
	{
		{
			EFunction.CdKey,
			FeatureRestrictionTemplate.TemplateForPioneerClient
		}
	};

	// Token: 0x0400810B RID: 33035
	[Nullable(2)]
	public FilterSettingViewModel FilterSettingViewModel;

	// Token: 0x0400810C RID: 33036
	public readonly Dictionary<int, bool> FilterChangedMap = new Dictionary<int, bool>();

	// Token: 0x0400810D RID: 33037
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, float[]> FilterSettingValuesCacheInternal;

	// Token: 0x0400810E RID: 33038
	private int? FilterSettingIdCacheInternal;

	// Token: 0x0400810F RID: 33039
	public bool HasApplyRecommendData;

	// Token: 0x04008110 RID: 33040
	[Nullable(2)]
	private static MenuModel _Instance;
}
