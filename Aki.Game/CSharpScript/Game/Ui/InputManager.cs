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
	// Token: 0x020035E2 RID: 13794
	[NullableContext(1)]
	[Nullable(0)]
	public class InputManager : Singleton
	{
		// Token: 0x060231D4 RID: 143828 RVA: 0x009FAC7C File Offset: 0x009F8E7C
		public void Init()
		{
			EventSystem.Instance.Add(EEventName.UiManagerInit, new Action(this.Start));
			EventSystem.Instance.Add(EEventName.UiManagerDestroy, new Action(this.Clear));
		}

		// Token: 0x060231D5 RID: 143829 RVA: 0x009FACB0 File Offset: 0x009F8EB0
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

		// Token: 0x060231D6 RID: 143830 RVA: 0x009FAD18 File Offset: 0x009F8F18
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

		// Token: 0x060231D7 RID: 143831 RVA: 0x009FAD74 File Offset: 0x009F8F74
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

		// Token: 0x060231D8 RID: 143832 RVA: 0x009FAEB8 File Offset: 0x009F90B8
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

		// Token: 0x060231D9 RID: 143833 RVA: 0x009FAF01 File Offset: 0x009F9101
		private bool DefaultLockShortcutKeyDelegate(string actionName, InputDistributeDefine.EActionType actionType)
		{
			return true;
		}

		// Token: 0x060231DA RID: 143834 RVA: 0x009FAF04 File Offset: 0x009F9104
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

		// Token: 0x060231DB RID: 143835 RVA: 0x009FAF6C File Offset: 0x009F916C
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

		// Token: 0x060231DC RID: 143836 RVA: 0x009FAFD4 File Offset: 0x009F91D4
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

		// Token: 0x060231DD RID: 143837 RVA: 0x009FB028 File Offset: 0x009F9228
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

		// Token: 0x060231DE RID: 143838 RVA: 0x009FB06C File Offset: 0x009F926C
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

		// Token: 0x060231DF RID: 143839 RVA: 0x009FB0B0 File Offset: 0x009F92B0
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

		// Token: 0x060231E0 RID: 143840 RVA: 0x009FB0F4 File Offset: 0x009F92F4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public ViewHotKeyHandle[] GetViewHotKeyHandle(EUiViewName viewName)
		{
			return this.ViewHotKeyHandleContainer.Get(viewName);
		}

		// Token: 0x060231E1 RID: 143841 RVA: 0x009FB102 File Offset: 0x009F9302
		public ViewHotKeyHandle[] GetAllViewHotKeyHandle()
		{
			return this.ViewHotKeyHandleContainer.GetAll();
		}

		// Token: 0x060231E2 RID: 143842 RVA: 0x009FB110 File Offset: 0x009F9310
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

		// Token: 0x060231E3 RID: 143843 RVA: 0x009FB210 File Offset: 0x009F9410
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

		// Token: 0x060231E4 RID: 143844 RVA: 0x009FB310 File Offset: 0x009F9510
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

		// Token: 0x060231E5 RID: 143845 RVA: 0x009FB370 File Offset: 0x009F9570
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

		// Token: 0x060231E6 RID: 143846 RVA: 0x009FB3CD File Offset: 0x009F95CD
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			this.AddViewHandle(viewName, viewId);
		}

		// Token: 0x060231E7 RID: 143847 RVA: 0x009FB3D7 File Offset: 0x009F95D7
		private void OnCloseView(EUiViewName viewName, int viewId)
		{
			this.RemoveViewHandle(viewName, viewId);
		}

		// Token: 0x060231E8 RID: 143848 RVA: 0x009FB3E1 File Offset: 0x009F95E1
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

		// Token: 0x060231E9 RID: 143849 RVA: 0x009FB40C File Offset: 0x009F960C
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

		// Token: 0x060231EA RID: 143850 RVA: 0x009FB437 File Offset: 0x009F9637
		private void OnPlayerDead()
		{
			this.ClearAlwaysCursorViewList();
			this.DisableShortcutKeyViewRecord.Clear();
			this.DisableCloseViewByShortcutKeyViewRecord.Clear();
		}

		// Token: 0x060231EB RID: 143851 RVA: 0x009FB455 File Offset: 0x009F9655
		private void RefreshCursor()
		{
			this.RefreshAlwaysCursorVisibleByViewRecord();
		}

		// Token: 0x060231EC RID: 143852 RVA: 0x009FB460 File Offset: 0x009F9660
		private void MoveCursorToRightDown()
		{
			ValueTuple<int, int>? cursorRightDown = this.GetCursorRightDown();
			if (cursorRightDown != null)
			{
				this.SetMouseLocation(cursorRightDown.Value);
			}
		}

		// Token: 0x060231ED RID: 143853 RVA: 0x009FB48A File Offset: 0x009F968A
		private void OnWorldDone()
		{
			this.ClearAlwaysCursorViewList();
		}

		// Token: 0x060231EE RID: 143854 RVA: 0x009FB494 File Offset: 0x009F9694
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

		// Token: 0x060231EF RID: 143855 RVA: 0x009FB54C File Offset: 0x009F974C
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

		// Token: 0x060231F0 RID: 143856 RVA: 0x009FB5F9 File Offset: 0x009F97F9
		public bool IsAllowOpenViewByShortcutKey()
		{
			return !this.DisableShortcutKeyViewRecord.HasAny();
		}

		// Token: 0x060231F1 RID: 143857 RVA: 0x009FB609 File Offset: 0x009F9809
		public bool IsAllowCloseViewByShortcutKey()
		{
			return !this.DisableCloseViewByShortcutKeyViewRecord.HasAny();
		}

		// Token: 0x060231F2 RID: 143858 RVA: 0x009FB619 File Offset: 0x009F9819
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

		// Token: 0x060231F3 RID: 143859 RVA: 0x009FB644 File Offset: 0x009F9844
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

		// Token: 0x060231F4 RID: 143860 RVA: 0x009FB690 File Offset: 0x009F9890
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

		// Token: 0x060231F5 RID: 143861 RVA: 0x009FB6CB File Offset: 0x009F98CB
		private void TryRemoveDisableCloseView(EUiViewName viewName, int viewId)
		{
			this.DisableCloseViewByShortcutKeyViewRecord.Remove(viewName);
		}

		// Token: 0x060231F6 RID: 143862 RVA: 0x009FB6DC File Offset: 0x009F98DC
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

		// Token: 0x060231F7 RID: 143863 RVA: 0x009FB80C File Offset: 0x009F9A0C
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

		// Token: 0x060231F8 RID: 143864 RVA: 0x009FB97C File Offset: 0x009F9B7C
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

		// Token: 0x060231F9 RID: 143865 RVA: 0x009FBA08 File Offset: 0x009F9C08
		private bool RefreshAlwaysCursorVisible()
		{
			bool flag = this.IsImmersiveMouseModeEnabled() && !this.IsImmersiveInputPaused();
			bool flag2 = this.ShowMouseViewRecord.HasAny() && !flag;
			this.SetAlwaysShowCursor(flag2);
			return flag2;
		}

		// Token: 0x060231FA RID: 143866 RVA: 0x009FBA47 File Offset: 0x009F9C47
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

		// Token: 0x060231FB RID: 143867 RVA: 0x009FBA7C File Offset: 0x009F9C7C
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

		// Token: 0x060231FC RID: 143868 RVA: 0x009FBACC File Offset: 0x009F9CCC
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

		// Token: 0x060231FD RID: 143869 RVA: 0x009FBBC4 File Offset: 0x009F9DC4
		private void ApplyGameAndUiInputMode()
		{
			APlayerController playerController = Global.PlayerController;
			if (this.InputModeReply == null || !UKuroInputFunctionLibrary.HasInputModeReply(this.InputModeReply))
			{
				this.InputModeReply = UKuroInputFunctionLibrary.SetGameAndUIInputMode(playerController, "InputManager设置输入模式", false, false);
			}
		}

		// Token: 0x060231FE RID: 143870 RVA: 0x009FBC05 File Offset: 0x009F9E05
		private void ReplyGameAndUiInputMode()
		{
			if (this.InputModeReply != null)
			{
				UKuroInputFunctionLibrary.ReplyInputMode(Global.PlayerController, this.InputModeReply);
				this.InputModeReply = null;
			}
		}

		// Token: 0x060231FF RID: 143871 RVA: 0x009FBC2C File Offset: 0x009F9E2C
		public void RefreshStateOnPlatformChanged(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
		{
			this.SetShowCursor(this.ManagerMouseStatus, true);
		}

		// Token: 0x06023200 RID: 143872 RVA: 0x009FBC3C File Offset: 0x009F9E3C
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

		// Token: 0x06023201 RID: 143873 RVA: 0x009FBC80 File Offset: 0x009F9E80
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

		// Token: 0x06023202 RID: 143874 RVA: 0x009FBCB4 File Offset: 0x009F9EB4
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

		// Token: 0x06023203 RID: 143875 RVA: 0x009FBCF3 File Offset: 0x009F9EF3
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

		// Token: 0x06023204 RID: 143876 RVA: 0x009FBD20 File Offset: 0x009F9F20
		public bool IsShowMouseCursor()
		{
			return this.IsPlayerControllerIsValid() && Global.PlayerController.bShowMouseCursor;
		}

		// Token: 0x06023205 RID: 143877 RVA: 0x009FBD38 File Offset: 0x009F9F38
		private bool IsPlayerControllerIsValid()
		{
			APlayerController playerController = Global.PlayerController;
			return playerController != null && playerController.IsValid();
		}

		// Token: 0x06023206 RID: 143878 RVA: 0x009FBD5C File Offset: 0x009F9F5C
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

		// Token: 0x06023207 RID: 143879 RVA: 0x009FBD9F File Offset: 0x009F9F9F
		public void SetInputRespondToKey(string keyboardShortcut)
		{
			if (keyboardShortcut != "")
			{
				Input.Instance.OnlyRespondToKey = keyboardShortcut;
			}
		}

		// Token: 0x06023208 RID: 143880 RVA: 0x009FBDB9 File Offset: 0x009F9FB9
		public void ResetInputRespondToKey(string keyboardShortcut)
		{
			if (keyboardShortcut == Input.Instance.OnlyRespondToKey)
			{
				Input.Instance.OnlyRespondToKey = "";
			}
		}

		// Token: 0x06023209 RID: 143881 RVA: 0x009FBDDC File Offset: 0x009F9FDC
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

		// Token: 0x0602320A RID: 143882 RVA: 0x009FBE09 File Offset: 0x009FA009
		public void ResumeImmersiveMouseMode(EImmersiveMouseModeReason reason)
		{
			if (this.ImmersiveMouseModule != null)
			{
				this.ImmersiveMouseModule.ResumeImmersiveMode(reason);
			}
		}

		// Token: 0x0602320B RID: 143883 RVA: 0x009FBE1F File Offset: 0x009FA01F
		public bool IsImmersiveMouseModeEnabled()
		{
			return this.ImmersiveMouseModule != null && this.ImmersiveMouseModule.IsImmersiveModeEnabled();
		}

		// Token: 0x0602320C RID: 143884 RVA: 0x009FBE36 File Offset: 0x009FA036
		public bool IsImmersiveInputPaused()
		{
			return this.ImmersiveMouseModule != null && this.ImmersiveMouseModule.IsImmersiveInputPaused();
		}

		// Token: 0x0602320D RID: 143885 RVA: 0x009FBE4D File Offset: 0x009FA04D
		public bool GetImmersiveInputWakeState()
		{
			return this.ImmersiveInputWakeState;
		}

		// Token: 0x0602320E RID: 143886 RVA: 0x009FBE55 File Offset: 0x009FA055
		public void SetImmersiveInputWakeState(EInputControllerMainType inputMainType, bool isWake)
		{
			if (this.ImmersiveInputWakeState == isWake)
			{
				return;
			}
			this.ImmersiveInputWakeState = isWake;
			EventSystem.Instance.Emit<EInputControllerMainType, bool>(EEventName.OnImmersiveInputStateChange, inputMainType, isWake);
		}

		// Token: 0x0602320F RID: 143887 RVA: 0x009FBE7C File Offset: 0x009FA07C
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

		// Token: 0x06023210 RID: 143888 RVA: 0x009FBEFC File Offset: 0x009FA0FC
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

		// Token: 0x1700491A RID: 18714
		// (get) Token: 0x06023211 RID: 143889 RVA: 0x009FBF79 File Offset: 0x009FA179
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

		// Token: 0x06023212 RID: 143890 RVA: 0x009FBF9C File Offset: 0x009FA19C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023213 RID: 143891 RVA: 0x009FBF9E File Offset: 0x009FA19E
		public static void ResetStaticDefaultValue()
		{
			InputManager instance = InputManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputManager._instance = null;
		}

		// Token: 0x06023214 RID: 143892 RVA: 0x009FBFB7 File Offset: 0x009FA1B7
		static InputManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputManager.CreateStaticDefaultValue), new Action(InputManager.ResetStaticDefaultValue));
		}

		// Token: 0x04013D3D RID: 81213
		private EMouseCursorVisibleType MouseCursorVisibleType;

		// Token: 0x04013D3E RID: 81214
		private bool IsAlwaysShowMouseCursor;

		// Token: 0x04013D3F RID: 81215
		private bool ManagerMouseStatus;

		// Token: 0x04013D40 RID: 81216
		private bool IsInit;

		// Token: 0x04013D41 RID: 81217
		private readonly InputViewRecord ShowMouseViewRecord = new InputViewRecord();

		// Token: 0x04013D42 RID: 81218
		private bool IsCursorFrameGenDisabled;

		// Token: 0x04013D43 RID: 81219
		public readonly InputViewRecord DisableShortcutKeyViewRecord = new InputViewRecord();

		// Token: 0x04013D44 RID: 81220
		public readonly InputViewRecord DisableCloseViewByShortcutKeyViewRecord = new InputViewRecord();

		// Token: 0x04013D45 RID: 81221
		[Nullable(2)]
		private FInputModeReply InputModeReply;

		// Token: 0x04013D46 RID: 81222
		private readonly ViewHotKeyHandleContainer ViewHotKeyHandleContainer = new ViewHotKeyHandleContainer();

		// Token: 0x04013D47 RID: 81223
		public bool IsAutoMoveCursorToCenter = true;

		// Token: 0x04013D48 RID: 81224
		public bool IsAltPress;

		// Token: 0x04013D49 RID: 81225
		[Nullable(2)]
		public ImmersiveMouseModule ImmersiveMouseModule;

		// Token: 0x04013D4A RID: 81226
		private readonly Dictionary<string, TLockShortcutKeyDelegate> LockShortcutKeyDelegateMap = new Dictionary<string, TLockShortcutKeyDelegate>();

		// Token: 0x04013D4B RID: 81227
		private bool ImmersiveInputWakeState;

		// Token: 0x04013D4C RID: 81228
		[Nullable(2)]
		private static InputManager _instance;
	}
}
