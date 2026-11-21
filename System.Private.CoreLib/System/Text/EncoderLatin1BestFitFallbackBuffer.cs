using System;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000224 RID: 548
	internal sealed class EncoderLatin1BestFitFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060029EC RID: 10732 RVA: 0x00082C3C File Offset: 0x00080E3C
		public override bool Fallback(char charUnknown, int index)
		{
			this._iCount = (this._iSize = 1);
			this._cBestFit = EncoderLatin1BestFitFallbackBuffer.TryBestFit(charUnknown);
			if (this._cBestFit == '\0')
			{
				this._cBestFit = '?';
			}
			return true;
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00082C78 File Offset: 0x00080E78
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
			this._cBestFit = '?';
			this._iCount = (this._iSize = 2);
			return true;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00082D00 File Offset: 0x00080F00
		public override char GetNextChar()
		{
			this._iCount--;
			if (this._iCount < 0)
			{
				return '\0';
			}
			if (this._iCount == 2147483647)
			{
				this._iCount = -1;
				return '\0';
			}
			return this._cBestFit;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00082D37 File Offset: 0x00080F37
		public override bool MovePrevious()
		{
			if (this._iCount >= 0)
			{
				this._iCount++;
			}
			return this._iCount >= 0 && this._iCount <= this._iSize;
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x00082D6C File Offset: 0x00080F6C
		public override int Remaining
		{
			get
			{
				if (this._iCount <= 0)
				{
					return 0;
				}
				return this._iCount;
			}
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00082D7F File Offset: 0x00080F7F
		public override void Reset()
		{
			this._iCount = -1;
			this.charStart = null;
			this.bFallingBack = false;
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00082D98 File Offset: 0x00080F98
		private unsafe static char TryBestFit(char cUnknown)
		{
			int num = 0;
			int num2 = EncoderLatin1BestFitFallbackBuffer.ArrayCharBestFit.Length;
			int num3;
			while ((num3 = num2 - num) > 6)
			{
				int i = num3 / 2 + num & 65534;
				char c = (char)(*EncoderLatin1BestFitFallbackBuffer.ArrayCharBestFit[i]);
				if (c == cUnknown)
				{
					return (char)(*EncoderLatin1BestFitFallbackBuffer.ArrayCharBestFit[i + 1]);
				}
				if (c < cUnknown)
				{
					num = i;
				}
				else
				{
					num2 = i;
				}
			}
			for (int i = num; i < num2; i += 2)
			{
				if (*EncoderLatin1BestFitFallbackBuffer.ArrayCharBestFit[i] == (ushort)cUnknown)
				{
					return (char)(*EncoderLatin1BestFitFallbackBuffer.ArrayCharBestFit[i + 1]);
				}
			}
			return '\0';
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x00082E34 File Offset: 0x00081034
		private static ReadOnlySpan<char> ArrayCharBestFit
		{
			get
			{
				return RuntimeHelpers.CreateSpan<char>(fieldof(<PrivateImplementationDetails>.FB2089AF82E09593374B65EC2440779FDCF5DD6DA07D26E57AF6790667B937CD2).FieldHandle);
			}
		}

		// Token: 0x0400075B RID: 1883
		private char _cBestFit;

		// Token: 0x0400075C RID: 1884
		private int _iCount = -1;

		// Token: 0x0400075D RID: 1885
		private int _iSize;
	}
}
