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
	// Token: 0x020047AF RID: 18351
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapInteractComponent : MapComponent
	{
		// Token: 0x060300A8 RID: 196776 RVA: 0x00B21D85 File Offset: 0x00B1FF85
		public WorldMapInteractComponent([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<MapComponent, MapComponentContainer, MapEntity> parent) : base(parent)
		{
		}

		// Token: 0x17007842 RID: 30786
		// (get) Token: 0x060300A9 RID: 196777 RVA: 0x00B21DA4 File Offset: 0x00B1FFA4
		public override EMapComponent ComponentType
		{
			get
			{
				return EMapComponent.WorldMapInteract;
			}
		}

		// Token: 0x17007843 RID: 30787
		// (get) Token: 0x060300AA RID: 196778 RVA: 0x00B21DA7 File Offset: 0x00B1FFA7
		public bool IsJoystickMoving
		{
			get
			{
				return this.JoystickMovingRight || this.JoystickMovingForward;
			}
		}

		// Token: 0x17007844 RID: 30788
		// (get) Token: 0x060300AB RID: 196779 RVA: 0x00B21DB9 File Offset: 0x00B1FFB9
		public bool IsJoystickFocus
		{
			get
			{
				return this.JoystickFocus;
			}
		}

		// Token: 0x17007845 RID: 30789
		// (get) Token: 0x060300AC RID: 196780 RVA: 0x00B21DC1 File Offset: 0x00B1FFC1
		[Nullable(1)]
		public Vector2D MultiTouchOriginCenter
		{
			[NullableContext(1)]
			get
			{
				return this.InternalMultiTouchOriginCenter;
			}
		}

		// Token: 0x17007846 RID: 30790
		// (get) Token: 0x060300AD RID: 196781 RVA: 0x00B21DC9 File Offset: 0x00B1FFC9
		public bool IsDragging
		{
			get
			{
				return this.Dragging;
			}
		}

		// Token: 0x17007847 RID: 30791
		// (get) Token: 0x060300AE RID: 196782 RVA: 0x00B21DD1 File Offset: 0x00B1FFD1
		// (set) Token: 0x060300AF RID: 196783 RVA: 0x00B21DDC File Offset: 0x00B1FFDC
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

		// Token: 0x17007848 RID: 30792
		// (get) Token: 0x060300B0 RID: 196784 RVA: 0x00B21E2C File Offset: 0x00B2002C
		public bool IsJoystickZoom
		{
			get
			{
				return !string.IsNullOrEmpty(this.ZoomAxis);
			}
		}

		// Token: 0x17007849 RID: 30793
		// (get) Token: 0x060300B1 RID: 196785 RVA: 0x00B21E3C File Offset: 0x00B2003C
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

		// Token: 0x1700784A RID: 30794
		// (get) Token: 0x060300B2 RID: 196786 RVA: 0x00B21E79 File Offset: 0x00B20079
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

		// Token: 0x1700784B RID: 30795
		// (get) Token: 0x060300B3 RID: 196787 RVA: 0x00B21E8C File Offset: 0x00B2008C
		private FVector2D ViewportSize
		{
			get
			{
				return this.WorldMapUiComponent.ViewPortSize;
			}
		}

		// Token: 0x060300B4 RID: 196788 RVA: 0x00B21E9C File Offset: 0x00B2009C
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

		// Token: 0x060300B5 RID: 196789 RVA: 0x00B21F7B File Offset: 0x00B2017B
		protected override void OnEnable()
		{
			this.AddEventListener();
		}

		// Token: 0x060300B6 RID: 196790 RVA: 0x00B21F83 File Offset: 0x00B20183
		protected override void OnDisable()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060300B7 RID: 196791 RVA: 0x00B21F8B File Offset: 0x00B2018B
		protected override void OnRemove()
		{
			this.PrevPointerDownPosition = null;
			this.PointerDeltaPosition = null;
		}

		// Token: 0x060300B8 RID: 196792 RVA: 0x00B21F9B File Offset: 0x00B2019B
		public void SetJoystickFocus(bool value)
		{
			this.JoystickFocus = value;
		}

		// Token: 0x060300B9 RID: 196793 RVA: 0x00B21FA4 File Offset: 0x00B201A4
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

		// Token: 0x060300BA RID: 196794 RVA: 0x00B22028 File Offset: 0x00B20228
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

		// Token: 0x060300BB RID: 196795 RVA: 0x00B220B0 File Offset: 0x00B202B0
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

		// Token: 0x060300BC RID: 196796 RVA: 0x00B22130 File Offset: 0x00B20330
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

		// Token: 0x060300BD RID: 196797 RVA: 0x00B221C0 File Offset: 0x00B203C0
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

		// Token: 0x060300BE RID: 196798 RVA: 0x00B2229C File Offset: 0x00B2049C
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

		// Token: 0x060300BF RID: 196799 RVA: 0x00B22320 File Offset: 0x00B20520
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

		// Token: 0x060300C0 RID: 196800 RVA: 0x00B22378 File Offset: 0x00B20578
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

		// Token: 0x060300C1 RID: 196801 RVA: 0x00B2246C File Offset: 0x00B2066C
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

		// Token: 0x060300C2 RID: 196802 RVA: 0x00B224A4 File Offset: 0x00B206A4
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

		// Token: 0x060300C3 RID: 196803 RVA: 0x00B2258C File Offset: 0x00B2078C
		private void OnWheelAxisInput(ULGUIPointerEventData eventData)
		{
			EventSystem.Instance.Emit<float, EMapScaleSetType>(EEventName.WorldMapWheelAxisInput, eventData.scrollAxisValue * 0.05f, EMapScaleSetType.WheelInput);
		}

		// Token: 0x060300C4 RID: 196804 RVA: 0x00B225AC File Offset: 0x00B207AC
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

		// Token: 0x060300C5 RID: 196805 RVA: 0x00B22600 File Offset: 0x00B20800
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

		// Token: 0x060300C6 RID: 196806 RVA: 0x00B22654 File Offset: 0x00B20854
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

		// Token: 0x060300C7 RID: 196807 RVA: 0x00B226A4 File Offset: 0x00B208A4
		private bool CheckPointInScope(FVector mousePos)
		{
			Vector2D vector2D = this.MousePositionConverToLgui(mousePos.X, mousePos.Y);
			return vector2D.X >= 0.0 && vector2D.X <= (double)this.ViewportSize.X && vector2D.Y >= 0.0 && vector2D.Y <= (double)this.ViewportSize.Y;
		}

		// Token: 0x060300C8 RID: 196808 RVA: 0x00B22714 File Offset: 0x00B20914
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

		// Token: 0x04019E88 RID: 106120
		private const float MULTI_TOUCH_DELAY_TIME = 0.5f;

		// Token: 0x04019E89 RID: 106121
		private const float SCALE_STEP = 0.05f;

		// Token: 0x04019E8A RID: 106122
		private bool Dragging;

		// Token: 0x04019E8B RID: 106123
		private bool MultiFingerControl;

		// Token: 0x04019E8C RID: 106124
		private double LastMultiTouchEndTime;

		// Token: 0x04019E8D RID: 106125
		private bool JoystickMovingRight;

		// Token: 0x04019E8E RID: 106126
		private bool JoystickMovingForward;

		// Token: 0x04019E8F RID: 106127
		private bool JoystickFocus;

		// Token: 0x04019E90 RID: 106128
		[Nullable(1)]
		private string ZoomAxis = string.Empty;

		// Token: 0x04019E91 RID: 106129
		[Nullable(1)]
		private readonly Vector2D InternalMultiTouchOriginCenter = Vector2D.Create();

		// Token: 0x04019E92 RID: 106130
		private Vector2D PrevPointerDownPosition;

		// Token: 0x04019E93 RID: 106131
		private Vector2D PointerDeltaPosition;

		// Token: 0x04019E94 RID: 106132
		private double PointerDownTime;

		// Token: 0x04019E95 RID: 106133
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, InputDistributeDefine.ITouchData> TouchMap;
	}
}
