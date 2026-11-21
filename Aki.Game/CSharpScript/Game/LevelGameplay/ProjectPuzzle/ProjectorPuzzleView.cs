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
	// Token: 0x02005C16 RID: 23574
	[NullableContext(1)]
	[Nullable(0)]
	public class ProjectorPuzzleView : UiTickViewBase
	{
		// Token: 0x06039E64 RID: 237156 RVA: 0x010480DB File Offset: 0x010462DB
		public ProjectorPuzzleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039E65 RID: 237157 RVA: 0x010480F0 File Offset: 0x010462F0
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

		// Token: 0x06039E66 RID: 237158 RVA: 0x0104821C File Offset: 0x0104641C
		protected override UniTask OnBeforeStartAsync()
		{
			ProjectorPuzzleView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ProjectorPuzzleView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E67 RID: 237159 RVA: 0x01048260 File Offset: 0x01046460
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

		// Token: 0x06039E68 RID: 237160 RVA: 0x010482BA File Offset: 0x010464BA
		protected override void OnBeforeDestroy()
		{
			this.ClearInput();
			ProjectorPuzzleController.CloseGameplay(true, false, false);
		}

		// Token: 0x06039E69 RID: 237161 RVA: 0x010482CC File Offset: 0x010464CC
		protected override void OnTick(float delta)
		{
			float rollInput = this.IsInputEnable ? (Info.Instance.IsInGamepad() ? this.GamepadRollValue : this.RollInputValue) : 0f;
			ProjectorPuzzleController.Update(delta, rollInput);
			this.UpdateGamepadInput(delta);
		}

		// Token: 0x06039E6A RID: 237162 RVA: 0x01048314 File Offset: 0x01046514
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

		// Token: 0x06039E6B RID: 237163 RVA: 0x010484A0 File Offset: 0x010466A0
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

		// Token: 0x06039E6C RID: 237164 RVA: 0x0104858C File Offset: 0x0104678C
		private void ClearInput()
		{
			this.RemoveInputEventListener();
			this.IsInputEnable = false;
			this.EndInput();
		}

		// Token: 0x06039E6D RID: 237165 RVA: 0x010485A4 File Offset: 0x010467A4
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

		// Token: 0x06039E6E RID: 237166 RVA: 0x010485F8 File Offset: 0x010467F8
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

		// Token: 0x06039E6F RID: 237167 RVA: 0x01048658 File Offset: 0x01046858
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

		// Token: 0x06039E70 RID: 237168 RVA: 0x010486B8 File Offset: 0x010468B8
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

		// Token: 0x06039E71 RID: 237169 RVA: 0x0104870E File Offset: 0x0104690E
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

		// Token: 0x06039E72 RID: 237170 RVA: 0x01048725 File Offset: 0x01046925
		private void OnResetButtonClick()
		{
			if (!this.IsInputEnable)
			{
				return;
			}
			this.EndInput();
			ProjectorPuzzleController.ResetGameplay();
		}

		// Token: 0x06039E73 RID: 237171 RVA: 0x0104873B File Offset: 0x0104693B
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.EndInput();
			this.SetGamepadInputEnable(Info.Instance.IsInGamepad());
		}

		// Token: 0x06039E74 RID: 237172 RVA: 0x01048753 File Offset: 0x01046953
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06039E75 RID: 237173 RVA: 0x0104875C File Offset: 0x0104695C
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

		// Token: 0x06039E76 RID: 237174 RVA: 0x0104882D File Offset: 0x01046A2D
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

		// Token: 0x06039E77 RID: 237175 RVA: 0x0104884D File Offset: 0x01046A4D
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

		// Token: 0x06039E78 RID: 237176 RVA: 0x0104886D File Offset: 0x01046A6D
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

		// Token: 0x06039E79 RID: 237177 RVA: 0x0104888D File Offset: 0x01046A8D
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

		// Token: 0x06039E7A RID: 237178 RVA: 0x010488BA File Offset: 0x01046ABA
		private void OnRollUpButtonRelease()
		{
			if (!this.IsRollUpPressed)
			{
				return;
			}
			this.IsRollUpPressed = false;
			this.UpdateRollInputValue();
		}

		// Token: 0x06039E7B RID: 237179 RVA: 0x010488D2 File Offset: 0x01046AD2
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

		// Token: 0x06039E7C RID: 237180 RVA: 0x010488FF File Offset: 0x01046AFF
		private void OnRollDownButtonRelease()
		{
			if (!this.IsRollDownPressed)
			{
				return;
			}
			this.IsRollDownPressed = false;
			this.UpdateRollInputValue();
		}

		// Token: 0x06039E7D RID: 237181 RVA: 0x01048917 File Offset: 0x01046B17
		private void UpdateRollInputValue()
		{
			this.RollInputValue = (float)((this.IsRollUpPressed ? -1 : 0) + ((this.IsRollDownPressed > false) ? 1 : 0));
		}

		// Token: 0x06039E7E RID: 237182 RVA: 0x01048938 File Offset: 0x01046B38
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

		// Token: 0x0401E99C RID: 125340
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x0401E99D RID: 125341
		[Nullable(2)]
		private UUIItem DragItem;

		// Token: 0x0401E99E RID: 125342
		private bool IsInputEnable;

		// Token: 0x0401E99F RID: 125343
		private bool IsPointerInput;

		// Token: 0x0401E9A0 RID: 125344
		private bool HasBindGamepadInput;

		// Token: 0x0401E9A1 RID: 125345
		private float LookUpValue;

		// Token: 0x0401E9A2 RID: 125346
		private float TurnValue;

		// Token: 0x0401E9A3 RID: 125347
		private float RollInputValue;

		// Token: 0x0401E9A4 RID: 125348
		private float GamepadRollValue;

		// Token: 0x0401E9A5 RID: 125349
		private bool IsRollUpPressed;

		// Token: 0x0401E9A6 RID: 125350
		private bool IsRollDownPressed;

		// Token: 0x0401E9A7 RID: 125351
		private readonly Vector2D DragSize = Vector2D.Create();

		// Token: 0x0401E9A8 RID: 125352
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;
	}
}
