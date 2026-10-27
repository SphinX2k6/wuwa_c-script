using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001CD6 RID: 7382
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowCollectionTypeItemData
{
	// Token: 0x0600DF90 RID: 57232 RVA: 0x00345CD4 File Offset: 0x00343ED4
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

	// Token: 0x0600DF91 RID: 57233 RVA: 0x00345D38 File Offset: 0x00343F38
	public int GetItemNumWithQuality(int quality)
	{
		int result;
		if (!this.ItemQualityToNumMap.TryGetValue(quality, out result))
		{
			return 0;
		}
		return result;
	}

	// Token: 0x0600DF92 RID: 57234 RVA: 0x00345D58 File Offset: 0x00343F58
	public MotorcycleArrowCollectionTypeItemData(int type)
	{
		this.Type = type;
	}

	// Token: 0x040066DC RID: 26332
	public int Type;

	// Token: 0x040066DD RID: 26333
	public int TotalCount;

	// Token: 0x040066DE RID: 26334
	public Dictionary<int, int> ItemQualityToNumMap = new Dictionary<int, int>();

	// Token: 0x040066DF RID: 26335
	public List<MotorcycleArrowCollectionItemData> ItemList = new List<MotorcycleArrowCollectionItemData>();
}
