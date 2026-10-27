using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200494D RID: 18765
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnComponent : HotKeyComponent
	{
		// Token: 0x06030FD6 RID: 200662 RVA: 0x00B607AC File Offset: 0x00B5E9AC
		public ClickBtnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FD7 RID: 200663 RVA: 0x00B607B5 File Offset: 0x00B5E9B5
		protected override void OnPress(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06030FD8 RID: 200664 RVA: 0x00B607C4 File Offset: 0x00B5E9C4
		private void ClickButton(string tag)
		{
			if (tag == "tag1")
			{
				UiNavigationNewController.Instance.HotKeyCloseView();
				return;
			}
			UiNavigationNewController.Instance.ClickButton(tag);
		}

		// Token: 0x06030FD9 RID: 200665 RVA: 0x00B607EC File Offset: 0x00B5E9EC
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
			TsUiNavigationBehaviorListener activeListenerByTag = viewHandle.GetActiveListenerByTag(bindButtonTag);
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, activeListenerByTag != null && activeListenerByTag.IsListenerActive(), false);
		}
	}
}
