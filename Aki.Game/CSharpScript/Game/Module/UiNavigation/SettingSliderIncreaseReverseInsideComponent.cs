using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E2 RID: 18914
	public class SettingSliderIncreaseReverseInsideComponent : SliderIncreaseInsideComponent
	{
		// Token: 0x0603122B RID: 201259 RVA: 0x00B65707 File Offset: 0x00B63907
		public SettingSliderIncreaseReverseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603122C RID: 201260 RVA: 0x00B65710 File Offset: 0x00B63910
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
