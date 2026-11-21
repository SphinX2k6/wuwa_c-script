using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020027DC RID: 10204
public static class BasePlatformController
{
	// Token: 0x06019A46 RID: 105030 RVA: 0x007E4518 File Offset: 0x007E2718
	[NullableContext(1)]
	[return: Nullable(2)]
	public static BasePlatform GetBasePlatformByBasedMovementInfo(FBasedMovementInfo basedMovement)
	{
		UPrimitiveComponent movementBase = basedMovement.MovementBase;
		AActor aactor;
		if (movementBase == null)
		{
			aactor = null;
		}
		else
		{
			AActor owner = movementBase.GetOwner();
			aactor = ((owner != null) ? owner.GetAttachRootParentActor() : null);
		}
		AActor aactor2 = aactor;
		if (aactor2 != null && aactor2.IsValid())
		{
			return BasePlatformController.GetBasePlatformByEntity(ActorUtils.GetEntityByActor(aactor2, false));
		}
		return null;
	}

	// Token: 0x06019A47 RID: 105031 RVA: 0x007E4560 File Offset: 0x007E2760
	[NullableContext(2)]
	public static BasePlatform GetBasePlatformByEntity(EntityHandle entityHandle)
	{
		if (entityHandle == null || !entityHandle.Valid)
		{
			return null;
		}
		BaseActorComponent component = entityHandle.Entity.GetComponent<BaseActorComponent>();
		if (component.OwnedBasePlatform != null)
		{
			return component.OwnedBasePlatform;
		}
		BasePlatform basePlatform = null;
		if (entityHandle.Entity.GetComponent<SceneItemActorComponent>() != null)
		{
			basePlatform = new SceneItemBasePlatform(entityHandle);
		}
		else if (entityHandle.Entity.GetComponent<CharacterActorComponent>() != null)
		{
			basePlatform = new CharacterBasePlatform(entityHandle);
		}
		else if (entityHandle.Entity.GetComponent<VehicleActorComponent>() != null)
		{
			basePlatform = new VehicleBasePlatform(entityHandle);
		}
		component.OwnedBasePlatform = basePlatform;
		return basePlatform;
	}
}
