using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200042E RID: 1070
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class FurnitureConfig : ConfigBase
{
	// Token: 0x06003906 RID: 14598 RVA: 0x0014B2E1 File Offset: 0x001494E1
	public SpringFestival? GetGameplayConfigById(int handleId)
	{
		return ConfigSpringFestivalByActivityId.GetConfig(handleId, true);
	}

	// Token: 0x06003907 RID: 14599 RVA: 0x0014B2EA File Offset: 0x001494EA
	public Furniture? GetFurnitureConfig(int furnitureId)
	{
		return ConfigFurnitureById.GetConfig(furnitureId, true);
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x0014B2F3 File Offset: 0x001494F3
	public IReadOnlyList<Furniture> GetFurnitureConfigListByTagId(int tagId)
	{
		return ConfigFurnitureByTagId.GetConfigList(tagId, true);
	}

	// Token: 0x06003909 RID: 14601 RVA: 0x0014B2FC File Offset: 0x001494FC
	public SpringFestivalArea? GetFurnitureAreaConfig(int areaId)
	{
		return ConfigSpringFestivalAreaById.GetConfig(areaId, true);
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x0014B305 File Offset: 0x00149505
	public FurnitureDiyTag? GetFurnitureTagConfig(int tagId)
	{
		return ConfigFurnitureDiyTagById.GetConfig(tagId, true);
	}

	// Token: 0x0600390B RID: 14603 RVA: 0x0014B310 File Offset: 0x00149510
	public bool HasFurnitureLimit(int furnitureId)
	{
		Furniture? furnitureConfig = this.GetFurnitureConfig(furnitureId);
		return furnitureConfig != null && furnitureConfig.Value.LimitCount > 0;
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x0014B342 File Offset: 0x00149542
	public FurniturePresetConfig? GetFurniturePresetConfig(int areaId)
	{
		return ConfigFurniturePresetConfigByAreaId.GetConfig(areaId, true);
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x0014B34B File Offset: 0x0014954B
	public IReadOnlyList<FurnitureDiyTag> GetFurnitureTagConfigList()
	{
		return ConfigFurnitureDiyTagAll.GetConfigList(true);
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x0014B353 File Offset: 0x00149553
	public AtmosphereLevel? GetAtmosphereLevelConfig(int handleId, int level)
	{
		return ConfigAtmosphereLevelByActivityIdAndLevel.GetConfig(handleId, level, true);
	}

	// Token: 0x0600390F RID: 14607 RVA: 0x0014B35D File Offset: 0x0014955D
	public IReadOnlyList<AtmosphereLevel> GetAtmosphereLevelConfigList(int handleId)
	{
		return ConfigAtmosphereLevelByActivityId.GetConfigList(handleId, true);
	}

	// Token: 0x06003910 RID: 14608 RVA: 0x0014B366 File Offset: 0x00149566
	public IReadOnlyList<Furniture> GetFurnitureConfigListByHandleId(int handleId)
	{
		return ConfigFurnitureByActivityId.GetConfigList(handleId, true);
	}

	// Token: 0x06003911 RID: 14609 RVA: 0x0014B36F File Offset: 0x0014956F
	public FurnitureQualityConfig? GetFurnitureQualityConfig(int qualityId)
	{
		return ConfigFurnitureQualityConfigById.GetConfig(qualityId, true);
	}

	// Token: 0x06003912 RID: 14610 RVA: 0x0014B378 File Offset: 0x00149578
	public FurnitureFilterConfig? GetFurnitureFilterConfig(int filterId)
	{
		return ConfigFurnitureFilterConfigById.GetConfig(filterId, true);
	}

	// Token: 0x06003913 RID: 14611 RVA: 0x0014B381 File Offset: 0x00149581
	public IReadOnlyList<FurnitureFilterConfig> GetFurnitureFilterConfigList()
	{
		return ConfigFurnitureFilterConfigAll.GetConfigList(true);
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x0014B389 File Offset: 0x00149589
	public IReadOnlyList<Furniture> GetFurnitureConfigListBySourceTypeAndGetWayId(int sourceType, int getWayId)
	{
		return ConfigFurnitureBySourceTypeAndGetWayId.GetConfigList(sourceType, getWayId, true);
	}

	// Token: 0x06003915 RID: 14613 RVA: 0x0014B393 File Offset: 0x00149593
	public IReadOnlyList<SpringFestivalArea> GetFurnitureAreaConfigListByFloorId(int floorId)
	{
		return ConfigSpringFestivalAreaByFloor.GetConfigList(floorId, true);
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x0014B39C File Offset: 0x0014959C
	public IReadOnlyList<Furniture> GetFurnitureConfigList()
	{
		return ConfigFurnitureAll.GetConfigList(true);
	}

	// Token: 0x06003917 RID: 14615 RVA: 0x0014B3A4 File Offset: 0x001495A4
	public IReadOnlyList<SpringFestivalArea> GetFurnitureAreaConfigList()
	{
		return ConfigSpringFestivalAreaByAll.GetConfigList(true);
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x0014B3AC File Offset: 0x001495AC
	public SpringFestivalArea? GetFurnitureAreaConfigBySlotEntityId(int slotEntityId)
	{
		IReadOnlyList<SpringFestivalArea> furnitureAreaConfigList = this.GetFurnitureAreaConfigList();
		if (furnitureAreaConfigList == null)
		{
			return null;
		}
		foreach (SpringFestivalArea value in furnitureAreaConfigList)
		{
			int[] slotEntityIdsArray = value.GetSlotEntityIdsArray();
			if (slotEntityIdsArray != null)
			{
				for (int i = 0; i < slotEntityIdsArray.Length; i++)
				{
					if (slotEntityIdsArray[i] == slotEntityId)
					{
						return new SpringFestivalArea?(value);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x0014B440 File Offset: 0x00149640
	public SpringFestivalAreaCamera? GetAreaCameraConfig(int id)
	{
		return ConfigSpringFestivalAreaCameraById.GetConfig(id, true);
	}

	// Token: 0x170007E2 RID: 2018
	// (get) Token: 0x0600391A RID: 14618 RVA: 0x0014B449 File Offset: 0x00149649
	[Nullable(1)]
	public static FurnitureConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return FurnitureConfig._Instance;
		}
	}

	// Token: 0x0600391B RID: 14619 RVA: 0x0014B450 File Offset: 0x00149650
	[NullableContext(1)]
	public static FurnitureConfig GetOrCreateInstance()
	{
		if (FurnitureConfig._Instance == null)
		{
			FurnitureConfig.CreateInstance();
		}
		return FurnitureConfig._Instance;
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x0014B464 File Offset: 0x00149664
	public static bool CreateInstance()
	{
		if (FurnitureConfig._Instance != null)
		{
			return true;
		}
		FurnitureConfig._Instance = new FurnitureConfig();
		return true;
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x0014B47A File Offset: 0x0014967A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600391E RID: 14622 RVA: 0x0014B47C File Offset: 0x0014967C
	public static void ResetStaticDefaultValue()
	{
		FurnitureConfig._Instance = null;
	}

	// Token: 0x0600391F RID: 14623 RVA: 0x0014B484 File Offset: 0x00149684
	static FurnitureConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FurnitureConfig.CreateStaticDefaultValue), new Action(FurnitureConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002EA9 RID: 11945
	private static FurnitureConfig _Instance;
}
