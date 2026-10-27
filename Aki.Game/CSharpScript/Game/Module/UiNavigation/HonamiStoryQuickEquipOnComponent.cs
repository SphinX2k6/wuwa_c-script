using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004978 RID: 18808
	public class HonamiStoryQuickEquipOnComponent : HonamiStoryComponentBase
	{
		// Token: 0x06031077 RID: 200823 RVA: 0x00B61C30 File Offset: 0x00B5FE30
		public HonamiStoryQuickEquipOnComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031078 RID: 200824 RVA: 0x00B61C39 File Offset: 0x00B5FE39
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			if (UiNavigationNewController.Instance.IsNavigationMousePositionDragging())
			{
				UiNavigationNewController.Instance.NotifyNavigationMousePositionDragState(false);
				UiNavigationNewController.Instance.SimulationPointerTrigger(false);
			}
			base.Logic.QuickEquipOn();
		}

		// Token: 0x06031079 RID: 200825 RVA: 0x00B61C74 File Offset: 0x00B5FE74
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (base.Logic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
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
			HonamiStoryItemGridItem curItem = base.Logic.GetCurItem();
			if (curItem == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			HonamiStoryItemDataBase data = curItem.GetData();
			if (data != null && data.GetItemType() == EHonamiStoryItemType.Normal)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			EHonamiStoryBackpackType backpackType = curItem.GetBackpackType();
			if (backpackType == EHonamiStoryBackpackType.Backpack || backpackType == EHonamiStoryBackpackType.Inventory)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
		}
	}
}
