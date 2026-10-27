using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200538F RID: 21391
	[NullableContext(1)]
	[Nullable(0)]
	public class MovieModeUtil
	{
		// Token: 0x06036A62 RID: 223842 RVA: 0x00CEF098 File Offset: 0x00CED298
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

		// Token: 0x06036A63 RID: 223843 RVA: 0x00CEF120 File Offset: 0x00CED320
		private static float CalculateOffset(Vector2D baseOffset, bool isWidthBlend, float offset, float offsetWidthDirection, float offsetHeightDirection)
		{
			float num = isWidthBlend ? ((float)baseOffset.X) : ((float)baseOffset.Y);
			float num2 = isWidthBlend ? (offsetWidthDirection * offset) : (offsetHeightDirection * offset);
			return num + num2;
		}
	}
}
