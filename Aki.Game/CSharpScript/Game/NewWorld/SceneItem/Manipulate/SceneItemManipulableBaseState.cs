using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006293 RID: 25235
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemManipulableBaseState
	{
		// Token: 0x0603CE95 RID: 249493 RVA: 0x0117E114 File Offset: 0x0117C314
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

		// Token: 0x0603CE96 RID: 249494 RVA: 0x0117E168 File Offset: 0x0117C368
		public void ChangeMoveController(bool isAutonomous)
		{
			this.OnChangeMoveController(isAutonomous);
		}

		// Token: 0x0603CE97 RID: 249495 RVA: 0x0117E174 File Offset: 0x0117C374
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

		// Token: 0x0603CE98 RID: 249496 RVA: 0x0117E200 File Offset: 0x0117C400
		public void Enter(bool isAutonomous)
		{
			if (isAutonomous)
			{
				this.OnEnter();
				return;
			}
			this.OnSimulateEnter();
		}

		// Token: 0x0603CE99 RID: 249497 RVA: 0x0117E212 File Offset: 0x0117C412
		protected virtual void OnEnter()
		{
		}

		// Token: 0x0603CE9A RID: 249498 RVA: 0x0117E214 File Offset: 0x0117C414
		protected virtual void OnSimulateEnter()
		{
		}

		// Token: 0x0603CE9B RID: 249499 RVA: 0x0117E216 File Offset: 0x0117C416
		public void Tick(float delta, bool isAutonomous)
		{
			if (isAutonomous)
			{
				this.OnTick(delta);
				return;
			}
			this.OnSimulateTick(delta);
		}

		// Token: 0x0603CE9C RID: 249500 RVA: 0x0117E22A File Offset: 0x0117C42A
		protected virtual void OnTick(float delta)
		{
		}

		// Token: 0x0603CE9D RID: 249501 RVA: 0x0117E22C File Offset: 0x0117C42C
		protected virtual void OnSimulateTick(float delta)
		{
		}

		// Token: 0x0603CE9E RID: 249502 RVA: 0x0117E22E File Offset: 0x0117C42E
		public void Exit(bool isAutonomous)
		{
			if (isAutonomous)
			{
				this.OnExit();
				return;
			}
			this.OnSimulateExit();
		}

		// Token: 0x0603CE9F RID: 249503 RVA: 0x0117E240 File Offset: 0x0117C440
		protected virtual void OnExit()
		{
		}

		// Token: 0x0603CEA0 RID: 249504 RVA: 0x0117E242 File Offset: 0x0117C442
		protected virtual void OnSimulateExit()
		{
		}

		// Token: 0x0603CEA1 RID: 249505 RVA: 0x0117E244 File Offset: 0x0117C444
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

		// Token: 0x0603CEA2 RID: 249506 RVA: 0x0117E2B0 File Offset: 0x0117C4B0
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

		// Token: 0x0603CEA3 RID: 249507 RVA: 0x0117E2EF File Offset: 0x0117C4EF
		protected void StartGamepadShake(UKuroForceFeedbackEffect gamepadShake)
		{
			if (gamepadShake == null || !gamepadShake.IsValid())
			{
				return;
			}
			GamepadController.Instance.TriggerGamepadShakeByManipulatable(gamepadShake);
		}

		// Token: 0x0603CEA4 RID: 249508 RVA: 0x0117E30E File Offset: 0x0117C50E
		protected void StopGamepadShake(UKuroForceFeedbackEffect gamepadShake)
		{
			if (gamepadShake == null || !gamepadShake.IsValid())
			{
				return;
			}
			GamepadController.Instance.StopManipulatableGamepadShake(gamepadShake);
		}

		// Token: 0x0603CEA5 RID: 249509 RVA: 0x0117E32D File Offset: 0x0117C52D
		protected void OpenPhysicsSplit()
		{
			UActorComponent ueActorComp = this.UeActorComp;
			if (ueActorComp != null && ueActorComp.IsValid())
			{
				this.UeActorComp.bEnableAutoPhysicsSplit = true;
			}
		}

		// Token: 0x0603CEA6 RID: 249510 RVA: 0x0117E34F File Offset: 0x0117C54F
		protected void ClosePhysicsSplit()
		{
			UActorComponent ueActorComp = this.UeActorComp;
			if (ueActorComp != null && ueActorComp.IsValid())
			{
				this.UeActorComp.bEnableAutoPhysicsSplit = false;
				this.UeActorComp.KuroCreatePhysicsState(false);
			}
		}

		// Token: 0x0603CEA7 RID: 249511 RVA: 0x0117E37D File Offset: 0x0117C57D
		public virtual bool IsNoLockCasting()
		{
			return false;
		}

		// Token: 0x040204A4 RID: 132260
		protected readonly SceneItemManipulatableComponent SceneItem;

		// Token: 0x040204A5 RID: 132261
		protected readonly SceneItemPropertyComponent PropComp;

		// Token: 0x040204A6 RID: 132262
		private UCameraShakeBase CurrentCameraShake;

		// Token: 0x040204A7 RID: 132263
		protected Action EnterCallback;

		// Token: 0x040204A8 RID: 132264
		protected readonly Action ExitCallback;

		// Token: 0x040204A9 RID: 132265
		protected float Timer;

		// Token: 0x040204AA RID: 132266
		protected UActorComponent UeActorComp;
	}
}
