using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E6 RID: 14566
	public class HonamiStoryCancelComponent : HonamiStoryComponentBase
	{
		// Token: 0x06025B8B RID: 154507 RVA: 0x00A9C73A File Offset: 0x00A9A93A
		public HonamiStoryCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B8C RID: 154508 RVA: 0x00A9C743 File Offset: 0x00A9A943
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

		// Token: 0x06025B8D RID: 154509 RVA: 0x00A9C77B File Offset: 0x00A9A97B
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
