using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E0 RID: 14560
	public class GamepadMoveRightComponent : GamepadInteractComponentBase
	{
		// Token: 0x06025B79 RID: 154489 RVA: 0x00A9C43E File Offset: 0x00A9A63E
		public GamepadMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B7A RID: 154490 RVA: 0x00A9C447 File Offset: 0x00A9A647
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			UiNavigationNewController.Instance.GamepadControlMouseMoveRight(value);
		}
	}
}
