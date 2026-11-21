using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003952 RID: 14674
	public class SliderReduceReverseComponent : SliderComponent
	{
		// Token: 0x06025D49 RID: 154953 RVA: 0x00AA0477 File Offset: 0x00A9E677
		public SliderReduceReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D4A RID: 154954 RVA: 0x00AA0480 File Offset: 0x00A9E680
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(-0.05f);
		}

		// Token: 0x06025D4B RID: 154955 RVA: 0x00AA048D File Offset: 0x00A9E68D
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.4f)
			{
				return;
			}
			this.SetValue(-value * 0.05f);
		}
	}
}
