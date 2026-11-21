using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C5 RID: 14533
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnInScrollComponent : HotKeyComponent
	{
		// Token: 0x06025B06 RID: 154374 RVA: 0x00A9B669 File Offset: 0x00A99869
		public ClickBtnInScrollComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B07 RID: 154375 RVA: 0x00A9B672 File Offset: 0x00A99872
		protected override void OnPress(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06025B08 RID: 154376 RVA: 0x00A9B681 File Offset: 0x00A99881
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

		// Token: 0x06025B09 RID: 154377 RVA: 0x00A9B6B0 File Offset: 0x00A998B0
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
