using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;

// Token: 0x0200187F RID: 6271
[NullableContext(1)]
[Nullable(0)]
public class ComposeSort : CommonSort<EComposeSortWayType>
{
	// Token: 0x0600B7D9 RID: 47065 RVA: 0x00299C1C File Offset: 0x00297E1C
	private int SortMenu(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IReagentProductionData reagentProductionData = a as IReagentProductionData;
		if (reagentProductionData == null)
		{
			return 0;
		}
		IReagentProductionData reagentProductionData2 = b as IReagentProductionData;
		if (reagentProductionData2 == null)
		{
			return 0;
		}
		if (reagentProductionData.SubType != reagentProductionData2.SubType)
		{
			return (reagentProductionData2.SubType - reagentProductionData.SubType) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x0600B7DA RID: 47066 RVA: 0x00299C68 File Offset: 0x00297E68
	private int SortMake(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IReagentProductionData reagentProductionData = a as IReagentProductionData;
		if (reagentProductionData == null)
		{
			return 0;
		}
		IReagentProductionData reagentProductionData2 = b as IReagentProductionData;
		if (reagentProductionData2 == null)
		{
			return 0;
		}
		if (reagentProductionData2.IsUnlock != reagentProductionData.IsUnlock)
		{
			int num = reagentProductionData2.IsUnlock - reagentProductionData.IsUnlock;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			int num2 = (!ComposeModel.Instance.CheckBaseItemData(reagentProductionData, EBaseItemDataCheckMask.All)) ? 1 : 0;
			int num3 = (!ComposeModel.Instance.CheckBaseItemData(reagentProductionData2, EBaseItemDataCheckMask.All)) ? 1 : 0;
			if (num2 != num3)
			{
				return num2 - num3;
			}
			return reagentProductionData.SortId - reagentProductionData2.SortId;
		}
	}

	// Token: 0x0600B7DB RID: 47067 RVA: 0x00299CF4 File Offset: 0x00297EF4
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IReagentProductionData reagentProductionData = a as IReagentProductionData;
		if (reagentProductionData == null)
		{
			return 0;
		}
		IReagentProductionData reagentProductionData2 = b as IReagentProductionData;
		if (reagentProductionData2 == null)
		{
			return 0;
		}
		if (reagentProductionData2.IsUnlock != reagentProductionData.IsUnlock)
		{
			int num = reagentProductionData2.IsUnlock - reagentProductionData.IsUnlock;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			if (reagentProductionData.Quality != reagentProductionData2.Quality)
			{
				return (reagentProductionData2.Quality - reagentProductionData.Quality) * (isAscending ? -1 : 1);
			}
			return reagentProductionData.SortId - reagentProductionData2.SortId;
		}
	}

	// Token: 0x0600B7DC RID: 47068 RVA: 0x00299D70 File Offset: 0x00297F70
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EComposeSortWayType.Menu, new TSortResult(this.SortMenu));
		this.SortMap.Add(EComposeSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EComposeSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
