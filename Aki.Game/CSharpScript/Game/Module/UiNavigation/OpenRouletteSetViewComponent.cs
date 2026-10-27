using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A4 RID: 18852
	public class OpenRouletteSetViewComponent : HotKeyComponent
	{
		// Token: 0x06031160 RID: 201056 RVA: 0x00B63E69 File Offset: 0x00B62069
		public OpenRouletteSetViewComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031161 RID: 201057 RVA: 0x00B63E72 File Offset: 0x00B62072
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06031162 RID: 201058 RVA: 0x00B63E7D File Offset: 0x00B6207D
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OpenRouletteSetView);
		}
	}
}
