using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200326D RID: 12909
public static class BasePlatformController
{
	// Token: 0x0601BE6B RID: 114283 RVA: 0x007BCC40 File Offset: 0x007BAE40
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

	// Token: 0x0601BE6C RID: 114284 RVA: 0x007BCC88 File Offset: 0x007BAE88
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
