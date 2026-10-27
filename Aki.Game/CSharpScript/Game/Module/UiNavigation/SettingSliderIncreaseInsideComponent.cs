using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E0 RID: 18912
	public class SettingSliderIncreaseInsideComponent : SliderIncreaseInsideComponent
	{
		// Token: 0x06031227 RID: 201255 RVA: 0x00B656C5 File Offset: 0x00B638C5
		public SettingSliderIncreaseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031228 RID: 201256 RVA: 0x00B656CE File Offset: 0x00B638CE
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
