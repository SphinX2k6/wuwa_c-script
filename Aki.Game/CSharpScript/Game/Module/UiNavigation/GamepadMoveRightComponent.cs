using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004968 RID: 18792
	public class GamepadMoveRightComponent : GamepadInteractComponentBase
	{
		// Token: 0x06031049 RID: 200777 RVA: 0x00B6155E File Offset: 0x00B5F75E
		public GamepadMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603104A RID: 200778 RVA: 0x00B61567 File Offset: 0x00B5F767
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			UiNavigationNewController.Instance.GamepadControlMouseMoveRight(value);
		}
	}
}
