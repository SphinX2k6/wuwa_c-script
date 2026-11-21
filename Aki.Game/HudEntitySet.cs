using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020013E7 RID: 5095
[NullableContext(1)]
[Nullable(0)]
public class HudEntitySet
{
	// Token: 0x0600C9A0 RID: 51616 RVA: 0x003BF182 File Offset: 0x003BD382
	public void Initialize()
	{
	}

	// Token: 0x0600C9A1 RID: 51617 RVA: 0x003BF184 File Offset: 0x003BD384
	public void Clear()
	{
		this.HudUnitEntityList.Clear();
		this.HudUnitEntityMap.Clear();
	}

	// Token: 0x0600C9A2 RID: 51618 RVA: 0x003BF19C File Offset: 0x003BD39C
	public HudEntityData Add(Entity entity)
	{
		HudEntityData hudEntityData = new HudEntityData();
		hudEntityData.Initialize(entity);
		this.HudUnitEntityMap[(long)entity.Id] = hudEntityData;
		this.HudUnitEntityList.Add(hudEntityData);
		return hudEntityData;
	}

	// Token: 0x0600C9A3 RID: 51619 RVA: 0x003BF1D8 File Offset: 0x003BD3D8
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

	// Token: 0x0600C9A4 RID: 51620 RVA: 0x003BF217 File Offset: 0x003BD417
	public int Num()
	{
		return this.HudUnitEntityList.Count;
	}

	// Token: 0x0600C9A5 RID: 51621 RVA: 0x003BF224 File Offset: 0x003BD424
	[return: Nullable(2)]
	public HudEntityData GetByEntity(Entity entity)
	{
		HudEntityData result;
		this.HudUnitEntityMap.TryGetValue((long)entity.Id, out result);
		return result;
	}

	// Token: 0x0600C9A6 RID: 51622 RVA: 0x003BF248 File Offset: 0x003BD448
	[NullableContext(2)]
	public HudEntityData GetByEntityId(long entityId)
	{
		HudEntityData result;
		this.HudUnitEntityMap.TryGetValue(entityId, out result);
		return result;
	}

	// Token: 0x0600C9A7 RID: 51623 RVA: 0x003BF265 File Offset: 0x003BD465
	public List<HudEntityData> GetAll()
	{
		return this.HudUnitEntityList;
	}

	// Token: 0x0400727E RID: 29310
	private List<HudEntityData> HudUnitEntityList = new List<HudEntityData>();

	// Token: 0x0400727F RID: 29311
	private Dictionary<long, HudEntityData> HudUnitEntityMap = new Dictionary<long, HudEntityData>();
}
