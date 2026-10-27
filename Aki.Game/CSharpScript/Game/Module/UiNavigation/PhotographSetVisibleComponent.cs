using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049AF RID: 18863
	public class PhotographSetVisibleComponent : HotKeyComponent
	{
		// Token: 0x0603118F RID: 201103 RVA: 0x00B64727 File Offset: 0x00B62927
		public PhotographSetVisibleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031190 RID: 201104 RVA: 0x00B64730 File Offset: 0x00B62930
		protected override void OnPress(HotKeyMap config)
		{
			EventSystem.Instance.Emit(EEventName.OnPhotographSetVisible);
		}

		// Token: 0x06031191 RID: 201105 RVA: 0x00B64742 File Offset: 0x00B62942
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
