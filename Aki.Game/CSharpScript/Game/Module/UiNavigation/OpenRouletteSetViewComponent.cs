using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200391E RID: 14622
	public class OpenRouletteSetViewComponent : HotKeyComponent
	{
		// Token: 0x06025C96 RID: 154774 RVA: 0x00A9EDB9 File Offset: 0x00A9CFB9
		public OpenRouletteSetViewComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C97 RID: 154775 RVA: 0x00A9EDC2 File Offset: 0x00A9CFC2
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025C98 RID: 154776 RVA: 0x00A9EDCD File Offset: 0x00A9CFCD
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OpenRouletteSetView);
		}
	}
}
