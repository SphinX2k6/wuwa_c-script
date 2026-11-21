using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003955 RID: 14677
	public class SettingSliderIncreaseReverseComponent : SliderIncreaseComponent
	{
		// Token: 0x06025D50 RID: 154960 RVA: 0x00AA04E8 File Offset: 0x00A9E6E8
		public SettingSliderIncreaseReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D51 RID: 154961 RVA: 0x00AA04F1 File Offset: 0x00A9E6F1
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.073f)
			{
				return;
			}
			this.SetValue(-value * 0.01f);
		}

		// Token: 0x04014D43 RID: 85315
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x04014D44 RID: 85316
		private const float SETTING_INTERVAL = 0.01f;
	}
}
