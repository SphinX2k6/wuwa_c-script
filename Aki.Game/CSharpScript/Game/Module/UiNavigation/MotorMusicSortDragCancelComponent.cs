using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003910 RID: 14608
	public class MotorMusicSortDragCancelComponent : HotKeyComponent
	{
		// Token: 0x06025C66 RID: 154726 RVA: 0x00A9E86E File Offset: 0x00A9CA6E
		public MotorMusicSortDragCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C67 RID: 154727 RVA: 0x00A9E877 File Offset: 0x00A9CA77
		protected override void OnPress(HotKeyMap config)
		{
			if (UiNavigationNewController.Instance.IsNavigationMousePositionDragging())
			{
				EventSystem.Instance.Emit(EEventName.OnMotorMusicSortDragCancel);
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
			}
		}

		// Token: 0x06025C68 RID: 154728 RVA: 0x00A9E8AB File Offset: 0x00A9CAAB
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
