using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D5 RID: 13781
	[NullableContext(1)]
	[Nullable(0)]
	public class ImmersiveMouseModule
	{
		// Token: 0x06023146 RID: 143686 RVA: 0x009F9D28 File Offset: 0x009F7F28
		public void Initialize()
		{
			if (this.IsInitialized)
			{
				return;
			}
			this.IsInitialized = true;
			this.Reset();
			foreach (ImmersiveMouse immersiveMouse in ImmersiveMouseConfig.Instance.GetAllImmersiveMouseViewConfig())
			{
				this.ImmersiveMouseViewSet.Add((EUiViewName)immersiveMouse.ViewName);
			}
			this.InitGamepadIgnoreKeys();
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
			this.CurrentInputMainType = Info.Instance.InputControllerMainType;
			this.UpdateInputBindings();
		}

		// Token: 0x06023147 RID: 143687 RVA: 0x009F9DD8 File Offset: 0x009F7FD8
		private void InitGamepadIgnoreKeys()
		{
			this.GamepadIgnoreKeySet.Clear();
			foreach (string actionName in new string[]
			{
				"UI键盘F手柄A",
				"UI返回"
			})
			{
				foreach (string item in UiNavigationModel.Instance.GetGamepadKeyNameListByActionName(actionName))
				{
					this.GamepadIgnoreKeySet.Add(item);
				}
			}
		}

		// Token: 0x06023148 RID: 143688 RVA: 0x009F9E68 File Offset: 0x009F8068
		public void EnableImmersiveMode()
		{
			if (this.ImmersiveModeEnabled || !this.FunctionEnabled)
			{
				return;
			}
			this.ImmersiveModeEnabled = true;
			Ticker ticker = TickSystem.Instance.Add(new Action<float>(this.Tick), "ImmersiveMouseModule", ETickingGroup.TG_PrePhysics, true, 0, true);
			this.TickId = ticker.Id;
			InputDistributeController.Instance.BindActions(this.MouseInputActionList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnClickedMouse));
			this.IsMouseInViewport = this.CheckMouseInViewport();
			this.BindInputListeners();
			InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, true);
		}

		// Token: 0x06023149 RID: 143689 RVA: 0x009F9EF8 File Offset: 0x009F80F8
		public void DisableImmersiveMode()
		{
			if (!this.ImmersiveModeEnabled)
			{
				return;
			}
			this.ImmersiveModeEnabled = false;
			this.Reset();
			if (this.TickId != -1)
			{
				TickSystem.Instance.Remove(this.TickId);
				this.TickId = -1;
			}
			InputDistributeController.Instance.UnBindActions(this.MouseInputActionList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnClickedMouse));
			this.UnbindAllInputListeners();
			InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, false);
		}

		// Token: 0x0602314A RID: 143690 RVA: 0x009F9F6F File Offset: 0x009F816F
		public bool IsImmersiveModeEnabled()
		{
			return this.ImmersiveModeEnabled;
		}

		// Token: 0x0602314B RID: 143691 RVA: 0x009F9F77 File Offset: 0x009F8177
		public bool IsImmersiveInputPaused()
		{
			return this.PauseReasonSet.Count > 0;
		}

		// Token: 0x0602314C RID: 143692 RVA: 0x009F9F87 File Offset: 0x009F8187
		public void PauseImmersiveMode(EImmersiveMouseModeReason reason, bool bReset = true, bool bShowCursor = true)
		{
			this.PauseReasonSet.Add(reason);
			if (!this.ImmersiveModeEnabled)
			{
				return;
			}
			if (bReset)
			{
				this.Reset();
			}
			if (bShowCursor)
			{
				InputManager.Instance.SetShowCursor(true, true);
			}
			EventSystem.Instance.Emit(EEventName.RefreshCursor);
		}

		// Token: 0x0602314D RID: 143693 RVA: 0x009F9FC7 File Offset: 0x009F81C7
		public void ResumeImmersiveMode(EImmersiveMouseModeReason reason)
		{
			this.PauseReasonSet.Remove(reason);
			EventSystem.Instance.Emit(EEventName.RefreshCursor);
		}

		// Token: 0x0602314E RID: 143694 RVA: 0x009F9FE8 File Offset: 0x009F81E8
		public void Tick(float deltaTime)
		{
			if (!this.ImmersiveModeEnabled)
			{
				return;
			}
			if (this.PauseReasonSet.Count > 0)
			{
				return;
			}
			if (this.CurrentInputMainType == EInputControllerMainType.Keyboard)
			{
				bool isMouseInViewport = this.IsMouseInViewport;
				this.IsMouseInViewport = this.CheckMouseInViewport();
				if (!this.IsMouseInViewport)
				{
					this.MouseIdleTime = 0f;
					if (isMouseInViewport && !Global.PlayerController.bShowMouseCursor)
					{
						InputManager.Instance.SetShowCursor(true, true);
					}
					return;
				}
			}
			bool flag = this.HasAnyInput();
			if (InputManager.Instance.GetImmersiveInputWakeState())
			{
				if (flag)
				{
					this.MouseIdleTime = 0f;
					if (!Global.PlayerController.bShowMouseCursor)
					{
						InputManager.Instance.SetShowCursor(true, true);
						return;
					}
				}
				else
				{
					this.MouseIdleTime += deltaTime;
					if (this.MouseIdleTime >= (float)this.AutoHideMouseDelay)
					{
						InputManager.Instance.SetShowCursor(false, true);
						this.MouseIdleTime = 0f;
						InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, false);
						return;
					}
				}
			}
			else if (flag)
			{
				InputManager.Instance.SetShowCursor(true, true);
				this.MouseIdleTime = 0f;
				InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, true);
			}
		}

		// Token: 0x0602314F RID: 143695 RVA: 0x009FA103 File Offset: 0x009F8303
		public void Reset()
		{
			this.MouseIdleTime = 0f;
		}

		// Token: 0x06023150 RID: 143696 RVA: 0x009FA110 File Offset: 0x009F8310
		private void OnClickedMouse(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (this.ImmersiveModeEnabled && this.CurrentInputMainType == EInputControllerMainType.Keyboard && !InputManager.Instance.GetImmersiveInputWakeState())
			{
				InputManager.Instance.SetShowCursor(true, true);
				this.MouseIdleTime = 0f;
				InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, true);
			}
		}

		// Token: 0x06023151 RID: 143697 RVA: 0x009FA164 File Offset: 0x009F8364
		private bool CheckMousePress()
		{
			foreach (string actionName in this.MouseInputActionList)
			{
				if (InputDistributeModel.Instance.IsActionInPress(actionName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06023152 RID: 143698 RVA: 0x009FA19C File Offset: 0x009F839C
		private bool CheckMouseInViewport()
		{
			float num = 0f;
			float num2 = 0f;
			return Global.PlayerController.GetMousePosition(ref num, ref num2);
		}

		// Token: 0x06023153 RID: 143699 RVA: 0x009FA1C4 File Offset: 0x009F83C4
		public void RefreshMouseImmersiveMode()
		{
			UiViewBase uiViewBase = null;
			foreach (ELayerType layer in this.ImmersiveMouseViewLayerList)
			{
				uiViewBase = UiModel.Instance.GetTopView(layer);
				if (uiViewBase != null)
				{
					break;
				}
			}
			if (uiViewBase == null)
			{
				return;
			}
			EUiViewName name = uiViewBase.ViewInfo.Name;
			if (name == this.TopView)
			{
				return;
			}
			this.TopView = new EUiViewName?(name);
			if (this.ImmersiveMouseViewSet.Contains(name))
			{
				this.ApplyImmersiveMouseConfig(name);
				if (!this.ImmersiveModeEnabled)
				{
					this.EnableImmersiveMode();
					return;
				}
			}
			else if (this.ImmersiveModeEnabled)
			{
				this.DisableImmersiveMode();
			}
		}

		// Token: 0x06023154 RID: 143700 RVA: 0x009FA274 File Offset: 0x009F8474
		private void ApplyImmersiveMouseConfig(EUiViewName viewName)
		{
			ImmersiveMouse immersiveMouseViewConfigByViewName = ImmersiveMouseConfig.Instance.GetImmersiveMouseViewConfigByViewName(viewName);
			this.AutoHideMouseDelay = immersiveMouseViewConfigByViewName.AutoHideTime;
			this.DeadZone = immersiveMouseViewConfigByViewName.DeadZone;
		}

		// Token: 0x06023155 RID: 143701 RVA: 0x009FA2A7 File Offset: 0x009F84A7
		public void SetFunctionEnabled(bool bEnabled, bool bReset = true, bool bShowCursor = true)
		{
			this.FunctionEnabled = bEnabled;
			if (!this.FunctionEnabled)
			{
				this.DisableImmersiveMode();
				return;
			}
			if (bReset)
			{
				this.Reset();
			}
			if (bShowCursor)
			{
				InputManager.Instance.SetShowCursor(true, true);
			}
		}

		// Token: 0x06023156 RID: 143702 RVA: 0x009FA2D7 File Offset: 0x009F84D7
		public bool IsFunctionEnabled()
		{
			return this.FunctionEnabled;
		}

		// Token: 0x06023157 RID: 143703 RVA: 0x009FA2DF File Offset: 0x009F84DF
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (this.CurrentInputMainType == now)
			{
				return;
			}
			this.CurrentInputMainType = now;
			this.UpdateInputBindings();
		}

		// Token: 0x06023158 RID: 143704 RVA: 0x009FA2F8 File Offset: 0x009F84F8
		private void UpdateInputBindings()
		{
			if (!this.ImmersiveModeEnabled)
			{
				return;
			}
			this.UnbindAllInputListeners();
			this.BindInputListeners();
		}

		// Token: 0x06023159 RID: 143705 RVA: 0x009FA310 File Offset: 0x009F8510
		private void BindInputListeners()
		{
			if (this.CurrentInputMainType == EInputControllerMainType.Gamepad)
			{
				EventSystem.Instance.Add(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnGamepadAnyKey));
				this.IsGamepadInputBound = true;
				return;
			}
			if (this.CurrentInputMainType == EInputControllerMainType.Touch)
			{
				InputDistributeController.Instance.BindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchInput));
				this.IsTouchInputBound = true;
			}
		}

		// Token: 0x0602315A RID: 143706 RVA: 0x009FA374 File Offset: 0x009F8574
		private void UnbindAllInputListeners()
		{
			if (this.IsGamepadInputBound)
			{
				EventSystem.Instance.Remove(EEventName.OnInputAnyKey, new Action<bool, FKey>(this.OnGamepadAnyKey));
				this.IsGamepadInputBound = false;
			}
			if (this.IsTouchInputBound)
			{
				InputDistributeController.Instance.UnBindTouch(0, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouchInput));
				this.IsTouchInputBound = false;
			}
		}

		// Token: 0x0602315B RID: 143707 RVA: 0x009FA3D4 File Offset: 0x009F85D4
		private void OnGamepadAnyKey(bool bPress, FKey key)
		{
			if (!bPress)
			{
				return;
			}
			if (!UKismetInputLibrary.Key_IsGamepadKey(key))
			{
				return;
			}
			string text = key.KeyName.ToString();
			if (!string.IsNullOrEmpty(text) && this.GamepadIgnoreKeySet.Contains(text))
			{
				return;
			}
			this.OnAnyInput();
		}

		// Token: 0x0602315C RID: 143708 RVA: 0x009FA421 File Offset: 0x009F8621
		private void OnTouchInput(string arg1, InputDistributeDefine.ITouchData arg2, InputIdentification arg3)
		{
			this.OnAnyInput();
		}

		// Token: 0x0602315D RID: 143709 RVA: 0x009FA42C File Offset: 0x009F862C
		private void OnAnyInput()
		{
			if (!this.ImmersiveModeEnabled || this.PauseReasonSet.Count > 0)
			{
				return;
			}
			if (!InputManager.Instance.GetImmersiveInputWakeState())
			{
				InputManager.Instance.SetShowCursor(true, true);
				this.MouseIdleTime = 0f;
				InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, true);
				return;
			}
			this.MouseIdleTime = 0f;
		}

		// Token: 0x0602315E RID: 143710 RVA: 0x009FA490 File Offset: 0x009F8690
		private bool HasAnyInput()
		{
			return this.CurrentInputMainType == EInputControllerMainType.Keyboard && (this.CheckMousePress() || this.CheckMouseMove());
		}

		// Token: 0x0602315F RID: 143711 RVA: 0x009FA4B0 File Offset: 0x009F86B0
		private bool CheckMouseMove()
		{
			float value = 0f;
			float value2 = 0f;
			Global.PlayerController.GetInputMouseDelta(ref value, ref value2);
			return Math.Abs(value) + Math.Abs(value2) > this.DeadZone;
		}

		// Token: 0x04013D03 RID: 81155
		private bool ImmersiveModeEnabled;

		// Token: 0x04013D04 RID: 81156
		private float DeadZone = 0.1f;

		// Token: 0x04013D05 RID: 81157
		private int AutoHideMouseDelay = 3000;

		// Token: 0x04013D06 RID: 81158
		private float MouseIdleTime;

		// Token: 0x04013D07 RID: 81159
		private int TickId = -1;

		// Token: 0x04013D08 RID: 81160
		private readonly string[] MouseInputActionList = new string[]
		{
			"UI左键点击",
			"UI右键点击"
		};

		// Token: 0x04013D09 RID: 81161
		private readonly ELayerType[] ImmersiveMouseViewLayerList = new ELayerType[]
		{
			ELayerType.Pop,
			ELayerType.Loading,
			ELayerType.Plot,
			ELayerType.Normal
		};

		// Token: 0x04013D0A RID: 81162
		private readonly HashSet<EUiViewName> ImmersiveMouseViewSet = new HashSet<EUiViewName>();

		// Token: 0x04013D0B RID: 81163
		private bool IsInitialized;

		// Token: 0x04013D0C RID: 81164
		private EUiViewName? TopView;

		// Token: 0x04013D0D RID: 81165
		private readonly HashSet<EImmersiveMouseModeReason> PauseReasonSet = new HashSet<EImmersiveMouseModeReason>();

		// Token: 0x04013D0E RID: 81166
		private bool FunctionEnabled = true;

		// Token: 0x04013D0F RID: 81167
		private bool IsMouseInViewport;

		// Token: 0x04013D10 RID: 81168
		private EInputControllerMainType CurrentInputMainType;

		// Token: 0x04013D11 RID: 81169
		private bool IsGamepadInputBound;

		// Token: 0x04013D12 RID: 81170
		private bool IsTouchInputBound;

		// Token: 0x04013D13 RID: 81171
		private readonly HashSet<string> GamepadIgnoreKeySet = new HashSet<string>();
	}
}
