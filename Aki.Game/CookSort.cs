using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Cook;

// Token: 0x02000D3C RID: 3388
[NullableContext(1)]
[Nullable(0)]
public class CookSort : CommonSort<ECookSortWayType>
{
	// Token: 0x06008BCC RID: 35788 RVA: 0x002A4698 File Offset: 0x002A2898
	private int SortMenu(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ICookingData cookingData = a as ICookingData;
		ICookingData cookingData2 = b as ICookingData;
		if (cookingData.SubType != cookingData2.SubType)
		{
			return (cookingData2.SubType - cookingData.SubType) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008BCD RID: 35789 RVA: 0x002A46D8 File Offset: 0x002A28D8
	private int SortMake(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ICookingData cookingData = a as ICookingData;
		ICookingData cookingData2 = b as ICookingData;
		if (cookingData2.IsUnLock != cookingData.IsUnLock)
		{
			int num = cookingData2.IsUnLock ? 1 : -1;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			if (cookingData2.IsCook == cookingData.IsCook)
			{
				return 0;
			}
			int num2 = cookingData2.IsCook - cookingData.IsCook;
			if (!isAscending)
			{
				return -num2;
			}
			return num2;
		}
	}

	// Token: 0x06008BCE RID: 35790 RVA: 0x002A473C File Offset: 0x002A293C
	private int SortMakeMachining(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IMachiningData machiningData = a as IMachiningData;
		IMachiningData machiningData2 = b as IMachiningData;
		int num = 0;
		if (machiningData.IsUnLock == machiningData2.IsUnLock)
		{
			num = machiningData2.IsMachining - machiningData.IsMachining;
		}
		else if (machiningData.IsUnLock)
		{
			num = -1;
		}
		else if (machiningData2.IsUnLock)
		{
			num = 1;
		}
		return isAscending ? num : (num * -1);
	}

	// Token: 0x06008BCF RID: 35791 RVA: 0x002A4798 File Offset: 0x002A2998
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ICookItemData cookItemData = a as ICookItemData;
		ICookItemData cookItemData2 = b as ICookItemData;
		if (cookItemData.Quality != cookItemData2.Quality)
		{
			return (cookItemData2.Quality - cookItemData.Quality) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008BD0 RID: 35792 RVA: 0x002A47D8 File Offset: 0x002A29D8
	private int SortItemId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ICookItemData cookItemData = a as ICookItemData;
		ICookItemData cookItemData2 = b as ICookItemData;
		if (cookItemData.ItemId != cookItemData2.ItemId)
		{
			return cookItemData.ItemId - cookItemData2.ItemId;
		}
		return 0;
	}

	// Token: 0x06008BD1 RID: 35793 RVA: 0x002A4810 File Offset: 0x002A2A10
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(ECookSortWayType.Menu, new TSortResult(this.SortMenu));
		this.SortMap.Add(ECookSortWayType.MakeMachining, new TSortResult(this.SortMakeMachining));
		this.SortMap.Add(ECookSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(ECookSortWayType.ItemId, new TSortResult(this.SortItemId));
		this.SortMap.Add(ECookSortWayType.Make, new TSortResult(this.SortMake));
	}
}
