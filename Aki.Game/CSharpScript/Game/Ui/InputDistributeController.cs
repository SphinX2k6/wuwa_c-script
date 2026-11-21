using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035A6 RID: 13734
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class InputDistributeController : ControllerBase
	{
		// Token: 0x06022FFD RID: 143357 RVA: 0x009F412A File Offset: 0x009F232A
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x06022FFE RID: 143358 RVA: 0x009F4133 File Offset: 0x009F2333
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x06022FFF RID: 143359 RVA: 0x009F413C File Offset: 0x009F233C
		private void AddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnAddNotAllowFightInputViewName, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnRemoveNotAllowFightInputViewName, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnClearNotAllowFightInputViewName, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.ShowHUD, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.HideHUD, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.ReConnectBegin, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.ReConnectSuccess, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.LogOut, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnStartLoadingState, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.ResetModuleByResetToBattleView, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.SdkKick, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add<bool>(EEventName.CharOnRoleDrown, new Action<bool>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnPlotWaitViewDone, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add<bool, string>(EEventName.OnCameraSequenceSetUiVisible, new Action<bool, string>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnEnterTransitionMap, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add<bool, string>(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Add(EEventName.OnOnlyAllowFightInputStateChanged, new Action(this.OnOnlyAllowFightInputStateChanged));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewBegined, new Action<EUiViewName>(this.OnOpenViewBegined));
			EventSystem.Instance.Add<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OnOpenViewFail));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.FloatQueueCloseView, new Action<EUiViewName, int>(this.OnFloatQueueCloseView));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ResetModuleByResetToBattleView, new Action(this.OnResetModuleByResetToBattleView));
		}

		// Token: 0x06023000 RID: 143360 RVA: 0x009F444C File Offset: 0x009F264C
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnAddNotAllowFightInputViewName, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnRemoveNotAllowFightInputViewName, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnClearNotAllowFightInputViewName, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.ShowHUD, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.HideHUD, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.ReConnectBegin, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.ReConnectSuccess, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.LogOut, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove<bool>(EEventName.OnShowMouseCursor, new Action<bool>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnStartLoadingState, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.ResetModuleByResetToBattleView, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.SdkKick, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove<bool>(EEventName.CharOnRoleDrown, new Action<bool>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnPlotWaitViewDone, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove<EOperationType, EOperationType>(EEventName.ShowTypeChange, new Action<EOperationType, EOperationType>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove<bool, string>(EEventName.OnCameraSequenceSetUiVisible, new Action<bool, string>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnEnterTransitionMap, new Action(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove<bool, string>(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.OnRefreshInputDistributeTag));
			EventSystem.Instance.Remove(EEventName.OnOnlyAllowFightInputStateChanged, new Action(this.OnOnlyAllowFightInputStateChanged));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewBegined, new Action<EUiViewName>(this.OnOpenViewBegined));
			EventSystem.Instance.Remove<EUiViewName>(EEventName.OpenViewFail, new Action<EUiViewName>(this.OnOpenViewFail));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.FloatQueueCloseView, new Action<EUiViewName, int>(this.OnFloatQueueCloseView));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ResetModuleByResetToBattleView, new Action(this.OnResetModuleByResetToBattleView));
		}

		// Token: 0x06023001 RID: 143361 RVA: 0x009F4759 File Offset: 0x009F2959
		private void OnRefreshInputDistributeTag(bool _)
		{
			this.RefreshInputTag();
		}

		// Token: 0x06023002 RID: 143362 RVA: 0x009F4761 File Offset: 0x009F2961
		private void OnRefreshInputDistributeTag(bool _, string _1)
		{
			this.RefreshInputTag();
		}

		// Token: 0x06023003 RID: 143363 RVA: 0x009F4769 File Offset: 0x009F2969
		private void OnOnlyAllowFightInputStateChanged()
		{
			this.RefreshInputTag();
		}

		// Token: 0x06023004 RID: 143364 RVA: 0x009F4771 File Offset: 0x009F2971
		private void OnRefreshInputDistributeTag(EOperationType last, EOperationType now)
		{
			this.RefreshInputTag();
		}

		// Token: 0x06023005 RID: 143365 RVA: 0x009F4779 File Offset: 0x009F2979
		private void OnRefreshInputDistributeTag()
		{
			this.RefreshInputTag();
		}

		// Token: 0x06023006 RID: 143366 RVA: 0x009F4784 File Offset: 0x009F2984
		private void OnWorldDone()
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "当世界加载完成时，清理所有输入分发Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ClearAllNotAllowFightInputViewNames();
		}

		// Token: 0x06023007 RID: 143367 RVA: 0x009F47B4 File Offset: 0x009F29B4
		private void OnResetModuleByResetToBattleView()
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]当回到主界面时，清理所有输入分发Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ClearAllNotAllowFightInputViewNames();
		}

		// Token: 0x06023008 RID: 143368 RVA: 0x009F47E4 File Offset: 0x009F29E4
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (!InputDistributeConfig.Instance.IsViewAllowFightInput(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputDistribute]当打开界面时, 记录不允许输入的界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				InputDistributeModel.Instance.AddNotAllowFightInputViewName(viewName);
			}
			EventSystem.Instance.Emit(EEventName.OnAddNotAllowFightInputViewName);
		}

		// Token: 0x06023009 RID: 143369 RVA: 0x009F4848 File Offset: 0x009F2A48
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			if (!InputDistributeConfig.Instance.IsViewAllowFightInput(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputDistribute]当关闭界面时, 删除不允许输入的界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				InputDistributeModel.Instance.RemoveNotAllowFightInputViewName(viewName);
			}
			EventSystem.Instance.Emit(EEventName.OnRemoveNotAllowFightInputViewName);
		}

		// Token: 0x0602300A RID: 143370 RVA: 0x009F48AC File Offset: 0x009F2AAC
		private void OnOpenViewBegined(EUiViewName viewName)
		{
			if (!InputDistributeConfig.Instance.IsViewAllowFightInput(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputDistribute]当打开界面开始时, 将界面添加至“不允许战斗输入”Set中";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				InputDistributeModel.Instance.AddNotAllowFightInputViewName(viewName);
			}
			EventSystem.Instance.Emit(EEventName.OnAddNotAllowFightInputViewName);
		}

		// Token: 0x0602300B RID: 143371 RVA: 0x009F4910 File Offset: 0x009F2B10
		private void OnOpenViewFail(EUiViewName viewName)
		{
			if (!InputDistributeConfig.Instance.IsViewAllowFightInput(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputDistribute]当打开界面结束时, 清理“不允许战斗输入”Set";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				InputDistributeModel.Instance.RemoveNotAllowFightInputViewName(viewName);
			}
			EventSystem.Instance.Emit(EEventName.OnRemoveNotAllowFightInputViewName);
		}

		// Token: 0x0602300C RID: 143372 RVA: 0x009F4974 File Offset: 0x009F2B74
		private void OnFloatQueueCloseView(EUiViewName viewName, int viewId)
		{
			if (!InputDistributeConfig.Instance.IsViewAllowFightInput(viewName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Input;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[InputDistribute]当Float队列关闭界面时, 删除不允许输入的界面";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				InputDistributeModel.Instance.RemoveNotAllowFightInputViewName(viewName);
			}
			EventSystem.Instance.Emit(EEventName.OnRemoveNotAllowFightInputViewName);
		}

		// Token: 0x0602300D RID: 143373 RVA: 0x009F49D5 File Offset: 0x009F2BD5
		private void ClearAllNotAllowFightInputViewNames()
		{
			InputDistributeModel.Instance.ClearAllNotAllowFightInputViewNames();
			EventSystem.Instance.Emit(EEventName.OnClearNotAllowFightInputViewName);
		}

		// Token: 0x0602300E RID: 143374 RVA: 0x009F49F1 File Offset: 0x009F2BF1
		public void RefreshInputTag()
		{
			InputDistributeModel.Instance.RefreshInputDistributeTag();
		}

		// Token: 0x0602300F RID: 143375 RVA: 0x009F49FD File Offset: 0x009F2BFD
		public void BindAction(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindAction(actionName, actionCallback);
		}

		// Token: 0x06023010 RID: 143376 RVA: 0x009F4A0B File Offset: 0x009F2C0B
		public void ExecuteDelayInputAction(string actionName)
		{
			InputDistributeModel.Instance.ExecuteDelayInputAction(actionName);
		}

		// Token: 0x06023011 RID: 143377 RVA: 0x009F4A18 File Offset: 0x009F2C18
		public void BindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindActions(actionNames, actionCallback);
		}

		// Token: 0x06023012 RID: 143378 RVA: 0x009F4A26 File Offset: 0x009F2C26
		public void UnBindAction(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindAction(actionName, actionCallback);
		}

		// Token: 0x06023013 RID: 143379 RVA: 0x009F4A34 File Offset: 0x009F2C34
		public void UnBindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindActions(actionNames, actionCallback);
		}

		// Token: 0x06023014 RID: 143380 RVA: 0x009F4A42 File Offset: 0x009F2C42
		public void BindActionIgnoreLimit(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindActionIgnoreLimit(actionName, actionCallback);
		}

		// Token: 0x06023015 RID: 143381 RVA: 0x009F4A50 File Offset: 0x009F2C50
		public void UnBindActionIgnoreLimit(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindActionIgnoreLimit(actionName, actionCallback);
		}

		// Token: 0x06023016 RID: 143382 RVA: 0x009F4A5E File Offset: 0x009F2C5E
		public void BindAxis(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.BindAxis(axisName, axisCallback);
		}

		// Token: 0x06023017 RID: 143383 RVA: 0x009F4A6C File Offset: 0x009F2C6C
		public void BindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.BindAxes(axisNames, axisCallback);
		}

		// Token: 0x06023018 RID: 143384 RVA: 0x009F4A7A File Offset: 0x009F2C7A
		public void UnBindAxis(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.UnBindAxis(axisName, axisCallback);
		}

		// Token: 0x06023019 RID: 143385 RVA: 0x009F4A88 File Offset: 0x009F2C88
		public void UnBindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.UnBindAxes(axisNames, axisCallback);
		}

		// Token: 0x0602301A RID: 143386 RVA: 0x009F4A96 File Offset: 0x009F2C96
		public bool HasAxisBind(string axisName)
		{
			return InputDistributeModel.Instance.HasAxisBind(axisName);
		}

		// Token: 0x0602301B RID: 143387 RVA: 0x009F4AA3 File Offset: 0x009F2CA3
		public bool HasActionBind(string actionName)
		{
			return InputDistributeModel.Instance.HasActionBind(actionName);
		}

		// Token: 0x0602301C RID: 143388 RVA: 0x009F4AB0 File Offset: 0x009F2CB0
		public bool IsActionRespondable(string actionName)
		{
			return InputDistributeModel.Instance.IsActionRespondable(actionName);
		}

		// Token: 0x0602301D RID: 143389 RVA: 0x009F4ABD File Offset: 0x009F2CBD
		public void BindAxisIgnoreLimit(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.BindAxisIgnoreLimit(axisName, axisCallback);
		}

		// Token: 0x0602301E RID: 143390 RVA: 0x009F4ACB File Offset: 0x009F2CCB
		public void UnBindAxisIgnoreLimit(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.UnBindAxisIgnoreLimit(axisName, axisCallback);
		}

		// Token: 0x0602301F RID: 143391 RVA: 0x009F4AD9 File Offset: 0x009F2CD9
		public void BindTouch(int touchId, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.BindTouch(touchId, touchCallback);
		}

		// Token: 0x06023020 RID: 143392 RVA: 0x009F4AE7 File Offset: 0x009F2CE7
		public void BindTouches(int[] touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.BindTouches(touchIdList, touchCallback);
		}

		// Token: 0x06023021 RID: 143393 RVA: 0x009F4AF5 File Offset: 0x009F2CF5
		public void UnBindTouch(int touchId, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.UnBindTouch(touchId, touchCallback);
		}

		// Token: 0x06023022 RID: 143394 RVA: 0x009F4B03 File Offset: 0x009F2D03
		public void UnBindTouches(IReadOnlyList<int> touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.UnBindTouches(touchIdList, touchCallback);
		}

		// Token: 0x06023023 RID: 143395 RVA: 0x009F4B11 File Offset: 0x009F2D11
		public void BindKey(string keyName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindKey(keyName, actionCallback);
		}

		// Token: 0x06023024 RID: 143396 RVA: 0x009F4B1F File Offset: 0x009F2D1F
		public void UnBindKey(string keyName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindKey(keyName, actionCallback);
		}

		// Token: 0x06023025 RID: 143397 RVA: 0x009F4B2D File Offset: 0x009F2D2D
		public void InputAxis(string axisName, float value, bool force = false)
		{
			if (Math.Abs(value) <= 0.02f)
			{
				InputDistributeModel.Instance.InputAxis(axisName, 0f, force);
				return;
			}
			InputDistributeModel.Instance.InputAxis(axisName, value, force);
		}

		// Token: 0x06023026 RID: 143398 RVA: 0x009F4B5B File Offset: 0x009F2D5B
		public bool IsAxisRespondable(string axisName)
		{
			return InputDistributeModel.Instance.IsAxisRespondable(axisName);
		}

		// Token: 0x06023027 RID: 143399 RVA: 0x009F4B68 File Offset: 0x009F2D68
		public bool InputAction(string actionName, bool bPress)
		{
			return InputDistributeModel.Instance.InputAction(actionName, bPress);
		}

		// Token: 0x06023028 RID: 143400 RVA: 0x009F4B76 File Offset: 0x009F2D76
		public void InputTouch(int touchId, InputDistributeDefine.ITouchData touchData)
		{
			InputDistributeModel.Instance.InputTouch(touchId, touchData);
		}

		// Token: 0x06023029 RID: 143401 RVA: 0x009F4B84 File Offset: 0x009F2D84
		public void InputKey(string keyName, bool bPress)
		{
			InputDistributeModel.Instance.InputKey(keyName, bPress);
		}

		// Token: 0x0602302A RID: 143402 RVA: 0x009F4B92 File Offset: 0x009F2D92
		[NullableContext(2)]
		public string GetCurrentActionName()
		{
			return InputDistributeModel.Instance.GetCurrentActionName();
		}

		// Token: 0x0602302B RID: 143403 RVA: 0x009F4B9E File Offset: 0x009F2D9E
		[NullableContext(2)]
		public string GetCurrentAxisName()
		{
			return InputDistributeModel.Instance.GetCurrentAxisName();
		}

		// Token: 0x0602302C RID: 143404 RVA: 0x009F4BAA File Offset: 0x009F2DAA
		public bool IsAllowFightInput()
		{
			return InputDistributeModel.Instance.IsAllowFightInput();
		}

		// Token: 0x0602302D RID: 143405 RVA: 0x009F4BB6 File Offset: 0x009F2DB6
		public bool IsAllowFightMoveInput()
		{
			return InputDistributeModel.Instance.IsAllowFightMoveInput();
		}

		// Token: 0x0602302E RID: 143406 RVA: 0x009F4BC2 File Offset: 0x009F2DC2
		public bool IsAllowFightActionInput()
		{
			return InputDistributeModel.Instance.IsAllowFightActionInput();
		}

		// Token: 0x0602302F RID: 143407 RVA: 0x009F4BCE File Offset: 0x009F2DCE
		public bool IsAllowFightCameraRotationInput()
		{
			return InputDistributeModel.Instance.IsAllowFightCameraRotationInput();
		}

		// Token: 0x06023030 RID: 143408 RVA: 0x009F4BDA File Offset: 0x009F2DDA
		public bool IsAllowFightCameraZoomInput()
		{
			return InputDistributeModel.Instance.IsAllowFightCameraZoomInput();
		}

		// Token: 0x06023031 RID: 143409 RVA: 0x009F4BE6 File Offset: 0x009F2DE6
		public bool IsAllowHeadRotation()
		{
			return InputDistributeModel.Instance.IsAllowHeadRotation();
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x06023032 RID: 143410 RVA: 0x009F4BF2 File Offset: 0x009F2DF2
		public static InputDistributeController Instance
		{
			get
			{
				return InputDistributeController._Instance;
			}
		}

		// Token: 0x06023033 RID: 143411 RVA: 0x009F4BF9 File Offset: 0x009F2DF9
		public static InputDistributeController GetOrCreateInstance()
		{
			if (InputDistributeController._Instance == null)
			{
				InputDistributeController.CreateInstance();
			}
			return InputDistributeController._Instance;
		}

		// Token: 0x06023034 RID: 143412 RVA: 0x009F4C0D File Offset: 0x009F2E0D
		public static bool CreateInstance()
		{
			if (InputDistributeController._Instance != null)
			{
				return true;
			}
			InputDistributeController._Instance = new InputDistributeController();
			return true;
		}

		// Token: 0x06023035 RID: 143413 RVA: 0x009F4C23 File Offset: 0x009F2E23
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023036 RID: 143414 RVA: 0x009F4C25 File Offset: 0x009F2E25
		public static void ResetStaticDefaultValue()
		{
			InputDistributeController._Instance = null;
		}

		// Token: 0x06023037 RID: 143415 RVA: 0x009F4C2D File Offset: 0x009F2E2D
		static InputDistributeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDistributeController.CreateStaticDefaultValue), new Action(InputDistributeController.ResetStaticDefaultValue));
		}

		// Token: 0x04013BC0 RID: 80832
		[Nullable(2)]
		private static InputDistributeController _Instance;
	}
}
