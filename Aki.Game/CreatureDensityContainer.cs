using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002A6E RID: 10862
[NullableContext(1)]
[Nullable(0)]
public class CreatureDensityContainer
{
	// Token: 0x0601B8D1 RID: 112849 RVA: 0x0087D211 File Offset: 0x0087B411
	public Dictionary<long, CreatureDensityItem> GetLevel(int level)
	{
		while (this.DensityArray.Count <= level)
		{
			this.DensityArray.Add(new Dictionary<long, CreatureDensityItem>());
		}
		return this.DensityArray[level];
	}

	// Token: 0x0601B8D2 RID: 112850 RVA: 0x0087D23F File Offset: 0x0087B43F
	[NullableContext(2)]
	public CreatureDensityItem GetItem(long creatureDataId)
	{
		return this.CreatureDensityMap.GetValueOrDefault(creatureDataId);
	}

	// Token: 0x0601B8D3 RID: 112851 RVA: 0x0087D250 File Offset: 0x0087B450
	public CreatureDensityItem GetItemByPbDataId(int pbDataId)
	{
		CreatureDensityItem result;
		if (!this.PbDataDensityMap.TryGetValue(pbDataId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601B8D4 RID: 112852 RVA: 0x0087D270 File Offset: 0x0087B470
	public CreatureDensityItem AddItem(long creatureDataId, int densityLevel, EntityPb entityData)
	{
		CreatureDensityItem creatureDensityItem = new CreatureDensityItem(creatureDataId, densityLevel, entityData);
		this.CreatureDensityMap[creatureDataId] = creatureDensityItem;
		this.PbDataDensityMap[entityData.ConfigId] = creatureDensityItem;
		while (this.DensityArray.Count <= creatureDensityItem.DensityLevel)
		{
			this.DensityArray.Add(new Dictionary<long, CreatureDensityItem>());
		}
		this.DensityArray[creatureDensityItem.DensityLevel][creatureDataId] = creatureDensityItem;
		return creatureDensityItem;
	}

	// Token: 0x0601B8D5 RID: 112853 RVA: 0x0087D2E4 File Offset: 0x0087B4E4
	[NullableContext(2)]
	public CreatureDensityItem RemoveItem(long creatureDataId)
	{
		CreatureDensityItem creatureDensityItem;
		if (!this.CreatureDensityMap.TryGetValue(creatureDataId, out creatureDensityItem))
		{
			return null;
		}
		this.CreatureDensityMap.Remove(creatureDataId);
		this.PbDataDensityMap.Remove(creatureDensityItem.EntityData.ConfigId);
		this.DensityArray[creatureDensityItem.DensityLevel].Remove(creatureDataId);
		return creatureDensityItem;
	}

	// Token: 0x0601B8D6 RID: 112854 RVA: 0x0087D340 File Offset: 0x0087B540
	public void Clear()
	{
		this.CreatureDensityMap.Clear();
		this.PbDataDensityMap.Clear();
		foreach (Dictionary<long, CreatureDensityItem> dictionary in this.DensityArray)
		{
			dictionary.Clear();
		}
	}

	// Token: 0x0400EE0E RID: 60942
	protected readonly List<Dictionary<long, CreatureDensityItem>> DensityArray = new List<Dictionary<long, CreatureDensityItem>>();

	// Token: 0x0400EE0F RID: 60943
	protected readonly Dictionary<long, CreatureDensityItem> CreatureDensityMap = new Dictionary<long, CreatureDensityItem>();

	// Token: 0x0400EE10 RID: 60944
	protected readonly Dictionary<int, CreatureDensityItem> PbDataDensityMap = new Dictionary<int, CreatureDensityItem>();
}
