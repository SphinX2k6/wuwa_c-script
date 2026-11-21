using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000ECB RID: 3787
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DangoAbyssConfig : ConfigBase
{
	// Token: 0x06009782 RID: 38786 RVA: 0x002CEFF5 File Offset: 0x002CD1F5
	public AbyssInst? GetDangoAbyssInstById(int id)
	{
		return ConfigAbyssInstById.GetConfig(id, true);
	}

	// Token: 0x06009783 RID: 38787 RVA: 0x002CEFFE File Offset: 0x002CD1FE
	public AbyssInst? GetDangoAbyssInstByInstId(int id)
	{
		return ConfigAbyssInstByInstId.GetConfig(id, true);
	}

	// Token: 0x06009784 RID: 38788 RVA: 0x002CF007 File Offset: 0x002CD207
	public IReadOnlyList<AbyssInst> GetDangoAbyssInstListByActivityId(int activityId)
	{
		return ConfigAbyssInstByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x06009785 RID: 38789 RVA: 0x002CF010 File Offset: 0x002CD210
	public AbyssReward? GetAbyssRewardById(int id)
	{
		return ConfigAbyssRewardById.GetConfig(id, true);
	}

	// Token: 0x06009786 RID: 38790 RVA: 0x002CF019 File Offset: 0x002CD219
	public IReadOnlyList<AbyssReward> GetAllAbyssReward()
	{
		return ConfigAbyssRewardAll.GetConfigList(true);
	}

	// Token: 0x06009787 RID: 38791 RVA: 0x002CF021 File Offset: 0x002CD221
	public AbyssRewardType? GetAbyssRewardTypeById(int id)
	{
		return ConfigAbyssRewardTypeById.GetConfig(id, true);
	}

	// Token: 0x06009788 RID: 38792 RVA: 0x002CF02A File Offset: 0x002CD22A
	public AbyssRoom? GetDangoAbyssRoomById(int id)
	{
		return ConfigAbyssRoomById.GetConfig(id, true);
	}

	// Token: 0x06009789 RID: 38793 RVA: 0x002CF033 File Offset: 0x002CD233
	public AbyssLittleRole? GetDangoRoleById(int id)
	{
		return ConfigAbyssLittleRoleById.GetConfig(id, true);
	}

	// Token: 0x0600978A RID: 38794 RVA: 0x002CF03C File Offset: 0x002CD23C
	public IReadOnlyList<AbyssLittleRole> GetAllDangoRole()
	{
		return ConfigAbyssLittleRoleAll.GetConfigList(true);
	}

	// Token: 0x0600978B RID: 38795 RVA: 0x002CF044 File Offset: 0x002CD244
	public AbyssRoleLevel? GetDangoLevelConfigByLevelAndGroupId(int level, int groupId)
	{
		return ConfigAbyssRoleLevelByLevelAndGroupId.GetConfig(level, groupId, true);
	}

	// Token: 0x0600978C RID: 38796 RVA: 0x002CF04E File Offset: 0x002CD24E
	public IReadOnlyList<AbyssRoleLevel> GetDangoLevelConfigByGroupId(int groupId)
	{
		return ConfigAbyssRoleLevelByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600978D RID: 38797 RVA: 0x002CF058 File Offset: 0x002CD258
	public AbyssItem? GetDangoItemById(int id)
	{
		if (id <= 0)
		{
			return null;
		}
		return ConfigAbyssItemById.GetConfig(id, true);
	}

	// Token: 0x0600978E RID: 38798 RVA: 0x002CF07C File Offset: 0x002CD27C
	public DangoAbyssDefine.ESlotType GetSlotTypeByIndex(int slotIndex)
	{
		AbyssRoleSlot? config = ConfigAbyssRoleSlotById.GetConfig(slotIndex, true);
		if (config != null)
		{
			return (DangoAbyssDefine.ESlotType)config.Value.SlotType;
		}
		return DangoAbyssDefine.ESlotType.Normal;
	}

	// Token: 0x0600978F RID: 38799 RVA: 0x002CF0AB File Offset: 0x002CD2AB
	public AbyssCastDesc? GetDangoCastDescById(int id)
	{
		return ConfigAbyssCastDescById.GetConfig(id, true);
	}

	// Token: 0x06009790 RID: 38800 RVA: 0x002CF0B4 File Offset: 0x002CD2B4
	public AbyssPluginPropDesc? GetDangoPluginPropDescById(int id)
	{
		return ConfigAbyssPluginPropDescById.GetConfig(id, true);
	}

	// Token: 0x06009791 RID: 38801 RVA: 0x002CF0BD File Offset: 0x002CD2BD
	public AbyssQuality? GetAbyssQualityById(int id)
	{
		return ConfigAbyssQualityById.GetConfig(id, true);
	}

	// Token: 0x06009792 RID: 38802 RVA: 0x002CF0C8 File Offset: 0x002CD2C8
	public AbyssQuality? GetAbyssQualityByPluginItemId(int itemId)
	{
		AbyssItem? dangoItemById = this.GetDangoItemById(itemId);
		if (dangoItemById == null)
		{
			return null;
		}
		return ConfigAbyssQualityById.GetConfig(dangoItemById.Value.QualityId, true);
	}

	// Token: 0x06009793 RID: 38803 RVA: 0x002CF105 File Offset: 0x002CD305
	public int? GetWorldInstanceId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoWorldInstanceId");
	}

	// Token: 0x06009794 RID: 38804 RVA: 0x002CF111 File Offset: 0x002CD311
	public int? GetWorldInstanceEntranceId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoWorldInstanceEntranceId");
	}

	// Token: 0x06009795 RID: 38805 RVA: 0x002CF11D File Offset: 0x002CD31D
	public int? GetWorldTeleportId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoSmallWorldTeleportId");
	}

	// Token: 0x06009796 RID: 38806 RVA: 0x002CF129 File Offset: 0x002CD329
	public IReadOnlyList<int> GetSmallWorldInsIdList()
	{
		return ConfigCommonParamById.GetIntArrayConfig("DangoSmallWorldInsId");
	}

	// Token: 0x06009797 RID: 38807 RVA: 0x002CF135 File Offset: 0x002CD335
	public int? GetAbyssKeyItemId()
	{
		return ConfigCommonParamById.GetIntConfig("AbyssKeyId");
	}

	// Token: 0x06009798 RID: 38808 RVA: 0x002CF141 File Offset: 0x002CD341
	public string GetAbyssLimitRewardTexture()
	{
		return ConfigCommonParamById.GetStringConfig("DangoAbyssLimitRewardTexture");
	}

	// Token: 0x06009799 RID: 38809 RVA: 0x002CF14D File Offset: 0x002CD34D
	public int? GetAbyssLimitRewardRewardId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoAbyssLimitRewardId");
	}

	// Token: 0x0600979A RID: 38810 RVA: 0x002CF159 File Offset: 0x002CD359
	public AbyssActivity? GetAbyssActivityData(int activityId)
	{
		return ConfigAbyssActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x0600979B RID: 38811 RVA: 0x002CF164 File Offset: 0x002CD364
	public AbyssRoute? GetAbyssRouteByRouteIdAndFloorId(int routeId, int floorId)
	{
		IReadOnlyList<AbyssRoute> configList = ConfigAbyssRouteByRouterAndFloor.GetConfigList(routeId, floorId, true);
		if (configList == null || configList.Count <= 0)
		{
			return null;
		}
		return new AbyssRoute?(configList[0]);
	}

	// Token: 0x0600979C RID: 38812 RVA: 0x002CF19C File Offset: 0x002CD39C
	public AbyssRewardTab? GetAbyssRewardTabById(int id)
	{
		return ConfigAbyssRewardTabById.GetConfig(id, true);
	}

	// Token: 0x0600979D RID: 38813 RVA: 0x002CF1A8 File Offset: 0x002CD3A8
	public int GetAbyssMarkByActivityId(int id)
	{
		return ConfigAbyssActivityByActivityId.GetConfig(id, true).Value.MarkId;
	}

	// Token: 0x0600979E RID: 38814 RVA: 0x002CF1CC File Offset: 0x002CD3CC
	public AbyssSettle? GetAbyssSettleById(int id)
	{
		return ConfigAbyssSettleById.GetConfig(id, true);
	}

	// Token: 0x0600979F RID: 38815 RVA: 0x002CF1D8 File Offset: 0x002CD3D8
	public AbyssSynthesis? GetAbyssSynthesisByQualityId(int qualityId)
	{
		IReadOnlyList<AbyssSynthesis> configList = ConfigAbyssSynthesisAll.GetConfigList(true);
		if (configList == null)
		{
			return null;
		}
		foreach (AbyssSynthesis value in configList)
		{
			if (value.Quality == qualityId)
			{
				return new AbyssSynthesis?(value);
			}
		}
		return null;
	}

	// Token: 0x060097A0 RID: 38816 RVA: 0x002CF24C File Offset: 0x002CD44C
	public int GetDangoShopAngryTime()
	{
		return ConfigCommonParamById.GetIntConfig("DangoShopAngryTime").GetValueOrDefault();
	}

	// Token: 0x060097A1 RID: 38817 RVA: 0x002CF26C File Offset: 0x002CD46C
	public int GetDangoShopBuyTime()
	{
		return ConfigCommonParamById.GetIntConfig("DangoShopBuyTime").GetValueOrDefault();
	}

	// Token: 0x060097A2 RID: 38818 RVA: 0x002CF28C File Offset: 0x002CD48C
	public int GetDangoShopClickTime()
	{
		return ConfigCommonParamById.GetIntConfig("DangoShopClickTime").GetValueOrDefault();
	}

	// Token: 0x060097A3 RID: 38819 RVA: 0x002CF2AC File Offset: 0x002CD4AC
	public int GetBadDangoMeshId()
	{
		return ConfigCommonParamById.GetIntConfig("BadDangoMesh").GetValueOrDefault();
	}

	// Token: 0x060097A4 RID: 38820 RVA: 0x002CF2CB File Offset: 0x002CD4CB
	public string GetBadDangoStandAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoStandAnimation");
	}

	// Token: 0x060097A5 RID: 38821 RVA: 0x002CF2D7 File Offset: 0x002CD4D7
	public string GetBadDangoBuyAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoBuyAnimation");
	}

	// Token: 0x060097A6 RID: 38822 RVA: 0x002CF2E3 File Offset: 0x002CD4E3
	public string GetBadDangoBadDangoPinkAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoPinkAnimation");
	}

	// Token: 0x060097A7 RID: 38823 RVA: 0x002CF2EF File Offset: 0x002CD4EF
	public string GetBadDangoBadDangoPinkOverAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoPinkOverAnimation");
	}

	// Token: 0x060097A8 RID: 38824 RVA: 0x002CF2FC File Offset: 0x002CD4FC
	public FTransform GetBadDangoTransform()
	{
		FRotator badDangoRotator = this.GetBadDangoRotator();
		FVector badDangoLocation = this.GetBadDangoLocation();
		FVector badDangoZoom = this.GetBadDangoZoom();
		return new FTransform(ref badDangoRotator, ref badDangoLocation, ref badDangoZoom);
	}

	// Token: 0x060097A9 RID: 38825 RVA: 0x002CF32C File Offset: 0x002CD52C
	private FRotator GetBadDangoRotator()
	{
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("BadDangoRotator");
		FRotator result = new FRotator();
		if (floatArrayConfig.Count == 3)
		{
			result.Roll = floatArrayConfig[0];
			result.Pitch = floatArrayConfig[1];
			result.Yaw = floatArrayConfig[2];
		}
		return result;
	}

	// Token: 0x060097AA RID: 38826 RVA: 0x002CF380 File Offset: 0x002CD580
	private FVector GetBadDangoZoom()
	{
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("BadDangoZoom");
		FVector result = new FVector();
		if (floatArrayConfig.Count == 3)
		{
			result.X = floatArrayConfig[0];
			result.Y = floatArrayConfig[1];
			result.Z = floatArrayConfig[2];
		}
		return result;
	}

	// Token: 0x060097AB RID: 38827 RVA: 0x002CF3D4 File Offset: 0x002CD5D4
	private FVector GetBadDangoLocation()
	{
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("BadDangoLocation");
		FVector result = new FVector();
		if (floatArrayConfig.Count == 3)
		{
			result.X = floatArrayConfig[0];
			result.Y = floatArrayConfig[1];
			result.Z = floatArrayConfig[2];
		}
		return result;
	}

	// Token: 0x060097AC RID: 38828 RVA: 0x002CF428 File Offset: 0x002CD628
	public string GetItemBgDesc(int itemId)
	{
		AbyssItem? dangoItemById = this.GetDangoItemById(itemId);
		string bgDescription = dangoItemById.Value.BgDescription;
		if (bgDescription == "")
		{
			return "";
		}
		StringArray? stringArray = dangoItemById.Value.LevelDescStrArray(0);
		if (stringArray != null)
		{
			StringArray value = stringArray.Value;
			int arrayStringLength = value.ArrayStringLength;
			string[] array = new string[arrayStringLength];
			for (int i = 0; i < arrayStringLength; i++)
			{
				array[i] = value.ArrayString(i);
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(bgDescription, null), array);
		}
		return "";
	}

	// Token: 0x17001071 RID: 4209
	// (get) Token: 0x060097AD RID: 38829 RVA: 0x002CF4C8 File Offset: 0x002CD6C8
	public static DangoAbyssConfig Instance
	{
		get
		{
			return DangoAbyssConfig._Instance;
		}
	}

	// Token: 0x060097AE RID: 38830 RVA: 0x002CF4CF File Offset: 0x002CD6CF
	public static DangoAbyssConfig GetOrCreateInstance()
	{
		if (DangoAbyssConfig._Instance == null)
		{
			DangoAbyssConfig.CreateInstance();
		}
		return DangoAbyssConfig._Instance;
	}

	// Token: 0x060097AF RID: 38831 RVA: 0x002CF4E3 File Offset: 0x002CD6E3
	public static bool CreateInstance()
	{
		if (DangoAbyssConfig._Instance != null)
		{
			return true;
		}
		DangoAbyssConfig._Instance = new DangoAbyssConfig();
		return true;
	}

	// Token: 0x060097B0 RID: 38832 RVA: 0x002CF4F9 File Offset: 0x002CD6F9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060097B1 RID: 38833 RVA: 0x002CF4FB File Offset: 0x002CD6FB
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssConfig._Instance = null;
	}

	// Token: 0x060097B2 RID: 38834 RVA: 0x002CF503 File Offset: 0x002CD703
	static DangoAbyssConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssConfig.CreateStaticDefaultValue), new Action(DangoAbyssConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005B15 RID: 23317
	[Nullable(2)]
	private static DangoAbyssConfig _Instance;
}
