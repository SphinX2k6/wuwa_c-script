using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038EE RID: 14574
	public class HonamiStoryPickUpDownComponent : HonamiStoryComponentBase
	{
		// Token: 0x06025BA1 RID: 154529 RVA: 0x00A9CA2C File Offset: 0x00A9AC2C
		public HonamiStoryPickUpDownComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BA2 RID: 154530 RVA: 0x00A9CA35 File Offset: 0x00A9AC35
		protected override void OnPress(HotKeyMap config)
		{
		}

		// Token: 0x06025BA3 RID: 154531 RVA: 0x00A9CA37 File Offset: 0x00A9AC37
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (base.Logic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
