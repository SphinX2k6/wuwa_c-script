using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003956 RID: 14678
	public class SettingSliderReduceReverseComponent : SliderReduceComponent
	{
		// Token: 0x06025D52 RID: 154962 RVA: 0x00AA050A File Offset: 0x00A9E70A
		public SettingSliderReduceReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D53 RID: 154963 RVA: 0x00AA0513 File Offset: 0x00A9E713
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.073f)
			{
				return;
			}
			this.SetValue(-value * 0.01f);
		}

		// Token: 0x04014D45 RID: 85317
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x04014D46 RID: 85318
		private const float SETTING_INTERVAL = 0.01f;
	}
}
