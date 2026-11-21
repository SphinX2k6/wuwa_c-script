using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003935 RID: 14645
	public class RoleInteractComponentBase : HotKeyComponent
	{
		// Token: 0x06025CF4 RID: 154868 RVA: 0x00A9FBC9 File Offset: 0x00A9DDC9
		public RoleInteractComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CF5 RID: 154869 RVA: 0x00A9FBD2 File Offset: 0x00A9DDD2
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
