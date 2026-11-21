using System;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace System.Text
{
	// Token: 0x0200024B RID: 587
	public class UTF8Encoding : Encoding
	{
		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0008E586 File Offset: 0x0008C786
		internal unsafe static ReadOnlySpan<byte> PreambleSpan
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5), 3);
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0008E593 File Offset: 0x0008C793
		public UTF8Encoding() : base(65001)
		{
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0008E5A0 File Offset: 0x0008C7A0
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) : this()
		{
			this._emitUTF8Identifier = encoderShouldEmitUTF8Identifier;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x0008E5AF File Offset: 0x0008C7AF
		public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) : this(encoderShouldEmitUTF8Identifier)
		{
			this._isThrowException = throwOnInvalidBytes;
			if (this._isThrowException)
			{
				this.SetDefaultFallbacks();
			}
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x0008E5D0 File Offset: 0x0008C7D0
		internal sealed override void SetDefaultFallbacks()
		{
			if (this._isThrowException)
			{
				this.encoderFallback = EncoderFallback.ExceptionFallback;
				this.decoderFallback = DecoderFallback.ExceptionFallback;
				return;
			}
			this.encoderFallback = new EncoderReplacementFallback("�");
			this.decoderFallback = new DecoderReplacementFallback("�");
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0008E61C File Offset: 0x0008C81C
		[NullableContext(1)]
		public unsafe override int GetByteCount(char[] chars, int index, int count)
		{
			if (chars == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.chars, ExceptionResource.ArgumentNull_Array);
			}
			if ((index | count) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((index < 0) ? ExceptionArgument.index : ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (chars.Length - index < count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.chars, ExceptionResource.ArgumentOutOfRange_IndexCountBuffer);
			}
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			return this.GetByteCountCommon(ptr + index, count);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0008E684 File Offset: 0x0008C884
		[NullableContext(1)]
		public unsafe override int GetByteCount(string chars)
		{
			if (chars == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.chars);
			}
			char* ptr;
			if (chars == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = chars.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* pChars = ptr;
			return this.GetByteCountCommon(pChars, chars.Length);
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0008E6B9 File Offset: 0x0008C8B9
		[CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			if (chars == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.chars);
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return this.GetByteCountCommon(chars, count);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0008E6DC File Offset: 0x0008C8DC
		public unsafe override int GetByteCount(ReadOnlySpan<char> chars)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* pChars = reference;
				return this.GetByteCountCommon(pChars, chars.Length);
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0008E704 File Offset: 0x0008C904
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetByteCountCommon(char* pChars, int charCount)
		{
			int num2;
			int num = this.GetByteCountFast(pChars, charCount, null, out num2);
			if (num2 != charCount)
			{
				num += base.GetByteCountWithFallback(pChars, charCount, num2);
				if (num < 0)
				{
					Encoding.ThrowConversionOverflow();
				}
			}
			return num;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0008E738 File Offset: 0x0008C938
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetByteCountFast(char* pChars, int charsLength, EncoderFallback fallback, out int charsConsumed)
		{
			long num2;
			int num3;
			int num = (int)((long)(Utf16Utility.GetPointerToFirstInvalidChar(pChars, charsLength, out num2, out num3) - pChars));
			charsConsumed = num;
			long num4 = (long)num + num2;
			if (num4 > 2147483647L)
			{
				Encoding.ThrowConversionOverflow();
			}
			return (int)num4;
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0008E770 File Offset: 0x0008C970
		[NullableContext(1)]
		public unsafe override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (s == null || bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException((s == null) ? ExceptionArgument.s : ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if ((charIndex | charCount) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((charIndex < 0) ? ExceptionArgument.charIndex : ExceptionArgument.charCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (s.Length - charIndex < charCount)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.s, ExceptionResource.ArgumentOutOfRange_IndexCount);
			}
			if ((ulong)byteIndex > (ulong)((long)bytes.Length))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.byteIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			char* ptr;
			if (s == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = s.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			byte* ptr3;
			if (bytes == null || bytes.Length == 0)
			{
				ptr3 = null;
			}
			else
			{
				ptr3 = &bytes[0];
			}
			return this.GetBytesCommon(ptr2 + charIndex, charCount, ptr3 + byteIndex, bytes.Length - byteIndex, true);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0008E814 File Offset: 0x0008CA14
		[NullableContext(1)]
		public unsafe override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			if (chars == null || bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException((chars == null) ? ExceptionArgument.chars : ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if ((charIndex | charCount) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((charIndex < 0) ? ExceptionArgument.charIndex : ExceptionArgument.charCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (chars.Length - charIndex < charCount)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.chars, ExceptionResource.ArgumentOutOfRange_IndexCount);
			}
			if ((ulong)byteIndex > (ulong)((long)bytes.Length))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.byteIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			char* ptr;
			if (chars == null || chars.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &chars[0];
			}
			byte* ptr2;
			if (bytes == null || bytes.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &bytes[0];
			}
			return this.GetBytesCommon(ptr + charIndex, charCount, ptr2 + byteIndex, bytes.Length - byteIndex, true);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x0008E8BC File Offset: 0x0008CABC
		[CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			if (chars == null || bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException((chars == null) ? ExceptionArgument.chars : ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if ((charCount | byteCount) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((charCount < 0) ? ExceptionArgument.charCount : ExceptionArgument.byteCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return this.GetBytesCommon(chars, charCount, bytes, byteCount, true);
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0008E90C File Offset: 0x0008CB0C
		public unsafe override int GetBytes(ReadOnlySpan<char> chars, Span<byte> bytes)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* pChars = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* pBytes = reference2;
					return this.GetBytesCommon(pChars, chars.Length, pBytes, bytes.Length, true);
				}
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x0008E944 File Offset: 0x0008CB44
		public unsafe override bool TryGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* pChars = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* pBytes = reference2;
					int bytesCommon = this.GetBytesCommon(pChars, chars.Length, pBytes, bytes.Length, false);
					if (bytesCommon >= 0)
					{
						bytesWritten = bytesCommon;
						return true;
					}
					bytesWritten = 0;
					return false;
				}
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x0008E990 File Offset: 0x0008CB90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetBytesCommon(char* pChars, int charCount, byte* pBytes, int byteCount, bool throwForDestinationOverflow = true)
		{
			int num;
			int bytesFast = this.GetBytesFast(pChars, charCount, pBytes, byteCount, out num);
			if (num == charCount)
			{
				return bytesFast;
			}
			return base.GetBytesWithFallback(pChars, charCount, pBytes, byteCount, num, bytesFast, throwForDestinationOverflow);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0008E9C0 File Offset: 0x0008CBC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetBytesFast(char* pChars, int charsLength, byte* pBytes, int bytesLength, out int charsConsumed)
		{
			char* ptr;
			byte* ptr2;
			Utf8Utility.TranscodeToUtf8(pChars, charsLength, pBytes, bytesLength, out ptr, out ptr2);
			charsConsumed = (int)((long)(ptr - pChars));
			return (int)((long)(ptr2 - pBytes));
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x0008E9F0 File Offset: 0x0008CBF0
		[NullableContext(1)]
		public unsafe override int GetCharCount(byte[] bytes, int index, int count)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if ((index | count) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((index < 0) ? ExceptionArgument.index : ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (bytes.Length - index < count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.bytes, ExceptionResource.ArgumentOutOfRange_IndexCountBuffer);
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return this.GetCharCountCommon(ptr + index, count);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0008EA52 File Offset: 0x0008CC52
		[CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return this.GetCharCountCommon(bytes, count);
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x0008EA78 File Offset: 0x0008CC78
		public unsafe override int GetCharCount(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* pBytes = reference;
				return this.GetCharCountCommon(pBytes, bytes.Length);
			}
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x0008EAA0 File Offset: 0x0008CCA0
		[NullableContext(1)]
		public unsafe override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			if (bytes == null || chars == null)
			{
				ThrowHelper.ThrowArgumentNullException((bytes == null) ? ExceptionArgument.bytes : ExceptionArgument.chars, ExceptionResource.ArgumentNull_Array);
			}
			if ((byteIndex | byteCount) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((byteIndex < 0) ? ExceptionArgument.byteIndex : ExceptionArgument.byteCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.bytes, ExceptionResource.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (charIndex > chars.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.charIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			char* ptr2;
			if (chars == null || chars.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &chars[0];
			}
			return this.GetCharsCommon(ptr + byteIndex, byteCount, ptr2 + charIndex, chars.Length - charIndex, true);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0008EB48 File Offset: 0x0008CD48
		[CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			if (bytes == null || chars == null)
			{
				ThrowHelper.ThrowArgumentNullException((bytes == null) ? ExceptionArgument.bytes : ExceptionArgument.chars, ExceptionResource.ArgumentNull_Array);
			}
			if ((byteCount | charCount) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((byteCount < 0) ? ExceptionArgument.byteCount : ExceptionArgument.charCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return this.GetCharsCommon(bytes, byteCount, chars, charCount, true);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0008EB98 File Offset: 0x0008CD98
		public unsafe override int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* pBytes = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
				{
					char* pChars = reference2;
					return this.GetCharsCommon(pBytes, bytes.Length, pChars, chars.Length, true);
				}
			}
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0008EBD0 File Offset: 0x0008CDD0
		public unsafe override bool TryGetChars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* pBytes = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
				{
					char* pChars = reference2;
					int charsCommon = this.GetCharsCommon(pBytes, bytes.Length, pChars, chars.Length, false);
					if (charsCommon >= 0)
					{
						charsWritten = charsCommon;
						return true;
					}
					charsWritten = 0;
					return false;
				}
			}
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0008EC1C File Offset: 0x0008CE1C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetCharsCommon(byte* pBytes, int byteCount, char* pChars, int charCount, bool throwForDestinationOverflow = true)
		{
			int num;
			int charsFast = this.GetCharsFast(pBytes, byteCount, pChars, charCount, out num);
			if (num == byteCount)
			{
				return charsFast;
			}
			return base.GetCharsWithFallback(pBytes, byteCount, pChars, charCount, num, charsFast, throwForDestinationOverflow);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0008EC4C File Offset: 0x0008CE4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetCharsFast(byte* pBytes, int bytesLength, char* pChars, int charsLength, out int bytesConsumed)
		{
			byte* ptr;
			char* ptr2;
			Utf8Utility.TranscodeToUtf16(pBytes, bytesLength, pChars, charsLength, out ptr, out ptr2);
			bytesConsumed = (int)((long)(ptr - pBytes));
			return (int)((long)(ptr2 - pChars));
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0008EC7C File Offset: 0x0008CE7C
		private protected sealed override int GetCharsWithFallback(ReadOnlySpan<byte> bytes, int originalBytesLength, Span<char> chars, int originalCharsLength, DecoderNLS decoder, bool throwForDestinationOverflow = true)
		{
			DecoderReplacementFallback decoderReplacementFallback = ((decoder == null) ? base.DecoderFallback : decoder.Fallback) as DecoderReplacementFallback;
			if (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1 && decoderReplacementFallback.DefaultString[0] == '�')
			{
				int start;
				int start2;
				Utf8.ToUtf16(bytes, chars, out start, out start2, true, decoder == null || decoder.MustFlush);
				bytes = bytes.Slice(start);
				chars = chars.Slice(start2);
			}
			if (bytes.IsEmpty)
			{
				return originalCharsLength - chars.Length;
			}
			return base.GetCharsWithFallback(bytes, originalBytesLength, chars, originalCharsLength, decoder, throwForDestinationOverflow);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0008ED14 File Offset: 0x0008CF14
		[NullableContext(1)]
		public unsafe override string GetString(byte[] bytes, int index, int count)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if ((index | count) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((index < 0) ? ExceptionArgument.index : ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (bytes.Length - index < count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.bytes, ExceptionResource.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (count == 0)
			{
				return string.Empty;
			}
			byte* ptr;
			if (bytes == null || bytes.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &bytes[0];
			}
			return string.CreateStringFromEncoding(ptr + index, count, this);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0008ED80 File Offset: 0x0008CF80
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetCharCountCommon(byte* pBytes, int byteCount)
		{
			int num2;
			int num = this.GetCharCountFast(pBytes, byteCount, null, out num2);
			if (num2 != byteCount)
			{
				num += base.GetCharCountWithFallback(pBytes, byteCount, num2);
				if (num < 0)
				{
					Encoding.ThrowConversionOverflow();
				}
			}
			return num;
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0008EDB4 File Offset: 0x0008CFB4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetCharCountFast(byte* pBytes, int bytesLength, DecoderFallback fallback, out int bytesConsumed)
		{
			int num2;
			int num3;
			int num = (int)((long)(Utf8Utility.GetPointerToFirstInvalidByte(pBytes, bytesLength, out num2, out num3) - pBytes));
			bytesConsumed = num;
			return num + num2;
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00080E1B File Offset: 0x0007F01B
		[NullableContext(1)]
		public override Decoder GetDecoder()
		{
			return new DecoderNLS(this);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00080E23 File Offset: 0x0007F023
		[NullableContext(1)]
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x0008EDDA File Offset: 0x0008CFDA
		internal sealed override bool TryGetByteCount(Rune value, out int byteCount)
		{
			byteCount = value.Utf8SequenceLength;
			return true;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x0008EDE6 File Offset: 0x0008CFE6
		internal sealed override OperationStatus EncodeRune(Rune value, Span<byte> bytes, out int bytesWritten)
		{
			if (!value.TryEncodeToUtf8(bytes, out bytesWritten))
			{
				return OperationStatus.DestinationTooSmall;
			}
			return OperationStatus.Done;
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0008EDF6 File Offset: 0x0008CFF6
		internal sealed override OperationStatus DecodeFirstRune(ReadOnlySpan<byte> bytes, out Rune value, out int bytesConsumed)
		{
			return Rune.DecodeFromUtf8(bytes, out value, out bytesConsumed);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0008EE00 File Offset: 0x0008D000
		public override int GetMaxByteCount(int charCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			long num = (long)charCount + 1L;
			if (base.EncoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.EncoderFallback.MaxCharCount;
			}
			num *= 3L;
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0008EE5C File Offset: 0x0008D05C
		public override int GetMaxCharCount(int byteCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			long num = (long)byteCount + 1L;
			if (base.DecoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.DecoderFallback.MaxCharCount;
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("byteCount", SR.ArgumentOutOfRange_GetCharCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x0008EEB2 File Offset: 0x0008D0B2
		[NullableContext(1)]
		public override byte[] GetPreamble()
		{
			if (this._emitUTF8Identifier)
			{
				return new byte[]
				{
					239,
					187,
					191
				};
			}
			return Array.Empty<byte>();
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x0008EED4 File Offset: 0x0008D0D4
		public override ReadOnlySpan<byte> Preamble
		{
			get
			{
				if (base.GetType() != typeof(UTF8Encoding))
				{
					return new ReadOnlySpan<byte>(this.GetPreamble());
				}
				if (!this._emitUTF8Identifier)
				{
					return default(ReadOnlySpan<byte>);
				}
				return UTF8Encoding.PreambleSpan;
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0008EF1C File Offset: 0x0008D11C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			UTF8Encoding utf8Encoding = value as UTF8Encoding;
			return utf8Encoding != null && (this._emitUTF8Identifier == utf8Encoding._emitUTF8Identifier && base.EncoderFallback.Equals(utf8Encoding.EncoderFallback)) && base.DecoderFallback.Equals(utf8Encoding.DecoderFallback);
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x0008EF69 File Offset: 0x0008D169
		public override int GetHashCode()
		{
			return base.EncoderFallback.GetHashCode() + base.DecoderFallback.GetHashCode() + 65001 + ((this._emitUTF8Identifier > false) ? 1 : 0);
		}

		// Token: 0x040007EC RID: 2028
		internal static readonly UTF8Encoding.UTF8EncodingSealed s_default = new UTF8Encoding.UTF8EncodingSealed(true);

		// Token: 0x040007ED RID: 2029
		private readonly bool _emitUTF8Identifier;

		// Token: 0x040007EE RID: 2030
		private readonly bool _isThrowException;

		// Token: 0x0200024C RID: 588
		internal sealed class UTF8EncodingSealed : UTF8Encoding
		{
			// Token: 0x06002CC3 RID: 11459 RVA: 0x0008EF9F File Offset: 0x0008D19F
			public UTF8EncodingSealed(bool encoderShouldEmitUTF8Identifier) : base(encoderShouldEmitUTF8Identifier)
			{
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x0008EFA8 File Offset: 0x0008D1A8
			public override ReadOnlySpan<byte> Preamble
			{
				get
				{
					if (!this._emitUTF8Identifier)
					{
						return default(ReadOnlySpan<byte>);
					}
					return UTF8Encoding.PreambleSpan;
				}
			}

			// Token: 0x06002CC5 RID: 11461 RVA: 0x0008EFCC File Offset: 0x0008D1CC
			public override object Clone()
			{
				return new UTF8Encoding(this._emitUTF8Identifier)
				{
					IsReadOnly = false
				};
			}

			// Token: 0x06002CC6 RID: 11462 RVA: 0x0008EFE0 File Offset: 0x0008D1E0
			public override byte[] GetBytes(string s)
			{
				if (s != null && s.Length <= 32)
				{
					return this.GetBytesForSmallInput(s);
				}
				return base.GetBytes(s);
			}

			// Token: 0x06002CC7 RID: 11463 RVA: 0x0008F000 File Offset: 0x0008D200
			private unsafe byte[] GetBytesForSmallInput(string s)
			{
				byte* ptr = stackalloc byte[(UIntPtr)96];
				int length = s.Length;
				char* ptr2;
				if (s == null)
				{
					ptr2 = null;
				}
				else
				{
					fixed (char* ptr3 = s.GetPinnableReference())
					{
						ptr2 = ptr3;
					}
				}
				char* pChars = ptr2;
				int bytesCommon = base.GetBytesCommon(pChars, length, ptr, 96, true);
				char* ptr3 = null;
				return new Span<byte>(ref *ptr, bytesCommon).ToArray();
			}

			// Token: 0x06002CC8 RID: 11464 RVA: 0x0008F04E File Offset: 0x0008D24E
			public override int GetMaxByteCount(int charCount)
			{
				if (charCount > 715827881)
				{
					UTF8Encoding.UTF8EncodingSealed.<GetMaxByteCount>g__ThrowArgumentException|7_0(charCount);
				}
				return charCount * 3 + 3;
			}

			// Token: 0x06002CC9 RID: 11465 RVA: 0x0008F063 File Offset: 0x0008D263
			public override int GetMaxCharCount(int byteCount)
			{
				if (byteCount > 2147483646)
				{
					UTF8Encoding.UTF8EncodingSealed.<GetMaxCharCount>g__ThrowArgumentException|8_0(byteCount);
				}
				return byteCount + 1;
			}

			// Token: 0x06002CCA RID: 11466 RVA: 0x0008F076 File Offset: 0x0008D276
			public override string GetString(byte[] bytes)
			{
				if (bytes != null && bytes.Length <= 32)
				{
					return this.GetStringForSmallInput(bytes);
				}
				return base.GetString(bytes);
			}

			// Token: 0x06002CCB RID: 11467 RVA: 0x0008F094 File Offset: 0x0008D294
			private unsafe string GetStringForSmallInput(byte[] bytes)
			{
				char* ptr = stackalloc char[(UIntPtr)64];
				int byteCount = bytes.Length;
				int charsCommon;
				fixed (byte[] array = bytes)
				{
					byte* pBytes;
					if (bytes == null || array.Length == 0)
					{
						pBytes = null;
					}
					else
					{
						pBytes = &array[0];
					}
					charsCommon = base.GetCharsCommon(pBytes, byteCount, ptr, 32, true);
				}
				return new string(new ReadOnlySpan<char>(ref *ptr, charsCommon));
			}

			// Token: 0x06002CCC RID: 11468 RVA: 0x0008F0E2 File Offset: 0x0008D2E2
			public override bool TryGetBytes(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten)
			{
				return base.TryGetBytes(chars, bytes, out bytesWritten);
			}

			// Token: 0x06002CCD RID: 11469 RVA: 0x0008F0F0 File Offset: 0x0008D2F0
			[Intrinsic]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal unsafe static int ReadUtf8(ref char input, int inputLength, ref byte output, int outputLength)
			{
				fixed (char* ptr = &input)
				{
					char* pChars = ptr;
					fixed (byte* ptr2 = &output)
					{
						byte* pBytes = ptr2;
						return UTF8Encoding.s_default.GetBytesCommon(pChars, inputLength, pBytes, outputLength, false);
					}
				}
			}

			// Token: 0x06002CCE RID: 11470 RVA: 0x0008F116 File Offset: 0x0008D316
			[CompilerGenerated]
			internal static void <GetMaxByteCount>g__ThrowArgumentException|7_0(int charCount)
			{
				throw new ArgumentOutOfRangeException("charCount", (charCount < 0) ? SR.ArgumentOutOfRange_NeedNonNegNum : SR.ArgumentOutOfRange_GetByteCountOverflow);
			}

			// Token: 0x06002CCF RID: 11471 RVA: 0x0008F132 File Offset: 0x0008D332
			[CompilerGenerated]
			internal static void <GetMaxCharCount>g__ThrowArgumentException|8_0(int byteCount)
			{
				throw new ArgumentOutOfRangeException("byteCount", (byteCount < 0) ? SR.ArgumentOutOfRange_NeedNonNegNum : SR.ArgumentOutOfRange_GetCharCountOverflow);
			}
		}
	}
}
