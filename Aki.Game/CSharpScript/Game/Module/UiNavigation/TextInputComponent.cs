using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003962 RID: 14690
	public class TextInputComponent : HotKeyComponent
	{
		// Token: 0x06025D73 RID: 154995 RVA: 0x00AA0825 File Offset: 0x00A9EA25
		public TextInputComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D74 RID: 154996 RVA: 0x00AA082E File Offset: 0x00A9EA2E
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ActiveTextInput(config.BindButtonTag);
		}

		// Token: 0x06025D75 RID: 154997 RVA: 0x00AA0844 File Offset: 0x00A9EA44
		[NullableContext(1)]
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
