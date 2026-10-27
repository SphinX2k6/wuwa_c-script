using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D8 RID: 18904
	public class SliderReduceReverseComponent : SliderComponent
	{
		// Token: 0x06031213 RID: 201235 RVA: 0x00B65527 File Offset: 0x00B63727
		public SliderReduceReverseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031214 RID: 201236 RVA: 0x00B65530 File Offset: 0x00B63730
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(-0.05f);
		}

		// Token: 0x06031215 RID: 201237 RVA: 0x00B6553D File Offset: 0x00B6373D
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
