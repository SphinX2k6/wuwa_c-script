using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D6 RID: 18902
	public class SliderReduceComponent : SliderComponent
	{
		// Token: 0x0603120D RID: 201229 RVA: 0x00B654CA File Offset: 0x00B636CA
		public SliderReduceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603120E RID: 201230 RVA: 0x00B654D3 File Offset: 0x00B636D3
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(-0.05f);
		}

		// Token: 0x0603120F RID: 201231 RVA: 0x00B654E0 File Offset: 0x00B636E0
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
