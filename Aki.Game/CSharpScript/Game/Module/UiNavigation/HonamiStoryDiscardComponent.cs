using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004972 RID: 18802
	public class HonamiStoryDiscardComponent : HonamiStoryComponentBase
	{
		// Token: 0x06031065 RID: 200805 RVA: 0x00B6198D File Offset: 0x00B5FB8D
		public HonamiStoryDiscardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031066 RID: 200806 RVA: 0x00B61996 File Offset: 0x00B5FB96
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.Discard();
		}

		// Token: 0x06031067 RID: 200807 RVA: 0x00B619AC File Offset: 0x00B5FBAC
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (base.Logic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!base.Logic.IsInGame())
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
			if (curItem.GetBackpackType() == EHonamiStoryBackpackType.PickUpBox)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
