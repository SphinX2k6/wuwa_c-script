using System;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003470 RID: 13424
	public static class ColorUtils
	{
		// Token: 0x04012DC6 RID: 77254
		private const byte MAX_BYTE = 255;

		// Token: 0x04012DC7 RID: 77255
		public static readonly FLinearColor LinearYellow = new FLinearColor(1f, 1f, 0f, 0f);

		// Token: 0x04012DC8 RID: 77256
		public static readonly FLinearColor LinearGreen = new FLinearColor(0f, 1f, 0f, 0f);

		// Token: 0x04012DC9 RID: 77257
		public static readonly FLinearColor LinearRed = new FLinearColor(1f, 0f, 0f, 0f);

		// Token: 0x04012DCA RID: 77258
		public static readonly FLinearColor LinearBlue = new FLinearColor(0f, 0f, 1f, 0f);

		// Token: 0x04012DCB RID: 77259
		public static readonly FLinearColor LinearWhite = new FLinearColor(1f, 1f, 1f, 0f);

		// Token: 0x04012DCC RID: 77260
		public static readonly FLinearColor LinearWhiteOpaque = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x04012DCD RID: 77261
		public static readonly FLinearColor LinearCyan = new FLinearColor(0f, 1f, 1f, 0f);

		// Token: 0x04012DCE RID: 77262
		public static readonly FLinearColor LinearBlack = new FLinearColor(0f, 0f, 0f, 1f);

		// Token: 0x04012DCF RID: 77263
		public static readonly FLinearColor LinearClear = new FLinearColor(0f, 0f, 0f, 0f);

		// Token: 0x04012DD0 RID: 77264
		public static readonly FColor ColorWhile = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04012DD1 RID: 77265
		public static readonly FColor ColorBlack = new FColor(0, 0, 0, byte.MaxValue);

		// Token: 0x04012DD2 RID: 77266
		public static readonly FColor ColorYellow = new FColor(byte.MaxValue, byte.MaxValue, 0, 0);

		// Token: 0x04012DD3 RID: 77267
		public static readonly FColor ColorRed = new FColor(byte.MaxValue, 0, 0, 0);
	}
}
