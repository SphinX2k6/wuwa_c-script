using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F3 RID: 14579
	[NullableContext(1)]
	[Nullable(0)]
	public class HotKeyComponent : UiPanelBase
	{
		// Token: 0x06025BAF RID: 154543 RVA: 0x00A9CCAE File Offset: 0x00A9AEAE
		public HotKeyComponent(int hotKeyMapIndex)
		{
			this.HotKeyMapIndex = hotKeyMapIndex;
			this.HotKeyConfig = UiNavigationConfig.Instance.GetHotKeyMapConfig(this.HotKeyMapIndex);
		}

		// Token: 0x06025BB0 RID: 154544 RVA: 0x00A9CCD3 File Offset: 0x00A9AED3
		protected override void OnBeforeCreateImplement()
		{
			this.OnInit();
		}

		// Token: 0x06025BB1 RID: 154545 RVA: 0x00A9CCDC File Offset: 0x00A9AEDC
		protected override UniTask OnBeforeStartAsync()
		{
			HotKeyComponent.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HotKeyComponent.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025BB2 RID: 154546 RVA: 0x00A9CD1F File Offset: 0x00A9AF1F
		private bool GetLogic()
		{
			return this.LogicMode == HotKeyViewDefine.ELogicMode.Min;
		}

		// Token: 0x06025BB3 RID: 154547 RVA: 0x00A9CD2A File Offset: 0x00A9AF2A
		private void OnSetVisible(bool bVisible)
		{
			if (bVisible)
			{
				this.OnRefreshMode();
			}
			else if (this.IsPress)
			{
				this.ReleaseWithoutCheck();
			}
			this.CurComponent.SetVisible(bVisible);
		}

		// Token: 0x06025BB4 RID: 154548 RVA: 0x00A9CD51 File Offset: 0x00A9AF51
		protected virtual void OnRefreshMode()
		{
			this.RefreshKeyIcon();
			this.RefreshHotKeyNameText();
		}

		// Token: 0x06025BB5 RID: 154549 RVA: 0x00A9CD5F File Offset: 0x00A9AF5F
		private void RefreshKeyIcon()
		{
			this.CurComponent.RefreshKeyIcon();
		}

		// Token: 0x06025BB6 RID: 154550 RVA: 0x00A9CD6C File Offset: 0x00A9AF6C
		private void RefreshKeyIconWithoutActive()
		{
			this.CurComponent.RefreshKeyIconWithoutActive();
		}

		// Token: 0x06025BB7 RID: 154551 RVA: 0x00A9CD79 File Offset: 0x00A9AF79
		protected HotKeyMap? GetHotKeyConfig()
		{
			return new HotKeyMap?(this.HotKeyConfig.Value);
		}

		// Token: 0x06025BB8 RID: 154552 RVA: 0x00A9CD8C File Offset: 0x00A9AF8C
		private unsafe void SetLogicMode(HotKeyViewDefine.ELogicMode logicMode, bool isActive)
		{
			bool logic = this.GetLogic();
			if (UiNavigationModel.Instance.IsOpenLog)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiNavigationHotKey;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[LogicMode]模式设置";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("配置id", this.HotKeyMapIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tag", this.GetBindButtonTag());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("模式", HotKeyViewDefine.LogicModeLogString[logicMode]);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("值", isActive);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
			if (isActive)
			{
				if ((this.LogicMode & logicMode) != HotKeyViewDefine.ELogicMode.Min)
				{
					this.LogicMode ^= logicMode;
				}
			}
			else
			{
				this.LogicMode |= logicMode;
			}
			if (logic != this.GetLogic())
			{
				this.OnHotKeyActiveChanged(this.GetLogic());
			}
		}

		// Token: 0x06025BB9 RID: 154553 RVA: 0x00A9CE94 File Offset: 0x00A9B094
		protected void RefreshHotKeyNameText()
		{
			HotKeyMap? hotKeyMap;
			string textId = this.HotKeyTextId ?? ((this.GetHotKeyConfig() != null) ? hotKeyMap.GetValueOrDefault().TextId : null);
			this.CurComponent.RefreshNameText(textId);
		}

		// Token: 0x06025BBA RID: 154554 RVA: 0x00A9CEDC File Offset: 0x00A9B0DC
		protected virtual void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = this.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag != null, false);
		}

		// Token: 0x06025BBB RID: 154555 RVA: 0x00A9CF0D File Offset: 0x00A9B10D
		protected virtual void OnRefreshHotKeyText(UiNavigationViewHandle viewHandle)
		{
		}

		// Token: 0x06025BBC RID: 154556 RVA: 0x00A9CF10 File Offset: 0x00A9B110
		protected virtual void OnRefreshHotKeyTextId(UiNavigationViewHandle viewHandle)
		{
			if (this.CurComponent.GetIsForceSetText())
			{
				return;
			}
			string bindButtonTag = this.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			string hotKeyTextId = (activeListenerByTag != null) ? activeListenerByTag.GetTipsTextIdByState() : null;
			this.SetHotKeyTextId(hotKeyTextId);
			this.RefreshHotKeyNameText();
		}

		// Token: 0x06025BBD RID: 154557 RVA: 0x00A9CF5C File Offset: 0x00A9B15C
		protected virtual void OnRefreshHotKeyShield(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerNotifyShield, focusListener == null || !focusListener.ShieldHotKeyIndexArray.Contains(this.HotKeyMapIndex), false);
		}

		// Token: 0x06025BBE RID: 154558 RVA: 0x00A9CF94 File Offset: 0x00A9B194
		private unsafe void RefreshConfigShield(bool isForce = false)
		{
			if (this.RootItem == null || !this.RootItem.IsValid())
			{
				return;
			}
			HotKeyViewDefine.EHotKeyApplicableType applicableType = (HotKeyViewDefine.EHotKeyApplicableType)this.HotKeyConfig.Value.ApplicableType;
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.KeyboardAndHandle)
			{
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, true, true);
				return;
			}
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyKeyboard)
			{
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, Info.Instance.IsInKeyBoard(), isForce);
				return;
			}
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyHandle)
			{
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, Info.Instance.IsInGamepad(), isForce);
				return;
			}
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyKeyboardTransparent)
			{
				bool flag = Info.Instance.IsInKeyBoard();
				this.RootItem.SetAlpha(!flag);
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, true, isForce);
				if (UiNavigationModel.Instance.IsOpenLog)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiNavigationHotKey;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "仅键鼠透明";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("配置id", this.HotKeyMapIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tag", this.GetBindButtonTag());
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				return;
			}
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyHandleTransparent)
			{
				bool flag2 = Info.Instance.IsInGamepad();
				this.RootItem.SetAlpha(!flag2);
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, true, isForce);
				if (UiNavigationModel.Instance.IsOpenLog)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiNavigationHotKey;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "仅手柄透明";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("配置id", this.HotKeyMapIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Tag", this.GetBindButtonTag());
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
				return;
			}
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.KeyboardAndHandleTransparent)
			{
				bool flag3 = Info.Instance.IsInKeyBoard();
				bool flag4 = Info.Instance.IsInGamepad();
				this.RootItem.SetAlpha((float)((flag3 || flag4) ? 0 : 1));
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, true, true);
				if (UiNavigationModel.Instance.IsOpenLog)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.UiNavigationHotKey;
					ELogAuthor author3 = ELogAuthor.XXJ;
					string message3 = "键盘和手柄透明";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("配置id", this.HotKeyMapIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Tag", this.GetBindButtonTag());
					instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				}
				return;
			}
			if (applicableType == HotKeyViewDefine.EHotKeyApplicableType.OnlyKeyboardTransparentExceptLongPress)
			{
				bool flag5 = Info.Instance.IsInKeyBoard();
				this.RootItem.SetAlpha(!flag5);
				this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ConfigShield, flag5, isForce);
				if (UiNavigationModel.Instance.IsOpenLog)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.UiNavigationHotKey;
					ELogAuthor author4 = ELogAuthor.CB;
					string message4 = "仅键鼠可用且透明,长按时不透明";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("配置id", this.HotKeyMapIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("Tag", this.GetBindButtonTag());
					instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				}
			}
		}

		// Token: 0x06025BBF RID: 154559 RVA: 0x00A9D29C File Offset: 0x00A9B49C
		public void InitHotKeyLogicMode()
		{
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.LogicByNoController, !Info.Instance.IsInTouch(), false);
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, true);
			this.RefreshConfigShield(false);
		}

		// Token: 0x06025BC0 RID: 154560 RVA: 0x00A9D2C4 File Offset: 0x00A9B4C4
		public void RegisterMe()
		{
			this.AddEventListener();
			this.RefreshConfigShield(true);
			HotKeyCombineComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.RefreshPcAndGamepad();
			}
			this.RefreshKeyIconWithoutActive();
		}

		// Token: 0x06025BC1 RID: 154561 RVA: 0x00A9D2EA File Offset: 0x00A9B4EA
		public void UnRegisterMe()
		{
			this.RemoveEventListener();
			this.OnUnRegisterMe();
			this.HandleFinishInputAxis(this.GetAxisName());
		}

		// Token: 0x06025BC2 RID: 154562 RVA: 0x00A9D304 File Offset: 0x00A9B504
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			if (this.HotKeyConfig != null && this.HotKeyConfig.GetValueOrDefault().HideInShowMouse)
			{
				EventSystem.Instance.Add(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursorChanged));
				this.OnShowMouseCursorChanged(InputManager.Instance.IsShowMouseCursor());
			}
			this.OnAddEventListener();
		}

		// Token: 0x06025BC3 RID: 154563 RVA: 0x00A9D380 File Offset: 0x00A9B580
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			if (this.HotKeyConfig != null && this.HotKeyConfig.GetValueOrDefault().HideInShowMouse)
			{
				EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursorChanged));
			}
			this.OnRemoveEventListener();
		}

		// Token: 0x06025BC4 RID: 154564 RVA: 0x00A9D3EC File Offset: 0x00A9B5EC
		private void OnShowMouseCursorChanged(bool bShowMouseCursor)
		{
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ShowMouseShield, !bShowMouseCursor, false);
		}

		// Token: 0x06025BC5 RID: 154565 RVA: 0x00A9D400 File Offset: 0x00A9B600
		private void OnActionKeyChanged(string notifyActionName)
		{
			string actionName = this.GetActionName();
			if (!StringUtils.IsEmpty(actionName) && actionName == notifyActionName)
			{
				this.RefreshKeyIconWithoutActive();
			}
		}

		// Token: 0x06025BC6 RID: 154566 RVA: 0x00A9D42C File Offset: 0x00A9B62C
		public void SetVisibleMode(HotKeyViewDefine.ELogicMode logicMode, bool isActive, bool isForce = false)
		{
			HotKeyViewDefine.ELogicMode logicMode2 = this.LogicMode;
			this.SetLogicMode(logicMode, isActive);
			if (this.LogicMode != logicMode2 || isForce || this.ForceRefreshVisibleMode)
			{
				this.ForceRefreshVisibleMode = false;
				this.OnSetVisible(this.GetLogic());
			}
		}

		// Token: 0x06025BC7 RID: 154567 RVA: 0x00A9D473 File Offset: 0x00A9B673
		public void OnlySetVisibleMode(HotKeyViewDefine.ELogicMode logicMode, bool isActive)
		{
			this.ForceRefreshVisibleMode = true;
			this.SetLogicMode(logicMode, isActive);
		}

		// Token: 0x06025BC8 RID: 154568 RVA: 0x00A9D484 File Offset: 0x00A9B684
		public void SetHotKeyDescTextForce(string text)
		{
			this.CurComponent.SetNameTextForce(true);
			this.CurComponent.SetNameText(text);
		}

		// Token: 0x06025BC9 RID: 154569 RVA: 0x00A9D49E File Offset: 0x00A9B69E
		public void ResetHotKeyDescTextForce()
		{
			this.CurComponent.SetNameTextForce(false);
		}

		// Token: 0x06025BCA RID: 154570 RVA: 0x00A9D4AC File Offset: 0x00A9B6AC
		[NullableContext(2)]
		public void SetHotKeyTextId(string textId)
		{
			if (StringUtils.IsEmpty(textId))
			{
				this.HotKeyTextId = null;
				return;
			}
			this.HotKeyTextId = textId;
		}

		// Token: 0x06025BCB RID: 154571 RVA: 0x00A9D4C5 File Offset: 0x00A9B6C5
		public bool IsHotKeyActive()
		{
			return this.LogicMode == HotKeyViewDefine.ELogicMode.Min;
		}

		// Token: 0x06025BCC RID: 154572 RVA: 0x00A9D4D0 File Offset: 0x00A9B6D0
		public bool IsAllowTickContinue()
		{
			return this.LogicMode == HotKeyViewDefine.ELogicMode.Min || this.IsStartInputAxis;
		}

		// Token: 0x06025BCD RID: 154573 RVA: 0x00A9D4E4 File Offset: 0x00A9B6E4
		public void RefreshMode()
		{
			Log.Instance.Info(ELogModule.UiNavigationHotKey, ELogAuthor.XXJ, "切换了控制器,强制刷新表现", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RefreshConfigShield(true);
			HotKeyCombineComponent curComponent = this.CurComponent;
			if (curComponent != null)
			{
				curComponent.RefreshPcAndGamepad();
			}
			this.OnRefreshByControllerChange();
		}

		// Token: 0x06025BCE RID: 154574 RVA: 0x00A9D530 File Offset: 0x00A9B730
		public void Press()
		{
			if (!this.GetLogic())
			{
				return;
			}
			this.IsPress = true;
			HotKeyMap? hotKeyConfig = this.GetHotKeyConfig();
			if (hotKeyConfig != null)
			{
				this.OnPress(hotKeyConfig.Value);
			}
		}

		// Token: 0x06025BCF RID: 154575 RVA: 0x00A9D56A File Offset: 0x00A9B76A
		public void Release()
		{
			if (!this.GetLogic() || !this.IsPress)
			{
				return;
			}
			this.ReleaseWithoutCheck();
		}

		// Token: 0x06025BD0 RID: 154576 RVA: 0x00A9D584 File Offset: 0x00A9B784
		protected void ReleaseWithoutCheck()
		{
			this.IsPress = false;
			HotKeyMap? hotKeyConfig = this.GetHotKeyConfig();
			if (hotKeyConfig != null)
			{
				this.OnRelease(hotKeyConfig.Value);
			}
		}

		// Token: 0x06025BD1 RID: 154577 RVA: 0x00A9D5B5 File Offset: 0x00A9B7B5
		public void InputAxis(string axisName, float value)
		{
			if (!this.GetLogic())
			{
				this.HandleFinishInputAxis(axisName);
				return;
			}
			this.HandleStartInputAxis(axisName);
			this.OnInputAxis(axisName, value);
		}

		// Token: 0x06025BD2 RID: 154578 RVA: 0x00A9D5D6 File Offset: 0x00A9B7D6
		private void HandleStartInputAxis(string axisName)
		{
			if (!this.IsStartInputAxis)
			{
				this.IsStartInputAxis = true;
				this.OnStartInputAxis(axisName);
			}
		}

		// Token: 0x06025BD3 RID: 154579 RVA: 0x00A9D5EE File Offset: 0x00A9B7EE
		private void HandleFinishInputAxis(string axisName)
		{
			if (this.IsStartInputAxis)
			{
				this.IsStartInputAxis = false;
				this.OnFinishInputAxis(axisName);
			}
		}

		// Token: 0x06025BD4 RID: 154580 RVA: 0x00A9D608 File Offset: 0x00A9B808
		[NullableContext(2)]
		public string GetBindButtonTag()
		{
			if (this.HotKeyConfig == null)
			{
				return null;
			}
			return this.HotKeyConfig.GetValueOrDefault().BindButtonTag;
		}

		// Token: 0x06025BD5 RID: 154581 RVA: 0x00A9D634 File Offset: 0x00A9B834
		[NullableContext(2)]
		public string GetActionName()
		{
			if (this.HotKeyConfig == null)
			{
				return null;
			}
			return this.HotKeyConfig.GetValueOrDefault().ActionName;
		}

		// Token: 0x06025BD6 RID: 154582 RVA: 0x00A9D660 File Offset: 0x00A9B860
		[NullableContext(2)]
		public string GetAxisName()
		{
			if (this.HotKeyConfig == null)
			{
				return null;
			}
			return this.HotKeyConfig.GetValueOrDefault().AxisName;
		}

		// Token: 0x06025BD7 RID: 154583 RVA: 0x00A9D68C File Offset: 0x00A9B88C
		public bool IsAxisAllDirection()
		{
			return ((this.HotKeyConfig != null) ? new int?(this.HotKeyConfig.GetValueOrDefault().AxisDirection) : null).Value == 0;
		}

		// Token: 0x06025BD8 RID: 154584 RVA: 0x00A9D6D0 File Offset: 0x00A9B8D0
		public bool IsAxisPositive()
		{
			return ((this.HotKeyConfig != null) ? new int?(this.HotKeyConfig.GetValueOrDefault().AxisDirection) : null).Value != 1;
		}

		// Token: 0x06025BD9 RID: 154585 RVA: 0x00A9D718 File Offset: 0x00A9B918
		public bool IsAxisReverse()
		{
			return ((this.HotKeyConfig != null) ? new int?(this.HotKeyConfig.GetValueOrDefault().AxisDirection) : null).Value != 2;
		}

		// Token: 0x06025BDA RID: 154586 RVA: 0x00A9D75F File Offset: 0x00A9B95F
		public void SetHotKeyFunctionType(string functionType)
		{
			this.FunctionType = functionType;
		}

		// Token: 0x06025BDB RID: 154587 RVA: 0x00A9D768 File Offset: 0x00A9B968
		public string GetHotKeyFunctionType()
		{
			return this.FunctionType;
		}

		// Token: 0x06025BDC RID: 154588 RVA: 0x00A9D770 File Offset: 0x00A9B970
		public bool IsOccupancyFightInput()
		{
			return this.OnIsOccupancyFightInput();
		}

		// Token: 0x06025BDD RID: 154589 RVA: 0x00A9D778 File Offset: 0x00A9B978
		public void RefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.OnRefreshHotKeyShield(viewHandle);
			this.OnRefreshSelfHotKeyState(viewHandle);
			this.RefreshConfigShield(false);
			this.HandleLogicAfterRefresh(viewHandle);
		}

		// Token: 0x06025BDE RID: 154590 RVA: 0x00A9D796 File Offset: 0x00A9B996
		public void RefreshSelfHotKeyText(UiNavigationViewHandle viewHandle)
		{
			this.OnRefreshHotKeyText(viewHandle);
			this.OnRefreshHotKeyTextId(viewHandle);
		}

		// Token: 0x06025BDF RID: 154591 RVA: 0x00A9D7A6 File Offset: 0x00A9B9A6
		public void SetHotKeyType(HotKeyTypeBase hotKeyType)
		{
			this.CurComponent.SetHotKeyType(hotKeyType);
		}

		// Token: 0x06025BE0 RID: 154592 RVA: 0x00A9D7B4 File Offset: 0x00A9B9B4
		public void SetLinkComponent(TsUiHotKeyLinkListener linkComponent)
		{
			this.LinkComponent = linkComponent;
		}

		// Token: 0x06025BE1 RID: 154593 RVA: 0x00A9D7BD File Offset: 0x00A9B9BD
		[NullableContext(2)]
		public bool IsLinkListener(AActor actor)
		{
			if (this.LinkComponent == null)
			{
				return true;
			}
			if (actor == null)
			{
				return false;
			}
			TArray<AActor> actorList = this.LinkComponent.ActorList;
			return actorList != null && actorList.Contains(actor);
		}

		// Token: 0x06025BE2 RID: 154594 RVA: 0x00A9D7E5 File Offset: 0x00A9B9E5
		public int GetHotKeyMapIndex()
		{
			return this.HotKeyMapIndex;
		}

		// Token: 0x06025BE3 RID: 154595 RVA: 0x00A9D7ED File Offset: 0x00A9B9ED
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x06025BE4 RID: 154596 RVA: 0x00A9D7F5 File Offset: 0x00A9B9F5
		protected virtual void OnInit()
		{
		}

		// Token: 0x06025BE5 RID: 154597 RVA: 0x00A9D7F7 File Offset: 0x00A9B9F7
		protected virtual void OnRefreshByControllerChange()
		{
		}

		// Token: 0x06025BE6 RID: 154598 RVA: 0x00A9D7F9 File Offset: 0x00A9B9F9
		protected virtual void OnHotKeyActiveChanged(bool isActive)
		{
		}

		// Token: 0x06025BE7 RID: 154599 RVA: 0x00A9D7FB File Offset: 0x00A9B9FB
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x06025BE8 RID: 154600 RVA: 0x00A9D7FD File Offset: 0x00A9B9FD
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x06025BE9 RID: 154601 RVA: 0x00A9D7FF File Offset: 0x00A9B9FF
		protected virtual void OnUnRegisterMe()
		{
		}

		// Token: 0x06025BEA RID: 154602 RVA: 0x00A9D801 File Offset: 0x00A9BA01
		protected virtual void OnClear()
		{
		}

		// Token: 0x06025BEB RID: 154603 RVA: 0x00A9D803 File Offset: 0x00A9BA03
		protected virtual void HandleLogicAfterRefresh(UiNavigationViewHandle viewHandle)
		{
		}

		// Token: 0x06025BEC RID: 154604 RVA: 0x00A9D808 File Offset: 0x00A9BA08
		protected virtual bool OnIsOccupancyFightInput()
		{
			return this.HotKeyConfig == null || this.HotKeyConfig.GetValueOrDefault().IsOccupancyFightInput;
		}

		// Token: 0x06025BED RID: 154605 RVA: 0x00A9D833 File Offset: 0x00A9BA33
		protected virtual void OnPress(HotKeyMap config)
		{
		}

		// Token: 0x06025BEE RID: 154606 RVA: 0x00A9D835 File Offset: 0x00A9BA35
		protected virtual void OnRelease(HotKeyMap config)
		{
		}

		// Token: 0x06025BEF RID: 154607 RVA: 0x00A9D837 File Offset: 0x00A9BA37
		protected virtual void OnInputAxis(string axisName, float value)
		{
		}

		// Token: 0x06025BF0 RID: 154608 RVA: 0x00A9D839 File Offset: 0x00A9BA39
		protected virtual void OnStartInputAxis(string axisName)
		{
		}

		// Token: 0x06025BF1 RID: 154609 RVA: 0x00A9D83B File Offset: 0x00A9BA3B
		protected virtual void OnFinishInputAxis(string axisName)
		{
		}

		// Token: 0x06025BF2 RID: 154610 RVA: 0x00A9D840 File Offset: 0x00A9BA40
		protected virtual bool GetIsLongPress()
		{
			return this.HotKeyConfig != null && this.HotKeyConfig.Value.LongPressTime > 0;
		}

		// Token: 0x06025BF3 RID: 154611 RVA: 0x00A9D872 File Offset: 0x00A9BA72
		public void ResetPressState()
		{
			if (!this.IsLongPress && this.IsPress)
			{
				this.IsPress = false;
			}
		}

		// Token: 0x04014D07 RID: 85255
		protected int HotKeyMapIndex;

		// Token: 0x04014D08 RID: 85256
		[Nullable(2)]
		protected HotKeyCombineComponent CurComponent;

		// Token: 0x04014D09 RID: 85257
		protected bool IsPress;

		// Token: 0x04014D0A RID: 85258
		private readonly HotKeyMap? HotKeyConfig;

		// Token: 0x04014D0B RID: 85259
		private HotKeyViewDefine.ELogicMode LogicMode;

		// Token: 0x04014D0C RID: 85260
		[Nullable(2)]
		protected string HotKeyTextId;

		// Token: 0x04014D0D RID: 85261
		[Nullable(2)]
		private string FunctionType;

		// Token: 0x04014D0E RID: 85262
		[Nullable(2)]
		private string FullPath;

		// Token: 0x04014D0F RID: 85263
		[Nullable(2)]
		private TsUiHotKeyLinkListener LinkComponent;

		// Token: 0x04014D10 RID: 85264
		private bool ForceRefreshVisibleMode;

		// Token: 0x04014D11 RID: 85265
		private bool IsStartInputAxis;

		// Token: 0x04014D12 RID: 85266
		private bool IsLongPress;
	}
}
