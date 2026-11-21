using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038EC RID: 14572
	public class HonamiStoryMoveLeftComponent : HonamiStoryComponentBase
	{
		// Token: 0x06025B9B RID: 154523 RVA: 0x00A9C9B4 File Offset: 0x00A9ABB4
		public HonamiStoryMoveLeftComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B9C RID: 154524 RVA: 0x00A9C9BD File Offset: 0x00A9ABBD
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.JumpToPrevPanelNew();
		}

		// Token: 0x06025B9D RID: 154525 RVA: 0x00A9C9D3 File Offset: 0x00A9ABD3
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
