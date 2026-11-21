using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text
{
	// Token: 0x02000230 RID: 560
	internal class Latin1Encoding : Encoding
	{
		// Token: 0x06002AC5 RID: 10949 RVA: 0x000858C0 File Offset: 0x00083AC0
		public Latin1Encoding() : base(28591)
		{
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000858D0 File Offset: 0x00083AD0
		public override ReadOnlySpan<byte> Preamble
		{
			get
			{
				return default(ReadOnlySpan<byte>);
			}
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000858E6 File Offset: 0x00083AE6
		internal sealed override void SetDefaultFallbacks()
		{
			this.encoderFallback = EncoderLatin1BestFitFallback.SingletonInstance;
			this.decoderFallback = DecoderFallback.ReplacementFallback;
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000858FE File Offset: 0x00083AFE
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

		// Token: 0x06002AC9 RID: 10953 RVA: 0x00085924 File Offset: 0x00083B24
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

		// Token: 0x06002ACA RID: 10954 RVA: 0x0008598C File Offset: 0x00083B8C
		public unsafe override int GetByteCount(ReadOnlySpan<char> chars)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(chars))
			{
				char* pChars = reference;
				return this.GetByteCountCommon(pChars, chars.Length);
			}
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000859B4 File Offset: 0x00083BB4
		public unsafe override int GetByteCount(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
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
			char* pChars = ptr;
			return this.GetByteCountCommon(pChars, s.Length);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000859EC File Offset: 0x00083BEC
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

		// Token: 0x06002ACD RID: 10957 RVA: 0x00085A20 File Offset: 0x00083C20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetByteCountFast(char* pChars, int charsLength, EncoderFallback fallback, out int charsConsumed)
		{
			int num = charsLength;
			if (!Latin1Encoding.FallbackSupportsFastGetByteCount(fallback))
			{
				num = (int)Latin1Utility.GetIndexOfFirstNonLatin1Char(pChars, (UIntPtr)charsLength);
			}
			charsConsumed = num;
			return num;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x00085A48 File Offset: 0x00083C48
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

		// Token: 0x06002ACF RID: 10959 RVA: 0x00085AA0 File Offset: 0x00083CA0
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

		// Token: 0x06002AD0 RID: 10960 RVA: 0x00085AF0 File Offset: 0x00083CF0
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

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00085B98 File Offset: 0x00083D98
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

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00085BD0 File Offset: 0x00083DD0
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

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00085C1C File Offset: 0x00083E1C
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

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00085CC0 File Offset: 0x00083EC0
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

		// Token: 0x06002AD5 RID: 10965 RVA: 0x00085CF0 File Offset: 0x00083EF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private protected unsafe sealed override int GetBytesFast(char* pChars, int charsLength, byte* pBytes, int bytesLength, out int charsConsumed)
		{
			int num = (int)Latin1Utility.NarrowUtf16ToLatin1(pChars, pBytes, (UIntPtr)Math.Min(charsLength, bytesLength));
			charsConsumed = num;
			return num;
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x00085D14 File Offset: 0x00083F14
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes);
			}
			if (count < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return count;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00085D30 File Offset: 0x00083F30
		public override int GetCharCount(byte[] bytes)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes);
			}
			return bytes.Length;
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00085D3F File Offset: 0x00083F3F
		public override int GetCharCount(byte[] bytes, int index, int count)
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
			return count;
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00085D75 File Offset: 0x00083F75
		public override int GetCharCount(ReadOnlySpan<byte> bytes)
		{
			return bytes.Length;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00085D7E File Offset: 0x00083F7E
		private protected unsafe override int GetCharCountFast(byte* pBytes, int bytesLength, DecoderFallback fallback, out int bytesConsumed)
		{
			bytesConsumed = bytesLength;
			return bytesLength;
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00085D85 File Offset: 0x00083F85
		public override int GetMaxCharCount(int byteCount)
		{
			if (byteCount < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.byteCount, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
			}
			return byteCount;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00085D98 File Offset: 0x00083F98
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
			return this.GetCharsCommon(bytes, byteCount, chars, charCount);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x00085DE4 File Offset: 0x00083FE4
		public unsafe override char[] GetChars(byte[] bytes)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes);
			}
			if (bytes.Length == 0)
			{
				return Array.Empty<char>();
			}
			char[] array = new char[bytes.Length];
			fixed (byte[] array2 = bytes)
			{
				byte* pBytes;
				if (bytes == null || array2.Length == 0)
				{
					pBytes = null;
				}
				else
				{
					pBytes = &array2[0];
				}
				char[] array3;
				char* pChars;
				if ((array3 = array) == null || array3.Length == 0)
				{
					pChars = null;
				}
				else
				{
					pChars = &array3[0];
				}
				this.GetCharsCommon(pBytes, bytes.Length, pChars, array.Length);
				array3 = null;
			}
			return array;
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00085E58 File Offset: 0x00084058
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
			return this.GetCharsCommon(ptr + byteIndex, byteCount, ptr2 + charIndex, chars.Length - charIndex);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x00085EFC File Offset: 0x000840FC
		public unsafe override char[] GetChars(byte[] bytes, int index, int count)
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
			char[] array = new char[count];
			fixed (byte[] array2 = bytes)
			{
				byte* ptr;
				if (bytes == null || array2.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array2[0];
				}
				char[] array3;
				char* pChars;
				if ((array3 = array) == null || array3.Length == 0)
				{
					pChars = null;
				}
				else
				{
					pChars = &array3[0];
				}
				this.GetCharsCommon(ptr + index, count, pChars, array.Length);
				array3 = null;
			}
			return array;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00085F8C File Offset: 0x0008418C
		public unsafe override int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
			{
				byte* pBytes = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
				{
					char* pChars = reference2;
					return this.GetCharsCommon(pBytes, bytes.Length, pChars, chars.Length);
				}
			}
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00085FC4 File Offset: 0x000841C4
		public unsafe override bool TryGetChars(ReadOnlySpan<byte> bytes, Span<char> chars, out int charsWritten)
		{
			if (bytes.Length <= chars.Length)
			{
				fixed (byte* reference = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* pBytes = reference;
					fixed (char* reference2 = MemoryMarshal.GetReference<char>(chars))
					{
						char* pChars = reference2;
						charsWritten = this.GetCharsCommon(pBytes, bytes.Length, pChars, chars.Length);
						return true;
					}
				}
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00086014 File Offset: 0x00084214
		public unsafe override string GetString(byte[] bytes)
		{
			if (bytes == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.bytes);
			}
			string text = string.FastAllocateString(bytes.Length);
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
				char* ptr;
				if (text == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = text.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* pChars = ptr;
				this.GetCharsCommon(pBytes, bytes.Length, pChars, text.Length);
				char* ptr2 = null;
			}
			return text;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00086078 File Offset: 0x00084278
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
			string text = string.FastAllocateString(count);
			fixed (byte[] array = bytes)
			{
				byte* ptr;
				if (bytes == null || array.Length == 0)
				{
					ptr = null;
				}
				else
				{
					ptr = &array[0];
				}
				char* ptr2;
				if (text == null)
				{
					ptr2 = null;
				}
				else
				{
					fixed (char* ptr3 = text.GetPinnableReference())
					{
						ptr2 = ptr3;
					}
				}
				char* pChars = ptr2;
				this.GetCharsCommon(ptr + index, count, pChars, count);
				char* ptr3 = null;
			}
			return text;
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000860FA File Offset: 0x000842FA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe int GetCharsCommon(byte* pBytes, int byteCount, char* pChars, int charCount)
		{
			if (byteCount > charCount)
			{
				base.ThrowCharsOverflow();
			}
			Latin1Utility.WidenLatin1ToUtf16(pBytes, pChars, (UIntPtr)byteCount);
			return byteCount;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00086114 File Offset: 0x00084314
		private protected unsafe sealed override int GetCharsFast(byte* pBytes, int bytesLength, char* pChars, int charsLength, out int bytesConsumed)
		{
			int num = Math.Min(bytesLength, charsLength);
			Latin1Utility.WidenLatin1ToUtf16(pBytes, pChars, (UIntPtr)num);
			bytesConsumed = num;
			return num;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x00080E1B File Offset: 0x0007F01B
		public override Decoder GetDecoder()
		{
			return new DecoderNLS(this);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x00080E23 File Offset: 0x0007F023
		public override Encoder GetEncoder()
		{
			return new EncoderNLS(this);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00086138 File Offset: 0x00084338
		internal sealed override bool TryGetByteCount(Rune value, out int byteCount)
		{
			if (value.Value <= 255)
			{
				byteCount = 1;
				return true;
			}
			byteCount = 0;
			return false;
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00086151 File Offset: 0x00084351
		internal unsafe sealed override OperationStatus EncodeRune(Rune value, Span<byte> bytes, out int bytesWritten)
		{
			if (value.Value > 255)
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

		// Token: 0x06002AEA RID: 10986 RVA: 0x0008618C File Offset: 0x0008438C
		internal unsafe sealed override OperationStatus DecodeFirstRune(ReadOnlySpan<byte> bytes, out Rune value, out int bytesConsumed)
		{
			if (!bytes.IsEmpty)
			{
				byte value2 = *bytes[0];
				value = new Rune((int)value2);
				bytesConsumed = 1;
				return OperationStatus.Done;
			}
			value = Rune.ReplacementChar;
			bytesConsumed = 0;
			return OperationStatus.NeedMoreData;
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002AEB RID: 10987 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsSingleByte
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x000861CC File Offset: 0x000843CC
		public override bool IsAlwaysNormalized(NormalizationForm form)
		{
			return form == NormalizationForm.FormC;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x000861D4 File Offset: 0x000843D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool FallbackSupportsFastGetByteCount(EncoderFallback fallback)
		{
			if (fallback == null)
			{
				return false;
			}
			if (fallback is EncoderLatin1BestFitFallback)
			{
				return true;
			}
			EncoderReplacementFallback encoderReplacementFallback = fallback as EncoderReplacementFallback;
			return encoderReplacementFallback != null && encoderReplacementFallback.MaxCharCount == 1 && encoderReplacementFallback.DefaultString[0] <= 'ÿ';
		}

		// Token: 0x0400078B RID: 1931
		internal static readonly Latin1Encoding.Latin1EncodingSealed s_default = new Latin1Encoding.Latin1EncodingSealed();

		// Token: 0x02000231 RID: 561
		internal sealed class Latin1EncodingSealed : Latin1Encoding
		{
			// Token: 0x06002AEF RID: 10991 RVA: 0x00086225 File Offset: 0x00084425
			public override object Clone()
			{
				return new Latin1Encoding
				{
					IsReadOnly = false
				};
			}
		}
	}
}
