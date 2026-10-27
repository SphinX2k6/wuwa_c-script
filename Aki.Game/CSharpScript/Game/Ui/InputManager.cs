using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B1 RID: 18097
	[NullableContext(1)]
	[Nullable(0)]
	public class InputManager : Singleton
	{
		// Token: 0x0602EA88 RID: 191112 RVA: 0x00ACC3A8 File Offset: 0x00ACA5A8
		public void Init()
		{
			EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.Start));
			EventSystem.Instance.Add(EEventName.UiManagerDestroy, new Action(this.Clear));
		}

		// Token: 0x0602EA89 RID: 191113 RVA: 0x00ACC3DC File Offset: 0x00ACA5DC
		private void Start()
		{
			if (!this.IsInit)
			{
				this.RegisterHandle();
				this.IsInit = true;
				this.ShowMouseViewRecord.Clear();
				this.DisableShortcutKeyViewRecord.Clear();
				this.DisableCloseViewByShortcutKeyViewRecord.Clear();
				this.IsAltPress = false;
				this.ImmersiveMouseModule = new ImmersiveMouseModule();
				this.ImmersiveMouseModule.Initialize();
			}
			UKuroInputFunctionLibrary.ClearInputModeReply();
		}

		// Token: 0x0602EA8A RID: 191114 RVA: 0x00ACC444 File Offset: 0x00ACA644
		private void Clear()
		{
			if (this.IsInit)
			{
				this.RemoveHandle();
				this.ShowMouseViewRecord.Clear();
				this.DisableShortcutKeyViewRecord.Clear();
				this.DisableCloseViewByShortcutKeyViewRecord.Clear();
				ViewHotKeyHandleContainer viewHotKeyHandleContainer = this.ViewHotKeyHandleContainer;
				if (viewHotKeyHandleContainer != null)
				{
					viewHotKeyHandleContainer.Clear();
				}
				this.IsInit = false;
				this.IsAltPress = false;
			}
		}

		// Token: 0x0602EA8B RID: 191115 RVA: 0x00ACC4A0 File Offset: 0x00ACA6A0
		private void AddViewHotKeyHandle(OpenAndCloseViewHotKey config)
		{
			if (this.ViewHotKeyHandleContainer.IsDataExist(config.Id))
			{
				return;
			}
			string[] array = new string[config.ViewParamLength];
			for (int i = 0; i < config.ViewParamLength; i++)
			{
				array[i] = config.ViewParam(i);
			}
			ViewHotKeyHandle viewHotKeyHandle = ViewHotKeyHandleFactory.CreateViewHotKeyHandle(new OpenAndCloseViewHotKey
			{
				ConfigId = config.Id,
				ActionName = config.ActionName,
				InputControllerType = (EOpenAndCloseViewInputControllerType)config.InputControllerType,
				ViewName = (EUiViewName)config.ViewName,
				ViewParam = array,
				IsPressTrigger = config.IsPressTrigger,
				PressStartTime = config.PressStartTime,
				PressTriggerTime = config.PressTriggerTime,
				IsReleaseTrigger = config.IsReleaseTrigger,
				ReleaseInvalidTime = config.ReleaseInvalidTime,
				IsPressClose = config.IsPressClose,
				IsReleaseClose = config.IsReleaseClose,
				IsAllowOpenViewByShortcutKey = new Func<bool>(this.IsAllowOpenViewByShortcutKey),
				IsAllowCloseViewByShortcutKey = new Func<bool>(this.IsAllowCloseViewByShortcutKey),
				IsLockShortcutKey = delegate(string actionName, InputDistributeDefine.EActionType actionType)
				{
					using (Dictionary<string, TLockShortcutKeyDelegate>.ValueCollection.Enumerator enumerator = this.LockShortcutKeyDelegateMap.Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current(actionName, actionType))
							{
								return true;
							}
						}
					}
					return false;
				}
			}, config.HandleType);
			viewHotKeyHandle.Bind();
			this.ViewHotKeyHandleContainer.Add(viewHotKeyHandle);
		}

		// Token: 0x0602EA8C RID: 191116 RVA: 0x00ACC5E4 File Offset: 0x00ACA7E4
		private void RemoveViewHotKeyHandle(OpenAndCloseViewHotKey config)
		{
			ViewHotKeyHandle[] array = this.ViewHotKeyHandleContainer.Get((EUiViewName)config.ViewName);
			if (array == null)
			{
				return;
			}
			foreach (ViewHotKeyHandle viewHotKeyHandle in array)
			{
				this.ViewHotKeyHandleContainer.Remove(viewHotKeyHandle);
			}
		}

		// Token: 0x0602EA8D RID: 191117 RVA: 0x00ACC62D File Offset: 0x00ACA82D
		private bool DefaultLockShortcutKeyDelegate(string actionName, InputDistributeDefine.EActionType actionType)
		{
			return true;
		}

		// Token: 0x0602EA8E RID: 191118 RVA: 0x00ACC630 File Offset: 0x00ACA830
		public void AddViewHotKeyActionByType(EInputDataType type)
		{
			IReadOnlyList<OpenAndCloseViewHotKey> allOpenAndCloseViewHotKeyConfig = ViewHotKeyConfig.Instance.GetAllOpenAndCloseViewHotKeyConfig();
			if (allOpenAndCloseViewHotKeyConfig == null)
			{
				return;
			}
			foreach (OpenAndCloseViewHotKey config in allOpenAndCloseViewHotKeyConfig)
			{
				if (config.GetEffectiveTypeListBytes().Contains((int)type))
				{
					this.AddViewHotKeyHandle(config);
				}
			}
		}

		// Token: 0x0602EA8F RID: 191119 RVA: 0x00ACC698 File Offset: 0x00ACA898
		public void RemoveViewHotKeyActionByType(EInputDataType type)
		{
			IReadOnlyList<OpenAndCloseViewHotKey> allOpenAndCloseViewHotKeyConfig = ViewHotKeyConfig.Instance.GetAllOpenAndCloseViewHotKeyConfig();
			if (allOpenAndCloseViewHotKeyConfig == null)
			{
				return;
			}
			foreach (OpenAndCloseViewHotKey config in allOpenAndCloseViewHotKeyConfig)
			{
				if (config.GetEffectiveTypeListBytes().Contains((int)type))
				{
					this.RemoveViewHotKeyHandle(config);
				}
			}
		}

		// Token: 0x0602EA90 RID: 191120 RVA: 0x00ACC700 File Offset: 0x00ACA900
		public void RegisterLockShortcutKeyReason(string reason, TLockShortcutKeyDelegate delegateItem = null)
		{
			if (delegateItem == null)
			{
				delegateItem = new TLockShortcutKeyDelegate(this.DefaultLockShortcutKeyDelegate);
			}
			this.LockShortcutKeyDelegateMap[reason] = delegateItem;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputManager;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "锁定快捷键输入的原因";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EA91 RID: 191121 RVA: 0x00ACC754 File Offset: 0x00ACA954
		public void RemoveLockShortcutKeyReason(string reason)
		{
			this.LockShortcutKeyDelegateMap.Remove(reason);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputManager;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "解锁快捷键输入的原因";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602EA92 RID: 191122 RVA: 0x00ACC798 File Offset: 0x00ACA998
		public void RegisterOpenViewFunc(EUiViewName name, Action delegateItem)
		{
			this.ViewHotKeyHandleContainer.RegisterOpenViewFunc(name, delegateItem);
			ViewHotKeyHandle[] array = this.ViewHotKeyHandleContainer.Get(name);
			if (array == null)
			{
				return;
			}
			ViewHotKeyHandle[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].BindOpenViewCallback(delegateItem);
			}
		}

		// Token: 0x0602EA93 RID: 191123 RVA: 0x00ACC7DC File Offset: 0x00ACA9DC
		public void RegisterCloseViewFunc(EUiViewName name, Action delegateItem)
		{
			this.ViewHotKeyHandleContainer.RegisterCloseViewFunc(name, delegateItem);
			ViewHotKeyHandle[] array = this.ViewHotKeyHandleContainer.Get(name);
			if (array == null)
			{
				return;
			}
			ViewHotKeyHandle[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].BindCloseViewCallback(delegateItem);
			}
		}

		// Token: 0x0602EA94 RID: 191124 RVA: 0x00ACC820 File Offset: 0x00ACAA20
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public ViewHotKeyHandle[] GetViewHotKeyHandle(EUiViewName viewName)
		{
			return this.ViewHotKeyHandleContainer.Get(viewName);
		}

		// Token: 0x0602EA95 RID: 191125 RVA: 0x00ACC82E File Offset: 0x00ACAA2E
		public ViewHotKeyHandle[] GetAllViewHotKeyHandle()
		{
			return this.ViewHotKeyHandleContainer.GetAll();
		}

		// Token: 0x0602EA96 RID: 191126 RVA: 0x00ACC83C File Offset: 0x00ACAA3C
		private void RegisterHandle()
		{
			InputDistributeController.Instance.BindAction("GM指令", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputGmShortcutKey));
			InputDistributeController.Instance.BindAction("显示鼠标", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputMouseShortcutKey));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.ResetModuleByResetToBattleView, new Action(this.OnPlayerDead));
			EventSystem.Instance.Add(EEventName.RefreshCursor, new Action(this.RefreshCursor));
			EventSystem.Instance.Add(EEventName.MoveCursorToRightDown, new Action(this.MoveCursorToRightDown));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.RefreshStateOnPlatformChanged));
		}

		// Token: 0x0602EA97 RID: 191127 RVA: 0x00ACC93C File Offset: 0x00ACAB3C
		private void RemoveHandle()
		{
			InputDistributeController.Instance.UnBindAction("GM指令", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputGmShortcutKey));
			InputDistributeController.Instance.UnBindAction("显示鼠标", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputMouseShortcutKey));
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ResetModuleByResetToBattleView, new Action(this.OnPlayerDead));
			EventSystem.Instance.Remove(EEventName.RefreshCursor, new Action(this.RefreshCursor));
			EventSystem.Instance.Remove(EEventName.MoveCursorToRightDown, new Action(this.MoveCursorToRightDown));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.RefreshStateOnPlatformChanged));
		}

		// Token: 0x0602EA98 RID: 191128 RVA: 0x00ACCA3C File Offset: 0x00ACAC3C
		private void OnInputGmShortcutKey(string name, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Release)
			{
				return;
			}
			if (!SundryModel.Instance.GmBlueprintGmIsOpen)
			{
				return;
			}
			if (SundryModel.Instance.CanOpenGmView)
			{
				if (UiManager.Instance.IsViewOpen(EUiViewName.GmView))
				{
					UiManager.Instance.CloseView(EUiViewName.GmView, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.GmView, null, null);
			}
		}

		// Token: 0x0602EA99 RID: 191129 RVA: 0x00ACCA9C File Offset: 0x00ACAC9C
		private void OnInputMouseShortcutKey(string name, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			bool flag = actionType == InputDistributeDefine.EActionType.Press;
			if (flag != this.IsAltPress)
			{
				this.IsAltPress = flag;
				InputDistributeController.Instance.RefreshInputTag();
			}
			if (this.MouseCursorVisibleType == EMouseCursorVisibleType.AlwaysVisible)
			{
				return;
			}
			bool flag2 = actionType == InputDistributeDefine.EActionType.Press;
			if (this.IsAlwaysShowMouseCursor)
			{
				if (flag2)
				{
					this.SetShowCursor(true, true);
					return;
				}
			}
			else
			{
				this.MoveCursorToCenter();
				this.SetShowCursor(flag2, true);
			}
		}

		// Token: 0x0602EA9A RID: 191130 RVA: 0x00ACCAF9 File Offset: 0x00ACACF9
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			this.AddViewHandle(viewName, viewId);
		}

		// Token: 0x0602EA9B RID: 191131 RVA: 0x00ACCB03 File Offset: 0x00ACAD03
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			this.RemoveViewHandle(viewName, viewId);
		}

		// Token: 0x0602EA9C RID: 191132 RVA: 0x00ACCB0D File Offset: 0x00ACAD0D
		private void AddViewHandle(EUiViewName viewName, int viewId)
		{
			ImmersiveMouseModule immersiveMouseModule = this.ImmersiveMouseModule;
			if (immersiveMouseModule != null)
			{
				immersiveMouseModule.RefreshMouseImmersiveMode();
			}
			this.CursorOpenViewHandle(viewName, viewId);
			this.TryAddDisableCloseView(viewName, viewId);
			this.TryAddDisableShortcutKeyView(viewName, viewId);
		}

		// Token: 0x0602EA9D RID: 191133 RVA: 0x00ACCB38 File Offset: 0x00ACAD38
		private void RemoveViewHandle(EUiViewName viewName, int viewId)
		{
			ImmersiveMouseModule immersiveMouseModule = this.ImmersiveMouseModule;
			if (immersiveMouseModule != null)
			{
				immersiveMouseModule.RefreshMouseImmersiveMode();
			}
			this.TryCloseViewHiddenCursor(viewName, viewId);
			this.TryRemoveDisableShortcutKeyView(viewName, viewId);
			this.TryRemoveDisableCloseView(viewName, viewId);
		}

		// Token: 0x0602EA9E RID: 191134 RVA: 0x00ACCB63 File Offset: 0x00ACAD63
		private void OnPlayerDead()
		{
			this.ClearAlwaysCursorViewList();
			this.DisableShortcutKeyViewRecord.Clear();
			this.DisableCloseViewByShortcutKeyViewRecord.Clear();
		}

		// Token: 0x0602EA9F RID: 191135 RVA: 0x00ACCB81 File Offset: 0x00ACAD81
		private void RefreshCursor()
		{
			this.RefreshAlwaysCursorVisibleByViewRecord();
		}

		// Token: 0x0602EAA0 RID: 191136 RVA: 0x00ACCB8C File Offset: 0x00ACAD8C
		private void MoveCursorToRightDown()
		{
			ValueTuple<int, int>? cursorRightDown = this.GetCursorRightDown();
			if (cursorRightDown != null)
			{
				this.SetMouseLocation(cursorRightDown.Value);
			}
		}

		// Token: 0x0602EAA1 RID: 191137 RVA: 0x00ACCBB6 File Offset: 0x00ACADB6
		private void OnWorldDone()
		{
			this.ClearAlwaysCursorViewList();
		}

		// Token: 0x0602EAA2 RID: 191138 RVA: 0x00ACCBC0 File Offset: 0x00ACADC0
		private unsafe void TryAddDisableShortcutKeyView(EUiViewName viewName, int viewId)
		{
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null)
			{
				return;
			}
			if (uiViewInfo.CanOpenViewByShortcutKey)
			{
				return;
			}
			int num = this.DisableShortcutKeyViewRecord.Add(viewName);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputManager;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "添加不允许打开界面快捷键的界面";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("length", this.DisableShortcutKeyViewRecord.Size());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("count", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0602EAA3 RID: 191139 RVA: 0x00ACCC78 File Offset: 0x00ACAE78
		private unsafe void TryRemoveDisableShortcutKeyView(EUiViewName viewName, int viewId)
		{
			if (!this.DisableShortcutKeyViewRecord.Has(viewName))
			{
				return;
			}
			int num = this.DisableShortcutKeyViewRecord.Remove(viewName);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputManager;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "删除不允许打开界面快捷键的界面";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("length", this.DisableShortcutKeyViewRecord.Size());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("count", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0602EAA4 RID: 191140 RVA: 0x00ACCD25 File Offset: 0x00ACAF25
		public bool IsAllowOpenViewByShortcutKey()
		{
			return !this.DisableShortcutKeyViewRecord.HasAny();
		}

		// Token: 0x0602EAA5 RID: 191141 RVA: 0x00ACCD35 File Offset: 0x00ACAF35
		public bool IsAllowCloseViewByShortcutKey()
		{
			return !this.DisableCloseViewByShortcutKeyViewRecord.HasAny();
		}

		// Token: 0x0602EAA6 RID: 191142 RVA: 0x00ACCD45 File Offset: 0x00ACAF45
		public void SetMouseCursorVisibleType(EMouseCursorVisibleType cursorVisibleType)
		{
			this.MouseCursorVisibleType = cursorVisibleType;
			if (cursorVisibleType == EMouseCursorVisibleType.AlwaysVisible)
			{
				this.SetShowCursor(true, true);
				return;
			}
			if (cursorVisibleType != EMouseCursorVisibleType.AlwaysHide)
			{
				this.RefreshAlwaysCursorVisibleByViewRecord();
				return;
			}
			this.SetShowCursor(false, true);
		}

		// Token: 0x0602EAA7 RID: 191143 RVA: 0x00ACCD70 File Offset: 0x00ACAF70
		private void CursorOpenViewHandle(EUiViewName viewName, int viewId)
		{
			if (viewName == UiModel.Instance.MainViewName)
			{
				this.ClearAlwaysCursorViewList();
				return;
			}
			if (!this.IsPlayerControllerIsValid())
			{
				return;
			}
			bool flag = this.IsShowMouseCursor();
			if (!this.TryOpenViewShowCursor(viewName, viewId))
			{
				return;
			}
			if (!flag)
			{
				this.MoveCursorToCenter();
			}
		}

		// Token: 0x0602EAA8 RID: 191144 RVA: 0x00ACCDBC File Offset: 0x00ACAFBC
		private void TryAddDisableCloseView(EUiViewName viewName, int viewId)
		{
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null)
			{
				return;
			}
			if (uiViewInfo.IsShortKeysExitView && uiViewInfo.Type != ELayerType.Normal)
			{
				this.DisableCloseViewByShortcutKeyViewRecord.Add(viewName);
			}
		}

		// Token: 0x0602EAA9 RID: 191145 RVA: 0x00ACCDF7 File Offset: 0x00ACAFF7
		private void TryRemoveDisableCloseView(EUiViewName viewName, int viewId)
		{
			this.DisableCloseViewByShortcutKeyViewRecord.Remove(viewName);
		}

		// Token: 0x0602EAAA RID: 191146 RVA: 0x00ACCE08 File Offset: 0x00ACB008
		private unsafe bool TryOpenViewShowCursor(EUiViewName viewName, int viewId)
		{
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null)
			{
				return false;
			}
			if (uiViewInfo.ShowCursorType == EShowCursorType.NotSet)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputManager;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "打开界面时显示鼠标 失败，原因是因为此界面的显示鼠标类型为：不影响鼠标显隐";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (uiViewInfo.ShowCursorType == EShowCursorType.Hidden)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputManager;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "打开界面时显示鼠标 失败，原因是因为此界面的显示鼠标类型为：隐藏鼠标";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("viewName", viewName);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				this.RefreshAlwaysCursorVisibleByViewRecord();
				return false;
			}
			int num = this.ShowMouseViewRecord.Add(viewName);
			if (this.MouseCursorVisibleType != EMouseCursorVisibleType.None)
			{
				return false;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.InputManager;
			ELogAuthor author3 = ELogAuthor.XXJ;
			string message3 = "打开界面时尝试显示鼠标成功";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ShowCursorType", uiViewInfo.ShowCursorType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("count", num);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.RefreshAlwaysCursorVisibleByViewRecord();
			return true;
		}

		// Token: 0x0602EAAB RID: 191147 RVA: 0x00ACCF38 File Offset: 0x00ACB138
		private unsafe void TryCloseViewHiddenCursor(EUiViewName viewName, int viewId)
		{
			UiViewInfo uiViewInfo = UiConfig.Instance.TryGetViewInfo(viewName);
			if (uiViewInfo == null)
			{
				return;
			}
			if (uiViewInfo.ShowCursorType == EShowCursorType.NotSet)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputManager;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "关闭界面时尝试隐藏失败，原因是因为UI表中，此界面的显示鼠标类型为：不影响鼠标显隐藏";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("viewName", viewName);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.MouseCursorVisibleType != EMouseCursorVisibleType.None)
			{
				this.ShowMouseViewRecord.Remove(viewName);
				Log.Instance.Info(ELogModule.InputManager, ELogAuthor.XXJ, "关闭界面时尝试隐藏失败，原因是因为运行了总是显示鼠标的GM指令", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!this.ShowMouseViewRecord.Has(viewName))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.InputManager;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "关闭界面时尝试隐藏失败，原因是因为此界面没有再显示鼠标界面列表中";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("viewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ShowMouseViewList", this.ShowMouseViewRecord);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.RefreshAlwaysCursorVisibleByViewRecord();
				return;
			}
			this.ShowMouseViewRecord.Remove(viewName);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.InputManager;
			ELogAuthor author3 = ELogAuthor.XXJ;
			string message3 = "关闭界面时尝试隐藏鼠标成功";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("viewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("ShowCursorType", uiViewInfo.ShowCursorType);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			this.RefreshAlwaysCursorVisibleByViewRecord();
		}

		// Token: 0x0602EAAC RID: 191148 RVA: 0x00ACD0A8 File Offset: 0x00ACB2A8
		private void RefreshAlwaysCursorVisibleByViewRecord()
		{
			if (this.MouseCursorVisibleType != EMouseCursorVisibleType.None)
			{
				return;
			}
			bool flag = this.RefreshAlwaysCursorVisible();
			bool flag2 = this.ShowMouseViewRecord.Size() == 1 && this.ShowMouseViewRecord.Has(EUiViewName.NetWorkMaskView);
			bool flag3 = flag && !flag2;
			if (flag3 && !this.IsCursorFrameGenDisabled)
			{
				this.IsCursorFrameGenDisabled = true;
				GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("CursorVisialbe");
				return;
			}
			if (!flag3 && this.IsCursorFrameGenDisabled)
			{
				this.IsCursorFrameGenDisabled = false;
				GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("CursorVisialbe");
			}
		}

		// Token: 0x0602EAAD RID: 191149 RVA: 0x00ACD134 File Offset: 0x00ACB334
		private bool RefreshAlwaysCursorVisible()
		{
			bool flag = this.IsImmersiveMouseModeEnabled() && !this.IsImmersiveInputPaused();
			bool flag2 = this.ShowMouseViewRecord.HasAny() && !flag;
			this.SetAlwaysShowCursor(flag2);
			return flag2;
		}

		// Token: 0x0602EAAE RID: 191150 RVA: 0x00ACD173 File Offset: 0x00ACB373
		private void ClearAlwaysCursorViewList()
		{
			this.ShowMouseViewRecord.Clear();
			this.SetAlwaysShowCursor(false);
			if (this.IsCursorFrameGenDisabled)
			{
				this.IsCursorFrameGenDisabled = false;
				GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("CursorVisialbe");
			}
		}

		// Token: 0x0602EAAF RID: 191151 RVA: 0x00ACD1A8 File Offset: 0x00ACB3A8
		public void SetAlwaysShowCursor(bool bAlwaysShowMouseCursor)
		{
			if (InputExtraShowCursorCenter.Instance.HasExtraShowCursorData())
			{
				bool isAlwaysShowMouseCursor = InputExtraShowCursorCenter.Instance.CheckShowCursorData();
				this.IsAlwaysShowMouseCursor = isAlwaysShowMouseCursor;
			}
			else
			{
				this.IsAlwaysShowMouseCursor = bAlwaysShowMouseCursor;
			}
			if (this.IsAlwaysShowMouseCursor == this.ManagerMouseStatus)
			{
				return;
			}
			this.SetShowCursor(this.IsAlwaysShowMouseCursor, true);
		}

		// Token: 0x0602EAB0 RID: 191152 RVA: 0x00ACD1F8 File Offset: 0x00ACB3F8
		public unsafe void SetShowCursor(bool value, bool fireEvent = true)
		{
			if (!this.IsPlayerControllerIsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InputManager;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "设置鼠标可见性失败，因为PlayerController不可用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ManagerMouseStatus = value;
			bool flag = this.ManagerMouseStatus && !Info.Instance.IsInGamepad();
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.InputManager;
			ELogAuthor author2 = ELogAuthor.XXJ;
			string message2 = "实际设置鼠标可见性";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("realSetValue", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			APlayerController playerController = Global.PlayerController;
			if (flag)
			{
				playerController.bShowMouseCursor = true;
				this.ApplyGameAndUiInputMode();
			}
			else
			{
				playerController.bShowMouseCursor = false;
				this.ReplyGameAndUiInputMode();
			}
			if (fireEvent)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnShowMouseCursor, value);
			}
		}

		// Token: 0x0602EAB1 RID: 191153 RVA: 0x00ACD2F0 File Offset: 0x00ACB4F0
		private void ApplyGameAndUiInputMode()
		{
			APlayerController playerController = Global.PlayerController;
			if (this.InputModeReply == null || !UKuroInputFunctionLibrary.HasInputModeReply(this.InputModeReply))
			{
				this.InputModeReply = UKuroInputFunctionLibrary.SetGameAndUIInputMode(playerController, "InputManager设置输入模式", false, false);
			}
		}

		// Token: 0x0602EAB2 RID: 191154 RVA: 0x00ACD331 File Offset: 0x00ACB531
		private void ReplyGameAndUiInputMode()
		{
			if (this.InputModeReply != null)
			{
				UKuroInputFunctionLibrary.ReplyInputMode(Global.PlayerController, this.InputModeReply);
				this.InputModeReply = null;
			}
		}

		// Token: 0x0602EAB3 RID: 191155 RVA: 0x00ACD358 File Offset: 0x00ACB558
		public void RefreshStateOnPlatformChanged(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
		{
			this.SetShowCursor(this.ManagerMouseStatus, true);
		}

		// Token: 0x0602EAB4 RID: 191156 RVA: 0x00ACD368 File Offset: 0x00ACB568
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"X",
			"Y"
		})]
		private ValueTuple<int, int>? GetCursorCenter()
		{
			if (!this.IsPlayerControllerIsValid())
			{
				return null;
			}
			APlayerController playerController = Global.PlayerController;
			int num = 0;
			int num2 = 0;
			playerController.GetViewportSize(ref num, ref num2);
			int item = num / 2;
			int item2 = num2 / 2;
			return new ValueTuple<int, int>?(new ValueTuple<int, int>(item, item2));
		}

		// Token: 0x0602EAB5 RID: 191157 RVA: 0x00ACD3AC File Offset: 0x00ACB5AC
		public void MoveCursorToCenter()
		{
			if (!this.IsAutoMoveCursorToCenter)
			{
				return;
			}
			ValueTuple<int, int>? cursorCenter = this.GetCursorCenter();
			if (cursorCenter != null)
			{
				this.SetMouseLocation(cursorCenter.Value);
			}
		}

		// Token: 0x0602EAB6 RID: 191158 RVA: 0x00ACD3E0 File Offset: 0x00ACB5E0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"X",
			"Y"
		})]
		private ValueTuple<int, int>? GetCursorRightDown()
		{
			if (!this.IsPlayerControllerIsValid())
			{
				return null;
			}
			APlayerController playerController = Global.PlayerController;
			int num = 0;
			int num2 = 0;
			playerController.GetViewportSize(ref num, ref num2);
			int item = num;
			int item2 = num2;
			return new ValueTuple<int, int>?(new ValueTuple<int, int>(item, item2));
		}

		// Token: 0x0602EAB7 RID: 191159 RVA: 0x00ACD41F File Offset: 0x00ACB61F
		[NullableContext(0)]
		public void SetEventDataPrevPosition([TupleElementNames(new string[]
		{
			"X",
			"Y"
		})] ValueTuple<float, float>? cursorData)
		{
			if (cursorData != null)
			{
				LguiEventSystemManager.Instance.SetEventDataPrevPosition(cursorData.Value.Item1, cursorData.Value.Item2);
			}
		}

		// Token: 0x0602EAB8 RID: 191160 RVA: 0x00ACD44C File Offset: 0x00ACB64C
		public bool IsShowMouseCursor()
		{
			return this.IsPlayerControllerIsValid() && Global.PlayerController.bShowMouseCursor;
		}

		// Token: 0x0602EAB9 RID: 191161 RVA: 0x00ACD464 File Offset: 0x00ACB664
		private bool IsPlayerControllerIsValid()
		{
			APlayerController playerController = Global.PlayerController;
			return playerController != null && playerController.IsValid();
		}

		// Token: 0x0602EABA RID: 191162 RVA: 0x00ACD488 File Offset: 0x00ACB688
		[NullableContext(0)]
		private void SetMouseLocation([TupleElementNames(new string[]
		{
			"X",
			"Y"
		})] ValueTuple<int, int> cursorData)
		{
			Global.PlayerController.SetMouseLocation(cursorData.Item1, cursorData.Item2);
			this.SetEventDataPrevPosition(new ValueTuple<float, float>?(new ValueTuple<float, float>((float)cursorData.Item1, (float)cursorData.Item2)));
		}

		// Token: 0x0602EABB RID: 191163 RVA: 0x00ACD4CB File Offset: 0x00ACB6CB
		public void SetInputRespondToKey(string keyboardShortcut)
		{
			if (keyboardShortcut != "")
			{
				Input.Instance.OnlyRespondToKey = keyboardShortcut;
			}
		}

		// Token: 0x0602EABC RID: 191164 RVA: 0x00ACD4E5 File Offset: 0x00ACB6E5
		public void ResetInputRespondToKey(string keyboardShortcut)
		{
			if (keyboardShortcut == Input.Instance.OnlyRespondToKey)
			{
				Input.Instance.OnlyRespondToKey = "";
			}
		}

		// Token: 0x0602EABD RID: 191165 RVA: 0x00ACD508 File Offset: 0x00ACB708
		public void PauseImmersiveMouseMode(EImmersiveMouseModeReason reason, bool bReset = true, bool bShowCursor = true, bool bWakeInputState = false)
		{
			if (this.ImmersiveMouseModule != null)
			{
				this.ImmersiveMouseModule.PauseImmersiveMode(reason, bReset, bShowCursor);
			}
			if (bWakeInputState)
			{
				this.SetImmersiveInputWakeState(Info.Instance.InputControllerMainType, true);
			}
		}

		// Token: 0x0602EABE RID: 191166 RVA: 0x00ACD535 File Offset: 0x00ACB735
		public void ResumeImmersiveMouseMode(EImmersiveMouseModeReason reason)
		{
			if (this.ImmersiveMouseModule != null)
			{
				this.ImmersiveMouseModule.ResumeImmersiveMode(reason);
			}
		}

		// Token: 0x0602EABF RID: 191167 RVA: 0x00ACD54B File Offset: 0x00ACB74B
		public bool IsImmersiveMouseModeEnabled()
		{
			return this.ImmersiveMouseModule != null && this.ImmersiveMouseModule.IsImmersiveModeEnabled();
		}

		// Token: 0x0602EAC0 RID: 191168 RVA: 0x00ACD562 File Offset: 0x00ACB762
		public bool IsImmersiveInputPaused()
		{
			return this.ImmersiveMouseModule != null && this.ImmersiveMouseModule.IsImmersiveInputPaused();
		}

		// Token: 0x0602EAC1 RID: 191169 RVA: 0x00ACD579 File Offset: 0x00ACB779
		public bool GetImmersiveInputWakeState()
		{
			return this.ImmersiveInputWakeState;
		}

		// Token: 0x0602EAC2 RID: 191170 RVA: 0x00ACD581 File Offset: 0x00ACB781
		public void SetImmersiveInputWakeState(EInputControllerMainType inputMainType, bool isWake)
		{
			if (this.ImmersiveInputWakeState == isWake)
			{
				return;
			}
			this.ImmersiveInputWakeState = isWake;
			EventSystem.Instance.Emit<EInputControllerMainType, bool>(EEventName.OnImmersiveInputStateChange, inputMainType, isWake);
		}

		// Token: 0x0602EAC3 RID: 191171 RVA: 0x00ACD5A8 File Offset: 0x00ACB7A8
		public unsafe void AddDynamicShowMouseView(EUiViewName viewName)
		{
			int num = this.ShowMouseViewRecord.Add(viewName);
			this.RefreshAlwaysCursorVisibleByViewRecord();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputManager;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "增加动态显示鼠标界面";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0602EAC4 RID: 191172 RVA: 0x00ACD628 File Offset: 0x00ACB828
		public unsafe void RemoveDynamicShowMouseView(EUiViewName viewName)
		{
			int num = this.ShowMouseViewRecord.Remove(viewName);
			this.RefreshAlwaysCursorVisibleByViewRecord();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.InputManager;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "移除动态显示鼠标界面";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("count", num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x1700765E RID: 30302
		// (get) Token: 0x0602EAC5 RID: 191173 RVA: 0x00ACD6A5 File Offset: 0x00ACB8A5
		public static InputManager Instance
		{
			get
			{
				if (InputManager._instance == null)
				{
					InputManager._instance = new InputManager();
					InputManager._instance.OnInit();
				}
				return InputManager._instance;
			}
		}

		// Token: 0x0602EAC6 RID: 191174 RVA: 0x00ACD6C8 File Offset: 0x00ACB8C8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EAC7 RID: 191175 RVA: 0x00ACD6CA File Offset: 0x00ACB8CA
		public static void ResetStaticDefaultValue()
		{
			InputManager instance = InputManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputManager._instance = null;
		}

		// Token: 0x0602EAC8 RID: 191176 RVA: 0x00ACD6E3 File Offset: 0x00ACB8E3
		static InputManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputManager.CreateStaticDefaultValue), new Action(InputManager.ResetStaticDefaultValue));
		}

		// Token: 0x04019698 RID: 104088
		private EMouseCursorVisibleType MouseCursorVisibleType;

		// Token: 0x04019699 RID: 104089
		private bool IsAlwaysShowMouseCursor;

		// Token: 0x0401969A RID: 104090
		private bool ManagerMouseStatus;

		// Token: 0x0401969B RID: 104091
		private bool IsInit;

		// Token: 0x0401969C RID: 104092
		private readonly InputViewRecord ShowMouseViewRecord = new InputViewRecord();

		// Token: 0x0401969D RID: 104093
		private bool IsCursorFrameGenDisabled;

		// Token: 0x0401969E RID: 104094
		public readonly InputViewRecord DisableShortcutKeyViewRecord = new InputViewRecord();

		// Token: 0x0401969F RID: 104095
		public readonly InputViewRecord DisableCloseViewByShortcutKeyViewRecord = new InputViewRecord();

		// Token: 0x040196A0 RID: 104096
		[Nullable(2)]
		private FInputModeReply InputModeReply;

		// Token: 0x040196A1 RID: 104097
		private readonly ViewHotKeyHandleContainer ViewHotKeyHandleContainer = new ViewHotKeyHandleContainer();

		// Token: 0x040196A2 RID: 104098
		public bool IsAutoMoveCursorToCenter = true;

		// Token: 0x040196A3 RID: 104099
		public bool IsAltPress;

		// Token: 0x040196A4 RID: 104100
		[Nullable(2)]
		public ImmersiveMouseModule ImmersiveMouseModule;

		// Token: 0x040196A5 RID: 104101
		private readonly Dictionary<string, TLockShortcutKeyDelegate> LockShortcutKeyDelegateMap = new Dictionary<string, TLockShortcutKeyDelegate>();

		// Token: 0x040196A6 RID: 104102
		private bool ImmersiveInputWakeState;

		// Token: 0x040196A7 RID: 104103
		[Nullable(2)]
		private static InputManager _instance;
	}
}
