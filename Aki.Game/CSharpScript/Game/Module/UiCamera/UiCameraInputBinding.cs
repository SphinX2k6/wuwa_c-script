using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x020039B5 RID: 14773
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraInputBinding
	{
		// Token: 0x06026097 RID: 155799 RVA: 0x00AAC2BC File Offset: 0x00AAA4BC
		public void Configure(UiCameraInputBindingData data)
		{
			object obj;
			if (this.IsBound)
			{
				UiCameraInputBindingData data2 = this.Data;
				obj = (((data2 != null) ? data2.DragComponent : null) != data.DragComponent);
			}
			else
			{
				obj = 0;
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				this.Unbind();
			}
			this.Data = data;
			this.CameraInputComponent = UiCameraModel.Instance.GetOrCreateCamera().GetMode<UiCameraNormalMode>().GetComponent<UiCameraInputComponent>();
			if (obj2 != null)
			{
				this.Bind();
				return;
			}
			if (this.IsBound)
			{
				this.CameraInputComponent.Bind(this, data.CameraSettingConfig, data.CameraOffsetConfig, data.SourceLocation);
			}
		}

		// Token: 0x06026098 RID: 155800 RVA: 0x00AAC34C File Offset: 0x00AAA54C
		public void Bind()
		{
			if (this.IsBound || this.Data == null || this.CameraInputComponent == null)
			{
				return;
			}
			this.IsBound = true;
			this.CameraInputComponent.Bind(this, this.Data.CameraSettingConfig, this.Data.CameraOffsetConfig, this.Data.SourceLocation);
			UUIDraggableComponent dragComponent = this.Data.DragComponent;
			dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDrag));
			dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDrag));
			dragComponent.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScroll));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnGamepadLookUp));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnGamepadTurn));
			EventSystem.Instance.Add<string, float>(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnGamepadZoom));
			EventSystem.Instance.Add(EEventName.NavigationTriggerRoleReset, new Action(this.OnGamepadReset));
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x06026099 RID: 155801 RVA: 0x00AAC49C File Offset: 0x00AAA69C
		public void Unbind()
		{
			if (!this.IsBound)
			{
				return;
			}
			this.IsBound = false;
			this.CurrentDragPosition = null;
			UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
			if (cameraInputComponent != null)
			{
				cameraInputComponent.Unbind(this);
			}
			if (this.Data != null)
			{
				UUIDraggableComponent dragComponent = this.Data.DragComponent;
				dragComponent.OnPointerBeginDragCallBack.Unbind();
				dragComponent.OnPointerDragCallBack.Unbind();
				dragComponent.OnPointerEndDragCallBack.Unbind();
				dragComponent.OnPointerScrollCallBack.Unbind();
			}
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnGamepadLookUp));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnGamepadTurn));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleZoom, new Action<string, float>(this.OnGamepadZoom));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleReset, new Action(this.OnGamepadReset));
			InputDistributeController.Instance.UnBindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0602609A RID: 155802 RVA: 0x00AAC5A5 File Offset: 0x00AAA7A5
		private void OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x0602609B RID: 155803 RVA: 0x00AAC5B8 File Offset: 0x00AAA7B8
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1 || InputSettings.Instance.IsInputKeyDown("RightMouseButton"))
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
			UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
			if (cameraInputComponent != null)
			{
				cameraInputComponent.AddYawInput(this, this.CurrentDragPosition.Value.X - currentDragPosition.Value.X);
			}
			UiCameraInputComponent cameraInputComponent2 = this.CameraInputComponent;
			if (cameraInputComponent2 == null)
			{
				return;
			}
			cameraInputComponent2.AddPitchInput(this, this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y);
		}

		// Token: 0x0602609C RID: 155804 RVA: 0x00AAC66F File Offset: 0x00AAA86F
		private void OnPointerEndDrag(ULGUIPointerEventData eventData)
		{
			this.CurrentDragPosition = null;
		}

		// Token: 0x0602609D RID: 155805 RVA: 0x00AAC67D File Offset: 0x00AAA87D
		private void OnPointerScroll(ULGUIPointerEventData eventData)
		{
			UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
			if (cameraInputComponent == null)
			{
				return;
			}
			cameraInputComponent.AddZoomInput(this, -eventData.scrollAxisValue);
		}

		// Token: 0x0602609E RID: 155806 RVA: 0x00AAC697 File Offset: 0x00AAA897
		private void OnGamepadLookUp(float value)
		{
			if (value != 0f && Info.Instance.IsInGamepad())
			{
				UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
				if (cameraInputComponent == null)
				{
					return;
				}
				cameraInputComponent.AddPitchInput(this, -value);
			}
		}

		// Token: 0x0602609F RID: 155807 RVA: 0x00AAC6C0 File Offset: 0x00AAA8C0
		private void OnGamepadTurn(float value)
		{
			if (value != 0f && Info.Instance.IsInGamepad())
			{
				UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
				if (cameraInputComponent == null)
				{
					return;
				}
				cameraInputComponent.AddYawInput(this, value);
			}
		}

		// Token: 0x060260A0 RID: 155808 RVA: 0x00AAC6E8 File Offset: 0x00AAA8E8
		private void OnGamepadZoom(string axisName, float value)
		{
			if (value != 0f && Info.Instance.IsInGamepad())
			{
				UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
				if (cameraInputComponent == null)
				{
					return;
				}
				cameraInputComponent.AddZoomInput(this, value);
			}
		}

		// Token: 0x060260A1 RID: 155809 RVA: 0x00AAC710 File Offset: 0x00AAA910
		private void OnGamepadReset()
		{
			UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
			if (cameraInputComponent == null || !cameraInputComponent.CanReceiveInput(this))
			{
				return;
			}
			UiCameraHandleData lastHandleData = UiCameraModel.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraModel.Instance.PushCameraHandleByHandleName(lastHandleData.GetHandleName(), true, true, "1001", false, null);
			}
		}

		// Token: 0x060260A2 RID: 155810 RVA: 0x00AAC760 File Offset: 0x00AAA960
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification identification)
		{
			if (touchData.TouchType != InputDistributeDefine.ETouchType.TouchMove || TouchFingerManager.Instance.GetTouchFingerCount() <= 1)
			{
				return;
			}
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
			UiCameraInputComponent cameraInputComponent = this.CameraInputComponent;
			if (cameraInputComponent == null)
			{
				return;
			}
			cameraInputComponent.AddZoomInput(this, -fingerExpandCloseValue);
		}

		// Token: 0x04014E5C RID: 85596
		[Nullable(2)]
		private UiCameraInputBindingData Data;

		// Token: 0x04014E5D RID: 85597
		[Nullable(2)]
		private UiCameraInputComponent CameraInputComponent;

		// Token: 0x04014E5E RID: 85598
		private FVector? CurrentDragPosition;

		// Token: 0x04014E5F RID: 85599
		private bool IsBound;
	}
}
