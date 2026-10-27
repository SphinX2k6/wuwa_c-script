using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020034F9 RID: 13561
[NullableContext(1)]
[Nullable(0)]
public class CreatureDensityContainer
{
	// Token: 0x0601DBBA RID: 121786 RVA: 0x00854DBD File Offset: 0x00852FBD
	public Dictionary<long, CreatureDensityItem> GetLevel(int level)
	{
		while (this.DensityArray.Count <= level)
		{
			this.DensityArray.Add(new Dictionary<long, CreatureDensityItem>());
		}
		return this.DensityArray[level];
	}

	// Token: 0x0601DBBB RID: 121787 RVA: 0x00854DEB File Offset: 0x00852FEB
	[NullableContext(2)]
	public CreatureDensityItem GetItem(long creatureDataId)
	{
		return this.CreatureDensityMap.GetValueOrDefault(creatureDataId);
	}

	// Token: 0x0601DBBC RID: 121788 RVA: 0x00854DFC File Offset: 0x00852FFC
	public CreatureDensityItem GetItemByPbDataId(int pbDataId)
	{
		CreatureDensityItem result;
		if (!this.PbDataDensityMap.TryGetValue(pbDataId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0601DBBD RID: 121789 RVA: 0x00854E1C File Offset: 0x0085301C
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

	// Token: 0x0601DBBE RID: 121790 RVA: 0x00854E90 File Offset: 0x00853090
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

	// Token: 0x0601DBBF RID: 121791 RVA: 0x00854EEC File Offset: 0x008530EC
	public void Clear()
	{
		this.CreatureDensityMap.Clear();
		this.PbDataDensityMap.Clear();
		foreach (Dictionary<long, CreatureDensityItem> dictionary in this.DensityArray)
		{
			dictionary.Clear();
		}
	}

	// Token: 0x0400E953 RID: 59731
	protected readonly List<Dictionary<long, CreatureDensityItem>> DensityArray = new List<Dictionary<long, CreatureDensityItem>>();

	// Token: 0x0400E954 RID: 59732
	protected readonly Dictionary<long, CreatureDensityItem> CreatureDensityMap = new Dictionary<long, CreatureDensityItem>();

	// Token: 0x0400E955 RID: 59733
	protected readonly Dictionary<int, CreatureDensityItem> PbDataDensityMap = new Dictionary<int, CreatureDensityItem>();
}
