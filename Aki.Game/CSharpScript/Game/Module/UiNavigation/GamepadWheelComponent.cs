using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200496B RID: 18795
	public class GamepadWheelComponent : GamepadInteractComponentBase
	{
		// Token: 0x06031053 RID: 200787 RVA: 0x00B61716 File Offset: 0x00B5F916
		public GamepadWheelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031054 RID: 200788 RVA: 0x00B61720 File Offset: 0x00B5F920
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

		// Token: 0x0401A492 RID: 107666
		private const float WHEEL_SPEED_SCALE = 0.4f;

		// Token: 0x0401A493 RID: 107667
		private float CacheValue;
	}
}
