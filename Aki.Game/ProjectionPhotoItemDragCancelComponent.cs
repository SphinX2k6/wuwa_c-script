using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;

// Token: 0x0200039E RID: 926
public class ProjectionPhotoItemDragCancelComponent : HotKeyComponent
{
	// Token: 0x06003341 RID: 13121 RVA: 0x001265EA File Offset: 0x001247EA
	public ProjectionPhotoItemDragCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
	{
	}

	// Token: 0x06003342 RID: 13122 RVA: 0x001265F3 File Offset: 0x001247F3
	protected override void OnPress(HotKeyMap config)
	{
		if (UiNavigationNewController.Instance.IsNavigationMousePositionDragging())
		{
			EventSystem.Instance.Emit(EEventName.OnProjectionPhotoItemDragCancel);
			UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
			UiNavigationNewController.Instance.SimulationPointerTrigger(false);
		}
	}

	// Token: 0x06003343 RID: 13123 RVA: 0x00126627 File Offset: 0x00124827
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
