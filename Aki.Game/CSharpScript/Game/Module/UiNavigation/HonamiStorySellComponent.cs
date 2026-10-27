using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004979 RID: 18809
	public class HonamiStorySellComponent : HonamiStoryComponentBase
	{
		// Token: 0x0603107A RID: 200826 RVA: 0x00B61D12 File Offset: 0x00B5FF12
		public HonamiStorySellComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603107B RID: 200827 RVA: 0x00B61D1B File Offset: 0x00B5FF1B
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.SellSingleOne();
		}

		// Token: 0x0603107C RID: 200828 RVA: 0x00B61D34 File Offset: 0x00B5FF34
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
