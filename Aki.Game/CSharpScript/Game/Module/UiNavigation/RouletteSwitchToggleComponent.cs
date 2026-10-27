using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C1 RID: 18881
	public class RouletteSwitchToggleComponent : HotKeyComponent
	{
		// Token: 0x060311CC RID: 201164 RVA: 0x00B64DC0 File Offset: 0x00B62FC0
		public RouletteSwitchToggleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311CD RID: 201165 RVA: 0x00B64DC9 File Offset: 0x00B62FC9
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x060311CE RID: 201166 RVA: 0x00B64DD4 File Offset: 0x00B62FD4
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.RouletteSwitchToggleComponentEmit);
		}
	}
}
