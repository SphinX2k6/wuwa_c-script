using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.PathLine;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071E1 RID: 29153
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemManipulatableCastProjectileState : SceneItemManipulableCastState
	{
		// Token: 0x060475B6 RID: 292278 RVA: 0x01224BB4 File Offset: 0x01222DB4
		[NullableContext(1)]
		public SceneItemManipulatableCastProjectileState(SceneItemManipulatableComponent SceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? CameraShake, [Nullable(2)] UKuroForceFeedbackEffect GamepadShake) : base(SceneItem, CameraShake, GamepadShake)
		{
		}

		// Token: 0x060475B7 RID: 292279 RVA: 0x01224BD8 File Offset: 0x01222DD8
		protected override void OnEnter()
		{
			base.OnEnter();
			this.GeneratePredictProjectilePoints();
			this.MoveSpeed = this.SceneItem.ManipulateBaseConfig.抛物瞄准模式初速度;
			this.Distance = 0f;
			this.LastLocation = global::Vector.Create(this.SceneItem.LastHoldingLocation);
			this.IsAfterPortal = false;
			if (this.NeedNotifyServer)
			{
				LevelGamePlayController.Instance.ManipulatableBeCastOrDrop2Server(this.SceneItem.Entity.Id, EControlState.FreeThrowing);
			}
			if (this.EnterCallback != null)
			{
				this.EnterCallback();
			}
		}

		// Token: 0x060475B8 RID: 292280 RVA: 0x01224C68 File Offset: 0x01222E68
		protected override void OnTick(float delta)
		{
			float num = this.MoveSpeed * delta;
			this.Distance += num;
			FVectorDouble value;
			if (!this.IsAfterPortal)
			{
				value = this.SplineComponent.D_GetLocationAtDistanceAlongSpline(this.Distance, ESplineCoordinateSpace.World);
			}
			else
			{
				value = this.AfterPortalSplineComponent.D_GetLocationAtDistanceAlongSpline(this.Distance, ESplineCoordinateSpace.World);
			}
			this.SceneItem.ActorComp.SetActorLocation(value, "unknown", true);
			if (!this.IsAfterPortal && this.Distance >= this.SplineComponent.GetSplineLength())
			{
				if (this.AfterPortalSplineComponent == null)
				{
					this.SceneItem.CastFreeState.NeedNotifyServer = false;
					SceneItemManipulatableComponent sceneItem = this.SceneItem;
					if (sceneItem != null)
					{
						sceneItem.SetState(SceneItemManipulatableComponent.EManipulatableState.BeCastingFree, "CastProjectileState over spline and no afterPortal");
					}
				}
				else
				{
					this.IsAfterPortal = true;
					this.SceneItem.ActorComp.SetActorLocation(this.AfterPortalSplineComponent.D_GetLocationAtDistanceAlongSpline(0f, ESplineCoordinateSpace.World), "[SceneItemManipulatableCastProjectileState] OnTeleport", false);
					this.Distance = 0f;
				}
			}
			else if (this.IsAfterPortal && this.Distance >= this.AfterPortalSplineComponent.GetSplineLength())
			{
				SceneItemManipulatableComponent sceneItem2 = this.SceneItem;
				if (sceneItem2 != null)
				{
					sceneItem2.SetState(SceneItemManipulatableComponent.EManipulatableState.Reset, "CastProjectileState over spline");
				}
			}
			this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.DynamicWaitSleep;
			this.CurrentDirection = global::Vector.Create();
			this.SceneItem.ActorComp.ActorLocationProxy.Subtraction(this.LastLocation, this.CurrentDirection);
			this.CurrentDirection.Normalize(9.99999993922529E-09);
			this.LastLocation = global::Vector.Create(this.SceneItem.ActorComp.ActorLocation);
		}

		// Token: 0x060475B9 RID: 292281 RVA: 0x01224E08 File Offset: 0x01223008
		protected override void OnExit()
		{
			base.OnExit();
			this.SceneItem.ActorComp.GetPrimitiveComponent().SetPhysicsLinearVelocity(this.CurrentDirection.MultiplyEqual((double)this.MoveSpeed).ToUeVectorOld(), false, default(FName));
			AActor splineActor = this.SplineActor;
			if (splineActor != null && splineActor.IsValid())
			{
				ActorSystem.Instance.Put("SceneItemManipulatableCastProjectileState.OnExit1", this.SplineActor, null);
				this.SplineActor = null;
				this.SplineComponent = null;
			}
			AActor afterPortalSplineActor = this.AfterPortalSplineActor;
			if (afterPortalSplineActor != null && afterPortalSplineActor.IsValid())
			{
				ActorSystem.Instance.Put("SceneItemManipulatableCastProjectileState.OnExit2", this.AfterPortalSplineActor, null);
				this.AfterPortalSplineActor = null;
				this.AfterPortalSplineComponent = null;
			}
		}

		// Token: 0x060475BA RID: 292282 RVA: 0x01224EC4 File Offset: 0x012230C4
		private void GeneratePredictProjectilePoints()
		{
			FVectorDouble newLocation = this.SceneItem.LastHoldingLocation.ToUeVector(false);
			TArray<FVectorDouble> projectilePath = ManipulaterModel.Instance.GetProjectilePath();
			TArray<FVectorDouble> afterPortalProjectilePath = ManipulaterModel.Instance.GetAfterPortalProjectilePath();
			global::Vector vector = global::Vector.Create(projectilePath.Get(projectilePath.Num() - 1));
			vector.SubtractionEqual(global::Vector.Create(projectilePath.Get(projectilePath.Num() - 2)));
			vector.Normalize(9.99999993922529E-09);
			if (afterPortalProjectilePath.Num() <= 0)
			{
				global::Vector vector2 = global::Vector.Create(projectilePath.Get(projectilePath.Num() - 1));
				vector2.AdditionEqual(vector.MultiplyEqual((double)(this.SceneItem.ManipulateBaseConfig.抛物瞄准射线检测半径 * 2f)));
				projectilePath.Add(vector2.ToUeVector(false));
			}
			else
			{
				global::Vector vector3 = global::Vector.Create(afterPortalProjectilePath.Get(afterPortalProjectilePath.Num() - 1));
				vector3.AdditionEqual(vector.MultiplyEqual((double)(this.SceneItem.ManipulateBaseConfig.抛物瞄准射线检测半径 * 2f)));
				afterPortalProjectilePath.Add(vector3.ToUeVector(false));
			}
			this.SplineActor = ActorSystem.Instance.Get(BP_BasePathLine_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
			this.SplineActor.D_K2_SetActorLocation(newLocation, false, ref WorldGlobal.SweepHitResult, true);
			this.SplineComponent = (this.SplineActor.GetComponentByClass(USplineComponent.StaticClass()) as USplineComponent);
			this.SplineComponent.D_SetSplinePoints(projectilePath, ESplineCoordinateSpace.Local, true);
			if (afterPortalProjectilePath.Num() > 0)
			{
				this.AfterPortalSplineActor = ActorSystem.Instance.Get(BP_BasePathLine_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true);
				FVectorDouble? afterPortalStartPosition = ManipulaterModel.Instance.GetAfterPortalStartPosition();
				if (afterPortalStartPosition != null)
				{
					this.AfterPortalSplineActor.D_K2_SetActorLocation(afterPortalStartPosition.Value, false, ref WorldGlobal.SweepHitResult, true);
				}
				this.AfterPortalSplineComponent = (this.AfterPortalSplineActor.GetComponentByClass(USplineComponent.StaticClass()) as USplineComponent);
				this.AfterPortalSplineComponent.D_SetSplinePoints(afterPortalProjectilePath, ESplineCoordinateSpace.Local, true);
			}
		}

		// Token: 0x060475BB RID: 292283 RVA: 0x012250D2 File Offset: 0x012232D2
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x0402584A RID: 153674
		private USplineComponent SplineComponent;

		// Token: 0x0402584B RID: 153675
		private AActor SplineActor;

		// Token: 0x0402584C RID: 153676
		private USplineComponent AfterPortalSplineComponent;

		// Token: 0x0402584D RID: 153677
		private AActor AfterPortalSplineActor;

		// Token: 0x0402584E RID: 153678
		private float MoveSpeed;

		// Token: 0x0402584F RID: 153679
		private float Distance;

		// Token: 0x04025850 RID: 153680
		[Nullable(1)]
		private global::Vector LastLocation = global::Vector.Create();

		// Token: 0x04025851 RID: 153681
		[Nullable(1)]
		private global::Vector CurrentDirection = global::Vector.Create();

		// Token: 0x04025852 RID: 153682
		private bool IsAfterPortal;
	}
}
