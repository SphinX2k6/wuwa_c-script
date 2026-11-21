using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200392D RID: 14637
	public class PhotoStickerItemScaleReduceComponent : PhotoStickerItemScaleComponent
	{
		// Token: 0x06025CD1 RID: 154833 RVA: 0x00A9F707 File Offset: 0x00A9D907
		public PhotoStickerItemScaleReduceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CD2 RID: 154834 RVA: 0x00A9F710 File Offset: 0x00A9D910
		protected override void OnRelease(HotKeyMap config)
		{
			base.ChangeScale(-1f);
		}

		// Token: 0x06025CD3 RID: 154835 RVA: 0x00A9F71D File Offset: 0x00A9D91D
		[NullableContext(1)]
		protected override void OnInputAxis(string axisName, float value)
		{
			if (value <= 0.4f)
			{
				return;
			}
			base.ChangeScale(-value);
		}
	}
}
