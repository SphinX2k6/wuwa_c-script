using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C6 RID: 14534
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnInScrollReleaseComponent : HotKeyComponent
	{
		// Token: 0x06025B0A RID: 154378 RVA: 0x00A9B702 File Offset: 0x00A99902
		public ClickBtnInScrollReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B0B RID: 154379 RVA: 0x00A9B70B File Offset: 0x00A9990B
		protected override void OnRelease(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06025B0C RID: 154380 RVA: 0x00A9B71A File Offset: 0x00A9991A
		private void ClickButton(string tag)
		{
			if (tag == "tag1")
			{
				UiNavigationNewController.Instance.HotKeyCloseView();
				return;
			}
			UiNavigationNewController.Instance.ClickButton(tag);
			UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		}

		// Token: 0x06025B0D RID: 154381 RVA: 0x00A9B74C File Offset: 0x00A9994C
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			if (activeListenerByTag == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!activeListenerByTag.IsInNormalScrollDisplayByGridActor())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag.IsListenerActive(), false);
		}
	}
}
