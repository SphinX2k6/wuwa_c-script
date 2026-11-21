using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200225C RID: 8796
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class WeaponConfig : ConfigBase
{
	// Token: 0x06015C2B RID: 89131 RVA: 0x006505DD File Offset: 0x0064E7DD
	public WeaponConf? GetWeaponConfigByItemId(int itemId)
	{
		return ConfigWeaponConfByItemId.GetConfig(itemId, true);
	}

	// Token: 0x06015C2C RID: 89132 RVA: 0x006505E6 File Offset: 0x0064E7E6
	[return: Nullable(2)]
	public string GetWeaponName(string weaponNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(weaponNameId, null);
	}

	// Token: 0x06015C2D RID: 89133 RVA: 0x006505F0 File Offset: 0x0064E7F0
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

	// Token: 0x06015C2E RID: 89134 RVA: 0x0065068C File Offset: 0x0064E88C
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

	// Token: 0x06015C2F RID: 89135 RVA: 0x00650709 File Offset: 0x0064E909
	[return: Nullable(2)]
	public string GetWeaponResonanceDesc(string descId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(descId, null);
	}

	// Token: 0x06015C30 RID: 89136 RVA: 0x00650712 File Offset: 0x0064E912
	[return: Nullable(2)]
	public string GetWeaponResonanceName(string resonanceNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(resonanceNameId, null);
	}

	// Token: 0x06015C31 RID: 89137 RVA: 0x0065071C File Offset: 0x0064E91C
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

	// Token: 0x06015C32 RID: 89138 RVA: 0x0065075C File Offset: 0x0064E95C
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

	// Token: 0x06015C33 RID: 89139 RVA: 0x006507C8 File Offset: 0x0064E9C8
	[NullableContext(2)]
	public IReadOnlyList<WeaponBreach> GetWeaponBreachList(int breachId)
	{
		return ConfigWeaponBreachByBreachId.GetConfigList(breachId, true);
	}

	// Token: 0x06015C34 RID: 89140 RVA: 0x006507D1 File Offset: 0x0064E9D1
	[NullableContext(2)]
	public IReadOnlyList<WeaponLevel> GetWeaponLevelList(int levelId)
	{
		return ConfigWeaponLevelByLevelId.GetConfigList(levelId, true);
	}

	// Token: 0x06015C35 RID: 89141 RVA: 0x006507DA File Offset: 0x0064E9DA
	public WeaponLevel? GetWeaponLevelConfig(int levelId, int level)
	{
		return ConfigWeaponLevelByLevelIdAndLevel.GetConfig(levelId, level, true);
	}

	// Token: 0x06015C36 RID: 89142 RVA: 0x006507E4 File Offset: 0x0064E9E4
	public WeaponBreach? GetWeaponBreach(int breachId, int breachLevel)
	{
		return ConfigWeaponBreachByBreachIdAndLevel.GetConfig(breachId, breachLevel, true);
	}

	// Token: 0x06015C37 RID: 89143 RVA: 0x006507F0 File Offset: 0x0064E9F0
	public int GetWeaponLevelLimit(int qualityId)
	{
		WeaponQualityInfo? config = ConfigWeaponQualityInfoById.GetConfig(qualityId, true);
		if (config == null)
		{
			return 0;
		}
		return config.GetValueOrDefault().LevelLimit;
	}

	// Token: 0x06015C38 RID: 89144 RVA: 0x0065081F File Offset: 0x0064EA1F
	public WeaponExpItem? GetWeaponExpItemConfig(int itemId)
	{
		return ConfigWeaponExpItemById.GetConfig(itemId, true);
	}

	// Token: 0x06015C39 RID: 89145 RVA: 0x00650828 File Offset: 0x0064EA28
	public WeaponQualityInfo? GetWeaponQualityInfo(int qualityId)
	{
		return ConfigWeaponQualityInfoById.GetConfig(qualityId, true);
	}

	// Token: 0x06015C3A RID: 89146 RVA: 0x00650834 File Offset: 0x0064EA34
	public float GetWeaponLevelUpCostRatio()
	{
		return (float)ConfigCommonParamById.GetIntConfig("WeaponLevelUpCoinCost").GetValueOrDefault() / 1000f;
	}

	// Token: 0x06015C3B RID: 89147 RVA: 0x0065085C File Offset: 0x0064EA5C
	public float GetWeaponExpCoefficient()
	{
		return (float)ConfigCommonParamById.GetIntConfig("WeaponStrengthenExpCost").GetValueOrDefault() / 1000f;
	}

	// Token: 0x06015C3C RID: 89148 RVA: 0x00650884 File Offset: 0x0064EA84
	public int GetWeaponQualityCheck()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_strengthen_panel_restrain1").GetValueOrDefault();
	}

	// Token: 0x06015C3D RID: 89149 RVA: 0x006508A4 File Offset: 0x0064EAA4
	public int GetWeaponLevelCheck()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_strengthen_panel_restrain2").GetValueOrDefault();
	}

	// Token: 0x06015C3E RID: 89150 RVA: 0x006508C4 File Offset: 0x0064EAC4
	public int GetWeaponResonanceCheck()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_quick_strengthen_restrain_num").GetValueOrDefault();
	}

	// Token: 0x06015C3F RID: 89151 RVA: 0x006508E4 File Offset: 0x0064EAE4
	public int GetMaterialItemMaxCount()
	{
		return ConfigCommonParamById.GetIntConfig("weapon_strengthen_num_limit").GetValueOrDefault();
	}

	// Token: 0x06015C40 RID: 89152 RVA: 0x00650903 File Offset: 0x0064EB03
	public QualityInfo? GetItemQuality(int qualityId)
	{
		return ConfigQualityInfoById.GetConfig(qualityId, true);
	}

	// Token: 0x06015C41 RID: 89153 RVA: 0x0065090C File Offset: 0x0064EB0C
	public WeaponModelTransform? GetWeaponModelTransformData(int transformId)
	{
		return ConfigWeaponModelTransformById.GetConfig(transformId, true);
	}

	// Token: 0x06015C42 RID: 89154 RVA: 0x00650915 File Offset: 0x0064EB15
	public TrialWeaponInfo? GetTrialWeaponConfig(int id)
	{
		return ConfigTrialWeaponInfoById.GetConfig(id, true);
	}

	// Token: 0x06015C43 RID: 89155 RVA: 0x00650920 File Offset: 0x0064EB20
	[NullableContext(2)]
	public List<WeaponConf> GetWeaponForHandBook()
	{
		IReadOnlyList<WeaponConf> configList = ConfigWeaponConfByIsShow.GetConfigList(true, true);
		if (configList != null)
		{
			return new List<WeaponConf>(configList);
		}
		return null;
	}

	// Token: 0x06015C44 RID: 89156 RVA: 0x00650940 File Offset: 0x0064EB40
	[NullableContext(2)]
	public List<WeaponSkin> GetWeaponSkinForHandBook()
	{
		IReadOnlyList<WeaponSkin> configList = ConfigWeaponSkinByIsShow.GetConfigList(true, true);
		if (configList != null)
		{
			return new List<WeaponSkin>(configList);
		}
		return null;
	}

	// Token: 0x06015C45 RID: 89157 RVA: 0x00650960 File Offset: 0x0064EB60
	public WeaponSkin GetWeaponSkinConfig(int id)
	{
		return ConfigWeaponSkinById.GetConfig(id, true).Value;
	}

	// Token: 0x06015C46 RID: 89158 RVA: 0x0065097C File Offset: 0x0064EB7C
	[NullableContext(2)]
	public List<WeaponExpItem> GetWeaponExpItemList()
	{
		IReadOnlyList<WeaponExpItem> configList = ConfigWeaponExpItemAll.GetConfigList(true);
		if (configList != null)
		{
			return new List<WeaponExpItem>(configList);
		}
		return null;
	}

	// Token: 0x06015C47 RID: 89159 RVA: 0x0065099B File Offset: 0x0064EB9B
	protected override bool OnClear()
	{
		this.WeaponConfigMap.Clear();
		this.WeaponExpItemMap.Clear();
		this.WeaponQualityInfoMap.Clear();
		this.TrialWeaponInfoMap.Clear();
		return true;
	}

	// Token: 0x17002104 RID: 8452
	// (get) Token: 0x06015C48 RID: 89160 RVA: 0x006509CA File Offset: 0x0064EBCA
	public static WeaponConfig Instance
	{
		get
		{
			return WeaponConfig._Instance;
		}
	}

	// Token: 0x06015C49 RID: 89161 RVA: 0x006509D1 File Offset: 0x0064EBD1
	public static WeaponConfig GetOrCreateInstance()
	{
		if (WeaponConfig._Instance == null)
		{
			WeaponConfig.CreateInstance();
		}
		return WeaponConfig._Instance;
	}

	// Token: 0x06015C4A RID: 89162 RVA: 0x006509E5 File Offset: 0x0064EBE5
	public static bool CreateInstance()
	{
		if (WeaponConfig._Instance != null)
		{
			return true;
		}
		WeaponConfig._Instance = new WeaponConfig();
		return true;
	}

	// Token: 0x06015C4B RID: 89163 RVA: 0x006509FB File Offset: 0x0064EBFB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06015C4C RID: 89164 RVA: 0x006509FD File Offset: 0x0064EBFD
	public static void ResetStaticDefaultValue()
	{
		WeaponConfig._Instance = null;
	}

	// Token: 0x06015C4D RID: 89165 RVA: 0x00650A05 File Offset: 0x0064EC05
	static WeaponConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponConfig.CreateStaticDefaultValue), new Action(WeaponConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400B77E RID: 46974
	private readonly Dictionary<int, WeaponConf> WeaponConfigMap = new Dictionary<int, WeaponConf>();

	// Token: 0x0400B77F RID: 46975
	private readonly Dictionary<int, WeaponExpItem> WeaponExpItemMap = new Dictionary<int, WeaponExpItem>();

	// Token: 0x0400B780 RID: 46976
	private readonly Dictionary<int, WeaponQualityInfo> WeaponQualityInfoMap = new Dictionary<int, WeaponQualityInfo>();

	// Token: 0x0400B781 RID: 46977
	private readonly Dictionary<int, TrialWeaponInfo> TrialWeaponInfoMap = new Dictionary<int, TrialWeaponInfo>();

	// Token: 0x0400B782 RID: 46978
	[Nullable(2)]
	private static WeaponConfig _Instance;
}
