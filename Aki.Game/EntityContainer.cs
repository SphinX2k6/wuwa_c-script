using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020034FD RID: 13565
[NullableContext(1)]
[Nullable(0)]
public class EntityContainer
{
	// Token: 0x0601DBCE RID: 121806 RVA: 0x0085529B File Offset: 0x0085349B
	public bool AddEntity(long creatureDataId, EntityHandle handle)
	{
		if (this.EntityMap.Contains(creatureDataId))
		{
			return false;
		}
		this.EntityMap.Set(creatureDataId, handle);
		this.EntityIdMap.Add(handle.Id, creatureDataId);
		return true;
	}

	// Token: 0x0601DBCF RID: 121807 RVA: 0x008552D0 File Offset: 0x008534D0
	public bool RemoveEntity(long creatureDataId)
	{
		EntityHandle entityHandle = this.EntityMap.Get(creatureDataId);
		if (entityHandle == null)
		{
			return false;
		}
		this.EntityMap.Remove(creatureDataId);
		this.EntityIdMap.Remove(entityHandle.Id);
		if (entityHandle.ConfigType == EntityConfigType.Level)
		{
			this.PbDataIdMap.Remove(entityHandle.PbDataId);
		}
		return true;
	}

	// Token: 0x0601DBD0 RID: 121808 RVA: 0x0085532A File Offset: 0x0085352A
	[NullableContext(2)]
	public EntityHandle GetEntity(long creatureDataId)
	{
		return this.EntityMap.Get(creatureDataId);
	}

	// Token: 0x0601DBD1 RID: 121809 RVA: 0x00855338 File Offset: 0x00853538
	public bool ExistEntity(long creatureDataId)
	{
		return this.EntityMap.Contains(creatureDataId);
	}

	// Token: 0x0601DBD2 RID: 121810 RVA: 0x00855348 File Offset: 0x00853548
	[NullableContext(2)]
	public EntityHandle GetEntityById(int entityId)
	{
		long key;
		if (!this.EntityIdMap.TryGetValue(entityId, out key))
		{
			return null;
		}
		return this.EntityMap.Get(key);
	}

	// Token: 0x0601DBD3 RID: 121811 RVA: 0x00855374 File Offset: 0x00853574
	[NullableContext(2)]
	public EntityHandle GetEntityByPbDataId(int pbDataId)
	{
		long key;
		if (!this.PbDataIdMap.TryGetValue(pbDataId, out key))
		{
			return null;
		}
		return this.EntityMap.Get(key);
	}

	// Token: 0x0601DBD4 RID: 121812 RVA: 0x008553A0 File Offset: 0x008535A0
	public void CheckSetPrefabEntity(EntityHandle handle)
	{
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		if (component.GetEntityConfigType() != EntityConfigType.Level)
		{
			return;
		}
		this.PbDataIdMap[component.GetPbDataId()] = component.GetCreatureDataId();
	}

	// Token: 0x0601DBD5 RID: 121813 RVA: 0x008553DE File Offset: 0x008535DE
	public long GetCreatureDataIdByPbDataId(int pbDataId)
	{
		return this.PbDataIdMap.GetValueOrDefault(pbDataId, 0L);
	}

	// Token: 0x0601DBD6 RID: 121814 RVA: 0x008553F0 File Offset: 0x008535F0
	public EntityHandle PopEntity()
	{
		EntityHandle byIndex = this.EntityMap.GetByIndex(0);
		if (byIndex == null)
		{
			return null;
		}
		this.RemoveEntity(byIndex.CreatureDataId);
		return byIndex;
	}

	// Token: 0x0601DBD7 RID: 121815 RVA: 0x0085541D File Offset: 0x0085361D
	[NullableContext(2)]
	public EntityHandle PeekEntity()
	{
		return this.EntityMap.GetByIndex(0);
	}

	// Token: 0x0601DBD8 RID: 121816 RVA: 0x0085542B File Offset: 0x0085362B
	public IReadOnlyList<EntityHandle> GetAllEntities()
	{
		return this.EntityMap.GetItems();
	}

	// Token: 0x0601DBD9 RID: 121817 RVA: 0x00855438 File Offset: 0x00853638
	public int Size()
	{
		return this.EntityMap.Size();
	}

	// Token: 0x0601DBDA RID: 121818 RVA: 0x00855445 File Offset: 0x00853645
	public void Clear()
	{
		this.EntityMap.Clear();
		this.EntityIdMap.Clear();
		this.PbDataIdMap.Clear();
	}

	// Token: 0x0400E97A RID: 59770
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public readonly CustomMap<long, EntityHandle> EntityMap = new CustomMap<long, EntityHandle>();

	// Token: 0x0400E97B RID: 59771
	public readonly Dictionary<int, long> EntityIdMap = new Dictionary<int, long>();

	// Token: 0x0400E97C RID: 59772
	public readonly Dictionary<int, long> PbDataIdMap = new Dictionary<int, long>();
}
