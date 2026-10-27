using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049DC RID: 18908
	public class SettingSliderReduceReverseComponent : SliderReduceComponent
	{
		// Token: 0x0603121C RID: 201244 RVA: 0x00B655BA File Offset: 0x00B637BA
		public SettingSliderReduceReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603121D RID: 201245 RVA: 0x00B655C3 File Offset: 0x00B637C3
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.073f)
			{
				return;
			}
			this.SetValue(-value * 0.01f);
		}

		// Token: 0x0401A4D3 RID: 107731
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x0401A4D4 RID: 107732
		private const float SETTING_INTERVAL = 0.01f;
	}
}
