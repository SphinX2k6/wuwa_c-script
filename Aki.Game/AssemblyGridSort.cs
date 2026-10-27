using System;
using System.Runtime.CompilerServices;

// Token: 0x02001874 RID: 6260
[NullableContext(1)]
[Nullable(0)]
public class AssemblyGridSort : CommonSort<EAssemblyGridSortWayType>
{
	// Token: 0x0600B7B9 RID: 47033 RVA: 0x00299470 File Offset: 0x00297670
	private int SortConfigIdAscending(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AssemblyGridData assemblyGridData = a as AssemblyGridData;
		if (assemblyGridData == null)
		{
			return 0;
		}
		AssemblyGridData assemblyGridData2 = b as AssemblyGridData;
		if (assemblyGridData2 == null)
		{
			return 0;
		}
		int id = assemblyGridData.Id;
		int id2 = assemblyGridData2.Id;
		return id - id2;
	}

	// Token: 0x0600B7BA RID: 47034 RVA: 0x002994A4 File Offset: 0x002976A4
	private int SortConfigId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AssemblyGridData assemblyGridData = a as AssemblyGridData;
		if (assemblyGridData == null)
		{
			return 0;
		}
		AssemblyGridData assemblyGridData2 = b as AssemblyGridData;
		if (assemblyGridData2 == null)
		{
			return 0;
		}
		int id = assemblyGridData.Id;
		return (assemblyGridData2.Id - id) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B7BB RID: 47035 RVA: 0x002994E0 File Offset: 0x002976E0
	private int SortSortIndex(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AssemblyGridData assemblyGridData = a as AssemblyGridData;
		if (assemblyGridData == null)
		{
			return 0;
		}
		AssemblyGridData assemblyGridData2 = b as AssemblyGridData;
		if (assemblyGridData2 == null)
		{
			return 0;
		}
		int sortId = assemblyGridData.SortId;
		int sortId2 = assemblyGridData2.SortId;
		return (sortId - sortId2) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B7BC RID: 47036 RVA: 0x0029951C File Offset: 0x0029771C
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AssemblyGridData assemblyGridData = a as AssemblyGridData;
		if (assemblyGridData == null)
		{
			return 0;
		}
		AssemblyGridData assemblyGridData2 = b as AssemblyGridData;
		if (assemblyGridData2 == null)
		{
			return 0;
		}
		int num = 0;
		if (assemblyGridData.GridType == ERouletteGridType.EquipItem)
		{
			AssemblyEquipItemGridData assemblyEquipItemGridData = assemblyGridData as AssemblyEquipItemGridData;
			if (assemblyEquipItemGridData != null)
			{
				AssemblyEquipItemGridData assemblyEquipItemGridData2 = assemblyGridData2 as AssemblyEquipItemGridData;
				if (assemblyEquipItemGridData2 != null)
				{
					int qualityId = assemblyEquipItemGridData.QualityId;
					num = assemblyEquipItemGridData2.QualityId - qualityId;
				}
			}
		}
		return num * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B7BD RID: 47037 RVA: 0x00299580 File Offset: 0x00297780
	private int SortCount(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		AssemblyGridData assemblyGridData = a as AssemblyGridData;
		if (assemblyGridData == null)
		{
			return 0;
		}
		AssemblyGridData assemblyGridData2 = b as AssemblyGridData;
		if (assemblyGridData2 == null)
		{
			return 0;
		}
		int num = 0;
		if (assemblyGridData.GridType == ERouletteGridType.EquipItem)
		{
			AssemblyEquipItemGridData assemblyEquipItemGridData = assemblyGridData as AssemblyEquipItemGridData;
			if (assemblyEquipItemGridData != null)
			{
				AssemblyEquipItemGridData assemblyEquipItemGridData2 = assemblyGridData2 as AssemblyEquipItemGridData;
				if (assemblyEquipItemGridData2 != null)
				{
					int itemNum = assemblyEquipItemGridData.ItemNum;
					int itemNum2 = assemblyEquipItemGridData2.ItemNum;
					num = itemNum - itemNum2;
				}
			}
		}
		return num * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B7BE RID: 47038 RVA: 0x002995E4 File Offset: 0x002977E4
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EAssemblyGridSortWayType.ConfigId, new TSortResult(this.SortConfigId));
		this.SortMap.Add(EAssemblyGridSortWayType.ConfigIdAscending, new TSortResult(this.SortConfigIdAscending));
		this.SortMap.Add(EAssemblyGridSortWayType.SortIndex, new TSortResult(this.SortSortIndex));
		this.SortMap.Add(EAssemblyGridSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(EAssemblyGridSortWayType.Count, new TSortResult(this.SortCount));
	}
}
