using System;

namespace System.Text
{
	// Token: 0x0200021F RID: 543
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x000826ED File Offset: 0x000808ED
		public override bool Fallback(char charUnknown, int index)
		{
			throw new EncoderFallbackException(SR.Format(SR.Argument_InvalidCodePageConversionIndex, (int)charUnknown, index), charUnknown, index);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0008270C File Offset: 0x0008090C
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
			int num = char.ConvertToUtf32(charUnknownHigh, charUnknownLow);
			throw new EncoderFallbackException(SR.Format(SR.Argument_InvalidCodePageConversionIndex, num, index), charUnknownHigh, charUnknownLow, index);
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00007B65 File Offset: 0x00005D65
		public override char GetNextChar()
		{
			return '\0';
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool MovePrevious()
		{
			return false;
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int Remaining
		{
			get
			{
				return 0;
			}
		}
	}
}
