using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F25 RID: 7973
[NullableContext(1)]
[Nullable(0)]
public class HudEntitySet
{
	// Token: 0x0600F581 RID: 62849 RVA: 0x003B3696 File Offset: 0x003B1896
	public void Initialize()
	{
	}

	// Token: 0x0600F582 RID: 62850 RVA: 0x003B3698 File Offset: 0x003B1898
	public void Clear()
	{
		this.HudUnitEntityList.Clear();
		this.HudUnitEntityMap.Clear();
	}

	// Token: 0x0600F583 RID: 62851 RVA: 0x003B36B0 File Offset: 0x003B18B0
	public HudEntityData Add(Entity entity)
	{
		HudEntityData hudEntityData = new HudEntityData();
		hudEntityData.Initialize(entity);
		this.HudUnitEntityMap[(long)entity.Id] = hudEntityData;
		this.HudUnitEntityList.Add(hudEntityData);
		return hudEntityData;
	}

	// Token: 0x0600F584 RID: 62852 RVA: 0x003B36EC File Offset: 0x003B18EC
	public void Remove(Entity entity)
	{
		HudEntityData byEntity = this.GetByEntity(entity);
		if (byEntity == null)
		{
			return;
		}
		byEntity.Destroy();
		this.HudUnitEntityList.Remove(byEntity);
		this.HudUnitEntityMap.Remove((long)entity.Id);
	}

	// Token: 0x0600F585 RID: 62853 RVA: 0x003B372B File Offset: 0x003B192B
	public int Num()
	{
		return this.HudUnitEntityList.Count;
	}

	// Token: 0x0600F586 RID: 62854 RVA: 0x003B3738 File Offset: 0x003B1938
	[return: Nullable(2)]
	public HudEntityData GetByEntity(Entity entity)
	{
		HudEntityData result;
		this.HudUnitEntityMap.TryGetValue((long)entity.Id, out result);
		return result;
	}

	// Token: 0x0600F587 RID: 62855 RVA: 0x003B375C File Offset: 0x003B195C
	[NullableContext(2)]
	public HudEntityData GetByEntityId(long entityId)
	{
		HudEntityData result;
		this.HudUnitEntityMap.TryGetValue(entityId, out result);
		return result;
	}

	// Token: 0x0600F588 RID: 62856 RVA: 0x003B3779 File Offset: 0x003B1979
	public List<HudEntityData> GetAll()
	{
		return this.HudUnitEntityList;
	}

	// Token: 0x0400719D RID: 29085
	private List<HudEntityData> HudUnitEntityList = new List<HudEntityData>();

	// Token: 0x0400719E RID: 29086
	private Dictionary<long, HudEntityData> HudUnitEntityMap = new Dictionary<long, HudEntityData>();
}
