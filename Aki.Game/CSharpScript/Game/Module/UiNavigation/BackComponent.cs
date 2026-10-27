using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200494A RID: 18762
	public class BackComponent : HotKeyComponent
	{
		// Token: 0x06030FCD RID: 200653 RVA: 0x00B60682 File Offset: 0x00B5E882
		public BackComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06030FCE RID: 200654 RVA: 0x00B6068B File Offset: 0x00B5E88B
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.HotKeyCloseView();
		}
	}
}
