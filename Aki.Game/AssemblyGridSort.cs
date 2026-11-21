using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D2D RID: 3373
[NullableContext(1)]
[Nullable(0)]
public class AssemblyGridSort : CommonSort<EAssemblyGridSortWayType>
{
	// Token: 0x06008BA2 RID: 35746 RVA: 0x002A3B88 File Offset: 0x002A1D88
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

	// Token: 0x06008BA3 RID: 35747 RVA: 0x002A3BBC File Offset: 0x002A1DBC
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

	// Token: 0x06008BA4 RID: 35748 RVA: 0x002A3BF8 File Offset: 0x002A1DF8
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

	// Token: 0x06008BA5 RID: 35749 RVA: 0x002A3C34 File Offset: 0x002A1E34
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

	// Token: 0x06008BA6 RID: 35750 RVA: 0x002A3C98 File Offset: 0x002A1E98
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

	// Token: 0x06008BA7 RID: 35751 RVA: 0x002A3CFC File Offset: 0x002A1EFC
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EAssemblyGridSortWayType.ConfigId, new TSortResult(this.SortConfigId));
		this.SortMap.Add(EAssemblyGridSortWayType.ConfigIdAscending, new TSortResult(this.SortConfigIdAscending));
		this.SortMap.Add(EAssemblyGridSortWayType.SortIndex, new TSortResult(this.SortSortIndex));
		this.SortMap.Add(EAssemblyGridSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(EAssemblyGridSortWayType.Count, new TSortResult(this.SortCount));
	}
}
