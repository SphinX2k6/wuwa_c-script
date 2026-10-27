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
	// Token: 0x0200727D RID: 29309
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerInputHandle
	{
		// Token: 0x06047D68 RID: 294248 RVA: 0x012615B0 File Offset: 0x0125F7B0
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

		// Token: 0x06047D69 RID: 294249 RVA: 0x01261688 File Offset: 0x0125F888
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

		// Token: 0x06047D6A RID: 294250 RVA: 0x0126178F File Offset: 0x0125F98F
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

		// Token: 0x06047D6B RID: 294251 RVA: 0x012617AC File Offset: 0x0125F9AC
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

		// Token: 0x06047D6C RID: 294252 RVA: 0x01261898 File Offset: 0x0125FA98
		private void OnClearAxisInputCache(string axisName)
		{
			this.AlwaysTickAxisValueMap.Remove(axisName);
			this.OptimizeTickAxisValueMap.Remove(axisName);
			InputDistributeController.Instance.InputAxis(axisName, 0f, true);
		}

		// Token: 0x06047D6D RID: 294253 RVA: 0x012618C8 File Offset: 0x0125FAC8
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

		// Token: 0x06047D6E RID: 294254 RVA: 0x01261A74 File Offset: 0x0125FC74
		public void InputAction(string actionName, bool bPress, FKey key)
		{
			if (!this.CustomKeyActionData.IsActionEnable(actionName))
			{
				return;
			}
			string keyName = key.KeyName.ToString();
			if (!this.CanInputActionOnMobilePlatform(keyName))
			{
				return;
			}
			if (!this.IsInputActionSameAsInputType(keyName))
			{
				return;
			}
			if (this.IsRecording)
			{
				EventSystem.Instance.Emit<string, bool, FKey>(EEventName.CharInputAction, actionName, bPress, key);
			}
			if (!this.CheckCombinationAction(actionName) || this.IsKeyBlockedByCombination(keyName))
			{
				this.HandleInputActionInCombinationAction(actionName, bPress);
				return;
			}
			InputDistributeController.Instance.InputAction(actionName, bPress);
		}

		// Token: 0x06047D6F RID: 294255 RVA: 0x01261AFC File Offset: 0x0125FCFC
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

		// Token: 0x06047D70 RID: 294256 RVA: 0x01261BA4 File Offset: 0x0125FDA4
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

		// Token: 0x06047D71 RID: 294257 RVA: 0x01261BFC File Offset: 0x0125FDFC
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

		// Token: 0x06047D72 RID: 294258 RVA: 0x01261C54 File Offset: 0x0125FE54
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

		// Token: 0x06047D73 RID: 294259 RVA: 0x01261CAC File Offset: 0x0125FEAC
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

		// Token: 0x06047D74 RID: 294260 RVA: 0x01261D80 File Offset: 0x0125FF80
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

		// Token: 0x06047D75 RID: 294261 RVA: 0x01261E54 File Offset: 0x01260054
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

		// Token: 0x06047D76 RID: 294262 RVA: 0x01261EE4 File Offset: 0x012600E4
		private void OnDisableCustomInputData(string reason)
		{
			this.CustomKeyActionData.DisableCustomInputData(reason);
		}

		// Token: 0x06047D77 RID: 294263 RVA: 0x01261EF2 File Offset: 0x012600F2
		private void OnEnableCacheCustomInputData(string reason)
		{
			this.CustomKeyActionData.EnableCustomInputData(reason);
		}

		// Token: 0x06047D78 RID: 294264 RVA: 0x01261F00 File Offset: 0x01260100
		private void OnEnableActionRecord(bool isRecording)
		{
			this.IsRecording = isRecording;
		}

		// Token: 0x06047D79 RID: 294265 RVA: 0x01261F0C File Offset: 0x0126010C
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

		// Token: 0x06047D7A RID: 294266 RVA: 0x01261F78 File Offset: 0x01260178
		private bool CheckCombinationAction(string actionName)
		{
			CombinationActionHandle combinationActionHandle = this.CombinationActionHandle;
			return combinationActionHandle == null || combinationActionHandle.CheckCombinationAction(actionName);
		}

		// Token: 0x06047D7B RID: 294267 RVA: 0x01261F8C File Offset: 0x0126018C
		private bool IsKeyBlockedByCombination(string keyName)
		{
			return this.CombinationActionHandle.GetBlockInputKeySet().Contains(keyName) || this.CombinationAxisHandle.GetBlockInputKeySet().Contains(keyName);
		}

		// Token: 0x06047D7C RID: 294268 RVA: 0x01261FB4 File Offset: 0x012601B4
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

		// Token: 0x06047D7D RID: 294269 RVA: 0x01262074 File Offset: 0x01260274
		private void HandleInputActionInCombinationAction(string actionName, bool bPress)
		{
			if (!bPress && InputDistributeModel.Instance.IsActionInPress(actionName))
			{
				InputDistributeController.Instance.InputAction(actionName, false);
			}
		}

		// Token: 0x06047D7E RID: 294270 RVA: 0x01262094 File Offset: 0x01260294
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

		// Token: 0x06047D7F RID: 294271 RVA: 0x0126210C File Offset: 0x0126030C
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

		// Token: 0x06047D80 RID: 294272 RVA: 0x0126212C File Offset: 0x0126032C
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

		// Token: 0x06047D81 RID: 294273 RVA: 0x0126216C File Offset: 0x0126036C
		private Vector NewTouchVector(int touchId, FVector ueVector)
		{
			Vector vector = Vector.Create(ueVector);
			this.TouchVectorMap[touchId] = vector;
			return vector;
		}

		// Token: 0x06047D82 RID: 294274 RVA: 0x01262194 File Offset: 0x01260394
		private bool IsInputActionSameAsInputType(string keyName)
		{
			return Info.Instance.IsGmLockGamepad || ((!Info.Instance.IsInGamepad() || !InputSettings.Instance.IsKeyboardKey(keyName)) && (!Info.Instance.IsInKeyBoard() || !InputSettings.Instance.IsGamepadKey(keyName)));
		}

		// Token: 0x06047D83 RID: 294275 RVA: 0x012621E6 File Offset: 0x012603E6
		public void SetCustomAction(string keyName, string actionName)
		{
			this.CustomKeyActionData.SetCustomAction(keyName, actionName);
		}

		// Token: 0x06047D84 RID: 294276 RVA: 0x012621F5 File Offset: 0x012603F5
		public void ResetAllCustomAction(string keyName)
		{
			this.TryInputCustomAction(keyName, false);
			this.CustomKeyActionData.ResetAllCustomAction(keyName);
		}

		// Token: 0x06047D85 RID: 294277 RVA: 0x0126220B File Offset: 0x0126040B
		public void ResetCustomAction(string keyName, string actionName)
		{
			this.CustomKeyActionData.ResetCustomAction(keyName, actionName);
		}

		// Token: 0x06047D86 RID: 294278 RVA: 0x0126221A File Offset: 0x0126041A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> GetCurrentPlatformCustomActionKeyNameList(string actionName)
		{
			return this.CustomKeyActionData.GetCurrentPlatformCustomActionKeyNameList(actionName);
		}

		// Token: 0x06047D87 RID: 294279 RVA: 0x01262228 File Offset: 0x01260428
		public void SetActionEnable(string actionName, bool bEnable)
		{
			this.CustomKeyActionData.SetActionEnable(actionName, bEnable);
		}

		// Token: 0x04025C51 RID: 154705
		private readonly Dictionary<int, Vector> TouchVectorMap = new Dictionary<int, Vector>();

		// Token: 0x04025C52 RID: 154706
		public bool IsPrintKeyName;

		// Token: 0x04025C53 RID: 154707
		public bool IsRecording;

		// Token: 0x04025C54 RID: 154708
		[Nullable(2)]
		private CombinationActionHandle CombinationActionHandle;

		// Token: 0x04025C55 RID: 154709
		[Nullable(2)]
		private CombinationAxisHandle CombinationAxisHandle;

		// Token: 0x04025C56 RID: 154710
		private readonly Dictionary<string, float> AlwaysTickAxisValueMap = new Dictionary<string, float>();

		// Token: 0x04025C57 RID: 154711
		private readonly Dictionary<string, float> OptimizeTickAxisValueMap = new Dictionary<string, float>();

		// Token: 0x04025C58 RID: 154712
		private readonly CustomKeyActionData CustomKeyActionData = new CustomKeyActionData();

		// Token: 0x04025C59 RID: 154713
		private bool LastShowMouseCursor;

		// Token: 0x04025C5A RID: 154714
		private bool LastFrameShowMouseCursor;

		// Token: 0x04025C5B RID: 154715
		private readonly List<string> BlockCheckKeyNameList = new List<string>();
	}
}
