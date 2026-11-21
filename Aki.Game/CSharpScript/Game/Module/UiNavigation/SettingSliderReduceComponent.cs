using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003954 RID: 14676
	public class SettingSliderReduceComponent : SliderReduceComponent
	{
		// Token: 0x06025D4E RID: 154958 RVA: 0x00AA04C7 File Offset: 0x00A9E6C7
		public SettingSliderReduceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D4F RID: 154959 RVA: 0x00AA04D0 File Offset: 0x00A9E6D0
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.073f)
			{
				return;
			}
			this.SetValue(value * 0.01f);
		}

		// Token: 0x04014D41 RID: 85313
		private const float SETTING_DEAD_AREA = 0.073f;

		// Token: 0x04014D42 RID: 85314
		private const float SETTING_INTERVAL = 0.01f;
	}
}
