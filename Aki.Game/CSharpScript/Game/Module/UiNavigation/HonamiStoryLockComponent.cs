using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004973 RID: 18803
	public class HonamiStoryLockComponent : HonamiStoryComponentBase
	{
		// Token: 0x06031068 RID: 200808 RVA: 0x00B61A3B File Offset: 0x00B5FC3B
		public HonamiStoryLockComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031069 RID: 200809 RVA: 0x00B61A44 File Offset: 0x00B5FC44
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.SetLockStatus();
		}

		// Token: 0x0603106A RID: 200810 RVA: 0x00B61A5C File Offset: 0x00B5FC5C
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
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
			if (base.Logic == null)
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
			if (curItem.GetBackpackType() == EHonamiStoryBackpackType.PickUpBox)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
