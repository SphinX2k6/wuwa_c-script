using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004950 RID: 18768
	public class ClickBtnInsideReleaseComponent : HotKeyComponent
	{
		// Token: 0x06030FE6 RID: 200678 RVA: 0x00B60AA5 File Offset: 0x00B5ECA5
		public ClickBtnInsideReleaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FE7 RID: 200679 RVA: 0x00B60AAE File Offset: 0x00B5ECAE
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButtonInside(config.BindButtonTag);
		}

		// Token: 0x06030FE8 RID: 200680 RVA: 0x00B60AC4 File Offset: 0x00B5ECC4
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				return;
			}
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
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (tsUiNavigationBehaviorListener == null)
			{
				tsUiNavigationBehaviorListener = focusListener.GetChildListenerByTag(bindButtonTag);
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, tsUiNavigationBehaviorListener != null && tsUiNavigationBehaviorListener.IsListenerActive(), false);
		}
	}
}
