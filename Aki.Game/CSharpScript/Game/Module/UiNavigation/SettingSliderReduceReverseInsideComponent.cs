using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200395D RID: 14685
	public class SettingSliderReduceReverseInsideComponent : SliderReduceInsideComponent
	{
		// Token: 0x06025D63 RID: 154979 RVA: 0x00AA0679 File Offset: 0x00A9E879
		public SettingSliderReduceReverseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D64 RID: 154980 RVA: 0x00AA0682 File Offset: 0x00A9E882
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.073f)
			{
				return;
			}
			this.SetValue(-value * 0.01f);
		}
	}
}
