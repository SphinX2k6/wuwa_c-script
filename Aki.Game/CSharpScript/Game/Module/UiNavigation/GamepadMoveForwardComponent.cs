using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004967 RID: 18791
	public class GamepadMoveForwardComponent : GamepadInteractComponentBase
	{
		// Token: 0x06031047 RID: 200775 RVA: 0x00B61548 File Offset: 0x00B5F748
		public GamepadMoveForwardComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031048 RID: 200776 RVA: 0x00B61551 File Offset: 0x00B5F751
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			UiNavigationNewController.Instance.GamepadControlMouseMoveForward(value);
		}
	}
}
