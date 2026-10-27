using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ProjectPuzzle
{
	// Token: 0x02006AB9 RID: 27321
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectorPuzzleView : UiTickViewBase
	{
		// Token: 0x06043E0A RID: 278026 RVA: 0x010A3A4F File Offset: 0x010A1C4F
		public ProjectorPuzzleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043E0B RID: 278027 RVA: 0x010A3A64 File Offset: 0x010A1C64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnResetButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06043E0C RID: 278028 RVA: 0x010A3B90 File Offset: 0x010A1D90
		protected override UniTask OnBeforeStartAsync()
		{
			ProjectorPuzzleView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ProjectorPuzzleView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043E0D RID: 278029 RVA: 0x010A3BD4 File Offset: 0x010A1DD4
		protected override void OnStart()
		{
			this.DragComponent = base.GetDraggable(1);
			UUIDraggableComponent dragComponent = this.DragComponent;
			object obj;
			if (dragComponent == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = dragComponent.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null);
			}
			this.DragItem = (obj as UUIItem);
			this.IsInputEnable = true;
			this.AddInputEventListener();
		}

		// Token: 0x06043E0E RID: 278030 RVA: 0x010A3C2E File Offset: 0x010A1E2E
		protected override void OnBeforeDestroy()
		{
			this.ClearInput();
			ProjectorPuzzleController.CloseGameplay(true, false, false);
		}

		// Token: 0x06043E0F RID: 278031 RVA: 0x010A3C40 File Offset: 0x010A1E40
		protected override void OnTick(float delta)
		{
			float rollInput = this.IsInputEnable ? (Info.Instance.IsInGamepad() ? this.GamepadRollValue : this.RollInputValue) : 0f;
			ProjectorPuzzleController.Update(delta, rollInput);
			this.UpdateGamepadInput(delta);
		}

		// Token: 0x06043E10 RID: 278032 RVA: 0x010A3C88 File Offset: 0x010A1E88
		private void AddInputEventListener()
		{
			UUIDraggableComponent dragComponent = this.DragComponent;
			if (dragComponent != null && dragComponent.IsValid())
			{
				dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBegin));
				dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
				dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEnd));
				dragComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBegin));
				dragComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEnd));
				dragComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEnd));
			}
			UUIButtonComponent button = base.GetButton(4);
			if (button != null && button.IsValid())
			{
				button.OnPointDownCallBack.Bind(new Action(this.OnRollUpButtonPress));
				button.OnPointCancelCallBack.Bind(new Action(this.OnRollUpButtonRelease));
				button.OnPointUpCallBack.Bind(new Action(this.OnRollUpButtonRelease));
			}
			UUIButtonComponent button2 = base.GetButton(5);
			if (button2 != null && button2.IsValid())
			{
				button2.OnPointDownCallBack.Bind(new Action(this.OnRollDownButtonPress));
				button2.OnPointCancelCallBack.Bind(new Action(this.OnRollDownButtonRelease));
				button2.OnPointUpCallBack.Bind(new Action(this.OnRollDownButtonRelease));
			}
			this.SetGamepadInputEnable(Info.Instance.IsInGamepad());
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06043E11 RID: 278033 RVA: 0x010A3E14 File Offset: 0x010A2014
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
			UUIButtonComponent button = base.GetButton(4);
			if (button != null && button.IsValid())
			{
				button.OnPointDownCallBack.Unbind();
				button.OnPointCancelCallBack.Unbind();
				button.OnPointUpCallBack.Unbind();
			}
			UUIButtonComponent button2 = base.GetButton(5);
			if (button2 != null && button2.IsValid())
			{
				button2.OnPointDownCallBack.Unbind();
				button2.OnPointCancelCallBack.Unbind();
				button2.OnPointUpCallBack.Unbind();
			}
			this.SetGamepadInputEnable(false);
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x06043E12 RID: 278034 RVA: 0x010A3F00 File Offset: 0x010A2100
		private void ClearInput()
		{
			this.RemoveInputEventListener();
			this.IsInputEnable = false;
			this.EndInput();
		}

		// Token: 0x06043E13 RID: 278035 RVA: 0x010A3F18 File Offset: 0x010A2118
		private void EndInput()
		{
			this.IsPointerInput = false;
			this.LookUpValue = 0f;
			this.TurnValue = 0f;
			this.RollInputValue = 0f;
			this.GamepadRollValue = 0f;
			this.IsRollUpPressed = false;
			this.IsRollDownPressed = false;
			ProjectorPuzzleController.EndInput();
		}

		// Token: 0x06043E14 RID: 278036 RVA: 0x010A3F6C File Offset: 0x010A216C
		private bool TryGetDragSize(Vector2D outValue)
		{
			UUIItem dragItem = this.DragItem;
			if (dragItem == null || !dragItem.IsValid())
			{
				outValue.Reset();
				return false;
			}
			float width = dragItem.GetWidth();
			float height = dragItem.GetHeight();
			if (width <= 0f || height <= 0f)
			{
				outValue.Reset();
				return false;
			}
			outValue.X = (double)width;
			outValue.Y = (double)height;
			return true;
		}

		// Token: 0x06043E15 RID: 278037 RVA: 0x010A3FCC File Offset: 0x010A21CC
		[NullableContext(2)]
		private void OnPointerBegin(ULGUIPointerEventData eventData)
		{
			if (eventData == null || !this.IsInputEnable)
			{
				return;
			}
			if (!this.TryGetDragSize(this.DragSize))
			{
				return;
			}
			this.IsPointerInput = true;
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			ProjectorPuzzleController.BeginInput(localPointInPlane.X, localPointInPlane.Y, this.DragSize.X, this.DragSize.Y);
		}

		// Token: 0x06043E16 RID: 278038 RVA: 0x010A402C File Offset: 0x010A222C
		[NullableContext(2)]
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null || !this.IsInputEnable)
			{
				return;
			}
			if (!this.TryGetDragSize(this.DragSize))
			{
				return;
			}
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			ProjectorPuzzleController.UpdateInput(localPointInPlane.X, localPointInPlane.Y, this.DragSize.X, this.DragSize.Y);
		}

		// Token: 0x06043E17 RID: 278039 RVA: 0x010A4082 File Offset: 0x010A2282
		[NullableContext(2)]
		private void OnPointerEnd(ULGUIPointerEventData eventData)
		{
			if (!this.IsInputEnable)
			{
				return;
			}
			this.IsPointerInput = false;
			ProjectorPuzzleController.EndInput();
		}

		// Token: 0x06043E18 RID: 278040 RVA: 0x010A4099 File Offset: 0x010A2299
		private void OnResetButtonClick()
		{
			if (!this.IsInputEnable)
			{
				return;
			}
			this.EndInput();
			ProjectorPuzzleController.ResetGameplay();
		}

		// Token: 0x06043E19 RID: 278041 RVA: 0x010A40AF File Offset: 0x010A22AF
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.EndInput();
			this.SetGamepadInputEnable(Info.Instance.IsInGamepad());
		}

		// Token: 0x06043E1A RID: 278042 RVA: 0x010A40C7 File Offset: 0x010A22C7
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06043E1B RID: 278043 RVA: 0x010A40D0 File Offset: 0x010A22D0
		private void SetGamepadInputEnable(bool enable)
		{
			if (enable)
			{
				if (!this.HasBindGamepadInput)
				{
					InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiLookUp));
					InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiTurn));
					InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiMoveRight));
					this.HasBindGamepadInput = true;
				}
				return;
			}
			if (this.HasBindGamepadInput)
			{
				InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiLookUp));
				InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiTurn));
				InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiMoveRight));
				this.HasBindGamepadInput = false;
			}
		}

		// Token: 0x06043E1C RID: 278044 RVA: 0x010A41A1 File Offset: 0x010A23A1
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
			this.LookUpValue = value;
		}

		// Token: 0x06043E1D RID: 278045 RVA: 0x010A41C1 File Offset: 0x010A23C1
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
			this.TurnValue = value;
		}

		// Token: 0x06043E1E RID: 278046 RVA: 0x010A41E1 File Offset: 0x010A23E1
		private void OnInputUiMoveRight(string axisName, float value, InputIdentification inputIdentification)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (value == this.GamepadRollValue)
			{
				return;
			}
			this.GamepadRollValue = value;
		}

		// Token: 0x06043E1F RID: 278047 RVA: 0x010A4201 File Offset: 0x010A2401
		private void OnRollUpButtonPress()
		{
			if (!this.IsInputEnable || Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.IsRollUpPressed)
			{
				return;
			}
			this.IsRollUpPressed = true;
			this.UpdateRollInputValue();
		}

		// Token: 0x06043E20 RID: 278048 RVA: 0x010A422E File Offset: 0x010A242E
		private void OnRollUpButtonRelease()
		{
			if (!this.IsRollUpPressed)
			{
				return;
			}
			this.IsRollUpPressed = false;
			this.UpdateRollInputValue();
		}

		// Token: 0x06043E21 RID: 278049 RVA: 0x010A4246 File Offset: 0x010A2446
		private void OnRollDownButtonPress()
		{
			if (!this.IsInputEnable || Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.IsRollDownPressed)
			{
				return;
			}
			this.IsRollDownPressed = true;
			this.UpdateRollInputValue();
		}

		// Token: 0x06043E22 RID: 278050 RVA: 0x010A4273 File Offset: 0x010A2473
		private void OnRollDownButtonRelease()
		{
			if (!this.IsRollDownPressed)
			{
				return;
			}
			this.IsRollDownPressed = false;
			this.UpdateRollInputValue();
		}

		// Token: 0x06043E23 RID: 278051 RVA: 0x010A428B File Offset: 0x010A248B
		private void UpdateRollInputValue()
		{
			this.RollInputValue = (float)((this.IsRollUpPressed ? -1 : 0) + ((this.IsRollDownPressed > false) ? 1 : 0));
		}

		// Token: 0x06043E24 RID: 278052 RVA: 0x010A42AC File Offset: 0x010A24AC
		private void UpdateGamepadInput(float delta)
		{
			if (!this.IsInputEnable || this.IsPointerInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			float turnValue = this.TurnValue;
			float lookUpValue = this.LookUpValue;
			if ((double)Math.Abs(turnValue) <= 1E-08 && (double)Math.Abs(lookUpValue) <= 1E-08)
			{
				return;
			}
			ProjectorPuzzleController.UpdateStickRotation(turnValue, lookUpValue, delta);
		}

		// Token: 0x040237AA RID: 145322
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x040237AB RID: 145323
		[Nullable(2)]
		private UUIItem DragItem;

		// Token: 0x040237AC RID: 145324
		private bool IsInputEnable;

		// Token: 0x040237AD RID: 145325
		private bool IsPointerInput;

		// Token: 0x040237AE RID: 145326
		private bool HasBindGamepadInput;

		// Token: 0x040237AF RID: 145327
		private float LookUpValue;

		// Token: 0x040237B0 RID: 145328
		private float TurnValue;

		// Token: 0x040237B1 RID: 145329
		private float RollInputValue;

		// Token: 0x040237B2 RID: 145330
		private float GamepadRollValue;

		// Token: 0x040237B3 RID: 145331
		private bool IsRollUpPressed;

		// Token: 0x040237B4 RID: 145332
		private bool IsRollDownPressed;

		// Token: 0x040237B5 RID: 145333
		private readonly Vector2D DragSize = Vector2D.Create();

		// Token: 0x040237B6 RID: 145334
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;
	}
}
