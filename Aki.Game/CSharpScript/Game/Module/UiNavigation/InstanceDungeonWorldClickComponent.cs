using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F4 RID: 14580
	public class InstanceDungeonWorldClickComponent : HotKeyComponent
	{
		// Token: 0x06025BF4 RID: 154612 RVA: 0x00A9D88B File Offset: 0x00A9BA8B
		public InstanceDungeonWorldClickComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BF5 RID: 154613 RVA: 0x00A9D894 File Offset: 0x00A9BA94
		protected override bool OnIsOccupancyFightInput()
		{
			return !UiManager.Instance.IsViewShow(EUiViewName.InteractionHintView);
		}

		// Token: 0x06025BF6 RID: 154614 RVA: 0x00A9D8AA File Offset: 0x00A9BAAA
		protected override void OnPress(HotKeyMap config)
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.InteractionHintView))
			{
				return;
			}
			UiNavigationNewController.Instance.ClickButton(config.BindButtonTag);
		}
	}
}
