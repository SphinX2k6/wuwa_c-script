using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003951 RID: 14673
	public class SliderIncreaseReverseComponent : SliderComponent
	{
		// Token: 0x06025D46 RID: 154950 RVA: 0x00AA0448 File Offset: 0x00A9E648
		public SliderIncreaseReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D47 RID: 154951 RVA: 0x00AA0451 File Offset: 0x00A9E651
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(0.05f);
		}

		// Token: 0x06025D48 RID: 154952 RVA: 0x00AA045E File Offset: 0x00A9E65E
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.4f)
			{
				return;
			}
			this.SetValue(-value * 0.05f);
		}
	}
}
