using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001A0C RID: 6668
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DangoAbyssConfig : ConfigBase
{
	// Token: 0x0600C372 RID: 50034 RVA: 0x002C3F85 File Offset: 0x002C2185
	public AbyssInst? GetDangoAbyssInstById(int id)
	{
		return ConfigAbyssInstById.GetConfig(id, true);
	}

	// Token: 0x0600C373 RID: 50035 RVA: 0x002C3F8E File Offset: 0x002C218E
	public AbyssInst? GetDangoAbyssInstByInstId(int id)
	{
		return ConfigAbyssInstByInstId.GetConfig(id, true);
	}

	// Token: 0x0600C374 RID: 50036 RVA: 0x002C3F97 File Offset: 0x002C2197
	public IReadOnlyList<AbyssInst> GetDangoAbyssInstListByActivityId(int activityId)
	{
		return ConfigAbyssInstByActivityId.GetConfigList(activityId, true);
	}

	// Token: 0x0600C375 RID: 50037 RVA: 0x002C3FA0 File Offset: 0x002C21A0
	public AbyssReward? GetAbyssRewardById(int id)
	{
		return ConfigAbyssRewardById.GetConfig(id, true);
	}

	// Token: 0x0600C376 RID: 50038 RVA: 0x002C3FA9 File Offset: 0x002C21A9
	public IReadOnlyList<AbyssReward> GetAllAbyssReward()
	{
		return ConfigAbyssRewardAll.GetConfigList(true);
	}

	// Token: 0x0600C377 RID: 50039 RVA: 0x002C3FB1 File Offset: 0x002C21B1
	public AbyssRewardType? GetAbyssRewardTypeById(int id)
	{
		return ConfigAbyssRewardTypeById.GetConfig(id, true);
	}

	// Token: 0x0600C378 RID: 50040 RVA: 0x002C3FBA File Offset: 0x002C21BA
	public AbyssRoom? GetDangoAbyssRoomById(int id)
	{
		return ConfigAbyssRoomById.GetConfig(id, true);
	}

	// Token: 0x0600C379 RID: 50041 RVA: 0x002C3FC3 File Offset: 0x002C21C3
	public AbyssLittleRole? GetDangoRoleById(int id)
	{
		return ConfigAbyssLittleRoleById.GetConfig(id, true);
	}

	// Token: 0x0600C37A RID: 50042 RVA: 0x002C3FCC File Offset: 0x002C21CC
	public IReadOnlyList<AbyssLittleRole> GetAllDangoRole()
	{
		return ConfigAbyssLittleRoleAll.GetConfigList(true);
	}

	// Token: 0x0600C37B RID: 50043 RVA: 0x002C3FD4 File Offset: 0x002C21D4
	public AbyssRoleLevel? GetDangoLevelConfigByLevelAndGroupId(int level, int groupId)
	{
		return ConfigAbyssRoleLevelByLevelAndGroupId.GetConfig(level, groupId, true);
	}

	// Token: 0x0600C37C RID: 50044 RVA: 0x002C3FDE File Offset: 0x002C21DE
	public IReadOnlyList<AbyssRoleLevel> GetDangoLevelConfigByGroupId(int groupId)
	{
		return ConfigAbyssRoleLevelByGroupId.GetConfigList(groupId, true);
	}

	// Token: 0x0600C37D RID: 50045 RVA: 0x002C3FE8 File Offset: 0x002C21E8
	public AbyssItem? GetDangoItemById(int id)
	{
		if (id <= 0)
		{
			return null;
		}
		return ConfigAbyssItemById.GetConfig(id, true);
	}

	// Token: 0x0600C37E RID: 50046 RVA: 0x002C400C File Offset: 0x002C220C
	public DangoAbyssDefine.ESlotType GetSlotTypeByIndex(int slotIndex)
	{
		AbyssRoleSlot? config = ConfigAbyssRoleSlotById.GetConfig(slotIndex, true);
		if (config != null)
		{
			return (DangoAbyssDefine.ESlotType)config.Value.SlotType;
		}
		return DangoAbyssDefine.ESlotType.Normal;
	}

	// Token: 0x0600C37F RID: 50047 RVA: 0x002C403B File Offset: 0x002C223B
	public AbyssCastDesc? GetDangoCastDescById(int id)
	{
		return ConfigAbyssCastDescById.GetConfig(id, true);
	}

	// Token: 0x0600C380 RID: 50048 RVA: 0x002C4044 File Offset: 0x002C2244
	public AbyssPluginPropDesc? GetDangoPluginPropDescById(int id)
	{
		return ConfigAbyssPluginPropDescById.GetConfig(id, true);
	}

	// Token: 0x0600C381 RID: 50049 RVA: 0x002C404D File Offset: 0x002C224D
	public AbyssQuality? GetAbyssQualityById(int id)
	{
		return ConfigAbyssQualityById.GetConfig(id, true);
	}

	// Token: 0x0600C382 RID: 50050 RVA: 0x002C4058 File Offset: 0x002C2258
	public AbyssQuality? GetAbyssQualityByPluginItemId(int itemId)
	{
		AbyssItem? dangoItemById = this.GetDangoItemById(itemId);
		if (dangoItemById == null)
		{
			return null;
		}
		return ConfigAbyssQualityById.GetConfig(dangoItemById.Value.QualityId, true);
	}

	// Token: 0x0600C383 RID: 50051 RVA: 0x002C4095 File Offset: 0x002C2295
	public int? GetWorldInstanceId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoWorldInstanceId");
	}

	// Token: 0x0600C384 RID: 50052 RVA: 0x002C40A1 File Offset: 0x002C22A1
	public int? GetWorldInstanceEntranceId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoWorldInstanceEntranceId");
	}

	// Token: 0x0600C385 RID: 50053 RVA: 0x002C40AD File Offset: 0x002C22AD
	public int? GetWorldTeleportId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoSmallWorldTeleportId");
	}

	// Token: 0x0600C386 RID: 50054 RVA: 0x002C40B9 File Offset: 0x002C22B9
	public IReadOnlyList<int> GetSmallWorldInsIdList()
	{
		return ConfigCommonParamById.GetIntArrayConfig("DangoSmallWorldInsId");
	}

	// Token: 0x0600C387 RID: 50055 RVA: 0x002C40C5 File Offset: 0x002C22C5
	public int? GetAbyssKeyItemId()
	{
		return ConfigCommonParamById.GetIntConfig("AbyssKeyId");
	}

	// Token: 0x0600C388 RID: 50056 RVA: 0x002C40D1 File Offset: 0x002C22D1
	public string GetAbyssLimitRewardTexture()
	{
		return ConfigCommonParamById.GetStringConfig("DangoAbyssLimitRewardTexture");
	}

	// Token: 0x0600C389 RID: 50057 RVA: 0x002C40DD File Offset: 0x002C22DD
	public int? GetAbyssLimitRewardRewardId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoAbyssLimitRewardId");
	}

	// Token: 0x0600C38A RID: 50058 RVA: 0x002C40E9 File Offset: 0x002C22E9
	public AbyssActivity? GetAbyssActivityData(int activityId)
	{
		return ConfigAbyssActivityByActivityId.GetConfig(activityId, true);
	}

	// Token: 0x0600C38B RID: 50059 RVA: 0x002C40F4 File Offset: 0x002C22F4
	public AbyssRoute? GetAbyssRouteByRouteIdAndFloorId(int routeId, int floorId)
	{
		IReadOnlyList<AbyssRoute> configList = ConfigAbyssRouteByRouterAndFloor.GetConfigList(routeId, floorId, true);
		if (configList == null || configList.Count <= 0)
		{
			return null;
		}
		return new AbyssRoute?(configList[0]);
	}

	// Token: 0x0600C38C RID: 50060 RVA: 0x002C412C File Offset: 0x002C232C
	public AbyssRewardTab? GetAbyssRewardTabById(int id)
	{
		return ConfigAbyssRewardTabById.GetConfig(id, true);
	}

	// Token: 0x0600C38D RID: 50061 RVA: 0x002C4138 File Offset: 0x002C2338
	public int GetAbyssMarkByActivityId(int id)
	{
		return ConfigAbyssActivityByActivityId.GetConfig(id, true).Value.MarkId;
	}

	// Token: 0x0600C38E RID: 50062 RVA: 0x002C415C File Offset: 0x002C235C
	public AbyssSettle? GetAbyssSettleById(int id)
	{
		return ConfigAbyssSettleById.GetConfig(id, true);
	}

	// Token: 0x0600C38F RID: 50063 RVA: 0x002C4168 File Offset: 0x002C2368
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

	// Token: 0x0600C390 RID: 50064 RVA: 0x002C41DC File Offset: 0x002C23DC
	public int GetDangoShopAngryTime()
	{
		return ConfigCommonParamById.GetIntConfig("DangoShopAngryTime").GetValueOrDefault();
	}

	// Token: 0x0600C391 RID: 50065 RVA: 0x002C41FC File Offset: 0x002C23FC
	public int GetDangoShopBuyTime()
	{
		return ConfigCommonParamById.GetIntConfig("DangoShopBuyTime").GetValueOrDefault();
	}

	// Token: 0x0600C392 RID: 50066 RVA: 0x002C421C File Offset: 0x002C241C
	public int GetDangoShopClickTime()
	{
		return ConfigCommonParamById.GetIntConfig("DangoShopClickTime").GetValueOrDefault();
	}

	// Token: 0x0600C393 RID: 50067 RVA: 0x002C423C File Offset: 0x002C243C
	public int GetBadDangoMeshId()
	{
		return ConfigCommonParamById.GetIntConfig("BadDangoMesh").GetValueOrDefault();
	}

	// Token: 0x0600C394 RID: 50068 RVA: 0x002C425B File Offset: 0x002C245B
	public string GetBadDangoStandAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoStandAnimation");
	}

	// Token: 0x0600C395 RID: 50069 RVA: 0x002C4267 File Offset: 0x002C2467
	public string GetBadDangoBuyAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoBuyAnimation");
	}

	// Token: 0x0600C396 RID: 50070 RVA: 0x002C4273 File Offset: 0x002C2473
	public string GetBadDangoBadDangoPinkAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoPinkAnimation");
	}

	// Token: 0x0600C397 RID: 50071 RVA: 0x002C427F File Offset: 0x002C247F
	public string GetBadDangoBadDangoPinkOverAni()
	{
		return ConfigCommonParamById.GetStringConfig("BadDangoPinkOverAnimation");
	}

	// Token: 0x0600C398 RID: 50072 RVA: 0x002C428C File Offset: 0x002C248C
	public FTransform GetBadDangoTransform()
	{
		FRotator badDangoRotator = this.GetBadDangoRotator();
		FVector badDangoLocation = this.GetBadDangoLocation();
		FVector badDangoZoom = this.GetBadDangoZoom();
		return new FTransform(ref badDangoRotator, ref badDangoLocation, ref badDangoZoom);
	}

	// Token: 0x0600C399 RID: 50073 RVA: 0x002C42BC File Offset: 0x002C24BC
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

	// Token: 0x0600C39A RID: 50074 RVA: 0x002C4310 File Offset: 0x002C2510
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

	// Token: 0x0600C39B RID: 50075 RVA: 0x002C4364 File Offset: 0x002C2564
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

	// Token: 0x0600C39C RID: 50076 RVA: 0x002C43B8 File Offset: 0x002C25B8
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

	// Token: 0x1700104C RID: 4172
	// (get) Token: 0x0600C39D RID: 50077 RVA: 0x002C4458 File Offset: 0x002C2658
	public static DangoAbyssConfig Instance
	{
		get
		{
			return DangoAbyssConfig._Instance;
		}
	}

	// Token: 0x0600C39E RID: 50078 RVA: 0x002C445F File Offset: 0x002C265F
	public static DangoAbyssConfig GetOrCreateInstance()
	{
		if (DangoAbyssConfig._Instance == null)
		{
			DangoAbyssConfig.CreateInstance();
		}
		return DangoAbyssConfig._Instance;
	}

	// Token: 0x0600C39F RID: 50079 RVA: 0x002C4473 File Offset: 0x002C2673
	public static bool CreateInstance()
	{
		if (DangoAbyssConfig._Instance != null)
		{
			return true;
		}
		DangoAbyssConfig._Instance = new DangoAbyssConfig();
		return true;
	}

	// Token: 0x0600C3A0 RID: 50080 RVA: 0x002C4489 File Offset: 0x002C2689
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C3A1 RID: 50081 RVA: 0x002C448B File Offset: 0x002C268B
	public static void ResetStaticDefaultValue()
	{
		DangoAbyssConfig._Instance = null;
	}

	// Token: 0x0600C3A2 RID: 50082 RVA: 0x002C4493 File Offset: 0x002C2693
	static DangoAbyssConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoAbyssConfig.CreateStaticDefaultValue), new Action(DangoAbyssConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005A46 RID: 23110
	[Nullable(2)]
	private static DangoAbyssConfig _Instance;
}
