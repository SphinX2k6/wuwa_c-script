using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002A72 RID: 10866
[NullableContext(1)]
[Nullable(0)]
public class EntityContainer
{
	// Token: 0x0601B8E5 RID: 112869 RVA: 0x0087D6EF File Offset: 0x0087B8EF
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

	// Token: 0x0601B8E6 RID: 112870 RVA: 0x0087D724 File Offset: 0x0087B924
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

	// Token: 0x0601B8E7 RID: 112871 RVA: 0x0087D77E File Offset: 0x0087B97E
	[NullableContext(2)]
	public EntityHandle GetEntity(long creatureDataId)
	{
		return this.EntityMap.Get(creatureDataId);
	}

	// Token: 0x0601B8E8 RID: 112872 RVA: 0x0087D78C File Offset: 0x0087B98C
	public bool ExistEntity(long creatureDataId)
	{
		return this.EntityMap.Contains(creatureDataId);
	}

	// Token: 0x0601B8E9 RID: 112873 RVA: 0x0087D79C File Offset: 0x0087B99C
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

	// Token: 0x0601B8EA RID: 112874 RVA: 0x0087D7C8 File Offset: 0x0087B9C8
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

	// Token: 0x0601B8EB RID: 112875 RVA: 0x0087D7F4 File Offset: 0x0087B9F4
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

	// Token: 0x0601B8EC RID: 112876 RVA: 0x0087D832 File Offset: 0x0087BA32
	public long GetCreatureDataIdByPbDataId(int pbDataId)
	{
		return this.PbDataIdMap.GetValueOrDefault(pbDataId, 0L);
	}

	// Token: 0x0601B8ED RID: 112877 RVA: 0x0087D844 File Offset: 0x0087BA44
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

	// Token: 0x0601B8EE RID: 112878 RVA: 0x0087D871 File Offset: 0x0087BA71
	[NullableContext(2)]
	public EntityHandle PeekEntity()
	{
		return this.EntityMap.GetByIndex(0);
	}

	// Token: 0x0601B8EF RID: 112879 RVA: 0x0087D87F File Offset: 0x0087BA7F
	public IReadOnlyList<EntityHandle> GetAllEntities()
	{
		return this.EntityMap.GetItems();
	}

	// Token: 0x0601B8F0 RID: 112880 RVA: 0x0087D88C File Offset: 0x0087BA8C
	public int Size()
	{
		return this.EntityMap.Size();
	}

	// Token: 0x0601B8F1 RID: 112881 RVA: 0x0087D899 File Offset: 0x0087BA99
	public void Clear()
	{
		this.EntityMap.Clear();
		this.EntityIdMap.Clear();
		this.PbDataIdMap.Clear();
	}

	// Token: 0x0400EE35 RID: 60981
	[Nullable(new byte[]
	{
		1,
		2
	})]
	public readonly CustomMap<long, EntityHandle> EntityMap = new CustomMap<long, EntityHandle>();

	// Token: 0x0400EE36 RID: 60982
	public readonly Dictionary<int, long> EntityIdMap = new Dictionary<int, long>();

	// Token: 0x0400EE37 RID: 60983
	public readonly Dictionary<int, long> PbDataIdMap = new Dictionary<int, long>();
}
