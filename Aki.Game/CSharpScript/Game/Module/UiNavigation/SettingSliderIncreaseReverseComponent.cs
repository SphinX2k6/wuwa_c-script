using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049DB RID: 18907
	public class SettingSliderIncreaseReverseComponent : SliderIncreaseComponent
	{
		// Token: 0x0603121A RID: 201242 RVA: 0x00B65598 File Offset: 0x00B63798
		public SettingSliderIncreaseReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603121B RID: 201243 RVA: 0x00B655A1 File Offset: 0x00B637A1
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.073f)
			{
				return;
			}
			this.SetValue(-value * 0.01f);
		}

		// Token: 0x0401A4D1 RID: 107729
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x0401A4D2 RID: 107730
		private const float SETTING_INTERVAL = 0.01f;
	}
}
