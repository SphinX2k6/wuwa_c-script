using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;

namespace System.Text
{
	// Token: 0x02000222 RID: 546
	public abstract class EncoderFallbackBuffer
	{
		// Token: 0x060029D5 RID: 10709
		public abstract bool Fallback(char charUnknown, int index);

		// Token: 0x060029D6 RID: 10710
		public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

		// Token: 0x060029D7 RID: 10711
		public abstract char GetNextChar();

		// Token: 0x060029D8 RID: 10712
		public abstract bool MovePrevious();

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060029D9 RID: 10713
		public abstract int Remaining { get; }

		// Token: 0x060029DA RID: 10714 RVA: 0x0008287D File Offset: 0x00080A7D
		public virtual void Reset()
		{
			while (this.GetNextChar() != '\0')
			{
			}
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00082887 File Offset: 0x00080A87
		internal void InternalReset()
		{
			this.charStart = null;
			this.bFallingBack = false;
			this.iRecursionCount = 0;
			this.Reset();
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000828A5 File Offset: 0x00080AA5
		internal unsafe void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder)
		{
			this.charStart = charStart;
			this.charEnd = charEnd;
			this.encoder = encoder;
			this.setEncoder = setEncoder;
			this.bUsedEncoder = false;
			this.bFallingBack = false;
			this.iRecursionCount = 0;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000828D9 File Offset: 0x00080AD9
		internal static EncoderFallbackBuffer CreateAndInitialize(Encoding encoding, EncoderNLS encoder, int originalCharCount)
		{
			EncoderFallbackBuffer encoderFallbackBuffer = (encoder == null) ? encoding.EncoderFallback.CreateFallbackBuffer() : encoder.FallbackBuffer;
			encoderFallbackBuffer.encoding = encoding;
			encoderFallbackBuffer.encoder = encoder;
			encoderFallbackBuffer.originalCharCount = originalCharCount;
			return encoderFallbackBuffer;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00082908 File Offset: 0x00080B08
		internal char InternalGetNextChar()
		{
			char nextChar = this.GetNextChar();
			this.bFallingBack = (nextChar > '\0');
			if (nextChar == '\0')
			{
				this.iRecursionCount = 0;
			}
			return nextChar;
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00082934 File Offset: 0x00080B34
		private unsafe bool InternalFallback(ReadOnlySpan<char> chars, out int charsConsumed)
		{
			char c = (char)(*chars[0]);
			char c2 = '\0';
			if (!chars.IsEmpty)
			{
				c = (char)(*chars[0]);
				if (chars.Length > 1)
				{
					c2 = (char)(*chars[1]);
				}
			}
			int index = this.originalCharCount - chars.Length;
			if (!char.IsSurrogatePair(c, c2))
			{
				charsConsumed = 1;
				return this.Fallback(c, index);
			}
			charsConsumed = 2;
			return this.Fallback(c, c2, index);
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000829A4 File Offset: 0x00080BA4
		internal int InternalFallbackGetByteCount(ReadOnlySpan<char> chars, out int charsConsumed)
		{
			int result = 0;
			if (this.InternalFallback(chars, out charsConsumed))
			{
				result = this.DrainRemainingDataForGetByteCount();
			}
			return result;
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000829C5 File Offset: 0x00080BC5
		internal bool TryInternalFallbackGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int charsConsumed, out int bytesWritten)
		{
			if (this.InternalFallback(chars, out charsConsumed))
			{
				return this.TryDrainRemainingDataForGetBytes(bytes, out bytesWritten);
			}
			bytesWritten = 0;
			return true;
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000829E0 File Offset: 0x00080BE0
		internal bool TryDrainRemainingDataForGetBytes(Span<byte> bytes, out int bytesWritten)
		{
			int length = bytes.Length;
			Rune value;
			for (;;)
			{
				Rune nextRune;
				value = (nextRune = this.GetNextRune());
				if (nextRune.Value == 0)
				{
					goto Block_3;
				}
				int start;
				switch (this.encoding.EncodeRune(value, bytes, out start))
				{
				case OperationStatus.Done:
					bytes = bytes.Slice(start);
					break;
				case OperationStatus.DestinationTooSmall:
					goto IL_3E;
				case OperationStatus.InvalidData:
					EncoderFallbackBuffer.ThrowLastCharRecursive(value.Value);
					break;
				}
			}
			IL_3E:
			for (int i = 0; i < value.Utf16SequenceLength; i++)
			{
				this.MovePrevious();
			}
			bytesWritten = length - bytes.Length;
			return false;
			Block_3:
			bytesWritten = length - bytes.Length;
			return true;
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00082A80 File Offset: 0x00080C80
		internal int DrainRemainingDataForGetByteCount()
		{
			int num = 0;
			for (;;)
			{
				Rune nextRune;
				Rune value = nextRune = this.GetNextRune();
				if (nextRune.Value == 0)
				{
					break;
				}
				int num2;
				if (!this.encoding.TryGetByteCount(value, out num2))
				{
					EncoderFallbackBuffer.ThrowLastCharRecursive(value.Value);
				}
				num += num2;
				if (num < 0)
				{
					this.InternalReset();
					Encoding.ThrowConversionOverflow();
				}
			}
			return num;
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00082AD4 File Offset: 0x00080CD4
		private Rune GetNextRune()
		{
			char nextChar = this.GetNextChar();
			Rune result;
			if (Rune.TryCreate(nextChar, out result) || Rune.TryCreate(nextChar, this.GetNextChar(), out result))
			{
				return result;
			}
			throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00082B10 File Offset: 0x00080D10
		internal unsafe bool InternalFallback(char ch, ref char* chars)
		{
			int index = (chars - this.charStart) / 2 - 1;
			if (char.IsHighSurrogate(ch))
			{
				if (chars >= this.charEnd)
				{
					if (this.encoder != null && !this.encoder.MustFlush)
					{
						if (this.setEncoder)
						{
							this.bUsedEncoder = true;
							this.encoder._charLeftOver = ch;
						}
						this.bFallingBack = false;
						return false;
					}
				}
				else
				{
					char c = (char)(*chars);
					if (char.IsLowSurrogate(c))
					{
						if (this.bFallingBack)
						{
							int num = this.iRecursionCount;
							this.iRecursionCount = num + 1;
							if (num > 250)
							{
								EncoderFallbackBuffer.ThrowLastCharRecursive(char.ConvertToUtf32(ch, c));
							}
						}
						chars += 2;
						this.bFallingBack = this.Fallback(ch, c, index);
						return this.bFallingBack;
					}
				}
			}
			if (this.bFallingBack)
			{
				int num = this.iRecursionCount;
				this.iRecursionCount = num + 1;
				if (num > 250)
				{
					EncoderFallbackBuffer.ThrowLastCharRecursive((int)ch);
				}
			}
			this.bFallingBack = this.Fallback(ch, index);
			return this.bFallingBack;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00082C0C File Offset: 0x00080E0C
		[DoesNotReturn]
		internal static void ThrowLastCharRecursive(int charRecursive)
		{
			throw new ArgumentException(SR.Format(SR.Argument_RecursiveFallback, charRecursive), "chars");
		}

		// Token: 0x04000751 RID: 1873
		internal unsafe char* charStart;

		// Token: 0x04000752 RID: 1874
		internal unsafe char* charEnd;

		// Token: 0x04000753 RID: 1875
		internal EncoderNLS encoder;

		// Token: 0x04000754 RID: 1876
		internal bool setEncoder;

		// Token: 0x04000755 RID: 1877
		internal bool bUsedEncoder;

		// Token: 0x04000756 RID: 1878
		internal bool bFallingBack;

		// Token: 0x04000757 RID: 1879
		internal int iRecursionCount;

		// Token: 0x04000758 RID: 1880
		private Encoding encoding;

		// Token: 0x04000759 RID: 1881
		private int originalCharCount;
	}
}
