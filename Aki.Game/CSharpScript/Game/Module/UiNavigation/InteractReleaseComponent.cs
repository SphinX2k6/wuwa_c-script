using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F6 RID: 14582
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractReleaseComponent : HotKeyComponent
	{
		// Token: 0x06025BFC RID: 154620 RVA: 0x00A9D96C File Offset: 0x00A9BB6C
		public InteractReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BFD RID: 154621 RVA: 0x00A9D975 File Offset: 0x00A9BB75
		protected override void OnPress(HotKeyMap config)
		{
			this.PressListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			UiNavigationNewController.Instance.Interact(true, config.Id);
		}

		// Token: 0x06025BFE RID: 154622 RVA: 0x00A9D99A File Offset: 0x00A9BB9A
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.InteractRelease(config.Id, this.PressListener);
			this.PressListener = null;
		}

		// Token: 0x06025BFF RID: 154623 RVA: 0x00A9D9BC File Offset: 0x00A9BBBC
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListener != null, false);
		}

		// Token: 0x06025C00 RID: 154624 RVA: 0x00A9D9DC File Offset: 0x00A9BBDC
		protected override void HandleLogicAfterRefresh(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (this.PressListener != null && this.PressListener != focusListener)
			{
				this.OnRelease(base.GetHotKeyConfig().GetValueOrDefault());
			}
		}

		// Token: 0x06025C01 RID: 154625 RVA: 0x00A9DA18 File Offset: 0x00A9BC18
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

		// Token: 0x06025C02 RID: 154626 RVA: 0x00A9DA54 File Offset: 0x00A9BC54
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

		// Token: 0x04014D13 RID: 85267
		[Nullable(2)]
		private TsUiNavigationBehaviorListener PressListener;
	}
}
