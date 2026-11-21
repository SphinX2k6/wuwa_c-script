using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020012AD RID: 4781
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class HandBookConfig : ConfigBase
{
	// Token: 0x0600BD51 RID: 48465 RVA: 0x0037F48E File Offset: 0x0037D68E
	public IReadOnlyList<PhantomHandBook> GetPhantomHandBookConfig()
	{
		return ConfigPhantomHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD52 RID: 48466 RVA: 0x0037F496 File Offset: 0x0037D696
	public IReadOnlyList<PhantomFetterHandBook> GetPhantomFetterHandBookConfig()
	{
		return ConfigPhantomFetterHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD53 RID: 48467 RVA: 0x0037F49E File Offset: 0x0037D69E
	public PhantomHandBook? GetPhantomHandBookConfigById(int id)
	{
		return ConfigPhantomHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD54 RID: 48468 RVA: 0x0037F4A7 File Offset: 0x0037D6A7
	public IReadOnlyList<PhantomHandBookPage> GetPhantomHandBookPageConfig()
	{
		return ConfigPhantomHandBookPageAll.GetConfigList(true);
	}

	// Token: 0x0600BD55 RID: 48469 RVA: 0x0037F4AF File Offset: 0x0037D6AF
	public HandBookEntrance? GetHandBookEntranceConfig(EHandBookTabType type)
	{
		return ConfigHandBookEntranceById.GetConfig((int)type, true);
	}

	// Token: 0x0600BD56 RID: 48470 RVA: 0x0037F4B8 File Offset: 0x0037D6B8
	public IReadOnlyList<HandBookEntrance> GetHandBookEntranceConfigList()
	{
		return ConfigHandBookEntranceAll.GetConfigList(true);
	}

	// Token: 0x0600BD57 RID: 48471 RVA: 0x0037F4C0 File Offset: 0x0037D6C0
	public WeaponHandBook? GetWeaponHandBookConfig(int id)
	{
		return ConfigWeaponHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD58 RID: 48472 RVA: 0x0037F4C9 File Offset: 0x0037D6C9
	public IReadOnlyList<WeaponHandBook> GetWeaponHandBookConfigList()
	{
		return ConfigWeaponHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD59 RID: 48473 RVA: 0x0037F4D1 File Offset: 0x0037D6D1
	public MonsterHandBook? GetMonsterHandBookConfigById(int id)
	{
		return ConfigMonsterHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD5A RID: 48474 RVA: 0x0037F4DA File Offset: 0x0037D6DA
	public MonsterHandBook? GetMonsterHandBookConfigByMonsterId(int monsterId)
	{
		return ConfigMonsterHandBookByMonsterId.GetConfig(monsterId, true);
	}

	// Token: 0x0600BD5B RID: 48475 RVA: 0x0037F4E3 File Offset: 0x0037D6E3
	public IReadOnlyList<MonsterHandBook> GetMonsterHandBookConfigByType(int type)
	{
		return ConfigMonsterHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600BD5C RID: 48476 RVA: 0x0037F4EC File Offset: 0x0037D6EC
	public IReadOnlyList<MonsterHandBookType> GetMonsterHandBookTypeConfig()
	{
		return ConfigMonsterHandBookTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD5D RID: 48477 RVA: 0x0037F4F4 File Offset: 0x0037D6F4
	public MonsterHandBookType? GetMonsterHandBookTypeConfigById(int id)
	{
		return ConfigMonsterHandBookTypeById.GetConfig(id, true);
	}

	// Token: 0x0600BD5E RID: 48478 RVA: 0x0037F4FD File Offset: 0x0037D6FD
	public IReadOnlyList<MonsterHandBook> GetMonsterHandBookConfigList()
	{
		return ConfigMonsterHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD5F RID: 48479 RVA: 0x0037F505 File Offset: 0x0037D705
	public ItemHandBook? GetItemHandBookConfigById(int id)
	{
		return ConfigItemHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD60 RID: 48480 RVA: 0x0037F50E File Offset: 0x0037D70E
	public IReadOnlyList<ItemHandBook> GetItemHandBookConfigList()
	{
		return ConfigItemHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD61 RID: 48481 RVA: 0x0037F516 File Offset: 0x0037D716
	public IReadOnlyList<ItemHandBook> GetItemHandBookConfigByType(int type)
	{
		return ConfigItemHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600BD62 RID: 48482 RVA: 0x0037F51F File Offset: 0x0037D71F
	public IReadOnlyList<ItemHandBookType> GetItemHandBookTypeConfigList()
	{
		return ConfigItemHandBookTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD63 RID: 48483 RVA: 0x0037F527 File Offset: 0x0037D727
	public ItemHandBookType? GetItemHandBookTypeConfig(int type)
	{
		return ConfigItemHandBookTypeById.GetConfig(type, true);
	}

	// Token: 0x0600BD64 RID: 48484 RVA: 0x0037F530 File Offset: 0x0037D730
	public IReadOnlyList<AnimalHandBook> GetAnimalHandBookConfigList()
	{
		return ConfigAnimalHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD65 RID: 48485 RVA: 0x0037F538 File Offset: 0x0037D738
	public AnimalHandBook? GetAnimalHandBookConfigById(int id)
	{
		return ConfigAnimalHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD66 RID: 48486 RVA: 0x0037F544 File Offset: 0x0037D744
	public AnimalHandBook? GetAnimalHandBookConfigByMeshId(int meshId)
	{
		if (this.AnimalMeshIdMap == null)
		{
			this.AnimalMeshIdMap = new Dictionary<int, int>();
			foreach (AnimalHandBook animalHandBook in ConfigAnimalHandBookAll.GetConfigList(true))
			{
				this.AnimalMeshIdMap[animalHandBook.MeshId] = animalHandBook.Id;
			}
		}
		int num;
		if (this.AnimalMeshIdMap.TryGetValue(meshId, out num) && num != 0)
		{
			return ConfigAnimalHandBookByMeshId.GetConfig(meshId, true);
		}
		return null;
	}

	// Token: 0x0600BD67 RID: 48487 RVA: 0x0037F5DC File Offset: 0x0037D7DC
	public IReadOnlyList<ChipHandBook> GetAllChipHandBookConfig()
	{
		return ConfigChipHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD68 RID: 48488 RVA: 0x0037F5E4 File Offset: 0x0037D7E4
	public IReadOnlyList<ChipHandBook> GetChipHandBookConfigList(int type)
	{
		return ConfigChipHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600BD69 RID: 48489 RVA: 0x0037F5ED File Offset: 0x0037D7ED
	public ChipHandBook? GetChipHandBookConfig(int id)
	{
		return ConfigChipHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD6A RID: 48490 RVA: 0x0037F5F6 File Offset: 0x0037D7F6
	public IReadOnlyList<ChipType> GetChipTypeConfigList()
	{
		return ConfigChipTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD6B RID: 48491 RVA: 0x0037F5FE File Offset: 0x0037D7FE
	public ChipType? GetChipTypeConfig(int id)
	{
		return ConfigChipTypeById.GetConfig(id, true);
	}

	// Token: 0x0600BD6C RID: 48492 RVA: 0x0037F607 File Offset: 0x0037D807
	public NounHandBook? GetNounHandBookConfig(int id)
	{
		return ConfigNounHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD6D RID: 48493 RVA: 0x0037F610 File Offset: 0x0037D810
	public IReadOnlyList<NounHandBook> GetNounHandBookConfigList(int type)
	{
		return ConfigNounHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600BD6E RID: 48494 RVA: 0x0037F619 File Offset: 0x0037D819
	public IReadOnlyList<NounType> GetNounTypeConfigList()
	{
		return ConfigNounTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD6F RID: 48495 RVA: 0x0037F621 File Offset: 0x0037D821
	public NounType? GetNounTypeConfig(int id)
	{
		return ConfigNounTypeById.GetConfig(id, true);
	}

	// Token: 0x0600BD70 RID: 48496 RVA: 0x0037F62A File Offset: 0x0037D82A
	public IReadOnlyList<NounHandBook> GetNounTypeConfigAll()
	{
		return ConfigNounHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD71 RID: 48497 RVA: 0x0037F632 File Offset: 0x0037D832
	public GeographyHandBook? GetGeographyHandBookConfig(int id)
	{
		return ConfigGeographyHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD72 RID: 48498 RVA: 0x0037F63B File Offset: 0x0037D83B
	public IReadOnlyList<GeographyHandBook> GetAllGeographyHandBookConfig()
	{
		return ConfigGeographyHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD73 RID: 48499 RVA: 0x0037F643 File Offset: 0x0037D843
	public IReadOnlyList<GeographyHandBook> GetGeographyHandBookConfigByType(int type)
	{
		return ConfigGeographyHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600BD74 RID: 48500 RVA: 0x0037F64C File Offset: 0x0037D84C
	public IReadOnlyList<GeographyHandBook> GetGeographyHandBookConfigByTabType(int tabType)
	{
		return ConfigGeographyHandBookByTabType.GetConfigList(tabType, true);
	}

	// Token: 0x0600BD75 RID: 48501 RVA: 0x0037F655 File Offset: 0x0037D855
	public IReadOnlyList<GeographyHandBook> GetGeographyHandBookConfigByTabTypeAndType(int tabType, int type)
	{
		return ConfigGeographyHandBookByTabTypeAndType.GetConfigList(tabType, type, true);
	}

	// Token: 0x0600BD76 RID: 48502 RVA: 0x0037F65F File Offset: 0x0037D85F
	public GeographyType? GetGeographyTypeConfig(int id)
	{
		return ConfigGeographyTypeById.GetConfig(id, true);
	}

	// Token: 0x0600BD77 RID: 48503 RVA: 0x0037F668 File Offset: 0x0037D868
	public IReadOnlyList<GeographyType> GetGeographyTypeConfigList()
	{
		return ConfigGeographyTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD78 RID: 48504 RVA: 0x0037F670 File Offset: 0x0037D870
	public IReadOnlyList<GeographyTabType> GetGeographyTabList()
	{
		return ConfigGeographyTabTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD79 RID: 48505 RVA: 0x0037F678 File Offset: 0x0037D878
	public GeographyTabType? GetGeographyTabTypeById(int id)
	{
		return ConfigGeographyTabTypeById.GetConfig(id, true);
	}

	// Token: 0x0600BD7A RID: 48506 RVA: 0x0037F681 File Offset: 0x0037D881
	public IReadOnlyList<PhotographHandBook> GetAllPlotHandBookConfig()
	{
		return ConfigPhotographHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600BD7B RID: 48507 RVA: 0x0037F689 File Offset: 0x0037D889
	public PhotographHandBook? GetPlotHandBookConfig(int id)
	{
		return ConfigPhotographHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600BD7C RID: 48508 RVA: 0x0037F692 File Offset: 0x0037D892
	public IReadOnlyList<PhotographHandBook> GetPlotHandBookConfigByType(int type)
	{
		return ConfigPhotographHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600BD7D RID: 48509 RVA: 0x0037F69B File Offset: 0x0037D89B
	public PlotType? GetPlotTypeConfig(int id)
	{
		return ConfigPlotTypeById.GetConfig(id, true);
	}

	// Token: 0x0600BD7E RID: 48510 RVA: 0x0037F6A4 File Offset: 0x0037D8A4
	public IReadOnlyList<PlotType> GetPlotTypeConfigList()
	{
		return ConfigPlotTypeAll.GetConfigList(true);
	}

	// Token: 0x0600BD7F RID: 48511 RVA: 0x0037F6AC File Offset: 0x0037D8AC
	public IReadOnlyList<HandBookQuestTab> GetQuestTabList()
	{
		return ConfigHandBookQuestTabAll.GetConfigList(true);
	}

	// Token: 0x0600BD80 RID: 48512 RVA: 0x0037F6B4 File Offset: 0x0037D8B4
	public HandBookQuestTab? GetQuestTab(int type)
	{
		foreach (HandBookQuestTab value in ConfigHandBookQuestTabAll.GetConfigList(true))
		{
			if (value.Type == type)
			{
				return new HandBookQuestTab?(value);
			}
		}
		return null;
	}

	// Token: 0x0600BD81 RID: 48513 RVA: 0x0037F718 File Offset: 0x0037D918
	public PlotHandBookConfig? GetQuestPlotConfig(int questId)
	{
		return ConfigPlotHandBookConfigByQuestId.GetConfig(questId, true);
	}

	// Token: 0x170012AA RID: 4778
	// (get) Token: 0x0600BD82 RID: 48514 RVA: 0x0037F721 File Offset: 0x0037D921
	public static HandBookConfig Instance
	{
		get
		{
			return HandBookConfig._Instance;
		}
	}

	// Token: 0x0600BD83 RID: 48515 RVA: 0x0037F728 File Offset: 0x0037D928
	public static HandBookConfig GetOrCreateInstance()
	{
		if (HandBookConfig._Instance == null)
		{
			HandBookConfig.CreateInstance();
		}
		return HandBookConfig._Instance;
	}

	// Token: 0x0600BD84 RID: 48516 RVA: 0x0037F73C File Offset: 0x0037D93C
	public static bool CreateInstance()
	{
		if (HandBookConfig._Instance != null)
		{
			return true;
		}
		HandBookConfig._Instance = new HandBookConfig();
		return true;
	}

	// Token: 0x0600BD85 RID: 48517 RVA: 0x0037F752 File Offset: 0x0037D952
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BD86 RID: 48518 RVA: 0x0037F754 File Offset: 0x0037D954
	public static void ResetStaticDefaultValue()
	{
		HandBookConfig._Instance = null;
	}

	// Token: 0x0600BD87 RID: 48519 RVA: 0x0037F75C File Offset: 0x0037D95C
	static HandBookConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookConfig.CreateStaticDefaultValue), new Action(HandBookConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006CF5 RID: 27893
	[Nullable(2)]
	private Dictionary<int, int> AnimalMeshIdMap;

	// Token: 0x04006CF6 RID: 27894
	[Nullable(2)]
	private static HandBookConfig _Instance;
}
