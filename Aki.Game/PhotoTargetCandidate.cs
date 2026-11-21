using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001A8B RID: 6795
[NullableContext(2)]
[Nullable(0)]
public class PhotoTargetCandidate
{
	// Token: 0x06010CFE RID: 68862 RVA: 0x004ED9E4 File Offset: 0x004EBBE4
	private PhotoTargetCandidate(EntityHandle entity, AActor actor)
	{
		this.Entity = entity;
		this.Actor = actor;
	}

	// Token: 0x06010CFF RID: 68863 RVA: 0x004ED9FC File Offset: 0x004EBBFC
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

	// Token: 0x06010D00 RID: 68864 RVA: 0x004EDA64 File Offset: 0x004EBC64
	public int? GetPbDataId()
	{
		EntityHandle entity = this.Entity;
		if (entity == null)
		{
			return null;
		}
		return new int?(entity.PbDataId);
	}

	// Token: 0x06010D01 RID: 68865 RVA: 0x004EDA8F File Offset: 0x004EBC8F
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

	// Token: 0x06010D02 RID: 68866 RVA: 0x004EDAC2 File Offset: 0x004EBCC2
	[NullableContext(1)]
	public static PhotoTargetCandidate CreateFromEntity(EntityHandle handle)
	{
		return new PhotoTargetCandidate(handle, null);
	}

	// Token: 0x06010D03 RID: 68867 RVA: 0x004EDACB File Offset: 0x004EBCCB
	[NullableContext(1)]
	public static PhotoTargetCandidate CreateFromActor(AActor actor)
	{
		return new PhotoTargetCandidate(null, actor);
	}

	// Token: 0x04009497 RID: 38039
	private readonly EntityHandle Entity;

	// Token: 0x04009498 RID: 38040
	private readonly AActor Actor;
}
