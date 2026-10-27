using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x02001886 RID: 6278
[NullableContext(1)]
[Nullable(0)]
public class FishingItemSort : CommonSort<EFishingItemSortWayType>
{
	// Token: 0x0600B7F5 RID: 47093 RVA: 0x0029A4AC File Offset: 0x002986AC
	private int SortGetState(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IFishingHandBookItemData fishingHandBookItemData = a as IFishingHandBookItemData;
		if (fishingHandBookItemData == null)
		{
			return 0;
		}
		IFishingHandBookItemData fishingHandBookItemData2 = b as IFishingHandBookItemData;
		if (fishingHandBookItemData2 == null)
		{
			return 0;
		}
		int num = (FishingModel.Instance.FishingItemHandBookDataMap.ContainsKey(fishingHandBookItemData.Id) > false) ? 1 : 0;
		int num2 = (FishingModel.Instance.FishingItemHandBookDataMap.ContainsKey(fishingHandBookItemData2.Id) > false) ? 1 : 0;
		if (num != num2)
		{
			int num3 = num - num2;
			if (!isAscending)
			{
				return -num3;
			}
			return num3;
		}
		else
		{
			int num4 = fishingHandBookItemData2.HandBookId - fishingHandBookItemData.HandBookId;
			if (!isAscending)
			{
				return -num4;
			}
			return num4;
		}
	}

	// Token: 0x0600B7F6 RID: 47094 RVA: 0x0029A530 File Offset: 0x00298730
	private int SortHandBookId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IFishingHandBookItemData fishingHandBookItemData = a as IFishingHandBookItemData;
		if (fishingHandBookItemData == null)
		{
			return 0;
		}
		IFishingHandBookItemData fishingHandBookItemData2 = b as IFishingHandBookItemData;
		if (fishingHandBookItemData2 == null)
		{
			return 0;
		}
		int num = fishingHandBookItemData2.HandBookId - fishingHandBookItemData.HandBookId;
		if (!isAscending)
		{
			return -num;
		}
		return num;
	}

	// Token: 0x0600B7F7 RID: 47095 RVA: 0x0029A56A File Offset: 0x0029876A
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EFishingItemSortWayType.GetState, new TSortResult(this.SortGetState));
		this.SortMap.Add(EFishingItemSortWayType.HandBookId, new TSortResult(this.SortHandBookId));
	}
}
