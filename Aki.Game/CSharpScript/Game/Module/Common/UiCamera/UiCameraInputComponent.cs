using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiRoleCamera.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.UiCamera
{
	// Token: 0x02005B4A RID: 23370
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraInputComponent
	{
		// Token: 0x0603B29D RID: 242333 RVA: 0x00E1B3A0 File Offset: 0x00E195A0
		public void InitData(IUiCameraInputComponentData data)
		{
			if (this.ComponentState == EComponentState.None || this.ComponentState == EComponentState.End)
			{
				this.ComponentState = EComponentState.InitData;
				this.Data = data;
				this.OnInitData();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[UiCameraInputComponent] InitData调用异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentState", this.ComponentState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603B29E RID: 242334 RVA: 0x00E1B404 File Offset: 0x00E19604
		public void UpdateData(IUiCameraInputComponentData data)
		{
			if (this.ComponentState == EComponentState.Start || this.ComponentState == EComponentState.DeActivated)
			{
				this.Data = data;
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.WDX;
			string message = "[UiCameraInputComponent] UpdateData调用异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentState", this.ComponentState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603B29F RID: 242335 RVA: 0x00E1B45C File Offset: 0x00E1965C
		public void Start()
		{
			if (this.ComponentState == EComponentState.InitData || this.ComponentState == EComponentState.End)
			{
				this.ComponentState = EComponentState.Start;
				this.OnStart();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[UiCameraInputComponent] Start调用异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentState", this.ComponentState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603B2A0 RID: 242336 RVA: 0x00E1B4BC File Offset: 0x00E196BC
		public void Activate()
		{
			if (this.ComponentState != EComponentState.Start && this.ComponentState != EComponentState.DeActivated)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCommon;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "[UiCameraInputComponent] Activate调用异常";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentState", this.ComponentState);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (UiCameraAnimationManager.Instance.IsPlayingAnimation())
			{
				Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.LZK, "[UiCameraInputComponent] 在相机动画期间不应该激活相机输入组件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.ComponentState = EComponentState.Activated;
			this.OnActivate();
		}

		// Token: 0x0603B2A1 RID: 242337 RVA: 0x00E1B544 File Offset: 0x00E19744
		public void DeActivate()
		{
			if (this.ComponentState == EComponentState.Activated)
			{
				this.ComponentState = EComponentState.DeActivated;
				this.OnDeActivate();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[UiCameraInputComponent] DeActivate调用异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentState", this.ComponentState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603B2A2 RID: 242338 RVA: 0x00E1B59C File Offset: 0x00E1979C
		public void End()
		{
			if (this.ComponentState == EComponentState.Activated)
			{
				this.DeActivate();
			}
			if (this.ComponentState == EComponentState.Start || this.ComponentState == EComponentState.DeActivated)
			{
				this.ComponentState = EComponentState.End;
				this.OnEnd();
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCommon;
			ELogAuthor author = ELogAuthor.LZK;
			string message = "[UiCameraInputComponent] End调用异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ComponentState", this.ComponentState);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603B2A3 RID: 242339 RVA: 0x00E1B60C File Offset: 0x00E1980C
		protected void OnInitData()
		{
			UiCamera uiCamera = UiCameraManager.Get();
			this.UiCameraControlRotationComponent = (uiCamera.AddUiCameraComponent(typeof(UiCameraControlRotationComponent), false) as UiCameraControlRotationComponent);
		}

		// Token: 0x0603B2A4 RID: 242340 RVA: 0x00E1B63B File Offset: 0x00E1983B
		protected void OnStart()
		{
			this.AddCameraEventListener();
		}

		// Token: 0x0603B2A5 RID: 242341 RVA: 0x00E1B643 File Offset: 0x00E19843
		protected void AddCameraEventListener()
		{
			EventSystem.Instance.Add<UiCameraHandleData, UiCameraHandleData, string>(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
			EventSystem.Instance.Add(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		}

		// Token: 0x0603B2A6 RID: 242342 RVA: 0x00E1B67D File Offset: 0x00E1987D
		protected void OnActivate()
		{
			this.ActiveCameraControlRotationComponent();
			UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
			if (uiCameraControlRotationComponent != null)
			{
				uiCameraControlRotationComponent.Activate();
			}
			this.AddInputEventListener();
		}

		// Token: 0x0603B2A7 RID: 242343 RVA: 0x00E1B69C File Offset: 0x00E1989C
		protected void AddInputEventListener()
		{
			UUIDraggableComponent dragComponent = this.Data.DragComponent;
			dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
			dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
			dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
			dragComponent.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
			EventSystem.Instance.Add<string, float>(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnInputUiZoom));
			EventSystem.Instance.Add(EEventName.NavigationTriggerRoleReset, new Action(this.OnRightStickPress));
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0603B2A8 RID: 242344 RVA: 0x00E1B79F File Offset: 0x00E1999F
		protected void OnDeActivate()
		{
			UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
			if (uiCameraControlRotationComponent != null)
			{
				uiCameraControlRotationComponent.Deactivate();
			}
			this.CurrentDragPosition = null;
			this.RemoveInputEventListener();
		}

		// Token: 0x0603B2A9 RID: 242345 RVA: 0x00E1B7C4 File Offset: 0x00E199C4
		protected void RemoveInputEventListener()
		{
			UUIDraggableComponent dragComponent = this.Data.DragComponent;
			dragComponent.OnPointerBeginDragCallBack.Unbind();
			dragComponent.OnPointerDragCallBack.Unbind();
			dragComponent.OnPointerEndDragCallBack.Unbind();
			dragComponent.OnPointerScrollCallBack.Unbind();
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnInputUiZoom));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleReset, new Action(this.OnRightStickPress));
			InputDistributeController.Instance.UnBindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0603B2AA RID: 242346 RVA: 0x00E1B897 File Offset: 0x00E19A97
		protected void RemoveCameraEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPlayCameraAnimationStart, new Action<UiCameraHandleData, UiCameraHandleData, string>(this.OnPlayCameraAnimationStart));
			EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		}

		// Token: 0x0603B2AB RID: 242347 RVA: 0x00E1B8D1 File Offset: 0x00E19AD1
		protected void OnEnd()
		{
			this.RemoveCameraEventListener();
		}

		// Token: 0x0603B2AC RID: 242348 RVA: 0x00E1B8D9 File Offset: 0x00E19AD9
		public EComponentState GetComponentState()
		{
			return this.ComponentState;
		}

		// Token: 0x0603B2AD RID: 242349 RVA: 0x00E1B8E1 File Offset: 0x00E19AE1
		public bool TryActivate()
		{
			if (UiCameraAnimationManager.Instance.IsPlayingAnimation())
			{
				return false;
			}
			this.Activate();
			return true;
		}

		// Token: 0x0603B2AE RID: 242350 RVA: 0x00E1B8F8 File Offset: 0x00E19AF8
		public bool TryDeActivate()
		{
			if (this.ComponentState != EComponentState.Activated)
			{
				return false;
			}
			this.DeActivate();
			return true;
		}

		// Token: 0x0603B2AF RID: 242351 RVA: 0x00E1B90C File Offset: 0x00E19B0C
		public void ActiveCameraControlRotationComponent()
		{
			this.UiCameraControlRotationComponent.InitDataByConfig(this.Data.CameraSettingConfig);
			this.UiCameraControlRotationComponent.SetNeedFloorReflection(true);
			SUiRoleCameraOffsetSetting? cameraOffsetConfig = this.Data.CameraOffsetConfig;
			FVector sourceLocation;
			if (cameraOffsetConfig != null)
			{
				UiCameraControlRotationComponent uiCameraControlRotationComponent = this.UiCameraControlRotationComponent;
				sourceLocation = this.Data.SourceLocation;
				uiCameraControlRotationComponent.UpdateData(sourceLocation, cameraOffsetConfig.Value.镜头浮动最大高度, cameraOffsetConfig.Value.镜头浮动最低高度, cameraOffsetConfig.Value.镜头浮动最长臂长, cameraOffsetConfig.Value.镜头浮动最短臂长);
				return;
			}
			UiCameraControlRotationComponent uiCameraControlRotationComponent2 = this.UiCameraControlRotationComponent;
			sourceLocation = this.Data.SourceLocation;
			uiCameraControlRotationComponent2.UpdateData(sourceLocation, 0f, 0f, 0f, 0f);
		}

		// Token: 0x0603B2B0 RID: 242352 RVA: 0x00E1B9D1 File Offset: 0x00E19BD1
		private void OnPlayCameraAnimationStart(UiCameraHandleData uiCameraHandleData, UiCameraHandleData cameraHandleData, string arg3)
		{
			this.TryDeActivate();
		}

		// Token: 0x0603B2B1 RID: 242353 RVA: 0x00E1B9DA File Offset: 0x00E19BDA
		private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
		{
			if (!handleData.GetUiCameraAnimationConfig().bTargetActorAsCenter)
			{
				return;
			}
			if (this.ComponentState == EComponentState.Activated)
			{
				this.DeActivate();
				this.Activate();
				return;
			}
			this.Activate();
		}

		// Token: 0x0603B2B2 RID: 242354 RVA: 0x00E1BA06 File Offset: 0x00E19C06
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x0603B2B3 RID: 242355 RVA: 0x00E1BA24 File Offset: 0x00E19C24
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput || TouchFingerManager.Instance.GetTouchFingerCount() > 1 || InputSettings.Instance.IsInputKeyDown("RightMouseButton"))
			{
				this.CurrentDragPosition = null;
				return;
			}
			FVector? currentDragPosition = this.CurrentDragPosition;
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
			if (currentDragPosition == null)
			{
				return;
			}
			float num = this.CurrentDragPosition.Value.X - currentDragPosition.Value.X;
			float num2 = this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y;
			if (num != 0f)
			{
				this.UiCameraControlRotationComponent.AddYawInput(num);
			}
			if (num2 != 0f)
			{
				this.UiCameraControlRotationComponent.AddPitchInput(num2);
			}
		}

		// Token: 0x0603B2B4 RID: 242356 RVA: 0x00E1BAEA File Offset: 0x00E19CEA
		private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.CurrentDragPosition = null;
		}

		// Token: 0x0603B2B5 RID: 242357 RVA: 0x00E1BB01 File Offset: 0x00E19D01
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (eventData.scrollAxisValue != 0f)
			{
				this.UiCameraControlRotationComponent.AddZoomInput(-eventData.scrollAxisValue);
			}
		}

		// Token: 0x0603B2B6 RID: 242358 RVA: 0x00E1BB2B File Offset: 0x00E19D2B
		private void OnInputUiLookUp(float value)
		{
			if (!this.CanCameraInput || value == 0f || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraControlRotationComponent.AddPitchInput(-value);
		}

		// Token: 0x0603B2B7 RID: 242359 RVA: 0x00E1BB57 File Offset: 0x00E19D57
		private void OnInputUiTurn(float value)
		{
			if (!this.CanCameraInput || value == 0f || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraControlRotationComponent.AddYawInput(value);
		}

		// Token: 0x0603B2B8 RID: 242360 RVA: 0x00E1BB82 File Offset: 0x00E19D82
		private void OnInputUiZoom(string axisName, float value)
		{
			if (!this.CanCameraInput || value == 0f || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.UiCameraControlRotationComponent.AddZoomInput(value);
		}

		// Token: 0x0603B2B9 RID: 242361 RVA: 0x00E1BBB0 File Offset: 0x00E19DB0
		private void OnRightStickPress()
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData.HandleName, true, true, "1001", false, null, null);
			}
		}

		// Token: 0x0603B2BA RID: 242362 RVA: 0x00E1BBF7 File Offset: 0x00E19DF7
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (touchData.TouchType == InputDistributeDefine.ETouchType.TouchMove)
			{
				this.TouchMoved();
			}
		}

		// Token: 0x0603B2BB RID: 242363 RVA: 0x00E1BC14 File Offset: 0x00E19E14
		private void TouchMoved()
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
				this.UiCameraControlRotationComponent.AddZoomInput(-fingerExpandCloseValue);
			}
		}

		// Token: 0x0401ED62 RID: 126306
		private IUiCameraInputComponentData Data;

		// Token: 0x0401ED63 RID: 126307
		private UiCameraControlRotationComponent UiCameraControlRotationComponent;

		// Token: 0x0401ED64 RID: 126308
		private FVector? CurrentDragPosition;

		// Token: 0x0401ED65 RID: 126309
		private EComponentState ComponentState;

		// Token: 0x0401ED66 RID: 126310
		public bool CanCameraInput = true;
	}
}
