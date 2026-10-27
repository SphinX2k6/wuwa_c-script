using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E9 RID: 18921
	public class TextInputInsideComponent : HotKeyComponent
	{
		// Token: 0x06031240 RID: 201280 RVA: 0x00B6592D File Offset: 0x00B63B2D
		public TextInputInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031241 RID: 201281 RVA: 0x00B65936 File Offset: 0x00B63B36
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ActiveTextInputInside(config.BindButtonTag);
		}

		// Token: 0x06031242 RID: 201282 RVA: 0x00B6594C File Offset: 0x00B63B4C
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
			TsUiNavigationBehaviorListener focusListenerInsideListenerByTag = UiNavigationNewController.Instance.GetFocusListenerInsideListenerByTag(focusListener, bindButtonTag);
			if (focusListenerInsideListenerByTag == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, focusListenerInsideListenerByTag != null && focusListenerInsideListenerByTag.IsListenerActive(), false);
		}
	}
}
