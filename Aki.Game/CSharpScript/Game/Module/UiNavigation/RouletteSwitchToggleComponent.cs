using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200393B RID: 14651
	public class RouletteSwitchToggleComponent : HotKeyComponent
	{
		// Token: 0x06025D02 RID: 154882 RVA: 0x00A9FD10 File Offset: 0x00A9DF10
		public RouletteSwitchToggleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D03 RID: 154883 RVA: 0x00A9FD19 File Offset: 0x00A9DF19
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025D04 RID: 154884 RVA: 0x00A9FD24 File Offset: 0x00A9DF24
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.RouletteSwitchToggleComponentEmit);
		}
	}
}
