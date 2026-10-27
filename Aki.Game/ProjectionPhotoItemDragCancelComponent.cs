using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;

// Token: 0x02000EE9 RID: 3817
public class ProjectionPhotoItemDragCancelComponent : HotKeyComponent
{
	// Token: 0x06005FAB RID: 24491 RVA: 0x0011E792 File Offset: 0x0011C992
	public ProjectionPhotoItemDragCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
	{
	}

	// Token: 0x06005FAC RID: 24492 RVA: 0x0011E79B File Offset: 0x0011C99B
	protected override void OnPress(HotKeyMap config)
	{
		if (UiNavigationNewController.Instance.IsNavigationMousePositionDragging())
		{
			EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemDragCancel);
			UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
			UiNavigationNewController.Instance.SimulationPointerTrigger(false);
		}
	}

	// Token: 0x06005FAD RID: 24493 RVA: 0x0011E7CF File Offset: 0x0011C9CF
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
