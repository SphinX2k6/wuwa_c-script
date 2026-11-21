using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039AA RID: 14762
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCamera
	{
		// Token: 0x17004D91 RID: 19857
		// (get) Token: 0x0602602C RID: 155692 RVA: 0x00AAADAB File Offset: 0x00AA8FAB
		// (set) Token: 0x0602602D RID: 155693 RVA: 0x00AAADB3 File Offset: 0x00AA8FB3
		public EUiCameraMode CurrentMode { get; private set; }

		// Token: 0x17004D92 RID: 19858
		// (get) Token: 0x0602602E RID: 155694 RVA: 0x00AAADBC File Offset: 0x00AA8FBC
		// (set) Token: 0x0602602F RID: 155695 RVA: 0x00AAADC4 File Offset: 0x00AA8FC4
		public UiCameraModel Model { get; private set; }

		// Token: 0x17004D93 RID: 19859
		// (get) Token: 0x06026030 RID: 155696 RVA: 0x00AAADCD File Offset: 0x00AA8FCD
		// (set) Token: 0x06026031 RID: 155697 RVA: 0x00AAADD5 File Offset: 0x00AA8FD5
		[Nullable(2)]
		public BP_CineCamera_C CameraActor { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004D94 RID: 19860
		// (get) Token: 0x06026032 RID: 155698 RVA: 0x00AAADDE File Offset: 0x00AA8FDE
		// (set) Token: 0x06026033 RID: 155699 RVA: 0x00AAADE6 File Offset: 0x00AA8FE6
		[Nullable(2)]
		public UCineCameraComponent CineCameraComponent { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x17004D95 RID: 19861
		// (get) Token: 0x06026034 RID: 155700 RVA: 0x00AAADEF File Offset: 0x00AA8FEF
		// (set) Token: 0x06026035 RID: 155701 RVA: 0x00AAADF7 File Offset: 0x00AA8FF7
		public bool IsEntered { get; private set; }

		// Token: 0x17004D96 RID: 19862
		// (get) Token: 0x06026036 RID: 155702 RVA: 0x00AAAE00 File Offset: 0x00AA9000
		private UiCameraModeBase CurrentModeInstance
		{
			get
			{
				return this.Modes[this.CurrentMode];
			}
		}

		// Token: 0x06026037 RID: 155703 RVA: 0x00AAAE13 File Offset: 0x00AA9013
		public void Initialize(UiCameraModel model)
		{
			this.Model = model;
			this.RefreshCameraActor();
			this.AddMode(EUiCameraMode.Normal, new UiCameraNormalMode());
			this.AddMode(EUiCameraMode.Photographer, new UiCameraPhotographerMode());
			this.CurrentMode = EUiCameraMode.Normal;
			this.CurrentModeInstance.Enter();
		}

		// Token: 0x06026038 RID: 155704 RVA: 0x00AAAE50 File Offset: 0x00AA9050
		public void SwitchMode(EUiCameraMode mode)
		{
			UiCameraModeBase uiCameraModeBase;
			if (this.CurrentMode == mode || !this.Modes.TryGetValue(mode, out uiCameraModeBase))
			{
				return;
			}
			this.CurrentModeInstance.Exit();
			this.RefreshCameraActor();
			this.CurrentMode = mode;
			uiCameraModeBase.Enter();
		}

		// Token: 0x06026039 RID: 155705 RVA: 0x00AAAE96 File Offset: 0x00AA9096
		private void AddMode(EUiCameraMode modeType, UiCameraModeBase mode)
		{
			mode.Initialize(this);
			this.Modes.Add(modeType, mode);
		}

		// Token: 0x0602603A RID: 155706 RVA: 0x00AAAEAC File Offset: 0x00AA90AC
		public T GetMode<[Nullable(0)] T>() where T : UiCameraModeBase
		{
			foreach (UiCameraModeBase uiCameraModeBase in this.Modes.Values)
			{
				T t = uiCameraModeBase as T;
				if (t != null)
				{
					return t;
				}
			}
			throw new InvalidOperationException("UiCamera mode " + typeof(T).Name + " is not registered.");
		}

		// Token: 0x0602603B RID: 155707 RVA: 0x00AAAF38 File Offset: 0x00AA9138
		public T GetComponent<[Nullable(0)] T>() where T : UiCameraComponent
		{
			return this.CurrentModeInstance.GetComponent<T>();
		}

		// Token: 0x0602603C RID: 155708 RVA: 0x00AAAF45 File Offset: 0x00AA9145
		[NullableContext(0)]
		[return: Nullable(2)]
		public T GetUiCameraComponent<T>() where T : UiCameraComponent
		{
			return this.CurrentModeInstance.TryGetComponent<T>();
		}

		// Token: 0x0602603D RID: 155709 RVA: 0x00AAAF52 File Offset: 0x00AA9152
		[NullableContext(2)]
		public BP_CineCamera_C GetCameraActor()
		{
			return this.CameraActor;
		}

		// Token: 0x0602603E RID: 155710 RVA: 0x00AAAF5C File Offset: 0x00AA915C
		public bool RefreshCameraActor()
		{
			WidgetCamera widgetCamera = CameraController.Instance.MainModel.WidgetCamera;
			WidgetCameraDisplayComponent widgetCameraDisplayComponent = ((widgetCamera != null) ? widgetCamera.DisplayComponent : null) ?? ((widgetCamera != null) ? widgetCamera.GetComponent<WidgetCameraDisplayComponent>() : null);
			if (widgetCameraDisplayComponent == null)
			{
				this.CameraActor = null;
				this.CineCameraComponent = null;
				return false;
			}
			if (!widgetCameraDisplayComponent.RefreshCineCamera())
			{
				this.CameraActor = null;
				this.CineCameraComponent = null;
				return false;
			}
			BP_CineCamera_C cineCamera = widgetCameraDisplayComponent.CineCamera;
			if (cineCamera == null || !cineCamera.IsValid())
			{
				this.CameraActor = null;
				this.CineCameraComponent = null;
				return false;
			}
			UCineCameraComponent cineCameraComponent = cineCamera.GetCineCameraComponent();
			this.CameraActor = cineCamera;
			this.CineCameraComponent = cineCameraComponent;
			cineCamera.SetTickableWhenPaused(true);
			if (cineCameraComponent != null)
			{
				cineCameraComponent.SetTickableWhenPaused(true);
			}
			return true;
		}

		// Token: 0x0602603F RID: 155711 RVA: 0x00AAB010 File Offset: 0x00AA9210
		[NullableContext(2)]
		public void Enter(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f, Action callback = null)
		{
			CameraController.Instance.EnterCameraMode(ECustomCameraMode.Widget, blendTime, blendFunction, blendExp, callback, false, "MainCamera", null);
			this.IsEntered = true;
		}

		// Token: 0x06026040 RID: 155712 RVA: 0x00AAB03C File Offset: 0x00AA923C
		public void Exit(float blendTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, float blendExp = 0f)
		{
			if (CameraModel.Instance.MainModel.LogicHideHeadEnabled)
			{
				blendTime = 0f;
				blendFunction = EViewTargetBlendFunction.VTBlend_Linear;
				blendExp = 0f;
			}
			CameraController.Instance.ExitCameraMode(ECustomCameraMode.Widget, blendTime, blendFunction, blendExp, null, "MainCamera", null);
			this.IsEntered = false;
		}

		// Token: 0x06026041 RID: 155713 RVA: 0x00AAB088 File Offset: 0x00AA9288
		public void SetWorldLocation(FVectorDouble location)
		{
			UiCameraNormalMode uiCameraNormalMode = this.CurrentModeInstance as UiCameraNormalMode;
			if (uiCameraNormalMode != null)
			{
				uiCameraNormalMode.SetWorldLocation(location);
				return;
			}
			FHitResult fhitResult = new FHitResult();
			BP_CineCamera_C cameraActor = this.CameraActor;
			if (cameraActor == null)
			{
				return;
			}
			cameraActor.D_K2_SetActorLocation(location, false, ref fhitResult, false);
		}

		// Token: 0x06026042 RID: 155714 RVA: 0x00AAB0C8 File Offset: 0x00AA92C8
		public void SetWorldRotation(FRotator rotation)
		{
			UiCameraNormalMode uiCameraNormalMode = this.CurrentModeInstance as UiCameraNormalMode;
			if (uiCameraNormalMode != null)
			{
				uiCameraNormalMode.SetWorldRotation(rotation);
				return;
			}
			BP_CineCamera_C cameraActor = this.CameraActor;
			if (cameraActor == null)
			{
				return;
			}
			cameraActor.K2_SetActorRotation(rotation, false);
		}

		// Token: 0x06026043 RID: 155715 RVA: 0x00AAB0FF File Offset: 0x00AA92FF
		public void Apply(UiCameraHandleData data)
		{
			if (!data.ShouldSkipApply())
			{
				this.CurrentModeInstance.Apply(data);
			}
		}

		// Token: 0x06026044 RID: 155716 RVA: 0x00AAB115 File Offset: 0x00AA9315
		public void Tick(float deltaTime)
		{
			this.CurrentModeInstance.Tick(deltaTime);
		}

		// Token: 0x06026045 RID: 155717 RVA: 0x00AAB124 File Offset: 0x00AA9324
		public void Clear()
		{
			if (this.IsEntered)
			{
				this.Exit(0f, EViewTargetBlendFunction.VTBlend_Linear, 0f);
			}
			foreach (UiCameraModeBase uiCameraModeBase in this.Modes.Values)
			{
				uiCameraModeBase.Clear();
			}
			this.Modes.Clear();
			this.CameraActor = null;
			this.CineCameraComponent = null;
			this.IsEntered = false;
		}

		// Token: 0x04014E30 RID: 85552
		private readonly Dictionary<EUiCameraMode, UiCameraModeBase> Modes = new Dictionary<EUiCameraMode, UiCameraModeBase>();
	}
}
