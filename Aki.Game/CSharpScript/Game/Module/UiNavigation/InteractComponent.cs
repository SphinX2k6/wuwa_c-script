using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F5 RID: 14581
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractComponent : HotKeyComponent
	{
		// Token: 0x06025BF7 RID: 154615 RVA: 0x00A9D8CF File Offset: 0x00A9BACF
		public InteractComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BF8 RID: 154616 RVA: 0x00A9D8D8 File Offset: 0x00A9BAD8
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.InteractClick();
		}

		// Token: 0x06025BF9 RID: 154617 RVA: 0x00A9D8E4 File Offset: 0x00A9BAE4
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListener != null, false);
		}

		// Token: 0x06025BFA RID: 154618 RVA: 0x00A9D904 File Offset: 0x00A9BB04
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

		// Token: 0x06025BFB RID: 154619 RVA: 0x00A9D940 File Offset: 0x00A9BB40
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
