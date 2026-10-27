using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200498C RID: 18828
	public class MapCheckComponent : MapInteractComponentBase
	{
		// Token: 0x06031110 RID: 200976 RVA: 0x00B634E9 File Offset: 0x00B616E9
		public MapCheckComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031111 RID: 200977 RVA: 0x00B634F2 File Offset: 0x00B616F2
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButton(config.BindButtonTag);
		}
	}
}
