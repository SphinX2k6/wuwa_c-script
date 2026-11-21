using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003556 RID: 13654
	[NullableContext(2)]
	[Nullable(0)]
	public class UiBehaviorModelInput : IUiBehavior
	{
		// Token: 0x06022B5E RID: 142174 RVA: 0x009DF09E File Offset: 0x009DD29E
		[NullableContext(1)]
		public void InitData(IUiModelInputData data)
		{
			this.Data = data;
			this.OnInitData();
		}

		// Token: 0x06022B5F RID: 142175 RVA: 0x009DF0B0 File Offset: 0x009DD2B0
		public UniTask OnUiCreateAsync()
		{
			UiBehaviorModelInput.<OnUiCreateAsync>d__15 <OnUiCreateAsync>d__;
			<OnUiCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnUiCreateAsync>d__.<>1__state = -1;
			<OnUiCreateAsync>d__.<>t__builder.Start<UiBehaviorModelInput.<OnUiCreateAsync>d__15>(ref <OnUiCreateAsync>d__);
			return <OnUiCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022B60 RID: 142176 RVA: 0x009DF0EB File Offset: 0x009DD2EB
		public void OnUiStart()
		{
		}

		// Token: 0x06022B61 RID: 142177 RVA: 0x009DF0ED File Offset: 0x009DD2ED
		public void OnUiShow()
		{
			this.AddInputEventListener();
		}

		// Token: 0x06022B62 RID: 142178 RVA: 0x009DF0F5 File Offset: 0x009DD2F5
		public void OnUiHide()
		{
			this.ResetInputState();
			this.RemoveInputEventListener();
		}

		// Token: 0x06022B63 RID: 142179 RVA: 0x009DF103 File Offset: 0x009DD303
		public void OnDestroy()
		{
			this.ResetInputState();
			this.RemoveInputEventListener();
			this.Data = null;
			this.InputDataComponent = null;
		}

		// Token: 0x06022B64 RID: 142180 RVA: 0x009DF11F File Offset: 0x009DD31F
		private void OnInitData()
		{
			IUiModelInputData data = this.Data;
			this.InputDataComponent = ((data != null) ? data.ModelBase.CheckGetComponent<UiModelInputDataComponent>() : null);
		}

		// Token: 0x06022B65 RID: 142181 RVA: 0x009DF140 File Offset: 0x009DD340
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

		// Token: 0x06022B66 RID: 142182 RVA: 0x009DF1D4 File Offset: 0x009DD3D4
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

		// Token: 0x06022B67 RID: 142183 RVA: 0x009DF280 File Offset: 0x009DD480
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

		// Token: 0x06022B68 RID: 142184 RVA: 0x009DF308 File Offset: 0x009DD508
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

		// Token: 0x06022B69 RID: 142185 RVA: 0x009DF350 File Offset: 0x009DD550
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

		// Token: 0x06022B6A RID: 142186 RVA: 0x009DF42F File Offset: 0x009DD62F
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

		// Token: 0x06022B6B RID: 142187 RVA: 0x009DF45C File Offset: 0x009DD65C
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

		// Token: 0x06022B6C RID: 142188 RVA: 0x009DF4AC File Offset: 0x009DD6AC
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

		// Token: 0x06022B6D RID: 142189 RVA: 0x009DF4F9 File Offset: 0x009DD6F9
		private float FilterGamepadAxisInput(float value)
		{
			if (Math.Abs(value) >= 0.1f)
			{
				return value;
			}
			return 0f;
		}

		// Token: 0x06022B6E RID: 142190 RVA: 0x009DF50F File Offset: 0x009DD70F
		private float FilterDragAxisInput(float value)
		{
			if (Math.Abs(value) >= 1f)
			{
				return value;
			}
			return 0f;
		}

		// Token: 0x06022B6F RID: 142191 RVA: 0x009DF528 File Offset: 0x009DD728
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

		// Token: 0x06022B70 RID: 142192 RVA: 0x009DF59B File Offset: 0x009DD79B
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

		// Token: 0x040133A2 RID: 78754
		private const float GamepadAxisDeadZone = 0.1f;

		// Token: 0x040133A3 RID: 78755
		private const float DragAxisThreshold = 1f;

		// Token: 0x040133A4 RID: 78756
		private IUiModelInputData Data;

		// Token: 0x040133A5 RID: 78757
		private UiModelInputDataComponent InputDataComponent;

		// Token: 0x040133A6 RID: 78758
		private FVector? CurrentDragPosition;

		// Token: 0x040133A7 RID: 78759
		private bool IsInputEventListening;

		// Token: 0x040133A8 RID: 78760
		private bool IsGamepadInputActive;

		// Token: 0x040133A9 RID: 78761
		private float CurrentGamepadYaw;

		// Token: 0x040133AA RID: 78762
		private float CurrentGamepadPitch;

		// Token: 0x040133AB RID: 78763
		public bool CanModelInput = true;

		// Token: 0x040133AC RID: 78764
		public Action OnDragBegin;

		// Token: 0x040133AD RID: 78765
		public Action OnDragEnd;

		// Token: 0x040133AE RID: 78766
		public Action OnGamepadInputBegin;

		// Token: 0x040133AF RID: 78767
		public Action OnGamepadInputEnd;
	}
}
