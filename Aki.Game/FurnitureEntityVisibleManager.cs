using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000462 RID: 1122
[NullableContext(1)]
[Nullable(0)]
public class FurnitureEntityVisibleManager
{
	// Token: 0x06003A2C RID: 14892 RVA: 0x0014CAAC File Offset: 0x0014ACAC
	public void LockFurnitureEntity()
	{
		this.FurnitureEntityLock = true;
	}

	// Token: 0x06003A2D RID: 14893 RVA: 0x0014CAB5 File Offset: 0x0014ACB5
	public void UnlockFurnitureEntity()
	{
		this.FurnitureEntityLock = false;
	}

	// Token: 0x06003A2E RID: 14894 RVA: 0x0014CAC0 File Offset: 0x0014ACC0
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

	// Token: 0x06003A2F RID: 14895 RVA: 0x0014CBE0 File Offset: 0x0014ADE0
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

	// Token: 0x06003A30 RID: 14896 RVA: 0x0014CC68 File Offset: 0x0014AE68
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

	// Token: 0x06003A31 RID: 14897 RVA: 0x0014CD08 File Offset: 0x0014AF08
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

	// Token: 0x06003A32 RID: 14898 RVA: 0x0014CD6C File Offset: 0x0014AF6C
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

	// Token: 0x06003A33 RID: 14899 RVA: 0x0014CDDC File Offset: 0x0014AFDC
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

	// Token: 0x06003A34 RID: 14900 RVA: 0x0014CE19 File Offset: 0x0014B019
	private bool EntityTypeFilter(CreatureDataComponent creatureComponent)
	{
		return creatureComponent.IsRole() || creatureComponent.IsPlayer() || creatureComponent.IsNpc() || creatureComponent.IsSceneItem() || creatureComponent.IsAnimal();
	}

	// Token: 0x04002F2B RID: 12075
	private readonly List<EntityHandle> DisabledEntityList = new List<EntityHandle>();

	// Token: 0x04002F2C RID: 12076
	[Nullable(2)]
	private EntityHandle SpareShopNpcEntityHandle;

	// Token: 0x04002F2D RID: 12077
	private bool FurnitureEntityLock;
}
