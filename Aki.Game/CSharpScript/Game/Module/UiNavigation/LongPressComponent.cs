using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038FB RID: 14587
	public class LongPressComponent : HotKeyComponent
	{
		// Token: 0x06025C14 RID: 154644 RVA: 0x00A9DCB3 File Offset: 0x00A9BEB3
		public LongPressComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C15 RID: 154645 RVA: 0x00A9DCBC File Offset: 0x00A9BEBC
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointUp(config.BindButtonTag, config.Id, null);
		}

		// Token: 0x06025C16 RID: 154646 RVA: 0x00A9DCD7 File Offset: 0x00A9BED7
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointDown(config.BindButtonTag, config.Id, null);
		}
	}
}
