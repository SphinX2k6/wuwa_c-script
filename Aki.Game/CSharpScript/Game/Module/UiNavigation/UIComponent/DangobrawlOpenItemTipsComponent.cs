using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003979 RID: 14713
	public class DangobrawlOpenItemTipsComponent : HotKeyComponent
	{
		// Token: 0x06025DFD RID: 155133 RVA: 0x00AA2CCE File Offset: 0x00AA0ECE
		public DangobrawlOpenItemTipsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DFE RID: 155134 RVA: 0x00AA2CD7 File Offset: 0x00AA0ED7
		protected override void OnRelease(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OnDangobrawlOpenItemTipsHotkeyNotify);
		}

		// Token: 0x06025DFF RID: 155135 RVA: 0x00AA2CE9 File Offset: 0x00AA0EE9
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
