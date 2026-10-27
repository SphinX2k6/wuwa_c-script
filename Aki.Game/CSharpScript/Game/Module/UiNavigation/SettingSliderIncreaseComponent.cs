using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D9 RID: 18905
	public class SettingSliderIncreaseComponent : SliderIncreaseComponent
	{
		// Token: 0x06031216 RID: 201238 RVA: 0x00B65556 File Offset: 0x00B63756
		public SettingSliderIncreaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031217 RID: 201239 RVA: 0x00B6555F File Offset: 0x00B6375F
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.073f)
			{
				return;
			}
			this.SetValue(value * 0.01f);
		}

		// Token: 0x0401A4CD RID: 107725
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x0401A4CE RID: 107726
		private const float SETTING_INTERVAL = 0.01f;
	}
}
