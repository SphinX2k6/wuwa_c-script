using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E3 RID: 18915
	public class SettingSliderReduceReverseInsideComponent : SliderReduceInsideComponent
	{
		// Token: 0x0603122D RID: 201261 RVA: 0x00B65729 File Offset: 0x00B63929
		public SettingSliderReduceReverseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603122E RID: 201262 RVA: 0x00B65732 File Offset: 0x00B63932
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
