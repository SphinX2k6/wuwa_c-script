using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020062A3 RID: 25251
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemManipulableTrackTargetCastToFreeState : SceneItemManipulableCastState, IStaticVariableResetter
	{
		// Token: 0x0603CF29 RID: 249641 RVA: 0x01182F79 File Offset: 0x01181179
		[NullableContext(1)]
		public SceneItemManipulableTrackTargetCastToFreeState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x0603CF2A RID: 249642 RVA: 0x01182F84 File Offset: 0x01181184
		static SceneItemManipulableTrackTargetCastToFreeState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemManipulableTrackTargetCastToFreeState.CreateStaticDefaultValue), new Action(SceneItemManipulableTrackTargetCastToFreeState.ResetStaticDefaultValue));
		}

		// Token: 0x0603CF2B RID: 249643 RVA: 0x01182FA3 File Offset: 0x011811A3
		public static void CreateStaticDefaultValue()
		{
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace = null;
		}

		// Token: 0x0603CF2C RID: 249644 RVA: 0x01182FAB File Offset: 0x011811AB
		public static void ResetStaticDefaultValue()
		{
			SceneItemManipulableTrackTargetCastToFreeState._sphereTrace = null;
		}

		// Token: 0x0603CF2D RID: 249645 RVA: 0x01182FB3 File Offset: 0x011811B3
		[NullableContext(1)]
		public void SetStartCameraLocation(global::Vector inStartCameraLocation)
		{
			this.StartCameraLocation = inStartCameraLocation;
		}

		// Token: 0x0603CF2E RID: 249646 RVA: 0x01182FBC File Offset: 0x011811BC
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

		// Token: 0x0603CF2F RID: 249647 RVA: 0x011831A8 File Offset: 0x011813A8
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

		// Token: 0x0603CF30 RID: 249648 RVA: 0x0118325F File Offset: 0x0118145F
		protected override void OnExit()
		{
			base.OnExit();
			this.StartCameraLocation = null;
		}

		// Token: 0x0603CF31 RID: 249649 RVA: 0x01183270 File Offset: 0x01181470
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

		// Token: 0x0603CF32 RID: 249650 RVA: 0x0118344B File Offset: 0x0118164B
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x04020510 RID: 132368
		[Nullable(1)]
		private const string PROFILE_KEY = "[SceneItemManipulableTrackTargetCastToFreeState.OnEnter]";

		// Token: 0x04020511 RID: 132369
		private const float MAX_DISTANCE = 5000f;

		// Token: 0x04020512 RID: 132370
		private const float SPHERE_TRACE_RADIUS = 1f;

		// Token: 0x04020513 RID: 132371
		private static UTraceSphereElement _sphereTrace;

		// Token: 0x04020514 RID: 132372
		private global::Vector StartCameraLocation;

		// Token: 0x04020515 RID: 132373
		private global::Vector MoveStartLocation;

		// Token: 0x04020516 RID: 132374
		private global::Vector MoveEndLocation;

		// Token: 0x04020517 RID: 132375
		private global::Vector MoveDirection;

		// Token: 0x04020518 RID: 132376
		private float? TotalDistance;

		// Token: 0x04020519 RID: 132377
		private bool IsPastEnd;

		// Token: 0x0402051A RID: 132378
		private float MoveSpeed;
	}
}
