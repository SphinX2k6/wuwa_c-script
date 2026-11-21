using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006295 RID: 25237
	public class SceneItemManipulableCastFreeState : SceneItemManipulableCastState
	{
		// Token: 0x0603CEB2 RID: 249522 RVA: 0x0117E85B File Offset: 0x0117CA5B
		[NullableContext(1)]
		public SceneItemManipulableCastFreeState(SceneItemManipulatableComponent SceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? CameraShake, [Nullable(2)] UKuroForceFeedbackEffect GamepadShake) : base(SceneItem, CameraShake, GamepadShake)
		{
		}

		// Token: 0x0603CEB3 RID: 249523 RVA: 0x0117E871 File Offset: 0x0117CA71
		public void SetForward(FVector newValue)
		{
			this.Forward = newValue;
		}

		// Token: 0x0603CEB4 RID: 249524 RVA: 0x0117E87C File Offset: 0x0117CA7C
		protected override void OnEnter()
		{
			base.OnEnter();
			float scale = 1f;
			float num = 0f;
			IThrowMotion motionConfig = this.SceneItem.Config.ThrowCfg.MotionConfig;
			if (motionConfig.Type == EThrowMotion.Projectile)
			{
				IProjectileMotion projectileMotion = motionConfig as IProjectileMotion;
				scale = projectileMotion.Velocity;
				num = projectileMotion.AngularVelocity;
			}
			this.SceneItem.IsCanBeHeld = false;
			if (this.NeedResetPhysicsMode)
			{
				this.SceneItem.ActorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.DynamicWaitSleep;
			}
			if (this.NeedNotifyServer)
			{
				LevelGamePlayController.Instance.ManipulatableBeCastOrDrop2Server(this.SceneItem.Entity.Id, EControlState.FreeThrowing);
			}
			global::Vector vector = global::Vector.Create(UKismetMathLibrary.RandomUnitVector());
			UPrimitiveComponent primitiveComponent = this.SceneItem.ActorComp.GetPrimitiveComponent();
			primitiveComponent.SetPhysicsLinearVelocity(this.Forward * scale, false, default(FName));
			FVectorDouble fvectorDouble = vector.ToUeVector(false);
			FVectorDouble fvectorDouble2 = fvectorDouble * (double)num;
			primitiveComponent.SetPhysicsAngularVelocityInDegrees(fvectorDouble2, false, default(FName));
			this.SceneItem.TargetActorComponent = null;
			this.SceneItem.TargetOutletComponent = null;
			if (this.EnterCallback != null)
			{
				this.EnterCallback();
			}
		}

		// Token: 0x0603CEB5 RID: 249525 RVA: 0x0117E9A7 File Offset: 0x0117CBA7
		protected override void OnTick(float delta)
		{
			this.UpdateRotationAccordingToVelocity();
		}

		// Token: 0x0603CEB6 RID: 249526 RVA: 0x0117E9B0 File Offset: 0x0117CBB0
		protected override void OnChangeMoveController(bool isAutonomous)
		{
			if (isAutonomous)
			{
				if (this.SceneItem != null)
				{
					SceneItemActorComponent actorComp = this.SceneItem.ActorComp;
					if (actorComp != null)
					{
						actorComp.PhysicsMode = SceneItemActorComponent.EPhysicsMode.DynamicWaitSleep;
						return;
					}
				}
			}
			else
			{
				this.OnExit();
			}
		}

		// Token: 0x0603CEB7 RID: 249527 RVA: 0x0117E9E5 File Offset: 0x0117CBE5
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x040204B8 RID: 132280
		private FVector Forward = new FVector();
	}
}
