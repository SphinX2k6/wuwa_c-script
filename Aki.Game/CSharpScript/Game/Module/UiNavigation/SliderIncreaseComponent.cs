using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049D5 RID: 18901
	public class SliderIncreaseComponent : SliderComponent
	{
		// Token: 0x0603120A RID: 201226 RVA: 0x00B6549C File Offset: 0x00B6369C
		public SliderIncreaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603120B RID: 201227 RVA: 0x00B654A5 File Offset: 0x00B636A5
		protected override void OnRelease(HotKeyMap config)
		{
			this.SetValue(0.05f);
		}

		// Token: 0x0603120C RID: 201228 RVA: 0x00B654B2 File Offset: 0x00B636B2
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
