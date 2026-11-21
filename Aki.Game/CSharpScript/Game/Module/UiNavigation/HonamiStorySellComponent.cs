using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F1 RID: 14577
	public class HonamiStorySellComponent : HonamiStoryComponentBase
	{
		// Token: 0x06025BAA RID: 154538 RVA: 0x00A9CBF2 File Offset: 0x00A9ADF2
		public HonamiStorySellComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BAB RID: 154539 RVA: 0x00A9CBFB File Offset: 0x00A9ADFB
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.SellSingleOne();
		}

		// Token: 0x06025BAC RID: 154540 RVA: 0x00A9CC14 File Offset: 0x00A9AE14
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (!viewHandle.HasGamepadControlMouse())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (viewHandle.IsNavigationMousePositionDragging())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (base.Logic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, !base.Logic.IsInGame(), false);
		}
	}
}
