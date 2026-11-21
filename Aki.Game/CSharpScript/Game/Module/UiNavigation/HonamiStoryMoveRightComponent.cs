using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038ED RID: 14573
	public class HonamiStoryMoveRightComponent : HonamiStoryComponentBase
	{
		// Token: 0x06025B9E RID: 154526 RVA: 0x00A9C9F0 File Offset: 0x00A9ABF0
		public HonamiStoryMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B9F RID: 154527 RVA: 0x00A9C9F9 File Offset: 0x00A9ABF9
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.JumpToNextPanelNew();
		}

		// Token: 0x06025BA0 RID: 154528 RVA: 0x00A9CA0F File Offset: 0x00A9AC0F
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
