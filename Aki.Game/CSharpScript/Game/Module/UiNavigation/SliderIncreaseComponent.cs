using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200394F RID: 14671
	public class SliderIncreaseComponent : SliderComponent
	{
		// Token: 0x06025D40 RID: 154944 RVA: 0x00AA03EC File Offset: 0x00A9E5EC
		public SliderIncreaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D41 RID: 154945 RVA: 0x00AA03F5 File Offset: 0x00A9E5F5
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(0.05f);
		}

		// Token: 0x06025D42 RID: 154946 RVA: 0x00AA0402 File Offset: 0x00A9E602
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
