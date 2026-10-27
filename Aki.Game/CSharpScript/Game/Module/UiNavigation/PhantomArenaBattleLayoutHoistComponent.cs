using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049AA RID: 18858
	public class PhantomArenaBattleLayoutHoistComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x0603117F RID: 201087 RVA: 0x00B6457E File Offset: 0x00B6277E
		public PhantomArenaBattleLayoutHoistComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031180 RID: 201088 RVA: 0x00B64587 File Offset: 0x00B62787
		protected override void OnPress(HotKeyMap _)
		{
			if (base.Proxy != null)
			{
				base.Proxy.GamepadLogic.SwitchCardLayoutHoist();
				UiNavigationModel.Instance.RepeatMove();
			}
		}

		// Token: 0x06031181 RID: 201089 RVA: 0x00B645AB File Offset: 0x00B627AB
		protected override void OnRefreshSelfHotKeyStateIsMainInVisible()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
