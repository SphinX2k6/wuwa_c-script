using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006299 RID: 25241
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableCastToTargetState : SceneItemManipulableCastState
	{
		// Token: 0x0603CED6 RID: 249558 RVA: 0x0117FA3E File Offset: 0x0117DC3E
		public SceneItemManipulableCastToTargetState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x0603CED7 RID: 249559 RVA: 0x0117FA54 File Offset: 0x0117DC54
		public void SetTarget(Entity newValue)
		{
			this.TargetInternal = newValue;
		}

		// Token: 0x0603CED8 RID: 249560 RVA: 0x0117FA5D File Offset: 0x0117DC5D
		public override void SetEnterCallback(Action callback)
		{
			this.EnterCallback = callback;
		}

		// Token: 0x0603CED9 RID: 249561 RVA: 0x0117FA68 File Offset: 0x0117DC68
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

		// Token: 0x0603CEDA RID: 249562 RVA: 0x0117FB24 File Offset: 0x0117DD24
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

		// Token: 0x0603CEDB RID: 249563 RVA: 0x0117FBB7 File Offset: 0x0117DDB7
		protected override void OnExit()
		{
			base.OnExit();
			this.TargetInternal = null;
		}

		// Token: 0x0603CEDC RID: 249564 RVA: 0x0117FBC8 File Offset: 0x0117DDC8
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

		// Token: 0x0603CEDD RID: 249565 RVA: 0x0117FC40 File Offset: 0x0117DE40
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

		// Token: 0x0603CEDE RID: 249566 RVA: 0x0117FCF4 File Offset: 0x0117DEF4
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

		// Token: 0x040204D5 RID: 132309
		[Nullable(2)]
		private Entity TargetInternal;

		// Token: 0x040204D6 RID: 132310
		private readonly global::Vector PrevLocation = global::Vector.Create();
	}
}
