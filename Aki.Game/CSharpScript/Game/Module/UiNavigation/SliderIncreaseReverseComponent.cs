using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D7 RID: 18903
	public class SliderIncreaseReverseComponent : SliderComponent
	{
		// Token: 0x06031210 RID: 201232 RVA: 0x00B654F8 File Offset: 0x00B636F8
		public SliderIncreaseReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031211 RID: 201233 RVA: 0x00B65501 File Offset: 0x00B63701
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(0.05f);
		}

		// Token: 0x06031212 RID: 201234 RVA: 0x00B6550E File Offset: 0x00B6370E
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
