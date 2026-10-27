using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E8 RID: 18920
	public class TextInputComponent : HotKeyComponent
	{
		// Token: 0x0603123D RID: 201277 RVA: 0x00B658D5 File Offset: 0x00B63AD5
		public TextInputComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603123E RID: 201278 RVA: 0x00B658DE File Offset: 0x00B63ADE
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ActiveTextInput(config.BindButtonTag);
		}

		// Token: 0x0603123F RID: 201279 RVA: 0x00B658F4 File Offset: 0x00B63AF4
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
