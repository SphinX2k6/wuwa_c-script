using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049DE RID: 18910
	public class SliderIncreaseInsideComponent : SliderInsideComponent
	{
		// Token: 0x06031221 RID: 201249 RVA: 0x00B65669 File Offset: 0x00B63869
		public SliderIncreaseInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031222 RID: 201250 RVA: 0x00B65672 File Offset: 0x00B63872
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(0.05f);
		}

		// Token: 0x06031223 RID: 201251 RVA: 0x00B6567F File Offset: 0x00B6387F
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
