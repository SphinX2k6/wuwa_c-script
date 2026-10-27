using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200497D RID: 18813
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractComponent : HotKeyComponent
	{
		// Token: 0x060310C7 RID: 200903 RVA: 0x00B629CF File Offset: 0x00B60BCF
		public InteractComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310C8 RID: 200904 RVA: 0x00B629D8 File Offset: 0x00B60BD8
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.InteractClick();
		}

		// Token: 0x060310C9 RID: 200905 RVA: 0x00B629E4 File Offset: 0x00B60BE4
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListener != null, false);
		}

		// Token: 0x060310CA RID: 200906 RVA: 0x00B62A04 File Offset: 0x00B60C04
		protected override void OnRefreshHotKeyText(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			TsUiNavigationTextChangeListener tsUiNavigationTextChangeListener = (focusListener != null) ? focusListener.GetTextChangeComponent() : null;
			if (tsUiNavigationTextChangeListener != null)
			{
				base.SetHotKeyDescTextForce(tsUiNavigationTextChangeListener.Text.GetText());
				return;
			}
			base.ResetHotKeyDescTextForce();
		}

		// Token: 0x060310CB RID: 200907 RVA: 0x00B62A40 File Offset: 0x00B60C40
		protected override void OnRefreshHotKeyTextId(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (focusListener == null)
			{
				return;
			}
			string tipsTextIdByState = focusListener.GetTipsTextIdByState();
			base.SetHotKeyTextId(tipsTextIdByState);
			base.RefreshHotKeyNameText();
		}
	}
}
