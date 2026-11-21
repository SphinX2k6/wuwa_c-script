using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003959 RID: 14681
	public class SliderReduceInsideComponent : SliderInsideComponent
	{
		// Token: 0x06025D5A RID: 154970 RVA: 0x00AA05E7 File Offset: 0x00A9E7E7
		public SliderReduceInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D5B RID: 154971 RVA: 0x00AA05F0 File Offset: 0x00A9E7F0
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(-0.05f);
		}

		// Token: 0x06025D5C RID: 154972 RVA: 0x00AA05FD File Offset: 0x00A9E7FD
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.4f)
			{
				return;
			}
			this.SetValue(value * 0.05f);
		}
	}
}
