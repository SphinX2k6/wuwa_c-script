using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071DE RID: 29150
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemManipulableBaseState
	{
		// Token: 0x06047593 RID: 292243 RVA: 0x012242E0 File Offset: 0x012224E0
		[NullableContext(1)]
		public SceneItemManipulableBaseState(SceneItemManipulatableComponent sceneItem)
		{
			this.SceneItem = sceneItem;
			this.PropComp = sceneItem.PropComp;
			SceneItemActorComponent actorComp = sceneItem.ActorComp;
			UActorComponent ueActorComp;
			if (actorComp == null)
			{
				ueActorComp = null;
			}
			else
			{
				AActor owner = actorComp.Owner;
				ueActorComp = ((owner != null) ? owner.GetComponentByClass(UActorComponent.StaticClass()) : null);
			}
			this.UeActorComp = ueActorComp;
		}

		// Token: 0x06047594 RID: 292244 RVA: 0x01224334 File Offset: 0x01222534
		public void ChangeMoveController(bool isAutonomous)
		{
			this.OnChangeMoveController(isAutonomous);
		}

		// Token: 0x06047595 RID: 292245 RVA: 0x01224340 File Offset: 0x01222540
		protected virtual void OnChangeMoveController(bool isAutonomous)
		{
			if (isAutonomous)
			{
				SceneItemManipulatableComponent sceneItem = this.SceneItem;
				SceneItemManipulatableComponent.EManipulatableState? emanipulatableState = (sceneItem != null) ? new SceneItemManipulatableComponent.EManipulatableState?(sceneItem.GetState()) : null;
				if (emanipulatableState != null)
				{
					switch (emanipulatableState.GetValueOrDefault())
					{
					case SceneItemManipulatableComponent.EManipulatableState.BeDrawing:
					case SceneItemManipulatableComponent.EManipulatableState.BeHolding:
					case SceneItemManipulatableComponent.EManipulatableState.BeCastingToTarget:
					case SceneItemManipulatableComponent.EManipulatableState.BeCastingToOutlet:
					case SceneItemManipulatableComponent.EManipulatableState.BeCastingProjectile:
					case SceneItemManipulatableComponent.EManipulatableState.BeDropping:
					{
						SceneItemManipulatableComponent sceneItem2 = this.SceneItem;
						if (sceneItem2 == null)
						{
							return;
						}
						sceneItem2.SetState(SceneItemManipulatableComponent.EManipulatableState.BeCastingFree, "OnChangeMoveController");
						return;
					}
					case SceneItemManipulatableComponent.EManipulatableState.BePrecasting:
					case SceneItemManipulatableComponent.EManipulatableState.BeCastingFree:
					case SceneItemManipulatableComponent.EManipulatableState.MatchingOutlet:
						break;
					default:
						return;
					}
				}
			}
			else
			{
				this.OnExit();
			}
		}

		// Token: 0x06047596 RID: 292246 RVA: 0x012243CC File Offset: 0x012225CC
		public void Enter(bool isAutonomous)
		{
			if (isAutonomous)
			{
				this.OnEnter();
				return;
			}
			this.OnSimulateEnter();
		}

		// Token: 0x06047597 RID: 292247 RVA: 0x012243DE File Offset: 0x012225DE
		protected virtual void OnEnter()
		{
		}

		// Token: 0x06047598 RID: 292248 RVA: 0x012243E0 File Offset: 0x012225E0
		protected virtual void OnSimulateEnter()
		{
		}

		// Token: 0x06047599 RID: 292249 RVA: 0x012243E2 File Offset: 0x012225E2
		public void Tick(float delta, bool isAutonomous)
		{
			if (isAutonomous)
			{
				this.OnTick(delta);
				return;
			}
			this.OnSimulateTick(delta);
		}

		// Token: 0x0604759A RID: 292250 RVA: 0x012243F6 File Offset: 0x012225F6
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0604759B RID: 292251 RVA: 0x012243F8 File Offset: 0x012225F8
		protected virtual void OnSimulateTick(float delta)
		{
		}

		// Token: 0x0604759C RID: 292252 RVA: 0x012243FA File Offset: 0x012225FA
		public void Exit(bool isAutonomous)
		{
			if (isAutonomous)
			{
				this.OnExit();
				return;
			}
			this.OnSimulateExit();
		}

		// Token: 0x0604759D RID: 292253 RVA: 0x0122440C File Offset: 0x0122260C
		protected virtual void OnExit()
		{
		}

		// Token: 0x0604759E RID: 292254 RVA: 0x0122440E File Offset: 0x0122260E
		protected virtual void OnSimulateExit()
		{
		}

		// Token: 0x0604759F RID: 292255 RVA: 0x01224410 File Offset: 0x01222610
		protected void StartCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase>? shakeClass)
		{
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (characterCameraManager != null && characterCameraManager.IsValid() && (shakeClass != null && shakeClass.GetValueOrDefault().IsValid()))
			{
				this.CurrentCameraShake = characterCameraManager.StartMatineeCameraShake(shakeClass.Value.As<UMatineeCameraShake>(), 1f, ECameraShakePlaySpace.CameraLocal, default(FRotator), 1f);
			}
		}

		// Token: 0x060475A0 RID: 292256 RVA: 0x0122447C File Offset: 0x0122267C
		protected void StopCameraShake()
		{
			APlayerCameraManager characterCameraManager = Global.CharacterCameraManager;
			if (characterCameraManager != null && characterCameraManager.IsValid())
			{
				UCameraShakeBase currentCameraShake = this.CurrentCameraShake;
				if (currentCameraShake != null && currentCameraShake.IsValid())
				{
					characterCameraManager.StopCameraShake(this.CurrentCameraShake, true);
				}
			}
		}

		// Token: 0x060475A1 RID: 292257 RVA: 0x012244BB File Offset: 0x012226BB
		protected void StartGamepadShake(UKuroForceFeedbackEffect gamepadShake)
		{
			if (gamepadShake == null || !gamepadShake.IsValid())
			{
				return;
			}
			GamepadController.Instance.TriggerGamepadShakeByManipulatable(gamepadShake);
		}

		// Token: 0x060475A2 RID: 292258 RVA: 0x012244DA File Offset: 0x012226DA
		protected void StopGamepadShake(UKuroForceFeedbackEffect gamepadShake)
		{
			if (gamepadShake == null || !gamepadShake.IsValid())
			{
				return;
			}
			GamepadController.Instance.StopManipulatableGamepadShake(gamepadShake);
		}

		// Token: 0x060475A3 RID: 292259 RVA: 0x012244F9 File Offset: 0x012226F9
		protected void OpenPhysicsSplit()
		{
			UActorComponent ueActorComp = this.UeActorComp;
			if (ueActorComp != null && ueActorComp.IsValid())
			{
				this.UeActorComp.bEnableAutoPhysicsSplit = true;
			}
		}

		// Token: 0x060475A4 RID: 292260 RVA: 0x0122451B File Offset: 0x0122271B
		protected void ClosePhysicsSplit()
		{
			UActorComponent ueActorComp = this.UeActorComp;
			if (ueActorComp != null && ueActorComp.IsValid())
			{
				this.UeActorComp.bEnableAutoPhysicsSplit = false;
				this.UeActorComp.KuroCreatePhysicsState(false);
			}
		}

		// Token: 0x060475A5 RID: 292261 RVA: 0x01224549 File Offset: 0x01222749
		public virtual bool IsNoLockCasting()
		{
			return false;
		}

		// Token: 0x04025835 RID: 153653
		protected readonly SceneItemManipulatableComponent SceneItem;

		// Token: 0x04025836 RID: 153654
		protected readonly SceneItemPropertyComponent PropComp;

		// Token: 0x04025837 RID: 153655
		private UCameraShakeBase CurrentCameraShake;

		// Token: 0x04025838 RID: 153656
		protected Action EnterCallback;

		// Token: 0x04025839 RID: 153657
		protected readonly Action ExitCallback;

		// Token: 0x0402583A RID: 153658
		protected float Timer;

		// Token: 0x0402583B RID: 153659
		protected UActorComponent UeActorComp;
	}
}
