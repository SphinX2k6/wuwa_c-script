using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049DA RID: 18906
	public class SettingSliderReduceComponent : SliderReduceComponent
	{
		// Token: 0x06031218 RID: 201240 RVA: 0x00B65577 File Offset: 0x00B63777
		public SettingSliderReduceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031219 RID: 201241 RVA: 0x00B65580 File Offset: 0x00B63780
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.073f)
			{
				return;
			}
			this.SetValue(value * 0.01f);
		}

		// Token: 0x0401A4CF RID: 107727
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x0401A4D0 RID: 107728
		private const float SETTING_INTERVAL = 0.01f;
	}
}
