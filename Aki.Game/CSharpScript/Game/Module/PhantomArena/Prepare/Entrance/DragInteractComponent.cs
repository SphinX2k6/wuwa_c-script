using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005158 RID: 20824
	[NullableContext(1)]
	[Nullable(0)]
	public class DragInteractComponent
	{
		// Token: 0x17008112 RID: 33042
		// (get) Token: 0x060353BE RID: 218046 RVA: 0x00C9A6D1 File Offset: 0x00C988D1
		public bool IsJoystickZoom
		{
			get
			{
				return this.ZoomAxis != "";
			}
		}

		// Token: 0x17008113 RID: 33043
		// (get) Token: 0x060353BF RID: 218047 RVA: 0x00C9A6E3 File Offset: 0x00C988E3
		public Vector2D MultiTouchOriginCenter
		{
			get
			{
				return this.InternalMultiTouchOriginCenter;
			}
		}

		// Token: 0x060353C0 RID: 218048 RVA: 0x00C9A6EC File Offset: 0x00C988EC
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

		// Token: 0x17008114 RID: 33044
		// (get) Token: 0x060353C1 RID: 218049 RVA: 0x00C9A7D6 File Offset: 0x00C989D6
		public bool IsDragging
		{
			get
			{
				return this.Dragging;
			}
		}

		// Token: 0x17008115 RID: 33045
		// (get) Token: 0x060353C2 RID: 218050 RVA: 0x00C9A7E0 File Offset: 0x00C989E0
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

		// Token: 0x17008116 RID: 33046
		// (get) Token: 0x060353C3 RID: 218051 RVA: 0x00C9A83A File Offset: 0x00C98A3A
		public bool IsJoystickMoving
		{
			get
			{
				return this.JoystickMovingRight || this.JoystickMovingForward;
			}
		}

		// Token: 0x17008117 RID: 33047
		// (get) Token: 0x060353C4 RID: 218052 RVA: 0x00C9A84C File Offset: 0x00C98A4C
		public bool IsJoystickFocus
		{
			get
			{
				return this.JoystickFocus;
			}
		}

		// Token: 0x060353C5 RID: 218053 RVA: 0x00C9A854 File Offset: 0x00C98A54
		public void SetJoystickFocus(bool value)
		{
			this.JoystickFocus = value;
		}

		// Token: 0x17008118 RID: 33048
		// (get) Token: 0x060353C6 RID: 218054 RVA: 0x00C9A85D File Offset: 0x00C98A5D
		// (set) Token: 0x060353C7 RID: 218055 RVA: 0x00C9A865 File Offset: 0x00C98A65
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

		// Token: 0x060353C8 RID: 218056 RVA: 0x00C9A8A1 File Offset: 0x00C98AA1
		public void Enable()
		{
			this.AddEventListener();
		}

		// Token: 0x060353C9 RID: 218057 RVA: 0x00C9A8A9 File Offset: 0x00C98AA9
		public void Disable()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060353CA RID: 218058 RVA: 0x00C9A8B4 File Offset: 0x00C98AB4
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

		// Token: 0x060353CB RID: 218059 RVA: 0x00C9A938 File Offset: 0x00C98B38
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

		// Token: 0x060353CC RID: 218060 RVA: 0x00C9A9BC File Offset: 0x00C98BBC
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

		// Token: 0x060353CD RID: 218061 RVA: 0x00C9AA28 File Offset: 0x00C98C28
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

		// Token: 0x060353CE RID: 218062 RVA: 0x00C9AAF8 File Offset: 0x00C98CF8
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

		// Token: 0x060353CF RID: 218063 RVA: 0x00C9AB3C File Offset: 0x00C98D3C
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

		// Token: 0x060353D0 RID: 218064 RVA: 0x00C9AB72 File Offset: 0x00C98D72
		[NullableContext(2)]
		private void OnWheelAxisInput(ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x060353D1 RID: 218065 RVA: 0x00C9AB74 File Offset: 0x00C98D74
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

		// Token: 0x060353D2 RID: 218066 RVA: 0x00C9AC4C File Offset: 0x00C98E4C
		private Vector2D MousePositionConvertToLgui(double x, double y)
		{
			Vector2D vector2D = Vector2D.Create(x, y);
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
			return vector2D;
		}

		// Token: 0x060353D3 RID: 218067 RVA: 0x00C9AC8C File Offset: 0x00C98E8C
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

		// Token: 0x060353D4 RID: 218068 RVA: 0x00C9AD7A File Offset: 0x00C98F7A
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

		// Token: 0x060353D5 RID: 218069 RVA: 0x00C9ADA5 File Offset: 0x00C98FA5
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

		// Token: 0x060353D6 RID: 218070 RVA: 0x00C9ADC5 File Offset: 0x00C98FC5
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

		// Token: 0x0401C53B RID: 116027
		[Nullable(2)]
		private readonly UUIDraggableComponent Draggable;

		// Token: 0x0401C53C RID: 116028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<Vector2D> CallbackOnDrag;

		// Token: 0x0401C53D RID: 116029
		[Nullable(2)]
		private readonly Action CallbackOnDown;

		// Token: 0x0401C53E RID: 116030
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<Vector2D> CallbackOnInertia;

		// Token: 0x0401C53F RID: 116031
		private bool Dragging;

		// Token: 0x0401C540 RID: 116032
		private bool MultiFingerControl;

		// Token: 0x0401C541 RID: 116033
		private double LastMultiTouchEndTime;

		// Token: 0x0401C542 RID: 116034
		private string ZoomAxis = "";

		// Token: 0x0401C543 RID: 116035
		private bool JoystickMovingRight;

		// Token: 0x0401C544 RID: 116036
		private bool JoystickMovingForward;

		// Token: 0x0401C545 RID: 116037
		private bool JoystickFocus;

		// Token: 0x0401C546 RID: 116038
		[Nullable(2)]
		private Vector2D PrevPointerDownPosition;

		// Token: 0x0401C547 RID: 116039
		[Nullable(2)]
		private Vector2D PointerDeltaPosition;

		// Token: 0x0401C548 RID: 116040
		private double PointerDownTime;

		// Token: 0x0401C549 RID: 116041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, InputDistributeDefine.ITouchData> TouchMap;

		// Token: 0x0401C54A RID: 116042
		private readonly Vector2D InternalMultiTouchOriginCenter = Vector2D.Create();
	}
}
