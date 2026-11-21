using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;

// Token: 0x02000D3A RID: 3386
[NullableContext(1)]
[Nullable(0)]
public class ComposeStructureSort : CommonSort<EComposeStructureSortWayType>
{
	// Token: 0x06008BC7 RID: 35783 RVA: 0x002A44E8 File Offset: 0x002A26E8
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

	// Token: 0x06008BC8 RID: 35784 RVA: 0x002A4534 File Offset: 0x002A2734
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

	// Token: 0x06008BC9 RID: 35785 RVA: 0x002A45BC File Offset: 0x002A27BC
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

	// Token: 0x06008BCA RID: 35786 RVA: 0x002A4638 File Offset: 0x002A2838
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EComposeStructureSortWayType.Menu, new TSortResult(this.SortMenu));
		this.SortMap.Add(EComposeStructureSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EComposeStructureSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
