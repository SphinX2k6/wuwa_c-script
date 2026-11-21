using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003929 RID: 14633
	public class PhotographSetVisibleComponent : HotKeyComponent
	{
		// Token: 0x06025CC5 RID: 154821 RVA: 0x00A9F677 File Offset: 0x00A9D877
		public PhotographSetVisibleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CC6 RID: 154822 RVA: 0x00A9F680 File Offset: 0x00A9D880
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OnPhotographSetVisible);
		}

		// Token: 0x06025CC7 RID: 154823 RVA: 0x00A9F692 File Offset: 0x00A9D892
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
