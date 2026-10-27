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
	// Token: 0x0200497B RID: 18811
	[NullableContext(1)]
	[Nullable(0)]
	public class HotKeyComponent : UiPanelBase
	{
		// Token: 0x0603107F RID: 200831 RVA: 0x00B61DCE File Offset: 0x00B5FFCE
		public HotKeyComponent(int hotKeyMapIndex)
		{
			this.HotKeyMapIndex = hotKeyMapIndex;
			this.HotKeyConfig = UiNavigationConfig.Instance.GetHotKeyMapConfig(this.HotKeyMapIndex);
		}

		// Token: 0x06031080 RID: 200832 RVA: 0x00B61DF3 File Offset: 0x00B5FFF3
		protected override void OnBeforeCreateImplement()
		{
			this.OnInit();
		}

		// Token: 0x06031081 RID: 200833 RVA: 0x00B61DFC File Offset: 0x00B5FFFC
		protected override UniTask OnBeforeStartAsync()
		{
			HotKeyComponent.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<HotKeyComponent.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031082 RID: 200834 RVA: 0x00B61E3F File Offset: 0x00B6003F
		private bool GetLogic()
		{
			return this.LogicMode == HotKeyViewDefine.ELogicMode.Min;
		}

		// Token: 0x06031083 RID: 200835 RVA: 0x00B61E4A File Offset: 0x00B6004A
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

		// Token: 0x06031084 RID: 200836 RVA: 0x00B61E71 File Offset: 0x00B60071
		protected virtual void OnRefreshMode()
		{
			this.RefreshKeyIcon();
			this.RefreshHotKeyNameText();
		}

		// Token: 0x06031085 RID: 200837 RVA: 0x00B61E7F File Offset: 0x00B6007F
		private void RefreshKeyIcon()
		{
			this.CurComponent.RefreshKeyIcon();
		}

		// Token: 0x06031086 RID: 200838 RVA: 0x00B61E8C File Offset: 0x00B6008C
		private void RefreshKeyIconWithoutActive()
		{
			this.CurComponent.RefreshKeyIconWithoutActive();
		}

		// Token: 0x06031087 RID: 200839 RVA: 0x00B61E99 File Offset: 0x00B60099
		protected HotKeyMap? GetHotKeyConfig()
		{
			return new HotKeyMap?(this.HotKeyConfig.Value);
		}

		// Token: 0x06031088 RID: 200840 RVA: 0x00B61EAC File Offset: 0x00B600AC
		private unsafe void SetLogicMode(HotKeyViewDefine.ELogicMode logicMode, bool isActive)
		{
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
					return;
				}
			}
			else
			{
				this.LogicMode |= logicMode;
			}
		}

		// Token: 0x06031089 RID: 200841 RVA: 0x00B61F98 File Offset: 0x00B60198
		protected void RefreshHotKeyNameText()
		{
			HotKeyMap? hotKeyMap;
			string textId = this.HotKeyTextId ?? ((this.GetHotKeyConfig() != null) ? hotKeyMap.GetValueOrDefault().TextId : null);
			this.CurComponent.RefreshNameText(textId);
		}

		// Token: 0x0603108A RID: 200842 RVA: 0x00B61FE0 File Offset: 0x00B601E0
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

		// Token: 0x0603108B RID: 200843 RVA: 0x00B62011 File Offset: 0x00B60211
		protected virtual void OnRefreshHotKeyText(UiNavigationViewHandle viewHandle)
		{
		}

		// Token: 0x0603108C RID: 200844 RVA: 0x00B62014 File Offset: 0x00B60214
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

		// Token: 0x0603108D RID: 200845 RVA: 0x00B62060 File Offset: 0x00B60260
		protected virtual void OnRefreshHotKeyShield(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerNotifyShield, focusListener == null || !focusListener.ShieldHotKeyIndexArray.Contains(this.HotKeyMapIndex), false);
		}

		// Token: 0x0603108E RID: 200846 RVA: 0x00B62098 File Offset: 0x00B60298
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

		// Token: 0x0603108F RID: 200847 RVA: 0x00B623A0 File Offset: 0x00B605A0
		public void InitHotKeyLogicMode()
		{
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.LogicByNoController, !Info.Instance.IsInTouch(), false);
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, true);
			this.RefreshConfigShield(false);
		}

		// Token: 0x06031090 RID: 200848 RVA: 0x00B623C8 File Offset: 0x00B605C8
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

		// Token: 0x06031091 RID: 200849 RVA: 0x00B623EE File Offset: 0x00B605EE
		public void UnRegisterMe()
		{
			this.RemoveEventListener();
			this.OnUnRegisterMe();
			this.HandleFinishInputAxis(this.GetAxisName());
		}

		// Token: 0x06031092 RID: 200850 RVA: 0x00B62408 File Offset: 0x00B60608
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

		// Token: 0x06031093 RID: 200851 RVA: 0x00B62484 File Offset: 0x00B60684
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActionKeyChanged, new Action<string>(this.OnActionKeyChanged));
			if (this.HotKeyConfig != null && this.HotKeyConfig.GetValueOrDefault().HideInShowMouse)
			{
				EventSystem.Instance.Remove(EEventName.OnShowMouseCursor, new Action<bool>(this.OnShowMouseCursorChanged));
			}
			this.OnRemoveEventListener();
		}

		// Token: 0x06031094 RID: 200852 RVA: 0x00B624F0 File Offset: 0x00B606F0
		private void OnShowMouseCursorChanged(bool bShowMouseCursor)
		{
			this.SetVisibleMode(HotKeyViewDefine.ELogicMode.ShowMouseShield, !bShowMouseCursor, false);
		}

		// Token: 0x06031095 RID: 200853 RVA: 0x00B62504 File Offset: 0x00B60704
		private void OnActionKeyChanged(string notifyActionName)
		{
			string actionName = this.GetActionName();
			if (!StringUtils.IsEmpty(actionName) && actionName == notifyActionName)
			{
				this.RefreshKeyIconWithoutActive();
			}
		}

		// Token: 0x06031096 RID: 200854 RVA: 0x00B62530 File Offset: 0x00B60730
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

		// Token: 0x06031097 RID: 200855 RVA: 0x00B62577 File Offset: 0x00B60777
		public void OnlySetVisibleMode(HotKeyViewDefine.ELogicMode logicMode, bool isActive)
		{
			this.ForceRefreshVisibleMode = true;
			this.SetLogicMode(logicMode, isActive);
		}

		// Token: 0x06031098 RID: 200856 RVA: 0x00B62588 File Offset: 0x00B60788
		public void SetHotKeyDescTextForce(string text)
		{
			this.CurComponent.SetNameTextForce(true);
			this.CurComponent.SetNameText(text);
		}

		// Token: 0x06031099 RID: 200857 RVA: 0x00B625A2 File Offset: 0x00B607A2
		public void ResetHotKeyDescTextForce()
		{
			this.CurComponent.SetNameTextForce(false);
		}

		// Token: 0x0603109A RID: 200858 RVA: 0x00B625B0 File Offset: 0x00B607B0
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

		// Token: 0x0603109B RID: 200859 RVA: 0x00B625C9 File Offset: 0x00B607C9
		public bool IsHotKeyActive()
		{
			return this.LogicMode == HotKeyViewDefine.ELogicMode.Min;
		}

		// Token: 0x0603109C RID: 200860 RVA: 0x00B625D4 File Offset: 0x00B607D4
		public bool IsAllowTickContinue()
		{
			return this.LogicMode == HotKeyViewDefine.ELogicMode.Min || this.IsStartInputAxis;
		}

		// Token: 0x0603109D RID: 200861 RVA: 0x00B625E8 File Offset: 0x00B607E8
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

		// Token: 0x0603109E RID: 200862 RVA: 0x00B62634 File Offset: 0x00B60834
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

		// Token: 0x0603109F RID: 200863 RVA: 0x00B6266E File Offset: 0x00B6086E
		public void Release()
		{
			if (!this.GetLogic() || !this.IsPress)
			{
				return;
			}
			this.ReleaseWithoutCheck();
		}

		// Token: 0x060310A0 RID: 200864 RVA: 0x00B62688 File Offset: 0x00B60888
		protected void ReleaseWithoutCheck()
		{
			this.IsPress = false;
			HotKeyMap? hotKeyConfig = this.GetHotKeyConfig();
			if (hotKeyConfig != null)
			{
				this.OnRelease(hotKeyConfig.Value);
			}
		}

		// Token: 0x060310A1 RID: 200865 RVA: 0x00B626B9 File Offset: 0x00B608B9
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

		// Token: 0x060310A2 RID: 200866 RVA: 0x00B626DA File Offset: 0x00B608DA
		private void HandleStartInputAxis(string axisName)
		{
			if (!this.IsStartInputAxis)
			{
				this.IsStartInputAxis = true;
				this.OnStartInputAxis(axisName);
			}
		}

		// Token: 0x060310A3 RID: 200867 RVA: 0x00B626F2 File Offset: 0x00B608F2
		private void HandleFinishInputAxis(string axisName)
		{
			if (this.IsStartInputAxis)
			{
				this.IsStartInputAxis = false;
				this.OnFinishInputAxis(axisName);
			}
		}

		// Token: 0x060310A4 RID: 200868 RVA: 0x00B6270C File Offset: 0x00B6090C
		[NullableContext(2)]
		public string GetBindButtonTag()
		{
			if (this.HotKeyConfig == null)
			{
				return null;
			}
			return this.HotKeyConfig.GetValueOrDefault().BindButtonTag;
		}

		// Token: 0x060310A5 RID: 200869 RVA: 0x00B62738 File Offset: 0x00B60938
		[NullableContext(2)]
		public string GetActionName()
		{
			if (this.HotKeyConfig == null)
			{
				return null;
			}
			return this.HotKeyConfig.GetValueOrDefault().ActionName;
		}

		// Token: 0x060310A6 RID: 200870 RVA: 0x00B62764 File Offset: 0x00B60964
		[NullableContext(2)]
		public string GetAxisName()
		{
			if (this.HotKeyConfig == null)
			{
				return null;
			}
			return this.HotKeyConfig.GetValueOrDefault().AxisName;
		}

		// Token: 0x060310A7 RID: 200871 RVA: 0x00B62790 File Offset: 0x00B60990
		public bool IsAxisAllDirection()
		{
			return ((this.HotKeyConfig != null) ? new int?(this.HotKeyConfig.GetValueOrDefault().AxisDirection) : null).Value == 0;
		}

		// Token: 0x060310A8 RID: 200872 RVA: 0x00B627D4 File Offset: 0x00B609D4
		public bool IsAxisPositive()
		{
			return ((this.HotKeyConfig != null) ? new int?(this.HotKeyConfig.GetValueOrDefault().AxisDirection) : null).Value != 1;
		}

		// Token: 0x060310A9 RID: 200873 RVA: 0x00B6281C File Offset: 0x00B60A1C
		public bool IsAxisReverse()
		{
			return ((this.HotKeyConfig != null) ? new int?(this.HotKeyConfig.GetValueOrDefault().AxisDirection) : null).Value != 2;
		}

		// Token: 0x060310AA RID: 200874 RVA: 0x00B62863 File Offset: 0x00B60A63
		public void SetHotKeyFunctionType(string functionType)
		{
			this.FunctionType = functionType;
		}

		// Token: 0x060310AB RID: 200875 RVA: 0x00B6286C File Offset: 0x00B60A6C
		public string GetHotKeyFunctionType()
		{
			return this.FunctionType;
		}

		// Token: 0x060310AC RID: 200876 RVA: 0x00B62874 File Offset: 0x00B60A74
		public bool IsOccupancyFightInput()
		{
			return this.OnIsOccupancyFightInput();
		}

		// Token: 0x060310AD RID: 200877 RVA: 0x00B6287C File Offset: 0x00B60A7C
		public void RefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.OnRefreshHotKeyShield(viewHandle);
			this.OnRefreshSelfHotKeyState(viewHandle);
			this.RefreshConfigShield(false);
			this.HandleLogicAfterRefresh(viewHandle);
		}

		// Token: 0x060310AE RID: 200878 RVA: 0x00B6289A File Offset: 0x00B60A9A
		public void RefreshSelfHotKeyText(UiNavigationViewHandle viewHandle)
		{
			this.OnRefreshHotKeyText(viewHandle);
			this.OnRefreshHotKeyTextId(viewHandle);
		}

		// Token: 0x060310AF RID: 200879 RVA: 0x00B628AA File Offset: 0x00B60AAA
		public void SetHotKeyType(HotKeyTypeBase hotKeyType)
		{
			this.CurComponent.SetHotKeyType(hotKeyType);
		}

		// Token: 0x060310B0 RID: 200880 RVA: 0x00B628B8 File Offset: 0x00B60AB8
		public void SetLinkComponent(TsUiHotKeyLinkListener linkComponent)
		{
			this.LinkComponent = linkComponent;
		}

		// Token: 0x060310B1 RID: 200881 RVA: 0x00B628C1 File Offset: 0x00B60AC1
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

		// Token: 0x060310B2 RID: 200882 RVA: 0x00B628E9 File Offset: 0x00B60AE9
		public int GetHotKeyMapIndex()
		{
			return this.HotKeyMapIndex;
		}

		// Token: 0x060310B3 RID: 200883 RVA: 0x00B628F1 File Offset: 0x00B60AF1
		public void Clear()
		{
			this.OnClear();
		}

		// Token: 0x060310B4 RID: 200884 RVA: 0x00B628F9 File Offset: 0x00B60AF9
		protected virtual void OnInit()
		{
		}

		// Token: 0x060310B5 RID: 200885 RVA: 0x00B628FB File Offset: 0x00B60AFB
		protected virtual void OnRefreshByControllerChange()
		{
		}

		// Token: 0x060310B6 RID: 200886 RVA: 0x00B628FD File Offset: 0x00B60AFD
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x060310B7 RID: 200887 RVA: 0x00B628FF File Offset: 0x00B60AFF
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x060310B8 RID: 200888 RVA: 0x00B62901 File Offset: 0x00B60B01
		protected virtual void OnUnRegisterMe()
		{
		}

		// Token: 0x060310B9 RID: 200889 RVA: 0x00B62903 File Offset: 0x00B60B03
		protected virtual void OnClear()
		{
		}

		// Token: 0x060310BA RID: 200890 RVA: 0x00B62905 File Offset: 0x00B60B05
		protected virtual void HandleLogicAfterRefresh(UiNavigationViewHandle viewHandle)
		{
		}

		// Token: 0x060310BB RID: 200891 RVA: 0x00B62908 File Offset: 0x00B60B08
		protected virtual bool OnIsOccupancyFightInput()
		{
			return this.HotKeyConfig == null || this.HotKeyConfig.GetValueOrDefault().IsOccupancyFightInput;
		}

		// Token: 0x060310BC RID: 200892 RVA: 0x00B62933 File Offset: 0x00B60B33
		public virtual void SetDataCallback(Func<object> callback)
		{
		}

		// Token: 0x060310BD RID: 200893 RVA: 0x00B62935 File Offset: 0x00B60B35
		protected virtual void OnPress(HotKeyMap config)
		{
		}

		// Token: 0x060310BE RID: 200894 RVA: 0x00B62937 File Offset: 0x00B60B37
		protected virtual void OnRelease(HotKeyMap config)
		{
		}

		// Token: 0x060310BF RID: 200895 RVA: 0x00B62939 File Offset: 0x00B60B39
		protected virtual void OnInputAxis(string axisName, float value)
		{
		}

		// Token: 0x060310C0 RID: 200896 RVA: 0x00B6293B File Offset: 0x00B60B3B
		protected virtual void OnStartInputAxis(string axisName)
		{
		}

		// Token: 0x060310C1 RID: 200897 RVA: 0x00B6293D File Offset: 0x00B60B3D
		protected virtual void OnFinishInputAxis(string axisName)
		{
		}

		// Token: 0x060310C2 RID: 200898 RVA: 0x00B62940 File Offset: 0x00B60B40
		protected virtual bool GetIsLongPress()
		{
			return this.HotKeyConfig != null && this.HotKeyConfig.Value.LongPressTime > 0;
		}

		// Token: 0x060310C3 RID: 200899 RVA: 0x00B62972 File Offset: 0x00B60B72
		public void ResetPressState()
		{
			if (!this.IsLongPress && this.IsPress)
			{
				this.IsPress = false;
			}
		}

		// Token: 0x0401A494 RID: 107668
		protected int HotKeyMapIndex;

		// Token: 0x0401A495 RID: 107669
		[Nullable(2)]
		protected HotKeyCombineComponent CurComponent;

		// Token: 0x0401A496 RID: 107670
		protected bool IsPress;

		// Token: 0x0401A497 RID: 107671
		private readonly HotKeyMap? HotKeyConfig;

		// Token: 0x0401A498 RID: 107672
		private HotKeyViewDefine.ELogicMode LogicMode;

		// Token: 0x0401A499 RID: 107673
		[Nullable(2)]
		protected string HotKeyTextId;

		// Token: 0x0401A49A RID: 107674
		[Nullable(2)]
		private string FunctionType;

		// Token: 0x0401A49B RID: 107675
		[Nullable(2)]
		private string FullPath;

		// Token: 0x0401A49C RID: 107676
		[Nullable(2)]
		private TsUiHotKeyLinkListener LinkComponent;

		// Token: 0x0401A49D RID: 107677
		private bool ForceRefreshVisibleMode;

		// Token: 0x0401A49E RID: 107678
		private bool IsStartInputAxis;

		// Token: 0x0401A49F RID: 107679
		private bool IsLongPress;
	}
}
