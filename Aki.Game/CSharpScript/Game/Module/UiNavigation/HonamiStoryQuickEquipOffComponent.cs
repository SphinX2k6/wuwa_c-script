using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038EF RID: 14575
	public class HonamiStoryQuickEquipOffComponent : HonamiStoryComponentBase
	{
		// Token: 0x06025BA4 RID: 154532 RVA: 0x00A9CA54 File Offset: 0x00A9AC54
		public HonamiStoryQuickEquipOffComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025BA5 RID: 154533 RVA: 0x00A9CA5D File Offset: 0x00A9AC5D
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
			base.Logic.QuickEquipOff();
		}

		// Token: 0x06025BA6 RID: 154534 RVA: 0x00A9CA98 File Offset: 0x00A9AC98
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
			if (curItem.GetBackpackType() != EHonamiStoryBackpackType.Player)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
