using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038E3 RID: 14563
	public class GamepadWheelComponent : GamepadInteractComponentBase
	{
		// Token: 0x06025B83 RID: 154499 RVA: 0x00A9C5F6 File Offset: 0x00A9A7F6
		public GamepadWheelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B84 RID: 154500 RVA: 0x00A9C600 File Offset: 0x00A9A800
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			float num = -value * 0.4f;
			if (this.CacheValue == num && num == 0f)
			{
				return;
			}
			this.CacheValue = num;
			LguiEventSystemManager.Instance.InputWheelAxisByGamepad(num);
		}

		// Token: 0x04014D05 RID: 85253
		private const float WHEEL_SPEED_SCALE = 0.4f;

		// Token: 0x04014D06 RID: 85254
		private float CacheValue;
	}
}
