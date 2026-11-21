using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038DF RID: 14559
	public class GamepadMoveForwardComponent : GamepadInteractComponentBase
	{
		// Token: 0x06025B77 RID: 154487 RVA: 0x00A9C428 File Offset: 0x00A9A628
		public GamepadMoveForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B78 RID: 154488 RVA: 0x00A9C431 File Offset: 0x00A9A631
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			UiNavigationNewController.Instance.GamepadControlMouseMoveForward(value);
		}
	}
}
