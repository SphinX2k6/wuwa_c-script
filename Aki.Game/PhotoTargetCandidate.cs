using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020025A0 RID: 9632
[NullableContext(2)]
[Nullable(0)]
public class PhotoTargetCandidate
{
	// Token: 0x0601381C RID: 79900 RVA: 0x004DEEB0 File Offset: 0x004DD0B0
	private PhotoTargetCandidate(EntityHandle entity, AActor actor)
	{
		this.Entity = entity;
		this.Actor = actor;
	}

	// Token: 0x0601381D RID: 79901 RVA: 0x004DEEC8 File Offset: 0x004DD0C8
	public Vector GetPosition()
	{
		if (this.Entity != null)
		{
			WorldEntity entity = this.Entity.Entity;
			BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return null;
			}
			return baseActorComponent.ActorLocationProxy;
		}
		else
		{
			if (this.Actor != null)
			{
				FVectorDouble fvectorDouble = this.Actor.D_K2_GetActorLocation();
				return Vector.Create(fvectorDouble.X, fvectorDouble.Y, fvectorDouble.Z);
			}
			return null;
		}
	}

	// Token: 0x0601381E RID: 79902 RVA: 0x004DEF30 File Offset: 0x004DD130
	public int? GetPbDataId()
	{
		EntityHandle entity = this.Entity;
		if (entity == null)
		{
			return null;
		}
		return new int?(entity.PbDataId);
	}

	// Token: 0x0601381F RID: 79903 RVA: 0x004DEF5B File Offset: 0x004DD15B
	public AActor GetActor()
	{
		if (this.Entity == null)
		{
			return this.Actor;
		}
		WorldEntity entity = this.Entity.Entity;
		BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return null;
		}
		return baseActorComponent.Owner;
	}

	// Token: 0x06013820 RID: 79904 RVA: 0x004DEF8E File Offset: 0x004DD18E
	[NullableContext(1)]
	public static PhotoTargetCandidate CreateFromEntity(EntityHandle handle)
	{
		return new PhotoTargetCandidate(handle, null);
	}

	// Token: 0x06013821 RID: 79905 RVA: 0x004DEF97 File Offset: 0x004DD197
	[NullableContext(1)]
	public static PhotoTargetCandidate CreateFromActor(AActor actor)
	{
		return new PhotoTargetCandidate(null, actor);
	}

	// Token: 0x0400933F RID: 37695
	private readonly EntityHandle Entity;

	// Token: 0x04009340 RID: 37696
	private readonly AActor Actor;
}
