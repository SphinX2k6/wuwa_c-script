using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072DB RID: 29403
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCameraDisplayComponent : EntityComponent
	{
		// Token: 0x17009F3F RID: 40767
		// (get) Token: 0x0604825F RID: 295519 RVA: 0x01282F60 File Offset: 0x01281160
		public BP_CineCamera_C CineCamera
		{
			get
			{
				SceneSubCamera top = this.CameraQueue.Top;
				if (top == null)
				{
					return null;
				}
				return top.Camera;
			}
		}

		// Token: 0x17009F40 RID: 40768
		// (get) Token: 0x06048260 RID: 295520 RVA: 0x01282F78 File Offset: 0x01281178
		public SceneSubCamera CurSceneSubCamera
		{
			get
			{
				PriorityQueue<SceneSubCamera> cameraQueue = this.CameraQueue;
				if (cameraQueue == null)
				{
					return null;
				}
				return cameraQueue.Top;
			}
		}

		// Token: 0x17009F41 RID: 40769
		// (get) Token: 0x06048261 RID: 295521 RVA: 0x01282F8B File Offset: 0x0128118B
		public SceneSubCamera DefaultSceneSubCamera
		{
			get
			{
				return this.DefaultCamera;
			}
		}

		// Token: 0x06048262 RID: 295522 RVA: 0x01282F93 File Offset: 0x01281193
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x06048263 RID: 295523 RVA: 0x01282FB0 File Offset: 0x012811B0
		protected override bool OnInit()
		{
			Comparison<SceneSubCamera> compare;
			if ((compare = SceneCameraDisplayComponent.<>O.<0>__Compare) == null)
			{
				compare = (SceneCameraDisplayComponent.<>O.<0>__Compare = new Comparison<SceneSubCamera>(SceneSubCamera.Compare));
			}
			this.CameraQueue = new PriorityQueue<SceneSubCamera>(compare);
			this.RemoveCameraList = new List<SceneSubCamera>();
			this.DefaultCamera = new SceneSubCamera();
			this.DefaultCamera.Camera = CameraController.Instance.SpawnCineCamera();
			this.DefaultCamera.Type = ESceneSubCameraType.Default;
			this.CameraQueue.Push(this.DefaultCamera);
			this.DefaultCineCameraInternal = this.DefaultCamera.Camera;
			this.SelfCenteredTimeDilation = 1f;
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Add<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSwitchSelfCenteredMode));
			this.AddEvents();
			return this.DefaultCineCameraInternal != null;
		}

		// Token: 0x06048264 RID: 295524 RVA: 0x012830AA File Offset: 0x012812AA
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged)))
			{
				EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			}
		}

		// Token: 0x06048265 RID: 295525 RVA: 0x012830E5 File Offset: 0x012812E5
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged)))
			{
				EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			}
		}

		// Token: 0x06048266 RID: 295526 RVA: 0x01283120 File Offset: 0x01281320
		[NullableContext(1)]
		protected void OnModeChanged(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
		{
			CameraModelInstance cameraModelInstanceInternal = this.CameraModelInstanceInternal;
			if (cameraName != ((cameraModelInstanceInternal != null) ? cameraModelInstanceInternal.CameraName : null))
			{
				return;
			}
			if (newMode == ECustomCameraMode.Scene && this.IsIdle())
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.JYS, "SceneCameraDisplayComponent退出Scene相机", default(ReadOnlySpan<ValueTuple<string, object>>));
				CameraController.Instance.ExitCameraMode(ECustomCameraMode.Scene, 1f, EViewTargetBlendFunction.VTBlend_Linear, 0f, delegate
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Shadow.EnableCSMStable 1", null);
				}, this.CameraModelInstanceInternal.CameraName, null);
				this.ClearRemovedSceneCamera();
				return;
			}
			ECustomCameraMode? ecustomCameraMode = oldMode;
			ECustomCameraMode ecustomCameraMode2 = ECustomCameraMode.Scene;
			if (ecustomCameraMode.GetValueOrDefault() == ecustomCameraMode2 & ecustomCameraMode != null)
			{
				ecustomCameraMode = oldMode;
				if (!(newMode == ecustomCameraMode.GetValueOrDefault() & ecustomCameraMode != null))
				{
					this.ClearRemovedSceneCamera();
					return;
				}
			}
		}

		// Token: 0x06048267 RID: 295527 RVA: 0x012831F0 File Offset: 0x012813F0
		protected void OnWorldDone()
		{
			this.DefaultCamera.Camera = CameraController.Instance.SpawnCineCamera();
			this.DefaultCineCameraInternal = this.DefaultCamera.Camera;
			ECustomCameraMode? cameraMode = this.CameraModelInstanceInternal.CameraMode;
			ECustomCameraMode ecustomCameraMode = ECustomCameraMode.Scene;
			if (cameraMode.GetValueOrDefault() == ecustomCameraMode & cameraMode != null)
			{
				CameraController.Instance.SetViewTarget(this.DefaultCineCameraInternal, "SceneCamera.OnWorldDone", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.CameraModelInstanceInternal.CameraName, null, null);
			}
		}

		// Token: 0x06048268 RID: 295528 RVA: 0x01283280 File Offset: 0x01281480
		protected void OnClearWorld()
		{
			if (this.DefaultCamera != null)
			{
				ActorSystem.Instance.Put("SceneCameraDisplayComponent.OnClearWorld", this.DefaultCineCameraInternal, null);
				this.DefaultCamera.Camera = null;
				this.DefaultCineCameraInternal = null;
			}
			this.UiInActiveCount = 0;
			this.ClearRemovedSceneCamera();
		}

		// Token: 0x06048269 RID: 295529 RVA: 0x012832CC File Offset: 0x012814CC
		protected override bool OnClear()
		{
			if (this.DefaultCineCameraInternal != null)
			{
				ActorSystem.Instance.Put("SceneCameraDisplayComponent.OnClear", this.DefaultCineCameraInternal, null);
				this.DefaultCineCameraInternal = null;
			}
			this.RemoveEvents();
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Remove<ESelfCenteredMode, float>(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSwitchSelfCenteredMode));
			this.CameraModelInstanceInternal = null;
			return true;
		}

		// Token: 0x0604826A RID: 295530 RVA: 0x01283361 File Offset: 0x01281561
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			BP_CineCamera_C defaultCineCameraInternal = this.DefaultCineCameraInternal;
			if (defaultCineCameraInternal != null && defaultCineCameraInternal.IsValid())
			{
				this.DefaultCineCameraInternal.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x0604826B RID: 295531 RVA: 0x01283384 File Offset: 0x01281584
		public SceneSubCamera GetUnBoundSceneCamera(ESceneSubCameraType type)
		{
			if (this.CameraQueue.Empty)
			{
				return null;
			}
			if (!this.DefaultCamera.IsBinding)
			{
				this.RestDefaultSubSceneCamera();
				this.DefaultCamera.Type = type;
				this.DefaultCamera.IsBinding = true;
				this.CameraQueue.Update(this.DefaultCamera);
				return this.DefaultCamera;
			}
			SceneSubCamera sceneSubCamera = new SceneSubCamera();
			sceneSubCamera.Camera = CameraController.Instance.SpawnCineCamera();
			sceneSubCamera.Type = type;
			this.CameraQueue.Push(sceneSubCamera);
			return sceneSubCamera;
		}

		// Token: 0x0604826C RID: 295532 RVA: 0x01283410 File Offset: 0x01281610
		public void RemoveBoundSceneCamera(SceneSubCamera camera)
		{
			if (this.CameraQueue.Empty || camera == null)
			{
				return;
			}
			camera.IsBinding = false;
			if (this.DefaultCamera == camera)
			{
				this.RestDefaultSubSceneCamera();
				this.CameraQueue.Update(this.DefaultCamera);
				return;
			}
			this.CameraQueue.Remove(camera);
			this.RemoveCameraList.Add(camera);
			if (this.IsIdle())
			{
				this.DefaultCamera.CopyData(camera);
			}
		}

		// Token: 0x0604826D RID: 295533 RVA: 0x01283484 File Offset: 0x01281684
		public bool IsIdle()
		{
			return !this.CameraQueue.Empty && this.CameraQueue.Top == this.DefaultCamera && !this.DefaultCamera.IsBinding;
		}

		// Token: 0x0604826E RID: 295534 RVA: 0x012834B8 File Offset: 0x012816B8
		public void ClearRemovedSceneCamera()
		{
			foreach (SceneSubCamera sceneSubCamera in this.RemoveCameraList)
			{
				sceneSubCamera.Clear();
			}
			this.RemoveCameraList.Clear();
		}

		// Token: 0x0604826F RID: 295535 RVA: 0x01283514 File Offset: 0x01281714
		public void UpdateViewTarget(float? fadeIn = null, Action callback = null)
		{
			if (fadeIn != null)
			{
				CameraController.Instance.SetViewTarget(this.CurSceneSubCamera.Camera, "SceneCamera.UpdateViewTarget", fadeIn.Value, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(true), new bool?(true), this.CameraModelInstanceInternal.CameraName, callback, null);
				return;
			}
			CameraController.Instance.SetViewTarget(this.CurSceneSubCamera.Camera, "SceneCamera.UpdateViewTarget2", this.CurSceneSubCamera.FadeIn, this.CurSceneSubCamera.FadeInFunc, this.CurSceneSubCamera.FadeInExp, new bool?(true), new bool?(true), this.CameraModelInstanceInternal.CameraName, callback, this.CurSceneSubCamera.FadeInCurve);
		}

		// Token: 0x06048270 RID: 295536 RVA: 0x012835C9 File Offset: 0x012817C9
		public void EnableExtraCameraAction()
		{
			this.EnablePerspectiveToOrthographicView(null);
		}

		// Token: 0x06048271 RID: 295537 RVA: 0x012835D2 File Offset: 0x012817D2
		public void EnablePerspectiveToOrthographicView(Action callback = null)
		{
			if (this.CurSceneSubCamera.IsCameraAberrationEnable && this.CurSceneSubCamera.CameraAberrationView != null)
			{
				this.CurSceneSubCamera.CameraAberrationView.EnablePerspectiveToOrthographicView(this.CurSceneSubCamera.Camera, callback);
			}
		}

		// Token: 0x06048272 RID: 295538 RVA: 0x0128360C File Offset: 0x0128180C
		public void EnableOrthographicToPerspectiveView(Action callback = null)
		{
			if (this.CurSceneSubCamera.IsCameraAberrationEnable && this.CurSceneSubCamera.CameraAberrationView != null)
			{
				this.CurSceneSubCamera.IsCameraAberrationEnable = false;
				this.CurSceneSubCamera.CameraAberrationView.EnableOrthographicToPerspectiveToView(this.CurSceneSubCamera.Camera, callback);
				return;
			}
			if (callback != null)
			{
				callback();
			}
		}

		// Token: 0x06048273 RID: 295539 RVA: 0x01283668 File Offset: 0x01281868
		protected override void OnAfterTick(float deltaTime)
		{
			float second = deltaTime * 0.001f * this.SelfCenteredTimeDilation;
			SceneSubCamera curSceneSubCamera = this.CurSceneSubCamera;
			if (((curSceneSubCamera != null) ? curSceneSubCamera.CameraAberrationView : null) != null)
			{
				this.CurSceneSubCamera.CameraAberrationView.Update(second);
			}
		}

		// Token: 0x06048274 RID: 295540 RVA: 0x012836AC File Offset: 0x012818AC
		private void RestDefaultSubSceneCamera()
		{
			this.DefaultCamera.IsBinding = false;
			BP_CineCamera_C camera = this.DefaultCamera.Camera;
			if (camera != null && camera.IsValid())
			{
				camera.CameraComponent.bConstrainAspectRatio = false;
			}
			this.DefaultCamera.Type = ESceneSubCameraType.Default;
			this.DefaultCamera.IsKeepUi = true;
			this.DefaultCamera.CanAcceptInput = false;
			this.DefaultCamera.FixInputData = null;
			this.DefaultCamera.FollowConfig = null;
		}

		// Token: 0x06048275 RID: 295541 RVA: 0x01283724 File Offset: 0x01281924
		public void SetUiActive(bool isActive)
		{
			if (isActive)
			{
				if (this.UiInActiveCount > 0)
				{
					this.UiInActiveCount--;
				}
			}
			else
			{
				this.UiInActiveCount++;
			}
			if (this.UiInActiveCount != 0 && isActive)
			{
				return;
			}
			if (this.UiInActiveCount > 1 && !isActive)
			{
				return;
			}
			UiLayer.Instance.SetLayerActive(ELayerType.Pop, isActive);
			UiLayer.Instance.SetLayerActive(ELayerType.Float, isActive);
			if (isActive)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.CameraSeq, 0);
				InputDistributeModel.Instance.RemoveInputDistributeTag("BlockAllInputTag", false);
				InputDistributeController.Instance.RefreshInputTag();
				UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("SceneCameraDisplayComponent.SetUiActive");
				return;
			}
			BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.CameraSeq, null, 0);
			InputDistributeModel.Instance.SetInputDistributeTag("BlockAllInputTag");
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag("SceneCameraDisplayComponent.SetUiActive");
		}

		// Token: 0x06048276 RID: 295542 RVA: 0x01283801 File Offset: 0x01281A01
		private void OnSwitchSelfCenteredMode(ESelfCenteredMode selfCenterMode, float globalTimeDilation)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.SelfCenteredTimeDilation = CharacterModel.Instance.InverseSelfCenteredTimeDilation;
			}, null, null);
		}

		// Token: 0x06048277 RID: 295543 RVA: 0x0128381C File Offset: 0x01281A1C
		protected override bool OnEnd()
		{
			this.SelfCenteredTimeDilation = 1f;
			return true;
		}

		// Token: 0x06048278 RID: 295544 RVA: 0x0128382C File Offset: 0x01281A2C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneCameraDisplayComponent sceneCameraDisplayComponent = (SceneCameraDisplayComponent)componentTemplate;
			if (base.CanResetComponentProperty("CameraModelInstanceInternal"))
			{
				if (sceneCameraDisplayComponent.CameraModelInstanceInternal == null)
				{
					this.CameraModelInstanceInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CameraModelInstance>(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DefaultCineCameraInternal"))
			{
				if (sceneCameraDisplayComponent.DefaultCineCameraInternal == null)
				{
					this.DefaultCineCameraInternal = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_CineCamera_C>(this.DefaultCineCameraInternal), "DefaultCineCameraInternal"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CameraQueue"))
			{
				if (sceneCameraDisplayComponent.CameraQueue == null)
				{
					this.CameraQueue = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PriorityQueue<SceneSubCamera>>(this.CameraQueue), "CameraQueue"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RemoveCameraList"))
			{
				if (sceneCameraDisplayComponent.RemoveCameraList == null)
				{
					this.RemoveCameraList = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<SceneSubCamera>>(this.RemoveCameraList), "RemoveCameraList"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DefaultCamera"))
			{
				if (sceneCameraDisplayComponent.DefaultCamera == null)
				{
					this.DefaultCamera = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneSubCamera>(this.DefaultCamera), "DefaultCamera"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("UiInActiveCount"))
			{
				this.UiInActiveCount = sceneCameraDisplayComponent.UiInActiveCount;
			}
			if (base.CanResetComponentProperty("SelfCenteredTimeDilation"))
			{
				this.SelfCenteredTimeDilation = sceneCameraDisplayComponent.SelfCenteredTimeDilation;
			}
			return true;
		}

		// Token: 0x04026151 RID: 155985
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04026152 RID: 155986
		private BP_CineCamera_C DefaultCineCameraInternal;

		// Token: 0x04026153 RID: 155987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private PriorityQueue<SceneSubCamera> CameraQueue;

		// Token: 0x04026154 RID: 155988
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SceneSubCamera> RemoveCameraList;

		// Token: 0x04026155 RID: 155989
		private SceneSubCamera DefaultCamera;

		// Token: 0x04026156 RID: 155990
		private int UiInActiveCount;

		// Token: 0x04026157 RID: 155991
		private float SelfCenteredTimeDilation = 1f;

		// Token: 0x0200CFD0 RID: 53200
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E7C9 RID: 255945
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<SceneSubCamera> <0>__Compare;
		}
	}
}
