using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Compose;

// Token: 0x02000D36 RID: 3382
[NullableContext(1)]
[Nullable(0)]
public class ComposePurificationSort : CommonSort<EComposePurificationSortWayType>
{
	// Token: 0x06008BBE RID: 35774 RVA: 0x002A41D4 File Offset: 0x002A23D4
	private int SortMake(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IPurificationData purificationData = a as IPurificationData;
		if (purificationData == null)
		{
			return 0;
		}
		IPurificationData purificationData2 = b as IPurificationData;
		if (purificationData2 == null)
		{
			return 0;
		}
		if (purificationData.IsUnlock != purificationData2.IsUnlock)
		{
			return (purificationData2.IsUnlock - purificationData.IsUnlock) * (isAscending ? -1 : 1);
		}
		int isUnlock = purificationData.IsUnlock;
		int isUnlock2 = purificationData2.IsUnlock;
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
			int num = (!ComposeModel.Instance.CheckBaseItemData(purificationData, EBaseItemDataCheckMask.All)) ? 1 : 0;
			int num2 = (!ComposeModel.Instance.CheckBaseItemData(purificationData2, EBaseItemDataCheckMask.All)) ? 1 : 0;
			if (num != num2)
			{
				return num - num2;
			}
			return purificationData.SortId - purificationData2.SortId;
		}
	}

	// Token: 0x06008BBF RID: 35775 RVA: 0x002A4280 File Offset: 0x002A2480
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IPurificationData purificationData = a as IPurificationData;
		if (purificationData == null)
		{
			return 0;
		}
		IPurificationData purificationData2 = b as IPurificationData;
		if (purificationData2 == null)
		{
			return 0;
		}
		if (purificationData2.IsUnlock != purificationData.IsUnlock)
		{
			int num = purificationData2.IsUnlock - purificationData.IsUnlock;
			if (!isAscending)
			{
				return -num;
			}
			return num;
		}
		else
		{
			if (purificationData.Quality != purificationData2.Quality)
			{
				return (purificationData2.Quality - purificationData.Quality) * (isAscending ? -1 : 1);
			}
			return purificationData.ConfigId - purificationData2.ConfigId;
		}
	}

	// Token: 0x06008BC0 RID: 35776 RVA: 0x002A42FA File Offset: 0x002A24FA
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EComposePurificationSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EComposePurificationSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
