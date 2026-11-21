using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003950 RID: 14672
	public class SliderReduceComponent : SliderComponent
	{
		// Token: 0x06025D43 RID: 154947 RVA: 0x00AA041A File Offset: 0x00A9E61A
		public SliderReduceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D44 RID: 154948 RVA: 0x00AA0423 File Offset: 0x00A9E623
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(-0.05f);
		}

		// Token: 0x06025D45 RID: 154949 RVA: 0x00AA0430 File Offset: 0x00A9E630
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
