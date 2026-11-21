using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200395A RID: 14682
	public class SettingSliderIncreaseInsideComponent : SliderIncreaseInsideComponent
	{
		// Token: 0x06025D5D RID: 154973 RVA: 0x00AA0615 File Offset: 0x00A9E815
		public SettingSliderIncreaseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D5E RID: 154974 RVA: 0x00AA061E File Offset: 0x00A9E81E
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.073f)
			{
				return;
			}
			this.SetValue(value * 0.01f);
		}
	}
}
