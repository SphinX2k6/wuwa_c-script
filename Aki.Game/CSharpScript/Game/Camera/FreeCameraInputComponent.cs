using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006452 RID: 25682
	[NullableContext(1)]
	[Nullable(0)]
	public class FreeCameraInputComponent : EntityComponent
	{
		// Token: 0x170076A8 RID: 30376
		// (get) Token: 0x0603E602 RID: 255490 RVA: 0x0122275A File Offset: 0x0122095A
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(FreeCameraLogicComponent)
				};
			}
		}

		// Token: 0x0603E603 RID: 255491 RVA: 0x0122276F File Offset: 0x0122096F
		protected override bool OnStart()
		{
			this.LogicComponent = base.Entity.GetComponent<FreeCameraLogicComponent>();
			this.InitViewportSize();
			return this.LogicComponent != null;
		}

		// Token: 0x0603E604 RID: 255492 RVA: 0x01222794 File Offset: 0x01220994
		private void HandleInputDirty()
		{
			if (this.ForwardData.Distance == 0f && this.RightData.Distance == 0f && this.UpData.Distance == 0f && this.RotateLookUp == 0f && this.RotateTurn == 0f && this.DeltaFov == 0f)
			{
				this.IsInputDirty = false;
			}
		}

		// Token: 0x0603E605 RID: 255493 RVA: 0x01222808 File Offset: 0x01220A08
		private void ResetData()
		{
			this.ForwardData.Distance = 0f;
			this.RightData.Distance = 0f;
			this.UpData.Distance = 0f;
			this.RotateLookUp = 0f;
			this.RotateTurn = 0f;
			this.DeltaFov = 0f;
			this.IsInputDirty = false;
		}

		// Token: 0x0603E606 RID: 255494 RVA: 0x01222870 File Offset: 0x01220A70
		protected override void OnTick(float delta)
		{
			if (!this.IsInputDirty)
			{
				return;
			}
			this.HandleInputDirty();
			FreeCameraLogicComponent logicComponent = this.LogicComponent;
			if (logicComponent != null)
			{
				logicComponent.ReceiveCameraInput(this.ForwardData, this.RightData, this.UpData, this.RotateLookUp, this.RotateTurn, this.DeltaFov, 0f, null, false);
			}
			this.ResetData();
		}

		// Token: 0x0603E607 RID: 255495 RVA: 0x012228D0 File Offset: 0x01220AD0
		[NullableContext(2)]
		public void BindAxes(UUIDraggableComponent dragComponent = null)
		{
			InputDistributeController.Instance.BindAxes(new <>z__ReadOnlyArray<string>(new string[]
			{
				"Zoom",
				"UiIncrease",
				"UiReduce"
			}), new TInputHandle<float>(this.InputCameraFov));
			InputDistributeController.Instance.BindAxis("MoveForward", new TInputHandle<float>(this.InputCameraForward));
			InputDistributeController.Instance.BindAxis("MoveRight", new TInputHandle<float>(this.InputCameraRight));
			InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.InputCameraForward));
			InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.InputCameraRight));
			InputDistributeController.Instance.BindAxis("LookUp", new TInputHandle<float>(this.InputCameraLookUp));
			InputDistributeController.Instance.BindAxis("Turn", new TInputHandle<float>(this.InputCameraTurn));
			this.DragComponent = dragComponent;
			if (this.DragComponent != null)
			{
				this.DragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
				this.DragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
				this.DragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
				this.DragComponent.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
			}
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0603E608 RID: 255496 RVA: 0x01222A58 File Offset: 0x01220C58
		public void UnBindAxes()
		{
			InputDistributeController.Instance.UnBindAxes(new <>z__ReadOnlyArray<string>(new string[]
			{
				"Zoom",
				"UiIncrease",
				"UiReduce"
			}), new TInputHandle<float>(this.InputCameraFov));
			InputDistributeController.Instance.UnBindAxis("MoveForward", new TInputHandle<float>(this.InputCameraForward));
			InputDistributeController.Instance.UnBindAxis("MoveRight", new TInputHandle<float>(this.InputCameraRight));
			InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.InputCameraForward));
			InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.InputCameraRight));
			InputDistributeController.Instance.UnBindAxis("LookUp", new TInputHandle<float>(this.InputCameraLookUp));
			InputDistributeController.Instance.UnBindAxis("Turn", new TInputHandle<float>(this.InputCameraTurn));
			if (this.DragComponent != null)
			{
				this.DragComponent.OnPointerBeginDragCallBack.Unbind();
				this.DragComponent.OnPointerDragCallBack.Unbind();
				this.DragComponent.OnPointerEndDragCallBack.Unbind();
				this.DragComponent.OnPointerScrollCallBack.Unbind();
				this.DragComponent = null;
			}
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
			{
				0,
				1
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
		}

		// Token: 0x0603E609 RID: 255497 RVA: 0x01222BB4 File Offset: 0x01220DB4
		private void InitViewportSize()
		{
			this.ViewportSize.X = (double)UiLayer.Instance.UiRootItem.GetWidth();
			this.ViewportSize.Y = (double)UiLayer.Instance.UiRootItem.GetHeight();
		}

		// Token: 0x0603E60A RID: 255498 RVA: 0x01222BEC File Offset: 0x01220DEC
		protected void InputCameraFov(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraFieldFov(value * 1f);
		}

		// Token: 0x0603E60B RID: 255499 RVA: 0x01222BFB File Offset: 0x01220DFB
		protected void InputCameraForward(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraMoveForward(value * 10f);
		}

		// Token: 0x0603E60C RID: 255500 RVA: 0x01222C0A File Offset: 0x01220E0A
		protected void InputCameraRight(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraMoveRight(value * 10f);
		}

		// Token: 0x0603E60D RID: 255501 RVA: 0x01222C19 File Offset: 0x01220E19
		protected void InputCameraUp(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraMoveUp(value * 10f);
		}

		// Token: 0x0603E60E RID: 255502 RVA: 0x01222C28 File Offset: 0x01220E28
		protected void InputCameraLookUp(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraRotateLookUp(-value * 3f);
		}

		// Token: 0x0603E60F RID: 255503 RVA: 0x01222C38 File Offset: 0x01220E38
		protected void InputCameraTurn(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraRotateTurn(value * 3f);
		}

		// Token: 0x0603E610 RID: 255504 RVA: 0x01222C47 File Offset: 0x01220E47
		public void InputCameraMoveForward(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.ForwardData.Distance = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0603E611 RID: 255505 RVA: 0x01222C65 File Offset: 0x01220E65
		public void InputCameraMoveRight(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.RightData.Distance = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0603E612 RID: 255506 RVA: 0x01222C83 File Offset: 0x01220E83
		public void InputCameraMoveUp(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.UpData.Distance = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0603E613 RID: 255507 RVA: 0x01222CA1 File Offset: 0x01220EA1
		public void InputCameraRotateLookUp(float value)
		{
			if (value == 0f && this.RotateLookUp == 0f)
			{
				return;
			}
			this.RotateLookUp = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0603E614 RID: 255508 RVA: 0x01222CC7 File Offset: 0x01220EC7
		public void InputCameraRotateTurn(float value)
		{
			if (value == 0f && this.RotateTurn == 0f)
			{
				return;
			}
			this.RotateTurn = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0603E615 RID: 255509 RVA: 0x01222CED File Offset: 0x01220EED
		public void InputCameraFieldFov(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.DeltaFov = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0603E616 RID: 255510 RVA: 0x01222D06 File Offset: 0x01220F06
		public void SetIsMoveBySelf(bool isMoveBySelf)
		{
			this.ForwardData.IsMoveBySelf = isMoveBySelf;
			this.RightData.IsMoveBySelf = isMoveBySelf;
			this.UpData.IsMoveBySelf = isMoveBySelf;
		}

		// Token: 0x0603E617 RID: 255511 RVA: 0x01222D2C File Offset: 0x01220F2C
		public void SetUpMoveByWorld()
		{
			this.UpData.IsMoveBySelf = false;
		}

		// Token: 0x0603E618 RID: 255512 RVA: 0x01222D3A File Offset: 0x01220F3A
		public void SetForwardMoveByWorld()
		{
			this.ForwardData.IsMoveBySelf = false;
		}

		// Token: 0x0603E619 RID: 255513 RVA: 0x01222D48 File Offset: 0x01220F48
		public void SetRightMoveByWorld()
		{
			this.RightData.IsMoveBySelf = false;
		}

		// Token: 0x0603E61A RID: 255514 RVA: 0x01222D56 File Offset: 0x01220F56
		[NullableContext(2)]
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			this.PointerDownTime = Time.Instance.NowSeconds;
			this.CurrentDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		}

		// Token: 0x0603E61B RID: 255515 RVA: 0x01222D84 File Offset: 0x01220F84
		[NullableContext(2)]
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput || TouchFingerManager.Instance.GetTouchFingerCount() > 1 || InputSettings.Instance.IsInputKeyDown("RightMouseButton"))
			{
				this.CurrentDragPosition = null;
				this.DragDeltaPos.Reset();
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
			this.DragDeltaPos = Vector2D.Create((double)num, (double)num2);
			if (num != 0f)
			{
				this.InputCameraMoveRight(-num);
			}
			if (num2 != 0f)
			{
				this.InputCameraMoveForward(-num2);
			}
		}

		// Token: 0x0603E61C RID: 255516 RVA: 0x01222E5C File Offset: 0x0122105C
		[NullableContext(2)]
		private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (!this.DragDeltaPos.Normalize(0.0))
			{
				this.DragDeltaPos.Reset();
				return;
			}
			double num = Time.Instance.NowSeconds - this.PointerDownTime;
			float num2 = (float)MathUtils.Instance.Clamp(this.DragDeltaPos.X / num, -this.ViewportSize.X, this.ViewportSize.X);
			float num3 = (float)MathUtils.Instance.Clamp(this.DragDeltaPos.Y / num, -this.ViewportSize.Y, this.ViewportSize.Y);
			this.RightData.Distance = 2f * num2;
			this.ForwardData.Distance = 2f * num3;
			FreeCameraLogicComponent logicComponent = this.LogicComponent;
			if (logicComponent != null)
			{
				logicComponent.ReceiveCameraInput(this.ForwardData, this.RightData, this.UpData, this.RotateLookUp, this.RotateTurn, this.DeltaFov, 0.8f, CurveUtils.CreateCurve(ECurveType.Squared, new float[]
				{
					0.5f
				}), true);
			}
			this.ResetData();
			this.CurrentDragPosition = null;
		}

		// Token: 0x0603E61D RID: 255517 RVA: 0x01222F8B File Offset: 0x0122118B
		[NullableContext(2)]
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (eventData.scrollAxisValue != 0f)
			{
				this.InputCameraFieldFov(eventData.scrollAxisValue);
			}
		}

		// Token: 0x0603E61E RID: 255518 RVA: 0x01222FAF File Offset: 0x012211AF
		private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
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

		// Token: 0x0603E61F RID: 255519 RVA: 0x01222FCC File Offset: 0x012211CC
		private void TouchMoved()
		{
			if (!this.CanCameraInput)
			{
				return;
			}
			if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(EFingerIndex.One, EFingerIndex.Two);
				this.InputCameraFieldFov(fingerExpandCloseValue);
			}
		}

		// Token: 0x0603E620 RID: 255520 RVA: 0x01223004 File Offset: 0x01221204
		public void ResetInputData()
		{
			this.ForwardData.Distance = 0f;
			this.RightData.Distance = 0f;
			this.UpData.Distance = 0f;
			this.RotateLookUp = 0f;
			this.RotateTurn = 0f;
			this.DeltaFov = 0f;
			this.IsInputDirty = false;
			FreeCameraLogicComponent logicComponent = this.LogicComponent;
			if (logicComponent == null)
			{
				return;
			}
			logicComponent.ResetToInit(0f, null, null);
		}

		// Token: 0x0603E621 RID: 255521 RVA: 0x01223080 File Offset: 0x01221280
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FreeCameraInputComponent freeCameraInputComponent = (FreeCameraInputComponent)componentTemplate;
			if (freeCameraInputComponent.LogicComponent == null)
			{
				this.LogicComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LogicComponent), "LogicComponent"))
			{
				return false;
			}
			this.IsInputDirty = freeCameraInputComponent.IsInputDirty;
			if (freeCameraInputComponent.ForwardData != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForwardData), "ForwardData"))
			{
				return false;
			}
			if (freeCameraInputComponent.RightData != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.RightData), "RightData"))
			{
				return false;
			}
			if (freeCameraInputComponent.UpData != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.UpData), "UpData"))
			{
				return false;
			}
			this.RotateLookUp = freeCameraInputComponent.RotateLookUp;
			this.RotateTurn = freeCameraInputComponent.RotateTurn;
			this.DeltaFov = freeCameraInputComponent.DeltaFov;
			if (freeCameraInputComponent.DragComponent == null)
			{
				this.DragComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DragComponent), "DragComponent"))
			{
				return false;
			}
			this.CurrentDragPosition = freeCameraInputComponent.CurrentDragPosition;
			if (freeCameraInputComponent.DragDeltaPos == null)
			{
				this.DragDeltaPos = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DragDeltaPos), "DragDeltaPos"))
			{
				return false;
			}
			this.CanCameraInput = freeCameraInputComponent.CanCameraInput;
			this.PointerDownTime = freeCameraInputComponent.PointerDownTime;
			return freeCameraInputComponent.ViewportSize == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.ViewportSize), "ViewportSize");
		}

		// Token: 0x170076A9 RID: 30377
		// (get) Token: 0x0603E622 RID: 255522 RVA: 0x012231FD File Offset: 0x012213FD
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170076AA RID: 30378
		// (get) Token: 0x0603E623 RID: 255523 RVA: 0x01223200 File Offset: 0x01221400
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040213B0 RID: 136112
		private const int MOVE_STEP = 10;

		// Token: 0x040213B1 RID: 136113
		private const int ROTATE_STEP = 3;

		// Token: 0x040213B2 RID: 136114
		private const int FOV_STEP = 1;

		// Token: 0x040213B3 RID: 136115
		private const float TWEEN_TIME = 2f;

		// Token: 0x040213B4 RID: 136116
		private const float DRAG_TWEEN_TIME = 0.8f;

		// Token: 0x040213B5 RID: 136117
		[Nullable(2)]
		private FreeCameraLogicComponent LogicComponent;

		// Token: 0x040213B6 RID: 136118
		private bool IsInputDirty;

		// Token: 0x040213B7 RID: 136119
		private readonly FreeCameraLogicComponent.ICameraMoveData ForwardData = new FreeCameraLogicComponent.CameraMoveDataImpl
		{
			Distance = 0f,
			IsMoveBySelf = true
		};

		// Token: 0x040213B8 RID: 136120
		private readonly FreeCameraLogicComponent.ICameraMoveData RightData = new FreeCameraLogicComponent.CameraMoveDataImpl
		{
			Distance = 0f,
			IsMoveBySelf = true
		};

		// Token: 0x040213B9 RID: 136121
		private readonly FreeCameraLogicComponent.ICameraMoveData UpData = new FreeCameraLogicComponent.CameraMoveDataImpl
		{
			Distance = 0f,
			IsMoveBySelf = true
		};

		// Token: 0x040213BA RID: 136122
		private float RotateLookUp;

		// Token: 0x040213BB RID: 136123
		private float RotateTurn;

		// Token: 0x040213BC RID: 136124
		private float DeltaFov;

		// Token: 0x040213BD RID: 136125
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x040213BE RID: 136126
		private FVector? CurrentDragPosition;

		// Token: 0x040213BF RID: 136127
		private Vector2D DragDeltaPos = Vector2D.Create();

		// Token: 0x040213C0 RID: 136128
		public bool CanCameraInput;

		// Token: 0x040213C1 RID: 136129
		private double PointerDownTime;

		// Token: 0x040213C2 RID: 136130
		private readonly Vector2D ViewportSize = Vector2D.Create();
	}
}
