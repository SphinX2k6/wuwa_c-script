using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E5 RID: 14565
	public class HonamiStoryMainSetVisibleComponent : HotKeyComponent
	{
		// Token: 0x06025B88 RID: 154504 RVA: 0x00A9C714 File Offset: 0x00A9A914
		public HonamiStoryMainSetVisibleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B89 RID: 154505 RVA: 0x00A9C71D File Offset: 0x00A9A91D
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OnPhotographSetVisible);
		}

		// Token: 0x06025B8A RID: 154506 RVA: 0x00A9C72F File Offset: 0x00A9A92F
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
