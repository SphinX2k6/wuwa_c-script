using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049B2 RID: 18866
	public class PhotoStickerItemScaleIncreaseComponent : PhotoStickerItemScaleComponent
	{
		// Token: 0x06031198 RID: 201112 RVA: 0x00B6478E File Offset: 0x00B6298E
		public PhotoStickerItemScaleIncreaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031199 RID: 201113 RVA: 0x00B64797 File Offset: 0x00B62997
		protected override void OnRelease(HotKeyMap config)
		{
			base.ChangeScale(1f);
		}

		// Token: 0x0603119A RID: 201114 RVA: 0x00B647A4 File Offset: 0x00B629A4
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
