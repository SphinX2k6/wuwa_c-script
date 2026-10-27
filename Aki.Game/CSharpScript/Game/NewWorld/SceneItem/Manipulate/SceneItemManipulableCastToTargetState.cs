using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071E4 RID: 29156
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableCastToTargetState : SceneItemManipulableCastState
	{
		// Token: 0x060475D4 RID: 292308 RVA: 0x01225C06 File Offset: 0x01223E06
		public SceneItemManipulableCastToTargetState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x060475D5 RID: 292309 RVA: 0x01225C1C File Offset: 0x01223E1C
		public void SetTarget(Entity newValue)
		{
			this.TargetInternal = newValue;
		}

		// Token: 0x060475D6 RID: 292310 RVA: 0x01225C25 File Offset: 0x01223E25
		public override void SetEnterCallback(Action callback)
		{
			this.EnterCallback = callback;
		}

		// Token: 0x060475D7 RID: 292311 RVA: 0x01225C30 File Offset: 0x01223E30
		protected override void OnEnter()
		{
			Entity targetInternal = this.TargetInternal;
			if (targetInternal == null || !targetInternal.Valid)
			{
				Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CH, "被控物没有进入CastToTarget时,没有设置目标", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.OnEnter();
			this.SceneItem.IsCanBeHeld = false;
			BaseActorComponent component = this.TargetInternal.GetComponent<BaseActorComponent>();
			this.SceneItem.TargetActorComponent = component;
			this.SceneItem.TargetOutletComponent = null;
			if (this.NeedNotifyServer)
			{
				LevelGamePlayController.Instance.ManipulatableBeCastOrDrop2Server(this.SceneItem.Entity.Id, EControlState.LockEntityThrowing);
			}
			base.StartCast();
			base.CalcDirection();
			if (this.EnterCallback != null)
			{
				this.EnterCallback();
			}
		}

		// Token: 0x060475D8 RID: 292312 RVA: 0x01225CEC File Offset: 0x01223EEC
		protected override void OnTick(float delta)
		{
			this.Timer += delta;
			float num = MathUtils.Instance.Clamp(this.Timer / this.CastDuration, 0f, 1f);
			if (this.SceneItem.CastCurve != null)
			{
				num = this.SceneItem.CastCurve.GetFloatValue(num);
			}
			global::Vector prevLocation = this.PrevLocation;
			FVectorDouble actorLocation = this.SceneItem.ActorComp.ActorLocation;
			prevLocation.DeepCopy(actorLocation);
			this.UpdateLocation(num);
			this.UpdateRotation();
			this.UpdateRotationAccordingToVelocity();
			this.CheckFinish();
		}

		// Token: 0x060475D9 RID: 292313 RVA: 0x01225D7F File Offset: 0x01223F7F
		protected override void OnExit()
		{
			base.OnExit();
			this.TargetInternal = null;
		}

		// Token: 0x060475DA RID: 292314 RVA: 0x01225D90 File Offset: 0x01223F90
		protected void UpdateRotation()
		{
			float num = 0f;
			IThrowMotion motionConfig = this.SceneItem.Config.ThrowCfg.MotionConfig;
			if (motionConfig.Type == EThrowMotion.Projectile)
			{
				num = (motionConfig as IProjectileMotion).AngularVelocity;
			}
			float angle = num * this.Timer;
			FRotator value = UKismetMathLibrary.RotatorFromAxisAndAngle(this.CastRotAxis.ToUeVectorOld(), angle);
			this.SceneItem.ActorComp.SetActorRotation(value, "[SceneItemManipulableCastToTargetState.UpdateLocation]", this.HitCallback != null);
		}

		// Token: 0x060475DB RID: 292315 RVA: 0x01225E08 File Offset: 0x01224008
		protected override void UpdateRotationAccordingToVelocity()
		{
			if (!this.SceneItem.ManipulateBaseConfig.随速度调整朝向)
			{
				return;
			}
			if (this.AfterHit)
			{
				return;
			}
			global::Vector vector = global::Vector.Create();
			this.SceneItem.ActorComp.ActorLocationProxy.Subtraction(this.PrevLocation, vector);
			vector.Normalize(9.99999993922529E-09);
			FVectorDouble actorLocation = this.SceneItem.ActorComp.ActorLocation;
			FVectorDouble actorLocation2 = this.SceneItem.ActorComp.ActorLocation;
			FVectorDouble fvectorDouble = vector.ToUeVector(false);
			FVectorDouble fvectorDouble2 = actorLocation2 + fvectorDouble;
			FRotator value = UKismetMathLibrary.D_FindLookAtRotation(actorLocation, fvectorDouble2);
			this.SceneItem.ActorComp.SetActorRotation(value, "[ManipulableCastState.UpdateRotationAccordingToVelocity]", false);
		}

		// Token: 0x060475DC RID: 292316 RVA: 0x01225EBC File Offset: 0x012240BC
		private void CheckFinish()
		{
			if (this.Timer >= this.CastDuration && this.CastDuration > 0f)
			{
				this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.DynamicWaitSleep;
				global::Vector vector = global::Vector.Create(this.SceneItem.ActorComp.ActorLocation);
				vector.SubtractionEqual(this.PrevLocation);
				vector.Normalize(9.99999993922529E-09);
				IThrowMotion motionConfig = this.SceneItem.Config.ThrowCfg.MotionConfig;
				if (motionConfig.Type != EThrowMotion.FreeFall)
				{
					IProjectileMotion projectileMotion = motionConfig as IProjectileMotion;
					if (projectileMotion != null)
					{
						vector.MultiplyEqual((double)projectileMotion.Velocity);
					}
					else
					{
						ICircumnutation circumnutation = motionConfig as ICircumnutation;
						if (circumnutation != null)
						{
							vector.MultiplyEqual((double)circumnutation.Velocity);
						}
						else
						{
							IThrowMotionTrackTarget throwMotionTrackTarget = motionConfig as IThrowMotionTrackTarget;
							if (throwMotionTrackTarget != null)
							{
								vector.MultiplyEqual((double)throwMotionTrackTarget.Velocity);
							}
							else
							{
								IThrowMotionLevitate throwMotionLevitate = motionConfig as IThrowMotionLevitate;
								if (throwMotionLevitate != null)
								{
									vector.MultiplyEqual((double)throwMotionLevitate.Velocity);
								}
							}
						}
					}
				}
				this.SceneItem.ActorComp.GetPrimitiveComponent().SetPhysicsLinearVelocity(vector.ToUeVectorOld(), false, default(FName));
			}
		}

		// Token: 0x04025866 RID: 153702
		[Nullable(2)]
		private Entity TargetInternal;

		// Token: 0x04025867 RID: 153703
		private readonly global::Vector PrevLocation = global::Vector.Create();
	}
}
