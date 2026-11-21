using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004128 RID: 16680
	[NullableContext(1)]
	[Nullable(0)]
	public class DragInteractComponent
	{
		// Token: 0x170054D2 RID: 21714
		// (get) Token: 0x0602A2BA RID: 172730 RVA: 0x00BE7BD1 File Offset: 0x00BE5DD1
		public bool IsJoystickZoom
		{
			get
			{
				return this.ZoomAxis != "";
			}
		}

		// Token: 0x170054D3 RID: 21715
		// (get) Token: 0x0602A2BB RID: 172731 RVA: 0x00BE7BE3 File Offset: 0x00BE5DE3
		public Vector2D MultiTouchOriginCenter
		{
			get
			{
				return this.InternalMultiTouchOriginCenter;
			}
		}

		// Token: 0x0602A2BC RID: 172732 RVA: 0x00BE7BEC File Offset: 0x00BE5DEC
		public DragInteractComponent(IDragInteractParam param)
		{
			this.Draggable = param.Draggable;
			this.CallbackOnDown = param.CallbackOnDown;
			this.CallbackOnDrag = param.CallbackOnDrag;
			this.CallbackOnInertia = param.CallbackOnInertia;
			this.TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();
			this.Draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			this.Draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			this.Draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			this.Draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnWheelAxisInput));
			this.PointerDeltaPosition = Vector2D.Create();
			this.PrevPointerDownPosition = Vector2D.Create();
		}

		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x0602A2BD RID: 172733 RVA: 0x00BE7CD6 File Offset: 0x00BE5ED6
		public bool IsDragging
		{
			get
			{
				return this.Dragging;
			}
		}

		// Token: 0x170054D5 RID: 21717
		// (get) Token: 0x0602A2BE RID: 172734 RVA: 0x00BE7CE0 File Offset: 0x00BE5EE0
		private Vector2D DragSize
		{
			get
			{
				UUIDraggableComponent draggable = this.Draggable;
				double x = (double)((draggable != null) ? draggable.RootUIComp.Get().Width : 0f);
				UUIDraggableComponent draggable2 = this.Draggable;
				return Vector2D.Create(x, (double)((draggable2 != null) ? draggable2.RootUIComp.Get().Height : 0f));
			}
		}

		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x0602A2BF RID: 172735 RVA: 0x00BE7D3A File Offset: 0x00BE5F3A
		public bool IsJoystickMoving
		{
			get
			{
				return this.JoystickMovingRight || this.JoystickMovingForward;
			}
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x0602A2C0 RID: 172736 RVA: 0x00BE7D4C File Offset: 0x00BE5F4C
		public bool IsJoystickFocus
		{
			get
			{
				return this.JoystickFocus;
			}
		}

		// Token: 0x0602A2C1 RID: 172737 RVA: 0x00BE7D54 File Offset: 0x00BE5F54
		public void SetJoystickFocus(bool value)
		{
			this.JoystickFocus = value;
		}

		// Token: 0x170054D8 RID: 21720
		// (get) Token: 0x0602A2C2 RID: 172738 RVA: 0x00BE7D5D File Offset: 0x00BE5F5D
		// (set) Token: 0x0602A2C3 RID: 172739 RVA: 0x00BE7D65 File Offset: 0x00BE5F65
		public bool IsMultiFingerControl
		{
			get
			{
				return this.MultiFingerControl;
			}
			set
			{
				if (value != this.MultiFingerControl)
				{
					if (!value && this.TouchMap.Count > 0)
					{
						return;
					}
					this.MultiFingerControl = value;
					if (!this.MultiFingerControl)
					{
						this.LastMultiTouchEndTime = Time.Instance.NowSeconds;
					}
				}
			}
		}

		// Token: 0x0602A2C4 RID: 172740 RVA: 0x00BE7DA1 File Offset: 0x00BE5FA1
		public void Enable()
		{
			this.AddEventListener();
		}

		// Token: 0x0602A2C5 RID: 172741 RVA: 0x00BE7DA9 File Offset: 0x00BE5FA9
		public void Disable()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0602A2C6 RID: 172742 RVA: 0x00BE7DB4 File Offset: 0x00BE5FB4
		private void AddEventListener()
		{
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerMapForward, new Action<float>(this.OnUiForwardInput));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerMapRight, new Action<float>(this.OnUiRightInput));
			EventSystem.Instance.Add<string, float>(EEventName.NavigationTriggerMapZoom, new Action<string, float>(this.OnHandleTriggerInput));
		}

		// Token: 0x0602A2C7 RID: 172743 RVA: 0x00BE7E38 File Offset: 0x00BE6038
		private void RemoveEventListener()
		{
			InputDistributeController.Instance.UnBindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerMapForward, new Action<float>(this.OnUiForwardInput));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerMapRight, new Action<float>(this.OnUiRightInput));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerMapZoom, new Action<string, float>(this.OnHandleTriggerInput));
		}

		// Token: 0x0602A2C8 RID: 172744 RVA: 0x00BE7EBC File Offset: 0x00BE60BC
		[NullableContext(2)]
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			this.Dragging = false;
			if (eventData == null || this.IsMultiFingerControl)
			{
				return;
			}
			Vector2D inV = this.MousePositionConvertToLgui((double)eventData.pointerPosition.X, (double)eventData.pointerPosition.Y);
			this.PrevPointerDownPosition.DeepCopy(inV);
			this.PointerDownTime = Time.Instance.NowSeconds;
			Action callbackOnDown = this.CallbackOnDown;
			if (callbackOnDown == null)
			{
				return;
			}
			callbackOnDown();
		}

		// Token: 0x0602A2C9 RID: 172745 RVA: 0x00BE7F28 File Offset: 0x00BE6128
		[NullableContext(2)]
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData == null || this.IsMultiFingerControl || this.TouchMap.Count > 1)
			{
				this.Dragging = false;
				this.PointerDeltaPosition.Reset();
				return;
			}
			this.Dragging = true;
			Vector2D vector2D = this.MousePositionConvertToLgui((double)eventData.pointerPosition.X, (double)eventData.pointerPosition.Y);
			Vector2D vector2D2 = Vector2D.Create(vector2D.X, vector2D.Y).SubtractionEqual(this.PrevPointerDownPosition);
			if (vector2D2.X == 0.0 && vector2D2.Y == 0.0)
			{
				return;
			}
			this.PointerDeltaPosition.DeepCopy(vector2D2);
			this.PrevPointerDownPosition.DeepCopy(vector2D);
			Action<Vector2D> callbackOnDrag = this.CallbackOnDrag;
			if (callbackOnDrag == null)
			{
				return;
			}
			callbackOnDrag(this.PointerDeltaPosition);
		}

		// Token: 0x0602A2CA RID: 172746 RVA: 0x00BE7FF8 File Offset: 0x00BE61F8
		[NullableContext(2)]
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			double nowSeconds = Time.Instance.NowSeconds;
			if (this.IsMultiFingerControl || nowSeconds - this.LastMultiTouchEndTime < 0.5)
			{
				return;
			}
			this.Dragging = false;
			this.DragInertia();
		}

		// Token: 0x0602A2CB RID: 172747 RVA: 0x00BE803C File Offset: 0x00BE623C
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
		{
			InputDistributeDefine.ETouchType touchType = touchData.TouchType;
			int touchId = int.Parse(touchIdName);
			if (touchType == InputDistributeDefine.ETouchType.TouchBegin)
			{
				this.TouchTrigger(true, touchId, touchData);
				return;
			}
			if (touchType != InputDistributeDefine.ETouchType.TouchEnd)
			{
				return;
			}
			this.TouchTrigger(false, touchId, null);
		}

		// Token: 0x0602A2CC RID: 172748 RVA: 0x00BE8072 File Offset: 0x00BE6272
		[NullableContext(2)]
		private void OnWheelAxisInput(ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x0602A2CD RID: 172749 RVA: 0x00BE8074 File Offset: 0x00BE6274
		[NullableContext(2)]
		private void TouchTrigger(bool bTouchPress, int touchId, InputDistributeDefine.ITouchData touchData = null)
		{
			if (bTouchPress)
			{
				if (LguiEventSystemManager.Instance.IsPressComponentIsValid(touchId))
				{
					this.TouchMap[touchId] = touchData;
				}
			}
			else
			{
				this.TouchMap.Remove(touchId);
			}
			this.InternalMultiTouchOriginCenter.Reset();
			foreach (InputDistributeDefine.ITouchData touchData2 in this.TouchMap.Values)
			{
				Vector2D b = Vector2D.Create(touchData2.TouchPosition.X, touchData2.TouchPosition.Y);
				this.InternalMultiTouchOriginCenter.AdditionEqual(b);
			}
			if (this.TouchMap.Count > 0)
			{
				this.InternalMultiTouchOriginCenter.DivisionEqual((double)this.TouchMap.Count);
			}
		}

		// Token: 0x0602A2CE RID: 172750 RVA: 0x00BE814C File Offset: 0x00BE634C
		private Vector2D MousePositionConvertToLgui(double x, double y)
		{
			Vector2D vector2D = Vector2D.Create(x, y);
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
			return vector2D;
		}

		// Token: 0x0602A2CF RID: 172751 RVA: 0x00BE818C File Offset: 0x00BE638C
		private void DragInertia()
		{
			if (this.PointerDeltaPosition.X == 0.0 && this.PointerDeltaPosition.Y == 0.0)
			{
				return;
			}
			double num = Time.Instance.NowSeconds - this.PointerDownTime;
			double num2 = this.PointerDeltaPosition.Size();
			double num3 = 2.0 * num2 / (num * num) * num;
			if (!this.DragSize.IsNearlyZero(9.999999747378752E-05))
			{
				num3 = MathCommon.Clamp(num3, 0.0, this.DragSize.Size());
			}
			if (!this.PointerDeltaPosition.Normalize(0.0))
			{
				this.PointerDeltaPosition.Reset();
				return;
			}
			Vector2D vector2D = Vector2D.Create();
			this.PointerDeltaPosition.Multiply(num3, vector2D);
			Action<Vector2D> callbackOnInertia = this.CallbackOnInertia;
			if (callbackOnInertia != null)
			{
				callbackOnInertia(vector2D);
			}
			this.PointerDeltaPosition.Reset();
		}

		// Token: 0x0602A2D0 RID: 172752 RVA: 0x00BE827A File Offset: 0x00BE647A
		private void OnHandleTriggerInput(string axisName, float value)
		{
			if (value == 0f)
			{
				if (this.ZoomAxis == axisName)
				{
					this.ZoomAxis = "";
				}
				return;
			}
			this.ZoomAxis = axisName;
		}

		// Token: 0x0602A2D1 RID: 172753 RVA: 0x00BE82A5 File Offset: 0x00BE64A5
		private void OnUiForwardInput(float value)
		{
			if (value == 0f)
			{
				this.JoystickMovingForward = false;
				return;
			}
			this.JoystickMovingForward = true;
			this.JoystickFocus = false;
		}

		// Token: 0x0602A2D2 RID: 172754 RVA: 0x00BE82C5 File Offset: 0x00BE64C5
		private void OnUiRightInput(float value)
		{
			if (value == 0f)
			{
				this.JoystickMovingRight = false;
				return;
			}
			this.JoystickMovingRight = true;
			this.JoystickFocus = false;
		}

		// Token: 0x04016F70 RID: 94064
		[Nullable(2)]
		private readonly UUIDraggableComponent Draggable;

		// Token: 0x04016F71 RID: 94065
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<Vector2D> CallbackOnDrag;

		// Token: 0x04016F72 RID: 94066
		[Nullable(2)]
		private readonly Action CallbackOnDown;

		// Token: 0x04016F73 RID: 94067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<Vector2D> CallbackOnInertia;

		// Token: 0x04016F74 RID: 94068
		private bool Dragging;

		// Token: 0x04016F75 RID: 94069
		private bool MultiFingerControl;

		// Token: 0x04016F76 RID: 94070
		private double LastMultiTouchEndTime;

		// Token: 0x04016F77 RID: 94071
		private string ZoomAxis = "";

		// Token: 0x04016F78 RID: 94072
		private bool JoystickMovingRight;

		// Token: 0x04016F79 RID: 94073
		private bool JoystickMovingForward;

		// Token: 0x04016F7A RID: 94074
		private bool JoystickFocus;

		// Token: 0x04016F7B RID: 94075
		[Nullable(2)]
		private Vector2D PrevPointerDownPosition;

		// Token: 0x04016F7C RID: 94076
		[Nullable(2)]
		private Vector2D PointerDeltaPosition;

		// Token: 0x04016F7D RID: 94077
		private double PointerDownTime;

		// Token: 0x04016F7E RID: 94078
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, InputDistributeDefine.ITouchData> TouchMap;

		// Token: 0x04016F7F RID: 94079
		private readonly Vector2D InternalMultiTouchOriginCenter = Vector2D.Create();
	}
}
