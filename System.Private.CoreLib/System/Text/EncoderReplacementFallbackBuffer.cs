using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000227 RID: 551
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06002A0C RID: 10764 RVA: 0x00083463 File Offset: 0x00081663
		[NullableContext(1)]
		public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
		{
			this._strDefault = fallback.DefaultString + fallback.DefaultString;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00083490 File Offset: 0x00081690
		public override bool Fallback(char charUnknown, int index)
		{
			if (this._fallbackCount >= 1)
			{
				if (char.IsHighSurrogate(charUnknown) && this._fallbackCount >= 0 && char.IsLowSurrogate(this._strDefault[this._fallbackIndex + 1]))
				{
					EncoderFallbackBuffer.ThrowLastCharRecursive(char.ConvertToUtf32(charUnknown, this._strDefault[this._fallbackIndex + 1]));
				}
				EncoderFallbackBuffer.ThrowLastCharRecursive((int)charUnknown);
			}
			this._fallbackCount = this._strDefault.Length / 2;
			this._fallbackIndex = -1;
			return this._fallbackCount != 0;
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00083518 File Offset: 0x00081718
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			if (!char.IsHighSurrogate(charUnknownHigh))
			{
				throw new ArgumentOutOfRangeException("charUnknownHigh", SR.Format(SR.ArgumentOutOfRange_Range, 55296, 56319));
			}
			if (!char.IsLowSurrogate(charUnknownLow))
			{
				throw new ArgumentOutOfRangeException("charUnknownLow", SR.Format(SR.ArgumentOutOfRange_Range, 56320, 57343));
			}
			if (this._fallbackCount >= 1)
			{
				EncoderFallbackBuffer.ThrowLastCharRecursive(char.ConvertToUtf32(charUnknownHigh, charUnknownLow));
			}
			this._fallbackCount = this._strDefault.Length;
			this._fallbackIndex = -1;
			return this._fallbackCount != 0;
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000835C0 File Offset: 0x000817C0
		public override char GetNextChar()
		{
			this._fallbackCount--;
			this._fallbackIndex++;
			if (this._fallbackCount < 0)
			{
				return '\0';
			}
			if (this._fallbackCount == 2147483647)
			{
				this._fallbackCount = -1;
				return '\0';
			}
			return this._strDefault[this._fallbackIndex];
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x0008361B File Offset: 0x0008181B
		public override bool MovePrevious()
		{
			if (this._fallbackCount >= -1 && this._fallbackIndex >= 0)
			{
				this._fallbackIndex--;
				this._fallbackCount++;
				return true;
			}
			return false;
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0008364E File Offset: 0x0008184E
		public override int Remaining
		{
			get
			{
				if (this._fallbackCount >= 0)
				{
					return this._fallbackCount;
				}
				return 0;
			}
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00083661 File Offset: 0x00081861
		public override void Reset()
		{
			this._fallbackCount = -1;
			this._fallbackIndex = 0;
			this.charStart = null;
			this.bFallingBack = false;
		}

		// Token: 0x04000765 RID: 1893
		private readonly string _strDefault;

		// Token: 0x04000766 RID: 1894
		private int _fallbackCount = -1;

		// Token: 0x04000767 RID: 1895
		private int _fallbackIndex = -1;
	}
}
