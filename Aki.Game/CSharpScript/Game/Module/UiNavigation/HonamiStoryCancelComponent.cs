using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200496E RID: 18798
	public class HonamiStoryCancelComponent : HonamiStoryComponentBase
	{
		// Token: 0x0603105B RID: 200795 RVA: 0x00B6185A File Offset: 0x00B5FA5A
		public HonamiStoryCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603105C RID: 200796 RVA: 0x00B61863 File Offset: 0x00B5FA63
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			if (UiNavigationNewController.Instance.IsNavigationMousePositionDragging())
			{
				base.Logic.CancelOperationByGamepad();
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
			}
		}

		// Token: 0x0603105D RID: 200797 RVA: 0x00B6189B File Offset: 0x00B5FA9B
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (!viewHandle.HasGamepadControlMouse())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!viewHandle.IsNavigationMousePositionDragging())
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
