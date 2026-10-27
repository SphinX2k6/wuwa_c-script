using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200494F RID: 18767
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnInsideComponent : HotKeyComponent
	{
		// Token: 0x06030FDE RID: 200670 RVA: 0x00B608BE File Offset: 0x00B5EABE
		public ClickBtnInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FDF RID: 200671 RVA: 0x00B608C8 File Offset: 0x00B5EAC8
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

		// Token: 0x06030FE0 RID: 200672 RVA: 0x00B60927 File Offset: 0x00B5EB27
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButtonInside(config.BindButtonTag);
		}

		// Token: 0x06030FE1 RID: 200673 RVA: 0x00B6093A File Offset: 0x00B5EB3A
		protected override void OnStartInputAxis(string axisName)
		{
			UiNavigationJoystickInput.RegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.ClickButtonInside));
		}

		// Token: 0x06030FE2 RID: 200674 RVA: 0x00B6094D File Offset: 0x00B5EB4D
		protected override void OnFinishInputAxis(string axisName)
		{
			UiNavigationJoystickInput.UnRegisterLeftJoystickFunction(new Action<ENavigationDirectionType>(this.ClickButtonInside));
		}

		// Token: 0x06030FE3 RID: 200675 RVA: 0x00B60960 File Offset: 0x00B5EB60
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

		// Token: 0x06030FE4 RID: 200676 RVA: 0x00B609C8 File Offset: 0x00B5EBC8
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

		// Token: 0x06030FE5 RID: 200677 RVA: 0x00B60A30 File Offset: 0x00B5EC30
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
