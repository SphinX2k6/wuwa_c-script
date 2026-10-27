using System;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004548 RID: 17736
	public static class ColorUtils
	{
		// Token: 0x0401878C RID: 100236
		private const byte MAX_BYTE = 255;

		// Token: 0x0401878D RID: 100237
		public static readonly FLinearColor LinearYellow = new FLinearColor(1f, 1f, 0f, 0f);

		// Token: 0x0401878E RID: 100238
		public static readonly FLinearColor LinearGreen = new FLinearColor(0f, 1f, 0f, 0f);

		// Token: 0x0401878F RID: 100239
		public static readonly FLinearColor LinearRed = new FLinearColor(1f, 0f, 0f, 0f);

		// Token: 0x04018790 RID: 100240
		public static readonly FLinearColor LinearBlue = new FLinearColor(0f, 0f, 1f, 0f);

		// Token: 0x04018791 RID: 100241
		public static readonly FLinearColor LinearWhite = new FLinearColor(1f, 1f, 1f, 0f);

		// Token: 0x04018792 RID: 100242
		public static readonly FLinearColor LinearWhiteOpaque = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x04018793 RID: 100243
		public static readonly FLinearColor LinearCyan = new FLinearColor(0f, 1f, 1f, 0f);

		// Token: 0x04018794 RID: 100244
		public static readonly FLinearColor LinearBlack = new FLinearColor(0f, 0f, 0f, 1f);

		// Token: 0x04018795 RID: 100245
		public static readonly FLinearColor LinearClear = new FLinearColor(0f, 0f, 0f, 0f);

		// Token: 0x04018796 RID: 100246
		public static readonly FColor ColorWhile = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04018797 RID: 100247
		public static readonly FColor ColorBlack = new FColor(0, 0, 0, byte.MaxValue);

		// Token: 0x04018798 RID: 100248
		public static readonly FColor ColorYellow = new FColor(byte.MaxValue, byte.MaxValue, 0, 0);

		// Token: 0x04018799 RID: 100249
		public static readonly FColor ColorRed = new FColor(byte.MaxValue, 0, 0, 0);
	}
}
