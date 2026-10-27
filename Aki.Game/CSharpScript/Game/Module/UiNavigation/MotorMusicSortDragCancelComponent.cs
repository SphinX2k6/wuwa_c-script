using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004996 RID: 18838
	public class MotorMusicSortDragCancelComponent : HotKeyComponent
	{
		// Token: 0x06031130 RID: 201008 RVA: 0x00B6391E File Offset: 0x00B61B1E
		public MotorMusicSortDragCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031131 RID: 201009 RVA: 0x00B63927 File Offset: 0x00B61B27
		protected override void OnPress(HotKeyMap config)
		{
			if (UiNavigationNewController.Instance.IsNavigationMousePositionDragging())
			{
				EventSystem.Instance.Emit(EEventName.OnMotorMusicSortDragCancel);
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
			}
		}

		// Token: 0x06031132 RID: 201010 RVA: 0x00B6395B File Offset: 0x00B61B5B
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
