using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B3 RID: 18867
	public class PhotoStickerItemScaleReduceComponent : PhotoStickerItemScaleComponent
	{
		// Token: 0x0603119B RID: 201115 RVA: 0x00B647B7 File Offset: 0x00B629B7
		public PhotoStickerItemScaleReduceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603119C RID: 201116 RVA: 0x00B647C0 File Offset: 0x00B629C0
		protected override void OnRelease(HotKeyMap config)
		{
			base.ChangeScale(-1f);
		}

		// Token: 0x0603119D RID: 201117 RVA: 0x00B647CD File Offset: 0x00B629CD
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
