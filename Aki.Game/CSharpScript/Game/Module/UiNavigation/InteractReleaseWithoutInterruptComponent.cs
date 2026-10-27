using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200497F RID: 18815
	public class InteractReleaseWithoutInterruptComponent : InteractReleaseComponent
	{
		// Token: 0x060310D3 RID: 200915 RVA: 0x00B62B80 File Offset: 0x00B60D80
		public InteractReleaseWithoutInterruptComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060310D4 RID: 200916 RVA: 0x00B62B89 File Offset: 0x00B60D89
		[NullableContext(1)]
		protected override void HandleLogicAfterRefresh(UiNavigationViewHandle viewHandle)
		{
		}
	}
}
