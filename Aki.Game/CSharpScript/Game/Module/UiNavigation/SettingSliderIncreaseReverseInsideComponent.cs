using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200395C RID: 14684
	public class SettingSliderIncreaseReverseInsideComponent : SliderIncreaseInsideComponent
	{
		// Token: 0x06025D61 RID: 154977 RVA: 0x00AA0657 File Offset: 0x00A9E857
		public SettingSliderIncreaseReverseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D62 RID: 154978 RVA: 0x00AA0660 File Offset: 0x00A9E860
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.073f)
			{
				return;
			}
			this.SetValue(-value * 0.01f);
		}
	}
}
