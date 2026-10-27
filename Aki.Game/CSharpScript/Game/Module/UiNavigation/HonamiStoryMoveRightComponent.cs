using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004975 RID: 18805
	public class HonamiStoryMoveRightComponent : HonamiStoryComponentBase
	{
		// Token: 0x0603106E RID: 200814 RVA: 0x00B61B10 File Offset: 0x00B5FD10
		public HonamiStoryMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603106F RID: 200815 RVA: 0x00B61B19 File Offset: 0x00B5FD19
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.JumpToNextPanelNew();
		}

		// Token: 0x06031070 RID: 200816 RVA: 0x00B61B2F File Offset: 0x00B5FD2F
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
