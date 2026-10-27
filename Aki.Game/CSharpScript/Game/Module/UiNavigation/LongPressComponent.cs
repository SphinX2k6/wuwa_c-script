using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004982 RID: 18818
	public class LongPressComponent : HotKeyComponent
	{
		// Token: 0x060310E0 RID: 200928 RVA: 0x00B62DBF File Offset: 0x00B60FBF
		public LongPressComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310E1 RID: 200929 RVA: 0x00B62DC8 File Offset: 0x00B60FC8
		protected override void OnRelease(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointUp(config.BindButtonTag, config.Id, null);
		}

		// Token: 0x060310E2 RID: 200930 RVA: 0x00B62DE3 File Offset: 0x00B60FE3
		protected override void OnPress(HotKeyMap config)
		{
			UiNavigationNewController.Instance.SimulationPointDown(config.BindButtonTag, config.Id, null);
		}
	}
}
