using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View
{
	// Token: 0x02005F65 RID: 24421
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectViewBase : UiTickViewBase
	{
		// Token: 0x0603AB74 RID: 240500 RVA: 0x01099FB9 File Offset: 0x010981B9
		protected ItemInspectViewBase(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AB75 RID: 240501 RVA: 0x01099FD8 File Offset: 0x010981D8
		public void ExecuteModifyTipText(string text, Action onFinish)
		{
			onFinish();
		}

		// Token: 0x0603AB76 RID: 240502 RVA: 0x01099FE0 File Offset: 0x010981E0
		public virtual void ExecuteTriggerDialogues(ITriggerDialogues @params, Action onFinish)
		{
			onFinish();
		}

		// Token: 0x0603AB77 RID: 240503 RVA: 0x01099FE8 File Offset: 0x010981E8
		public virtual void ExecuteTriggerVoiceDialogues(ITriggerVoiceDialogues @params, Action onFinish)
		{
			onFinish();
		}

		// Token: 0x0603AB78 RID: 240504 RVA: 0x01099FF0 File Offset: 0x010981F0
		protected override void OnTick(float delta)
		{
			ItemInspectController.Instance.UpdateItemInspect(delta);
		}

		// Token: 0x0603AB79 RID: 240505 RVA: 0x01099FFD File Offset: 0x010981FD
		protected void InitDrag(UUIDraggableComponent dragComponent)
		{
			this.DragComponent = dragComponent;
			this.AddInputEventListener();
			this.IsInputEnable = true;
			ItemInspectModel.Instance.OnDragInteractSuccess = new Action<int>(this.OnDragSuccessCallback);
		}

		// Token: 0x0603AB7A RID: 240506 RVA: 0x0109A02C File Offset: 0x0109822C
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

		// Token: 0x0603AB7B RID: 240507 RVA: 0x0109A086 File Offset: 0x01098286
		protected void SetInputEnable(bool enable)
		{
			this.IsInputEnable = enable;
			if (!enable)
			{
				this.InputEnd();
			}
		}

		// Token: 0x0603AB7C RID: 240508 RVA: 0x0109A098 File Offset: 0x01098298
		protected bool IsInteractingItem()
		{
			return this.IsInputBegin;
		}

		// Token: 0x0603AB7D RID: 240509 RVA: 0x0109A0A0 File Offset: 0x010982A0
		protected virtual void HandleDragInteractSuccess(int tagId)
		{
			ItemInspectController.Instance.InteractPoint(tagId, delegate
			{
			});
		}

		// Token: 0x0603AB7E RID: 240510 RVA: 0x0109A0CC File Offset: 0x010982CC
		private void OnDragSuccessCallback(int tagId)
		{
			this.HandleDragInteractSuccess(tagId);
		}

		// Token: 0x0603AB7F RID: 240511 RVA: 0x0109A0D8 File Offset: 0x010982D8
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

		// Token: 0x0603AB80 RID: 240512 RVA: 0x0109A1B4 File Offset: 0x010983B4
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

		// Token: 0x0603AB81 RID: 240513 RVA: 0x0109A238 File Offset: 0x01098438
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

		// Token: 0x0603AB82 RID: 240514 RVA: 0x0109A28C File Offset: 0x0109848C
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

		// Token: 0x0603AB83 RID: 240515 RVA: 0x0109A30C File Offset: 0x0109850C
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

		// Token: 0x0603AB84 RID: 240516 RVA: 0x0109A3C8 File Offset: 0x010985C8
		[NullableContext(2)]
		private void OnPointerEndCallBack(ULGUIPointerEventData eventData)
		{
			if (ItemInspectController.Instance.IsCurrentStageDragInteraction() && !this.IsInputBegin)
			{
				return;
			}
			this.InputEnd();
		}

		// Token: 0x0603AB85 RID: 240517 RVA: 0x0109A3E5 File Offset: 0x010985E5
		private void OnInputControllerChange(EInputControllerType _, EInputControllerType __)
		{
			this.InputEnd();
			this.SetGamepadInputEnable(Info.Instance.IsInGamepad());
		}

		// Token: 0x0603AB86 RID: 240518 RVA: 0x0109A400 File Offset: 0x01098600
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

		// Token: 0x0603AB87 RID: 240519 RVA: 0x0109A507 File Offset: 0x01098707
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

		// Token: 0x0603AB88 RID: 240520 RVA: 0x0109A52E File Offset: 0x0109872E
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

		// Token: 0x0603AB89 RID: 240521 RVA: 0x0109A555 File Offset: 0x01098755
		private void OnInputUiMoveRight(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.DragStickInput.X = (double)value;
			this.ForwardDragStickInput();
		}

		// Token: 0x0603AB8A RID: 240522 RVA: 0x0109A577 File Offset: 0x01098777
		private void OnInputUiMoveForward(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.DragStickInput.Y = (double)value;
			this.ForwardDragStickInput();
		}

		// Token: 0x0603AB8B RID: 240523 RVA: 0x0109A59C File Offset: 0x0109879C
		private void ForwardDragStickInput()
		{
			if (this.IsInputEnable && ItemInspectController.Instance.IsCurrentStageDragInteraction())
			{
				ItemInspectController.Instance.ReceiveDragGamepadInput(this.DragStickInput.X, this.DragStickInput.Y);
				return;
			}
			ItemInspectController.Instance.ReceiveDragGamepadInput(0.0, 0.0);
		}

		// Token: 0x0603AB8C RID: 240524 RVA: 0x0109A600 File Offset: 0x01098800
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

		// Token: 0x0603AB8D RID: 240525 RVA: 0x0109A668 File Offset: 0x01098868
		private void ReceiveInput(Vector2D inputDirect, bool isGamePad)
		{
			if (this.IsInputEnable)
			{
				this.IsInputBegin = true;
				ItemInspectController.Instance.ReceiveRotateInput(inputDirect, isGamePad);
			}
		}

		// Token: 0x0603AB8E RID: 240526 RVA: 0x0109A685 File Offset: 0x01098885
		private void InputEnd()
		{
			this.IsInputBegin = false;
			ItemInspectController.Instance.ResetRotateInput();
			ItemInspectController.Instance.ReceiveDragGamepadInput(0.0, 0.0);
			ItemInspectController.Instance.EndDragInteraction();
		}

		// Token: 0x0401EDD9 RID: 126425
		private readonly Vector2D TempInput = Vector2D.Create();

		// Token: 0x0401EDDA RID: 126426
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x0401EDDB RID: 126427
		private bool IsInputEnable;

		// Token: 0x0401EDDC RID: 126428
		private bool IsInputBegin;

		// Token: 0x0401EDDD RID: 126429
		private bool HasBindGamepadInput;

		// Token: 0x0401EDDE RID: 126430
		private float LookUpValue;

		// Token: 0x0401EDDF RID: 126431
		private float TurnValue;

		// Token: 0x0401EDE0 RID: 126432
		private readonly Vector2D DragStickInput = Vector2D.Create();
	}
}
