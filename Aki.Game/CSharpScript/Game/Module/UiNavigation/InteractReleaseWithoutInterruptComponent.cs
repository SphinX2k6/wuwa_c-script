using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038F7 RID: 14583
	public class InteractReleaseWithoutInterruptComponent : InteractReleaseComponent
	{
		// Token: 0x06025C03 RID: 154627 RVA: 0x00A9DA80 File Offset: 0x00A9BC80
		public InteractReleaseWithoutInterruptComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C04 RID: 154628 RVA: 0x00A9DA89 File Offset: 0x00A9BC89
		[NullableContext(1)]
		protected override void HandleLogicAfterRefresh(UiNavigationViewHandle viewHandle)
		{
		}
	}
}
