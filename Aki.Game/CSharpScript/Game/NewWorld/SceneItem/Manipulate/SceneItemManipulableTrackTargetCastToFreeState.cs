using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071EE RID: 29166
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemManipulableTrackTargetCastToFreeState : SceneItemManipulableCastState, IStaticVariableResetter
	{
		// Token: 0x06047627 RID: 292391 RVA: 0x01229125 File Offset: 0x01227325
		[NullableContext(1)]
		public SceneItemManipulableTrackTargetCastToFreeState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x06047628 RID: 292392 RVA: 0x01229130 File Offset: 0x01227330
		static SceneItemManipulableTrackTargetCastToFreeState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemManipulableTrackTargetCastToFreeState.CreateStaticDefaultValue), new Action(SceneItemManipulableTrackTargetCastToFreeState.ResetStaticDefaultValue));
		}

		// Token: 0x06047629 RID: 292393 RVA: 0x0122914F File Offset: 0x0122734F
		public static void CreateStaticDefaultValue()
		{
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace = null;
		}

		// Token: 0x0604762A RID: 292394 RVA: 0x01229157 File Offset: 0x01227357
		public static void ResetStaticDefaultValue()
		{
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace = null;
		}

		// Token: 0x0604762B RID: 292395 RVA: 0x0122915F File Offset: 0x0122735F
		[NullableContext(1)]
		public void SetStartCameraLocation(global::Vector inStartCameraLocation)
		{
			this.StartCameraLocation = inStartCameraLocation;
		}

		// Token: 0x0604762C RID: 292396 RVA: 0x01229168 File Offset: 0x01227368
		protected override void OnEnter()
		{
			base.OnEnter();
			if (this.StartCameraLocation == null)
			{
				return;
			}
			this.IsPastEnd = false;
			this.MoveStartLocation = global::Vector.Create(this.SceneItem.ActorComp.ActorLocationProxy);
			IThrowMotionTrackTarget throwMotionTrackTarget = this.SceneItem.Config.ThrowCfg.MotionConfig as IThrowMotionTrackTarget;
			this.MoveSpeed = throwMotionTrackTarget.Velocity;
			this.TotalDistance = new float?(5000f);
			global::Vector vector = global::Vector.Create(0.0, 0.0, 0.0);
			CameraController.Instance.MainModel.CameraRotator.Vector(vector);
			if (SceneItemManipulableTrackTargetCastToFreeState._sphereTrace == null)
			{
				this.InitTraceInfo();
			}
			global::Vector vector2 = global::Vector.Create(this.StartCameraLocation);
			vector2.AdditionEqual(vector.MultiplyEqual(5000.0));
			TraceElementCommon.Instance.SetStartLocation(SceneItemManipulableTrackTargetCastToFreeState._sphereTrace, this.StartCameraLocation);
			TraceElementCommon.Instance.SetEndLocation(SceneItemManipulableTrackTargetCastToFreeState._sphereTrace, vector2);
			bool flag = TraceElementCommon.Instance.SphereTrace(SceneItemManipulableTrackTargetCastToFreeState._sphereTrace, "[SceneItemManipulableTrackTargetCastToFreeState.OnEnter]");
			this.MoveEndLocation = global::Vector.Create(vector2);
			if (flag && SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.HitResult.bBlockingHit)
			{
				TraceElementCommon.Instance.GetHitLocation(SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.HitResult, 0, this.MoveEndLocation);
				this.TotalDistance = new float?((float)global::Vector.Dist(this.MoveStartLocation, this.MoveEndLocation));
			}
			this.MoveDirection = global::Vector.Create(this.MoveEndLocation);
			this.MoveDirection.SubtractionEqual(this.MoveStartLocation);
			this.MoveDirection.Normalize(9.99999993922529E-09);
			if (this.NeedNotifyServer)
			{
				LevelGamePlayController.Instance.ManipulatableBeCastOrDrop2Server(this.SceneItem.Entity.Id, EControlState.FreeThrowing);
			}
			if (this.EnterCallback != null)
			{
				this.EnterCallback();
			}
			this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.Kinematic;
		}

		// Token: 0x0604762D RID: 292397 RVA: 0x01229354 File Offset: 0x01227554
		private void InitTraceInfo()
		{
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace = new UTraceSphereElement();
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.WorldContextObject = this.SceneItem.ActorComp.Owner;
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.bIsSingle = true;
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.bIgnoreSelf = true;
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			tarray.Add(KuroObjectTypeQuery.WorldStatic);
			tarray.Add(KuroObjectTypeQuery.Pawn);
			tarray.Add(KuroObjectTypeQuery.PawnMonster);
			tarray.Add(KuroObjectTypeQuery.Destructible);
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.SetObjectTypesQuery(ref tarray);
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.Radius = 1f;
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace.DrawTime = 5f;
		}

		// Token: 0x0604762E RID: 292398 RVA: 0x0122940B File Offset: 0x0122760B
		protected override void OnExit()
		{
			base.OnExit();
			this.StartCameraLocation = null;
		}

		// Token: 0x0604762F RID: 292399 RVA: 0x0122941C File Offset: 0x0122761C
		protected override void OnTick(float delta)
		{
			global::Vector vector = global::Vector.Create(global::Vector.Create(this.SceneItem.ActorComp.ActorLocationProxy));
			global::Vector vector2 = global::Vector.Create(this.MoveDirection);
			vector.AdditionEqual(vector2.MultiplyEqual((double)(this.MoveSpeed * delta)));
			if (!this.IsPastEnd)
			{
				this.SceneItem.ActorComp.SetActorLocation(vector.ToUeVector(false), "[SceneItemManipulableTrackTargetCastToFreeState.UpdateLocation]", true);
			}
			this.TotalDistance -= this.MoveSpeed * delta;
			if (!this.IsPastEnd)
			{
				float? totalDistance = this.TotalDistance;
				float num = 0f;
				if (totalDistance.GetValueOrDefault() <= num & totalDistance != null)
				{
					SceneItemManipulatableComponent sceneItem = this.SceneItem;
					if (((sceneItem != null) ? sceneItem.CurrentState : null) != this)
					{
						return;
					}
					this.IsPastEnd = true;
					this.SceneItem.TryEnableTick(false);
					this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.DynamicWaitSleep;
					vector2 = global::Vector.Create(this.MoveDirection);
					this.SceneItem.ActorComp.GetPrimitiveComponent().SetPhysicsLinearVelocity(vector2.MultiplyEqual((double)this.MoveSpeed).ToUeVectorOld(), false, default(FName));
				}
			}
			if (this.SceneItem.ManipulateBaseConfig.随速度调整朝向 && !this.AfterHit)
			{
				FVectorDouble fvectorDouble = global::Vector.Create(this.MoveDirection.ToUeVector(false)).ToUeVector(false);
				FVectorDouble actorLocation = this.SceneItem.ActorComp.ActorLocation;
				FVectorDouble actorLocation2 = this.SceneItem.ActorComp.ActorLocation;
				FVectorDouble fvectorDouble2 = actorLocation2 + fvectorDouble;
				FRotator value = UKismetMathLibrary.D_FindLookAtRotation(actorLocation, fvectorDouble2);
				this.SceneItem.ActorComp.SetActorRotation(value, "[ManipulableCastState.UpdateRotationAccordingToVelocity]", false);
			}
		}

		// Token: 0x06047630 RID: 292400 RVA: 0x012295F7 File Offset: 0x012277F7
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x040258A1 RID: 153761
		[Nullable(1)]
		private const string PROFILE_KEY = "[SceneItemManipulableTrackTargetCastToFreeState.OnEnter]";

		// Token: 0x040258A2 RID: 153762
		private const float MAX_DISTANCE = 5000f;

		// Token: 0x040258A3 RID: 153763
		private const float SPHERE_TRACE_RADIUS = 1f;

		// Token: 0x040258A4 RID: 153764
		private static UTraceSphereElement _sphereTrace;

		// Token: 0x040258A5 RID: 153765
		private global::Vector StartCameraLocation;

		// Token: 0x040258A6 RID: 153766
		private global::Vector MoveStartLocation;

		// Token: 0x040258A7 RID: 153767
		private global::Vector MoveEndLocation;

		// Token: 0x040258A8 RID: 153768
		private global::Vector MoveDirection;

		// Token: 0x040258A9 RID: 153769
		private float? TotalDistance;

		// Token: 0x040258AA RID: 153770
		private bool IsPastEnd;

		// Token: 0x040258AB RID: 153771
		private float MoveSpeed;
	}
}
