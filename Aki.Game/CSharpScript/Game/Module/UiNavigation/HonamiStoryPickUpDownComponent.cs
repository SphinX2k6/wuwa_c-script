using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004976 RID: 18806
	public class HonamiStoryPickUpDownComponent : HonamiStoryComponentBase
	{
		// Token: 0x06031071 RID: 200817 RVA: 0x00B61B4C File Offset: 0x00B5FD4C
		public HonamiStoryPickUpDownComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031072 RID: 200818 RVA: 0x00B61B55 File Offset: 0x00B5FD55
		protected override void OnPress(HotKeyMap config)
		{
		}

		// Token: 0x06031073 RID: 200819 RVA: 0x00B61B57 File Offset: 0x00B5FD57
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (base.Logic == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
