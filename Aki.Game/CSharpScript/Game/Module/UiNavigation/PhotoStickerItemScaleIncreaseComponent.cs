using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200392C RID: 14636
	public class PhotoStickerItemScaleIncreaseComponent : PhotoStickerItemScaleComponent
	{
		// Token: 0x06025CCE RID: 154830 RVA: 0x00A9F6DE File Offset: 0x00A9D8DE
		public PhotoStickerItemScaleIncreaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CCF RID: 154831 RVA: 0x00A9F6E7 File Offset: 0x00A9D8E7
		protected override void OnRelease(HotKeyMap config)
		{
			base.ChangeScale(1f);
		}

		// Token: 0x06025CD0 RID: 154832 RVA: 0x00A9F6F4 File Offset: 0x00A9D8F4
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value >= -0.4f)
			{
				return;
			}
			base.ChangeScale(-value);
		}
	}
}
