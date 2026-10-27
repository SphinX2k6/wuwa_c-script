using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Capability
{
	// Token: 0x0200715A RID: 29018
	[NullableContext(2)]
	[Nullable(0)]
	public class FreezeWaterRenderCapability : WaterDetectedCapability
	{
		// Token: 0x17009D51 RID: 40273
		// (get) Token: 0x06046D52 RID: 290130 RVA: 0x011D9EA0 File Offset: 0x011D80A0
		public AActor Actor
		{
			get
			{
				return this.ActorInternal;
			}
		}

		// Token: 0x06046D53 RID: 290131 RVA: 0x011D9EA8 File Offset: 0x011D80A8
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

		// Token: 0x06046D54 RID: 290132 RVA: 0x011D9F61 File Offset: 0x011D8161
		public override void Activate()
		{
			this.AddWaterInteractionComponent();
		}

		// Token: 0x06046D55 RID: 290133 RVA: 0x011D9F6A File Offset: 0x011D816A
		public override void Deactivate()
		{
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null || !actorInternal.IsValid())
			{
				ActorSystem.Instance.Put("MotorcycleFreezeWaterComponent.OnEnd", this.ActorInternal, null);
			}
			this.ActorInternal = null;
		}

		// Token: 0x06046D56 RID: 290134 RVA: 0x011D9FA1 File Offset: 0x011D81A1
		public override void OnWaterDetectedStart()
		{
			this.DetectingWater = true;
		}

		// Token: 0x06046D57 RID: 290135 RVA: 0x011D9FAA File Offset: 0x011D81AA
		public override void OnWaterDetectedEnd()
		{
			this.DetectingWater = false;
		}

		// Token: 0x06046D58 RID: 290136 RVA: 0x011D9FB4 File Offset: 0x011D81B4
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

		// Token: 0x06046D59 RID: 290137 RVA: 0x011DA008 File Offset: 0x011D8208
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

		// Token: 0x06046D5A RID: 290138 RVA: 0x011DA0E0 File Offset: 0x011D82E0
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

		// Token: 0x040252CB RID: 152267
		private const float ICE_MESH_SCALE = 40.96f;

		// Token: 0x040252CC RID: 152268
		private AActor ActorInternal;

		// Token: 0x040252CD RID: 152269
		private bool DetectingWater;

		// Token: 0x040252CE RID: 152270
		[Nullable(1)]
		private readonly AActor Invoker;

		// Token: 0x040252CF RID: 152271
		public UKuroTrailCollisionAsset KuroTrailCollisionAsset;
	}
}
