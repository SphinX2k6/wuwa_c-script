using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071E9 RID: 29161
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableLevitateCastState : SceneItemManipulableCastState, IStaticVariableResetter
	{
		// Token: 0x06047604 RID: 292356 RVA: 0x012282EC File Offset: 0x012264EC
		static SceneItemManipulableLevitateCastState()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemManipulableLevitateCastState.CreateStaticDefaultValue), new Action(SceneItemManipulableLevitateCastState.ResetStaticDefaultValue));
		}

		// Token: 0x06047605 RID: 292357 RVA: 0x0122830B File Offset: 0x0122650B
		public static void CreateStaticDefaultValue()
		{
			SceneItemManipulableLevitateCastState._sphereTrace = null;
		}

		// Token: 0x06047606 RID: 292358 RVA: 0x01228313 File Offset: 0x01226513
		public static void ResetStaticDefaultValue()
		{
			SceneItemManipulableLevitateCastState._sphereTrace = null;
		}

		// Token: 0x06047607 RID: 292359 RVA: 0x0122831C File Offset: 0x0122651C
		public SceneItemManipulableLevitateCastState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, new TSubclassOf<UCameraShakeBase>?(cameraShake), gamepadShake)
		{
			this.LevitateConfig = (IThrowMotionLevitate)this.SceneItem.Config.ThrowCfg.MotionConfig;
			this.Velocity = this.LevitateConfig.Velocity;
			this.VelocityDirection = global::Vector.Create();
			IRenderTrajectoryConfig renderTrajectoryConfig = this.LevitateConfig.RenderTrajectoryConfig;
			float? num = (renderTrajectoryConfig != null) ? new float?(renderTrajectoryConfig.Time) : null;
			this.LifeTime = ((num != null && num.GetValueOrDefault() != 0f) ? Math.Min(num.Value, this.LevitateConfig.MoveTime) : this.LevitateConfig.MoveTime);
			this.TotalDistance = this.Velocity * this.LifeTime;
			this.MaxDistance = this.TotalDistance;
			if (!StringUtils.IsEmpty(this.LevitateConfig.VelocityCurve))
			{
				ResourceSystem.Instance.LoadAsync<UCurveFloat>(this.LevitateConfig.VelocityCurve, delegate([Nullable(2)] UCurveFloat result, string _)
				{
					this.VelocityCurve = result;
					List<global::Vector> castPath = this.GetCastPath(true);
					global::Vector v = castPath[0];
					List<global::Vector> list = castPath;
					this.MaxDistance = (float)global::Vector.Dist(v, list[list.Count - 1]);
				}, 100, "js_undefined");
			}
		}

		// Token: 0x06047608 RID: 292360 RVA: 0x0122846C File Offset: 0x0122666C
		protected override void OnEnter()
		{
			base.OnEnter();
			this.SimulationTimer = 0f;
			this.PrevLoc.DeepCopy(this.MoveStartLocation);
			this.SceneItem.ActorComp.Owner.OnActorHit.Add(new Action<AActor, AActor, FVector, FHitResult>(this.StopOnHit));
			this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.Kinematic;
			this.SceneItem.ForceMoving = true;
		}

		// Token: 0x06047609 RID: 292361 RVA: 0x012284DE File Offset: 0x012266DE
		protected override void OnExit()
		{
			this.SceneItem.ActorComp.Owner.OnActorHit.Remove(new Action<AActor, AActor, FVector, FHitResult>(this.StopOnHit));
			this.SceneItem.ForceMoving = false;
			this.RequestToLevitate();
		}

		// Token: 0x0604760A RID: 292362 RVA: 0x01228518 File Offset: 0x01226718
		private void RequestToLevitate()
		{
			BeControlledEntityHoverRequest beControlledEntityHoverRequest = BeControlledEntityHoverRequest.Create();
			beControlledEntityHoverRequest.EntityId = MathUtils.Instance.NumberToLong(this.SceneItem.ActorComp.CreatureData.GetCreatureDataId());
			Net.Instance.Call(ERequestMessageId.BeControlledEntityHoverRequest, beControlledEntityHoverRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				BeControlledEntityHoverResponse beControlledEntityHoverResponse = (BeControlledEntityHoverResponse)msg;
				ErrorCode? errorCode = (beControlledEntityHoverResponse != null) ? new ErrorCode?(beControlledEntityHoverResponse.ErrorCode) : null;
				if (errorCode == null || errorCode.GetValueOrDefault() != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(beControlledEntityHoverResponse.ErrorCode, EResponseMessageId.BeControlledEntityHoverResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0604760B RID: 292363 RVA: 0x01228580 File Offset: 0x01226780
		public void SetVelocityDirection(global::Vector dire)
		{
			this.VelocityDirection.DeepCopy(dire);
		}

		// Token: 0x0604760C RID: 292364 RVA: 0x0122858E File Offset: 0x0122678E
		protected override void OnTick(float delta)
		{
			this.UpdateLocation(delta);
			this.UpdateRotationAccordingToVelocity();
		}

		// Token: 0x0604760D RID: 292365 RVA: 0x012285A0 File Offset: 0x012267A0
		protected override void UpdateLocation(float delta)
		{
			this.SimulationTimer += delta;
			this.SimulationTimer = Math.Min(this.SimulationTimer, this.LifeTime);
			global::Vector location = this.GetLocation(this.PrevLoc, delta);
			if (this.SceneItem.CurrentState != this)
			{
				return;
			}
			this.SceneItem.ActorComp.SetActorLocation(location.ToUeVector(false), "[SceneItemManipulableLevitateCastState.UpdateLocation]", true);
			this.PrevLoc = location;
			if (location.Equals(this.MoveEndLocation, 9.999999747378752E-05) && this.SceneItem.CurrentState == this)
			{
				SceneItemManipulatableComponent sceneItem = this.SceneItem;
				if (sceneItem != null)
				{
					sceneItem.SetState(SceneItemManipulatableComponent.EManipulatableState.Reset, "LevitateCastState Finish");
				}
			}
			if (this.SimulationTimer >= this.LifeTime && this.SceneItem.CurrentState == this)
			{
				SceneItemManipulatableComponent sceneItem2 = this.SceneItem;
				if (sceneItem2 == null)
				{
					return;
				}
				sceneItem2.SetState(SceneItemManipulatableComponent.EManipulatableState.Reset, "LevitateCastState OverTime");
			}
		}

		// Token: 0x0604760E RID: 292366 RVA: 0x01228684 File Offset: 0x01226884
		private global::Vector GetLocation(global::Vector startLoc, float timeStep)
		{
			global::Vector vector = global::Vector.Create();
			this.MoveDirection.Multiply((double)(this.Velocity * timeStep), vector);
			UCurveFloat velocityCurve = this.VelocityCurve;
			if (velocityCurve != null && velocityCurve.IsValid())
			{
				vector.MultiplyEqual((double)this.VelocityCurve.GetFloatValue(this.SimulationTimer));
			}
			vector.Set((double)(MathF.Floor((float)vector.X * 100f) / 100f), (double)(MathF.Floor((float)vector.Y * 100f) / 100f), (double)(MathF.Floor((float)vector.Z * 100f) / 100f));
			startLoc.Addition(vector, vector);
			if (global::Vector.Distance(vector, this.MoveStartLocation) > (double)this.TotalDistance)
			{
				vector = this.MoveEndLocation;
			}
			return vector;
		}

		// Token: 0x0604760F RID: 292367 RVA: 0x01228754 File Offset: 0x01226954
		public List<global::Vector> GetCastPath(bool ignoreTrace = false)
		{
			if (!ignoreTrace)
			{
				this.GetTraceResult();
			}
			else
			{
				CameraController.Instance.MainModel.CameraRotator.Vector(this.MoveDirection);
				global::Vector moveStartLocation = this.MoveStartLocation;
				FVectorDouble actorLocation = this.SceneItem.ActorComp.ActorLocation;
				moveStartLocation.DeepCopy(actorLocation);
			}
			List<global::Vector> list = new List<global::Vector>();
			global::Vector vector = global::Vector.Create(this.MoveStartLocation);
			list.Add(vector);
			float lifeTime = this.LifeTime;
			this.SimulationTimer = 0f;
			for (float num = 0f; num < lifeTime; num += this.TimeStepLimit)
			{
				this.SimulationTimer += this.TimeStepLimit;
				global::Vector location = this.GetLocation(vector, this.TimeStepLimit);
				vector = location;
				list.Add(location);
				if (location.Equals(this.MoveEndLocation, 9.999999747378752E-05))
				{
					break;
				}
			}
			return list;
		}

		// Token: 0x06047610 RID: 292368 RVA: 0x01228830 File Offset: 0x01226A30
		private void InitTraceInfo()
		{
			SceneItemManipulableLevitateCastState._sphereTrace = new UTraceSphereElement();
			SceneItemManipulableLevitateCastState._sphereTrace.WorldContextObject = this.SceneItem.ActorComp.Owner;
			SceneItemManipulableLevitateCastState._sphereTrace.bIsSingle = true;
			SceneItemManipulableLevitateCastState._sphereTrace.bIgnoreSelf = true;
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			tarray.Add(KuroObjectTypeQuery.WorldStatic);
			tarray.Add(KuroObjectTypeQuery.Pawn);
			tarray.Add(KuroObjectTypeQuery.PawnMonster);
			tarray.Add(KuroObjectTypeQuery.Destructible);
			SceneItemManipulableLevitateCastState._sphereTrace.SetObjectTypesQuery(ref tarray);
			SceneItemManipulatableComponent sceneItem = this.SceneItem;
			object obj;
			if (sceneItem == null)
			{
				obj = null;
			}
			else
			{
				TeleControl2 config = sceneItem.Config;
				obj = ((config != null) ? config.ThrowCfg.MotionConfig : null);
			}
			IThrowMotionLevitate throwMotionLevitate = obj as IThrowMotionLevitate;
			UTraceSphereElement sphereTrace = SceneItemManipulableLevitateCastState._sphereTrace;
			float? num = (throwMotionLevitate != null) ? throwMotionLevitate.RayRadius : null;
			sphereTrace.Radius = ((num != null && num.GetValueOrDefault() != 0f) ? throwMotionLevitate.RayRadius.Value : 50f);
			SceneItemManipulableLevitateCastState._sphereTrace.DrawTime = 5f;
		}

		// Token: 0x06047611 RID: 292369 RVA: 0x0122894C File Offset: 0x01226B4C
		private void GetTraceResult()
		{
			global::Vector moveStartLocation = this.MoveStartLocation;
			FVectorDouble actorLocation = this.SceneItem.ActorComp.ActorLocation;
			moveStartLocation.DeepCopy(actorLocation);
			global::Vector vector = global::Vector.Create(0.0, 0.0, 0.0);
			CameraController.Instance.MainModel.CameraRotator.Vector(vector);
			if (SceneItemManipulableLevitateCastState._sphereTrace == null)
			{
				this.InitTraceInfo();
			}
			global::Vector vector2 = global::Vector.Create(CameraController.Instance.MainModel.CameraLocation);
			global::Vector vector3 = global::Vector.Create(vector2);
			vector3.AdditionEqual(vector.MultiplyEqual((double)this.MaxDistance));
			TraceElementCommon.Instance.SetStartLocation(SceneItemManipulableLevitateCastState._sphereTrace, vector2);
			TraceElementCommon.Instance.SetEndLocation(SceneItemManipulableLevitateCastState._sphereTrace, vector3);
			bool flag = TraceElementCommon.Instance.SphereTrace(SceneItemManipulableLevitateCastState._sphereTrace, "[SceneItemManipulableLevitateCastState.GetTraceResult]");
			this.MoveEndLocation.DeepCopy(vector3);
			if (flag && SceneItemManipulableLevitateCastState._sphereTrace.HitResult.bBlockingHit)
			{
				TraceElementCommon.Instance.GetHitLocation(SceneItemManipulableLevitateCastState._sphereTrace.HitResult, 0, this.MoveEndLocation);
			}
			this.TotalDistance = (float)global::Vector.Dist(this.MoveStartLocation, this.MoveEndLocation);
			this.MoveDirection.DeepCopy(this.MoveEndLocation);
			this.MoveDirection.SubtractionEqual(this.MoveStartLocation);
			this.MoveDirection.Normalize(9.99999993922529E-09);
		}

		// Token: 0x06047612 RID: 292370 RVA: 0x01228AA8 File Offset: 0x01226CA8
		[NullableContext(2)]
		private void StopOnHit(AActor selfActor, AActor otherActor, FVector vector, [Nullable(1)] FHitResult hitResult)
		{
			SceneItemManipulatableComponent sceneItem = this.SceneItem;
			if (sceneItem == null)
			{
				return;
			}
			sceneItem.SetState(SceneItemManipulatableComponent.EManipulatableState.Reset, "LevitateCastState OnHit");
		}

		// Token: 0x06047613 RID: 292371 RVA: 0x01228AC0 File Offset: 0x01226CC0
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x0402588C RID: 153740
		private const float SPHERE_TRACE_RADIUS = 50f;

		// Token: 0x0402588D RID: 153741
		private const string PROFILE_KEY = "[SceneItemManipulableLevitateCastState.GetTraceResult]";

		// Token: 0x0402588E RID: 153742
		[Nullable(2)]
		private readonly IThrowMotionLevitate LevitateConfig;

		// Token: 0x0402588F RID: 153743
		[Nullable(2)]
		private static UTraceSphereElement _sphereTrace;

		// Token: 0x04025890 RID: 153744
		private readonly float Velocity;

		// Token: 0x04025891 RID: 153745
		[Nullable(2)]
		private readonly global::Vector VelocityDirection;

		// Token: 0x04025892 RID: 153746
		[Nullable(2)]
		private UCurveFloat VelocityCurve;

		// Token: 0x04025893 RID: 153747
		private readonly float LifeTime;

		// Token: 0x04025894 RID: 153748
		private readonly float TimeStepLimit = 0.033f;

		// Token: 0x04025895 RID: 153749
		private float SimulationTimer;

		// Token: 0x04025896 RID: 153750
		private global::Vector PrevLoc = global::Vector.Create();

		// Token: 0x04025897 RID: 153751
		private float MaxDistance;

		// Token: 0x04025898 RID: 153752
		private float TotalDistance;

		// Token: 0x04025899 RID: 153753
		private readonly global::Vector MoveStartLocation = global::Vector.Create();

		// Token: 0x0402589A RID: 153754
		private readonly global::Vector MoveEndLocation = global::Vector.Create();

		// Token: 0x0402589B RID: 153755
		private readonly global::Vector MoveDirection = global::Vector.Create();
	}
}
