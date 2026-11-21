using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;

// Token: 0x02000D38 RID: 3384
[NullableContext(1)]
[Nullable(0)]
public class ComposeSort : CommonSort<EComposeSortWayType>
{
	// Token: 0x06008BC2 RID: 35778 RVA: 0x002A4334 File Offset: 0x002A2534
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

	// Token: 0x06008BC3 RID: 35779 RVA: 0x002A4380 File Offset: 0x002A2580
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

	// Token: 0x06008BC4 RID: 35780 RVA: 0x002A440C File Offset: 0x002A260C
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

	// Token: 0x06008BC5 RID: 35781 RVA: 0x002A4488 File Offset: 0x002A2688
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EComposeSortWayType.Menu, new TSortResult(this.SortMenu));
		this.SortMap.Add(EComposeSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EComposeSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
