using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003953 RID: 14675
	public class SettingSliderIncreaseComponent : SliderIncreaseComponent
	{
		// Token: 0x06025D4C RID: 154956 RVA: 0x00AA04A6 File Offset: 0x00A9E6A6
		public SettingSliderIncreaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D4D RID: 154957 RVA: 0x00AA04AF File Offset: 0x00A9E6AF
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.073f)
			{
				return;
			}
			this.SetValue(value * 0.01f);
		}

		// Token: 0x04014D3F RID: 85311
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x04014D40 RID: 85312
		private const float SETTING_INTERVAL = 0.01f;
	}
}
