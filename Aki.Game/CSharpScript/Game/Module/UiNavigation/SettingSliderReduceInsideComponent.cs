using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E1 RID: 18913
	public class SettingSliderReduceInsideComponent : SliderReduceInsideComponent
	{
		// Token: 0x06031229 RID: 201257 RVA: 0x00B656E6 File Offset: 0x00B638E6
		public SettingSliderReduceInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603122A RID: 201258 RVA: 0x00B656EF File Offset: 0x00B638EF
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.073f)
			{
				return;
			}
			this.SetValue(value * 0.01f);
		}
	}
}
