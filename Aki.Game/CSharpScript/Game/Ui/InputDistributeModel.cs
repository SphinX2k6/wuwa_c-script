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
	// Token: 0x020035AE RID: 13742
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class InputDistributeModel : ModelBase
	{
		// Token: 0x0602305F RID: 143455 RVA: 0x009F5349 File Offset: 0x009F3549
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

		// Token: 0x06023060 RID: 143456 RVA: 0x009F537C File Offset: 0x009F357C
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

		// Token: 0x06023061 RID: 143457 RVA: 0x009F54A4 File Offset: 0x009F36A4
		private void InitializeInputDistributeSetup()
		{
			Type[] inputDistributeSetups = InputDistributeSetupDefine.inputDistributeSetups;
			for (int i = 0; i < inputDistributeSetups.Length; i++)
			{
				object obj = Activator.CreateInstance(inputDistributeSetups[i]);
				this.InputDistributeSetups.Add((InputDistributeSetup)obj);
			}
		}

		// Token: 0x06023062 RID: 143458 RVA: 0x009F54E0 File Offset: 0x009F36E0
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

		// Token: 0x06023063 RID: 143459 RVA: 0x009F5534 File Offset: 0x009F3734
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

		// Token: 0x06023064 RID: 143460 RVA: 0x009F55F4 File Offset: 0x009F37F4
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

		// Token: 0x06023065 RID: 143461 RVA: 0x009F56B4 File Offset: 0x009F38B4
		private void InitializeTouchHandles()
		{
			foreach (KeyValuePair<int, string> keyValuePair in InputDistributeDefine.touchTagMap)
			{
				int key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.NewInputTouchHandle(key, value);
			}
		}

		// Token: 0x06023066 RID: 143462 RVA: 0x009F5718 File Offset: 0x009F3918
		private void InitializeKeyHandles()
		{
			foreach (KeyValuePair<string, string> keyValuePair in InputDistributeDefine.keyTagMap)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				this.NewInputKeyHandle(key, value);
			}
		}

		// Token: 0x06023067 RID: 143463 RVA: 0x009F577C File Offset: 0x009F397C
		public bool IsActionInPress(string actionName)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			return inputActionHandle != null && inputActionHandle.GetIsPress();
		}

		// Token: 0x06023068 RID: 143464 RVA: 0x009F579C File Offset: 0x009F399C
		public bool IsAxisInPress(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			return inputAxisHandle != null && inputAxisHandle.GetCacheAxisValue() != 0f;
		}

		// Token: 0x06023069 RID: 143465 RVA: 0x009F57C6 File Offset: 0x009F39C6
		public bool HasAxisBind(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			return inputAxisHandle != null && inputAxisHandle.HasCallback();
		}

		// Token: 0x0602306A RID: 143466 RVA: 0x009F57DA File Offset: 0x009F39DA
		public bool HasActionBind(string actionName)
		{
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			return inputActionHandle != null && inputActionHandle.HasCallback();
		}

		// Token: 0x0602306B RID: 143467 RVA: 0x009F57F0 File Offset: 0x009F39F0
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

		// Token: 0x0602306C RID: 143468 RVA: 0x009F5858 File Offset: 0x009F3A58
		public unsafe bool InputAction(string actionName, bool bPress)
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
			bool flag = actionName == "通用交互" && Info.Instance.IsInGamepad();
			InputModel instance2 = InputModel.Instance;
			BattleInputData battleInputData = (instance2 != null) ? instance2.GetCurrentInputData() : null;
			if (battleInputData != null && !battleInputData.CheckActionInAllowFightActionNameList(actionName, inputActionHandle))
			{
				if (flag)
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.Input;
					ELogAuthor author2 = ELogAuthor.CFT;
					string message2 = "[破弱排查]4 通用交互被拦截: CheckActionInAllowFightActionNameList为false";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("bPress", bPress);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("inputData", battleInputData.GetType().Name);
					instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
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
					if (flag)
					{
						Log instance4 = Log.Instance;
						ELogModule module3 = ELogModule.Input;
						ELogAuthor author3 = ELogAuthor.CFT;
						string message3 = "[破弱排查]5 通用交互被拦截: 存在引导限制ActionLimitSet且不包含通用交互";
						ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("bPress", bPress);
						instance4.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					}
					EventSystem.Instance.Emit<string, bool>(EEventName.GuideLimitActionInput, actionName, bPress);
					return false;
				}
			}
			else
			{
				string inputDistributeTag = inputActionHandle.GetInputDistributeTag();
				if (!string.IsNullOrEmpty(inputDistributeTag) && !this.IsTagMatchAnyCurrentInputTag(inputDistributeTag, false))
				{
					if (flag)
					{
						Log instance5 = Log.Instance;
						ELogModule module4 = ELogModule.Input;
						ELogAuthor author4 = ELogAuthor.CFT;
						string message4 = "[破弱排查]6 通用交互被拦截: 输入分发Tag不匹配";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("bPress", bPress);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("actionTag", inputDistributeTag);
						instance5.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
					if (!bPress)
					{
						inputActionHandle.TryReleaseActionIfLimitInputDistributeTag();
					}
					inputActionHandle.InputActionIgnoreLimit(bPress);
					return false;
				}
				if (!this.CheckFightActionInputAllow(actionName, inputDistributeTag))
				{
					if (flag)
					{
						Log instance6 = Log.Instance;
						ELogModule module5 = ELogModule.Input;
						ELogAuthor author5 = ELogAuthor.CFT;
						string message5 = "[破弱排查]7 通用交互被拦截: CheckFightActionInputAllow为false(与导航界面快捷键冲突)";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("bPress", bPress);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("actionTag", inputDistributeTag);
						instance6.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
					return false;
				}
			}
			if (flag)
			{
				Log instance7 = Log.Instance;
				ELogModule module6 = ELogModule.Input;
				ELogAuthor author6 = ELogAuthor.CFT;
				string message6 = "[破弱排查]通用交互分发给回调";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("bPress", bPress);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("hasCallback", inputActionHandle.HasCallback());
				instance7.Info(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
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

		// Token: 0x0602306D RID: 143469 RVA: 0x009F5B90 File Offset: 0x009F3D90
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

		// Token: 0x0602306E RID: 143470 RVA: 0x009F5BE0 File Offset: 0x009F3DE0
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

		// Token: 0x0602306F RID: 143471 RVA: 0x009F5C2D File Offset: 0x009F3E2D
		[NullableContext(2)]
		public string GetCurrentActionName()
		{
			return this.CurrentActionName;
		}

		// Token: 0x06023070 RID: 143472 RVA: 0x009F5C38 File Offset: 0x009F3E38
		public void InputCacheAxisValue(string axisName, float value)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				return;
			}
			inputAxisHandle.InputCacheAxisValue(value);
		}

		// Token: 0x06023071 RID: 143473 RVA: 0x009F5C58 File Offset: 0x009F3E58
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

		// Token: 0x06023072 RID: 143474 RVA: 0x009F5DC0 File Offset: 0x009F3FC0
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

		// Token: 0x06023073 RID: 143475 RVA: 0x009F5E26 File Offset: 0x009F4026
		[NullableContext(2)]
		public string GetCurrentAxisName()
		{
			return this.CurrentAxisName;
		}

		// Token: 0x06023074 RID: 143476 RVA: 0x009F5E30 File Offset: 0x009F4030
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

		// Token: 0x06023075 RID: 143477 RVA: 0x009F5E94 File Offset: 0x009F4094
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

		// Token: 0x06023076 RID: 143478 RVA: 0x009F5EDC File Offset: 0x009F40DC
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

		// Token: 0x06023077 RID: 143479 RVA: 0x009F5F24 File Offset: 0x009F4124
		public void BindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			foreach (string actionName in actionNames)
			{
				this.BindAction(actionName, actionCallback);
			}
		}

		// Token: 0x06023078 RID: 143480 RVA: 0x009F5F70 File Offset: 0x009F4170
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

		// Token: 0x06023079 RID: 143481 RVA: 0x009F5FB8 File Offset: 0x009F41B8
		public void UnBindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			foreach (string actionName in actionNames)
			{
				this.UnBindAction(actionName, actionCallback);
			}
		}

		// Token: 0x0602307A RID: 143482 RVA: 0x009F6004 File Offset: 0x009F4204
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

		// Token: 0x0602307B RID: 143483 RVA: 0x009F604C File Offset: 0x009F424C
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

		// Token: 0x0602307C RID: 143484 RVA: 0x009F6093 File Offset: 0x009F4293
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

		// Token: 0x0602307D RID: 143485 RVA: 0x009F60C8 File Offset: 0x009F42C8
		public bool IsPreventIgnoredAction(string actionName)
		{
			if (!this.PreventIgnoredActionEnabled)
			{
				return false;
			}
			InputActionHandle inputActionHandle = this.GetInputActionHandle(actionName);
			return inputActionHandle != null && inputActionHandle.HasIgnoreLimit();
		}

		// Token: 0x0602307E RID: 143486 RVA: 0x009F60F4 File Offset: 0x009F42F4
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

		// Token: 0x0602307F RID: 143487 RVA: 0x009F612C File Offset: 0x009F432C
		[return: Nullable(2)]
		private InputActionHandle GetInputActionHandle(string actionName)
		{
			InputActionHandle result;
			this.InputActionHandleMap.TryGetValue(actionName, out result);
			return result;
		}

		// Token: 0x06023080 RID: 143488 RVA: 0x009F614C File Offset: 0x009F434C
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

		// Token: 0x06023081 RID: 143489 RVA: 0x009F6194 File Offset: 0x009F4394
		public void BindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			foreach (string axisName in axisNames)
			{
				this.BindAxis(axisName, axisCallback);
			}
		}

		// Token: 0x06023082 RID: 143490 RVA: 0x009F61E0 File Offset: 0x009F43E0
		public float GetAxisValue(string axisName)
		{
			InputAxisHandle inputAxisHandle = this.GetInputAxisHandle(axisName);
			if (inputAxisHandle == null)
			{
				return 0f;
			}
			return inputAxisHandle.GetCacheAxisValue();
		}

		// Token: 0x06023083 RID: 143491 RVA: 0x009F6204 File Offset: 0x009F4404
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

		// Token: 0x06023084 RID: 143492 RVA: 0x009F624C File Offset: 0x009F444C
		public void UnBindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			foreach (string axisName in axisNames)
			{
				this.UnBindAxis(axisName, axisCallback);
			}
		}

		// Token: 0x06023085 RID: 143493 RVA: 0x009F6298 File Offset: 0x009F4498
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

		// Token: 0x06023086 RID: 143494 RVA: 0x009F62E0 File Offset: 0x009F44E0
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

		// Token: 0x06023087 RID: 143495 RVA: 0x009F6328 File Offset: 0x009F4528
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

		// Token: 0x06023088 RID: 143496 RVA: 0x009F6364 File Offset: 0x009F4564
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

		// Token: 0x06023089 RID: 143497 RVA: 0x009F63B0 File Offset: 0x009F45B0
		public void BindTouches(int[] touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			foreach (int touchId in touchIdList)
			{
				this.BindTouch(touchId, touchCallback);
			}
		}

		// Token: 0x0602308A RID: 143498 RVA: 0x009F63DC File Offset: 0x009F45DC
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

		// Token: 0x0602308B RID: 143499 RVA: 0x009F6428 File Offset: 0x009F4628
		public void UnBindTouches(IReadOnlyList<int> touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			foreach (int touchId in touchIdList)
			{
				this.UnBindTouch(touchId, touchCallback);
			}
		}

		// Token: 0x0602308C RID: 143500 RVA: 0x009F6474 File Offset: 0x009F4674
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

		// Token: 0x0602308D RID: 143501 RVA: 0x009F64AC File Offset: 0x009F46AC
		[return: Nullable(2)]
		private InputAxisHandle GetInputAxisHandle(string actionName)
		{
			InputAxisHandle result;
			this.InputAxisHandleMap.TryGetValue(actionName, out result);
			return result;
		}

		// Token: 0x0602308E RID: 143502 RVA: 0x009F64CC File Offset: 0x009F46CC
		private InputTouchHandle NewInputTouchHandle(int touchId, string inputDistributeTag)
		{
			InputTouchHandle inputTouchHandle = new InputTouchHandle(inputDistributeTag, touchId.ToString());
			this.InputTouchHandleMap[touchId] = inputTouchHandle;
			return inputTouchHandle;
		}

		// Token: 0x0602308F RID: 143503 RVA: 0x009F64F8 File Offset: 0x009F46F8
		[NullableContext(2)]
		private InputTouchHandle GetInputTouchHandle(int touchId)
		{
			InputTouchHandle result;
			this.InputTouchHandleMap.TryGetValue(touchId, out result);
			return result;
		}

		// Token: 0x06023090 RID: 143504 RVA: 0x009F6518 File Offset: 0x009F4718
		private InputKeyHandle NewInputKeyHandle(string keyName, string inputDistributeTag)
		{
			InputKeyHandle inputKeyHandle = new InputKeyHandle(inputDistributeTag, keyName);
			this.InputKeyHandleMap[keyName] = inputKeyHandle;
			return inputKeyHandle;
		}

		// Token: 0x06023091 RID: 143505 RVA: 0x009F653C File Offset: 0x009F473C
		[return: Nullable(2)]
		private InputKeyHandle GetInputKeyHandle(string keyName)
		{
			InputKeyHandle result;
			this.InputKeyHandleMap.TryGetValue(keyName, out result);
			return result;
		}

		// Token: 0x06023092 RID: 143506 RVA: 0x009F655C File Offset: 0x009F475C
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

		// Token: 0x06023093 RID: 143507 RVA: 0x009F65A4 File Offset: 0x009F47A4
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

		// Token: 0x06023094 RID: 143508 RVA: 0x009F65EC File Offset: 0x009F47EC
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

		// Token: 0x06023095 RID: 143509 RVA: 0x009F6621 File Offset: 0x009F4821
		public bool HasAnyNotAllowFightInputViewIsOpen()
		{
			return this.NotAllowFightInputViewNameSet.Count > 0;
		}

		// Token: 0x06023096 RID: 143510 RVA: 0x009F6631 File Offset: 0x009F4831
		public bool HasNotAllowFightInputViewIsOpen(EUiViewName uiViewName)
		{
			return this.NotAllowFightInputViewNameSet.Contains(uiViewName);
		}

		// Token: 0x06023097 RID: 143511 RVA: 0x009F663F File Offset: 0x009F483F
		public void AddNotAllowFightInputViewName(EUiViewName uiViewName)
		{
			this.NotAllowFightInputViewNameSet.Add(uiViewName);
		}

		// Token: 0x06023098 RID: 143512 RVA: 0x009F664E File Offset: 0x009F484E
		public void RemoveNotAllowFightInputViewName(EUiViewName uiViewName)
		{
			this.NotAllowFightInputViewNameSet.Remove(uiViewName);
		}

		// Token: 0x06023099 RID: 143513 RVA: 0x009F665D File Offset: 0x009F485D
		public void ClearAllNotAllowFightInputViewNames()
		{
			this.NotAllowFightInputViewNameSet.Clear();
		}

		// Token: 0x0602309A RID: 143514 RVA: 0x009F666A File Offset: 0x009F486A
		public HashSet<EUiViewName> GetNotAllowFightInputViewNameSet()
		{
			return this.NotAllowFightInputViewNameSet;
		}

		// Token: 0x0602309B RID: 143515 RVA: 0x009F6674 File Offset: 0x009F4874
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

		// Token: 0x0602309C RID: 143516 RVA: 0x009F66DC File Offset: 0x009F48DC
		private InputDistributeTag NewInputDistributeTag(string tag, [Nullable(2)] InputDistributeTag parentTag = null)
		{
			InputDistributeTag inputDistributeTag = new InputDistributeTag(tag, parentTag);
			this.InputDistributeTagMap[tag] = inputDistributeTag;
			return inputDistributeTag;
		}

		// Token: 0x0602309D RID: 143517 RVA: 0x009F6700 File Offset: 0x009F4900
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

		// Token: 0x0602309E RID: 143518 RVA: 0x009F6724 File Offset: 0x009F4924
		public bool MatchTag(string tag, InputDistributeTag inputDistributeTag, bool bExactMatch = false)
		{
			InputDistributeTag inputDistributeTag2 = this.GetInputDistributeTag(tag);
			return inputDistributeTag != null && inputDistributeTag2.MatchTag(inputDistributeTag.TagName, bExactMatch);
		}

		// Token: 0x0602309F RID: 143519 RVA: 0x009F674B File Offset: 0x009F494B
		public bool IsTagMatchAnyCurrentInputTag(string tag, bool bExactMatch = false)
		{
			return this.IsTagMatchAnyInputDistributeTags(tag, this.InputDistributeTags, bExactMatch);
		}

		// Token: 0x060230A0 RID: 143520 RVA: 0x009F675C File Offset: 0x009F495C
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

		// Token: 0x060230A1 RID: 143521 RVA: 0x009F67B4 File Offset: 0x009F49B4
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

		// Token: 0x060230A2 RID: 143522 RVA: 0x009F681C File Offset: 0x009F4A1C
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

		// Token: 0x060230A3 RID: 143523 RVA: 0x009F6858 File Offset: 0x009F4A58
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

		// Token: 0x060230A4 RID: 143524 RVA: 0x009F689C File Offset: 0x009F4A9C
		public void ClearLimitInputDistributeActions()
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]清除输入分发限制Action", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.LimitInputDistributeActionSet.Clear();
		}

		// Token: 0x060230A5 RID: 143525 RVA: 0x009F68D0 File Offset: 0x009F4AD0
		public bool HasActionLimitSet()
		{
			return this.LimitInputDistributeActionSet.Count > 0;
		}

		// Token: 0x060230A6 RID: 143526 RVA: 0x009F68E0 File Offset: 0x009F4AE0
		public bool IsActionInLimitSet(string actionName)
		{
			return this.LimitInputDistributeActionSet.Contains(actionName);
		}

		// Token: 0x060230A7 RID: 143527 RVA: 0x009F68F0 File Offset: 0x009F4AF0
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

		// Token: 0x060230A8 RID: 143528 RVA: 0x009F694C File Offset: 0x009F4B4C
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

		// Token: 0x060230A9 RID: 143529 RVA: 0x009F6974 File Offset: 0x009F4B74
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

		// Token: 0x060230AA RID: 143530 RVA: 0x009F69E4 File Offset: 0x009F4BE4
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

		// Token: 0x060230AB RID: 143531 RVA: 0x009F6A78 File Offset: 0x009F4C78
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

		// Token: 0x060230AC RID: 143532 RVA: 0x009F6B6C File Offset: 0x009F4D6C
		public void ClearInputDistributeTag()
		{
			this.InputDistributeTags.Clear();
		}

		// Token: 0x060230AD RID: 143533 RVA: 0x009F6B7C File Offset: 0x009F4D7C
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

		// Token: 0x060230AE RID: 143534 RVA: 0x009F6C28 File Offset: 0x009F4E28
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

		// Token: 0x060230AF RID: 143535 RVA: 0x009F6D48 File Offset: 0x009F4F48
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

		// Token: 0x060230B0 RID: 143536 RVA: 0x009F6D98 File Offset: 0x009F4F98
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

		// Token: 0x060230B1 RID: 143537 RVA: 0x009F6DD5 File Offset: 0x009F4FD5
		public bool IsAllowFightInput()
		{
			return this.IsAnyInputDistributeTagsMatchTag(this.InputDistributeTags, "FightInputRoot", false);
		}

		// Token: 0x060230B2 RID: 143538 RVA: 0x009F6DE9 File Offset: 0x009F4FE9
		public bool IsAllowFightMoveInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.AxisInput.MoveInput", this.InputDistributeTags, false);
		}

		// Token: 0x060230B3 RID: 143539 RVA: 0x009F6DFD File Offset: 0x009F4FFD
		public bool IsAllowFightActionInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.ActionInput", this.InputDistributeTags, false);
		}

		// Token: 0x060230B4 RID: 143540 RVA: 0x009F6E11 File Offset: 0x009F5011
		public bool IsAllowFightCameraRotationInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation", this.InputDistributeTags, false);
		}

		// Token: 0x060230B5 RID: 143541 RVA: 0x009F6E25 File Offset: 0x009F5025
		public bool IsAllowFightCameraZoomInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("FightInputRoot.FightInput.AxisInput.CameraInput.CameraZoom", this.InputDistributeTags, false);
		}

		// Token: 0x060230B6 RID: 143542 RVA: 0x009F6E39 File Offset: 0x009F5039
		public bool IsAllowHeadRotation()
		{
			return this.IsAllowFightInput() || this.IsTagMatchAnyInputDistributeTags("UiInputRoot.MouseInputTag", this.InputDistributeTags, false);
		}

		// Token: 0x060230B7 RID: 143543 RVA: 0x009F6E57 File Offset: 0x009F5057
		public bool IsAllowUiInput()
		{
			return this.IsTagMatchAnyInputDistributeTags("UiInputRoot", this.InputDistributeTags, false);
		}

		// Token: 0x060230B8 RID: 143544 RVA: 0x009F6E6C File Offset: 0x009F506C
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

		// Token: 0x060230B9 RID: 143545 RVA: 0x009F6E94 File Offset: 0x009F5094
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

		// Token: 0x170048EB RID: 18667
		// (get) Token: 0x060230BA RID: 143546 RVA: 0x009F6EBB File Offset: 0x009F50BB
		public static InputDistributeModel Instance
		{
			get
			{
				return InputDistributeModel._Instance;
			}
		}

		// Token: 0x060230BB RID: 143547 RVA: 0x009F6EC2 File Offset: 0x009F50C2
		public static InputDistributeModel GetOrCreateInstance()
		{
			if (InputDistributeModel._Instance == null)
			{
				InputDistributeModel.CreateInstance();
			}
			return InputDistributeModel._Instance;
		}

		// Token: 0x060230BC RID: 143548 RVA: 0x009F6ED6 File Offset: 0x009F50D6
		public static bool CreateInstance()
		{
			if (InputDistributeModel._Instance != null)
			{
				return true;
			}
			InputDistributeModel._Instance = new InputDistributeModel();
			return true;
		}

		// Token: 0x060230BD RID: 143549 RVA: 0x009F6EEC File Offset: 0x009F50EC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060230BE RID: 143550 RVA: 0x009F6EEE File Offset: 0x009F50EE
		public static void ResetStaticDefaultValue()
		{
			InputDistributeModel._Instance = null;
		}

		// Token: 0x060230BF RID: 143551 RVA: 0x009F6EF6 File Offset: 0x009F50F6
		static InputDistributeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDistributeModel.CreateStaticDefaultValue), new Action(InputDistributeModel.ResetStaticDefaultValue));
		}

		// Token: 0x04013BD4 RID: 80852
		private const float EMIT_EVENT_AXIS_DELTA = 0.05f;

		// Token: 0x04013BD5 RID: 80853
		private List<InputDistributeTag> InputDistributeTags = new List<InputDistributeTag>();

		// Token: 0x04013BD6 RID: 80854
		private List<InputDistributeTag> LastInputDistributeTags = new List<InputDistributeTag>();

		// Token: 0x04013BD7 RID: 80855
		private readonly HashSet<string> LimitInputDistributeActionSet = new HashSet<string>();

		// Token: 0x04013BD8 RID: 80856
		private readonly List<InputDistributeSetup> InputDistributeSetups = new List<InputDistributeSetup>();

		// Token: 0x04013BD9 RID: 80857
		private readonly Dictionary<string, InputDistributeTag> InputDistributeTagMap = new Dictionary<string, InputDistributeTag>();

		// Token: 0x04013BDA RID: 80858
		private readonly Dictionary<string, InputDistributeDelay> InputDistributeDelayMap = new Dictionary<string, InputDistributeDelay>();

		// Token: 0x04013BDB RID: 80859
		private readonly Dictionary<string, InputKeyHandle> InputKeyHandleMap = new Dictionary<string, InputKeyHandle>();

		// Token: 0x04013BDC RID: 80860
		private readonly Dictionary<string, InputActionHandle> InputActionHandleMap = new Dictionary<string, InputActionHandle>();

		// Token: 0x04013BDD RID: 80861
		private readonly Dictionary<string, InputAxisHandle> InputAxisHandleMap = new Dictionary<string, InputAxisHandle>();

		// Token: 0x04013BDE RID: 80862
		private readonly Dictionary<int, InputTouchHandle> InputTouchHandleMap = new Dictionary<int, InputTouchHandle>();

		// Token: 0x04013BDF RID: 80863
		private readonly HashSet<EUiViewName> NotAllowFightInputViewNameSet = new HashSet<EUiViewName>();

		// Token: 0x04013BE0 RID: 80864
		[Nullable(2)]
		private string CurrentActionName;

		// Token: 0x04013BE1 RID: 80865
		[Nullable(2)]
		private string CurrentAxisName;

		// Token: 0x04013BE2 RID: 80866
		private readonly Dictionary<string, HashSet<TInputTagChangedCallback>> TagChangedCallbacks = new Dictionary<string, HashSet<TInputTagChangedCallback>>();

		// Token: 0x04013BE3 RID: 80867
		private float LastAxisValue;

		// Token: 0x04013BE4 RID: 80868
		private bool PreventIgnoredActionEnabled;

		// Token: 0x04013BE5 RID: 80869
		private readonly HashSet<string> PreventIgnoredActionSet = new HashSet<string>();

		// Token: 0x04013BE6 RID: 80870
		[Nullable(2)]
		private static InputDistributeModel _Instance;
	}
}
