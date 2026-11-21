using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063FC RID: 25596
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerInputHandle
	{
		// Token: 0x0603E128 RID: 254248 RVA: 0x01201DF0 File Offset: 0x011FFFF0
		public void Initialize()
		{
			this.CombinationActionHandle = new CombinationActionHandle();
			this.CombinationAxisHandle = new CombinationAxisHandle();
			if (Info.Instance.AxisInputOptimize)
			{
				EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
			}
			EventSystem.Instance.Add(EEventName.MobileGamepadDisconnect, new Action(this.OnMobileGamepadDisconnect));
			EventSystem.Instance.Add<string>(EEventName.ClearAxisInputCache, new Action<string>(this.OnClearAxisInputCache));
			EventSystem.Instance.Add(EEventName.DisableCustomInputData, new Action<string>(this.OnDisableCustomInputData));
			EventSystem.Instance.Add(EEventName.EnableCacheCustomInputData, new Action<string>(this.OnEnableCacheCustomInputData));
			EventSystem.Instance.Add(EEventName.EnableActionRecord, new Action<bool>(this.OnEnableActionRecord));
		}

		// Token: 0x0603E129 RID: 254249 RVA: 0x01201EC8 File Offset: 0x012000C8
		public void Clear()
		{
			CombinationActionHandle combinationActionHandle = this.CombinationActionHandle;
			if (combinationActionHandle != null)
			{
				combinationActionHandle.Clear();
			}
			this.CombinationActionHandle = null;
			CombinationAxisHandle combinationAxisHandle = this.CombinationAxisHandle;
			if (combinationAxisHandle != null)
			{
				combinationAxisHandle.Clear();
			}
			this.CombinationAxisHandle = null;
			this.AlwaysTickAxisValueMap.Clear();
			this.CustomKeyActionData.Clear();
			if (Info.Instance.AxisInputOptimize)
			{
				EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursor));
			}
			EventSystem.Instance.Remove(EEventName.MobileGamepadDisconnect, new Action(this.OnMobileGamepadDisconnect));
			EventSystem.Instance.Remove(EEventName.ClearAxisInputCache, new Action<string>(this.OnClearAxisInputCache));
			EventSystem.Instance.Remove(EEventName.DisableCustomInputData, new Action<string>(this.OnDisableCustomInputData));
			EventSystem.Instance.Remove(EEventName.EnableCacheCustomInputData, new Action<string>(this.OnEnableCacheCustomInputData));
			EventSystem.Instance.Remove(EEventName.EnableActionRecord, new Action<bool>(this.OnEnableActionRecord));
		}

		// Token: 0x0603E12A RID: 254250 RVA: 0x01201FCF File Offset: 0x012001CF
		private void OnShowMouseCursor(bool value)
		{
			if (this.LastShowMouseCursor != value)
			{
				this.LastShowMouseCursor = value;
				if (value)
				{
					this.LastFrameShowMouseCursor = true;
				}
			}
		}

		// Token: 0x0603E12B RID: 254251 RVA: 0x01201FEC File Offset: 0x012001EC
		private void OnMobileGamepadDisconnect()
		{
			Log.Instance.Info(ELogModule.MobileInputSwitch, ELogAuthor.XXJ, "手柄断开,清理输入缓存", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (KeyValuePair<string, float> keyValuePair in this.AlwaysTickAxisValueMap)
			{
				InputDistributeController.Instance.InputAxis(keyValuePair.Key, 0f, false);
			}
			this.AlwaysTickAxisValueMap.Clear();
			foreach (KeyValuePair<string, float> keyValuePair2 in this.OptimizeTickAxisValueMap)
			{
				InputDistributeController.Instance.InputAxis(keyValuePair2.Key, 0f, false);
			}
			this.OptimizeTickAxisValueMap.Clear();
		}

		// Token: 0x0603E12C RID: 254252 RVA: 0x012020D8 File Offset: 0x012002D8
		private void OnClearAxisInputCache(string axisName)
		{
			this.AlwaysTickAxisValueMap.Remove(axisName);
			this.OptimizeTickAxisValueMap.Remove(axisName);
			InputDistributeController.Instance.InputAxis(axisName, 0f, true);
		}

		// Token: 0x0603E12D RID: 254253 RVA: 0x01202108 File Offset: 0x01200308
		public void Tick(float delta)
		{
			CombinationAxisHandle combinationAxisHandle = this.CombinationAxisHandle;
			if (combinationAxisHandle != null)
			{
				combinationAxisHandle.Tick(delta);
			}
			if (Info.Instance.AxisInputOptimize)
			{
				if (this.LastFrameShowMouseCursor)
				{
					this.LastFrameShowMouseCursor = false;
					foreach (KeyValuePair<string, float> keyValuePair in this.AlwaysTickAxisValueMap)
					{
						InputDistributeController.Instance.InputAxis(keyValuePair.Key, 0f, false);
					}
					using (Dictionary<string, float>.Enumerator enumerator = this.OptimizeTickAxisValueMap.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, float> keyValuePair2 = enumerator.Current;
							InputDistributeController.Instance.InputAxis(keyValuePair2.Key, 0f, false);
						}
						return;
					}
				}
				foreach (KeyValuePair<string, float> keyValuePair3 in this.AlwaysTickAxisValueMap)
				{
					InputDistributeController.Instance.InputAxis(keyValuePair3.Key, keyValuePair3.Value, false);
				}
				if (InputModel.GetOrCreateInstance().LastClearAxisValue)
				{
					foreach (KeyValuePair<string, float> keyValuePair4 in this.OptimizeTickAxisValueMap)
					{
						InputDistributeController.Instance.InputAxis(keyValuePair4.Key, keyValuePair4.Value, true);
					}
					InputModel.Instance.ResetLastTemporaryClearAxisValues();
				}
			}
		}

		// Token: 0x0603E12E RID: 254254 RVA: 0x012022B4 File Offset: 0x012004B4
		public unsafe void InputAction(string actionName, bool bPress, FKey key)
		{
			bool flag = actionName == "通用交互" && Info.Instance.IsInGamepad();
			if (!this.CustomKeyActionData.IsActionEnable(actionName))
			{
				if (flag)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Input;
					ELogAuthor author = ELogAuthor.CFT;
					string message = "[破弱排查]1 通用交互被拦截: CustomKeyActionData.IsActionEnable为false";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bPress", bPress);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				return;
			}
			string text = key.KeyName.ToString();
			if (!this.CanInputActionOnMobilePlatform(text))
			{
				if (flag)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Input;
					ELogAuthor author2 = ELogAuthor.CFT;
					string message2 = "[破弱排查]2 通用交互被拦截: CanInputActionOnMobilePlatform为false";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bPress", bPress);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", text);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return;
			}
			if (!this.IsInputActionSameAsInputType(text))
			{
				if (flag)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Input;
					ELogAuthor author3 = ELogAuthor.CFT;
					string message3 = "[破弱排查]2 通用交互被拦截: IsInputActionSameAsInputType为false(按键与当前输入设备类型不一致)";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("bPress", bPress);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", text);
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				return;
			}
			if (this.IsRecording)
			{
				EventSystem.Instance.Emit<string, bool, FKey>(EEventName.CharInputAction, actionName, bPress, key);
			}
			if (!this.CheckCombinationAction(actionName) || this.IsKeyBlockedByCombination(text))
			{
				if (flag)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Input;
					ELogAuthor author4 = ELogAuthor.CFT;
					string message4 = "[破弱排查]3 通用交互被组合键拦截";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("bPress", bPress);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("key", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("CheckCombinationAction", this.CheckCombinationAction(actionName));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("IsKeyBlockedByCombination", this.IsKeyBlockedByCombination(text));
					instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
				}
				this.HandleInputActionInCombinationAction(actionName, bPress);
				return;
			}
			if (flag)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.Input;
				ELogAuthor author5 = ELogAuthor.CFT;
				string message5 = "[破弱排查]通用交互进入InputDistribute";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("bPress", bPress);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("key", text);
				instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
			}
			InputDistributeController.Instance.InputAction(actionName, bPress);
		}

		// Token: 0x0603E12F RID: 254255 RVA: 0x01202540 File Offset: 0x01200740
		public void InputAxis(string axisName, float value, bool alwaysTick = false)
		{
			if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInTouch())
			{
				return;
			}
			CombinationAxisHandle combinationAxisHandle = this.CombinationAxisHandle;
			if (combinationAxisHandle == null || combinationAxisHandle.CheckCombinationAxis(axisName))
			{
				CombinationActionHandle combinationActionHandle = this.CombinationActionHandle;
				if ((combinationActionHandle == null || combinationActionHandle.CheckCombinationActionByAxisName(axisName)) && !this.IsAxisBlockedByCombination(axisName))
				{
					if (!Info.Instance.AxisInputOptimize)
					{
						InputDistributeController.Instance.InputAxis(axisName, value, false);
						return;
					}
					if (alwaysTick)
					{
						this.AlwaysTickAxisValueMap[axisName] = value;
						return;
					}
					this.OptimizeTickAxisValueMap[axisName] = value;
					InputDistributeController.Instance.InputAxis(axisName, value, false);
					return;
				}
			}
			this.HandleInputAxisInCombinationAxis(axisName, value, alwaysTick);
		}

		// Token: 0x0603E130 RID: 254256 RVA: 0x012025E8 File Offset: 0x012007E8
		public void TouchBegin(ETouchIndex touchIndex, FVector position)
		{
			Vector touchPosition = this.SetTouchVector((int)touchIndex, position);
			InputDistributeDefine.TouchData touchData = new InputDistributeDefine.TouchData
			{
				TouchType = InputDistributeDefine.ETouchType.TouchBegin,
				TouchId = (int)touchIndex,
				TouchPosition = touchPosition
			};
			TouchFingerManager.Instance.StartTouch((EFingerIndex)touchIndex, position);
			LguiEventSystemManager.Instance.InputTouchTrigger(true, (int)touchIndex, position);
			InputDistributeController.Instance.InputTouch((int)touchIndex, touchData);
		}

		// Token: 0x0603E131 RID: 254257 RVA: 0x01202640 File Offset: 0x01200840
		public void TouchEnd(ETouchIndex touchIndex, FVector position)
		{
			Vector touchPosition = this.SetTouchVector((int)touchIndex, position);
			InputDistributeDefine.TouchData touchData = new InputDistributeDefine.TouchData
			{
				TouchType = InputDistributeDefine.ETouchType.TouchEnd,
				TouchId = (int)touchIndex,
				TouchPosition = touchPosition
			};
			TouchFingerManager.Instance.EndTouch((EFingerIndex)touchIndex);
			LguiEventSystemManager.Instance.InputTouchTrigger(false, (int)touchIndex, position);
			InputDistributeController.Instance.InputTouch((int)touchIndex, touchData);
		}

		// Token: 0x0603E132 RID: 254258 RVA: 0x01202698 File Offset: 0x01200898
		public void TouchMove(ETouchIndex touchIndex, FVector position)
		{
			Vector touchPosition = this.SetTouchVector((int)touchIndex, position);
			InputDistributeDefine.TouchData touchData = new InputDistributeDefine.TouchData
			{
				TouchType = InputDistributeDefine.ETouchType.TouchMove,
				TouchId = (int)touchIndex,
				TouchPosition = touchPosition
			};
			TouchFingerManager.Instance.MoveTouch((EFingerIndex)touchIndex, position);
			LguiEventSystemManager.Instance.InputLguiTouchMove((int)touchIndex, position);
			InputDistributeController.Instance.InputTouch((int)touchIndex, touchData);
		}

		// Token: 0x0603E133 RID: 254259 RVA: 0x012026F0 File Offset: 0x012008F0
		public void PressAnyKey(FKey key)
		{
			if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInTouch() && PlatformModel.Instance.IsKeyFromGamepadKey(key.KeyName.ToString()))
			{
				return;
			}
			string text = key.KeyName.ToString();
			CombinationActionHandle combinationActionHandle = this.CombinationActionHandle;
			if (combinationActionHandle != null)
			{
				combinationActionHandle.PressAnyKey(text);
			}
			CombinationAxisHandle combinationAxisHandle = this.CombinationAxisHandle;
			if (combinationAxisHandle != null)
			{
				combinationAxisHandle.PressAnyKey(text);
			}
			this.TryInputCustomAction(text, true);
			if (this.IsPrintKeyName)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "按下按键";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("KeyName", text);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			InputDistributeController.Instance.InputKey(text, true);
			EventSystem.Instance.Emit<bool, FKey>(EEventName.OnInputAnyKey, true, key);
		}

		// Token: 0x0603E134 RID: 254260 RVA: 0x012027C4 File Offset: 0x012009C4
		public void ReleaseAnyKey(FKey key)
		{
			if (Info.Instance.IsMobileInputModel() && Info.Instance.IsInTouch() && PlatformModel.Instance.IsKeyFromGamepadKey(key.KeyName.ToString()))
			{
				return;
			}
			string text = key.KeyName.ToString();
			CombinationActionHandle combinationActionHandle = this.CombinationActionHandle;
			if (combinationActionHandle != null)
			{
				combinationActionHandle.ReleaseAnyKey(text);
			}
			CombinationAxisHandle combinationAxisHandle = this.CombinationAxisHandle;
			if (combinationAxisHandle != null)
			{
				combinationAxisHandle.ReleaseAnyKey(text);
			}
			this.TryInputCustomAction(text, false);
			if (this.IsPrintKeyName)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputSettings;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "抬起按键";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("KeyName", text);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			InputDistributeController.Instance.InputKey(text, false);
			EventSystem.Instance.Emit<bool, FKey>(EEventName.OnInputAnyKey, false, key);
		}

		// Token: 0x0603E135 RID: 254261 RVA: 0x01202898 File Offset: 0x01200A98
		private void TryInputCustomAction(string keyName, bool bPress)
		{
			IReadOnlySet<string> customActionName = this.CustomKeyActionData.GetCustomActionName(keyName);
			if (customActionName == null)
			{
				return;
			}
			if (!this.CanInputActionOnMobilePlatform(keyName))
			{
				return;
			}
			if (!this.IsInputActionSameAsInputType(keyName))
			{
				return;
			}
			if (bPress && this.IsKeyBlockedByCombination(keyName))
			{
				return;
			}
			foreach (string actionName in customActionName)
			{
				if (!this.CheckCombinationAction(actionName) && bPress)
				{
					break;
				}
				InputDistributeController.Instance.InputAction(actionName, bPress);
			}
		}

		// Token: 0x0603E136 RID: 254262 RVA: 0x01202928 File Offset: 0x01200B28
		private void OnDisableCustomInputData(string reason)
		{
			this.CustomKeyActionData.DisableCustomInputData(reason);
		}

		// Token: 0x0603E137 RID: 254263 RVA: 0x01202936 File Offset: 0x01200B36
		private void OnEnableCacheCustomInputData(string reason)
		{
			this.CustomKeyActionData.EnableCustomInputData(reason);
		}

		// Token: 0x0603E138 RID: 254264 RVA: 0x01202944 File Offset: 0x01200B44
		private void OnEnableActionRecord(bool isRecording)
		{
			this.IsRecording = isRecording;
		}

		// Token: 0x0603E139 RID: 254265 RVA: 0x01202950 File Offset: 0x01200B50
		private bool CanInputActionOnMobilePlatform(string keyName)
		{
			if (Info.Instance.IsMobileInputModel())
			{
				if (InputSettings.Instance.IsKeyboardKey(keyName) || InputSettings.Instance.IsMouseButton(keyName))
				{
					return false;
				}
				if (Info.Instance.IsInTouch() && PlatformModel.Instance.IsKeyFromGamepadKey(keyName))
				{
					return false;
				}
				if (Info.Instance.IsInGamepad() && !PlatformModel.Instance.IsKeyFromGamepadKey(keyName))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603E13A RID: 254266 RVA: 0x012029BC File Offset: 0x01200BBC
		private bool CheckCombinationAction(string actionName)
		{
			CombinationActionHandle combinationActionHandle = this.CombinationActionHandle;
			return combinationActionHandle == null || combinationActionHandle.CheckCombinationAction(actionName);
		}

		// Token: 0x0603E13B RID: 254267 RVA: 0x012029D0 File Offset: 0x01200BD0
		private bool IsKeyBlockedByCombination(string keyName)
		{
			return this.CombinationActionHandle.GetBlockInputKeySet().Contains(keyName) || this.CombinationAxisHandle.GetBlockInputKeySet().Contains(keyName);
		}

		// Token: 0x0603E13C RID: 254268 RVA: 0x012029F8 File Offset: 0x01200BF8
		private bool IsAxisBlockedByCombination(string axisName)
		{
			IReadOnlySet<string> blockInputKeySet = this.CombinationActionHandle.GetBlockInputKeySet();
			IReadOnlySet<string> blockInputKeySet2 = this.CombinationAxisHandle.GetBlockInputKeySet();
			if (blockInputKeySet.Count <= 0 && blockInputKeySet2.Count <= 0)
			{
				return false;
			}
			InputAxisBinding axisBinding = InputSettingsManager.Instance.GetAxisBinding(axisName);
			if (axisBinding == null)
			{
				return false;
			}
			this.BlockCheckKeyNameList.Clear();
			axisBinding.GetKeyNameList(this.BlockCheckKeyNameList);
			foreach (string item in this.BlockCheckKeyNameList)
			{
				if (blockInputKeySet.Contains(item) || blockInputKeySet2.Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E13D RID: 254269 RVA: 0x01202AB8 File Offset: 0x01200CB8
		private void HandleInputActionInCombinationAction(string actionName, bool bPress)
		{
			if (!bPress && InputDistributeModel.Instance.IsActionInPress(actionName))
			{
				InputDistributeController.Instance.InputAction(actionName, false);
			}
		}

		// Token: 0x0603E13E RID: 254270 RVA: 0x01202AD8 File Offset: 0x01200CD8
		private void HandleInputAxisInCombinationAxis(string axisName, float value, bool alwaysTick)
		{
			if (value != 0f)
			{
				if (!InputDistributeModel.Instance.IsAxisInPress(axisName))
				{
					return;
				}
				if (Info.Instance.AxisInputOptimize)
				{
					if (alwaysTick)
					{
						this.AlwaysTickAxisValueMap[axisName] = 0f;
						return;
					}
					this.OptimizeTickAxisValueMap[axisName] = 0f;
					InputDistributeController.Instance.InputAxis(axisName, 0f, false);
					return;
				}
				else
				{
					InputDistributeController.Instance.InputAxis(axisName, 0f, false);
				}
			}
		}

		// Token: 0x0603E13F RID: 254271 RVA: 0x01202B50 File Offset: 0x01200D50
		[NullableContext(2)]
		private Vector GetTouchVector(int touchId)
		{
			Vector result;
			if (!this.TouchVectorMap.TryGetValue(touchId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0603E140 RID: 254272 RVA: 0x01202B70 File Offset: 0x01200D70
		private Vector SetTouchVector(int touchId, FVector ueVector)
		{
			Vector touchVector = this.GetTouchVector(touchId);
			if (touchVector != null)
			{
				touchVector.Set((double)ueVector.X, (double)ueVector.Y, (double)ueVector.Z);
				return touchVector;
			}
			return this.NewTouchVector(touchId, ueVector);
		}

		// Token: 0x0603E141 RID: 254273 RVA: 0x01202BB0 File Offset: 0x01200DB0
		private Vector NewTouchVector(int touchId, FVector ueVector)
		{
			Vector vector = Vector.Create(ueVector);
			this.TouchVectorMap[touchId] = vector;
			return vector;
		}

		// Token: 0x0603E142 RID: 254274 RVA: 0x01202BD8 File Offset: 0x01200DD8
		private bool IsInputActionSameAsInputType(string keyName)
		{
			return Info.Instance.IsGmLockGamepad || ((!Info.Instance.IsInGamepad() || !InputSettings.Instance.IsKeyboardKey(keyName)) && (!Info.Instance.IsInKeyBoard() || !InputSettings.Instance.IsGamepadKey(keyName)));
		}

		// Token: 0x0603E143 RID: 254275 RVA: 0x01202C2A File Offset: 0x01200E2A
		public void SetCustomAction(string keyName, string actionName)
		{
			this.CustomKeyActionData.SetCustomAction(keyName, actionName);
		}

		// Token: 0x0603E144 RID: 254276 RVA: 0x01202C39 File Offset: 0x01200E39
		public void ResetAllCustomAction(string keyName)
		{
			this.TryInputCustomAction(keyName, false);
			this.CustomKeyActionData.ResetAllCustomAction(keyName);
		}

		// Token: 0x0603E145 RID: 254277 RVA: 0x01202C4F File Offset: 0x01200E4F
		public void ResetCustomAction(string keyName, string actionName)
		{
			this.CustomKeyActionData.ResetCustomAction(keyName, actionName);
		}

		// Token: 0x0603E146 RID: 254278 RVA: 0x01202C5E File Offset: 0x01200E5E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> GetCurrentPlatformCustomActionKeyNameList(string actionName)
		{
			return this.CustomKeyActionData.GetCurrentPlatformCustomActionKeyNameList(actionName);
		}

		// Token: 0x0603E147 RID: 254279 RVA: 0x01202C6C File Offset: 0x01200E6C
		public void SetActionEnable(string actionName, bool bEnable)
		{
			this.CustomKeyActionData.SetActionEnable(actionName, bEnable);
		}

		// Token: 0x04020F11 RID: 134929
		private readonly Dictionary<int, Vector> TouchVectorMap = new Dictionary<int, Vector>();

		// Token: 0x04020F12 RID: 134930
		public bool IsPrintKeyName;

		// Token: 0x04020F13 RID: 134931
		public bool IsRecording;

		// Token: 0x04020F14 RID: 134932
		[Nullable(2)]
		private CombinationActionHandle CombinationActionHandle;

		// Token: 0x04020F15 RID: 134933
		[Nullable(2)]
		private CombinationAxisHandle CombinationAxisHandle;

		// Token: 0x04020F16 RID: 134934
		private readonly Dictionary<string, float> AlwaysTickAxisValueMap = new Dictionary<string, float>();

		// Token: 0x04020F17 RID: 134935
		private readonly Dictionary<string, float> OptimizeTickAxisValueMap = new Dictionary<string, float>();

		// Token: 0x04020F18 RID: 134936
		private readonly CustomKeyActionData CustomKeyActionData = new CustomKeyActionData();

		// Token: 0x04020F19 RID: 134937
		private bool LastShowMouseCursor;

		// Token: 0x04020F1A RID: 134938
		private bool LastFrameShowMouseCursor;

		// Token: 0x04020F1B RID: 134939
		private readonly List<string> BlockCheckKeyNameList = new List<string>();
	}
}
