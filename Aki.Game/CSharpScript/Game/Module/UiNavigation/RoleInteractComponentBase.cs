using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049BB RID: 18875
	public class RoleInteractComponentBase : HotKeyComponent
	{
		// Token: 0x060311BE RID: 201150 RVA: 0x00B64C79 File Offset: 0x00B62E79
		public RoleInteractComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311BF RID: 201151 RVA: 0x00B64C82 File Offset: 0x00B62E82
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}
	}
}
