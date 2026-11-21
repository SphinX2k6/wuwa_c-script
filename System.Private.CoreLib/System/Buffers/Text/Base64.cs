using System;
using System.Runtime.CompilerServices;

namespace System.Buffers.Text
{
	// Token: 0x020003A4 RID: 932
	public static class Base64
	{
		// Token: 0x06003CF2 RID: 15602 RVA: 0x000CBBBC File Offset: 0x000C9DBC
		public static OperationStatus EncodeToUtf8(ReadOnlySpan<byte> bytes, Span<byte> utf8, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true)
		{
			return Base64Helper.EncodeTo<Base64Helper.Base64EncoderByte, byte>(default(Base64Helper.Base64EncoderByte), bytes, utf8, out bytesConsumed, out bytesWritten, isFinalBlock);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x000CBBDD File Offset: 0x000C9DDD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetMaxEncodedToUtf8Length(int length)
		{
			ArgumentOutOfRangeException.ThrowIfGreaterThan<uint>((uint)length, 1610612733U, "(uint)length");
			return (length + 2) / 3 * 4;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x000CBBF8 File Offset: 0x000C9DF8
		public static OperationStatus EncodeToUtf8InPlace(Span<byte> buffer, int dataLength, out int bytesWritten)
		{
			return Base64Helper.EncodeToUtf8InPlace<Base64Helper.Base64EncoderByte>(default(Base64Helper.Base64EncoderByte), buffer, dataLength, out bytesWritten);
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x000CBC18 File Offset: 0x000C9E18
		public static OperationStatus DecodeFromUtf8(ReadOnlySpan<byte> utf8, Span<byte> bytes, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true)
		{
			return Base64Helper.DecodeFrom<Base64Helper.Base64DecoderByte, byte>(default(Base64Helper.Base64DecoderByte), utf8, bytes, out bytesConsumed, out bytesWritten, isFinalBlock, true);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x000CBC3A File Offset: 0x000C9E3A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetMaxDecodedFromUtf8Length(int length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			return (length >> 2) * 3;
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x000CBC4C File Offset: 0x000C9E4C
		public static OperationStatus DecodeFromUtf8InPlace(Span<byte> buffer, out int bytesWritten)
		{
			return Base64Helper.DecodeFromUtf8InPlace<Base64Helper.Base64DecoderByte>(default(Base64Helper.Base64DecoderByte), buffer, out bytesWritten, true);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x000CBC6C File Offset: 0x000C9E6C
		public static bool IsValid(ReadOnlySpan<char> base64Text)
		{
			int num;
			return Base64Helper.IsValid<char, Base64Helper.Base64CharValidatable>(default(Base64Helper.Base64CharValidatable), base64Text, out num);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x000CBC8C File Offset: 0x000C9E8C
		public static bool IsValid(ReadOnlySpan<char> base64Text, out int decodedLength)
		{
			return Base64Helper.IsValid<char, Base64Helper.Base64CharValidatable>(default(Base64Helper.Base64CharValidatable), base64Text, out decodedLength);
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x000CBCAC File Offset: 0x000C9EAC
		public static bool IsValid(ReadOnlySpan<byte> base64TextUtf8)
		{
			int num;
			return Base64Helper.IsValid<byte, Base64Helper.Base64ByteValidatable>(default(Base64Helper.Base64ByteValidatable), base64TextUtf8, out num);
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x000CBCCC File Offset: 0x000C9ECC
		public static bool IsValid(ReadOnlySpan<byte> base64TextUtf8, out int decodedLength)
		{
			return Base64Helper.IsValid<byte, Base64Helper.Base64ByteValidatable>(default(Base64Helper.Base64ByteValidatable), base64TextUtf8, out decodedLength);
		}
	}
}
