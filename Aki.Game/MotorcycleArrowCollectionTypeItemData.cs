using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001198 RID: 4504
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionTypeItemData
{
	// Token: 0x0600B3AD RID: 45997 RVA: 0x003516FC File Offset: 0x0034F8FC
	public void AddItemData(MotorcycleArrowCollectionItemData itemData, bool newItem)
	{
		this.TotalCount++;
		int quality = itemData.Config.Quality;
		int num;
		this.ItemQualityToNumMap.TryGetValue(quality, out num);
		this.ItemQualityToNumMap[quality] = num + 1;
		if (newItem)
		{
			this.ItemList.Add(itemData);
			return;
		}
		itemData.Num++;
	}

	// Token: 0x0600B3AE RID: 45998 RVA: 0x00351760 File Offset: 0x0034F960
	public int GetItemNumWithQuality(int quality)
	{
		int result;
		if (!this.ItemQualityToNumMap.TryGetValue(quality, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600B3AF RID: 45999 RVA: 0x00351780 File Offset: 0x0034F980
	public MotorcycleArrowCollectionTypeItemData(int type)
	{
		this.Type = type;
	}

	// Token: 0x040067BB RID: 26555
	public int Type;

	// Token: 0x040067BC RID: 26556
	public int TotalCount;

	// Token: 0x040067BD RID: 26557
	public Dictionary<int, int> ItemQualityToNumMap = new Dictionary<int, int>();

	// Token: 0x040067BE RID: 26558
	public List<MotorcycleArrowCollectionItemData> ItemList = new List<MotorcycleArrowCollectionItemData>();
}
