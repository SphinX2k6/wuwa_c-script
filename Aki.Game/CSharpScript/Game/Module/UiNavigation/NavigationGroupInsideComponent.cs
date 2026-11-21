using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200391D RID: 14621
	public class NavigationGroupInsideComponent : HotKeyComponent
	{
		// Token: 0x06025C93 RID: 154771 RVA: 0x00A9ED49 File Offset: 0x00A9CF49
		public NavigationGroupInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C94 RID: 154772 RVA: 0x00A9ED52 File Offset: 0x00A9CF52
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.JumpInsideNavigationGroup();
		}

		// Token: 0x06025C95 RID: 154773 RVA: 0x00A9ED60 File Offset: 0x00A9CF60
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
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
			if (UiNavigationNewController.Instance.GetCanFocusInsideListener(focusListener) == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
