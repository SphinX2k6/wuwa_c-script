using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F79 RID: 3961
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class FurnitureConfig : ConfigBase
{
	// Token: 0x0600656E RID: 25966 RVA: 0x00142A45 File Offset: 0x00140C45
	public SpringFestival? GetGameplayConfigById(int handleId)
	{
		return ConfigSpringFestivalByActivityId.GetConfig(handleId, true);
	}

	// Token: 0x0600656F RID: 25967 RVA: 0x00142A4E File Offset: 0x00140C4E
	public Furniture? GetFurnitureConfig(int furnitureId)
	{
		return ConfigFurnitureById.GetConfig(furnitureId, true);
	}

	// Token: 0x06006570 RID: 25968 RVA: 0x00142A57 File Offset: 0x00140C57
	public IReadOnlyList<Furniture> GetFurnitureConfigListByTagId(int tagId)
	{
		return ConfigFurnitureByTagId.GetConfigList(tagId, true);
	}

	// Token: 0x06006571 RID: 25969 RVA: 0x00142A60 File Offset: 0x00140C60
	public SpringFestivalArea? GetFurnitureAreaConfig(int areaId)
	{
		return ConfigSpringFestivalAreaById.GetConfig(areaId, true);
	}

	// Token: 0x06006572 RID: 25970 RVA: 0x00142A69 File Offset: 0x00140C69
	public FurnitureDiyTag? GetFurnitureTagConfig(int tagId)
	{
		return ConfigFurnitureDiyTagById.GetConfig(tagId, true);
	}

	// Token: 0x06006573 RID: 25971 RVA: 0x00142A74 File Offset: 0x00140C74
	public bool HasFurnitureLimit(int furnitureId)
	{
		Furniture? furnitureConfig = this.GetFurnitureConfig(furnitureId);
		return furnitureConfig != null && furnitureConfig.Value.LimitCount > 0;
	}

	// Token: 0x06006574 RID: 25972 RVA: 0x00142AA6 File Offset: 0x00140CA6
	public FurniturePresetConfig? GetFurniturePresetConfig(int areaId)
	{
		return ConfigFurniturePresetConfigByAreaId.GetConfig(areaId, true);
	}

	// Token: 0x06006575 RID: 25973 RVA: 0x00142AAF File Offset: 0x00140CAF
	public IReadOnlyList<FurnitureDiyTag> GetFurnitureTagConfigList()
	{
		return ConfigFurnitureDiyTagAll.GetConfigList(true);
	}

	// Token: 0x06006576 RID: 25974 RVA: 0x00142AB7 File Offset: 0x00140CB7
	public AtmosphereLevel? GetAtmosphereLevelConfig(int handleId, int level)
	{
		return ConfigAtmosphereLevelByActivityIdAndLevel.GetConfig(handleId, level, true);
	}

	// Token: 0x06006577 RID: 25975 RVA: 0x00142AC1 File Offset: 0x00140CC1
	public IReadOnlyList<AtmosphereLevel> GetAtmosphereLevelConfigList(int handleId)
	{
		return ConfigAtmosphereLevelByActivityId.GetConfigList(handleId, true);
	}

	// Token: 0x06006578 RID: 25976 RVA: 0x00142ACA File Offset: 0x00140CCA
	public IReadOnlyList<Furniture> GetFurnitureConfigListByHandleId(int handleId)
	{
		return ConfigFurnitureByActivityId.GetConfigList(handleId, true);
	}

	// Token: 0x06006579 RID: 25977 RVA: 0x00142AD3 File Offset: 0x00140CD3
	public FurnitureQualityConfig? GetFurnitureQualityConfig(int qualityId)
	{
		return ConfigFurnitureQualityConfigById.GetConfig(qualityId, true);
	}

	// Token: 0x0600657A RID: 25978 RVA: 0x00142ADC File Offset: 0x00140CDC
	public FurnitureFilterConfig? GetFurnitureFilterConfig(int filterId)
	{
		return ConfigFurnitureFilterConfigById.GetConfig(filterId, true);
	}

	// Token: 0x0600657B RID: 25979 RVA: 0x00142AE5 File Offset: 0x00140CE5
	public IReadOnlyList<FurnitureFilterConfig> GetFurnitureFilterConfigList()
	{
		return ConfigFurnitureFilterConfigAll.GetConfigList(true);
	}

	// Token: 0x0600657C RID: 25980 RVA: 0x00142AED File Offset: 0x00140CED
	public IReadOnlyList<Furniture> GetFurnitureConfigListBySourceTypeAndGetWayId(int sourceType, int getWayId)
	{
		return ConfigFurnitureBySourceTypeAndGetWayId.GetConfigList(sourceType, getWayId, true);
	}

	// Token: 0x0600657D RID: 25981 RVA: 0x00142AF7 File Offset: 0x00140CF7
	public IReadOnlyList<SpringFestivalArea> GetFurnitureAreaConfigListByFloorId(int floorId)
	{
		return ConfigSpringFestivalAreaByFloor.GetConfigList(floorId, true);
	}

	// Token: 0x0600657E RID: 25982 RVA: 0x00142B00 File Offset: 0x00140D00
	public IReadOnlyList<Furniture> GetFurnitureConfigList()
	{
		return ConfigFurnitureAll.GetConfigList(true);
	}

	// Token: 0x0600657F RID: 25983 RVA: 0x00142B08 File Offset: 0x00140D08
	public IReadOnlyList<SpringFestivalArea> GetFurnitureAreaConfigList()
	{
		return ConfigSpringFestivalAreaByAll.GetConfigList(true);
	}

	// Token: 0x06006580 RID: 25984 RVA: 0x00142B10 File Offset: 0x00140D10
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

	// Token: 0x06006581 RID: 25985 RVA: 0x00142BA4 File Offset: 0x00140DA4
	public SpringFestivalAreaCamera? GetAreaCameraConfig(int id)
	{
		return ConfigSpringFestivalAreaCameraById.GetConfig(id, true);
	}

	// Token: 0x170007C0 RID: 1984
	// (get) Token: 0x06006582 RID: 25986 RVA: 0x00142BAD File Offset: 0x00140DAD
	[Nullable(1)]
	public static FurnitureConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return FurnitureConfig._Instance;
		}
	}

	// Token: 0x06006583 RID: 25987 RVA: 0x00142BB4 File Offset: 0x00140DB4
	[NullableContext(1)]
	public static FurnitureConfig GetOrCreateInstance()
	{
		if (FurnitureConfig._Instance == null)
		{
			FurnitureConfig.CreateInstance();
		}
		return FurnitureConfig._Instance;
	}

	// Token: 0x06006584 RID: 25988 RVA: 0x00142BC8 File Offset: 0x00140DC8
	public static bool CreateInstance()
	{
		if (FurnitureConfig._Instance != null)
		{
			return true;
		}
		FurnitureConfig._Instance = new FurnitureConfig();
		return true;
	}

	// Token: 0x06006585 RID: 25989 RVA: 0x00142BDE File Offset: 0x00140DDE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006586 RID: 25990 RVA: 0x00142BE0 File Offset: 0x00140DE0
	public static void ResetStaticDefaultValue()
	{
		FurnitureConfig._Instance = null;
	}

	// Token: 0x06006587 RID: 25991 RVA: 0x00142BE8 File Offset: 0x00140DE8
	static FurnitureConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FurnitureConfig.CreateStaticDefaultValue), new Action(FurnitureConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002E10 RID: 11792
	private static FurnitureConfig _Instance;
}
