using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.Base;
using CSharpScript.Game.Module.Map.View.BaseMap;
using CSharpScript.Game.Ui;
using UnrealEngine;
using UnrealEngine.Extension;

namespace CSharpScript.Game.Module.WorldMap.ViewComponent
{
	// Token: 0x020036E0 RID: 14048
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapInteractComponent : MapComponent
	{
		// Token: 0x06024877 RID: 149623 RVA: 0x00A51CD1 File Offset: 0x00A4FED1
		public WorldMapInteractComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17004AFE RID: 19198
		// (get) Token: 0x06024878 RID: 149624 RVA: 0x00A51CF0 File Offset: 0x00A4FEF0
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapInteract;
			}
		}

		// Token: 0x17004AFF RID: 19199
		// (get) Token: 0x06024879 RID: 149625 RVA: 0x00A51CF3 File Offset: 0x00A4FEF3
		public bool IsJoystickMoving
		{
			get
			{
				return this.JoystickMovingRight || this.JoystickMovingForward;
			}
		}

		// Token: 0x17004B00 RID: 19200
		// (get) Token: 0x0602487A RID: 149626 RVA: 0x00A51D05 File Offset: 0x00A4FF05
		public bool IsJoystickFocus
		{
			get
			{
				return this.JoystickFocus;
			}
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x0602487B RID: 149627 RVA: 0x00A51D0D File Offset: 0x00A4FF0D
		[Nullable(1)]
		public Vector2D MultiTouchOriginCenter
		{
			[NullableContext(1)]
			get
			{
				return this.InternalMultiTouchOriginCenter;
			}
		}

		// Token: 0x17004B02 RID: 19202
		// (get) Token: 0x0602487C RID: 149628 RVA: 0x00A51D15 File Offset: 0x00A4FF15
		public bool IsDragging
		{
			get
			{
				return this.Dragging;
			}
		}

		// Token: 0x17004B03 RID: 19203
		// (get) Token: 0x0602487D RID: 149629 RVA: 0x00A51D1D File Offset: 0x00A4FF1D
		// (set) Token: 0x0602487E RID: 149630 RVA: 0x00A51D28 File Offset: 0x00A4FF28
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
					if (!value)
					{
						Dictionary<int, InputDistributeDefine.ITouchData> touchMap = this.TouchMap;
						if (touchMap != null && touchMap.Count > 0)
						{
							return;
						}
					}
					this.MultiFingerControl = value;
					if (!this.MultiFingerControl)
					{
						this.LastMultiTouchEndTime = Time.Instance.NowSeconds;
					}
				}
			}
		}

		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x0602487F RID: 149631 RVA: 0x00A51D78 File Offset: 0x00A4FF78
		public bool IsJoystickZoom
		{
			get
			{
				return !string.IsNullOrEmpty(this.ZoomAxis);
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x06024880 RID: 149632 RVA: 0x00A51D88 File Offset: 0x00A4FF88
		private WorldMapUiEntity WorldMapUiComponent
		{
			get
			{
				WorldMapUiEntity worldMapUiEntity = base.Parent.AsT3 as WorldMapUiEntity;
				if (worldMapUiEntity == null)
				{
					base.LogError(ELogAuthor.LRX, "[地图系统]->二级界面组件没有附加到容器下！", default(ReadOnlySpan<ValueTuple<string, object>>));
					return null;
				}
				return worldMapUiEntity;
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x06024881 RID: 149633 RVA: 0x00A51DC5 File Offset: 0x00A4FFC5
		private UKuroWorldMapUIParams UiParams
		{
			get
			{
				WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
				if (worldMapUiComponent == null)
				{
					return null;
				}
				return worldMapUiComponent.UiParams;
			}
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x06024882 RID: 149634 RVA: 0x00A51DD8 File Offset: 0x00A4FFD8
		private FVector2D ViewportSize
		{
			get
			{
				return this.WorldMapUiComponent.ViewPortSize;
			}
		}

		// Token: 0x06024883 RID: 149635 RVA: 0x00A51DE8 File Offset: 0x00A4FFE8
		protected override void OnAdd()
		{
			WorldMapUiEntity worldMapUiComponent = this.WorldMapUiComponent;
			BaseMap baseMap = (worldMapUiComponent != null) ? worldMapUiComponent.Map : null;
			object obj;
			if (baseMap == null)
			{
				obj = null;
			}
			else
			{
				AActor rootActor = baseMap.GetRootActor();
				obj = ((rootActor != null) ? rootActor.GetComponentByClass(UUIDraggableComponent.StaticClass()) : null);
			}
			UUIDraggableComponent uuidraggableComponent = obj as UUIDraggableComponent;
			if (uuidraggableComponent == null)
			{
				return;
			}
			this.TouchMap = new Dictionary<int, InputDistributeDefine.ITouchData>();
			this.PrevPointerDownPosition = Vector2D.Create();
			this.PointerDeltaPosition = Vector2D.Create();
			uuidraggableComponent.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDown));
			uuidraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			uuidraggableComponent.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUp));
			uuidraggableComponent.OnPointerCancelCallBack.Bind(new Action<ULGUIPointerEventData>(this.EndDrag));
			uuidraggableComponent.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnWheelAxisInput));
		}

		// Token: 0x06024884 RID: 149636 RVA: 0x00A51EC7 File Offset: 0x00A500C7
		protected override void OnEnable()
		{
			this.AddEventListener();
		}

		// Token: 0x06024885 RID: 149637 RVA: 0x00A51ECF File Offset: 0x00A500CF
		protected override void OnDisable()
		{
			this.RemoveEventListener();
		}

		// Token: 0x06024886 RID: 149638 RVA: 0x00A51ED7 File Offset: 0x00A500D7
		protected override void OnRemove()
		{
			this.PrevPointerDownPosition = null;
			this.PointerDeltaPosition = null;
		}

		// Token: 0x06024887 RID: 149639 RVA: 0x00A51EE7 File Offset: 0x00A500E7
		public void SetJoystickFocus(bool value)
		{
			this.JoystickFocus = value;
		}

		// Token: 0x06024888 RID: 149640 RVA: 0x00A51EF0 File Offset: 0x00A500F0
		private void AddEventListener()
		{
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			EventSystem.Instance.Add(EEventName.NavigationTriggerMapForward, new Action<float>(this.OnUiForwardInput));
			EventSystem.Instance.Add(EEventName.NavigationTriggerMapRight, new Action<float>(this.OnUiRightInput));
			EventSystem.Instance.Add(EEventName.NavigationTriggerMapZoom, new Action<string, float>(this.OnHandleTriggerInput));
		}

		// Token: 0x06024889 RID: 149641 RVA: 0x00A51F74 File Offset: 0x00A50174
		private void RemoveEventListener()
		{
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
			{
				0,
				1
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerMapForward, new Action<float>(this.OnUiForwardInput));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerMapRight, new Action<float>(this.OnUiRightInput));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerMapZoom, new Action<string, float>(this.OnHandleTriggerInput));
		}

		// Token: 0x0602488A RID: 149642 RVA: 0x00A51FFC File Offset: 0x00A501FC
		public void CheckTouch()
		{
			if (this.TouchMap == null)
			{
				return;
			}
			InputDistributeDefine.ITouchData touchData;
			this.TouchMap.TryGetValue(0, out touchData);
			InputDistributeDefine.ITouchData touchData2;
			this.TouchMap.TryGetValue(1, out touchData2);
			this.IsMultiFingerControl = (touchData != null && touchData2 != null);
			if (!this.IsMultiFingerControl)
			{
				return;
			}
			ValueTuple<EFingerExpandCloseType, float> fingerExpandCloseType = TouchFingerManager.Instance.GetFingerExpandCloseType(EFingerIndex.One, EFingerIndex.Two);
			EFingerExpandCloseType item = fingerExpandCloseType.Item1;
			if (item - EFingerExpandCloseType.Expand <= 1)
			{
				EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapFingerExpandClose, fingerExpandCloseType.Item2, EMapScaleSetType.FingerExpandClose);
			}
		}

		// Token: 0x0602488B RID: 149643 RVA: 0x00A5207C File Offset: 0x00A5027C
		private void OnPointerDown(ULGUIPointerEventData eventData)
		{
			this.Dragging = false;
			Vector2D pointerDeltaPosition = this.PointerDeltaPosition;
			if (pointerDeltaPosition != null)
			{
				pointerDeltaPosition.Reset();
			}
			if (eventData == null || this.IsMultiFingerControl || !this.CheckPointInScope(eventData.pointerPosition))
			{
				return;
			}
			Vector2D inV = this.MousePositionConverToLgui(eventData.pointerPosition.X, eventData.pointerPosition.Y);
			Vector2D prevPointerDownPosition = this.PrevPointerDownPosition;
			if (prevPointerDownPosition != null)
			{
				prevPointerDownPosition.DeepCopy(inV);
			}
			this.PointerDownTime = Time.Instance.NowSeconds;
			EventSystem.Instance.Emit(EEventName.WorldMapPointerDown);
		}

		// Token: 0x0602488C RID: 149644 RVA: 0x00A5210C File Offset: 0x00A5030C
		private void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (eventData != null && !this.IsMultiFingerControl)
			{
				Dictionary<int, InputDistributeDefine.ITouchData> touchMap = this.TouchMap;
				if (((touchMap != null) ? touchMap.Count : 0) <= 1)
				{
					this.Dragging = true;
					Vector2D vector2D = this.MousePositionConverToLgui(eventData.pointerPosition.X, eventData.pointerPosition.Y);
					Vector2D vector2D2 = Vector2D.Create(vector2D.X, vector2D.Y);
					vector2D2.SubtractionEqual(this.PrevPointerDownPosition);
					if (vector2D2.X == 0.0 && vector2D2.Y == 0.0)
					{
						return;
					}
					this.PointerDeltaPosition.DeepCopy(vector2D2);
					this.PrevPointerDownPosition.DeepCopy(vector2D);
					EventSystem.Instance.Emit<Vector2D>(EEventName.WorldMapPointerDrag, this.PointerDeltaPosition);
					return;
				}
			}
			this.Dragging = false;
			Vector2D pointerDeltaPosition = this.PointerDeltaPosition;
			if (pointerDeltaPosition == null)
			{
				return;
			}
			pointerDeltaPosition.Reset();
		}

		// Token: 0x0602488D RID: 149645 RVA: 0x00A521E8 File Offset: 0x00A503E8
		private void OnPointerUp(ULGUIPointerEventData eventData)
		{
			double nowSeconds = Time.Instance.NowSeconds;
			if (this.IsMultiFingerControl || nowSeconds - this.LastMultiTouchEndTime < 0.5)
			{
				Log.Instance.Info(ELogModule.Map, ELogAuthor.LYX, "正在进行双指缩放", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.Dragging)
			{
				this.EndDrag(eventData);
				return;
			}
			if (eventData == null || !this.CheckPointInScope(eventData.pointerPosition))
			{
				return;
			}
			EventSystem.Instance.Emit<ULGUIPointerEventData>(EEventName.WorldMapPointerUp, eventData);
		}

		// Token: 0x0602488E RID: 149646 RVA: 0x00A5226C File Offset: 0x00A5046C
		private void EndDrag(ULGUIPointerEventData eventData)
		{
			if (!this.Dragging)
			{
				return;
			}
			this.Dragging = false;
			if (!this.IsMultiFingerControl && Time.Instance.NowSeconds - this.LastMultiTouchEndTime >= 0.5)
			{
				this.DragInertia();
				return;
			}
			Vector2D pointerDeltaPosition = this.PointerDeltaPosition;
			if (pointerDeltaPosition == null)
			{
				return;
			}
			pointerDeltaPosition.Reset();
		}

		// Token: 0x0602488F RID: 149647 RVA: 0x00A522C4 File Offset: 0x00A504C4
		private void DragInertia()
		{
			if (this.PointerDeltaPosition == null || (this.PointerDeltaPosition.X == 0.0 && this.PointerDeltaPosition.Y == 0.0))
			{
				return;
			}
			double num = Time.Instance.NowSeconds - this.PointerDownTime;
			double num2 = this.PointerDeltaPosition.Size();
			double num3 = 2.0 * num2 / (num * num) * num;
			FVector2D uiViewportSize = LGuiExtension.GetUiViewportSize();
			if (!uiViewportSize.IsNearlyZero(0.0001f))
			{
				num3 = MathCommon.Clamp(num3, 0.0, (double)uiViewportSize.Size());
			}
			if (!this.PointerDeltaPosition.Normalize(0.0))
			{
				this.PointerDeltaPosition.Reset();
				return;
			}
			Vector2D vector2D = Vector2D.Create();
			this.PointerDeltaPosition.Multiply(num3, vector2D);
			EventSystem.Instance.Emit<Vector2D>(EEventName.WorldMapDragInertia, vector2D);
			this.PointerDeltaPosition.Reset();
		}

		// Token: 0x06024890 RID: 149648 RVA: 0x00A523B8 File Offset: 0x00A505B8
		[NullableContext(1)]
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification identification)
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

		// Token: 0x06024891 RID: 149649 RVA: 0x00A523F0 File Offset: 0x00A505F0
		private void TouchTrigger(bool bTouchPress, int touchId, InputDistributeDefine.ITouchData touchData = null)
		{
			if (bTouchPress)
			{
				if (LguiEventSystemManager.Instance.IsPressComponentIsValid(touchId) && touchData != null)
				{
					this.TouchMap[touchId] = touchData;
				}
			}
			else
			{
				this.TouchMap.Remove(touchId);
			}
			this.InternalMultiTouchOriginCenter.Reset();
			if (this.TouchMap != null)
			{
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
		}

		// Token: 0x06024892 RID: 149650 RVA: 0x00A524D8 File Offset: 0x00A506D8
		private void OnWheelAxisInput(ULGUIPointerEventData eventData)
		{
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapWheelAxisInput, eventData.scrollAxisValue * 0.05f, EMapScaleSetType.WheelInput);
		}

		// Token: 0x06024893 RID: 149651 RVA: 0x00A524F8 File Offset: 0x00A506F8
		private void OnUiForwardInput(float value)
		{
			if (value == 0f)
			{
				this.JoystickMovingForward = false;
				return;
			}
			this.JoystickMovingForward = true;
			this.JoystickFocus = false;
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.WorldMapJoystickMoveForward;
			UKuroWorldMapUIParams uiParams = this.UiParams;
			instance.Emit<float>(name, (uiParams != null) ? (-uiParams.GamePadMoveSpeed * value) : 0f);
		}

		// Token: 0x06024894 RID: 149652 RVA: 0x00A5254C File Offset: 0x00A5074C
		private void OnUiRightInput(float value)
		{
			if (value == 0f)
			{
				this.JoystickMovingRight = false;
				return;
			}
			this.JoystickMovingRight = true;
			this.JoystickFocus = false;
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.WorldMapJoystickMoveRight;
			UKuroWorldMapUIParams uiParams = this.UiParams;
			instance.Emit<float>(name, (uiParams != null) ? (-uiParams.GamePadMoveSpeed * value) : 0f);
		}

		// Token: 0x06024895 RID: 149653 RVA: 0x00A525A0 File Offset: 0x00A507A0
		[NullableContext(1)]
		private void OnHandleTriggerInput(string axisName, float value)
		{
			if (value == 0f)
			{
				if (this.ZoomAxis == axisName)
				{
					this.ZoomAxis = string.Empty;
				}
				return;
			}
			this.ZoomAxis = axisName;
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapHandleTriggerAxisInput, 0.05f * value, EMapScaleSetType.Gamepad);
		}

		// Token: 0x06024896 RID: 149654 RVA: 0x00A525F0 File Offset: 0x00A507F0
		private bool CheckPointInScope(FVector mousePos)
		{
			Vector2D vector2D = this.MousePositionConverToLgui(mousePos.X, mousePos.Y);
			return vector2D.X >= 0.0 && vector2D.X <= (double)this.ViewportSize.X && vector2D.Y >= 0.0 && vector2D.Y <= (double)this.ViewportSize.Y;
		}

		// Token: 0x06024897 RID: 149655 RVA: 0x00A52660 File Offset: 0x00A50860
		[NullableContext(1)]
		private Vector2D MousePositionConverToLgui(float x, float y)
		{
			Vector2D vector2D = Vector2D.Create((double)x, (double)y);
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			if (((uiRootItem != null) ? uiRootItem.GetCanvasScaler() : null) != null)
			{
				FVector2D fvector2D = vector2D.ToUeVector2D(false);
				FVector2D fvector2D2 = uiRootItem.GetCanvasScaler().ConvertPositionFromViewportToLGUICanvas(fvector2D);
				vector2D.FromUeVector2D(fvector2D2);
			}
			vector2D.X = MathCommon.Clamp(vector2D.X, 0.0, (double)this.ViewportSize.X);
			vector2D.Y = MathCommon.Clamp(vector2D.Y, 0.0, (double)this.ViewportSize.Y);
			return vector2D;
		}

		// Token: 0x04014538 RID: 83256
		private const float MULTI_TOUCH_DELAY_TIME = 0.5f;

		// Token: 0x04014539 RID: 83257
		private const float SCALE_STEP = 0.05f;

		// Token: 0x0401453A RID: 83258
		private bool Dragging;

		// Token: 0x0401453B RID: 83259
		private bool MultiFingerControl;

		// Token: 0x0401453C RID: 83260
		private double LastMultiTouchEndTime;

		// Token: 0x0401453D RID: 83261
		private bool JoystickMovingRight;

		// Token: 0x0401453E RID: 83262
		private bool JoystickMovingForward;

		// Token: 0x0401453F RID: 83263
		private bool JoystickFocus;

		// Token: 0x04014540 RID: 83264
		[Nullable(1)]
		private string ZoomAxis = string.Empty;

		// Token: 0x04014541 RID: 83265
		[Nullable(1)]
		private readonly Vector2D InternalMultiTouchOriginCenter = Vector2D.Create();

		// Token: 0x04014542 RID: 83266
		private Vector2D PrevPointerDownPosition;

		// Token: 0x04014543 RID: 83267
		private Vector2D PointerDeltaPosition;

		// Token: 0x04014544 RID: 83268
		private double PointerDownTime;

		// Token: 0x04014545 RID: 83269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, InputDistributeDefine.ITouchData> TouchMap;
	}
}
