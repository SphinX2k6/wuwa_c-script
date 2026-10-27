using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DEB RID: 7659
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class HandBookConfig : ConfigBase
{
	// Token: 0x0600E932 RID: 59698 RVA: 0x00373786 File Offset: 0x00371986
	public IReadOnlyList<PhantomHandBook> GetPhantomHandBookConfig()
	{
		return ConfigPhantomHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E933 RID: 59699 RVA: 0x0037378E File Offset: 0x0037198E
	public IReadOnlyList<PhantomFetterHandBook> GetPhantomFetterHandBookConfig()
	{
		return ConfigPhantomFetterHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E934 RID: 59700 RVA: 0x00373796 File Offset: 0x00371996
	public PhantomHandBook? GetPhantomHandBookConfigById(int id)
	{
		return ConfigPhantomHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E935 RID: 59701 RVA: 0x0037379F File Offset: 0x0037199F
	public IReadOnlyList<PhantomHandBookPage> GetPhantomHandBookPageConfig()
	{
		return ConfigPhantomHandBookPageAll.GetConfigList(true);
	}

	// Token: 0x0600E936 RID: 59702 RVA: 0x003737A7 File Offset: 0x003719A7
	public HandBookEntrance? GetHandBookEntranceConfig(EHandBookTabType type)
	{
		return ConfigHandBookEntranceById.GetConfig((int)type, true);
	}

	// Token: 0x0600E937 RID: 59703 RVA: 0x003737B0 File Offset: 0x003719B0
	public IReadOnlyList<HandBookEntrance> GetHandBookEntranceConfigList()
	{
		return ConfigHandBookEntranceAll.GetConfigList(true);
	}

	// Token: 0x0600E938 RID: 59704 RVA: 0x003737B8 File Offset: 0x003719B8
	public WeaponHandBook? GetWeaponHandBookConfig(int id)
	{
		return ConfigWeaponHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E939 RID: 59705 RVA: 0x003737C1 File Offset: 0x003719C1
	public IReadOnlyList<WeaponHandBook> GetWeaponHandBookConfigList()
	{
		return ConfigWeaponHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E93A RID: 59706 RVA: 0x003737C9 File Offset: 0x003719C9
	public MonsterHandBook? GetMonsterHandBookConfigById(int id)
	{
		return ConfigMonsterHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E93B RID: 59707 RVA: 0x003737D2 File Offset: 0x003719D2
	public MonsterHandBook? GetMonsterHandBookConfigByMonsterId(int monsterId)
	{
		return ConfigMonsterHandBookByMonsterId.GetConfig(monsterId, true);
	}

	// Token: 0x0600E93C RID: 59708 RVA: 0x003737DB File Offset: 0x003719DB
	public IReadOnlyList<MonsterHandBook> GetMonsterHandBookConfigByType(int type)
	{
		return ConfigMonsterHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600E93D RID: 59709 RVA: 0x003737E4 File Offset: 0x003719E4
	public IReadOnlyList<MonsterHandBookType> GetMonsterHandBookTypeConfig()
	{
		return ConfigMonsterHandBookTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E93E RID: 59710 RVA: 0x003737EC File Offset: 0x003719EC
	public MonsterHandBookType? GetMonsterHandBookTypeConfigById(int id)
	{
		return ConfigMonsterHandBookTypeById.GetConfig(id, true);
	}

	// Token: 0x0600E93F RID: 59711 RVA: 0x003737F5 File Offset: 0x003719F5
	public IReadOnlyList<MonsterHandBook> GetMonsterHandBookConfigList()
	{
		return ConfigMonsterHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E940 RID: 59712 RVA: 0x003737FD File Offset: 0x003719FD
	public ItemHandBook? GetItemHandBookConfigById(int id)
	{
		return ConfigItemHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E941 RID: 59713 RVA: 0x00373806 File Offset: 0x00371A06
	public IReadOnlyList<ItemHandBook> GetItemHandBookConfigList()
	{
		return ConfigItemHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E942 RID: 59714 RVA: 0x0037380E File Offset: 0x00371A0E
	public IReadOnlyList<ItemHandBook> GetItemHandBookConfigByType(int type)
	{
		return ConfigItemHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600E943 RID: 59715 RVA: 0x00373817 File Offset: 0x00371A17
	public IReadOnlyList<ItemHandBookType> GetItemHandBookTypeConfigList()
	{
		return ConfigItemHandBookTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E944 RID: 59716 RVA: 0x0037381F File Offset: 0x00371A1F
	public ItemHandBookType? GetItemHandBookTypeConfig(int type)
	{
		return ConfigItemHandBookTypeById.GetConfig(type, true);
	}

	// Token: 0x0600E945 RID: 59717 RVA: 0x00373828 File Offset: 0x00371A28
	public IReadOnlyList<AnimalHandBook> GetAnimalHandBookConfigList()
	{
		return ConfigAnimalHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E946 RID: 59718 RVA: 0x00373830 File Offset: 0x00371A30
	public AnimalHandBook? GetAnimalHandBookConfigById(int id)
	{
		return ConfigAnimalHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E947 RID: 59719 RVA: 0x0037383C File Offset: 0x00371A3C
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

	// Token: 0x0600E948 RID: 59720 RVA: 0x003738D4 File Offset: 0x00371AD4
	public IReadOnlyList<ChipHandBook> GetAllChipHandBookConfig()
	{
		return ConfigChipHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E949 RID: 59721 RVA: 0x003738DC File Offset: 0x00371ADC
	public IReadOnlyList<ChipHandBook> GetChipHandBookConfigList(int type)
	{
		return ConfigChipHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600E94A RID: 59722 RVA: 0x003738E5 File Offset: 0x00371AE5
	public ChipHandBook? GetChipHandBookConfig(int id)
	{
		return ConfigChipHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E94B RID: 59723 RVA: 0x003738EE File Offset: 0x00371AEE
	public IReadOnlyList<ChipType> GetChipTypeConfigList()
	{
		return ConfigChipTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E94C RID: 59724 RVA: 0x003738F6 File Offset: 0x00371AF6
	public ChipType? GetChipTypeConfig(int id)
	{
		return ConfigChipTypeById.GetConfig(id, true);
	}

	// Token: 0x0600E94D RID: 59725 RVA: 0x003738FF File Offset: 0x00371AFF
	public NounHandBook? GetNounHandBookConfig(int id)
	{
		return ConfigNounHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E94E RID: 59726 RVA: 0x00373908 File Offset: 0x00371B08
	public IReadOnlyList<NounHandBook> GetNounHandBookConfigList(int type)
	{
		return ConfigNounHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600E94F RID: 59727 RVA: 0x00373911 File Offset: 0x00371B11
	public IReadOnlyList<NounType> GetNounTypeConfigList()
	{
		return ConfigNounTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E950 RID: 59728 RVA: 0x00373919 File Offset: 0x00371B19
	public NounType? GetNounTypeConfig(int id)
	{
		return ConfigNounTypeById.GetConfig(id, true);
	}

	// Token: 0x0600E951 RID: 59729 RVA: 0x00373922 File Offset: 0x00371B22
	public IReadOnlyList<NounHandBook> GetNounTypeConfigAll()
	{
		return ConfigNounHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E952 RID: 59730 RVA: 0x0037392A File Offset: 0x00371B2A
	public GeographyHandBook? GetGeographyHandBookConfig(int id)
	{
		return ConfigGeographyHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E953 RID: 59731 RVA: 0x00373933 File Offset: 0x00371B33
	public IReadOnlyList<GeographyHandBook> GetAllGeographyHandBookConfig()
	{
		return ConfigGeographyHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E954 RID: 59732 RVA: 0x0037393B File Offset: 0x00371B3B
	public IReadOnlyList<GeographyHandBook> GetGeographyHandBookConfigByType(int type)
	{
		return ConfigGeographyHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600E955 RID: 59733 RVA: 0x00373944 File Offset: 0x00371B44
	public IReadOnlyList<GeographyHandBook> GetGeographyHandBookConfigByTabType(int tabType)
	{
		return ConfigGeographyHandBookByTabType.GetConfigList(tabType, true);
	}

	// Token: 0x0600E956 RID: 59734 RVA: 0x0037394D File Offset: 0x00371B4D
	public IReadOnlyList<GeographyHandBook> GetGeographyHandBookConfigByTabTypeAndType(int tabType, int type)
	{
		return ConfigGeographyHandBookByTabTypeAndType.GetConfigList(tabType, type, true);
	}

	// Token: 0x0600E957 RID: 59735 RVA: 0x00373957 File Offset: 0x00371B57
	public GeographyType? GetGeographyTypeConfig(int id)
	{
		return ConfigGeographyTypeById.GetConfig(id, true);
	}

	// Token: 0x0600E958 RID: 59736 RVA: 0x00373960 File Offset: 0x00371B60
	public IReadOnlyList<GeographyType> GetGeographyTypeConfigList()
	{
		return ConfigGeographyTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E959 RID: 59737 RVA: 0x00373968 File Offset: 0x00371B68
	public IReadOnlyList<GeographyTabType> GetGeographyTabList()
	{
		return ConfigGeographyTabTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E95A RID: 59738 RVA: 0x00373970 File Offset: 0x00371B70
	public GeographyTabType? GetGeographyTabTypeById(int id)
	{
		return ConfigGeographyTabTypeById.GetConfig(id, true);
	}

	// Token: 0x0600E95B RID: 59739 RVA: 0x00373979 File Offset: 0x00371B79
	public IReadOnlyList<PhotographHandBook> GetAllPlotHandBookConfig()
	{
		return ConfigPhotographHandBookAll.GetConfigList(true);
	}

	// Token: 0x0600E95C RID: 59740 RVA: 0x00373981 File Offset: 0x00371B81
	public PhotographHandBook? GetPlotHandBookConfig(int id)
	{
		return ConfigPhotographHandBookById.GetConfig(id, true);
	}

	// Token: 0x0600E95D RID: 59741 RVA: 0x0037398A File Offset: 0x00371B8A
	public IReadOnlyList<PhotographHandBook> GetPlotHandBookConfigByType(int type)
	{
		return ConfigPhotographHandBookByType.GetConfigList(type, true);
	}

	// Token: 0x0600E95E RID: 59742 RVA: 0x00373993 File Offset: 0x00371B93
	public PlotType? GetPlotTypeConfig(int id)
	{
		return ConfigPlotTypeById.GetConfig(id, true);
	}

	// Token: 0x0600E95F RID: 59743 RVA: 0x0037399C File Offset: 0x00371B9C
	public IReadOnlyList<PlotType> GetPlotTypeConfigList()
	{
		return ConfigPlotTypeAll.GetConfigList(true);
	}

	// Token: 0x0600E960 RID: 59744 RVA: 0x003739A4 File Offset: 0x00371BA4
	public IReadOnlyList<HandBookQuestTab> GetQuestTabList()
	{
		return ConfigHandBookQuestTabAll.GetConfigList(true);
	}

	// Token: 0x0600E961 RID: 59745 RVA: 0x003739AC File Offset: 0x00371BAC
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

	// Token: 0x0600E962 RID: 59746 RVA: 0x00373A10 File Offset: 0x00371C10
	public PlotHandBookConfig? GetQuestPlotConfig(int questId)
	{
		return ConfigPlotHandBookConfigByQuestId.GetConfig(questId, true);
	}

	// Token: 0x17001280 RID: 4736
	// (get) Token: 0x0600E963 RID: 59747 RVA: 0x00373A19 File Offset: 0x00371C19
	public static HandBookConfig Instance
	{
		get
		{
			return HandBookConfig._Instance;
		}
	}

	// Token: 0x0600E964 RID: 59748 RVA: 0x00373A20 File Offset: 0x00371C20
	public static HandBookConfig GetOrCreateInstance()
	{
		if (HandBookConfig._Instance == null)
		{
			HandBookConfig.CreateInstance();
		}
		return HandBookConfig._Instance;
	}

	// Token: 0x0600E965 RID: 59749 RVA: 0x00373A34 File Offset: 0x00371C34
	public static bool CreateInstance()
	{
		if (HandBookConfig._Instance != null)
		{
			return true;
		}
		HandBookConfig._Instance = new HandBookConfig();
		return true;
	}

	// Token: 0x0600E966 RID: 59750 RVA: 0x00373A4A File Offset: 0x00371C4A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E967 RID: 59751 RVA: 0x00373A4C File Offset: 0x00371C4C
	public static void ResetStaticDefaultValue()
	{
		HandBookConfig._Instance = null;
	}

	// Token: 0x0600E968 RID: 59752 RVA: 0x00373A54 File Offset: 0x00371C54
	static HandBookConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookConfig.CreateStaticDefaultValue), new Action(HandBookConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006C14 RID: 27668
	[Nullable(2)]
	private Dictionary<int, int> AnimalMeshIdMap;

	// Token: 0x04006C15 RID: 27669
	[Nullable(2)]
	private static HandBookConfig _Instance;
}
