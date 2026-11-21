using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Capability
{
	// Token: 0x02006319 RID: 25369
	[NullableContext(2)]
	[Nullable(0)]
	public class FreezeWaterRenderCapability : WaterDetectedCapability
	{
		// Token: 0x17007479 RID: 29817
		// (get) Token: 0x0603D68A RID: 251530 RVA: 0x011C0757 File Offset: 0x011BE957
		public AActor Actor
		{
			get
			{
				return this.ActorInternal;
			}
		}

		// Token: 0x0603D68B RID: 251531 RVA: 0x011C0760 File Offset: 0x011BE960
		[NullableContext(1)]
		public FreezeWaterRenderCapability(AActor Invoker, UKuroTrailCollisionAsset KuroTrailCollisionAsset)
		{
			this.Invoker = Invoker;
			this.KuroTrailCollisionAsset = KuroTrailCollisionAsset;
			AActor invoker = this.Invoker;
			if (invoker == null || !invoker.IsValid())
			{
				return;
			}
			this.ActorInternal = ActorSystem.Instance.Spawn(AActor.StaticClass(), this.Invoker.D_GetTransform(), this.Invoker);
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null || !actorInternal.IsValid())
			{
				ActorSystem.Instance.Put("MotorcycleFreezeWaterComponent.CreateFreezeWaterDependency fail", this.ActorInternal, null);
				return;
			}
			this.ActorInternal.D_AddComponentByClass(USceneComponent.StaticClass(), false, MathUtils.Instance.DefaultTransformDouble, false, default(FName));
		}

		// Token: 0x0603D68C RID: 251532 RVA: 0x011C0819 File Offset: 0x011BEA19
		public override void Activate()
		{
			this.AddWaterInteractionComponent();
		}

		// Token: 0x0603D68D RID: 251533 RVA: 0x011C0822 File Offset: 0x011BEA22
		public override void Deactivate()
		{
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null || !actorInternal.IsValid())
			{
				ActorSystem.Instance.Put("MotorcycleFreezeWaterComponent.OnEnd", this.ActorInternal, null);
			}
			this.ActorInternal = null;
		}

		// Token: 0x0603D68E RID: 251534 RVA: 0x011C0859 File Offset: 0x011BEA59
		public override void OnWaterDetectedStart()
		{
			this.DetectingWater = true;
		}

		// Token: 0x0603D68F RID: 251535 RVA: 0x011C0862 File Offset: 0x011BEA62
		public override void OnWaterDetectedEnd()
		{
			this.DetectingWater = false;
		}

		// Token: 0x0603D690 RID: 251536 RVA: 0x011C086C File Offset: 0x011BEA6C
		[NullableContext(1)]
		public override void OnWaterDetectedTick(float deltaTime, Vector impactPoint, Vector impactNormal)
		{
			if (!this.DetectingWater)
			{
				Log.Instance.Warn(ELogModule.Movement, ELogAuthor.XDW, "FreezeWaterRenderCapability 检查BroadcastWaterDetectedTick逻辑, 未调用Start就开始Tick", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			FHitResult fhitResult = new FHitResult();
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null)
			{
				return;
			}
			actorInternal.D_K2_SetActorLocation(impactPoint.ToUeVector(false), false, ref fhitResult, false);
		}

		// Token: 0x0603D691 RID: 251537 RVA: 0x011C08C0 File Offset: 0x011BEAC0
		private BP_KuroMotorcycleFreezeWaterComponent_C AddWaterInteractionComponent()
		{
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null || !actorInternal.IsValid())
			{
				return null;
			}
			AActor invoker = this.Invoker;
			if (invoker == null || !invoker.IsValid())
			{
				return null;
			}
			BP_KuroMotorcycleFreezeWaterComponent_C bp_KuroMotorcycleFreezeWaterComponent_C = this.ActorInternal.D_AddComponentByClass(BP_KuroMotorcycleFreezeWaterComponent_C.StaticClass(), false, MathUtils.Instance.DefaultTransformDouble, true, default(FName)) as BP_KuroMotorcycleFreezeWaterComponent_C;
			if (bp_KuroMotorcycleFreezeWaterComponent_C == null || !bp_KuroMotorcycleFreezeWaterComponent_C.IsValid())
			{
				Log.Instance.Error(ELogModule.Motor, ELogAuthor.XDW, "MotorcycleFreezeWaterComponent.AddWaterInteractionComponent: materialComp is invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			bp_KuroMotorcycleFreezeWaterComponent_C.Invoker = this.Invoker;
			this.ActorInternal.FinishAddComponent(bp_KuroMotorcycleFreezeWaterComponent_C, false, MathUtils.Instance.DefaultTransform);
			bp_KuroMotorcycleFreezeWaterComponent_C.SetRelativeScale3D(new FVector(40.96f));
			return bp_KuroMotorcycleFreezeWaterComponent_C;
		}

		// Token: 0x0603D692 RID: 251538 RVA: 0x011C0998 File Offset: 0x011BEB98
		public static UKuroEnviInteractionComponent CheckKuroWaterDetectedInterface(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return null;
			}
			UKuroEnviInteractionComponent ukuroEnviInteractionComponent = actor.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent;
			if (ukuroEnviInteractionComponent == null || !ukuroEnviInteractionComponent.IsValid())
			{
				return null;
			}
			if (ukuroEnviInteractionComponent == null)
			{
				return null;
			}
			return ukuroEnviInteractionComponent;
		}

		// Token: 0x04020908 RID: 133384
		private const float ICE_MESH_SCALE = 40.96f;

		// Token: 0x04020909 RID: 133385
		private AActor ActorInternal;

		// Token: 0x0402090A RID: 133386
		private bool DetectingWater;

		// Token: 0x0402090B RID: 133387
		[Nullable(1)]
		private readonly AActor Invoker;

		// Token: 0x0402090C RID: 133388
		public UKuroTrailCollisionAsset KuroTrailCollisionAsset;
	}
}
