using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200494E RID: 18766
	[NullableContext(1)]
	[Nullable(0)]
	public class ClickBtnInScrollComponent : HotKeyComponent
	{
		// Token: 0x06030FDA RID: 200666 RVA: 0x00B60825 File Offset: 0x00B5EA25
		public ClickBtnInScrollComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FDB RID: 200667 RVA: 0x00B6082E File Offset: 0x00B5EA2E
		protected override void OnPress(HotKeyMap config)
		{
			this.ClickButton(config.BindButtonTag);
		}

		// Token: 0x06030FDC RID: 200668 RVA: 0x00B6083D File Offset: 0x00B5EA3D
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

		// Token: 0x06030FDD RID: 200669 RVA: 0x00B6086C File Offset: 0x00B5EA6C
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
