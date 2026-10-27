using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200497C RID: 18812
	public class InstanceDungeonWorldClickComponent : HotKeyComponent
	{
		// Token: 0x060310C4 RID: 200900 RVA: 0x00B6298B File Offset: 0x00B60B8B
		public InstanceDungeonWorldClickComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310C5 RID: 200901 RVA: 0x00B62994 File Offset: 0x00B60B94
		protected override bool OnIsOccupancyFightInput()
		{
			return !UiManager.Instance.IsViewShow(EUiViewName.InteractionHintView);
		}

		// Token: 0x060310C6 RID: 200902 RVA: 0x00B629AA File Offset: 0x00B60BAA
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
