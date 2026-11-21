using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x020027DB RID: 10203
[NullableContext(1)]
[Nullable(0)]
public class VehicleBasePlatform : BasePlatform
{
	// Token: 0x06019A40 RID: 105024 RVA: 0x007E40B4 File Offset: 0x007E22B4
	public VehicleBasePlatform(EntityHandle entityHandle) : base(entityHandle)
	{
		this.IsDeltaBaseSpeedNeedZ = true;
		EntityHandle entityHandle2 = this.EntityHandle;
		SceneItemActorComponent sceneItemActorComponent = (entityHandle2 != null) ? entityHandle2.Entity.GetComponent<SceneItemActorComponent>() : null;
		SceneInteractionActor sceneInteractionActor = ((sceneItemActorComponent != null) ? sceneItemActorComponent.GetInteractionMainActor() : null) as SceneInteractionActor;
		if (sceneInteractionActor != null)
		{
			AActor attachParentActor = sceneInteractionActor.GetAttachParentActor();
			if (attachParentActor == null)
			{
				return;
			}
			AActor aactor = null;
			if (sceneInteractionActor.CollisionActors != null && sceneInteractionActor.CollisionActors.Num() > 0)
			{
				TArray<AActor> collisionActors = sceneInteractionActor.CollisionActors;
				aactor = ((collisionActors != null) ? collisionActors.Get(0) : null);
			}
			if (aactor == null)
			{
				aactor = attachParentActor;
			}
			FVector fvector = default(FVector);
			FVector fvector2 = default(FVector);
			aactor.GetActorBounds(true, ref fvector, ref fvector2, true);
			float num = Math.Max(fvector2.X, Math.Max(fvector2.Y, fvector2.Z));
			num += 50f;
			this.LeaveSphereRadiusSq = (double)(num * num);
		}
		object obj;
		if (sceneItemActorComponent == null)
		{
			obj = null;
		}
		else
		{
			CreatureDataComponent creatureData = sceneItemActorComponent.CreatureData;
			obj = ((creatureData != null) ? creatureData.GetPbEntityInitData() : null);
		}
		object obj2 = obj;
		Dictionary<EConfigComponent, IComponentBase> dictionary = (obj2 != null) ? obj2.ComponentsData : null;
		if (dictionary != null)
		{
			VehicleComponent component = TdUtils.GetComponent<VehicleComponent>(dictionary, EConfigComponent.VehicleComponent);
			if (((component != null) ? component.VehicleFeatures : null) != null)
			{
				foreach (IVehicleFeature vehicleFeature in component.VehicleFeatures)
				{
					IMovablePlatformVehicleFeature movablePlatformVehicleFeature = vehicleFeature as IMovablePlatformVehicleFeature;
					if (movablePlatformVehicleFeature != null)
					{
						using (List<int>.Enumerator enumerator2 = movablePlatformVehicleFeature.PlayerAttachTags.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								int item = enumerator2.Current;
								this.PlatformTags.Add(item);
							}
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06019A41 RID: 105025 RVA: 0x007E429C File Offset: 0x007E249C
	public override void TransformFromRelativeSpace(FVectorDouble inPosition, FRotator inRotation, ref FVectorDouble outPosition, ref FRotator outRotation)
	{
		EntityHandle entityHandle = this.EntityHandle;
		((entityHandle != null) ? entityHandle.Entity.GetComponent<VehicleActorComponent>() : null).SkeletalMesh.D_TransformFromBoneSpace(this.BoneName ?? FName.NAME_None, inPosition, inRotation, ref outPosition, ref outRotation);
	}

	// Token: 0x06019A42 RID: 105026 RVA: 0x007E42F0 File Offset: 0x007E24F0
	public override void TransformToRelativeSpace(FVectorDouble inPosition, FRotator inRotation, ref FVectorDouble outPosition, ref FRotator outRotation)
	{
		EntityHandle entityHandle = this.EntityHandle;
		((entityHandle != null) ? entityHandle.Entity.GetComponent<VehicleActorComponent>() : null).SkeletalMesh.D_TransformToBoneSpace(this.BoneName ?? FName.NAME_None, inPosition, inRotation, ref outPosition, ref outRotation);
	}

	// Token: 0x06019A43 RID: 105027 RVA: 0x007E4344 File Offset: 0x007E2544
	public override FTransformDouble? GetTransform()
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null)
		{
			return null;
		}
		return new FTransformDouble?(entityHandle.Entity.GetComponent<BaseActorComponent>().ActorTransform);
	}

	// Token: 0x06019A44 RID: 105028 RVA: 0x007E437C File Offset: 0x007E257C
	public override bool CheckLeave(Entity entity, Vector location)
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return true;
		}
		VehicleActorComponent component = this.EntityHandle.Entity.GetComponent<VehicleActorComponent>();
		this.CacheLocation.DeepCopy(component.ActorLocationProxy);
		if (Vector.DistSquared(location, this.CacheLocation) > this.LeaveSphereRadiusSq)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity2 = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			BaseTagComponent baseTagComponent = (entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null;
			if (this.PlatformTags.Count > 0)
			{
				foreach (int value in this.PlatformTags)
				{
					if (baseTagComponent != null)
					{
						baseTagComponent.RemoveTag(new int?(value));
					}
				}
				base.RequestEnterOrLeave(false);
			}
			return true;
		}
		return false;
	}

	// Token: 0x06019A45 RID: 105029 RVA: 0x007E4460 File Offset: 0x007E2660
	public override void OnCharacterEnter(Entity entity, UCharacterMovementComponent characterMovement)
	{
		if (!this.EntityHandle.Valid)
		{
			return;
		}
		UeSkeletalTickManageComponent component = this.EntityHandle.Entity.GetComponent<UeSkeletalTickManageComponent>();
		if (component != null)
		{
			component.SetTakeOverTick(true);
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity2 = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
		BaseTagComponent baseTagComponent = (entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null;
		if (this.PlatformTags.Count > 0)
		{
			foreach (int value in this.PlatformTags)
			{
				if (baseTagComponent != null)
				{
					baseTagComponent.AddTag(new int?(value));
				}
			}
			base.RequestEnterOrLeave(true);
		}
	}

	// Token: 0x0400E0CF RID: 57551
	public double LeaveSphereRadiusSq;

	// Token: 0x0400E0D0 RID: 57552
	public FName? BoneName = new FName?(new FName("Bone_Prop001"));

	// Token: 0x0400E0D1 RID: 57553
	protected readonly Vector CacheLocation = Vector.Create();

	// Token: 0x0400E0D2 RID: 57554
	private readonly List<int> PlatformTags = new List<int>();
}
