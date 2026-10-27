using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.HonamiStory;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004970 RID: 18800
	public class HonamiStoryCollectComponent : HonamiStoryComponentBase
	{
		// Token: 0x06031060 RID: 200800 RVA: 0x00B61902 File Offset: 0x00B5FB02
		public HonamiStoryCollectComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031061 RID: 200801 RVA: 0x00B6190B File Offset: 0x00B5FB0B
		protected override void OnPress(HotKeyMap config)
		{
			if (base.Logic == null)
			{
				return;
			}
			base.Logic.Collect();
		}

		// Token: 0x06031062 RID: 200802 RVA: 0x00B61924 File Offset: 0x00B5FB24
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
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
			if (curItem.GetBackpackType() != EHonamiStoryBackpackType.PickUpBox)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
