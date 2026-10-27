using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Input.BattleInputData;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.LevelGamePlay.Common;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200467D RID: 18045
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class InputDistributeModel : ModelBase
	{
		// Token: 0x0602E915 RID: 190741 RVA: 0x00AC77E9 File Offset: 0x00AC59E9
		protected override bool OnInit()
		{
			this.InitializeInputDistributeTags();
			this.InitializeActionHandles();
			this.InitializeAxisHandles();
			this.InitializeTouchHandles();
			this.InitializeKeyHandles();
			this.InitializeInputDistributeSetup();
			this.SetInputDistributeTag("FightInputRoot");
			return true;
		}

		// Token: 0x0602E916 RID: 190742 RVA: 0x00AC781C File Offset: 0x00AC5A1C
		protected override bool OnClear()
		{
			this.ClearAllNotAllowFightInputViewNames();
			this.InputDistributeTagMap.Clear();
			this.InputDistributeSetups.Clear();
			foreach (InputActionHandle inputActionHandle in this.InputActionHandleMap.Values)
			{
				inputActionHandle.Reset();
			}
			this.InputActionHandleMap.Clear();
			foreach (InputAxisHandle inputAxisHandle in this.InputAxisHandleMap.Values)
			{
				inputAxisHandle.Reset();
			}
			this.InputAxisHandleMap.Clear();
			foreach (InputKeyHandle inputKeyHandle in this.InputKeyHandleMap.Values)
			{
				inputKeyHandle.Reset();
			}
			this.InputKeyHandleMap.Clear();
			this.TagChangedCallbacks.Clear();
			return true;
		}

		// Token: 0x0602E917 RID: 190743 RVA: 0x00AC7944 File Offset: 0x00AC5B44
		private void InitializeInputDistributeSetup()
		{
			Type[] inputDistributeSetups = InputDistributeSetupDefine.inputDistributeSetups;
			for (int i = 0; i < inputDistributeSetups.Length; i++)
			{
				object obj = Activator.CreateInstance(inputDistributeSetups[i]);
				this.InputDistributeSetups.Add((InputDistributeSetup)obj);
			}
		}

		// Token: 0x0602E918 RID: 190744 RVA: 0x00AC7980 File Offset: 0x00AC5B80
		public void RefreshInputDistributeTag()
		{
			using (List<InputDistributeSetup>.Enumerator enumerator = this.InputDistributeSetups.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.OnRefresh())
					{
						break;
					}
				}
			}
		}

		// Token: 0x0602E919 RID: 190745 RVA: 0x00AC79D4 File Offset: 0x00AC5BD4
		private void InitializeActionHandles()
		{
			IReadOnlyList<ActionMapping> allActionMappingConfig = InputSettingsConfig.Instance.GetAllActionMappingConfig();
			if (allActionMappingConfig != null)
			{
				foreach (ActionMapping actionMapping in allActionMappingConfig)
				{
					this.NewInputActionHandle(actionMapping.ActionName, actionMapping.InputTag);
				}
			}
			IReadOnlyList<CombinationAction> allCombinationActionConfig = InputSettingsConfig.Instance.GetAllCombinationActionConfig();
			if (allCombinationActionConfig != null)
			{
				foreach (CombinationAction combinationAction in allCombinationActionConfig)
				{
					this.NewInputActionHandle(combinationAction.ActionName, combinationAction.InputTag);
				}
			}
		}

		// Token: 0x0602E91A RID: 190746 RVA: 0x00AC7A94 File Offset: 0x00AC5C94
		private void InitializeAxisHandles()
		{
			IReadOnlyList<AxisMapping> allAxisMappingConfig = InputSettingsConfig.Instance.GetAllAxisMappingConfig();
			if (allAxisMappingConfig != null)
			{
				foreach (AxisMapping axisMapping in allAxisMappingConfig)
				{
					this.NewInputAxisHandle(axisMapping.AxisName, axisMapping.InputTag);
				}
			}
			IReadOnlyList<CombinationAxis> allCombinationAxisConfig = InputSettingsConfig.Instance.GetAllCombinationAxisConfig();
			if (allCombinationAxisConfig != null)
			{
				foreach (CombinationAxis combinationAxis in allCombinationAxisConfig)
				{
					this.NewInputAxisHandle(combinationAxis.AxisName, combinationAxis.InputTag);
				}
			}
		}

		// Token: 0x0602E91B RID: 190747 RVA: 0x00AC7B54 File Offset: 0x00AC5D54
		private void InitializeTouchHandles()
		{
			foreach (KeyValuePair<int, string> keyValuePair in InputDistributeDefine.touchTagMap)
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.NewInputTouchHandle(key, value);
			}
		}

		// Token: 0x0602E91C RID: 190748 RVA: 0x00AC7BB8 File Offset: 0x00AC5DB8
		private void InitializeKeyHandles()
		{
			foreach (KeyValuePair<string, string> keyValuePair in InputDistributeDefine.keyTagMap)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.NewInputKeyHandle(key, value);
			}
		}

		// Token: 0x0602E91D RID: 190749 RVA: 0x00AC7C1C File Offset: 0x00AC5E1C
		public bool IsActionInPress(string actionName)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			return inputActionHandle != null && inputActionHandle.GetIsPress();
		}

		// Token: 0x0602E91E RID: 190750 RVA: 0x00AC7C3C File Offset: 0x00AC5E3C
		public bool IsAxisInPress(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			return inputAxisHandle != null && inputAxisHandle.GetCacheAxisValue() != 0f;
		}

		// Token: 0x0602E91F RID: 190751 RVA: 0x00AC7C66 File Offset: 0x00AC5E66
		public bool HasAxisBind(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			return inputAxisHandle != null && inputAxisHandle.HasCallback();
		}

		// Token: 0x0602E920 RID: 190752 RVA: 0x00AC7C7A File Offset: 0x00AC5E7A
		public bool HasActionBind(string actionName)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			return inputActionHandle != null && inputActionHandle.HasCallback();
		}

		// Token: 0x0602E921 RID: 190753 RVA: 0x00AC7C90 File Offset: 0x00AC5E90
		public bool IsActionRespondable(string actionName)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle == null)
			{
				return false;
			}
			InputModel instance = InputModel.Instance;
			BattleInputData battleInputData = (instance != null) ? instance.GetCurrentInputData() : null;
			if (battleInputData != null && !battleInputData.CheckActionInAllowFightActionNameList(actionName, inputActionHandle))
			{
				return false;
			}
			string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
			if (!string.IsNullOrEmpty(inputDistributeTag) && !this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false))
			{
				return inputActionHandle.HasIgnoreLimit();
			}
			return this.CheckFightActionInputAllow(actionName, inputDistributeTag);
		}

		// Token: 0x0602E922 RID: 190754 RVA: 0x00AC7CF8 File Offset: 0x00AC5EF8
		public bool InputAction(string actionName, bool bPress)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "输入Action时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			InputModel instance2 = InputModel.Instance;
			BattleInputData battleInputData = (instance2 != null) ? instance2.GetCurrentInputData() : null;
			if (battleInputData != null && !battleInputData.CheckActionInAllowFightActionNameList(actionName, inputActionHandle))
			{
				return false;
			}
			inputActionHandle.SetIsPress(bPress);
			if (Array.IndexOf<string>(InputDistributeDelay.delayInput, actionName) >= 0)
			{
				InputDistributeDelay inputDistributeDelay = null;
				if (!this.InputDistributeDelayMap.ContainsKey(actionName))
				{
					inputDistributeDelay = new InputDistributeDelay();
					this.InputDistributeDelayMap[actionName] = inputDistributeDelay;
				}
				else
				{
					this.InputDistributeDelayMap.TryGetValue(actionName, out inputDistributeDelay);
				}
				if (inputDistributeDelay.CheckCondition(actionName, bPress))
				{
					inputDistributeDelay.StartDelay((float)LevelGamePlayConfig.Instance.InteractInputCacheTime, bPress);
				}
			}
			if (this.HasActionLimitSet())
			{
				if (!this.IsActionInLimitSet(actionName))
				{
					EventSystem.Instance.Emit<string, bool>(EEventName.GuideLimitActionInput, actionName, bPress);
					return false;
				}
			}
			else
			{
				string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
				if (!string.IsNullOrEmpty(inputDistributeTag) && !this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false))
				{
					if (!bPress)
					{
						inputActionHandle.TryReleaseActionIfLimitInputDistributeTag();
					}
					inputActionHandle.InputActionIgnoreLimit(bPress);
					return false;
				}
				if (!this.CheckFightActionInputAllow(actionName, inputDistributeTag))
				{
					return false;
				}
			}
			inputActionHandle.InputAction(bPress);
			inputActionHandle.InputActionIgnoreLimit(bPress);
			if (bPress)
			{
				this.CurrentActionName = actionName;
			}
			else if (this.CurrentActionName != null)
			{
				this.CurrentActionName = null;
			}
			EventSystem.Instance.Emit(EEventName.OnInputChangeForCond);
			return true;
		}

		// Token: 0x0602E923 RID: 190755 RVA: 0x00AC7E5C File Offset: 0x00AC605C
		private bool CheckFightActionInputAllow(string actionName, [Nullable(2)] string tag)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tag);
			if (inputDistributeTag == null)
			{
				return true;
			}
			if (inputDistributeTag.MatchTag("UiInputRoot.MouseInputTag", false) || inputDistributeTag.MatchTag("UiInputRoot.Navigation", false))
			{
				return true;
			}
			UiNavigationModel instance = UiNavigationModel.Instance;
			return instance == null || !instance.CheckActionNameListInNavigation(actionName);
		}

		// Token: 0x0602E924 RID: 190756 RVA: 0x00AC7EAC File Offset: 0x00AC60AC
		private bool CheckFightAxisInputAllow(string axisName, [Nullable(2)] string tag)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tag);
			if (inputDistributeTag == null)
			{
				return true;
			}
			if (inputDistributeTag.MatchTag("UiInputRoot.MouseInputTag", false) || inputDistributeTag.MatchTag("UiInputRoot.Navigation", false))
			{
				return true;
			}
			UiNavigationModel instance = UiNavigationModel.Instance;
			return instance == null || !instance.CheckAxisNameListInNavigation(axisName);
		}

		// Token: 0x0602E925 RID: 190757 RVA: 0x00AC7EF9 File Offset: 0x00AC60F9
		[NullableContext(2)]
		public string GetCurrentActionName()
		{
			return this.CurrentActionName;
		}

		// Token: 0x0602E926 RID: 190758 RVA: 0x00AC7F04 File Offset: 0x00AC6104
		public void InputCacheAxisValue(string axisName, float value)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				return;
			}
			inputAxisHandle.InputCacheAxisValue(value);
		}

		// Token: 0x0602E927 RID: 190759 RVA: 0x00AC7F24 File Offset: 0x00AC6124
		public void InputAxis(string axisName, float value, bool force = false)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				return;
			}
			InputModel instance = InputModel.Instance;
			BattleInputData battleInputData = (instance != null) ? instance.GetCurrentInputData() : null;
			if (battleInputData != null && !battleInputData.CheckAxisInAllowFightAxisNameList(axisName, inputAxisHandle))
			{
				return;
			}
			if (this.HasActionLimitSet())
			{
				if (!this.IsActionInLimitSet(axisName))
				{
					if (Info.Instance.AxisInputOptimize && (inputAxisHandle.GetCacheAxisValue() != 0f || force))
					{
						inputAxisHandle.InputAxis(0f);
						inputAxisHandle.InputAxisIgnoreLimit(0f);
						return;
					}
					inputAxisHandle.InputAxisIgnoreLimit(value);
					return;
				}
			}
			else
			{
				string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
				if (!string.IsNullOrEmpty(inputDistributeTag) && !this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false))
				{
					if (Info.Instance.AxisInputOptimize && (inputAxisHandle.GetCacheAxisValue() != 0f || force))
					{
						inputAxisHandle.InputAxis(0f);
						inputAxisHandle.InputAxisIgnoreLimit(0f);
						return;
					}
					inputAxisHandle.InputAxisIgnoreLimit(value);
					return;
				}
				else if (!this.CheckFightAxisInputAllow(axisName, inputDistributeTag))
				{
					if (Info.Instance.AxisInputOptimize && (inputAxisHandle.GetCacheAxisValue() != 0f || force))
					{
						inputAxisHandle.InputAxis(0f);
						inputAxisHandle.InputAxisIgnoreLimit(0f);
						return;
					}
					inputAxisHandle.InputAxisIgnoreLimit(value);
					return;
				}
			}
			inputAxisHandle.InputAxis(value);
			inputAxisHandle.InputAxisIgnoreLimit(value);
			this.EmitAxisEventForCond(axisName, value);
			if (Math.Abs(value) > 0f)
			{
				this.CurrentAxisName = axisName;
				return;
			}
			if (this.CurrentAxisName != null)
			{
				this.CurrentAxisName = null;
			}
		}

		// Token: 0x0602E928 RID: 190760 RVA: 0x00AC808C File Offset: 0x00AC628C
		private void EmitAxisEventForCond(string axisName, float value)
		{
			if (this.CurrentActionName != axisName)
			{
				this.LastAxisValue = 0f;
			}
			if (Math.Abs(value) == 0f)
			{
				return;
			}
			if (Math.Abs(value - this.LastAxisValue) > 0.05f)
			{
				this.CurrentActionName = axisName;
				EventSystem.Instance.Emit(EEventName.OnInputChangeForCond);
				this.LastAxisValue = value;
			}
		}

		// Token: 0x0602E929 RID: 190761 RVA: 0x00AC80F2 File Offset: 0x00AC62F2
		[NullableContext(2)]
		public string GetCurrentAxisName()
		{
			return this.CurrentAxisName;
		}

		// Token: 0x0602E92A RID: 190762 RVA: 0x00AC80FC File Offset: 0x00AC62FC
		public void InputTouch(int touchId, InputDistributeDefine.ITouchData touchData)
		{
			InputTouchHandle inputTouchHandle = this.GetInputTouchHandle(touchId);
			if (inputTouchHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "输入Action时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("touchId", touchId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string inputDistributeTag = inputTouchHandle.GetInputDistributeTag();
			if (inputDistributeTag != null && !this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false))
			{
				return;
			}
			inputTouchHandle.InputTouch(touchData);
		}

		// Token: 0x0602E92B RID: 190763 RVA: 0x00AC8160 File Offset: 0x00AC6360
		public void BindAction(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "绑定Action回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputActionHandle.BindAction(actionCallback);
		}

		// Token: 0x0602E92C RID: 190764 RVA: 0x00AC81A8 File Offset: 0x00AC63A8
		public void ExecuteDelayInputAction(string actionName)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle != null && this.InputDistributeDelayMap.ContainsKey(actionName))
			{
				InputDistributeDelay inputDistributeDelay;
				this.InputDistributeDelayMap.TryGetValue(actionName, out inputDistributeDelay);
				if (inputDistributeDelay.IsInputActive(false))
				{
					inputActionHandle.InputAction(false);
				}
			}
		}

		// Token: 0x0602E92D RID: 190765 RVA: 0x00AC81F0 File Offset: 0x00AC63F0
		public void BindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			foreach (string actionName in actionNames)
			{
				this.BindAction(actionName, actionCallback);
			}
		}

		// Token: 0x0602E92E RID: 190766 RVA: 0x00AC823C File Offset: 0x00AC643C
		public void UnBindAction(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "取消绑定Action回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputActionHandle.UnBindAction(actionCallback);
		}

		// Token: 0x0602E92F RID: 190767 RVA: 0x00AC8284 File Offset: 0x00AC6484
		public void UnBindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			foreach (string actionName in actionNames)
			{
				this.UnBindAction(actionName, actionCallback);
			}
		}

		// Token: 0x0602E930 RID: 190768 RVA: 0x00AC82D0 File Offset: 0x00AC64D0
		public void BindActionIgnoreLimit(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "绑定Action回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputActionHandle.BindActionIgnoreLimit(actionCallback);
		}

		// Token: 0x0602E931 RID: 190769 RVA: 0x00AC8318 File Offset: 0x00AC6518
		public void UnBindActionIgnoreLimit(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			if (inputActionHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "取消绑定Action回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputActionHandle.UnBindActionIgnoreLimit(actionCallback);
		}

		// Token: 0x0602E932 RID: 190770 RVA: 0x00AC835F File Offset: 0x00AC655F
		public void PreventIgnoredActionRelease(bool enable, string key)
		{
			if (enable)
			{
				this.PreventIgnoredActionSet.Add(key);
			}
			else
			{
				this.PreventIgnoredActionSet.Remove(key);
			}
			this.PreventIgnoredActionEnabled = (this.PreventIgnoredActionSet.Count > 0);
		}

		// Token: 0x0602E933 RID: 190771 RVA: 0x00AC8394 File Offset: 0x00AC6594
		public bool IsPreventIgnoredAction(string actionName)
		{
			if (!this.PreventIgnoredActionEnabled)
			{
				return false;
			}
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			return inputActionHandle != null && inputActionHandle.HasIgnoreLimit();
		}

		// Token: 0x0602E934 RID: 190772 RVA: 0x00AC83C0 File Offset: 0x00AC65C0
		private InputActionHandle NewInputActionHandle(string actionName, string inputDistributeTag)
		{
			InputActionHandle inputActionHandle;
			this.InputActionHandleMap.TryGetValue(actionName, out inputActionHandle);
			if (inputActionHandle != null)
			{
				return inputActionHandle;
			}
			inputActionHandle = new InputActionHandle(inputDistributeTag, actionName);
			this.InputActionHandleMap[actionName] = inputActionHandle;
			return inputActionHandle;
		}

		// Token: 0x0602E935 RID: 190773 RVA: 0x00AC83F8 File Offset: 0x00AC65F8
		[return: Nullable(2)]
		private InputActionHandle GetInputActionHandle(string actionName)
		{
			InputActionHandle result;
			this.InputActionHandleMap.TryGetValue(actionName, out result);
			return result;
		}

		// Token: 0x0602E936 RID: 190774 RVA: 0x00AC8418 File Offset: 0x00AC6618
		public void BindAxis(string axisName, TInputHandle<float> axisCallback)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "绑定Axis回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputAxisHandle.BindAxis(axisCallback);
		}

		// Token: 0x0602E937 RID: 190775 RVA: 0x00AC8460 File Offset: 0x00AC6660
		public void BindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			foreach (string axisName in axisNames)
			{
				this.BindAxis(axisName, axisCallback);
			}
		}

		// Token: 0x0602E938 RID: 190776 RVA: 0x00AC84AC File Offset: 0x00AC66AC
		public float GetAxisValue(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				return 0f;
			}
			return inputAxisHandle.GetCacheAxisValue();
		}

		// Token: 0x0602E939 RID: 190777 RVA: 0x00AC84D0 File Offset: 0x00AC66D0
		public void UnBindAxis(string axisName, TInputHandle<float> axisCallback)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "取消绑定Action回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputAxisHandle.UnBindAxis(axisCallback);
		}

		// Token: 0x0602E93A RID: 190778 RVA: 0x00AC8518 File Offset: 0x00AC6718
		public void UnBindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			foreach (string axisName in axisNames)
			{
				this.UnBindAxis(axisName, axisCallback);
			}
		}

		// Token: 0x0602E93B RID: 190779 RVA: 0x00AC8564 File Offset: 0x00AC6764
		public void BindAxisIgnoreLimit(string axisName, TInputHandle<float> axisCallback)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "绑定Axis回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputAxisHandle.BindAxisIgnoreLimit(axisCallback);
		}

		// Token: 0x0602E93C RID: 190780 RVA: 0x00AC85AC File Offset: 0x00AC67AC
		public void UnBindAxisIgnoreLimit(string axisName, TInputHandle<float> axisCallback)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "取消绑定Axis回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", axisName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputAxisHandle.UnBindAxisIgnoreLimit(axisCallback);
		}

		// Token: 0x0602E93D RID: 190781 RVA: 0x00AC85F4 File Offset: 0x00AC67F4
		public bool IsAxisRespondable(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null || !inputAxisHandle.HasCallback())
			{
				return false;
			}
			string inputDistributeTag = inputAxisHandle.GetInputDistributeTag();
			return string.IsNullOrEmpty(inputDistributeTag) || this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false);
		}

		// Token: 0x0602E93E RID: 190782 RVA: 0x00AC8630 File Offset: 0x00AC6830
		public void BindTouch(int touchId, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputTouchHandle inputTouchHandle = this.GetInputTouchHandle(touchId);
			if (inputTouchHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "绑定Touch回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", touchId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputTouchHandle.BindTouch(touchCallback);
		}

		// Token: 0x0602E93F RID: 190783 RVA: 0x00AC867C File Offset: 0x00AC687C
		public void BindTouches(int[] touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			foreach (int touchId in touchIdList)
			{
				this.BindTouch(touchId, touchCallback);
			}
		}

		// Token: 0x0602E940 RID: 190784 RVA: 0x00AC86A8 File Offset: 0x00AC68A8
		public void UnBindTouch(int touchId, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputTouchHandle inputTouchHandle = this.GetInputTouchHandle(touchId);
			if (inputTouchHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "取消绑定Touch回调时，没有对应的ActionHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("axisName", touchId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputTouchHandle.UnBindTouch(touchCallback);
		}

		// Token: 0x0602E941 RID: 190785 RVA: 0x00AC86F4 File Offset: 0x00AC68F4
		public void UnBindTouches(IReadOnlyList<int> touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			foreach (int touchId in touchIdList)
			{
				this.UnBindTouch(touchId, touchCallback);
			}
		}

		// Token: 0x0602E942 RID: 190786 RVA: 0x00AC8740 File Offset: 0x00AC6940
		private InputAxisHandle NewInputAxisHandle(string actionName, string inputDistributeTag)
		{
			InputAxisHandle inputAxisHandle;
			this.InputAxisHandleMap.TryGetValue(actionName, out inputAxisHandle);
			if (inputAxisHandle != null)
			{
				return inputAxisHandle;
			}
			inputAxisHandle = new InputAxisHandle(inputDistributeTag, actionName);
			this.InputAxisHandleMap[actionName] = inputAxisHandle;
			return inputAxisHandle;
		}

		// Token: 0x0602E943 RID: 190787 RVA: 0x00AC8778 File Offset: 0x00AC6978
		[return: Nullable(2)]
		private InputAxisHandle GetInputAxisHandle(string actionName)
		{
			InputAxisHandle result;
			this.InputAxisHandleMap.TryGetValue(actionName, out result);
			return result;
		}

		// Token: 0x0602E944 RID: 190788 RVA: 0x00AC8798 File Offset: 0x00AC6998
		private InputTouchHandle NewInputTouchHandle(int touchId, string inputDistributeTag)
		{
			InputTouchHandle inputTouchHandle = new InputTouchHandle(inputDistributeTag, touchId.ToString());
			this.InputTouchHandleMap[touchId] = inputTouchHandle;
			return inputTouchHandle;
		}

		// Token: 0x0602E945 RID: 190789 RVA: 0x00AC87C4 File Offset: 0x00AC69C4
		[NullableContext(2)]
		private InputTouchHandle GetInputTouchHandle(int touchId)
		{
			InputTouchHandle result;
			this.InputTouchHandleMap.TryGetValue(touchId, out result);
			return result;
		}

		// Token: 0x0602E946 RID: 190790 RVA: 0x00AC87E4 File Offset: 0x00AC69E4
		private InputKeyHandle NewInputKeyHandle(string keyName, string inputDistributeTag)
		{
			InputKeyHandle inputKeyHandle = new InputKeyHandle(inputDistributeTag, keyName);
			this.InputKeyHandleMap[keyName] = inputKeyHandle;
			return inputKeyHandle;
		}

		// Token: 0x0602E947 RID: 190791 RVA: 0x00AC8808 File Offset: 0x00AC6A08
		[return: Nullable(2)]
		private InputKeyHandle GetInputKeyHandle(string keyName)
		{
			InputKeyHandle result;
			this.InputKeyHandleMap.TryGetValue(keyName, out result);
			return result;
		}

		// Token: 0x0602E948 RID: 190792 RVA: 0x00AC8828 File Offset: 0x00AC6A28
		public void BindKey(string keyName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputKeyHandle inputKeyHandle = this.GetInputKeyHandle(keyName);
			if (inputKeyHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "绑定Key回调时，没有对应的KeyHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("keyName", keyName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputKeyHandle.BindAction(actionCallback);
		}

		// Token: 0x0602E949 RID: 190793 RVA: 0x00AC8870 File Offset: 0x00AC6A70
		public void UnBindKey(string keyName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputKeyHandle inputKeyHandle = this.GetInputKeyHandle(keyName);
			if (inputKeyHandle == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "取消绑定Key回调时，没有对应的KeyHandle";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("keyName", keyName);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			inputKeyHandle.UnBindAction(actionCallback);
		}

		// Token: 0x0602E94A RID: 190794 RVA: 0x00AC88B8 File Offset: 0x00AC6AB8
		public void InputKey(string keyName, bool bPress)
		{
			InputKeyHandle inputKeyHandle = this.GetInputKeyHandle(keyName);
			if (inputKeyHandle == null)
			{
				return;
			}
			string inputDistributeTag = inputKeyHandle.GetInputDistributeTag();
			if (inputDistributeTag != null && !this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false))
			{
				return;
			}
			inputKeyHandle.InputKey(bPress);
		}

		// Token: 0x0602E94B RID: 190795 RVA: 0x00AC88ED File Offset: 0x00AC6AED
		public bool HasAnyNotAllowFightInputViewIsOpen()
		{
			return this.NotAllowFightInputViewNameSet.Count > 0;
		}

		// Token: 0x0602E94C RID: 190796 RVA: 0x00AC88FD File Offset: 0x00AC6AFD
		public bool HasNotAllowFightInputViewIsOpen(EUiViewName uiViewName)
		{
			return this.NotAllowFightInputViewNameSet.Contains(uiViewName);
		}

		// Token: 0x0602E94D RID: 190797 RVA: 0x00AC890B File Offset: 0x00AC6B0B
		public void AddNotAllowFightInputViewName(EUiViewName uiViewName)
		{
			this.NotAllowFightInputViewNameSet.Add(uiViewName);
		}

		// Token: 0x0602E94E RID: 190798 RVA: 0x00AC891A File Offset: 0x00AC6B1A
		public void RemoveNotAllowFightInputViewName(EUiViewName uiViewName)
		{
			this.NotAllowFightInputViewNameSet.Remove(uiViewName);
		}

		// Token: 0x0602E94F RID: 190799 RVA: 0x00AC8929 File Offset: 0x00AC6B29
		public void ClearAllNotAllowFightInputViewNames()
		{
			this.NotAllowFightInputViewNameSet.Clear();
		}

		// Token: 0x0602E950 RID: 190800 RVA: 0x00AC8936 File Offset: 0x00AC6B36
		public HashSet<EUiViewName> GetNotAllowFightInputViewNameSet()
		{
			return this.NotAllowFightInputViewNameSet;
		}

		// Token: 0x0602E951 RID: 190801 RVA: 0x00AC8940 File Offset: 0x00AC6B40
		private void InitializeInputDistributeTags()
		{
			foreach (ValueTuple<string, string> valueTuple in InputDistributeDefine.InitializeInputDistributeTagDefine)
			{
				string item = valueTuple.Item1;
				string item2 = valueTuple.Item2;
				InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(item2);
				this.NewInputDistributeTag(item, inputDistributeTag);
			}
		}

		// Token: 0x0602E952 RID: 190802 RVA: 0x00AC89A8 File Offset: 0x00AC6BA8
		private InputDistributeTag NewInputDistributeTag(string tag, [Nullable(2)] InputDistributeTag parentTag = null)
		{
			InputDistributeTag inputDistributeTag = new InputDistributeTag(tag, parentTag);
			this.InputDistributeTagMap[tag] = inputDistributeTag;
			return inputDistributeTag;
		}

		// Token: 0x0602E953 RID: 190803 RVA: 0x00AC89CC File Offset: 0x00AC6BCC
		[NullableContext(2)]
		public InputDistributeTag GetInputDistributeTag(string tag)
		{
			if (tag == null)
			{
				return null;
			}
			InputDistributeTag result;
			this.InputDistributeTagMap.TryGetValue(tag, out result);
			return result;
		}

		// Token: 0x0602E954 RID: 190804 RVA: 0x00AC89F0 File Offset: 0x00AC6BF0
		public bool MatchTag(string tag, InputDistributeTag inputDistributeTag, bool bExactMatch = false)
		{
			InputDistributeTag inputDistributeTag2 = this.GetInputDistributeTag(tag);
			return inputDistributeTag != null && inputDistributeTag2.MatchTag(inputDistributeTag.TagName, bExactMatch);
		}

		// Token: 0x0602E955 RID: 190805 RVA: 0x00AC8A17 File Offset: 0x00AC6C17
		public bool IsTagMatchAnyCurrentInputTag(string tag, bool bExactMatch = false)
		{
			return this.IsTagMatchAnyInputDistributeTags(tag, this.InputDistributeTags, bExactMatch);
		}

		// Token: 0x0602E956 RID: 190806 RVA: 0x00AC8A28 File Offset: 0x00AC6C28
		public bool IsAnyInputDistributeTagsMatchTag(List<InputDistributeTag> inputDistributeTags, string tag, bool bExactMatch = false)
		{
			using (List<InputDistributeTag>.Enumerator enumerator = inputDistributeTags.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MatchTag(tag, bExactMatch))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602E957 RID: 190807 RVA: 0x00AC8A80 File Offset: 0x00AC6C80
		public bool IsTagMatchAnyInputDistributeTags(string tag, List<InputDistributeTag> inputDistributeTags, bool bExactMatch = false)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tag);
			if (inputDistributeTag != null)
			{
				foreach (InputDistributeTag inputDistributeTag2 in inputDistributeTags)
				{
					if (inputDistributeTag.MatchTag(inputDistributeTag2.TagName, bExactMatch))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0602E958 RID: 190808 RVA: 0x00AC8AE8 File Offset: 0x00AC6CE8
		public bool IsTagMatchInputDistributeTags(string tag, string[] inputDistributeTags, bool bExactMatch = false)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tag);
			if (inputDistributeTag == null)
			{
				return false;
			}
			foreach (string tag2 in inputDistributeTags)
			{
				if (inputDistributeTag.MatchTag(tag2, bExactMatch))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602E959 RID: 190809 RVA: 0x00AC8B24 File Offset: 0x00AC6D24
		public void AddToLimitInputDistributeActions(string actionName)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputDistribute]设置输入分发限制Action";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionName", actionName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.LimitInputDistributeActionSet.Add(actionName);
		}

		// Token: 0x0602E95A RID: 190810 RVA: 0x00AC8B68 File Offset: 0x00AC6D68
		public void ClearLimitInputDistributeActions()
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]清除输入分发限制Action", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LimitInputDistributeActionSet.Clear();
		}

		// Token: 0x0602E95B RID: 190811 RVA: 0x00AC8B9C File Offset: 0x00AC6D9C
		public bool HasActionLimitSet()
		{
			return this.LimitInputDistributeActionSet.Count > 0;
		}

		// Token: 0x0602E95C RID: 190812 RVA: 0x00AC8BAC File Offset: 0x00AC6DAC
		public bool IsActionInLimitSet(string actionName)
		{
			return this.LimitInputDistributeActionSet.Contains(actionName);
		}

		// Token: 0x0602E95D RID: 190813 RVA: 0x00AC8BBC File Offset: 0x00AC6DBC
		public void AddInputDistributeTag(string tagName)
		{
			if (!this.AddInputDistributeTagInternal(tagName))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputDistribute]添加输入分发Tag";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagName", tagName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, this.InputDistributeTags);
			this.OnInputDistributeTagChanged();
		}

		// Token: 0x0602E95E RID: 190814 RVA: 0x00AC8C18 File Offset: 0x00AC6E18
		private bool AddInputDistributeTagInternal(string tagName)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tagName);
			if (inputDistributeTag == null)
			{
				return false;
			}
			this.InputDistributeTags.Add(inputDistributeTag);
			return true;
		}

		// Token: 0x0602E95F RID: 190815 RVA: 0x00AC8C40 File Offset: 0x00AC6E40
		public void SetInputDistributeTag(string tagName)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tagName);
			if (inputDistributeTag == null)
			{
				return;
			}
			this.InputDistributeTags = new List<InputDistributeTag>
			{
				inputDistributeTag
			};
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputDistribute]设置输入分发Tag";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagName", tagName);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, this.InputDistributeTags);
			this.OnInputDistributeTagChanged();
		}

		// Token: 0x0602E960 RID: 190816 RVA: 0x00AC8CB0 File Offset: 0x00AC6EB0
		public void SetInputDistributeTags(IList<string> tagNames)
		{
			this.ClearInputDistributeTag();
			foreach (string tagName in tagNames)
			{
				this.AddInputDistributeTagInternal(tagName);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Input;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "[InputDistribute]设置输入分发Tag";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tagNames", tagNames);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			EventSystem.Instance.Emit<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, this.InputDistributeTags);
			this.OnInputDistributeTagChanged();
		}

		// Token: 0x0602E961 RID: 190817 RVA: 0x00AC8D44 File Offset: 0x00AC6F44
		public void RemoveInputDistributeTag(string tagName, bool bRemoveChild = false)
		{
			InputDistributeTag inputDistributeTag = this.GetInputDistributeTag(tagName);
			if (inputDistributeTag == null)
			{
				return;
			}
			if (bRemoveChild)
			{
				List<InputDistributeTag> list = new List<InputDistributeTag>();
				foreach (InputDistributeTag inputDistributeTag2 in this.InputDistributeTags)
				{
					if (inputDistributeTag2.MatchTag(inputDistributeTag.TagName, false))
					{
						list.Add(inputDistributeTag2);
					}
				}
				using (List<InputDistributeTag>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						InputDistributeTag item = enumerator.Current;
						int num = this.InputDistributeTags.IndexOf(item);
						if (num >= 0)
						{
							this.InputDistributeTags.RemoveAt(num);
						}
					}
					return;
				}
			}
			int num2 = this.InputDistributeTags.IndexOf(inputDistributeTag);
			if (num2 < 0)
			{
				return;
			}
			this.InputDistributeTags.RemoveAt(num2);
		}

		// Token: 0x0602E962 RID: 190818 RVA: 0x00AC8E38 File Offset: 0x00AC7038
		public void ClearInputDistributeTag()
		{
			this.InputDistributeTags.Clear();
		}

		// Token: 0x0602E963 RID: 190819 RVA: 0x00AC8E48 File Offset: 0x00AC7048
		private void OnInputDistributeTagChanged()
		{
			foreach (string text in this.TagChangedCallbacks.Keys)
			{
				HashSet<TInputTagChangedCallback> hashSet;
				this.TagChangedCallbacks.TryGetValue(text, out hashSet);
				if (hashSet == null || hashSet.Count == 0)
				{
					return;
				}
				bool flag = this.IsTagMatchAnyInputDistributeTags(text, this.LastInputDistributeTags, false);
				bool flag2 = this.IsTagMatchAnyInputDistributeTags(text, this.InputDistributeTags, false);
				if (flag != flag2)
				{
					this.EmitInputDistributeTagChanged(hashSet, text, flag2);
				}
			}
			this.LastInputDistributeTags = new List<InputDistributeTag>(this.InputDistributeTags);
		}

		// Token: 0x0602E964 RID: 190820 RVA: 0x00AC8EF4 File Offset: 0x00AC70F4
		private unsafe void EmitInputDistributeTagChanged(HashSet<TInputTagChangedCallback> callbackSet, string tagName, bool isExist)
		{
			foreach (TInputTagChangedCallback tinputTagChangedCallback in callbackSet)
			{
				try
				{
					tinputTagChangedCallback(tagName, isExist);
				}
				catch (Exception ex)
				{
					if (ex != null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Input;
						ELogAuthor author = ELogAuthor.YYZ;
						string message = "[InputDistribute]Tag事件回调执行异常";
						Exception error = ex;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", tagName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
						instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
					else
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Input;
						ELogAuthor author2 = ELogAuthor.YYZ;
						string message2 = "[InputDistribute]Tag事件回调执行异常";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("tag", tagName);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("error", ex);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
				}
			}
		}

		// Token: 0x0602E965 RID: 190821 RVA: 0x00AC9014 File Offset: 0x00AC7214
		public void AddInputDistributeTagChangedListener(string tagName, TInputTagChangedCallback callback)
		{
			if (tagName == null || callback == null)
			{
				return;
			}
			HashSet<TInputTagChangedCallback> hashSet = null;
			this.TagChangedCallbacks.TryGetValue(tagName, out hashSet);
			if (hashSet == null)
			{
				hashSet = new HashSet<TInputTagChangedCallback>();
				this.TagChangedCallbacks[tagName] = hashSet;
			}
			if (hashSet.Contains(callback))
			{
				return;
			}
			hashSet.Add(callback);
		}

		// Token: 0x0602E966 RID: 190822 RVA: 0x00AC9064 File Offset: 0x00AC7264
		public void RemoveInputDistributeTagChangedListener(string tagName, TInputTagChangedCallback callback)
		{
			HashSet<TInputTagChangedCallback> hashSet;
			this.TagChangedCallbacks.TryGetValue(tagName, out hashSet);
			if (hashSet == null)
			{
				return;
			}
			hashSet.Remove(callback);
			if (hashSet.Count == 0)
			{
				this.TagChangedCallbacks.Remove(tagName);
			}
		}

		// Token: 0x0602E967 RID: 190823 RVA: 0x00AC90A1 File Offset: 0x00AC72A1
		public bool IsAllowFightInput()
		{
			return this.IsAnyInputDistributeTagsMatchTag(this.InputDistributeTags, "FightInputRoot", false);
		}

		// Token: 0x0602E968 RID: 190824 RVA: 0x00AC90B5 File Offset: 0x00AC72B5
		public bool IsAllowFightMoveInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.AxisInput.MoveInput", this.InputDistributeTags, false);
		}

		// Token: 0x0602E969 RID: 190825 RVA: 0x00AC90C9 File Offset: 0x00AC72C9
		public bool IsAllowFightActionInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.ActionInput", this.InputDistributeTags, false);
		}

		// Token: 0x0602E96A RID: 190826 RVA: 0x00AC90DD File Offset: 0x00AC72DD
		public bool IsAllowFightCameraRotationInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation", this.InputDistributeTags, false);
		}

		// Token: 0x0602E96B RID: 190827 RVA: 0x00AC90F1 File Offset: 0x00AC72F1
		public bool IsAllowFightCameraZoomInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.AxisInput.CameraInput.CameraZoom", this.InputDistributeTags, false);
		}

		// Token: 0x0602E96C RID: 190828 RVA: 0x00AC9105 File Offset: 0x00AC7305
		public bool IsAllowHeadRotation()
		{
			return this.IsAllowFightInput() || this.IsTagMatchAnyInputDistributeTags("UiInputRoot.MouseInputTag", this.InputDistributeTags, false);
		}

		// Token: 0x0602E96D RID: 190829 RVA: 0x00AC9123 File Offset: 0x00AC7323
		public bool IsAllowUiInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("UiInputRoot", this.InputDistributeTags, false);
		}

		// Token: 0x0602E96E RID: 190830 RVA: 0x00AC9138 File Offset: 0x00AC7338
		[return: Nullable(2)]
		public string GetActionInputDistributeTagName(string actionName)
		{
			InputActionHandle inputActionHandle;
			this.InputActionHandleMap.TryGetValue(actionName, out inputActionHandle);
			if (inputActionHandle == null)
			{
				return null;
			}
			return inputActionHandle.GetInputDistributeTag();
		}

		// Token: 0x0602E96F RID: 190831 RVA: 0x00AC9160 File Offset: 0x00AC7360
		[return: Nullable(2)]
		public string GetAxisInputDistributeTagName(string axisName)
		{
			InputAxisHandle inputAxisHandle;
			this.InputAxisHandleMap.TryGetValue(axisName, out inputAxisHandle);
			if (inputAxisHandle == null)
			{
				return null;
			}
			return inputAxisHandle.GetInputDistributeTag();
		}

		// Token: 0x1700762F RID: 30255
		// (get) Token: 0x0602E970 RID: 190832 RVA: 0x00AC9187 File Offset: 0x00AC7387
		public static InputDistributeModel Instance
		{
			get
			{
				return InputDistributeModel._Instance;
			}
		}

		// Token: 0x0602E971 RID: 190833 RVA: 0x00AC918E File Offset: 0x00AC738E
		public static InputDistributeModel GetOrCreateInstance()
		{
			if (InputDistributeModel._Instance == null)
			{
				InputDistributeModel.CreateInstance();
			}
			return InputDistributeModel._Instance;
		}

		// Token: 0x0602E972 RID: 190834 RVA: 0x00AC91A2 File Offset: 0x00AC73A2
		public static bool CreateInstance()
		{
			if (InputDistributeModel._Instance != null)
			{
				return true;
			}
			InputDistributeModel._Instance = new InputDistributeModel();
			return true;
		}

		// Token: 0x0602E973 RID: 190835 RVA: 0x00AC91B8 File Offset: 0x00AC73B8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E974 RID: 190836 RVA: 0x00AC91BA File Offset: 0x00AC73BA
		public static void ResetStaticDefaultValue()
		{
			InputDistributeModel._Instance = null;
		}

		// Token: 0x0602E975 RID: 190837 RVA: 0x00AC91C2 File Offset: 0x00AC73C2
		static InputDistributeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDistributeModel.CreateStaticDefaultValue), new Action(InputDistributeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401952D RID: 103725
		private const float EMIT_EVENT_AXIS_DELTA = 0.05f;

		// Token: 0x0401952E RID: 103726
		private List<InputDistributeTag> InputDistributeTags = new List<InputDistributeTag>();

		// Token: 0x0401952F RID: 103727
		private List<InputDistributeTag> LastInputDistributeTags = new List<InputDistributeTag>();

		// Token: 0x04019530 RID: 103728
		private readonly HashSet<string> LimitInputDistributeActionSet = new HashSet<string>();

		// Token: 0x04019531 RID: 103729
		private readonly List<InputDistributeSetup> InputDistributeSetups = new List<InputDistributeSetup>();

		// Token: 0x04019532 RID: 103730
		private readonly Dictionary<string, InputDistributeTag> InputDistributeTagMap = new Dictionary<string, InputDistributeTag>();

		// Token: 0x04019533 RID: 103731
		private readonly Dictionary<string, InputDistributeDelay> InputDistributeDelayMap = new Dictionary<string, InputDistributeDelay>();

		// Token: 0x04019534 RID: 103732
		private readonly Dictionary<string, InputKeyHandle> InputKeyHandleMap = new Dictionary<string, InputKeyHandle>();

		// Token: 0x04019535 RID: 103733
		private readonly Dictionary<string, InputActionHandle> InputActionHandleMap = new Dictionary<string, InputActionHandle>();

		// Token: 0x04019536 RID: 103734
		private readonly Dictionary<string, InputAxisHandle> InputAxisHandleMap = new Dictionary<string, InputAxisHandle>();

		// Token: 0x04019537 RID: 103735
		private readonly Dictionary<int, InputTouchHandle> InputTouchHandleMap = new Dictionary<int, InputTouchHandle>();

		// Token: 0x04019538 RID: 103736
		private readonly HashSet<EUiViewName> NotAllowFightInputViewNameSet = new HashSet<EUiViewName>();

		// Token: 0x04019539 RID: 103737
		[Nullable(2)]
		private string CurrentActionName;

		// Token: 0x0401953A RID: 103738
		[Nullable(2)]
		private string CurrentAxisName;

		// Token: 0x0401953B RID: 103739
		private readonly Dictionary<string, HashSet<TInputTagChangedCallback>> TagChangedCallbacks = new Dictionary<string, HashSet<TInputTagChangedCallback>>();

		// Token: 0x0401953C RID: 103740
		private float LastAxisValue;

		// Token: 0x0401953D RID: 103741
		private bool PreventIgnoredActionEnabled;

		// Token: 0x0401953E RID: 103742
		private readonly HashSet<string> PreventIgnoredActionSet = new HashSet<string>();

		// Token: 0x0401953F RID: 103743
		[Nullable(2)]
		private static InputDistributeModel _Instance;
	}
}
