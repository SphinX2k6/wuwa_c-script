using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200645F RID: 25695
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCameraPlayerComponent : EntityComponent
	{
		// Token: 0x0603E6A9 RID: 255657 RVA: 0x01226598 File Offset: 0x01224798
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E6AA RID: 255658 RVA: 0x012265B3 File Offset: 0x012247B3
		protected override bool OnStart()
		{
			this.DisplayComponent = base.Entity.GetComponent<SceneCameraDisplayComponent>();
			this.SceneCameraInputComponent = base.Entity.GetComponent<SceneCameraInputComponent>();
			this.FixSceneSubCameraList = new List<SceneSubCamera>();
			return this.DisplayComponent.Valid;
		}

		// Token: 0x0603E6AB RID: 255659 RVA: 0x012265ED File Offset: 0x012247ED
		protected override bool OnEnd()
		{
			this.DisplayComponent = null;
			this.SceneCameraInputComponent = null;
			this.FixSceneSubCameraList = null;
			return true;
		}

		// Token: 0x0603E6AC RID: 255660 RVA: 0x01226608 File Offset: 0x01224808
		public void ExitCameraMode(Action callback = null, SceneSubCamera camera = null, ELevelSequenceTransition? transitionType = null)
		{
			if (!CameraController.Instance.ExitCameraMode(ECustomCameraMode.Scene, (transitionType == ELevelSequenceTransition.Mask) ? 0f : ((camera != null) ? camera.FadeOut : 1f), UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear, 0f, callback, this.CameraModelInstanceInternal.CameraName, null) && callback != null)
			{
				callback();
			}
		}

		// Token: 0x0603E6AD RID: 255661 RVA: 0x01226668 File Offset: 0x01224868
		public void ExitSceneSubCamera(SceneSubCamera camera, Action callback = null, ELevelSequenceTransition? transitionType = null)
		{
			this.DisplayComponent.RemoveBoundSceneCamera(camera);
			if ((camera == null || !camera.EnableInPlotMode) && PlotModel.Instance.IsInHighLevelPlot())
			{
				this.ExitCameraMode(callback, camera, transitionType);
				return;
			}
			if (!this.DisplayComponent.IsIdle())
			{
				this.DisplayComponent.UpdateViewTarget(null, null);
				if (callback != null)
				{
					callback();
				}
				return;
			}
			if (this.CameraModelInstanceInternal.IsInHigherMode(ECustomCameraMode.Scene))
			{
				this.ExitCameraMode(callback, camera, transitionType);
				return;
			}
			this.DisplayComponent.UpdateViewTarget(new float?(0f), null);
			this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetRotation(new FRotator(this.CameraModelInstanceInternal.FightCamera.LogicComponent.CameraRotation.Pitch, this.DisplayComponent.CineCamera.K2_GetActorRotation().Yaw, this.CameraModelInstanceInternal.FightCamera.LogicComponent.CameraRotation.Roll));
			this.ExitCameraMode(callback, camera, transitionType);
		}

		// Token: 0x0603E6AE RID: 255662 RVA: 0x01226774 File Offset: 0x01224974
		[NullableContext(1)]
		public void EnterSceneSubCamera(SceneSubCamera camera, [Nullable(2)] Action callback = null)
		{
			if (camera != this.DisplayComponent.CurSceneSubCamera)
			{
				return;
			}
			this.DisplayComponent.UpdateViewTarget(null, callback);
		}

		// Token: 0x0603E6AF RID: 255663 RVA: 0x012267A8 File Offset: 0x012249A8
		public void EnterFixSceneSubCamera([Nullable(1)] Vector vectorLoc, [Nullable(1)] Rotator vectorRot, float fov, float fadeInTime, float fadeOutTime, ESceneSubCameraType type, Action callback = null, UnrealEngine.EViewTargetBlendFunction? blendInFunc = 0, float? blendInExp = 0f, UnrealEngine.EViewTargetBlendFunction? blendOutFunc = 0, float? blendOutExp = 0f, bool? isCameraAberrationEnable = false, CameraAberrationView cameraAberrationView = null, bool? canAcceptInput = false, SceneFixInputData fixInputData = null, [Nullable(1)] string reason = "", SceneCameraFollowConfig followConfig = null, UCurveFloat blendInCurve = null, UCurveFloat blendOutCurve = null, bool enableInPlotMode = false, bool mustCallback = false)
		{
			UnrealEngine.EViewTargetBlendFunction value = blendInFunc.GetValueOrDefault();
			if (blendInFunc == null)
			{
				value = UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear;
				blendInFunc = new UnrealEngine.EViewTargetBlendFunction?(value);
			}
			float value2 = blendInExp.GetValueOrDefault();
			if (blendInExp == null)
			{
				value2 = 0f;
				blendInExp = new float?(value2);
			}
			value = blendOutFunc.GetValueOrDefault();
			if (blendOutFunc == null)
			{
				value = UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear;
				blendOutFunc = new UnrealEngine.EViewTargetBlendFunction?(value);
			}
			value2 = blendOutExp.GetValueOrDefault();
			if (blendOutExp == null)
			{
				value2 = 0f;
				blendOutExp = new float?(value2);
			}
			bool value3 = isCameraAberrationEnable.GetValueOrDefault();
			if (isCameraAberrationEnable == null)
			{
				value3 = false;
				isCameraAberrationEnable = new bool?(value3);
			}
			value3 = canAcceptInput.GetValueOrDefault();
			if (canAcceptInput == null)
			{
				value3 = false;
				canAcceptInput = new bool?(value3);
			}
			if (!enableInPlotMode && PlotModel.Instance.IsInHighLevelPlot())
			{
				return;
			}
			this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetIsDitherEffectEnable(false);
			SceneSubCamera unBoundSceneCamera = this.DisplayComponent.GetUnBoundSceneCamera(type);
			unBoundSceneCamera.FadeIn = fadeInTime;
			unBoundSceneCamera.FadeInFunc = blendInFunc.Value;
			unBoundSceneCamera.FadeInExp = blendInExp.Value;
			unBoundSceneCamera.FadeOut = fadeOutTime;
			unBoundSceneCamera.FadeOutFunc = blendOutFunc.Value;
			unBoundSceneCamera.FadeOutExp = blendOutExp.Value;
			unBoundSceneCamera.Camera.GetCineCameraComponent().SetFieldOfView(fov);
			unBoundSceneCamera.Camera.CameraComponent.bConstrainAspectRatio = false;
			unBoundSceneCamera.IsCameraAberrationEnable = isCameraAberrationEnable.Value;
			unBoundSceneCamera.CameraAberrationView = cameraAberrationView;
			unBoundSceneCamera.FadeInCurve = blendInCurve;
			unBoundSceneCamera.FadeOutCurve = blendOutCurve;
			unBoundSceneCamera.StartRotation = vectorRot;
			unBoundSceneCamera.CanAcceptInput = canAcceptInput.Value;
			unBoundSceneCamera.EnableInPlotMode = enableInPlotMode;
			unBoundSceneCamera.FixInputData = fixInputData;
			unBoundSceneCamera.FollowConfig = followConfig;
			AActor camera = unBoundSceneCamera.Camera;
			FRotator frotator = vectorRot.ToUeRotator();
			FVectorDouble fvectorDouble = vectorLoc.ToUeVector(false);
			FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
			FVector fvector = fvectorDouble2;
			FTransformDouble ftransformDouble = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			camera.D_K2_SetActorTransform(ftransformDouble, false, ref WorldGlobal.SweepHitResult, true);
			if (type == ESceneSubCameraType.Gameplay && reason != "")
			{
				if (this.GameplaySceneSubCameraList.ContainsKey(reason))
				{
					this.GameplaySceneSubCameraList[reason].Add(unBoundSceneCamera);
				}
				else
				{
					this.GameplaySceneSubCameraList[reason] = new List<SceneSubCamera>
					{
						unBoundSceneCamera
					};
				}
			}
			else
			{
				this.FixSceneSubCameraList.Add(unBoundSceneCamera);
			}
			ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Scene;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				this.EnterSceneSubCamera(unBoundSceneCamera, callback);
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.EnableCSMStable 0", null);
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Scene, fadeInTime, blendInFunc.Value, blendInExp.Value, callback, mustCallback, this.CameraModelInstanceInternal.CameraName, blendInCurve);
			SceneCameraDisplayComponent displayComponent = this.DisplayComponent;
			if (displayComponent == null)
			{
				return;
			}
			displayComponent.EnableExtraCameraAction();
		}

		// Token: 0x0603E6B0 RID: 255664 RVA: 0x01226A83 File Offset: 0x01224C83
		public void ExitFixSceneSubCamera(Action exitFixCameraCallback = null, bool needYaw = true)
		{
			if (this.FixSceneSubCameraList.Count == 0)
			{
				return;
			}
			this.ExitSceneSubCameraByType(ESceneSubCameraType.Fix, exitFixCameraCallback, needYaw, "");
		}

		// Token: 0x0603E6B1 RID: 255665 RVA: 0x01226AA1 File Offset: 0x01224CA1
		[NullableContext(1)]
		public void ExitGameplaySubCamera(string reason, [Nullable(2)] Action exitFixCameraCallback = null, bool needYaw = true)
		{
			if (!this.GameplaySceneSubCameraList.ContainsKey(reason))
			{
				return;
			}
			this.ExitSceneSubCameraByType(ESceneSubCameraType.Gameplay, exitFixCameraCallback, needYaw, reason);
		}

		// Token: 0x0603E6B2 RID: 255666 RVA: 0x01226ABC File Offset: 0x01224CBC
		[NullableContext(1)]
		private void ExitSceneSubCameraByType(ESceneSubCameraType type, [Nullable(2)] Action exitFixCameraCallback = null, bool needYaw = true, string reason = "")
		{
			Action callback = delegate()
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.EnableCSMStable 1", null);
				Action exitFixCameraCallback2 = exitFixCameraCallback;
				if (exitFixCameraCallback2 == null)
				{
					return;
				}
				exitFixCameraCallback2();
			};
			this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetIsDitherEffectEnable(true);
			SceneSubCamera sceneSubCamera = null;
			if (this.DisplayComponent.CurSceneSubCamera.Type == type && this.DisplayComponent.DefaultSceneSubCamera != this.DisplayComponent.CurSceneSubCamera)
			{
				sceneSubCamera = this.DisplayComponent.CurSceneSubCamera;
			}
			if (type != ESceneSubCameraType.Fix)
			{
				if (type == ESceneSubCameraType.Gameplay)
				{
					foreach (SceneSubCamera camera in this.GameplaySceneSubCameraList[reason])
					{
						this.DisplayComponent.RemoveBoundSceneCamera(camera);
					}
					this.GameplaySceneSubCameraList.Remove(reason);
					if (this.GameplaySceneSubCameraList.Count > 0)
					{
						return;
					}
				}
			}
			else
			{
				while (this.FixSceneSubCameraList.Count > 0)
				{
					SceneSubCamera camera2 = this.FixSceneSubCameraList[this.FixSceneSubCameraList.Count - 1];
					this.FixSceneSubCameraList.RemoveAt(this.FixSceneSubCameraList.Count - 1);
					this.DisplayComponent.RemoveBoundSceneCamera(camera2);
				}
			}
			if (!this.DisplayComponent.IsIdle())
			{
				this.DisplayComponent.UpdateViewTarget(null, null);
				return;
			}
			if (this.CameraModelInstanceInternal.IsInHigherMode(ECustomCameraMode.Scene))
			{
				this.ExitCameraMode(callback, null, null);
				return;
			}
			if (sceneSubCamera != null && this.DisplayComponent.DefaultSceneSubCamera.Camera != null)
			{
				this.DisplayComponent.DefaultSceneSubCamera.CopyData(sceneSubCamera);
				this.DisplayComponent.UpdateViewTarget(new float?(0f), null);
			}
			if (needYaw)
			{
				CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
				bool flag;
				if (cameraModelInstanceInternal == null)
				{
					flag = (null != null);
				}
				else
				{
					FightCamera fightCamera = cameraModelInstanceInternal.FightCamera;
					flag = (((fightCamera != null) ? fightCamera.LogicComponent : null) != null);
				}
				if (flag)
				{
					SceneCameraDisplayComponent displayComponent = this.DisplayComponent;
					if (((displayComponent != null) ? displayComponent.CineCamera : null) != null)
					{
						this.CameraModelInstanceInternal.FightCamera.LogicComponent.SetRotation(new FRotator(this.CameraModelInstanceInternal.FightCamera.LogicComponent.CameraRotation.Pitch, this.DisplayComponent.CineCamera.K2_GetActorRotation().Yaw, this.CameraModelInstanceInternal.FightCamera.LogicComponent.CameraRotation.Roll));
					}
				}
			}
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Scene, this.DisplayComponent.DefaultSceneSubCamera.FadeOut, this.DisplayComponent.DefaultSceneSubCamera.FadeOutFunc, this.DisplayComponent.DefaultSceneSubCamera.FadeOutExp, callback, this.CameraModelInstanceInternal.CameraName, this.DisplayComponent.DefaultSceneSubCamera.FadeOutCurve);
		}

		// Token: 0x0603E6B3 RID: 255667 RVA: 0x01226D74 File Offset: 0x01224F74
		public bool IsCameraAberrationEnable()
		{
			return this.DisplayComponent.CurSceneSubCamera.IsCameraAberrationEnable;
		}

		// Token: 0x0603E6B4 RID: 255668 RVA: 0x01226D86 File Offset: 0x01224F86
		public void EnableOrthographicToPerspectiveView(Action callback = null)
		{
			this.DisplayComponent.EnableOrthographicToPerspectiveView(callback);
		}

		// Token: 0x0603E6B5 RID: 255669 RVA: 0x01226D94 File Offset: 0x01224F94
		public bool IsDefaultSubCameraValid()
		{
			SceneCameraDisplayComponent displayComponent = this.DisplayComponent;
			if (displayComponent == null)
			{
				return false;
			}
			SceneSubCamera defaultSceneSubCamera = displayComponent.DefaultSceneSubCamera;
			bool? flag;
			if (defaultSceneSubCamera == null)
			{
				flag = null;
			}
			else
			{
				BP_CineCamera_C camera = defaultSceneSubCamera.Camera;
				flag = ((camera != null) ? new bool?(camera.IsValid()) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x0603E6B6 RID: 255670 RVA: 0x01226DE8 File Offset: 0x01224FE8
		public void SetCameraFov(float fov, float minFov, float maxFov)
		{
			if (this.DisplayComponent.CurSceneSubCamera != null)
			{
				float fieldOfView = Math.Max(minFov, Math.Min(maxFov, fov));
				this.DisplayComponent.CurSceneSubCamera.Camera.GetCineCameraComponent().SetFieldOfView(fieldOfView);
			}
		}

		// Token: 0x0603E6B7 RID: 255671 RVA: 0x01226E2B File Offset: 0x0122502B
		[NullableContext(1)]
		public void SetCameraLookAtPosition(Vector targetPosition, float duration = 1f)
		{
			this.SceneCameraInputComponent.SetLookAtTarget(targetPosition, duration * 1000f);
		}

		// Token: 0x0603E6B8 RID: 255672 RVA: 0x01226E40 File Offset: 0x01225040
		protected override bool OnClear()
		{
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0603E6B9 RID: 255673 RVA: 0x01226E4C File Offset: 0x0122504C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneCameraPlayerComponent sceneCameraPlayerComponent = (SceneCameraPlayerComponent)componentTemplate;
			if (sceneCameraPlayerComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (sceneCameraPlayerComponent.DisplayComponent == null)
			{
				this.DisplayComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DisplayComponent), "DisplayComponent"))
			{
				return false;
			}
			if (sceneCameraPlayerComponent.SceneCameraInputComponent == null)
			{
				this.SceneCameraInputComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SceneCameraInputComponent), "SceneCameraInputComponent"))
			{
				return false;
			}
			if (sceneCameraPlayerComponent.FixSceneSubCameraList == null)
			{
				this.FixSceneSubCameraList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FixSceneSubCameraList), "FixSceneSubCameraList"))
			{
				return false;
			}
			return sceneCameraPlayerComponent.GameplaySceneSubCameraList == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.GameplaySceneSubCameraList), "GameplaySceneSubCameraList");
		}

		// Token: 0x170076C8 RID: 30408
		// (get) Token: 0x0603E6BA RID: 255674 RVA: 0x01226F3A File Offset: 0x0122513A
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C9 RID: 30409
		// (get) Token: 0x0603E6BB RID: 255675 RVA: 0x01226F3D File Offset: 0x0122513D
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076CA RID: 30410
		// (get) Token: 0x0603E6BC RID: 255676 RVA: 0x01226F40 File Offset: 0x01225140
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076CB RID: 30411
		// (get) Token: 0x0603E6BD RID: 255677 RVA: 0x01226F43 File Offset: 0x01225143
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04021442 RID: 136258
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04021443 RID: 136259
		private SceneCameraDisplayComponent DisplayComponent;

		// Token: 0x04021444 RID: 136260
		private SceneCameraInputComponent SceneCameraInputComponent;

		// Token: 0x04021445 RID: 136261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SceneSubCamera> FixSceneSubCameraList;

		// Token: 0x04021446 RID: 136262
		[Nullable(1)]
		private readonly Dictionary<string, List<SceneSubCamera>> GameplaySceneSubCameraList = new Dictionary<string, List<SceneSubCamera>>();
	}
}
