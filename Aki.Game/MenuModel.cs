using System;
using System.Collections.Generic;
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

// Token: 0x020016EC RID: 5868
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MenuModel : ModelBase
{
	// Token: 0x170015C1 RID: 5569
	// (get) Token: 0x0600E3FE RID: 58366 RVA: 0x0042E08C File Offset: 0x0042C28C
	// (set) Token: 0x0600E3FF RID: 58367 RVA: 0x0042E103 File Offset: 0x0042C303
	public bool IsImageQualityCustom
	{
		get
		{
			if (this.IsImageQualityCustomInternal == null)
			{
				EGameQualitySettingLevel valueOrDefault = (EGameQualitySettingLevel)this.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY).GetValueOrDefault();
				this.IsImageQualityCustomInternal = new bool?(!GameSettingsManager.Instance.CheckIsMatchQualityRecommend(valueOrDefault, new Func<EFunction, int?>(this.GetDataCacheOrCurValue)) || !GameSettingsManager.Instance.CheckIsMatchFloatRenderRecommend(valueOrDefault, new Func<EFunction, float?>(this.GetDataCacheOrCurValueFloat)));
			}
			return this.IsImageQualityCustomInternal.Value;
		}
		set
		{
			this.IsImageQualityCustomInternal = new bool?(value);
		}
	}

	// Token: 0x170015C2 RID: 5570
	// (set) Token: 0x0600E400 RID: 58368 RVA: 0x0042E111 File Offset: 0x0042C311
	public bool? IsImageQualityCustomNullable
	{
		set
		{
			this.IsImageQualityCustomInternal = value;
		}
	}

	// Token: 0x170015C3 RID: 5571
	// (get) Token: 0x0600E401 RID: 58369 RVA: 0x0042E11C File Offset: 0x0042C31C
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

	// Token: 0x170015C4 RID: 5572
	// (get) Token: 0x0600E402 RID: 58370 RVA: 0x0042E224 File Offset: 0x0042C424
	// (set) Token: 0x0600E403 RID: 58371 RVA: 0x0042E254 File Offset: 0x0042C454
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

	// Token: 0x0600E404 RID: 58372 RVA: 0x0042E262 File Offset: 0x0042C462
	protected override bool OnInit()
	{
		this.Initialize();
		return true;
	}

	// Token: 0x0600E405 RID: 58373 RVA: 0x0042E26B File Offset: 0x0042C46B
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

	// Token: 0x0600E406 RID: 58374 RVA: 0x0042E28C File Offset: 0x0042C48C
	public void Initialize()
	{
		this.InitCommonParameter();
		if (GameSettingsManager.Instance.IsValid(EFunction.RayTracing, true))
		{
			int? num = new int?(GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.RayTracing, 0, true));
			this.IsRayTracingOpenChecked = (num != null && num.Value > 0);
		}
	}

	// Token: 0x0600E407 RID: 58375 RVA: 0x0042E2E5 File Offset: 0x0042C4E5
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

	// Token: 0x0600E408 RID: 58376 RVA: 0x0042E30C File Offset: 0x0042C50C
	private void InitCommonParameter()
	{
		this.LowShake = (float)ConfigCommonParamById.GetIntConfig("LowShake").Value / 100f;
		this.MiddleShake = (float)ConfigCommonParamById.GetIntConfig("MiddleShake").Value / 100f;
		this.HighShake = (float)ConfigCommonParamById.GetIntConfig("HighShake").Value / 100f;
		this.AllowResolutionList = new List<int>(ConfigCommonParamById.GetIntArrayConfig("AllowResolutionList"));
	}

	// Token: 0x0600E409 RID: 58377 RVA: 0x0042E38C File Offset: 0x0042C58C
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

	// Token: 0x0600E40A RID: 58378 RVA: 0x0042E578 File Offset: 0x0042C778
	private MenuData BuildDataByType(MenuConfig config)
	{
		if (config.FunctionId == 51506)
		{
			return new MenuVersionCheckData(config);
		}
		return new MenuData(config);
	}

	// Token: 0x0600E40B RID: 58379 RVA: 0x0042E598 File Offset: 0x0042C798
	private bool CheckConsoleHide(MenuConfig config)
	{
		if (config.SpecifyHideConsolesLength <= 0)
		{
			return true;
		}
		string consoleModelName = UKuroStaticLibrary.GetConsoleModelName();
		using (IEnumerator<string> enumerator = config.SpecifyHideConsolesIter().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current == consoleModelName)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600E40C RID: 58380 RVA: 0x0042E600 File Offset: 0x0042C800
	private bool CheckActiveCondition(MenuConfig config)
	{
		if (Info.Instance.IsPs5Platform() && config.Ps5Hide == 1 && this.CheckConsoleHide(config))
		{
			return false;
		}
		if (Info.Instance.IsXboxPlatform() && !Info.Instance.IsWinGDKPlatform() && config.XboxHide == 1 && this.CheckConsoleHide(config))
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

	// Token: 0x0600E40D RID: 58381 RVA: 0x0042E710 File Offset: 0x0042C910
	private bool CheckActiveConditionImp(MenuConfig config)
	{
		return config.ConditionGroup == 0 || LevelGeneralController.Instance.CheckCondition(config.ConditionGroup.ToString(), null, true, Array.Empty<object>());
	}

	// Token: 0x0600E40E RID: 58382 RVA: 0x0042E748 File Offset: 0x0042C948
	private bool CheckIosReviewShield(int configId)
	{
		IReadOnlyList<int> iosReviewShieldMenuArray = CommonConfig.Instance.GetIosReviewShieldMenuArray();
		bool flag = false;
		if (iosReviewShieldMenuArray != null)
		{
			for (int i = 0; i < iosReviewShieldMenuArray.Count; i++)
			{
				if (iosReviewShieldMenuArray[i] == configId)
				{
					flag = true;
					break;
				}
			}
		}
		return flag && BaseConfigController.Instance.GetIosAuditFirstDownloadTip();
	}

	// Token: 0x0600E40F RID: 58383 RVA: 0x0042E796 File Offset: 0x0042C996
	private bool CheckShowImageSettingInCloudGame(MenuConfig menuConfig)
	{
		if (menuConfig.MainType != 2)
		{
			return this.CheckActiveConditionImp(menuConfig);
		}
		return MenuDefine.cloudGameImageShowSettingsSet.Contains((EFunction)menuConfig.FunctionId);
	}

	// Token: 0x0600E410 RID: 58384 RVA: 0x0042E7BB File Offset: 0x0042C9BB
	public void ClearMenuDataMap()
	{
		this.MenuDataMainTypeMap.Clear();
	}

	// Token: 0x0600E411 RID: 58385 RVA: 0x0042E7C8 File Offset: 0x0042C9C8
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

	// Token: 0x0600E412 RID: 58386 RVA: 0x0042E824 File Offset: 0x0042CA24
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

	// Token: 0x0600E413 RID: 58387 RVA: 0x0042E9B4 File Offset: 0x0042CBB4
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

	// Token: 0x0600E414 RID: 58388 RVA: 0x0042EA2C File Offset: 0x0042CC2C
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

	// Token: 0x0600E415 RID: 58389 RVA: 0x0042EA6C File Offset: 0x0042CC6C
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

	// Token: 0x0600E416 RID: 58390 RVA: 0x0042EA8C File Offset: 0x0042CC8C
	public bool IsInMenuDataByFunctionId(EFunction functionId)
	{
		return this.MenuDataFunctionMap.ContainsKey(functionId);
	}

	// Token: 0x0600E417 RID: 58391 RVA: 0x0042EA9C File Offset: 0x0042CC9C
	private int GetSettingScoreDelta(int current, int recommended, int[] scoreTable)
	{
		int num = MathUtils.Instance.Clamp(current, 0, scoreTable.Length - 1);
		int num2 = MathUtils.Instance.Clamp(recommended, 0, scoreTable.Length - 1);
		return scoreTable[num] - scoreTable[num2];
	}

	// Token: 0x0600E418 RID: 58392 RVA: 0x0042EAD4 File Offset: 0x0042CCD4
	private int GetRenderDistanceLoadScore(float value, bool isMobilePlatform)
	{
		double renderDistanceStepIndex = (double)GameSettingsDeviceRender.GetRenderDistanceStepIndex(value);
		int[] array = isMobilePlatform ? MenuDefine.mobileLoadingRangeScores : MenuDefine.pcLoadingRangeScores;
		int num = array[0];
		int num2 = array[array.Length - 1];
		double num3 = renderDistanceStepIndex / (double)GameSettingsDeviceRender.GetRenderDistanceMaxStepIndex();
		return (int)Math.Round((double)num + (double)(num2 - num) * num3, MidpointRounding.AwayFromZero);
	}

	// Token: 0x0600E419 RID: 58393 RVA: 0x0042EB1C File Offset: 0x0042CD1C
	private int GetRenderDistanceScoreDelta(bool isMobilePlatform)
	{
		if (!GameSettingsManager.Instance.IsValid(EFunction.LOADINGRANGESCALELEVEL, false))
		{
			this.ImageWeightMap.Remove(20611);
			return 0;
		}
		int quality = this.GetDataCacheOrCurValue(EFunction.IMAGEQUALITY) ?? ((int)GameSettingsDeviceRender.Instance.GameQualitySettingLevel);
		float? renderDistanceRecommendation = GameSettingsDeviceRender.Instance.GetRenderDistanceRecommendation(quality);
		if (renderDistanceRecommendation == null)
		{
			this.ImageWeightMap.Remove(20611);
			return 0;
		}
		float value = this.GetDataCacheOrCurValueFloat(EFunction.LOADINGRANGESCALELEVEL) ?? renderDistanceRecommendation.Value;
		int num = this.GetRenderDistanceLoadScore(value, isMobilePlatform) - this.GetRenderDistanceLoadScore(renderDistanceRecommendation.Value, isMobilePlatform);
		this.ImageWeightMap[20611] = num;
		return num;
	}

	// Token: 0x0600E41A RID: 58394 RVA: 0x0042EBF0 File Offset: 0x0042CDF0
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

	// Token: 0x0600E41B RID: 58395 RVA: 0x0042EEF8 File Offset: 0x0042D0F8
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
		int num = this.GetRenderDistanceScoreDelta(false);
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

	// Token: 0x0600E41C RID: 58396 RVA: 0x0042F2D4 File Offset: 0x0042D4D4
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
		int? num32 = new int?(this.GetDataCacheOrCurValue(EFunction.AnisoLevel).GetValueOrDefault());
		int num33 = MenuDefine.anisotropyScores[MathUtils.Instance.Clamp(num32.Value, 0, MenuDefine.anisotropyScores.Length - 1)];
		this.ImageWeightMap[20004] = num33;
		int renderDistanceScoreDelta = this.GetRenderDistanceScoreDelta(true);
		return (int)((num18 + (float)num19 + (float)num20 + (float)num21 + (float)num22 + (float)num23 + (float)num24 + (float)num25 + (float)num26 + (float)num27 + (float)num28 + (float)num29 + (float)num30 + (float)num31 + (float)num33 + (float)renderDistanceScoreDelta) * num2 * num4);
	}

	// Token: 0x0600E41D RID: 58397 RVA: 0x0042F7EC File Offset: 0x0042D9EC
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

	// Token: 0x0600E41E RID: 58398 RVA: 0x0042F92C File Offset: 0x0042DB2C
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

	// Token: 0x0600E41F RID: 58399 RVA: 0x0042FA37 File Offset: 0x0042DC37
	public bool GetGamepadOperationPreferences()
	{
		return LocalStorage.GetGlobal<bool>(ELocalStorageGlobalKey.GamepadOperationPreferences, false);
	}

	// Token: 0x0600E420 RID: 58400 RVA: 0x0042FA41 File Offset: 0x0042DC41
	public void CleanFilterCache()
	{
		this.FilterSettingValuesCacheInternal = null;
		this.FilterSettingIdCacheInternal = null;
		this.FilterChangedMap.Clear();
	}

	// Token: 0x0600E421 RID: 58401 RVA: 0x0042FA64 File Offset: 0x0042DC64
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

	// Token: 0x0600E422 RID: 58402 RVA: 0x0042FAA4 File Offset: 0x0042DCA4
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

	// Token: 0x0600E423 RID: 58403 RVA: 0x0042FB70 File Offset: 0x0042DD70
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

	// Token: 0x0600E424 RID: 58404 RVA: 0x0042FC75 File Offset: 0x0042DE75
	public bool IsDataCacheContains(EFunction id)
	{
		return this.TempDataCache.ContainsKey(id);
	}

	// Token: 0x0600E425 RID: 58405 RVA: 0x0042FC83 File Offset: 0x0042DE83
	public bool HasDataCache()
	{
		return this.TempDataCache.Count > 0;
	}

	// Token: 0x0600E426 RID: 58406 RVA: 0x0042FC93 File Offset: 0x0042DE93
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

	// Token: 0x0600E427 RID: 58407 RVA: 0x0042FCD0 File Offset: 0x0042DED0
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

	// Token: 0x0600E428 RID: 58408 RVA: 0x0042FCFE File Offset: 0x0042DEFE
	public void InitDataCache()
	{
		this.TempDataCache.Clear();
	}

	// Token: 0x0600E429 RID: 58409 RVA: 0x0042FD0C File Offset: 0x0042DF0C
	[NullableContext(0)]
	public UniTask<int> ApplyDataCache()
	{
		MenuModel.<ApplyDataCache>d__73 <ApplyDataCache>d__;
		<ApplyDataCache>d__.<>t__builder = AsyncUniTaskMethodBuilder<int>.Create();
		<ApplyDataCache>d__.<>4__this = this;
		<ApplyDataCache>d__.<>1__state = -1;
		<ApplyDataCache>d__.<>t__builder.Start<MenuModel.<ApplyDataCache>d__73>(ref <ApplyDataCache>d__);
		return <ApplyDataCache>d__.<>t__builder.Task;
	}

	// Token: 0x0600E42A RID: 58410 RVA: 0x0042FD50 File Offset: 0x0042DF50
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

	// Token: 0x0600E42B RID: 58411 RVA: 0x0042FD88 File Offset: 0x0042DF88
	public string[] GetTopLoadImpactSettings(int maxItems = 4)
	{
		if (this.ImageWeightMap == null || this.ImageWeightMap.Count == 0)
		{
			return new string[0];
		}
		List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(this.ImageWeightMap.Count);
		foreach (KeyValuePair<int, int> item in this.ImageWeightMap)
		{
			int num = list.Count;
			while (num > 0 && list[num - 1].Value < item.Value)
			{
				num--;
			}
			list.Insert(num, item);
		}
		int num2 = Math.Min(Math.Max(maxItems, 0), list.Count);
		string[] array = new string[num2];
		for (int i = 0; i < num2; i++)
		{
			KeyValuePair<int, int> keyValuePair = list[i];
			MenuData menuData;
			if (this.MenuDataFunctionMap.TryGetValue((EFunction)keyValuePair.Key, out menuData) && menuData != null)
			{
				array[i] = menuData.FunctionName;
			}
			else
			{
				array[i] = "";
			}
		}
		return array;
	}

	// Token: 0x170015C5 RID: 5573
	// (get) Token: 0x0600E42C RID: 58412 RVA: 0x0042FEA4 File Offset: 0x0042E0A4
	public static MenuModel Instance
	{
		get
		{
			return MenuModel._Instance;
		}
	}

	// Token: 0x0600E42D RID: 58413 RVA: 0x0042FEAB File Offset: 0x0042E0AB
	public static MenuModel GetOrCreateInstance()
	{
		if (MenuModel._Instance == null)
		{
			MenuModel.CreateInstance();
		}
		return MenuModel._Instance;
	}

	// Token: 0x0600E42E RID: 58414 RVA: 0x0042FEBF File Offset: 0x0042E0BF
	public static bool CreateInstance()
	{
		if (MenuModel._Instance != null)
		{
			return true;
		}
		MenuModel._Instance = new MenuModel();
		return true;
	}

	// Token: 0x0600E42F RID: 58415 RVA: 0x0042FED5 File Offset: 0x0042E0D5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E430 RID: 58416 RVA: 0x0042FED7 File Offset: 0x0042E0D7
	public static void ResetStaticDefaultValue()
	{
		MenuModel._Instance = null;
	}

	// Token: 0x0600E431 RID: 58417 RVA: 0x0042FEDF File Offset: 0x0042E0DF
	static MenuModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MenuModel.CreateStaticDefaultValue), new Action(MenuModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008234 RID: 33332
	private readonly Dictionary<EMainType, List<MenuData>> MenuDataMainTypeMap = new Dictionary<EMainType, List<MenuData>>();

	// Token: 0x04008235 RID: 33333
	private readonly Dictionary<EFunction, MenuData> MenuDataFunctionMap = new Dictionary<EFunction, MenuData>();

	// Token: 0x04008236 RID: 33334
	private readonly Dictionary<EFunction, float> TempDataCache = new Dictionary<EFunction, float>();

	// Token: 0x04008237 RID: 33335
	[Nullable(2)]
	private Dictionary<int, MainType> MainConfig;

	// Token: 0x04008238 RID: 33336
	private readonly Dictionary<int, int> ImageWeightMap = new Dictionary<int, int>();

	// Token: 0x04008239 RID: 33337
	public bool IsEdited;

	// Token: 0x0400823A RID: 33338
	private bool? IsImageQualityCustomInternal;

	// Token: 0x0400823B RID: 33339
	public CSharpScript.Game.Module.Menu.EInputControllerType KeySettingInputControllerType;

	// Token: 0x0400823C RID: 33340
	public bool IsWaitForKeyInput;

	// Token: 0x0400823D RID: 33341
	public float LowShake;

	// Token: 0x0400823E RID: 33342
	public float MiddleShake;

	// Token: 0x0400823F RID: 33343
	public float HighShake;

	// Token: 0x04008240 RID: 33344
	public int SimulatedPlatform = -1;

	// Token: 0x04008241 RID: 33345
	[Nullable(2)]
	public List<int> AllowResolutionList;

	// Token: 0x04008242 RID: 33346
	public float QualityInfoPercentage;

	// Token: 0x04008243 RID: 33347
	public bool IsOpenedImageOverloadConfirmBox;

	// Token: 0x04008244 RID: 33348
	public bool IsRayTracingOpenChecked;

	// Token: 0x04008245 RID: 33349
	public bool NeedRayTracingSubChange;

	// Token: 0x04008246 RID: 33350
	public bool IsVulkanOpenChecked;

	// Token: 0x04008247 RID: 33351
	public bool IsAnisoLevelOpenChecked;

	// Token: 0x04008248 RID: 33352
	private readonly Dictionary<EFunction, FeatureRestrictionTemplate> Function2FeatureTemplateMap = new Dictionary<EFunction, FeatureRestrictionTemplate>
	{
		{
			EFunction.CdKey,
			FeatureRestrictionTemplate.TemplateForPioneerClient
		}
	};

	// Token: 0x04008249 RID: 33353
	[Nullable(2)]
	public FilterSettingViewModel FilterSettingViewModel;

	// Token: 0x0400824A RID: 33354
	public readonly Dictionary<int, bool> FilterChangedMap = new Dictionary<int, bool>();

	// Token: 0x0400824B RID: 33355
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, float[]> FilterSettingValuesCacheInternal;

	// Token: 0x0400824C RID: 33356
	private int? FilterSettingIdCacheInternal;

	// Token: 0x0400824D RID: 33357
	public bool HasApplyRecommendData;

	// Token: 0x0400824E RID: 33358
	[Nullable(2)]
	private static MenuModel _Instance;
}
