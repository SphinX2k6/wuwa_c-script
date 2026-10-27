using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FAD RID: 4013
[NullableContext(1)]
[Nullable(0)]
public class FurnitureEntityVisibleManager
{
	// Token: 0x06006694 RID: 26260 RVA: 0x00144218 File Offset: 0x00142418
	public void LockFurnitureEntity()
	{
		this.FurnitureEntityLock = true;
	}

	// Token: 0x06006695 RID: 26261 RVA: 0x00144221 File Offset: 0x00142421
	public void UnlockFurnitureEntity()
	{
		this.FurnitureEntityLock = false;
	}

	// Token: 0x06006696 RID: 26262 RVA: 0x0014422C File Offset: 0x0014242C
	public void DisabledAllEntities()
	{
		if (this.DisabledEntityList.Count > 0)
		{
			return;
		}
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities == null)
		{
			return;
		}
		int handleId = FurnitureModel.Instance.HandleId;
		SpringFestival value = FurnitureConfig.Instance.GetGameplayConfigById(handleId).Value;
		int[] entityWhiteListArray = value.GetEntityWhiteListArray();
		int shopNpcEntityId = value.ShopNpcEntityId;
		foreach (EntityHandle entityHandle in allEntities)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Active)
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				if (component != null && this.EntityTypeFilter(component))
				{
					bool flag = false;
					for (int i = 0; i < entityWhiteListArray.Length; i++)
					{
						if (entityWhiteListArray[i] == entityHandle.PbDataId)
						{
							flag = true;
							break;
						}
					}
					if (!flag && entityHandle.PbDataId != shopNpcEntityId)
					{
						CreatureController.Instance.SetEntityEnable(entity, false, "进入家具装修状态", false);
						this.DisabledEntityList.Add(entityHandle);
					}
				}
			}
		}
	}

	// Token: 0x06006697 RID: 26263 RVA: 0x0014434C File Offset: 0x0014254C
	public void EnabledAllEntities()
	{
		this.EnableAllFurnitureEntity();
		if (this.DisabledEntityList.Count == 0)
		{
			return;
		}
		foreach (EntityHandle entityHandle in this.DisabledEntityList)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null)
			{
				CreatureController.Instance.SetEntityEnable(entity, true, "离开家具装修状态", false);
			}
		}
		this.DisabledEntityList.Clear();
	}

	// Token: 0x06006698 RID: 26264 RVA: 0x001443D4 File Offset: 0x001425D4
	public void EnableAllFurnitureEntity()
	{
		if (this.FurnitureEntityLock)
		{
			return;
		}
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities == null)
		{
			return;
		}
		foreach (EntityHandle entityHandle in allEntities)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && !entity.Active)
			{
				CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
				if (component != null)
				{
					int furnitureSlotId = component.FurnitureSlotId;
					int furnitureId = component.FurnitureId;
					if (furnitureSlotId > 0 && furnitureId > 0)
					{
						CreatureController.Instance.SetEntityEnable(entity, true, "进入家具装修状态", false);
					}
				}
			}
		}
	}

	// Token: 0x06006699 RID: 26265 RVA: 0x00144474 File Offset: 0x00142674
	public bool TryEnableFurnitureEntity(EntityHandle entityHandle)
	{
		if (this.FurnitureEntityLock)
		{
			return false;
		}
		WorldEntity entity = entityHandle.Entity;
		if (entity == null)
		{
			return false;
		}
		if (entity.Active)
		{
			return false;
		}
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return false;
		}
		int furnitureSlotId = component.FurnitureSlotId;
		int furnitureId = component.FurnitureId;
		if (furnitureSlotId <= 0 || furnitureId <= 0)
		{
			return false;
		}
		CreatureController.Instance.SetEntityEnable(entity, true, "FurnitureAddByAoi", false);
		return true;
	}

	// Token: 0x0600669A RID: 26266 RVA: 0x001444D8 File Offset: 0x001426D8
	public void EnableSpareShopNpcEntity()
	{
		int handleId = FurnitureModel.Instance.HandleId;
		int spareShopNpcEntityId = FurnitureConfig.Instance.GetGameplayConfigById(handleId).Value.SpareShopNpcEntityId;
		this.SpareShopNpcEntityHandle = CreatureModel.Instance.GetEntityByPbDataId(spareShopNpcEntityId);
		EntityHandle spareShopNpcEntityHandle = this.SpareShopNpcEntityHandle;
		WorldEntity worldEntity = (spareShopNpcEntityHandle != null) ? spareShopNpcEntityHandle.Entity : null;
		if (worldEntity == null)
		{
			return;
		}
		CreatureController.Instance.SetEntityEnable(worldEntity, true, "进入家具装修状态", false);
	}

	// Token: 0x0600669B RID: 26267 RVA: 0x00144548 File Offset: 0x00142748
	public void DisableSpareShopNpcEntity()
	{
		EntityHandle spareShopNpcEntityHandle = this.SpareShopNpcEntityHandle;
		WorldEntity worldEntity = (spareShopNpcEntityHandle != null) ? spareShopNpcEntityHandle.Entity : null;
		if (worldEntity == null)
		{
			return;
		}
		CreatureController.Instance.SetEntityEnable(worldEntity, false, "退出家具装修状态", false);
		this.SpareShopNpcEntityHandle = null;
	}

	// Token: 0x0600669C RID: 26268 RVA: 0x00144585 File Offset: 0x00142785
	private bool EntityTypeFilter(CreatureDataComponent creatureComponent)
	{
		return creatureComponent.IsRole() || creatureComponent.IsPlayer() || creatureComponent.IsNpc() || creatureComponent.IsSceneItem() || creatureComponent.IsAnimal();
	}

	// Token: 0x04002E92 RID: 11922
	private readonly List<EntityHandle> DisabledEntityList = new List<EntityHandle>();

	// Token: 0x04002E93 RID: 11923
	[Nullable(2)]
	private EntityHandle SpareShopNpcEntityHandle;

	// Token: 0x04002E94 RID: 11924
	private bool FurnitureEntityLock;
}
