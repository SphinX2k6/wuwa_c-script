using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200462C RID: 17964
	[NullableContext(2)]
	[Nullable(0)]
	public class UiBehaviorModelInput : IUiBehavior
	{
		// Token: 0x0602E44B RID: 189515 RVA: 0x00AB230E File Offset: 0x00AB050E
		[NullableContext(1)]
		public void InitData(IUiModelInputData data)
		{
			this.Data = data;
			this.OnInitData();
		}

		// Token: 0x0602E44C RID: 189516 RVA: 0x00AB2320 File Offset: 0x00AB0520
		public UniTask OnUiCreateAsync()
		{
			UiBehaviorModelInput.<OnUiCreateAsync>d__15 <OnUiCreateAsync>d__;
			<OnUiCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnUiCreateAsync>d__.<>1__state = -1;
			<OnUiCreateAsync>d__.<>t__builder.Start<UiBehaviorModelInput.<OnUiCreateAsync>d__15>(ref <OnUiCreateAsync>d__);
			return <OnUiCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E44D RID: 189517 RVA: 0x00AB235B File Offset: 0x00AB055B
		public void OnAfterUiStart()
		{
		}

		// Token: 0x0602E44E RID: 189518 RVA: 0x00AB235D File Offset: 0x00AB055D
		public void OnAfterUiShow()
		{
			this.AddInputEventListener();
		}

		// Token: 0x0602E44F RID: 189519 RVA: 0x00AB2365 File Offset: 0x00AB0565
		public void OnBeforeUiHide()
		{
			this.ResetInputState();
			this.RemoveInputEventListener();
		}

		// Token: 0x0602E450 RID: 189520 RVA: 0x00AB2373 File Offset: 0x00AB0573
		public void OnBeforeDestroy()
		{
			this.ResetInputState();
			this.RemoveInputEventListener();
			this.Data = null;
			this.InputDataComponent = null;
		}

		// Token: 0x0602E451 RID: 189521 RVA: 0x00AB238F File Offset: 0x00AB058F
		private void OnInitData()
		{
			IUiModelInputData data = this.Data;
			this.InputDataComponent = ((data != null) ? data.ModelBase.CheckGetComponent<UiModelInputDataComponent>() : null);
		}

		// Token: 0x0602E452 RID: 189522 RVA: 0x00AB23B0 File Offset: 0x00AB05B0
		private void ResetInputState()
		{
			this.CurrentDragPosition = null;
			if (this.IsGamepadInputActive)
			{
				this.IsGamepadInputActive = false;
				Action onGamepadInputEnd = this.OnGamepadInputEnd;
				if (onGamepadInputEnd != null)
				{
					onGamepadInputEnd();
				}
			}
			this.CurrentGamepadYaw = 0f;
			this.CurrentGamepadPitch = 0f;
			UiModelInputDataComponent inputDataComponent = this.InputDataComponent;
			if (inputDataComponent != null)
			{
				inputDataComponent.UpdateAxisInput(ERotateAxis.Pitch, 0f);
			}
			UiModelInputDataComponent inputDataComponent2 = this.InputDataComponent;
			if (inputDataComponent2 != null)
			{
				inputDataComponent2.UpdateAxisInput(ERotateAxis.Yaw, 0f);
			}
			UiModelInputDataComponent inputDataComponent3 = this.InputDataComponent;
			if (inputDataComponent3 == null)
			{
				return;
			}
			inputDataComponent3.UpdateAxisInput(ERotateAxis.Roll, 0f);
		}

		// Token: 0x0602E453 RID: 189523 RVA: 0x00AB2444 File Offset: 0x00AB0644
		protected void AddInputEventListener()
		{
			if (this.IsInputEventListening || this.Data == null)
			{
				return;
			}
			UUIDraggableComponent dragComponent = this.Data.DragComponent;
			dragComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
			dragComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
			dragComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
			EventSystem.Instance.Add<float>(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
			this.IsInputEventListening = true;
		}

		// Token: 0x0602E454 RID: 189524 RVA: 0x00AB24F0 File Offset: 0x00AB06F0
		protected void RemoveInputEventListener()
		{
			if (!this.IsInputEventListening || this.Data == null)
			{
				return;
			}
			UUIDraggableComponent dragComponent = this.Data.DragComponent;
			dragComponent.OnPointerBeginDragCallBack.Unbind();
			dragComponent.OnPointerDragCallBack.Unbind();
			dragComponent.OnPointerEndDragCallBack.Unbind();
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleLookUp, new Action<float>(this.OnInputUiLookUp));
			EventSystem.Instance.Remove(EEventName.NavigationTriggerRoleTurn, new Action<float>(this.OnInputUiTurn));
			this.IsInputEventListening = false;
		}

		// Token: 0x0602E455 RID: 189525 RVA: 0x00AB2578 File Offset: 0x00AB0778
		private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanModelInput)
			{
				return;
			}
			this.CurrentDragPosition = ((eventData != null) ? new FVector?(eventData.GetLocalPointInPlane()) : null);
			Action onDragBegin = this.OnDragBegin;
			if (onDragBegin == null)
			{
				return;
			}
			onDragBegin();
		}

		// Token: 0x0602E456 RID: 189526 RVA: 0x00AB25C0 File Offset: 0x00AB07C0
		private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
		{
			if (!this.CanModelInput || TouchFingerManager.Instance.GetTouchFingerCount() > 1)
			{
				this.CurrentDragPosition = null;
				this.ResetRotateAxisInput();
				return;
			}
			FVector? currentDragPosition = this.CurrentDragPosition;
			this.CurrentDragPosition = ((eventData != null) ? new FVector?(eventData.GetLocalPointInPlane()) : null);
			if (currentDragPosition == null || this.CurrentDragPosition == null)
			{
				return;
			}
			float value = this.CurrentDragPosition.Value.X - currentDragPosition.Value.X;
			float value2 = this.CurrentDragPosition.Value.Y - currentDragPosition.Value.Y;
			UiModelInputDataComponent inputDataComponent = this.InputDataComponent;
			if (inputDataComponent != null)
			{
				inputDataComponent.UpdateAxisInput(ERotateAxis.Yaw, this.FilterDragAxisInput(value));
			}
			UiModelInputDataComponent inputDataComponent2 = this.InputDataComponent;
			if (inputDataComponent2 == null)
			{
				return;
			}
			inputDataComponent2.UpdateAxisInput(ERotateAxis.Pitch, this.FilterDragAxisInput(value2));
		}

		// Token: 0x0602E457 RID: 189527 RVA: 0x00AB269F File Offset: 0x00AB089F
		private void OnPointerEndDragCallBack(ULGUIPointerEventData _)
		{
			if (!this.CanModelInput)
			{
				return;
			}
			this.CurrentDragPosition = null;
			this.ResetRotateAxisInput();
			Action onDragEnd = this.OnDragEnd;
			if (onDragEnd == null)
			{
				return;
			}
			onDragEnd();
		}

		// Token: 0x0602E458 RID: 189528 RVA: 0x00AB26CC File Offset: 0x00AB08CC
		private void OnInputUiLookUp(float value)
		{
			if (!this.CanModelInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.CurrentGamepadPitch = this.FilterGamepadAxisInput(value);
			UiModelInputDataComponent inputDataComponent = this.InputDataComponent;
			if (inputDataComponent != null)
			{
				inputDataComponent.UpdateAxisInput(ERotateAxis.Pitch, this.CurrentGamepadPitch);
			}
			this.UpdateGamepadInputState();
		}

		// Token: 0x0602E459 RID: 189529 RVA: 0x00AB271C File Offset: 0x00AB091C
		private void OnInputUiTurn(float value)
		{
			if (!this.CanModelInput || !Info.Instance.IsInGamepad())
			{
				return;
			}
			this.CurrentGamepadYaw = this.FilterGamepadAxisInput(value);
			UiModelInputDataComponent inputDataComponent = this.InputDataComponent;
			if (inputDataComponent != null)
			{
				inputDataComponent.UpdateAxisInput(ERotateAxis.Yaw, this.CurrentGamepadYaw);
			}
			this.UpdateGamepadInputState();
		}

		// Token: 0x0602E45A RID: 189530 RVA: 0x00AB2769 File Offset: 0x00AB0969
		private float FilterGamepadAxisInput(float value)
		{
			if (Math.Abs(value) >= 0.1f)
			{
				return value;
			}
			return 0f;
		}

		// Token: 0x0602E45B RID: 189531 RVA: 0x00AB277F File Offset: 0x00AB097F
		private float FilterDragAxisInput(float value)
		{
			if (Math.Abs(value) >= 1f)
			{
				return value;
			}
			return 0f;
		}

		// Token: 0x0602E45C RID: 189532 RVA: 0x00AB2798 File Offset: 0x00AB0998
		private void UpdateGamepadInputState()
		{
			bool flag = this.CurrentGamepadYaw != 0f || this.CurrentGamepadPitch != 0f;
			if (!flag || this.IsGamepadInputActive)
			{
				if (!flag && this.IsGamepadInputActive)
				{
					this.IsGamepadInputActive = false;
					Action onGamepadInputEnd = this.OnGamepadInputEnd;
					if (onGamepadInputEnd == null)
					{
						return;
					}
					onGamepadInputEnd();
				}
				return;
			}
			this.IsGamepadInputActive = true;
			Action onGamepadInputBegin = this.OnGamepadInputBegin;
			if (onGamepadInputBegin == null)
			{
				return;
			}
			onGamepadInputBegin();
		}

		// Token: 0x0602E45D RID: 189533 RVA: 0x00AB280B File Offset: 0x00AB0A0B
		private void ResetRotateAxisInput()
		{
			UiModelInputDataComponent inputDataComponent = this.InputDataComponent;
			if (inputDataComponent != null)
			{
				inputDataComponent.UpdateAxisInput(ERotateAxis.Yaw, 0f);
			}
			UiModelInputDataComponent inputDataComponent2 = this.InputDataComponent;
			if (inputDataComponent2 == null)
			{
				return;
			}
			inputDataComponent2.UpdateAxisInput(ERotateAxis.Pitch, 0f);
		}

		// Token: 0x04018D55 RID: 101717
		private const float GamepadAxisDeadZone = 0.1f;

		// Token: 0x04018D56 RID: 101718
		private const float DragAxisThreshold = 1f;

		// Token: 0x04018D57 RID: 101719
		private IUiModelInputData Data;

		// Token: 0x04018D58 RID: 101720
		private UiModelInputDataComponent InputDataComponent;

		// Token: 0x04018D59 RID: 101721
		private FVector? CurrentDragPosition;

		// Token: 0x04018D5A RID: 101722
		private bool IsInputEventListening;

		// Token: 0x04018D5B RID: 101723
		private bool IsGamepadInputActive;

		// Token: 0x04018D5C RID: 101724
		private float CurrentGamepadYaw;

		// Token: 0x04018D5D RID: 101725
		private float CurrentGamepadPitch;

		// Token: 0x04018D5E RID: 101726
		public bool CanModelInput = true;

		// Token: 0x04018D5F RID: 101727
		public Action OnDragBegin;

		// Token: 0x04018D60 RID: 101728
		public Action OnDragEnd;

		// Token: 0x04018D61 RID: 101729
		public Action OnGamepadInputBegin;

		// Token: 0x04018D62 RID: 101730
		public Action OnGamepadInputEnd;
	}
}
