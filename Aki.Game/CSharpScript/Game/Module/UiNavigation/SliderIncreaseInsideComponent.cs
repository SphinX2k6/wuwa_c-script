using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003958 RID: 14680
	public class SliderIncreaseInsideComponent : SliderInsideComponent
	{
		// Token: 0x06025D57 RID: 154967 RVA: 0x00AA05B9 File Offset: 0x00A9E7B9
		public SliderIncreaseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D58 RID: 154968 RVA: 0x00AA05C2 File Offset: 0x00A9E7C2
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(0.05f);
		}

		// Token: 0x06025D59 RID: 154969 RVA: 0x00AA05CF File Offset: 0x00A9E7CF
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.4f)
			{
				return;
			}
			this.SetValue(value * 0.05f);
		}
	}
}
