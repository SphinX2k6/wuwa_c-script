using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049FF RID: 18943
	public class DangobrawlOpenItemTipsComponent : HotKeyComponent
	{
		// Token: 0x060312C7 RID: 201415 RVA: 0x00B67D12 File Offset: 0x00B65F12
		public DangobrawlOpenItemTipsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312C8 RID: 201416 RVA: 0x00B67D1B File Offset: 0x00B65F1B
		protected override void OnRelease(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OnDangobrawlOpenItemTipsHotkeyNotify);
		}

		// Token: 0x060312C9 RID: 201417 RVA: 0x00B67D2D File Offset: 0x00B65F2D
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
