using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;

// Token: 0x02001881 RID: 6273
[NullableContext(1)]
[Nullable(0)]
public class ComposeStructureSort : CommonSort<EComposeStructureSortWayType>
{
	// Token: 0x0600B7DE RID: 47070 RVA: 0x00299DD0 File Offset: 0x00297FD0
	private int SortMenu(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IStructureData structureData = a as IStructureData;
		if (structureData == null)
		{
			return 0;
		}
		IStructureData structureData2 = b as IStructureData;
		if (structureData2 == null)
		{
			return 0;
		}
		if (structureData.SubType != structureData2.SubType)
		{
			return (structureData2.SubType - structureData.SubType) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x0600B7DF RID: 47071 RVA: 0x00299E1C File Offset: 0x0029801C
	private int SortMake(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IStructureData structureData = a as IStructureData;
		if (structureData == null)
		{
			return 0;
		}
		IStructureData structureData2 = b as IStructureData;
		if (structureData2 == null)
		{
			return 0;
		}
		int isUnlock = structureData.IsUnlock;
		int isUnlock2 = structureData2.IsUnlock;
		if (isUnlock != isUnlock2)
		{
			if (!isAscending)
			{
				return isUnlock - isUnlock2;
			}
			return isUnlock2 - isUnlock;
		}
		else
		{
			int num = (!ComposeModel.Instance.CheckBaseItemData(structureData, EBaseItemDataCheckMask.All)) ? 1 : 0;
			int num2 = (!ComposeModel.Instance.CheckBaseItemData(structureData2, EBaseItemDataCheckMask.All)) ? 1 : 0;
			if (num != num2)
			{
				return num - num2;
			}
			return structureData.SortId - structureData2.SortId;
		}
	}

	// Token: 0x0600B7E0 RID: 47072 RVA: 0x00299EA4 File Offset: 0x002980A4
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IStructureData structureData = a as IStructureData;
		if (structureData == null)
		{
			return 0;
		}
		IStructureData structureData2 = b as IStructureData;
		if (structureData2 == null)
		{
			return 0;
		}
		if (structureData2.IsUnlock != structureData.IsUnlock)
		{
			int num = structureData2.IsUnlock - structureData.IsUnlock;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			if (structureData.Quality != structureData2.Quality)
			{
				return (structureData2.Quality - structureData.Quality) * (isAscending ? -1 : 1);
			}
			return structureData.SortId - structureData2.SortId;
		}
	}

	// Token: 0x0600B7E1 RID: 47073 RVA: 0x00299F20 File Offset: 0x00298120
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EComposeStructureSortWayType.Menu, new TSortResult(this.SortMenu));
		this.SortMap.Add(EComposeStructureSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EComposeStructureSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
