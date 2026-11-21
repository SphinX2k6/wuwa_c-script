using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Text
{
	// Token: 0x02000219 RID: 537
	public abstract class DecoderFallbackBuffer
	{
		// Token: 0x06002976 RID: 10614
		[NullableContext(1)]
		public abstract bool Fallback(byte[] bytesUnknown, int index);

		// Token: 0x06002977 RID: 10615
		public abstract char GetNextChar();

		// Token: 0x06002978 RID: 10616
		public abstract bool MovePrevious();

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06002979 RID: 10617
		public abstract int Remaining { get; }

		// Token: 0x0600297A RID: 10618 RVA: 0x0008178A File Offset: 0x0007F98A
		public virtual void Reset()
		{
			while (this.GetNextChar() != '\0')
			{
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00081794 File Offset: 0x0007F994
		internal void InternalReset()
		{
			this.byteStart = null;
			this.Reset();
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000817A4 File Offset: 0x0007F9A4
		internal unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
			this.byteStart = byteStart;
			this.charEnd = charEnd;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000817B4 File Offset: 0x0007F9B4
		internal static DecoderFallbackBuffer CreateAndInitialize(Encoding encoding, DecoderNLS decoder, int originalByteCount)
		{
			DecoderFallbackBuffer decoderFallbackBuffer = (decoder == null) ? encoding.DecoderFallback.CreateFallbackBuffer() : decoder.FallbackBuffer;
			decoderFallbackBuffer._encoding = encoding;
			decoderFallbackBuffer._decoder = decoder;
			decoderFallbackBuffer._originalByteCount = originalByteCount;
			return decoderFallbackBuffer;
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000817E4 File Offset: 0x0007F9E4
		internal unsafe bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars)
		{
			if (this.Fallback(bytes, (int)((long)(pBytes - this.byteStart) - (long)bytes.Length)))
			{
				char* ptr = chars;
				bool flag = false;
				char nextChar;
				while ((nextChar = this.GetNextChar()) != '\0')
				{
					if (char.IsSurrogate(nextChar))
					{
						if (char.IsHighSurrogate(nextChar))
						{
							if (flag)
							{
								throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
							}
							flag = true;
						}
						else
						{
							if (!flag)
							{
								throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
							}
							flag = false;
						}
					}
					if (ptr >= this.charEnd)
					{
						return false;
					}
					*(ptr++) = nextChar;
				}
				if (flag)
				{
					throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
				}
				chars = ptr;
			}
			return true;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00081874 File Offset: 0x0007FA74
		internal unsafe virtual int InternalFallback(byte[] bytes, byte* pBytes)
		{
			if (!this.Fallback(bytes, (int)((long)(pBytes - this.byteStart) - (long)bytes.Length)))
			{
				return 0;
			}
			int num = 0;
			bool flag = false;
			char nextChar;
			while ((nextChar = this.GetNextChar()) != '\0')
			{
				if (char.IsSurrogate(nextChar))
				{
					if (char.IsHighSurrogate(nextChar))
					{
						if (flag)
						{
							throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
						}
						flag = true;
					}
					else
					{
						if (!flag)
						{
							throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
						}
						flag = false;
					}
				}
				num++;
			}
			if (flag)
			{
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
			}
			return num;
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000818F4 File Offset: 0x0007FAF4
		internal int InternalFallbackGetCharCount(ReadOnlySpan<byte> remainingBytes, int fallbackLength)
		{
			if (!this.Fallback(remainingBytes.Slice(0, fallbackLength).ToArray(), this._originalByteCount - remainingBytes.Length))
			{
				return 0;
			}
			return this.DrainRemainingDataForGetCharCount();
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00081930 File Offset: 0x0007FB30
		internal bool TryInternalFallbackGetChars(ReadOnlySpan<byte> remainingBytes, int fallbackLength, Span<char> chars, out int charsWritten)
		{
			if (this.Fallback(remainingBytes.Slice(0, fallbackLength).ToArray(), this._originalByteCount - remainingBytes.Length))
			{
				return this.TryDrainRemainingDataForGetChars(chars, out charsWritten);
			}
			charsWritten = 0;
			return true;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x00081974 File Offset: 0x0007FB74
		private Rune GetNextRune()
		{
			char nextChar = this.GetNextChar();
			Rune result;
			if (!Rune.TryCreate(nextChar, out result) && !Rune.TryCreate(nextChar, this.GetNextChar(), out result))
			{
				throw new ArgumentException(SR.Argument_InvalidCharSequenceNoIndex);
			}
			return result;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000819B0 File Offset: 0x0007FBB0
		internal int DrainRemainingDataForGetCharCount()
		{
			int num = 0;
			for (;;)
			{
				Rune nextRune;
				Rune rune = nextRune = this.GetNextRune();
				if (nextRune.Value == 0)
				{
					break;
				}
				num += rune.Utf16SequenceLength;
				if (num < 0)
				{
					this.InternalReset();
					Encoding.ThrowConversionOverflow();
				}
			}
			return num;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000819F0 File Offset: 0x0007FBF0
		internal bool TryDrainRemainingDataForGetChars(Span<char> chars, out int charsWritten)
		{
			int length = chars.Length;
			for (;;)
			{
				Rune nextRune;
				Rune rune = nextRune = this.GetNextRune();
				if (nextRune.Value == 0)
				{
					goto Block_2;
				}
				int start;
				if (!rune.TryEncodeToUtf16(chars, out start))
				{
					break;
				}
				chars = chars.Slice(start);
			}
			this.InternalReset();
			charsWritten = 0;
			return false;
			Block_2:
			charsWritten = length - chars.Length;
			return true;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00081A48 File Offset: 0x0007FC48
		[DoesNotReturn]
		internal static void ThrowLastBytesRecursive(byte[] bytesUnknown)
		{
			if (bytesUnknown == null)
			{
				bytesUnknown = Array.Empty<byte>();
			}
			StringBuilder stringBuilder = new StringBuilder(bytesUnknown.Length * 3);
			int num = 0;
			while (num < bytesUnknown.Length && num < 20)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append(' ');
				}
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder3 = stringBuilder2;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(2, 1, stringBuilder2);
				appendInterpolatedStringHandler.AppendLiteral("\\x");
				appendInterpolatedStringHandler.AppendFormatted<byte>(bytesUnknown[num], "X2");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
				num++;
			}
			if (num == 20)
			{
				stringBuilder.Append(" ...");
			}
			throw new ArgumentException(SR.Format(SR.Argument_RecursiveFallbackBytes, stringBuilder.ToString()), "bytesUnknown");
		}

		// Token: 0x0400073A RID: 1850
		internal unsafe byte* byteStart;

		// Token: 0x0400073B RID: 1851
		internal unsafe char* charEnd;

		// Token: 0x0400073C RID: 1852
		internal Encoding _encoding;

		// Token: 0x0400073D RID: 1853
		internal DecoderNLS _decoder;

		// Token: 0x0400073E RID: 1854
		private int _originalByteCount;
	}
}
