using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004953 RID: 18771
	public class CommonConsumeNavigationInsideNext : HotKeyComponent
	{
		// Token: 0x06030FF1 RID: 200689 RVA: 0x00B60C12 File Offset: 0x00B5EE12
		public CommonConsumeNavigationInsideNext(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FF2 RID: 200690 RVA: 0x00B60C1B File Offset: 0x00B5EE1B
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HandleCommonConsumeNavigationInside();
		}

		// Token: 0x06030FF3 RID: 200691 RVA: 0x00B60C28 File Offset: 0x00B5EE28
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
