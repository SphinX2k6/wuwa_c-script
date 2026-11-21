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
	// Token: 0x0200645D RID: 25693
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneCameraDisplayComponent : EntityComponent
	{
		// Token: 0x170076B9 RID: 30393
		// (get) Token: 0x0603E673 RID: 255603 RVA: 0x01225748 File Offset: 0x01223948
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

		// Token: 0x170076BA RID: 30394
		// (get) Token: 0x0603E674 RID: 255604 RVA: 0x01225760 File Offset: 0x01223960
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

		// Token: 0x170076BB RID: 30395
		// (get) Token: 0x0603E675 RID: 255605 RVA: 0x01225773 File Offset: 0x01223973
		public SceneSubCamera DefaultSceneSubCamera
		{
			get
			{
				return this.DefaultCamera;
			}
		}

		// Token: 0x0603E676 RID: 255606 RVA: 0x0122577B File Offset: 0x0122397B
		protected override bool OnCreate(IEntityArgs args = null)
		{
			this.CameraModelInstanceInternal = ((args != null) ? args.GetP1<CameraModelInstance>() : null);
			return base.OnCreate(args);
		}

		// Token: 0x0603E677 RID: 255607 RVA: 0x01225798 File Offset: 0x01223998
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

		// Token: 0x0603E678 RID: 255608 RVA: 0x01225892 File Offset: 0x01223A92
		private void AddEvents()
		{
			if (!EventSystem.Instance.Has<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged)))
			{
				EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			}
		}

		// Token: 0x0603E679 RID: 255609 RVA: 0x012258CD File Offset: 0x01223ACD
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged)))
			{
				EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.OnModeChanged));
			}
		}

		// Token: 0x0603E67A RID: 255610 RVA: 0x01225908 File Offset: 0x01223B08
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

		// Token: 0x0603E67B RID: 255611 RVA: 0x012259D8 File Offset: 0x01223BD8
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

		// Token: 0x0603E67C RID: 255612 RVA: 0x01225A68 File Offset: 0x01223C68
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

		// Token: 0x0603E67D RID: 255613 RVA: 0x01225AB4 File Offset: 0x01223CB4
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

		// Token: 0x0603E67E RID: 255614 RVA: 0x01225B49 File Offset: 0x01223D49
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			BP_CineCamera_C defaultCineCameraInternal = this.DefaultCineCameraInternal;
			if (defaultCineCameraInternal != null && defaultCineCameraInternal.IsValid())
			{
				this.DefaultCineCameraInternal.CustomTimeDilation = timeDilation;
			}
		}

		// Token: 0x0603E67F RID: 255615 RVA: 0x01225B6C File Offset: 0x01223D6C
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

		// Token: 0x0603E680 RID: 255616 RVA: 0x01225BF8 File Offset: 0x01223DF8
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

		// Token: 0x0603E681 RID: 255617 RVA: 0x01225C6C File Offset: 0x01223E6C
		public bool IsIdle()
		{
			return !this.CameraQueue.Empty && this.CameraQueue.Top == this.DefaultCamera && !this.DefaultCamera.IsBinding;
		}

		// Token: 0x0603E682 RID: 255618 RVA: 0x01225CA0 File Offset: 0x01223EA0
		public void ClearRemovedSceneCamera()
		{
			foreach (SceneSubCamera sceneSubCamera in this.RemoveCameraList)
			{
				sceneSubCamera.Clear();
			}
			this.RemoveCameraList.Clear();
		}

		// Token: 0x0603E683 RID: 255619 RVA: 0x01225CFC File Offset: 0x01223EFC
		public void UpdateViewTarget(float? fadeIn = null, Action callback = null)
		{
			if (fadeIn != null)
			{
				CameraController.Instance.SetViewTarget(this.CurSceneSubCamera.Camera, "SceneCamera.UpdateViewTarget", fadeIn.Value, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(true), new bool?(true), this.CameraModelInstanceInternal.CameraName, callback, null);
				return;
			}
			CameraController.Instance.SetViewTarget(this.CurSceneSubCamera.Camera, "SceneCamera.UpdateViewTarget2", this.CurSceneSubCamera.FadeIn, this.CurSceneSubCamera.FadeInFunc, this.CurSceneSubCamera.FadeInExp, new bool?(true), new bool?(true), this.CameraModelInstanceInternal.CameraName, callback, this.CurSceneSubCamera.FadeInCurve);
		}

		// Token: 0x0603E684 RID: 255620 RVA: 0x01225DB1 File Offset: 0x01223FB1
		public void EnableExtraCameraAction()
		{
			this.EnablePerspectiveToOrthographicView(null);
		}

		// Token: 0x0603E685 RID: 255621 RVA: 0x01225DBA File Offset: 0x01223FBA
		public void EnablePerspectiveToOrthographicView(Action callback = null)
		{
			if (this.CurSceneSubCamera.IsCameraAberrationEnable && this.CurSceneSubCamera.CameraAberrationView != null)
			{
				this.CurSceneSubCamera.CameraAberrationView.EnablePerspectiveToOrthographicView(this.CurSceneSubCamera.Camera, callback);
			}
		}

		// Token: 0x0603E686 RID: 255622 RVA: 0x01225DF4 File Offset: 0x01223FF4
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

		// Token: 0x0603E687 RID: 255623 RVA: 0x01225E50 File Offset: 0x01224050
		protected override void OnAfterTick(float deltaTime)
		{
			float second = deltaTime * 0.001f * this.SelfCenteredTimeDilation;
			SceneSubCamera curSceneSubCamera = this.CurSceneSubCamera;
			if (((curSceneSubCamera != null) ? curSceneSubCamera.CameraAberrationView : null) != null)
			{
				this.CurSceneSubCamera.CameraAberrationView.Update(second);
			}
		}

		// Token: 0x0603E688 RID: 255624 RVA: 0x01225E94 File Offset: 0x01224094
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

		// Token: 0x0603E689 RID: 255625 RVA: 0x01225F0C File Offset: 0x0122410C
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

		// Token: 0x0603E68A RID: 255626 RVA: 0x01225FE9 File Offset: 0x012241E9
		private void OnSwitchSelfCenteredMode(ESelfCenteredMode selfCenterMode, float globalTimeDilation)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.SelfCenteredTimeDilation = CharacterModel.Instance.InverseSelfCenteredTimeDilation;
			}, null, null);
		}

		// Token: 0x0603E68B RID: 255627 RVA: 0x01226004 File Offset: 0x01224204
		protected override bool OnEnd()
		{
			this.SelfCenteredTimeDilation = 1f;
			return true;
		}

		// Token: 0x0603E68C RID: 255628 RVA: 0x01226014 File Offset: 0x01224214
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneCameraDisplayComponent sceneCameraDisplayComponent = (SceneCameraDisplayComponent)componentTemplate;
			if (sceneCameraDisplayComponent.CameraModelInstanceInternal == null)
			{
				this.CameraModelInstanceInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraModelInstanceInternal), "CameraModelInstanceInternal"))
			{
				return false;
			}
			if (sceneCameraDisplayComponent.DefaultCineCameraInternal == null)
			{
				this.DefaultCineCameraInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultCineCameraInternal), "DefaultCineCameraInternal"))
			{
				return false;
			}
			if (sceneCameraDisplayComponent.CameraQueue == null)
			{
				this.CameraQueue = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CameraQueue), "CameraQueue"))
			{
				return false;
			}
			if (sceneCameraDisplayComponent.RemoveCameraList == null)
			{
				this.RemoveCameraList = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RemoveCameraList), "RemoveCameraList"))
			{
				return false;
			}
			if (sceneCameraDisplayComponent.DefaultCamera == null)
			{
				this.DefaultCamera = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultCamera), "DefaultCamera"))
			{
				return false;
			}
			this.UiInActiveCount = sceneCameraDisplayComponent.UiInActiveCount;
			this.SelfCenteredTimeDilation = sceneCameraDisplayComponent.SelfCenteredTimeDilation;
			return true;
		}

		// Token: 0x170076BC RID: 30396
		// (get) Token: 0x0603E68D RID: 255629 RVA: 0x01226123 File Offset: 0x01224323
		public override bool NeedCreateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076BD RID: 30397
		// (get) Token: 0x0603E68E RID: 255630 RVA: 0x01226126 File Offset: 0x01224326
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076BE RID: 30398
		// (get) Token: 0x0603E68F RID: 255631 RVA: 0x01226129 File Offset: 0x01224329
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076BF RID: 30399
		// (get) Token: 0x0603E690 RID: 255632 RVA: 0x0122612C File Offset: 0x0122432C
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C0 RID: 30400
		// (get) Token: 0x0603E691 RID: 255633 RVA: 0x0122612F File Offset: 0x0122432F
		public override bool NeedAfterTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076C1 RID: 30401
		// (get) Token: 0x0603E692 RID: 255634 RVA: 0x01226132 File Offset: 0x01224332
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04021434 RID: 136244
		private CameraModelInstance CameraModelInstanceInternal;

		// Token: 0x04021435 RID: 136245
		private BP_CineCamera_C DefaultCineCameraInternal;

		// Token: 0x04021436 RID: 136246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private PriorityQueue<SceneSubCamera> CameraQueue;

		// Token: 0x04021437 RID: 136247
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<SceneSubCamera> RemoveCameraList;

		// Token: 0x04021438 RID: 136248
		private SceneSubCamera DefaultCamera;

		// Token: 0x04021439 RID: 136249
		private int UiInActiveCount;

		// Token: 0x0402143A RID: 136250
		private float SelfCenteredTimeDilation = 1f;

		// Token: 0x0200BBAB RID: 48043
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039C06 RID: 236550
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<SceneSubCamera> <0>__Compare;
		}
	}
}
