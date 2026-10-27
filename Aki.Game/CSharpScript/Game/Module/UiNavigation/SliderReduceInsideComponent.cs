using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049DF RID: 18911
	public class SliderReduceInsideComponent : SliderInsideComponent
	{
		// Token: 0x06031224 RID: 201252 RVA: 0x00B65697 File Offset: 0x00B63897
		public SliderReduceInsideComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031225 RID: 201253 RVA: 0x00B656A0 File Offset: 0x00B638A0
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(-0.05f);
		}

		// Token: 0x06031226 RID: 201254 RVA: 0x00B656AD File Offset: 0x00B638AD
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
