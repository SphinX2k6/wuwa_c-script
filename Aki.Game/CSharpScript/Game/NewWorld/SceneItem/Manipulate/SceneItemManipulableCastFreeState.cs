using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071E0 RID: 29152
	public class SceneItemManipulableCastFreeState : SceneItemManipulableCastState
	{
		// Token: 0x060475B0 RID: 292272 RVA: 0x01224A27 File Offset: 0x01222C27
		[NullableContext(1)]
		public SceneItemManipulableCastFreeState(SceneItemManipulatableComponent SceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? CameraShake, [Nullable(2)] UKuroForceFeedbackEffect GamepadShake) : base(SceneItem, CameraShake, GamepadShake)
		{
		}

		// Token: 0x060475B1 RID: 292273 RVA: 0x01224A3D File Offset: 0x01222C3D
		public void SetForward(FVector newValue)
		{
			this.Forward = newValue;
		}

		// Token: 0x060475B2 RID: 292274 RVA: 0x01224A48 File Offset: 0x01222C48
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

		// Token: 0x060475B3 RID: 292275 RVA: 0x01224B73 File Offset: 0x01222D73
		protected override void OnTick(float delta)
		{
			this.UpdateRotationAccordingToVelocity();
		}

		// Token: 0x060475B4 RID: 292276 RVA: 0x01224B7C File Offset: 0x01222D7C
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

		// Token: 0x060475B5 RID: 292277 RVA: 0x01224BB1 File Offset: 0x01222DB1
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x04025849 RID: 153673
		private FVector Forward = new FVector();
	}
}
