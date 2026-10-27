using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001C75 RID: 7285
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class GachaConfig : ConfigBase
{
	// Token: 0x0600DB9C RID: 56220 RVA: 0x00331BC3 File Offset: 0x0032FDC3
	public int? PrimaryCurrency()
	{
		return ConfigCommonParamById.GetIntConfig("PrimaryCurrency");
	}

	// Token: 0x0600DB9D RID: 56221 RVA: 0x00331BCF File Offset: 0x0032FDCF
	public int? SecondCurrency()
	{
		return ConfigCommonParamById.GetIntConfig("SecondCurrency");
	}

	// Token: 0x0600DB9E RID: 56222 RVA: 0x00331BDB File Offset: 0x0032FDDB
	public float? GachaRecordActiveAlpha()
	{
		return ConfigCommonParamById.GetFloatConfig("GachaRecordActiveAlpha");
	}

	// Token: 0x0600DB9F RID: 56223 RVA: 0x00331BE7 File Offset: 0x0032FDE7
	public float? GachaRecordNoActiveAlpha()
	{
		return ConfigCommonParamById.GetFloatConfig("GachaRecordNoActiveAlpha");
	}

	// Token: 0x0600DBA0 RID: 56224 RVA: 0x00331BF3 File Offset: 0x0032FDF3
	public int? GetGachaResultDelay()
	{
		return ConfigCommonParamById.GetIntConfig("GachaResultDelay");
	}

	// Token: 0x0600DBA1 RID: 56225 RVA: 0x00331BFF File Offset: 0x0032FDFF
	public Gacha? GetGachaConfig(int gachaId)
	{
		return ConfigGachaById.GetConfig(gachaId, true);
	}

	// Token: 0x0600DBA2 RID: 56226 RVA: 0x00331C08 File Offset: 0x0032FE08
	public IReadOnlyList<Gacha> GetGachaList()
	{
		return ConfigGachaAll.GetConfigList(true);
	}

	// Token: 0x0600DBA3 RID: 56227 RVA: 0x00331C10 File Offset: 0x0032FE10
	public GachaPool? GetGachaPoolConfig(int gachaPoolId)
	{
		return ConfigGachaPoolById.GetConfig(gachaPoolId, true);
	}

	// Token: 0x0600DBA4 RID: 56228 RVA: 0x00331C19 File Offset: 0x0032FE19
	public InventoryDefine.EItemDataType GetItemIdType(int itemId)
	{
		return InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
	}

	// Token: 0x0600DBA5 RID: 56229 RVA: 0x00331C2B File Offset: 0x0032FE2B
	public GachaEffectConfig? GetGachaEffectConfigByTimesAndQuality(int times, int quality)
	{
		return ConfigGachaEffectConfigByTimesAndQuality.GetConfig(times, quality, true);
	}

	// Token: 0x0600DBA6 RID: 56230 RVA: 0x00331C38 File Offset: 0x0032FE38
	public string GetTextIdByType(GachaDefine.EAwardType awardType)
	{
		string p0Id;
		if (!GachaDefine.textKeyMap.TryGetValue(awardType, out p0Id))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "无法找到此奖品的文本Id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("awardType", awardType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		if (ConfigTextById.GetConfig(p0Id, true) == null)
		{
			return null;
		}
		Text? text;
		return text.GetValueOrDefault().TextContent;
	}

	// Token: 0x0600DBA7 RID: 56231 RVA: 0x00331CA6 File Offset: 0x0032FEA6
	public RoleQualityInfo? GetRoleQualityConfig(int qualityId)
	{
		return ConfigRoleQualityInfoById.GetConfig(qualityId, true);
	}

	// Token: 0x0600DBA8 RID: 56232 RVA: 0x00331CB0 File Offset: 0x0032FEB0
	public RoleInfo? GetRoleInfoById(int itemId)
	{
		InventoryConfig instance = InventoryConfig.Instance;
		if (instance.GetItemDataTypeByConfigId(new int?(itemId)) == InventoryDefine.EItemDataType.RoleItem)
		{
			return RoleConfig.Instance.GetRoleConfig(itemId);
		}
		ItemConfig itemConfigData = instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return null;
		}
		int id;
		if (!itemConfigData.Parameters.TryGetValue(5, out id))
		{
			return null;
		}
		return RoleConfig.Instance.GetRoleConfig(id);
	}

	// Token: 0x0600DBA9 RID: 56233 RVA: 0x00331D18 File Offset: 0x0032FF18
	public string GetGachaPoolNameId(int gachaPoolId)
	{
		GachaViewInfo? gachaViewInfo = this.GetGachaViewInfo(gachaPoolId);
		if (gachaViewInfo == null)
		{
			return null;
		}
		return gachaViewInfo.GetValueOrDefault().SummaryTitle;
	}

	// Token: 0x0600DBAA RID: 56234 RVA: 0x00331D48 File Offset: 0x0032FF48
	public GachaDefine.EGachaViewType? GetGachaViewType(int gachaPoolId)
	{
		GachaViewInfo? gachaViewInfo = this.GetGachaViewInfo(gachaPoolId);
		if (gachaViewInfo == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "奖池界面信息配置为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gachaPoolId", gachaPoolId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new GachaDefine.EGachaViewType?((GachaDefine.EGachaViewType)gachaViewInfo.Value.Type);
	}

	// Token: 0x0600DBAB RID: 56235 RVA: 0x00331DB4 File Offset: 0x0032FFB4
	public GachaViewInfo? GetGachaViewInfo(int gachaPoolId)
	{
		GachaViewInfo? config = ConfigGachaViewInfoById.GetConfig(gachaPoolId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "奖池界面信息配置为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gachaPoolId", gachaPoolId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0600DBAC RID: 56236 RVA: 0x00331E04 File Offset: 0x00330004
	public GachaTextureInfo? GetGachaTextureInfo(int itemId)
	{
		GachaTextureInfo? config = ConfigGachaTextureInfoById.GetConfig(itemId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "抽卡贴图信息表没有配置";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config;
	}

	// Token: 0x0600DBAD RID: 56237 RVA: 0x00331E54 File Offset: 0x00330054
	public string GetGachaElementTexturePath(int elementId)
	{
		ElementInfo? config = ConfigElementInfoById.GetConfig(elementId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().Icon2;
	}

	// Token: 0x0600DBAE RID: 56238 RVA: 0x00331E84 File Offset: 0x00330084
	public string GetGachaElementSpritePath(int elementId)
	{
		ElementInfo? config = ConfigElementInfoById.GetConfig(elementId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().GachaSpritePath;
	}

	// Token: 0x0600DBAF RID: 56239 RVA: 0x00331EB3 File Offset: 0x003300B3
	public GachaSequenceConfig? GetGachaSequenceConfigById(int id)
	{
		return ConfigGachaSequenceConfigById.GetConfig(id, true);
	}

	// Token: 0x0600DBB0 RID: 56240 RVA: 0x00331EBC File Offset: 0x003300BC
	public GachaWeaponSeqConfig? GetGachaWeaponSeqConfigById(int id)
	{
		return ConfigGachaWeaponSeqConfigById.GetConfig(id, true);
	}

	// Token: 0x0600DBB1 RID: 56241 RVA: 0x00331EC5 File Offset: 0x003300C5
	public GachaWeaponTransform? GetGachaWeaponTransformConfig(int id)
	{
		return ConfigGachaWeaponTransformById.GetConfig(id, true);
	}

	// Token: 0x0600DBB2 RID: 56242 RVA: 0x00331ECE File Offset: 0x003300CE
	public GachaViewTypeInfo? GetGachaViewTypeConfig(int type)
	{
		return ConfigGachaViewTypeInfoByType.GetConfig(type, true);
	}

	// Token: 0x0600DBB3 RID: 56243 RVA: 0x00331ED8 File Offset: 0x003300D8
	public int GetShopIdByGachaItemId(int gachaItemId)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("GachaItemIdToShopId");
		if (intArrayConfig == null || intArrayConfig.Count == 0)
		{
			Log.Instance.Error(ELogModule.Gacha, ELogAuthor.LZK, "GachaItemIdToShopId配置为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		for (int i = 0; i < intArrayConfig.Count; i += 2)
		{
			if (intArrayConfig[i] == gachaItemId)
			{
				return intArrayConfig[i + 1];
			}
		}
		return 0;
	}

	// Token: 0x0600DBB4 RID: 56244 RVA: 0x00331F44 File Offset: 0x00330144
	[NullableContext(1)]
	public IReadOnlyList<int> GetGachaRolePreviewTypeList()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("GachaRolePreviewTypeList");
		return intArrayConfig ?? new List<int>();
	}

	// Token: 0x0600DBB5 RID: 56245 RVA: 0x00331F68 File Offset: 0x00330168
	[NullableContext(1)]
	public IReadOnlyList<int> GetGachaWeaponPreviewTypeList()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("GachaWeaponPreviewTypeList");
		return intArrayConfig ?? new List<int>();
	}

	// Token: 0x170011E0 RID: 4576
	// (get) Token: 0x0600DBB6 RID: 56246 RVA: 0x00331F8A File Offset: 0x0033018A
	[Nullable(1)]
	public static GachaConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return GachaConfig._Instance;
		}
	}

	// Token: 0x0600DBB7 RID: 56247 RVA: 0x00331F91 File Offset: 0x00330191
	[NullableContext(1)]
	public static GachaConfig GetOrCreateInstance()
	{
		if (GachaConfig._Instance == null)
		{
			GachaConfig.CreateInstance();
		}
		return GachaConfig._Instance;
	}

	// Token: 0x0600DBB8 RID: 56248 RVA: 0x00331FA5 File Offset: 0x003301A5
	public static bool CreateInstance()
	{
		if (GachaConfig._Instance != null)
		{
			return true;
		}
		GachaConfig._Instance = new GachaConfig();
		return true;
	}

	// Token: 0x0600DBB9 RID: 56249 RVA: 0x00331FBB File Offset: 0x003301BB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DBBA RID: 56250 RVA: 0x00331FBD File Offset: 0x003301BD
	public static void ResetStaticDefaultValue()
	{
		GachaConfig._Instance = null;
	}

	// Token: 0x0600DBBB RID: 56251 RVA: 0x00331FC5 File Offset: 0x003301C5
	static GachaConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaConfig.CreateStaticDefaultValue), new Action(GachaConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040064C5 RID: 25797
	private static GachaConfig _Instance;
}
