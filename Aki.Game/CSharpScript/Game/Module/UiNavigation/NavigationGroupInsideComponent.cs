using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A3 RID: 18851
	public class NavigationGroupInsideComponent : HotKeyComponent
	{
		// Token: 0x0603115D RID: 201053 RVA: 0x00B63DF9 File Offset: 0x00B61FF9
		public NavigationGroupInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603115E RID: 201054 RVA: 0x00B63E02 File Offset: 0x00B62002
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.JumpInsideNavigationGroup();
		}

		// Token: 0x0603115F RID: 201055 RVA: 0x00B63E10 File Offset: 0x00B62010
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
