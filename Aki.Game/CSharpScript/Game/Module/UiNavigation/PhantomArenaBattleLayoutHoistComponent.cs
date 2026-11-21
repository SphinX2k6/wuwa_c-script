using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003924 RID: 14628
	public class PhantomArenaBattleLayoutHoistComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x06025CB5 RID: 154805 RVA: 0x00A9F4CE File Offset: 0x00A9D6CE
		public PhantomArenaBattleLayoutHoistComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CB6 RID: 154806 RVA: 0x00A9F4D7 File Offset: 0x00A9D6D7
		protected override void OnPress(HotKeyMap _)
		{
			if (base.Proxy != null)
			{
				base.Proxy.GamepadLogic.SwitchCardLayoutHoist();
				UiNavigationModel.Instance.RepeatMove();
			}
		}

		// Token: 0x06025CB7 RID: 154807 RVA: 0x00A9F4FB File Offset: 0x00A9D6FB
		protected override void OnRefreshSelfHotKeyStateIsMainInVisible()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
