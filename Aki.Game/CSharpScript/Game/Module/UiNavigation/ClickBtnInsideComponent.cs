using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C7 RID: 14535
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnInsideComponent : HotKeyComponent
	{
		// Token: 0x06025B0E RID: 154382 RVA: 0x00A9B79E File Offset: 0x00A9999E
		public ClickBtnInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B0F RID: 154383 RVA: 0x00A9B7A8 File Offset: 0x00A999A8
		private void ClickButtonInside(ENavigationDirectionType direction)
		{
			if (base.IsAxisAllDirection())
			{
				UiNavigationNewController.Instance.ClickButtonInside(base.GetBindButtonTag());
				return;
			}
			if (direction == ENavigationDirectionType.Left && base.IsAxisReverse())
			{
				UiNavigationNewController.Instance.ClickButtonInside(base.GetBindButtonTag());
				return;
			}
			if (direction == ENavigationDirectionType.Right && base.IsAxisPositive())
			{
				UiNavigationNewController.Instance.ClickButtonInside(base.GetBindButtonTag());
			}
		}

		// Token: 0x06025B10 RID: 154384 RVA: 0x00A9B807 File Offset: 0x00A99A07
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButtonInside(config.BindButtonTag);
		}

		// Token: 0x06025B11 RID: 154385 RVA: 0x00A9B81A File Offset: 0x00A99A1A
		protected override void OnStartInputAxis(string axisName)
		{
			UiNavigationJoystickInput.RegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.ClickButtonInside));
		}

		// Token: 0x06025B12 RID: 154386 RVA: 0x00A9B82D File Offset: 0x00A99A2D
		protected override void OnFinishInputAxis(string axisName)
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.ClickButtonInside));
		}

		// Token: 0x06025B13 RID: 154387 RVA: 0x00A9B840 File Offset: 0x00A99A40
		protected override void OnRefreshHotKeyText(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = focusListener.GetChildListenerByTag(bindButtonTag);
			}
			TsUiNavigationTextChangeListener tsUiNavigationTextChangeListener = (tsUiNavigationBehaviorListener != null) ? tsUiNavigationBehaviorListener.GetTextChangeComponent() : null;
			if (tsUiNavigationTextChangeListener != null)
			{
				base.SetHotKeyDescTextForce(tsUiNavigationTextChangeListener.Text.GetText());
				return;
			}
			base.ResetHotKeyDescTextForce();
		}

		// Token: 0x06025B14 RID: 154388 RVA: 0x00A9B8A8 File Offset: 0x00A99AA8
		protected override void OnRefreshHotKeyTextId(UiNavigationViewHandle viewHandle)
		{
			if (this.CurComponent.GetIsForceSetText())
			{
				return;
			}
			string bindButtonTag = base.GetBindButtonTag();
			if (StringUtils.IsEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = focusListener.GetChildListenerByTag(bindButtonTag);
			}
			string hotKeyTextId = (tsUiNavigationBehaviorListener != null) ? tsUiNavigationBehaviorListener.GetTipsTextIdByState() : null;
			base.SetHotKeyTextId(hotKeyTextId);
			base.RefreshHotKeyNameText();
		}

		// Token: 0x06025B15 RID: 154389 RVA: 0x00A9B910 File Offset: 0x00A99B10
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!base.IsLinkListener(focusListener.GetOwner()))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = focusListener.GetChildListenerByTag(bindButtonTag);
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsListenerActive(), false);
		}
	}
}
