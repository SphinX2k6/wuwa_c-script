using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004372 RID: 17266
	[NullableContext(1)]
	[Nullable(0)]
	public class MovieModeUtil
	{
		// Token: 0x0602B9A8 RID: 178600 RVA: 0x00C3DFC0 File Offset: 0x00C3C1C0
		public static void ApplyAspectOffsetToUi(IUiItemAspectOffsetConfig config, bool isApply, [Nullable(2)] IMovieModeAspectOffset aspectOffset)
		{
			if (aspectOffset == null || !isApply)
			{
				config.UiItem.SetAnchorOffsetX((float)config.OriginalOffset.X);
				config.UiItem.SetAnchorOffsetY((float)config.OriginalOffset.Y);
				return;
			}
			float offset = aspectOffset.Offset;
			bool isWidthBlend = aspectOffset.IsWidthBlend;
			float num = MovieModeUtil.CalculateOffset(config.OriginalOffset, isWidthBlend, offset, config.OffsetWidthDirection, config.OffsetHeightDirection);
			if (isWidthBlend)
			{
				config.UiItem.SetAnchorOffsetX(num);
				return;
			}
			config.UiItem.SetAnchorOffsetY(num);
		}

		// Token: 0x0602B9A9 RID: 178601 RVA: 0x00C3E048 File Offset: 0x00C3C248
		private static float CalculateOffset(Vector2D baseOffset, bool isWidthBlend, float offset, float offsetWidthDirection, float offsetHeightDirection)
		{
			float num = isWidthBlend ? ((float)baseOffset.X) : ((float)baseOffset.Y);
			float num2 = isWidthBlend ? (offsetWidthDirection * offset) : (offsetHeightDirection * offset);
			return num + num2;
		}
	}
}
