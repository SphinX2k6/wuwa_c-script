using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View
{
	// Token: 0x02006DE6 RID: 28134
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectViewBase : UiTickViewBase
	{
		// Token: 0x06044A10 RID: 281104 RVA: 0x010EFD6D File Offset: 0x010EDF6D
		protected ItemInspectViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06044A11 RID: 281105 RVA: 0x010EFD8C File Offset: 0x010EDF8C
		public void ExecuteModifyTipText(string text, Action onFinish)
		{
			onFinish();
		}

		// Token: 0x06044A12 RID: 281106 RVA: 0x010EFD94 File Offset: 0x010EDF94
		public virtual void ExecuteTriggerDialogues(ITriggerDialogues @params, Action onFinish)
		{
			onFinish();
		}

		// Token: 0x06044A13 RID: 281107 RVA: 0x010EFD9C File Offset: 0x010EDF9C
		public virtual void ExecuteTriggerVoiceDialogues(ITriggerVoiceDialogues @params, Action onFinish)
		{
			onFinish();
		}

		// Token: 0x06044A14 RID: 281108 RVA: 0x010EFDA4 File Offset: 0x010EDFA4
		protected override void OnTick(float delta)
		{
			ItemInspectController.Instance.UpdateItemInspect(delta);
		}

		// Token: 0x06044A15 RID: 281109 RVA: 0x010EFDB1 File Offset: 0x010EDFB1
		protected void InitDrag(UUIDraggableComponent dragComponent)
		{
			this.DragComponent = dragComponent;
			this.AddInputEventListener();
			this.IsInputEnable = true;
			ItemInspectModel.Instance.OnDragInteractSuccess = new Action<int>(this.OnDragSuccessCallback);
		}

		// Token: 0x06044A16 RID: 281110 RVA: 0x010EFDE0 File Offset: 0x010EDFE0
		protected void ClearDrag()
		{
			this.RemoveInputEventListener();
			this.InputEnd();
			this.DragComponent = null;
			this.IsInputEnable = false;
			this.IsInputBegin = false;
			this.LookUpValue = 0f;
			this.TurnValue = 0f;
			this.DragStickInput.Reset();
			ItemInspectModel.Instance.OnDragInteractSuccess = null;
		}

		// Token: 0x06044A17 RID: 281111 RVA: 0x010EFE3A File Offset: 0x010EE03A
		protected void SetInputEnable(bool enable)
		{
			this.IsInputEnable = enable;
			if (!enable)
			{
				this.InputEnd();
			}
		}

		// Token: 0x06044A18 RID: 281112 RVA: 0x010EFE4C File Offset: 0x010EE04C
		protected bool IsInteractingItem()
		{
			return this.IsInputBegin;
		}

		// Token: 0x06044A19 RID: 281113 RVA: 0x010EFE54 File Offset: 0x010EE054
		protected virtual void HandleDragInteractSuccess(int tagId)
		{
			ItemInspectController.Instance.InteractPoint(tagId, delegate
			{
			});
		}

		// Token: 0x06044A1A RID: 281114 RVA: 0x010EFE80 File Offset: 0x010EE080
		private void OnDragSuccessCallback(int tagId)
		{
			this.HandleDragInteractSuccess(tagId);
		}

		// Token: 0x06044A1B RID: 281115 RVA: 0x010EFE8C File Offset: 0x010EE08C
		private void AddInputEventListener()
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent != null && dragComponent.IsValid())
			{
				dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginCallBack));
				dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
				dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndCallBack));
				dragComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDownCallBack));
				dragComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndCallBack));
				dragComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndCallBack));
			}
			this.SetGamepadInputEnable(Info.Instance.IsInGamepad());
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06044A1C RID: 281116 RVA: 0x010EFF68 File Offset: 0x010EE168
		private void RemoveInputEventListener()
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent != null && dragComponent.IsValid())
			{
				dragComponent.OnPointerBeginDragCallBack.Unbind();
				dragComponent.OnPointerDragCallBack.Unbind();
				dragComponent.OnPointerEndDragCallBack.Unbind();
				dragComponent.OnPointerDownCallBack.Unbind();
				dragComponent.OnPointerCancelCallBack.Unbind();
				dragComponent.OnPointerUpCallBack.Unbind();
			}
			this.SetGamepadInputEnable(false);
			EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06044A1D RID: 281117 RVA: 0x010EFFEC File Offset: 0x010EE1EC
		[NullableContext(2)]
		private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (!ItemInspectController.Instance.IsCurrentStageDragInteraction())
			{
				this.OnPointerBeginCallBack(eventData);
				return;
			}
			if (this.IsInputEnable)
			{
				FVector pointerPosition = eventData.pointerPosition;
				this.IsInputBegin = ItemInspectController.Instance.BeginDragInteraction(pointerPosition.X, pointerPosition.Y);
			}
		}

		// Token: 0x06044A1E RID: 281118 RVA: 0x010F0040 File Offset: 0x010EE240
		[NullableContext(2)]
		private void OnPointerBeginCallBack(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (ItemInspectController.Instance.IsCurrentStageDragInteraction())
			{
				return;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.TempInput.X = 0.0;
			this.TempInput.Y = 0.0;
			this.ReceiveInput(this.TempInput, false);
			this.TempInput.X = (double)localPointInPlane.X;
			this.TempInput.Y = (double)localPointInPlane.Y;
		}

		// Token: 0x06044A1F RID: 281119 RVA: 0x010F00C0 File Offset: 0x010EE2C0
		[NullableContext(2)]
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (ItemInspectController.Instance.IsCurrentStageDragInteraction())
			{
				if (this.IsInputEnable && this.IsInputBegin)
				{
					FVector pointerPosition = eventData.pointerPosition;
					ItemInspectController.Instance.UpdateDragInteractionByPointer(pointerPosition.X, pointerPosition.Y);
				}
				return;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			this.TempInput.X -= (double)localPointInPlane.X;
			this.TempInput.Y = (double)localPointInPlane.Y - this.TempInput.Y;
			this.ReceiveInput(this.TempInput, false);
			this.TempInput.X = (double)localPointInPlane.X;
			this.TempInput.Y = (double)localPointInPlane.Y;
		}

		// Token: 0x06044A20 RID: 281120 RVA: 0x010F017C File Offset: 0x010EE37C
		[NullableContext(2)]
		private void OnPointerEndCallBack(ULGUIPointerEventData eventData)
		{
			if (ItemInspectController.Instance.IsCurrentStageDragInteraction() && !this.IsInputBegin)
			{
				return;
			}
			this.InputEnd();
		}

		// Token: 0x06044A21 RID: 281121 RVA: 0x010F0199 File Offset: 0x010EE399
		private void OnInputControllerChange(EInputControllerType _, EInputControllerType __)
		{
			this.InputEnd();
			this.SetGamepadInputEnable(Info.Instance.IsInGamepad());
		}

		// Token: 0x06044A22 RID: 281122 RVA: 0x010F01B4 File Offset: 0x010EE3B4
		private void SetGamepadInputEnable(bool enable)
		{
			if (enable)
			{
				if (!this.HasBindGamepadInput)
				{
					InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
					InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
					InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
					InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
					this.HasBindGamepadInput = true;
				}
				return;
			}
			if (this.HasBindGamepadInput)
			{
				InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
				InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
				InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
				InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
				this.HasBindGamepadInput = false;
			}
		}

		// Token: 0x06044A23 RID: 281123 RVA: 0x010F02BB File Offset: 0x010EE4BB
		private void OnInputUiLookUp(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (value == this.LookUpValue)
			{
				return;
			}
			this.LookUpValue = -value;
			this.GamepadInputChange();
		}

		// Token: 0x06044A24 RID: 281124 RVA: 0x010F02E2 File Offset: 0x010EE4E2
		private void OnInputUiTurn(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (value == this.TurnValue)
			{
				return;
			}
			this.TurnValue = -value;
			this.GamepadInputChange();
		}

		// Token: 0x06044A25 RID: 281125 RVA: 0x010F0309 File Offset: 0x010EE509
		private void OnInputUiMoveRight(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.DragStickInput.X = (double)value;
			this.ForwardDragStickInput();
		}

		// Token: 0x06044A26 RID: 281126 RVA: 0x010F032B File Offset: 0x010EE52B
		private void OnInputUiMoveForward(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.DragStickInput.Y = (double)value;
			this.ForwardDragStickInput();
		}

		// Token: 0x06044A27 RID: 281127 RVA: 0x010F0350 File Offset: 0x010EE550
		private void ForwardDragStickInput()
		{
			if (this.IsInputEnable && ItemInspectController.Instance.IsCurrentStageDragInteraction())
			{
				ItemInspectController.Instance.ReceiveDragGamepadInput(this.DragStickInput.X, this.DragStickInput.Y);
				return;
			}
			ItemInspectController.Instance.ReceiveDragGamepadInput(0.0, 0.0);
		}

		// Token: 0x06044A28 RID: 281128 RVA: 0x010F03B4 File Offset: 0x010EE5B4
		private void GamepadInputChange()
		{
			if (ItemInspectController.Instance.IsCurrentStageDragInteraction())
			{
				return;
			}
			this.TempInput.X = (double)this.TurnValue;
			this.TempInput.Y = (double)this.LookUpValue;
			if (this.TempInput.IsNearlyZero(1E-08))
			{
				this.InputEnd();
				return;
			}
			this.ReceiveInput(this.TempInput, true);
		}

		// Token: 0x06044A29 RID: 281129 RVA: 0x010F041C File Offset: 0x010EE61C
		private void ReceiveInput(Vector2D inputDirect, bool isGamePad)
		{
			if (this.IsInputEnable)
			{
				this.IsInputBegin = true;
				ItemInspectController.Instance.ReceiveRotateInput(inputDirect, isGamePad);
			}
		}

		// Token: 0x06044A2A RID: 281130 RVA: 0x010F0439 File Offset: 0x010EE639
		private void InputEnd()
		{
			this.IsInputBegin = false;
			ItemInspectController.Instance.ResetRotateInput();
			ItemInspectController.Instance.ReceiveDragGamepadInput(0.0, 0.0);
			ItemInspectController.Instance.EndDragInteraction();
		}

		// Token: 0x04023B37 RID: 146231
		private readonly Vector2D TempInput = Vector2D.Create();

		// Token: 0x04023B38 RID: 146232
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x04023B39 RID: 146233
		private bool IsInputEnable;

		// Token: 0x04023B3A RID: 146234
		private bool IsInputBegin;

		// Token: 0x04023B3B RID: 146235
		private bool HasBindGamepadInput;

		// Token: 0x04023B3C RID: 146236
		private float LookUpValue;

		// Token: 0x04023B3D RID: 146237
		private float TurnValue;

		// Token: 0x04023B3E RID: 146238
		private readonly Vector2D DragStickInput = Vector2D.Create();
	}
}
