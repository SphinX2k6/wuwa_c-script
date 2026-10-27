using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002D02 RID: 11522
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeaponConfig : ConfigBase
{
	// Token: 0x0601838A RID: 99210 RVA: 0x0062A609 File Offset: 0x00628809
	public WeaponConf? GetWeaponConfigByItemId(int itemId)
	{
		return ConfigWeaponConfByItemId.GetConfig(itemId, true);
	}

	// Token: 0x0601838B RID: 99211 RVA: 0x0062A612 File Offset: 0x00628812
	[return: Nullable(2)]
	public string GetWeaponName(string weaponNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(weaponNameId, null);
	}

	// Token: 0x0601838C RID: 99212 RVA: 0x0062A61C File Offset: 0x0062881C
	public unsafe WeaponPropertyGrowth? GetWeaponPropertyGrowthConfig(int curveId, int level, int breach)
	{
		WeaponPropertyGrowth? config = ConfigWeaponPropertyGrowthByCurveIdLevelAndBreachLevel.GetConfig(curveId, level, breach, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "武器基础配置表格查找武器成长数值失败 WeaponPropertyGrowth";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("曲线id", curveId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("等级", level);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("突破等级", breach);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return config;
	}

	// Token: 0x0601838D RID: 99213 RVA: 0x0062A6B8 File Offset: 0x006288B8
	public unsafe WeaponReson? GetWeaponResonanceConfig(int resonanceId, int level)
	{
		WeaponReson? config = ConfigWeaponResonByResonIdAndLevel.GetConfig(resonanceId, level, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "武器基础配置表格查找武器共鸣配置[WeaponReson]失败,请查看对应表格";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("共鸣组id", resonanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("共鸣等级", level);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x0601838E RID: 99214 RVA: 0x0062A735 File Offset: 0x00628935
	[return: Nullable(2)]
	public string GetWeaponResonanceDesc(string descId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(descId, null);
	}

	// Token: 0x0601838F RID: 99215 RVA: 0x0062A73E File Offset: 0x0062893E
	[return: Nullable(2)]
	public string GetWeaponResonanceName(string resonanceNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(resonanceNameId, null);
	}

	// Token: 0x06018390 RID: 99216 RVA: 0x0062A748 File Offset: 0x00628948
	[NullableContext(2)]
	public string GetWeaponTypeName(int typeId)
	{
		Mapping? config = ConfigMappingBySheetNameFieldNameAndValue.GetConfig("WeaponConf", "WeaponType", typeId, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.Comment, null);
		}
		return null;
	}

	// Token: 0x06018391 RID: 99217 RVA: 0x0062A788 File Offset: 0x00628988
	[NullableContext(2)]
	public string GetWeaponIconPath(int typeId)
	{
		IReadOnlyList<Mapping> configList = ConfigMappingBySheetNameAndFieldName.GetConfigList("WeaponConf", "WeaponType", true);
		if (configList != null)
		{
			foreach (Mapping mapping in configList)
			{
				if (typeId == mapping.Value)
				{
					return mapping.Icon;
				}
			}
		}
		return null;
	}

	// Token: 0x06018392 RID: 99218 RVA: 0x0062A7F4 File Offset: 0x006289F4
	[NullableContext(2)]
	public IReadOnlyList<WeaponBreach> GetWeaponBreachList(int breachId)
	{
		return ConfigWeaponBreachByBreachId.GetConfigList(breachId, true);
	}

	// Token: 0x06018393 RID: 99219 RVA: 0x0062A7FD File Offset: 0x006289FD
	[NullableContext(2)]
	public IReadOnlyList<WeaponLevel> GetWeaponLevelList(int levelId)
	{
		return ConfigWeaponLevelByLevelId.GetConfigList(levelId, true);
	}

	// Token: 0x06018394 RID: 99220 RVA: 0x0062A806 File Offset: 0x00628A06
	public WeaponLevel? GetWeaponLevelConfig(int levelId, int level)
	{
		return ConfigWeaponLevelByLevelIdAndLevel.GetConfig(levelId, level, true);
	}

	// Token: 0x06018395 RID: 99221 RVA: 0x0062A810 File Offset: 0x00628A10
	public WeaponBreach? GetWeaponBreach(int breachId, int breachLevel)
	{
		return ConfigWeaponBreachByBreachIdAndLevel.GetConfig(breachId, breachLevel, true);
	}

	// Token: 0x06018396 RID: 99222 RVA: 0x0062A81C File Offset: 0x00628A1C
	public int GetWeaponLevelLimit(int qualityId)
	{
		WeaponQualityInfo? config = ConfigWeaponQualityInfoById.GetConfig(qualityId, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().LevelLimit;
	}

	// Token: 0x06018397 RID: 99223 RVA: 0x0062A84B File Offset: 0x00628A4B
	public WeaponExpItem? GetWeaponExpItemConfig(int itemId)
	{
		return ConfigWeaponExpItemById.GetConfig(itemId, true);
	}

	// Token: 0x06018398 RID: 99224 RVA: 0x0062A854 File Offset: 0x00628A54
	public WeaponQualityInfo? GetWeaponQualityInfo(int qualityId)
	{
		return ConfigWeaponQualityInfoById.GetConfig(qualityId, true);
	}

	// Token: 0x06018399 RID: 99225 RVA: 0x0062A860 File Offset: 0x00628A60
	public float GetWeaponLevelUpCostRatio()
	{
		return (float)ConfigCommonParamById.GetIntConfig("WeaponLevelUpCoinCost").GetValueOrDefault() / 1000f;
	}

	// Token: 0x0601839A RID: 99226 RVA: 0x0062A888 File Offset: 0x00628A88
	public float GetWeaponExpCoefficient()
	{
		return (float)ConfigCommonParamById.GetIntConfig("WeaponStrengthenExpCost").GetValueOrDefault() / 1000f;
	}

	// Token: 0x0601839B RID: 99227 RVA: 0x0062A8B0 File Offset: 0x00628AB0
	public int GetWeaponQualityCheck()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_strengthen_panel_restrain1").GetValueOrDefault();
	}

	// Token: 0x0601839C RID: 99228 RVA: 0x0062A8D0 File Offset: 0x00628AD0
	public int GetWeaponLevelCheck()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_strengthen_panel_restrain2").GetValueOrDefault();
	}

	// Token: 0x0601839D RID: 99229 RVA: 0x0062A8F0 File Offset: 0x00628AF0
	public int GetWeaponResonanceCheck()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_quick_strengthen_restrain_num").GetValueOrDefault();
	}

	// Token: 0x0601839E RID: 99230 RVA: 0x0062A910 File Offset: 0x00628B10
	public int GetMaterialItemMaxCount()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_strengthen_num_limit").GetValueOrDefault();
	}

	// Token: 0x0601839F RID: 99231 RVA: 0x0062A92F File Offset: 0x00628B2F
	public QualityInfo? GetItemQuality(int qualityId)
	{
		return ConfigQualityInfoById.GetConfig(qualityId, true);
	}

	// Token: 0x060183A0 RID: 99232 RVA: 0x0062A938 File Offset: 0x00628B38
	public WeaponModelTransform? GetWeaponModelTransformData(int transformId)
	{
		return ConfigWeaponModelTransformById.GetConfig(transformId, true);
	}

	// Token: 0x060183A1 RID: 99233 RVA: 0x0062A941 File Offset: 0x00628B41
	public TrialWeaponInfo? GetTrialWeaponConfig(int id)
	{
		return ConfigTrialWeaponInfoById.GetConfig(id, true);
	}

	// Token: 0x060183A2 RID: 99234 RVA: 0x0062A94A File Offset: 0x00628B4A
	[NullableContext(2)]
	public List<WeaponConf> GetWeaponForHandBook()
	{
		IReadOnlyList<WeaponConf> configList = ConfigWeaponConfByIsShow.GetConfigList(true, true);
		if (configList == null)
		{
			return null;
		}
		return configList.ToList<WeaponConf>();
	}

	// Token: 0x060183A3 RID: 99235 RVA: 0x0062A95E File Offset: 0x00628B5E
	[NullableContext(2)]
	public List<WeaponSkin> GetWeaponSkinForHandBook()
	{
		IReadOnlyList<WeaponSkin> configList = ConfigWeaponSkinByIsShow.GetConfigList(true, true);
		if (configList == null)
		{
			return null;
		}
		return configList.ToList<WeaponSkin>();
	}

	// Token: 0x060183A4 RID: 99236 RVA: 0x0062A974 File Offset: 0x00628B74
	public WeaponSkin GetWeaponSkinConfig(int id)
	{
		return ConfigWeaponSkinById.GetConfig(id, true).Value;
	}

	// Token: 0x060183A5 RID: 99237 RVA: 0x0062A990 File Offset: 0x00628B90
	[NullableContext(2)]
	public List<WeaponExpItem> GetWeaponExpItemList()
	{
		IReadOnlyList<WeaponExpItem> configList = ConfigWeaponExpItemAll.GetConfigList(true);
		if (configList == null)
		{
			return null;
		}
		return configList.ToList<WeaponExpItem>();
	}

	// Token: 0x060183A6 RID: 99238 RVA: 0x0062A9A3 File Offset: 0x00628BA3
	protected override bool OnClear()
	{
		this.WeaponConfigMap.Clear();
		this.WeaponExpItemMap.Clear();
		this.WeaponQualityInfoMap.Clear();
		this.TrialWeaponInfoMap.Clear();
		return true;
	}

	// Token: 0x170020A9 RID: 8361
	// (get) Token: 0x060183A7 RID: 99239 RVA: 0x0062A9D2 File Offset: 0x00628BD2
	public static WeaponConfig Instance
	{
		get
		{
			return WeaponConfig._Instance;
		}
	}

	// Token: 0x060183A8 RID: 99240 RVA: 0x0062A9D9 File Offset: 0x00628BD9
	public static WeaponConfig GetOrCreateInstance()
	{
		if (WeaponConfig._Instance == null)
		{
			WeaponConfig.CreateInstance();
		}
		return WeaponConfig._Instance;
	}

	// Token: 0x060183A9 RID: 99241 RVA: 0x0062A9ED File Offset: 0x00628BED
	public static bool CreateInstance()
	{
		if (WeaponConfig._Instance != null)
		{
			return true;
		}
		WeaponConfig._Instance = new WeaponConfig();
		return true;
	}

	// Token: 0x060183AA RID: 99242 RVA: 0x0062AA03 File Offset: 0x00628C03
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060183AB RID: 99243 RVA: 0x0062AA05 File Offset: 0x00628C05
	public static void ResetStaticDefaultValue()
	{
		WeaponConfig._Instance = null;
	}

	// Token: 0x060183AC RID: 99244 RVA: 0x0062AA0D File Offset: 0x00628C0D
	static WeaponConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponConfig.CreateStaticDefaultValue), new Action(WeaponConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B409 RID: 46089
	private readonly Dictionary<int, WeaponConf> WeaponConfigMap = new Dictionary<int, WeaponConf>();

	// Token: 0x0400B40A RID: 46090
	private readonly Dictionary<int, WeaponExpItem> WeaponExpItemMap = new Dictionary<int, WeaponExpItem>();

	// Token: 0x0400B40B RID: 46091
	private readonly Dictionary<int, WeaponQualityInfo> WeaponQualityInfoMap = new Dictionary<int, WeaponQualityInfo>();

	// Token: 0x0400B40C RID: 46092
	private readonly Dictionary<int, TrialWeaponInfo> TrialWeaponInfoMap = new Dictionary<int, TrialWeaponInfo>();

	// Token: 0x0400B40D RID: 46093
	[Nullable(2)]
	private static WeaponConfig _Instance;
}
