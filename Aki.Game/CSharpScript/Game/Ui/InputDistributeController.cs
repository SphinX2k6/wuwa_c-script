using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004675 RID: 18037
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class InputDistributeController : ControllerBase
	{
		// Token: 0x0602E8B3 RID: 190643 RVA: 0x00AC65CA File Offset: 0x00AC47CA
		protected override bool OnInit()
		{
			this.AddEvents();
			return true;
		}

		// Token: 0x0602E8B4 RID: 190644 RVA: 0x00AC65D3 File Offset: 0x00AC47D3
		protected override bool OnClear()
		{
			this.RemoveEvents();
			return true;
		}

		// Token: 0x0602E8B5 RID: 190645 RVA: 0x00AC65DC File Offset: 0x00AC47DC
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

		// Token: 0x0602E8B6 RID: 190646 RVA: 0x00AC68EC File Offset: 0x00AC4AEC
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

		// Token: 0x0602E8B7 RID: 190647 RVA: 0x00AC6BF9 File Offset: 0x00AC4DF9
		private void OnRefreshInputDistributeTag(bool _)
		{
			this.RefreshInputTag();
		}

		// Token: 0x0602E8B8 RID: 190648 RVA: 0x00AC6C01 File Offset: 0x00AC4E01
		private void OnRefreshInputDistributeTag(bool _, string _1)
		{
			this.RefreshInputTag();
		}

		// Token: 0x0602E8B9 RID: 190649 RVA: 0x00AC6C09 File Offset: 0x00AC4E09
		private void OnOnlyAllowFightInputStateChanged()
		{
			this.RefreshInputTag();
		}

		// Token: 0x0602E8BA RID: 190650 RVA: 0x00AC6C11 File Offset: 0x00AC4E11
		private void OnRefreshInputDistributeTag(EOperationType last, EOperationType now)
		{
			this.RefreshInputTag();
		}

		// Token: 0x0602E8BB RID: 190651 RVA: 0x00AC6C19 File Offset: 0x00AC4E19
		private void OnRefreshInputDistributeTag()
		{
			this.RefreshInputTag();
		}

		// Token: 0x0602E8BC RID: 190652 RVA: 0x00AC6C24 File Offset: 0x00AC4E24
		private void OnWorldDone()
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "当世界加载完成时，清理所有输入分发Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ClearAllNotAllowFightInputViewNames();
		}

		// Token: 0x0602E8BD RID: 190653 RVA: 0x00AC6C54 File Offset: 0x00AC4E54
		private void OnResetModuleByResetToBattleView()
		{
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]当回到主界面时，清理所有输入分发Tag", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ClearAllNotAllowFightInputViewNames();
		}

		// Token: 0x0602E8BE RID: 190654 RVA: 0x00AC6C84 File Offset: 0x00AC4E84
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

		// Token: 0x0602E8BF RID: 190655 RVA: 0x00AC6CE8 File Offset: 0x00AC4EE8
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

		// Token: 0x0602E8C0 RID: 190656 RVA: 0x00AC6D4C File Offset: 0x00AC4F4C
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

		// Token: 0x0602E8C1 RID: 190657 RVA: 0x00AC6DB0 File Offset: 0x00AC4FB0
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

		// Token: 0x0602E8C2 RID: 190658 RVA: 0x00AC6E14 File Offset: 0x00AC5014
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

		// Token: 0x0602E8C3 RID: 190659 RVA: 0x00AC6E75 File Offset: 0x00AC5075
		private void ClearAllNotAllowFightInputViewNames()
		{
			InputDistributeModel.Instance.ClearAllNotAllowFightInputViewNames();
			EventSystem.Instance.Emit(EEventName.OnClearNotAllowFightInputViewName);
		}

		// Token: 0x0602E8C4 RID: 190660 RVA: 0x00AC6E91 File Offset: 0x00AC5091
		public void RefreshInputTag()
		{
			InputDistributeModel.Instance.RefreshInputDistributeTag();
		}

		// Token: 0x0602E8C5 RID: 190661 RVA: 0x00AC6E9D File Offset: 0x00AC509D
		public void BindAction(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindAction(actionName, actionCallback);
		}

		// Token: 0x0602E8C6 RID: 190662 RVA: 0x00AC6EAB File Offset: 0x00AC50AB
		public void ExecuteDelayInputAction(string actionName)
		{
			InputDistributeModel.Instance.ExecuteDelayInputAction(actionName);
		}

		// Token: 0x0602E8C7 RID: 190663 RVA: 0x00AC6EB8 File Offset: 0x00AC50B8
		public void BindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindActions(actionNames, actionCallback);
		}

		// Token: 0x0602E8C8 RID: 190664 RVA: 0x00AC6EC6 File Offset: 0x00AC50C6
		public void UnBindAction(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindAction(actionName, actionCallback);
		}

		// Token: 0x0602E8C9 RID: 190665 RVA: 0x00AC6ED4 File Offset: 0x00AC50D4
		public void UnBindActions(IReadOnlyList<string> actionNames, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindActions(actionNames, actionCallback);
		}

		// Token: 0x0602E8CA RID: 190666 RVA: 0x00AC6EE2 File Offset: 0x00AC50E2
		public void BindActionIgnoreLimit(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindActionIgnoreLimit(actionName, actionCallback);
		}

		// Token: 0x0602E8CB RID: 190667 RVA: 0x00AC6EF0 File Offset: 0x00AC50F0
		public void UnBindActionIgnoreLimit(string actionName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindActionIgnoreLimit(actionName, actionCallback);
		}

		// Token: 0x0602E8CC RID: 190668 RVA: 0x00AC6EFE File Offset: 0x00AC50FE
		public void BindAxis(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.BindAxis(axisName, axisCallback);
		}

		// Token: 0x0602E8CD RID: 190669 RVA: 0x00AC6F0C File Offset: 0x00AC510C
		public void BindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.BindAxes(axisNames, axisCallback);
		}

		// Token: 0x0602E8CE RID: 190670 RVA: 0x00AC6F1A File Offset: 0x00AC511A
		public void UnBindAxis(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.UnBindAxis(axisName, axisCallback);
		}

		// Token: 0x0602E8CF RID: 190671 RVA: 0x00AC6F28 File Offset: 0x00AC5128
		public void UnBindAxes(IReadOnlyList<string> axisNames, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.UnBindAxes(axisNames, axisCallback);
		}

		// Token: 0x0602E8D0 RID: 190672 RVA: 0x00AC6F36 File Offset: 0x00AC5136
		public bool HasAxisBind(string axisName)
		{
			return InputDistributeModel.Instance.HasAxisBind(axisName);
		}

		// Token: 0x0602E8D1 RID: 190673 RVA: 0x00AC6F43 File Offset: 0x00AC5143
		public bool HasActionBind(string actionName)
		{
			return InputDistributeModel.Instance.HasActionBind(actionName);
		}

		// Token: 0x0602E8D2 RID: 190674 RVA: 0x00AC6F50 File Offset: 0x00AC5150
		public bool IsActionRespondable(string actionName)
		{
			return InputDistributeModel.Instance.IsActionRespondable(actionName);
		}

		// Token: 0x0602E8D3 RID: 190675 RVA: 0x00AC6F5D File Offset: 0x00AC515D
		public void BindAxisIgnoreLimit(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.BindAxisIgnoreLimit(axisName, axisCallback);
		}

		// Token: 0x0602E8D4 RID: 190676 RVA: 0x00AC6F6B File Offset: 0x00AC516B
		public void UnBindAxisIgnoreLimit(string axisName, TInputHandle<float> axisCallback)
		{
			InputDistributeModel.Instance.UnBindAxisIgnoreLimit(axisName, axisCallback);
		}

		// Token: 0x0602E8D5 RID: 190677 RVA: 0x00AC6F79 File Offset: 0x00AC5179
		public void BindTouch(int touchId, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.BindTouch(touchId, touchCallback);
		}

		// Token: 0x0602E8D6 RID: 190678 RVA: 0x00AC6F87 File Offset: 0x00AC5187
		public void BindTouches(int[] touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.BindTouches(touchIdList, touchCallback);
		}

		// Token: 0x0602E8D7 RID: 190679 RVA: 0x00AC6F95 File Offset: 0x00AC5195
		public void UnBindTouch(int touchId, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.UnBindTouch(touchId, touchCallback);
		}

		// Token: 0x0602E8D8 RID: 190680 RVA: 0x00AC6FA3 File Offset: 0x00AC51A3
		public void UnBindTouches(IReadOnlyList<int> touchIdList, TInputHandle<InputDistributeDefine.ITouchData> touchCallback)
		{
			InputDistributeModel.Instance.UnBindTouches(touchIdList, touchCallback);
		}

		// Token: 0x0602E8D9 RID: 190681 RVA: 0x00AC6FB1 File Offset: 0x00AC51B1
		public void BindKey(string keyName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.BindKey(keyName, actionCallback);
		}

		// Token: 0x0602E8DA RID: 190682 RVA: 0x00AC6FBF File Offset: 0x00AC51BF
		public void UnBindKey(string keyName, TInputHandle<InputDistributeDefine.EActionType> actionCallback)
		{
			InputDistributeModel.Instance.UnBindKey(keyName, actionCallback);
		}

		// Token: 0x0602E8DB RID: 190683 RVA: 0x00AC6FCD File Offset: 0x00AC51CD
		public void InputAxis(string axisName, float value, bool force = false)
		{
			if (Math.Abs(value) <= 0.02f)
			{
				InputDistributeModel.Instance.InputAxis(axisName, 0f, force);
				return;
			}
			InputDistributeModel.Instance.InputAxis(axisName, value, force);
		}

		// Token: 0x0602E8DC RID: 190684 RVA: 0x00AC6FFB File Offset: 0x00AC51FB
		public bool IsAxisRespondable(string axisName)
		{
			return InputDistributeModel.Instance.IsAxisRespondable(axisName);
		}

		// Token: 0x0602E8DD RID: 190685 RVA: 0x00AC7008 File Offset: 0x00AC5208
		public bool InputAction(string actionName, bool bPress)
		{
			return InputDistributeModel.Instance.InputAction(actionName, bPress);
		}

		// Token: 0x0602E8DE RID: 190686 RVA: 0x00AC7016 File Offset: 0x00AC5216
		public void InputTouch(int touchId, InputDistributeDefine.ITouchData touchData)
		{
			InputDistributeModel.Instance.InputTouch(touchId, touchData);
		}

		// Token: 0x0602E8DF RID: 190687 RVA: 0x00AC7024 File Offset: 0x00AC5224
		public void InputKey(string keyName, bool bPress)
		{
			InputDistributeModel.Instance.InputKey(keyName, bPress);
		}

		// Token: 0x0602E8E0 RID: 190688 RVA: 0x00AC7032 File Offset: 0x00AC5232
		[NullableContext(2)]
		public string GetCurrentActionName()
		{
			return InputDistributeModel.Instance.GetCurrentActionName();
		}

		// Token: 0x0602E8E1 RID: 190689 RVA: 0x00AC703E File Offset: 0x00AC523E
		[NullableContext(2)]
		public string GetCurrentAxisName()
		{
			return InputDistributeModel.Instance.GetCurrentAxisName();
		}

		// Token: 0x0602E8E2 RID: 190690 RVA: 0x00AC704A File Offset: 0x00AC524A
		public bool IsAllowFightInput()
		{
			return InputDistributeModel.Instance.IsAllowFightInput();
		}

		// Token: 0x0602E8E3 RID: 190691 RVA: 0x00AC7056 File Offset: 0x00AC5256
		public bool IsAllowFightMoveInput()
		{
			return InputDistributeModel.Instance.IsAllowFightMoveInput();
		}

		// Token: 0x0602E8E4 RID: 190692 RVA: 0x00AC7062 File Offset: 0x00AC5262
		public bool IsAllowFightActionInput()
		{
			return InputDistributeModel.Instance.IsAllowFightActionInput();
		}

		// Token: 0x0602E8E5 RID: 190693 RVA: 0x00AC706E File Offset: 0x00AC526E
		public bool IsAllowFightCameraRotationInput()
		{
			return InputDistributeModel.Instance.IsAllowFightCameraRotationInput();
		}

		// Token: 0x0602E8E6 RID: 190694 RVA: 0x00AC707A File Offset: 0x00AC527A
		public bool IsAllowFightCameraZoomInput()
		{
			return InputDistributeModel.Instance.IsAllowFightCameraZoomInput();
		}

		// Token: 0x0602E8E7 RID: 190695 RVA: 0x00AC7086 File Offset: 0x00AC5286
		public bool IsAllowHeadRotation()
		{
			return InputDistributeModel.Instance.IsAllowHeadRotation();
		}

		// Token: 0x1700762D RID: 30253
		// (get) Token: 0x0602E8E8 RID: 190696 RVA: 0x00AC7092 File Offset: 0x00AC5292
		public static InputDistributeController Instance
		{
			get
			{
				return InputDistributeController._Instance;
			}
		}

		// Token: 0x0602E8E9 RID: 190697 RVA: 0x00AC7099 File Offset: 0x00AC5299
		public static InputDistributeController GetOrCreateInstance()
		{
			if (InputDistributeController._Instance == null)
			{
				InputDistributeController.CreateInstance();
			}
			return InputDistributeController._Instance;
		}

		// Token: 0x0602E8EA RID: 190698 RVA: 0x00AC70AD File Offset: 0x00AC52AD
		public static bool CreateInstance()
		{
			if (InputDistributeController._Instance != null)
			{
				return true;
			}
			InputDistributeController._Instance = new InputDistributeController();
			return true;
		}

		// Token: 0x0602E8EB RID: 190699 RVA: 0x00AC70C3 File Offset: 0x00AC52C3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E8EC RID: 190700 RVA: 0x00AC70C5 File Offset: 0x00AC52C5
		public static void ResetStaticDefaultValue()
		{
			InputDistributeController._Instance = null;
		}

		// Token: 0x0602E8ED RID: 190701 RVA: 0x00AC70CD File Offset: 0x00AC52CD
		static InputDistributeController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputDistributeController.CreateStaticDefaultValue), new Action(InputDistributeController.ResetStaticDefaultValue));
		}

		// Token: 0x04019519 RID: 103705
		[Nullable(2)]
		private static InputDistributeController _Instance;
	}
}
