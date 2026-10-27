using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A4 RID: 18084
	[NullableContext(1)]
	[Nullable(0)]
	public class ImmersiveMouseModule
	{
		// Token: 0x0602E9FA RID: 190970 RVA: 0x00ACB454 File Offset: 0x00AC9654
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

		// Token: 0x0602E9FB RID: 190971 RVA: 0x00ACB504 File Offset: 0x00AC9704
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

		// Token: 0x0602E9FC RID: 190972 RVA: 0x00ACB594 File Offset: 0x00AC9794
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

		// Token: 0x0602E9FD RID: 190973 RVA: 0x00ACB624 File Offset: 0x00AC9824
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

		// Token: 0x0602E9FE RID: 190974 RVA: 0x00ACB69B File Offset: 0x00AC989B
		public bool IsImmersiveModeEnabled()
		{
			return this.ImmersiveModeEnabled;
		}

		// Token: 0x0602E9FF RID: 190975 RVA: 0x00ACB6A3 File Offset: 0x00AC98A3
		public bool IsImmersiveInputPaused()
		{
			return this.PauseReasonSet.Count > 0;
		}

		// Token: 0x0602EA00 RID: 190976 RVA: 0x00ACB6B3 File Offset: 0x00AC98B3
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

		// Token: 0x0602EA01 RID: 190977 RVA: 0x00ACB6F3 File Offset: 0x00AC98F3
		public void ResumeImmersiveMode(EImmersiveMouseModeReason reason)
		{
			this.PauseReasonSet.Remove(reason);
			EventSystem.Instance.Emit(EEventName.RefreshCursor);
		}

		// Token: 0x0602EA02 RID: 190978 RVA: 0x00ACB714 File Offset: 0x00AC9914
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

		// Token: 0x0602EA03 RID: 190979 RVA: 0x00ACB82F File Offset: 0x00AC9A2F
		public void Reset()
		{
			this.MouseIdleTime = 0f;
		}

		// Token: 0x0602EA04 RID: 190980 RVA: 0x00ACB83C File Offset: 0x00AC9A3C
		private void OnClickedMouse(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (this.ImmersiveModeEnabled && this.CurrentInputMainType == EInputControllerMainType.Keyboard && !InputManager.Instance.GetImmersiveInputWakeState())
			{
				InputManager.Instance.SetShowCursor(true, true);
				this.MouseIdleTime = 0f;
				InputManager.Instance.SetImmersiveInputWakeState(this.CurrentInputMainType, true);
			}
		}

		// Token: 0x0602EA05 RID: 190981 RVA: 0x00ACB890 File Offset: 0x00AC9A90
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

		// Token: 0x0602EA06 RID: 190982 RVA: 0x00ACB8C8 File Offset: 0x00AC9AC8
		private bool CheckMouseInViewport()
		{
			float num = 0f;
			float num2 = 0f;
			return Global.PlayerController.GetMousePosition(ref num, ref num2);
		}

		// Token: 0x0602EA07 RID: 190983 RVA: 0x00ACB8F0 File Offset: 0x00AC9AF0
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

		// Token: 0x0602EA08 RID: 190984 RVA: 0x00ACB9A0 File Offset: 0x00AC9BA0
		private void ApplyImmersiveMouseConfig(EUiViewName viewName)
		{
			ImmersiveMouse immersiveMouseViewConfigByViewName = ImmersiveMouseConfig.Instance.GetImmersiveMouseViewConfigByViewName(viewName);
			this.AutoHideMouseDelay = immersiveMouseViewConfigByViewName.AutoHideTime;
			this.DeadZone = immersiveMouseViewConfigByViewName.DeadZone;
		}

		// Token: 0x0602EA09 RID: 190985 RVA: 0x00ACB9D3 File Offset: 0x00AC9BD3
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

		// Token: 0x0602EA0A RID: 190986 RVA: 0x00ACBA03 File Offset: 0x00AC9C03
		public bool IsFunctionEnabled()
		{
			return this.FunctionEnabled;
		}

		// Token: 0x0602EA0B RID: 190987 RVA: 0x00ACBA0B File Offset: 0x00AC9C0B
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (this.CurrentInputMainType == now)
			{
				return;
			}
			this.CurrentInputMainType = now;
			this.UpdateInputBindings();
		}

		// Token: 0x0602EA0C RID: 190988 RVA: 0x00ACBA24 File Offset: 0x00AC9C24
		private void UpdateInputBindings()
		{
			if (!this.ImmersiveModeEnabled)
			{
				return;
			}
			this.UnbindAllInputListeners();
			this.BindInputListeners();
		}

		// Token: 0x0602EA0D RID: 190989 RVA: 0x00ACBA3C File Offset: 0x00AC9C3C
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

		// Token: 0x0602EA0E RID: 190990 RVA: 0x00ACBAA0 File Offset: 0x00AC9CA0
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

		// Token: 0x0602EA0F RID: 190991 RVA: 0x00ACBB00 File Offset: 0x00AC9D00
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

		// Token: 0x0602EA10 RID: 190992 RVA: 0x00ACBB4D File Offset: 0x00AC9D4D
		private void OnTouchInput(string arg1, InputDistributeDefine.ITouchData arg2, InputIdentification arg3)
		{
			this.OnAnyInput();
		}

		// Token: 0x0602EA11 RID: 190993 RVA: 0x00ACBB58 File Offset: 0x00AC9D58
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

		// Token: 0x0602EA12 RID: 190994 RVA: 0x00ACBBBC File Offset: 0x00AC9DBC
		private bool HasAnyInput()
		{
			return this.CurrentInputMainType == EInputControllerMainType.Keyboard && (this.CheckMousePress() || this.CheckMouseMove());
		}

		// Token: 0x0602EA13 RID: 190995 RVA: 0x00ACBBDC File Offset: 0x00AC9DDC
		private bool CheckMouseMove()
		{
			float value = 0f;
			float value2 = 0f;
			Global.PlayerController.GetInputMouseDelta(ref value, ref value2);
			return Math.Abs(value) + Math.Abs(value2) > this.DeadZone;
		}

		// Token: 0x0401965E RID: 104030
		private bool ImmersiveModeEnabled;

		// Token: 0x0401965F RID: 104031
		private float DeadZone = 0.1f;

		// Token: 0x04019660 RID: 104032
		private int AutoHideMouseDelay = 3000;

		// Token: 0x04019661 RID: 104033
		private float MouseIdleTime;

		// Token: 0x04019662 RID: 104034
		private int TickId = -1;

		// Token: 0x04019663 RID: 104035
		private readonly string[] MouseInputActionList = new string[]
		{
			"UI左键点击",
			"UI右键点击"
		};

		// Token: 0x04019664 RID: 104036
		private readonly ELayerType[] ImmersiveMouseViewLayerList = new ELayerType[]
		{
			ELayerType.Pop,
			ELayerType.Loading,
			ELayerType.Plot,
			ELayerType.Normal
		};

		// Token: 0x04019665 RID: 104037
		private readonly HashSet<EUiViewName> ImmersiveMouseViewSet = new HashSet<EUiViewName>();

		// Token: 0x04019666 RID: 104038
		private bool IsInitialized;

		// Token: 0x04019667 RID: 104039
		private EUiViewName? TopView;

		// Token: 0x04019668 RID: 104040
		private readonly HashSet<EImmersiveMouseModeReason> PauseReasonSet = new HashSet<EImmersiveMouseModeReason>();

		// Token: 0x04019669 RID: 104041
		private bool FunctionEnabled = true;

		// Token: 0x0401966A RID: 104042
		private bool IsMouseInViewport;

		// Token: 0x0401966B RID: 104043
		private EInputControllerMainType CurrentInputMainType;

		// Token: 0x0401966C RID: 104044
		private bool IsGamepadInputBound;

		// Token: 0x0401966D RID: 104045
		private bool IsTouchInputBound;

		// Token: 0x0401966E RID: 104046
		private readonly HashSet<string> GamepadIgnoreKeySet = new HashSet<string>();
	}
}
