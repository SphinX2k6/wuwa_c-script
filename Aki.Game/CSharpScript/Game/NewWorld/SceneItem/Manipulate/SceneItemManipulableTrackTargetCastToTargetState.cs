using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071EF RID: 29167
	[NullableContext(2)]
	[Nullable(0)]
	internal class SceneItemManipulableTrackTargetCastToTargetState : SceneItemManipulableCastState
	{
		// Token: 0x06047631 RID: 292401 RVA: 0x012295FA File Offset: 0x012277FA
		[NullableContext(1)]
		public SceneItemManipulableTrackTargetCastToTargetState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, cameraShake, gamepadShake)
		{
		}

		// Token: 0x06047632 RID: 292402 RVA: 0x01229608 File Offset: 0x01227808
		[NullableContext(1)]
		public void SetTargetActorWithPart(BaseActorComponent targetActor, [Nullable(2)] CharacterPart targetPart)
		{
			this.TargetActor = targetActor;
			if (targetPart != null)
			{
				CharacterActorComponent characterActorComponent = targetActor as CharacterActorComponent;
				this.TargetSkeletalMesh = ((characterActorComponent != null) ? characterActorComponent.Actor.Mesh : null);
				this.TargetSocketName = targetPart.PartSocketName;
			}
		}

		// Token: 0x06047633 RID: 292403 RVA: 0x0122964C File Offset: 0x0122784C
		protected override void OnEnter()
		{
			base.OnEnter();
			if (this.TargetActor == null)
			{
				return;
			}
			IThrowMotionTrackTarget throwMotionTrackTarget = this.SceneItem.Config.ThrowCfg.MotionConfig as IThrowMotionTrackTarget;
			this.Speed = new float?(throwMotionTrackTarget.Velocity);
			if (!StringUtils.IsEmpty(throwMotionTrackTarget.VelocityCurve))
			{
				ResourceSystem.Instance.LoadAsync<UCurveFloat>(throwMotionTrackTarget.VelocityCurve, delegate([Nullable(2)] UCurveFloat result, string _)
				{
					this.SpeedCurve = result;
				}, 100, "js_undefined");
			}
			this.AngularSpeed = new float?(throwMotionTrackTarget.AngularVelocity);
			if (!StringUtils.IsEmpty(throwMotionTrackTarget.AngularVelocityCurve))
			{
				ResourceSystem.Instance.LoadAsync<UCurveFloat>(throwMotionTrackTarget.AngularVelocityCurve, delegate([Nullable(2)] UCurveFloat result, string _)
				{
					this.AngularSpeedCurve = result;
				}, 100, "js_undefined");
			}
			this.CurrentDirection = global::Vector.Create();
			if (throwMotionTrackTarget.VelocityOffset != null)
			{
				global::Rotator b = global::Rotator.Create(throwMotionTrackTarget.VelocityOffset.Y.GetValueOrDefault(), throwMotionTrackTarget.VelocityOffset.Z.GetValueOrDefault(), throwMotionTrackTarget.VelocityOffset.X.GetValueOrDefault());
				global::Rotator rotator = global::Rotator.Create(CameraController.Instance.MainModel.CameraRotator);
				MathUtils.Instance.ComposeRotator(rotator, b, rotator);
				rotator.Vector(this.CurrentDirection);
			}
			else
			{
				CameraController.Instance.MainModel.CameraRotator.Vector(this.CurrentDirection);
			}
			this.CurrentDirection.Normalize(9.99999993922529E-09);
			if (this.NeedNotifyServer)
			{
				LevelGamePlayController.Instance.ManipulatableBeCastOrDrop2Server(this.SceneItem.Entity.Id, EControlState.LockEntityThrowing);
			}
		}

		// Token: 0x06047634 RID: 292404 RVA: 0x012297DC File Offset: 0x012279DC
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			this.Timer += delta;
			float num = this.AngularSpeed.GetValueOrDefault();
			UCurveFloat angularSpeedCurve = this.AngularSpeedCurve;
			if (angularSpeedCurve != null && angularSpeedCurve.IsValid())
			{
				num *= this.AngularSpeedCurve.GetFloatValue(this.Timer);
			}
			float num2 = this.Speed.GetValueOrDefault();
			UCurveFloat speedCurve = this.SpeedCurve;
			if (speedCurve != null && speedCurve.IsValid())
			{
				num2 *= this.SpeedCurve.GetFloatValue(this.Timer);
			}
			this.CurrentDirection.Normalize(9.99999993922529E-09);
			global::Vector vector = global::Vector.Create();
			if (this.TargetSocketName != null)
			{
				global::Vector vector2 = vector;
				FVectorDouble fvectorDouble = this.TargetSkeletalMesh.D_GetSocketLocation(this.TargetSocketName.Value);
				vector2.DeepCopy(fvectorDouble);
			}
			else
			{
				vector.DeepCopy(this.TargetActor.ActorLocationProxy);
			}
			global::Vector vector3 = global::Vector.Create(this.SceneItem.ActorComp.ActorLocationProxy);
			global::Vector vector4 = global::Vector.Create(vector);
			vector4.SubtractionEqual(vector3);
			vector4.Normalize(9.99999993922529E-09);
			float num3 = (float)(Math.Acos(global::Vector.DotProduct(this.CurrentDirection, vector4)) * 57.295780181884766);
			num3 = MathUtils.Instance.Clamp(num3, -num * delta, num * delta);
			global::Vector vector5 = global::Vector.Create();
			global::Vector.CrossProduct(this.CurrentDirection, vector4, vector5);
			this.CurrentDirection.RotateAngleAxis((double)num3, vector5, this.CurrentDirection);
			global::Vector vector6 = global::Vector.Create(vector3);
			global::Vector vector7 = global::Vector.Create(this.CurrentDirection);
			vector7.MultiplyEqual((double)(num2 * delta));
			vector6.AdditionEqual(vector7);
			this.SceneItem.ActorComp.SetActorLocation(vector6.ToUeVector(false), "unknown", true);
			if (this.SceneItem.ManipulateBaseConfig.随速度调整朝向 && !this.AfterHit)
			{
				FVectorDouble fvectorDouble = this.SceneItem.ActorComp.ActorLocation;
				FVectorDouble actorLocation = this.SceneItem.ActorComp.ActorLocation;
				FVectorDouble fvectorDouble2 = this.CurrentDirection.ToUeVector(false);
				FVectorDouble fvectorDouble3 = actorLocation + fvectorDouble2;
				FRotator value = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble3);
				this.SceneItem.ActorComp.SetActorRotation(value, "[ManipulableCastState.UpdateRotationAccordingToVelocity]", false);
			}
		}

		// Token: 0x040258AC RID: 153772
		private BaseActorComponent TargetActor;

		// Token: 0x040258AD RID: 153773
		private USkeletalMeshComponent TargetSkeletalMesh;

		// Token: 0x040258AE RID: 153774
		private FName? TargetSocketName;

		// Token: 0x040258AF RID: 153775
		private float? Speed;

		// Token: 0x040258B0 RID: 153776
		private UCurveFloat SpeedCurve;

		// Token: 0x040258B1 RID: 153777
		private float? AngularSpeed;

		// Token: 0x040258B2 RID: 153778
		private UCurveFloat AngularSpeedCurve;

		// Token: 0x040258B3 RID: 153779
		private global::Vector CurrentDirection;
	}
}
