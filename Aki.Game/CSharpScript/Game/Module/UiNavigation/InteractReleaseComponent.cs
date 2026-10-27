using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200497E RID: 18814
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractReleaseComponent : HotKeyComponent
	{
		// Token: 0x060310CC RID: 200908 RVA: 0x00B62A6C File Offset: 0x00B60C6C
		public InteractReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310CD RID: 200909 RVA: 0x00B62A75 File Offset: 0x00B60C75
		protected override void OnPress(HotKeyMap config)
		{
			this.PressListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			UiNavigationNewController.Instance.Interact(true, config.Id);
		}

		// Token: 0x060310CE RID: 200910 RVA: 0x00B62A9A File Offset: 0x00B60C9A
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.InteractRelease(config.Id, this.PressListener);
			this.PressListener = null;
		}

		// Token: 0x060310CF RID: 200911 RVA: 0x00B62ABC File Offset: 0x00B60CBC
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListener != null, false);
		}

		// Token: 0x060310D0 RID: 200912 RVA: 0x00B62ADC File Offset: 0x00B60CDC
		protected override void HandleLogicAfterRefresh(UiNavigationViewHandle viewHandle)
		{
			TsUiNavigationBehaviorListener focusListener = viewHandle.GetFocusListener();
			if (this.PressListener != null && this.PressListener != focusListener)
			{
				this.OnRelease(base.GetHotKeyConfig().GetValueOrDefault());
			}
		}

		// Token: 0x060310D1 RID: 200913 RVA: 0x00B62B18 File Offset: 0x00B60D18
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

		// Token: 0x060310D2 RID: 200914 RVA: 0x00B62B54 File Offset: 0x00B60D54
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

		// Token: 0x0401A4A0 RID: 107680
		[Nullable(2)]
		private TsUiNavigationBehaviorListener PressListener;
	}
}
