using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072D0 RID: 29392
	[NullableContext(1)]
	[Nullable(0)]
	public class FreeCameraInputComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009F37 RID: 40759
		// (get) Token: 0x060481F7 RID: 295415 RVA: 0x0127FC7C File Offset: 0x0127DE7C
		public static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(FreeCameraLogicComponent)
				};
			}
		}

		// Token: 0x060481F8 RID: 295416 RVA: 0x0127FC91 File Offset: 0x0127DE91
		protected override bool OnStart()
		{
			this.LogicComponent = base.Entity.GetComponent<FreeCameraLogicComponent>();
			this.InitViewportSize();
			return this.LogicComponent != null;
		}

		// Token: 0x060481F9 RID: 295417 RVA: 0x0127FCB4 File Offset: 0x0127DEB4
		private void HandleInputDirty()
		{
			if (this.ForwardData.Distance == 0f && this.RightData.Distance == 0f && this.UpData.Distance == 0f && this.RotateLookUp == 0f && this.RotateTurn == 0f && this.DeltaFov == 0f)
			{
				this.IsInputDirty = false;
			}
		}

		// Token: 0x060481FA RID: 295418 RVA: 0x0127FD28 File Offset: 0x0127DF28
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

		// Token: 0x060481FB RID: 295419 RVA: 0x0127FD90 File Offset: 0x0127DF90
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

		// Token: 0x060481FC RID: 295420 RVA: 0x0127FDF0 File Offset: 0x0127DFF0
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

		// Token: 0x060481FD RID: 295421 RVA: 0x0127FF78 File Offset: 0x0127E178
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

		// Token: 0x060481FE RID: 295422 RVA: 0x012800D4 File Offset: 0x0127E2D4
		private void InitViewportSize()
		{
			this.ViewportSize.X = (double)UiLayer.Instance.UiRootItem.GetWidth();
			this.ViewportSize.Y = (double)UiLayer.Instance.UiRootItem.GetHeight();
		}

		// Token: 0x060481FF RID: 295423 RVA: 0x0128010C File Offset: 0x0127E30C
		protected void InputCameraFov(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraFieldFov(value * 1f);
		}

		// Token: 0x06048200 RID: 295424 RVA: 0x0128011B File Offset: 0x0127E31B
		protected void InputCameraForward(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraMoveForward(value * 10f);
		}

		// Token: 0x06048201 RID: 295425 RVA: 0x0128012A File Offset: 0x0127E32A
		protected void InputCameraRight(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraMoveRight(value * 10f);
		}

		// Token: 0x06048202 RID: 295426 RVA: 0x01280139 File Offset: 0x0127E339
		protected void InputCameraUp(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraMoveUp(value * 10f);
		}

		// Token: 0x06048203 RID: 295427 RVA: 0x01280148 File Offset: 0x0127E348
		protected void InputCameraLookUp(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraRotateLookUp(-value * 3f);
		}

		// Token: 0x06048204 RID: 295428 RVA: 0x01280158 File Offset: 0x0127E358
		protected void InputCameraTurn(string axisName, float value, InputIdentification inputIdentification)
		{
			this.InputCameraRotateTurn(value * 3f);
		}

		// Token: 0x06048205 RID: 295429 RVA: 0x01280167 File Offset: 0x0127E367
		public void InputCameraMoveForward(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.ForwardData.Distance = value;
			this.IsInputDirty = true;
		}

		// Token: 0x06048206 RID: 295430 RVA: 0x01280185 File Offset: 0x0127E385
		public void InputCameraMoveRight(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.RightData.Distance = value;
			this.IsInputDirty = true;
		}

		// Token: 0x06048207 RID: 295431 RVA: 0x012801A3 File Offset: 0x0127E3A3
		public void InputCameraMoveUp(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.UpData.Distance = value;
			this.IsInputDirty = true;
		}

		// Token: 0x06048208 RID: 295432 RVA: 0x012801C1 File Offset: 0x0127E3C1
		public void InputCameraRotateLookUp(float value)
		{
			if (value == 0f && this.RotateLookUp == 0f)
			{
				return;
			}
			this.RotateLookUp = value;
			this.IsInputDirty = true;
		}

		// Token: 0x06048209 RID: 295433 RVA: 0x012801E7 File Offset: 0x0127E3E7
		public void InputCameraRotateTurn(float value)
		{
			if (value == 0f && this.RotateTurn == 0f)
			{
				return;
			}
			this.RotateTurn = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0604820A RID: 295434 RVA: 0x0128020D File Offset: 0x0127E40D
		public void InputCameraFieldFov(float value)
		{
			if (value == 0f)
			{
				return;
			}
			this.DeltaFov = value;
			this.IsInputDirty = true;
		}

		// Token: 0x0604820B RID: 295435 RVA: 0x01280226 File Offset: 0x0127E426
		public void SetIsMoveBySelf(bool isMoveBySelf)
		{
			this.ForwardData.IsMoveBySelf = isMoveBySelf;
			this.RightData.IsMoveBySelf = isMoveBySelf;
			this.UpData.IsMoveBySelf = isMoveBySelf;
		}

		// Token: 0x0604820C RID: 295436 RVA: 0x0128024C File Offset: 0x0127E44C
		public void SetUpMoveByWorld()
		{
			this.UpData.IsMoveBySelf = false;
		}

		// Token: 0x0604820D RID: 295437 RVA: 0x0128025A File Offset: 0x0127E45A
		public void SetForwardMoveByWorld()
		{
			this.ForwardData.IsMoveBySelf = false;
		}

		// Token: 0x0604820E RID: 295438 RVA: 0x01280268 File Offset: 0x0127E468
		public void SetRightMoveByWorld()
		{
			this.RightData.IsMoveBySelf = false;
		}

		// Token: 0x0604820F RID: 295439 RVA: 0x01280276 File Offset: 0x0127E476
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

		// Token: 0x06048210 RID: 295440 RVA: 0x012802A4 File Offset: 0x0127E4A4
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

		// Token: 0x06048211 RID: 295441 RVA: 0x0128037C File Offset: 0x0127E57C
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

		// Token: 0x06048212 RID: 295442 RVA: 0x012804AB File Offset: 0x0127E6AB
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

		// Token: 0x06048213 RID: 295443 RVA: 0x012804CF File Offset: 0x0127E6CF
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

		// Token: 0x06048214 RID: 295444 RVA: 0x012804EC File Offset: 0x0127E6EC
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

		// Token: 0x06048215 RID: 295445 RVA: 0x01280524 File Offset: 0x0127E724
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

		// Token: 0x06048216 RID: 295446 RVA: 0x012805A0 File Offset: 0x0127E7A0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			FreeCameraInputComponent freeCameraInputComponent = (FreeCameraInputComponent)componentTemplate;
			if (base.CanResetComponentProperty("LogicComponent"))
			{
				if (freeCameraInputComponent.LogicComponent == null)
				{
					this.LogicComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FreeCameraLogicComponent>(this.LogicComponent), "LogicComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsInputDirty"))
			{
				this.IsInputDirty = freeCameraInputComponent.IsInputDirty;
			}
			if (base.CanResetComponentProperty("ForwardData") && freeCameraInputComponent.ForwardData != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<FreeCameraLogicComponent.ICameraMoveData>(this.ForwardData), "ForwardData"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("RightData") && freeCameraInputComponent.RightData != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<FreeCameraLogicComponent.ICameraMoveData>(this.RightData), "RightData"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("UpData") && freeCameraInputComponent.UpData != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<FreeCameraLogicComponent.ICameraMoveData>(this.UpData), "UpData"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("RotateLookUp"))
			{
				this.RotateLookUp = freeCameraInputComponent.RotateLookUp;
			}
			if (base.CanResetComponentProperty("RotateTurn"))
			{
				this.RotateTurn = freeCameraInputComponent.RotateTurn;
			}
			if (base.CanResetComponentProperty("DeltaFov"))
			{
				this.DeltaFov = freeCameraInputComponent.DeltaFov;
			}
			if (base.CanResetComponentProperty("DragComponent"))
			{
				if (freeCameraInputComponent.DragComponent == null)
				{
					this.DragComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UUIDraggableComponent>(this.DragComponent), "DragComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CurrentDragPosition"))
			{
				this.CurrentDragPosition = freeCameraInputComponent.CurrentDragPosition;
			}
			if (base.CanResetComponentProperty("DragDeltaPos"))
			{
				if (freeCameraInputComponent.DragDeltaPos == null)
				{
					this.DragDeltaPos = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.DragDeltaPos), "DragDeltaPos"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CanCameraInput"))
			{
				this.CanCameraInput = freeCameraInputComponent.CanCameraInput;
			}
			if (base.CanResetComponentProperty("PointerDownTime"))
			{
				this.PointerDownTime = freeCameraInputComponent.PointerDownTime;
			}
			return !base.CanResetComponentProperty("ViewportSize") || freeCameraInputComponent.ViewportSize == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Vector2D>(this.ViewportSize), "ViewportSize");
		}

		// Token: 0x040260CD RID: 155853
		private const int MOVE_STEP = 10;

		// Token: 0x040260CE RID: 155854
		private const int ROTATE_STEP = 3;

		// Token: 0x040260CF RID: 155855
		private const int FOV_STEP = 1;

		// Token: 0x040260D0 RID: 155856
		private const float TWEEN_TIME = 2f;

		// Token: 0x040260D1 RID: 155857
		private const float DRAG_TWEEN_TIME = 0.8f;

		// Token: 0x040260D2 RID: 155858
		[Nullable(2)]
		private FreeCameraLogicComponent LogicComponent;

		// Token: 0x040260D3 RID: 155859
		private bool IsInputDirty;

		// Token: 0x040260D4 RID: 155860
		private readonly FreeCameraLogicComponent.ICameraMoveData ForwardData = new FreeCameraLogicComponent.CameraMoveDataImpl
		{
			Distance = 0f,
			IsMoveBySelf = true
		};

		// Token: 0x040260D5 RID: 155861
		private readonly FreeCameraLogicComponent.ICameraMoveData RightData = new FreeCameraLogicComponent.CameraMoveDataImpl
		{
			Distance = 0f,
			IsMoveBySelf = true
		};

		// Token: 0x040260D6 RID: 155862
		private readonly FreeCameraLogicComponent.ICameraMoveData UpData = new FreeCameraLogicComponent.CameraMoveDataImpl
		{
			Distance = 0f,
			IsMoveBySelf = true
		};

		// Token: 0x040260D7 RID: 155863
		private float RotateLookUp;

		// Token: 0x040260D8 RID: 155864
		private float RotateTurn;

		// Token: 0x040260D9 RID: 155865
		private float DeltaFov;

		// Token: 0x040260DA RID: 155866
		[Nullable(2)]
		private UUIDraggableComponent DragComponent;

		// Token: 0x040260DB RID: 155867
		private FVector? CurrentDragPosition;

		// Token: 0x040260DC RID: 155868
		private Vector2D DragDeltaPos = Vector2D.Create();

		// Token: 0x040260DD RID: 155869
		public bool CanCameraInput;

		// Token: 0x040260DE RID: 155870
		private double PointerDownTime;

		// Token: 0x040260DF RID: 155871
		private readonly Vector2D ViewportSize = Vector2D.Create();
	}
}
