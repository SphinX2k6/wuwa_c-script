using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038C1 RID: 14529
	public class BackComponent : HotKeyComponent
	{
		// Token: 0x06025AF9 RID: 154361 RVA: 0x00A9B4C6 File Offset: 0x00A996C6
		public BackComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025AFA RID: 154362 RVA: 0x00A9B4CF File Offset: 0x00A996CF
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HotKeyCloseView();
		}
	}
}
