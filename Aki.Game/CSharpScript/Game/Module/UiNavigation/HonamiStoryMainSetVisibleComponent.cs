using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200496D RID: 18797
	public class HonamiStoryMainSetVisibleComponent : HotKeyComponent
	{
		// Token: 0x06031058 RID: 200792 RVA: 0x00B61834 File Offset: 0x00B5FA34
		public HonamiStoryMainSetVisibleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031059 RID: 200793 RVA: 0x00B6183D File Offset: 0x00B5FA3D
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OnPhotographSetVisible);
		}

		// Token: 0x0603105A RID: 200794 RVA: 0x00B6184F File Offset: 0x00B5FA4F
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
