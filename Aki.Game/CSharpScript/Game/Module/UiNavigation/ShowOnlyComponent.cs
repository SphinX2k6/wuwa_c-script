using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200394C RID: 14668
	public class ShowOnlyComponent : HotKeyComponent
	{
		// Token: 0x06025D38 RID: 154936 RVA: 0x00AA0377 File Offset: 0x00A9E577
		public ShowOnlyComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D39 RID: 154937 RVA: 0x00AA0380 File Offset: 0x00A9E580
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025D3A RID: 154938 RVA: 0x00AA038B File Offset: 0x00A9E58B
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}
	}
}
