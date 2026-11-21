using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003906 RID: 14598
	public class MapCheckComponent : MapInteractComponentBase
	{
		// Token: 0x06025C46 RID: 154694 RVA: 0x00A9E439 File Offset: 0x00A9C639
		public MapCheckComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C47 RID: 154695 RVA: 0x00A9E442 File Offset: 0x00A9C642
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.ClickButton(config.BindButtonTag);
		}
	}
}
