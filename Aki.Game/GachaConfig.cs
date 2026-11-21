using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001134 RID: 4404
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class GachaConfig : ConfigBase
{
	// Token: 0x0600AFB2 RID: 44978 RVA: 0x0033D00F File Offset: 0x0033B20F
	public int? PrimaryCurrency()
	{
		return ConfigCommonParamById.GetIntConfig("PrimaryCurrency");
	}

	// Token: 0x0600AFB3 RID: 44979 RVA: 0x0033D01B File Offset: 0x0033B21B
	public int? SecondCurrency()
	{
		return ConfigCommonParamById.GetIntConfig("SecondCurrency");
	}

	// Token: 0x0600AFB4 RID: 44980 RVA: 0x0033D027 File Offset: 0x0033B227
	public float? GachaRecordActiveAlpha()
	{
		return ConfigCommonParamById.GetFloatConfig("GachaRecordActiveAlpha");
	}

	// Token: 0x0600AFB5 RID: 44981 RVA: 0x0033D033 File Offset: 0x0033B233
	public float? GachaRecordNoActiveAlpha()
	{
		return ConfigCommonParamById.GetFloatConfig("GachaRecordNoActiveAlpha");
	}

	// Token: 0x0600AFB6 RID: 44982 RVA: 0x0033D03F File Offset: 0x0033B23F
	public int? GetGachaResultDelay()
	{
		return ConfigCommonParamById.GetIntConfig("GachaResultDelay");
	}

	// Token: 0x0600AFB7 RID: 44983 RVA: 0x0033D04B File Offset: 0x0033B24B
	public Gacha? GetGachaConfig(int gachaId)
	{
		return ConfigGachaById.GetConfig(gachaId, true);
	}

	// Token: 0x0600AFB8 RID: 44984 RVA: 0x0033D054 File Offset: 0x0033B254
	public IReadOnlyList<Gacha> GetGachaList()
	{
		return ConfigGachaAll.GetConfigList(true);
	}

	// Token: 0x0600AFB9 RID: 44985 RVA: 0x0033D05C File Offset: 0x0033B25C
	public GachaPool? GetGachaPoolConfig(int gachaPoolId)
	{
		return ConfigGachaPoolById.GetConfig(gachaPoolId, true);
	}

	// Token: 0x0600AFBA RID: 44986 RVA: 0x0033D065 File Offset: 0x0033B265
	public InventoryDefine.EItemDataType GetItemIdType(int itemId)
	{
		return InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId));
	}

	// Token: 0x0600AFBB RID: 44987 RVA: 0x0033D077 File Offset: 0x0033B277
	public GachaEffectConfig? GetGachaEffectConfigByTimesAndQuality(int times, int quality)
	{
		return ConfigGachaEffectConfigByTimesAndQuality.GetConfig(times, quality, true);
	}

	// Token: 0x0600AFBC RID: 44988 RVA: 0x0033D084 File Offset: 0x0033B284
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

	// Token: 0x0600AFBD RID: 44989 RVA: 0x0033D0F2 File Offset: 0x0033B2F2
	public RoleQualityInfo? GetRoleQualityConfig(int qualityId)
	{
		return ConfigRoleQualityInfoById.GetConfig(qualityId, true);
	}

	// Token: 0x0600AFBE RID: 44990 RVA: 0x0033D0FC File Offset: 0x0033B2FC
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

	// Token: 0x0600AFBF RID: 44991 RVA: 0x0033D164 File Offset: 0x0033B364
	public string GetGachaPoolNameId(int gachaPoolId)
	{
		GachaViewInfo? gachaViewInfo = this.GetGachaViewInfo(gachaPoolId);
		if (gachaViewInfo == null)
		{
			return null;
		}
		return gachaViewInfo.GetValueOrDefault().SummaryTitle;
	}

	// Token: 0x0600AFC0 RID: 44992 RVA: 0x0033D194 File Offset: 0x0033B394
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

	// Token: 0x0600AFC1 RID: 44993 RVA: 0x0033D200 File Offset: 0x0033B400
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

	// Token: 0x0600AFC2 RID: 44994 RVA: 0x0033D250 File Offset: 0x0033B450
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

	// Token: 0x0600AFC3 RID: 44995 RVA: 0x0033D2A0 File Offset: 0x0033B4A0
	public string GetGachaElementTexturePath(int elementId)
	{
		ElementInfo? config = ConfigElementInfoById.GetConfig(elementId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().Icon2;
	}

	// Token: 0x0600AFC4 RID: 44996 RVA: 0x0033D2D0 File Offset: 0x0033B4D0
	public string GetGachaElementSpritePath(int elementId)
	{
		ElementInfo? config = ConfigElementInfoById.GetConfig(elementId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().GachaSpritePath;
	}

	// Token: 0x0600AFC5 RID: 44997 RVA: 0x0033D2FF File Offset: 0x0033B4FF
	public GachaSequenceConfig? GetGachaSequenceConfigById(int id)
	{
		return ConfigGachaSequenceConfigById.GetConfig(id, true);
	}

	// Token: 0x0600AFC6 RID: 44998 RVA: 0x0033D308 File Offset: 0x0033B508
	public GachaWeaponSeqConfig? GetGachaWeaponSeqConfigById(int id)
	{
		return ConfigGachaWeaponSeqConfigById.GetConfig(id, true);
	}

	// Token: 0x0600AFC7 RID: 44999 RVA: 0x0033D311 File Offset: 0x0033B511
	public GachaWeaponTransform? GetGachaWeaponTransformConfig(int id)
	{
		return ConfigGachaWeaponTransformById.GetConfig(id, true);
	}

	// Token: 0x0600AFC8 RID: 45000 RVA: 0x0033D31A File Offset: 0x0033B51A
	public GachaViewTypeInfo? GetGachaViewTypeConfig(int type)
	{
		return ConfigGachaViewTypeInfoByType.GetConfig(type, true);
	}

	// Token: 0x0600AFC9 RID: 45001 RVA: 0x0033D324 File Offset: 0x0033B524
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

	// Token: 0x0600AFCA RID: 45002 RVA: 0x0033D390 File Offset: 0x0033B590
	[NullableContext(1)]
	public IReadOnlyList<int> GetGachaRolePreviewTypeList()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("GachaRolePreviewTypeList");
		return intArrayConfig ?? new List<int>();
	}

	// Token: 0x0600AFCB RID: 45003 RVA: 0x0033D3B4 File Offset: 0x0033B5B4
	[NullableContext(1)]
	public IReadOnlyList<int> GetGachaWeaponPreviewTypeList()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("GachaWeaponPreviewTypeList");
		return intArrayConfig ?? new List<int>();
	}

	// Token: 0x17001206 RID: 4614
	// (get) Token: 0x0600AFCC RID: 45004 RVA: 0x0033D3D6 File Offset: 0x0033B5D6
	[Nullable(1)]
	public static GachaConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return GachaConfig._Instance;
		}
	}

	// Token: 0x0600AFCD RID: 45005 RVA: 0x0033D3DD File Offset: 0x0033B5DD
	[NullableContext(1)]
	public static GachaConfig GetOrCreateInstance()
	{
		if (GachaConfig._Instance == null)
		{
			GachaConfig.CreateInstance();
		}
		return GachaConfig._Instance;
	}

	// Token: 0x0600AFCE RID: 45006 RVA: 0x0033D3F1 File Offset: 0x0033B5F1
	public static bool CreateInstance()
	{
		if (GachaConfig._Instance != null)
		{
			return true;
		}
		GachaConfig._Instance = new GachaConfig();
		return true;
	}

	// Token: 0x0600AFCF RID: 45007 RVA: 0x0033D407 File Offset: 0x0033B607
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AFD0 RID: 45008 RVA: 0x0033D409 File Offset: 0x0033B609
	public static void ResetStaticDefaultValue()
	{
		GachaConfig._Instance = null;
	}

	// Token: 0x0600AFD1 RID: 45009 RVA: 0x0033D411 File Offset: 0x0033B611
	static GachaConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GachaConfig.CreateStaticDefaultValue), new Action(GachaConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006597 RID: 26007
	private static GachaConfig _Instance;
}
