using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200395B RID: 14683
	public class SettingSliderReduceInsideComponent : SliderReduceInsideComponent
	{
		// Token: 0x06025D5F RID: 154975 RVA: 0x00AA0636 File Offset: 0x00A9E836
		public SettingSliderReduceInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D60 RID: 154976 RVA: 0x00AA063F File Offset: 0x00A9E83F
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
