using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000210 RID: 528
	public class ASCIIEncoding : Encoding
	{
		// Token: 0x06002917 RID: 10519 RVA: 0x000803E1 File Offset: 0x0007E5E1
		public ASCIIEncoding() : base(20127)
		{
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000803EE File Offset: 0x0007E5EE
		internal sealed override void SetDefaultFallbacks()
		{
			this.encoderFallback = EncoderFallback.ReplacementFallback;
			this.decoderFallback = DecoderFallback.ReplacementFallback;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00080408 File Offset: 0x0007E608
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

		// Token: 0x0600291A RID: 10522 RVA: 0x00080470 File Offset: 0x0007E670
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

		// Token: 0x0600291B RID: 10523 RVA: 0x000804A5 File Offset: 0x0007E6A5
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

		// Token: 0x0600291C RID: 10524 RVA: 0x000804C8 File Offset: 0x0007E6C8
		public unsafe override int GetByteCount(ReadOnlySpan<char> chars)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* pChars = reference;
				return this.GetByteCountCommon(pChars, chars.Length);
			}
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000804F0 File Offset: 0x0007E6F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetByteCountCommon(char* pChars, int charCount)
		{
			int num2;
			int num = this.GetByteCountFast(pChars, charCount, base.EncoderFallback, out num2);
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

		// Token: 0x0600291E RID: 10526 RVA: 0x00080528 File Offset: 0x0007E728
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetByteCountFast(char* pChars, int charsLength, EncoderFallback fallback, out int charsConsumed)
		{
			int num = charsLength;
			EncoderReplacementFallback encoderReplacementFallback = fallback as EncoderReplacementFallback;
			if (encoderReplacementFallback == null || encoderReplacementFallback.MaxCharCount != 1 || !Ascii.IsValid(encoderReplacementFallback.DefaultString[0]))
			{
				num = (int)Ascii.GetIndexOfFirstNonAsciiChar(pChars, (UIntPtr)charsLength);
			}
			charsConsumed = num;
			return num;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0008056C File Offset: 0x0007E76C
		[NullableContext(1)]
		public unsafe override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
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

		// Token: 0x06002920 RID: 10528 RVA: 0x00080610 File Offset: 0x0007E810
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

		// Token: 0x06002921 RID: 10529 RVA: 0x000806B8 File Offset: 0x0007E8B8
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

		// Token: 0x06002922 RID: 10530 RVA: 0x00080708 File Offset: 0x0007E908
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

		// Token: 0x06002923 RID: 10531 RVA: 0x00080740 File Offset: 0x0007E940
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

		// Token: 0x06002924 RID: 10532 RVA: 0x0008078C File Offset: 0x0007E98C
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

		// Token: 0x06002925 RID: 10533 RVA: 0x000807BC File Offset: 0x0007E9BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetBytesFast(char* pChars, int charsLength, byte* pBytes, int bytesLength, out int charsConsumed)
		{
			int num = (int)Ascii.NarrowUtf16ToAscii(pChars, pBytes, (UIntPtr)Math.Min(charsLength, bytesLength));
			charsConsumed = num;
			return num;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000807E0 File Offset: 0x0007E9E0
		private protected unsafe sealed override int GetBytesWithFallback(ReadOnlySpan<char> chars, int originalCharsLength, Span<byte> bytes, int originalBytesLength, EncoderNLS encoder, bool throwForDestinationOverflow = true)
		{
			EncoderReplacementFallback encoderReplacementFallback = ((encoder == null) ? base.EncoderFallback : encoder.Fallback) as EncoderReplacementFallback;
			if (encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1 && Ascii.IsValid(encoderReplacementFallback.DefaultString[0]))
			{
				byte b = (byte)encoderReplacementFallback.DefaultString[0];
				int num = Math.Min(chars.Length, bytes.Length);
				int i = 0;
				while (i < num)
				{
					*bytes[i++] = b;
					if (i < num)
					{
						int num2;
						Ascii.FromUtf16(chars.Slice(i), bytes.Slice(i), out num2);
						i += num2;
					}
				}
				chars = chars.Slice(num);
				bytes = bytes.Slice(num);
			}
			if (chars.IsEmpty)
			{
				return originalBytesLength - bytes.Length;
			}
			return base.GetBytesWithFallback(chars, originalCharsLength, bytes, originalBytesLength, encoder, throwForDestinationOverflow);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000808BC File Offset: 0x0007EABC
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

		// Token: 0x06002928 RID: 10536 RVA: 0x0008091E File Offset: 0x0007EB1E
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

		// Token: 0x06002929 RID: 10537 RVA: 0x00080944 File Offset: 0x0007EB44
		public unsafe override int GetCharCount(ReadOnlySpan<byte> bytes)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* pBytes = reference;
				return this.GetCharCountCommon(pBytes, bytes.Length);
			}
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x0008096C File Offset: 0x0007EB6C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetCharCountCommon(byte* pBytes, int byteCount)
		{
			int num2;
			int num = this.GetCharCountFast(pBytes, byteCount, base.DecoderFallback, out num2);
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

		// Token: 0x0600292B RID: 10539 RVA: 0x000809A4 File Offset: 0x0007EBA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetCharCountFast(byte* pBytes, int bytesLength, DecoderFallback fallback, out int bytesConsumed)
		{
			int num = bytesLength;
			DecoderReplacementFallback decoderReplacementFallback = fallback as DecoderReplacementFallback;
			if (decoderReplacementFallback == null || decoderReplacementFallback.MaxCharCount != 1)
			{
				num = (int)Ascii.GetIndexOfFirstNonAsciiByte(pBytes, (UIntPtr)bytesLength);
			}
			bytesConsumed = num;
			return num;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000809D8 File Offset: 0x0007EBD8
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

		// Token: 0x0600292D RID: 10541 RVA: 0x00080A80 File Offset: 0x0007EC80
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

		// Token: 0x0600292E RID: 10542 RVA: 0x00080AD0 File Offset: 0x0007ECD0
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

		// Token: 0x0600292F RID: 10543 RVA: 0x00080B08 File Offset: 0x0007ED08
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

		// Token: 0x06002930 RID: 10544 RVA: 0x00080B54 File Offset: 0x0007ED54
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

		// Token: 0x06002931 RID: 10545 RVA: 0x00080B84 File Offset: 0x0007ED84
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetCharsFast(byte* pBytes, int bytesLength, char* pChars, int charsLength, out int bytesConsumed)
		{
			bytesConsumed = (int)Ascii.WidenAsciiToUtf16(pBytes, pChars, (UIntPtr)Math.Min(charsLength, bytesLength));
			return bytesConsumed;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00080BA0 File Offset: 0x0007EDA0
		private protected unsafe sealed override int GetCharsWithFallback(ReadOnlySpan<byte> bytes, int originalBytesLength, Span<char> chars, int originalCharsLength, DecoderNLS decoder, bool throwForDestinationOverflow = true)
		{
			DecoderReplacementFallback decoderReplacementFallback = ((decoder == null) ? base.DecoderFallback : decoder.Fallback) as DecoderReplacementFallback;
			if (decoderReplacementFallback != null && decoderReplacementFallback.MaxCharCount == 1)
			{
				char c = decoderReplacementFallback.DefaultString[0];
				int num = Math.Min(bytes.Length, chars.Length);
				int i = 0;
				while (i < num)
				{
					*chars[i++] = c;
					if (i < num)
					{
						int num2;
						Ascii.ToUtf16(bytes.Slice(i), chars.Slice(i), out num2);
						i += num2;
					}
				}
				bytes = bytes.Slice(num);
				chars = chars.Slice(num);
			}
			if (bytes.IsEmpty)
			{
				return originalCharsLength - chars.Length;
			}
			return base.GetCharsWithFallback(bytes, originalBytesLength, chars, originalCharsLength, decoder, throwForDestinationOverflow);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00080C64 File Offset: 0x0007EE64
		[NullableContext(1)]
		public unsafe override string GetString(byte[] bytes, int byteIndex, int byteCount)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes, ExceptionResource.ArgumentNull_Array);
			}
			if ((byteIndex | byteCount) < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException((byteIndex < 0) ? ExceptionArgument.byteIndex : ExceptionArgument.byteCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			if (bytes.Length - byteIndex < byteCount)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.bytes, ExceptionResource.ArgumentOutOfRange_IndexCountBuffer);
			}
			if (byteCount == 0)
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
			return string.CreateStringFromEncoding(ptr + byteIndex, byteCount, this);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00080CCF File Offset: 0x0007EECF
		internal sealed override bool TryGetByteCount(Rune value, out int byteCount)
		{
			if (value.IsAscii)
			{
				byteCount = 1;
				return true;
			}
			byteCount = 0;
			return false;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00080CE3 File Offset: 0x0007EEE3
		internal unsafe sealed override OperationStatus EncodeRune(Rune value, Span<byte> bytes, out int bytesWritten)
		{
			if (!value.IsAscii)
			{
				bytesWritten = 0;
				return OperationStatus.InvalidData;
			}
			if (!bytes.IsEmpty)
			{
				*bytes[0] = (byte)value.Value;
				bytesWritten = 1;
				return OperationStatus.Done;
			}
			bytesWritten = 0;
			return OperationStatus.DestinationTooSmall;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00080D18 File Offset: 0x0007EF18
		internal unsafe sealed override OperationStatus DecodeFirstRune(ReadOnlySpan<byte> bytes, out Rune value, out int bytesConsumed)
		{
			if (bytes.IsEmpty)
			{
				value = Rune.ReplacementChar;
				bytesConsumed = 0;
				return OperationStatus.NeedMoreData;
			}
			byte value2 = *bytes[0];
			if (Ascii.IsValid(value2))
			{
				value = new Rune((int)value2);
				bytesConsumed = 1;
				return OperationStatus.Done;
			}
			value = Rune.ReplacementChar;
			bytesConsumed = 1;
			return OperationStatus.InvalidData;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x00080D70 File Offset: 0x0007EF70
		public override int GetMaxByteCount(int charCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			long num = (long)charCount + 1L;
			if (base.EncoderFallback.MaxCharCount > 1)
			{
				num *= (long)base.EncoderFallback.MaxCharCount;
			}
			if (num > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("charCount", SR.ArgumentOutOfRange_GetByteCountOverflow);
			}
			return (int)num;
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x00080DC8 File Offset: 0x0007EFC8
		public override int GetMaxCharCount(int byteCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(byteCount, "byteCount");
			long num = (long)byteCount;
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

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsSingleByte
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00080E1B File Offset: 0x0007F01B
		[NullableContext(1)]
		public override Decoder GetDecoder()
		{
			return new DecoderNLS(this);
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00080E23 File Offset: 0x0007F023
		[NullableContext(1)]
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		// Token: 0x04000729 RID: 1833
		internal static readonly ASCIIEncoding.ASCIIEncodingSealed s_default = new ASCIIEncoding.ASCIIEncodingSealed();

		// Token: 0x02000211 RID: 529
		internal sealed class ASCIIEncodingSealed : ASCIIEncoding
		{
			// Token: 0x0600293D RID: 10557 RVA: 0x00080E37 File Offset: 0x0007F037
			public override object Clone()
			{
				return new ASCIIEncoding
				{
					IsReadOnly = false
				};
			}
		}
	}
}
