using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace System.Buffers.Text
{
	// Token: 0x020003A5 RID: 933
	public static class Base64Url
	{
		// Token: 0x06003CFC RID: 15612 RVA: 0x000CBCEC File Offset: 0x000C9EEC
		public static int GetMaxDecodedLength(int base64Length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(base64Length, "base64Length");
			ValueTuple<uint, uint> valueTuple = uint.DivRem((uint)base64Length, 4U);
			uint item = valueTuple.Item1;
			uint item2 = valueTuple.Item2;
			return (int)(item * 3U + ((item2 > 0U) ? (item2 - 1U) : 0U));
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x000CBD28 File Offset: 0x000C9F28
		public static OperationStatus DecodeFromUtf8(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true)
		{
			return Base64Helper.DecodeFrom<Base64Url.Base64UrlDecoderByte, byte>(default(Base64Url.Base64UrlDecoderByte), source, destination, out bytesConsumed, out bytesWritten, isFinalBlock, true);
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x000CBD4C File Offset: 0x000C9F4C
		public static int DecodeFromUtf8InPlace(Span<byte> buffer)
		{
			int result;
			if (Base64Helper.DecodeFromUtf8InPlace<Base64Url.Base64UrlDecoderByte>(default(Base64Url.Base64UrlDecoderByte), buffer, out result, true) == OperationStatus.InvalidData)
			{
				throw new FormatException(SR.Format_BadBase64Char);
			}
			return result;
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x000CBD7C File Offset: 0x000C9F7C
		public static int DecodeFromUtf8(ReadOnlySpan<byte> source, Span<byte> destination)
		{
			int num;
			int result;
			OperationStatus operationStatus = Base64Url.DecodeFromUtf8(source, destination, out num, out result, true);
			if (operationStatus == OperationStatus.Done)
			{
				return result;
			}
			if (operationStatus == OperationStatus.DestinationTooSmall)
			{
				throw new ArgumentException(SR.Argument_DestinationTooShort, "destination");
			}
			throw new FormatException(SR.Format_BadBase64Char);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x000CBDBC File Offset: 0x000C9FBC
		public static bool TryDecodeFromUtf8(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			int num;
			OperationStatus operationStatus = Base64Url.DecodeFromUtf8(source, destination, out num, out bytesWritten, true);
			if (operationStatus == OperationStatus.InvalidData)
			{
				throw new FormatException(SR.Format_BadBase64Char);
			}
			return operationStatus == OperationStatus.Done;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x000CBDE8 File Offset: 0x000C9FE8
		[return: Nullable(1)]
		public unsafe static byte[] DecodeFromUtf8(ReadOnlySpan<byte> source)
		{
			int maxDecodedLength = Base64Url.GetMaxDecodedLength(source.Length);
			byte[] array = null;
			Span<byte> span;
			if (maxDecodedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxDecodedLength));
			}
			Span<byte> destination = span;
			int num;
			int length;
			bool flag = Base64Url.DecodeFromUtf8(source, destination, out num, out length, true) != OperationStatus.Done;
			byte[] result = destination.Slice(0, length).ToArray();
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (flag)
			{
				throw new FormatException(SR.Format_BadBase64Char);
			}
			return result;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x000CBE78 File Offset: 0x000CA078
		public static OperationStatus DecodeFromChars(ReadOnlySpan<char> source, Span<byte> destination, out int charsConsumed, out int bytesWritten, bool isFinalBlock = true)
		{
			return Base64Helper.DecodeFrom<Base64Url.Base64UrlDecoderChar, ushort>(default(Base64Url.Base64UrlDecoderChar), MemoryMarshal.Cast<char, ushort>(source), destination, out charsConsumed, out bytesWritten, isFinalBlock, true);
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x000CBEA0 File Offset: 0x000CA0A0
		private unsafe static OperationStatus DecodeWithWhiteSpaceBlockwise<TBase64Decoder>(TBase64Decoder decoder, ReadOnlySpan<ushort> source, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock = true) where TBase64Decoder : Base64Helper.IBase64Decoder<ushort>
		{
			Span<ushort> span = new Span<ushort>(stackalloc byte[(UIntPtr)8], 4);
			OperationStatus operationStatus = OperationStatus.Done;
			while (!source.IsEmpty)
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				while (num < source.Length && num2 < span.Length)
				{
					if (Base64Helper.IsWhiteSpace((int)(*source[num])))
					{
						num3++;
					}
					else
					{
						*span[num2] = *source[num];
						num2++;
					}
					num++;
				}
				source = source.Slice(num);
				bytesConsumed += num3;
				if (num2 != 0)
				{
					bool flag;
					if (decoder is Base64Helper.Base64DecoderByte)
					{
						flag = (source.Length >= 4);
					}
					else
					{
						flag = (source.Length > 1);
					}
					bool flag2 = !flag;
					if (flag && Base64Url.GetPaddingCount<TBase64Decoder>(decoder, span[3]) > 0)
					{
						flag = false;
						flag2 = true;
					}
					if (flag2 && !isFinalBlock)
					{
						flag2 = false;
					}
					int num4;
					int num5;
					operationStatus = Base64Helper.DecodeFrom<TBase64Decoder, ushort>(decoder, span.Slice(0, num2), bytes, out num4, out num5, flag2, false);
					bytesConsumed += num4;
					bytesWritten += num5;
					if (operationStatus != OperationStatus.Done)
					{
						return operationStatus;
					}
					if (!flag)
					{
						for (int i = 0; i < source.Length; i++)
						{
							if (!Base64Helper.IsWhiteSpace((int)(*source[i])))
							{
								bytesConsumed -= num4;
								bytesWritten -= num5;
								return OperationStatus.InvalidData;
							}
							bytesConsumed++;
						}
						break;
					}
					bytes = bytes.Slice(num5);
				}
			}
			return operationStatus;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x000CC00C File Offset: 0x000CA20C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static int GetPaddingCount<TBase64Decoder>(TBase64Decoder decoder, ref ushort ptrToLastElement) where TBase64Decoder : Base64Helper.IBase64Decoder<ushort>
		{
			int num = 0;
			if (decoder.IsValidPadding((uint)ptrToLastElement))
			{
				num++;
			}
			ref TBase64Decoder ptr = ref decoder;
			if (default(TBase64Decoder) == null)
			{
				TBase64Decoder tbase64Decoder = decoder;
				ptr = ref tbase64Decoder;
			}
			if (ptr.IsValidPadding((uint)(*Unsafe.Subtract<ushort>(ref ptrToLastElement, 1))))
			{
				num++;
			}
			return num;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x000CC064 File Offset: 0x000CA264
		public static int DecodeFromChars(ReadOnlySpan<char> source, Span<byte> destination)
		{
			int num;
			int result;
			OperationStatus operationStatus = Base64Url.DecodeFromChars(source, destination, out num, out result, true);
			if (operationStatus == OperationStatus.Done)
			{
				return result;
			}
			if (operationStatus == OperationStatus.DestinationTooSmall)
			{
				throw new ArgumentException(SR.Argument_DestinationTooShort, "destination");
			}
			throw new FormatException(SR.Format_BadBase64Char);
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x000CC0A4 File Offset: 0x000CA2A4
		public static bool TryDecodeFromChars(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten)
		{
			int num;
			OperationStatus operationStatus = Base64Url.DecodeFromChars(source, destination, out num, out bytesWritten, true);
			if (operationStatus == OperationStatus.InvalidData)
			{
				throw new FormatException(SR.Format_BadBase64Char);
			}
			return operationStatus == OperationStatus.Done;
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x000CC0D0 File Offset: 0x000CA2D0
		[return: Nullable(1)]
		public unsafe static byte[] DecodeFromChars(ReadOnlySpan<char> source)
		{
			int maxDecodedLength = Base64Url.GetMaxDecodedLength(source.Length);
			byte[] array = null;
			Span<byte> span;
			if (maxDecodedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxDecodedLength));
			}
			Span<byte> destination = span;
			int num;
			int length;
			bool flag = Base64Url.DecodeFromChars(source, destination, out num, out length, true) != OperationStatus.Done;
			byte[] result = destination.Slice(0, length).ToArray();
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (flag)
			{
				throw new FormatException(SR.Format_BadBase64Char);
			}
			return result;
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x000CC160 File Offset: 0x000CA360
		public static OperationStatus EncodeToUtf8(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true)
		{
			return Base64Helper.EncodeTo<Base64Url.Base64UrlEncoderByte, byte>(default(Base64Url.Base64UrlEncoderByte), source, destination, out bytesConsumed, out bytesWritten, isFinalBlock);
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x000CC184 File Offset: 0x000CA384
		public static int GetEncodedLength(int bytesLength)
		{
			ArgumentOutOfRangeException.ThrowIfGreaterThan<uint>((uint)bytesLength, 1610612733U, "(uint)bytesLength");
			ValueTuple<uint, uint> valueTuple = uint.DivRem((uint)bytesLength, 3U);
			uint item = valueTuple.Item1;
			uint item2 = valueTuple.Item2;
			return (int)(item * 4U + ((item2 > 0U) ? (item2 + 1U) : 0U));
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x000CC1C4 File Offset: 0x000CA3C4
		public static int EncodeToUtf8(ReadOnlySpan<byte> source, Span<byte> destination)
		{
			int num;
			int result;
			if (Base64Url.EncodeToUtf8(source, destination, out num, out result, true) == OperationStatus.Done)
			{
				return result;
			}
			throw new ArgumentException(SR.Argument_DestinationTooShort, "destination");
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x000CC1F0 File Offset: 0x000CA3F0
		[return: Nullable(1)]
		public static byte[] EncodeToUtf8(ReadOnlySpan<byte> source)
		{
			byte[] array = new byte[Base64Url.GetEncodedLength(source.Length)];
			int num;
			int num2;
			Base64Url.EncodeToUtf8(source, array, out num, out num2, true);
			return array;
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x000CC224 File Offset: 0x000CA424
		public static OperationStatus EncodeToChars(ReadOnlySpan<byte> source, Span<char> destination, out int bytesConsumed, out int charsWritten, bool isFinalBlock = true)
		{
			return Base64Helper.EncodeTo<Base64Url.Base64UrlEncoderChar, ushort>(default(Base64Url.Base64UrlEncoderChar), source, MemoryMarshal.Cast<char, ushort>(destination), out bytesConsumed, out charsWritten, isFinalBlock);
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x000CC24C File Offset: 0x000CA44C
		public static int EncodeToChars(ReadOnlySpan<byte> source, Span<char> destination)
		{
			int num;
			int result;
			if (Base64Url.EncodeToChars(source, destination, out num, out result, true) == OperationStatus.Done)
			{
				return result;
			}
			throw new ArgumentException(SR.Argument_DestinationTooShort, "destination");
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x000CC278 File Offset: 0x000CA478
		[return: Nullable(1)]
		public static char[] EncodeToChars(ReadOnlySpan<byte> source)
		{
			char[] array = new char[Base64Url.GetEncodedLength(source.Length)];
			int num;
			int num2;
			Base64Url.EncodeToChars(source, array, out num, out num2, true);
			return array;
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x000CC2AA File Offset: 0x000CA4AA
		[return: Nullable(1)]
		public unsafe static string EncodeToString(ReadOnlySpan<byte> source)
		{
			return string.Create<IntPtr>(Base64Url.GetEncodedLength(source.Length), &source, delegate(Span<char> buffer, IntPtr spanPtr)
			{
				int num;
				int num2;
				Base64Url.EncodeToChars(*spanPtr, buffer, out num, out num2, true);
			});
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x000CC2E0 File Offset: 0x000CA4E0
		public static bool TryEncodeToChars(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten)
		{
			int num;
			return Base64Url.EncodeToChars(source, destination, out num, out charsWritten, true) == OperationStatus.Done;
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x000CC2FC File Offset: 0x000CA4FC
		public static bool TryEncodeToUtf8(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			int num;
			return Base64Url.EncodeToUtf8(source, destination, out num, out bytesWritten, true) == OperationStatus.Done;
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x000CC318 File Offset: 0x000CA518
		public static bool TryEncodeToUtf8InPlace(Span<byte> buffer, int dataLength, out int bytesWritten)
		{
			return Base64Helper.EncodeToUtf8InPlace<Base64Url.Base64UrlEncoderByte>(default(Base64Url.Base64UrlEncoderByte), buffer, dataLength, out bytesWritten) == OperationStatus.Done;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x000CC33C File Offset: 0x000CA53C
		public static bool IsValid(ReadOnlySpan<char> base64UrlText)
		{
			int num;
			return Base64Helper.IsValid<char, Base64Url.Base64UrlCharValidatable>(default(Base64Url.Base64UrlCharValidatable), base64UrlText, out num);
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x000CC35C File Offset: 0x000CA55C
		public static bool IsValid(ReadOnlySpan<char> base64UrlText, out int decodedLength)
		{
			return Base64Helper.IsValid<char, Base64Url.Base64UrlCharValidatable>(default(Base64Url.Base64UrlCharValidatable), base64UrlText, out decodedLength);
		}

		// Token: 0x06003D15 RID: 15637 RVA: 0x000CC37C File Offset: 0x000CA57C
		public static bool IsValid(ReadOnlySpan<byte> utf8Base64UrlText)
		{
			int num;
			return Base64Helper.IsValid<byte, Base64Url.Base64UrlByteValidatable>(default(Base64Url.Base64UrlByteValidatable), utf8Base64UrlText, out num);
		}

		// Token: 0x06003D16 RID: 15638 RVA: 0x000CC39C File Offset: 0x000CA59C
		public static bool IsValid(ReadOnlySpan<byte> utf8Base64UrlText, out int decodedLength)
		{
			return Base64Helper.IsValid<byte, Base64Url.Base64UrlByteValidatable>(default(Base64Url.Base64UrlByteValidatable), utf8Base64UrlText, out decodedLength);
		}

		// Token: 0x020003A6 RID: 934
		private readonly struct Base64UrlDecoderByte : Base64Helper.IBase64Decoder<byte>
		{
			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06003D17 RID: 15639 RVA: 0x000CC3B9 File Offset: 0x000CA5B9
			public unsafe ReadOnlySpan<sbyte> DecodingMap
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.019F77B3D002A92270BB06E953AF99E78CDB700A200D48FA92C3C2761A7981FA), 256);
				}
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06003D18 RID: 15640 RVA: 0x000CC3CA File Offset: 0x000CA5CA
			public ReadOnlySpan<uint> VbmiLookup0
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.2A5F29F9A7E96F2A4E63D4E7C008ACF398C3757587C39E4B0213AA84A0F8134B4).FieldHandle);
				}
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06003D19 RID: 15641 RVA: 0x000CC3D6 File Offset: 0x000CA5D6
			public ReadOnlySpan<uint> VbmiLookup1
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.2F2A32F3653C4C968006A72ECBBB1AA0F708749525B56EA9E56BCB3E98E6802F4).FieldHandle);
				}
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x06003D1A RID: 15642 RVA: 0x000CC3E2 File Offset: 0x000CA5E2
			public unsafe ReadOnlySpan<sbyte> Avx2LutHigh
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.5F59740F3D304E9F125907FC35A1B3E6DB64928674E76615B9C64395001F47C6), 32);
				}
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x06003D1B RID: 15643 RVA: 0x000CC3F0 File Offset: 0x000CA5F0
			public unsafe ReadOnlySpan<sbyte> Avx2LutLow
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.59AEDF8133E78EA7A4BBCBE1AE6BEBAE12BCC035C6FD15AB9F1CB85DFB4355A3), 32);
				}
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06003D1C RID: 15644 RVA: 0x000CC3FE File Offset: 0x000CA5FE
			public unsafe ReadOnlySpan<sbyte> Avx2LutShift
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.F66CB51809504C49B2E7C18CF654E3B5EE50888ED30D93846F3E5BE37CBEC6D2), 32);
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x06003D1D RID: 15645 RVA: 0x000CC40C File Offset: 0x000CA60C
			public byte MaskSlashOrUnderscore
			{
				get
				{
					return 95;
				}
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x06003D1E RID: 15646 RVA: 0x000CC410 File Offset: 0x000CA610
			public ReadOnlySpan<int> Vector128LutHigh
			{
				get
				{
					return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.A4FF1D4AC2C9788D76AF0BA5AF9995969D9DBF2BEF85EFBD9C98685B997540044).FieldHandle);
				}
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x06003D1F RID: 15647 RVA: 0x000CC41C File Offset: 0x000CA61C
			public ReadOnlySpan<int> Vector128LutLow
			{
				get
				{
					return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.37E1536E87C491DAD7BE7AB8731692A0E1980A2B216292A31736F77C10FAABE04).FieldHandle);
				}
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06003D20 RID: 15648 RVA: 0x000CC428 File Offset: 0x000CA628
			public ReadOnlySpan<uint> Vector128LutShift
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.B7BD6A548D26C6014020BD89DE4A4402124CB1F2A34BB4C9CD97DC2D3CD34F684).FieldHandle);
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06003D21 RID: 15649 RVA: 0x000CC434 File Offset: 0x000CA634
			public ReadOnlySpan<uint> AdvSimdLutOne3
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.D8EB1688D420B9583C2D2EA1BD33B1DBEAF3C6EC6F03996C44C95260D94083FC4).FieldHandle);
				}
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x06003D22 RID: 15650 RVA: 0x000CC440 File Offset: 0x000CA640
			public uint AdvSimdLutTwo3Uint1
			{
				get
				{
					return 454754111U;
				}
			}

			// Token: 0x06003D23 RID: 15651 RVA: 0x000CC447 File Offset: 0x000CA647
			public int GetMaxDecodedLength(int sourceLength)
			{
				return Base64Url.GetMaxDecodedLength(sourceLength);
			}

			// Token: 0x06003D24 RID: 15652 RVA: 0x000CC44F File Offset: 0x000CA64F
			public bool IsInvalidLength(int bufferLength)
			{
				return (bufferLength & 3) == 1;
			}

			// Token: 0x06003D25 RID: 15653 RVA: 0x000CC458 File Offset: 0x000CA658
			public bool IsValidPadding(uint padChar)
			{
				return padChar == 37U || padChar == 61U;
			}

			// Token: 0x06003D26 RID: 15654 RVA: 0x000CC476 File Offset: 0x000CA676
			public int SrcLength(bool isFinalBlock, int sourceLength)
			{
				if (!isFinalBlock)
				{
					return sourceLength & -4;
				}
				return sourceLength;
			}

			// Token: 0x06003D27 RID: 15655 RVA: 0x000CC484 File Offset: 0x000CA684
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryDecode128Core(Vector128<byte> str, Vector128<byte> hiNibbles, Vector128<byte> maskSlashOrUnderscore, Vector128<byte> mask8F, Vector128<byte> lutLow, Vector128<byte> lutHigh, Vector128<sbyte> lutShift, Vector128<byte> shiftForUnderscore, out Vector128<byte> result)
			{
				Vector128<byte> right = Base64Helper.SimdShuffle(lutLow, hiNibbles, mask8F);
				Vector128<byte> right2 = Base64Helper.SimdShuffle(lutHigh, hiNibbles, mask8F);
				Vector128<byte> left = Vector128.LessThan<byte>(str, right);
				Vector128<byte> right3 = Vector128.GreaterThan<byte>(str, right2);
				Vector128<byte> vector = Vector128.Equals<byte>(str, maskSlashOrUnderscore);
				if (Vector128.AndNot<byte>(left | right3, vector) != Vector128<byte>.Zero)
				{
					result = default(Vector128<byte>);
					return false;
				}
				Vector128<byte> right4 = Base64Helper.SimdShuffle(lutShift.AsByte<sbyte>(), hiNibbles, mask8F);
				str += right4;
				result = str + (vector & shiftForUnderscore);
				return true;
			}

			// Token: 0x06003D28 RID: 15656 RVA: 0x000CC514 File Offset: 0x000CA714
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryDecode256Core(Vector256<sbyte> str, Vector256<sbyte> hiNibbles, Vector256<sbyte> maskSlashOrUnderscore, Vector256<sbyte> lutLow, Vector256<sbyte> lutHigh, Vector256<sbyte> lutShift, Vector256<sbyte> shiftForUnderscore, out Vector256<sbyte> result)
			{
				Vector256<sbyte> right = Avx2.Shuffle(lutLow, hiNibbles);
				Vector256<sbyte> right2 = Avx2.Shuffle(lutHigh, hiNibbles);
				Vector256<sbyte> left = Vector256.LessThan<sbyte>(str, right);
				Vector256<sbyte> right3 = Vector256.GreaterThan<sbyte>(str, right2);
				Vector256<sbyte> vector = Vector256.Equals<sbyte>(str, maskSlashOrUnderscore);
				if (Vector256.AndNot<sbyte>(left | right3, vector) != Vector256<sbyte>.Zero)
				{
					result = default(Vector256<sbyte>);
					return false;
				}
				Vector256<sbyte> right4 = Avx2.Shuffle(lutShift, hiNibbles);
				str += right4;
				result = str + (vector & shiftForUnderscore);
				return true;
			}

			// Token: 0x06003D29 RID: 15657 RVA: 0x000CC598 File Offset: 0x000CA798
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadVector512(byte* src, byte* srcStart, int sourceLength, out Vector512<sbyte> str)
			{
				return default(Base64Helper.Base64DecoderByte).TryLoadVector512(src, srcStart, sourceLength, out str);
			}

			// Token: 0x06003D2A RID: 15658 RVA: 0x000CC5B8 File Offset: 0x000CA7B8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadAvxVector256(byte* src, byte* srcStart, int sourceLength, out Vector256<sbyte> str)
			{
				return default(Base64Helper.Base64DecoderByte).TryLoadAvxVector256(src, srcStart, sourceLength, out str);
			}

			// Token: 0x06003D2B RID: 15659 RVA: 0x000CC5D8 File Offset: 0x000CA7D8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadVector128(byte* src, byte* srcStart, int sourceLength, out Vector128<byte> str)
			{
				return default(Base64Helper.Base64DecoderByte).TryLoadVector128(src, srcStart, sourceLength, out str);
			}

			// Token: 0x06003D2C RID: 15660 RVA: 0x000CC5F8 File Offset: 0x000CA7F8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadArmVector128x4(byte* src, byte* srcStart, int sourceLength, out Vector128<byte> str1, out Vector128<byte> str2, out Vector128<byte> str3, out Vector128<byte> str4)
			{
				return default(Base64Helper.Base64DecoderByte).TryLoadArmVector128x4(src, srcStart, sourceLength, out str1, out str2, out str3, out str4);
			}

			// Token: 0x06003D2D RID: 15661 RVA: 0x000CC620 File Offset: 0x000CA820
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int DecodeFourElements(byte* source, ref sbyte decodingMap)
			{
				return default(Base64Helper.Base64DecoderByte).DecodeFourElements(source, ref decodingMap);
			}

			// Token: 0x06003D2E RID: 15662 RVA: 0x000CC640 File Offset: 0x000CA840
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int DecodeRemaining(byte* srcEnd, ref sbyte decodingMap, long remaining, out uint t2, out uint t3)
			{
				return default(Base64Helper.Base64DecoderByte).DecodeRemaining(srcEnd, ref decodingMap, remaining, out t2, out t3);
			}

			// Token: 0x06003D2F RID: 15663 RVA: 0x000CC664 File Offset: 0x000CA864
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public int IndexOfAnyExceptWhiteSpace(ReadOnlySpan<byte> span)
			{
				return default(Base64Helper.Base64DecoderByte).IndexOfAnyExceptWhiteSpace(span);
			}

			// Token: 0x06003D30 RID: 15664 RVA: 0x000CB992 File Offset: 0x000C9B92
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public OperationStatus DecodeWithWhiteSpaceBlockwiseWrapper<TBase64Decoder>(TBase64Decoder decoder, ReadOnlySpan<byte> utf8, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock = true) where TBase64Decoder : Base64Helper.IBase64Decoder<byte>
			{
				return Base64Helper.DecodeWithWhiteSpaceBlockwise<TBase64Decoder>(decoder, utf8, bytes, ref bytesConsumed, ref bytesWritten, isFinalBlock);
			}
		}

		// Token: 0x020003A7 RID: 935
		private readonly struct Base64UrlDecoderChar : Base64Helper.IBase64Decoder<ushort>
		{
			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x06003D31 RID: 15665 RVA: 0x000CC680 File Offset: 0x000CA880
			public ReadOnlySpan<sbyte> DecodingMap
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).DecodingMap;
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06003D32 RID: 15666 RVA: 0x000CC69C File Offset: 0x000CA89C
			public ReadOnlySpan<uint> VbmiLookup0
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).VbmiLookup0;
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x06003D33 RID: 15667 RVA: 0x000CC6B8 File Offset: 0x000CA8B8
			public ReadOnlySpan<uint> VbmiLookup1
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).VbmiLookup1;
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x06003D34 RID: 15668 RVA: 0x000CC6D4 File Offset: 0x000CA8D4
			public ReadOnlySpan<sbyte> Avx2LutHigh
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).Avx2LutHigh;
				}
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06003D35 RID: 15669 RVA: 0x000CC6F0 File Offset: 0x000CA8F0
			public ReadOnlySpan<sbyte> Avx2LutLow
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).Avx2LutLow;
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06003D36 RID: 15670 RVA: 0x000CC70C File Offset: 0x000CA90C
			public ReadOnlySpan<sbyte> Avx2LutShift
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).Avx2LutShift;
				}
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06003D37 RID: 15671 RVA: 0x000CC728 File Offset: 0x000CA928
			public byte MaskSlashOrUnderscore
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).MaskSlashOrUnderscore;
				}
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x06003D38 RID: 15672 RVA: 0x000CC744 File Offset: 0x000CA944
			public ReadOnlySpan<int> Vector128LutHigh
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).Vector128LutHigh;
				}
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x06003D39 RID: 15673 RVA: 0x000CC760 File Offset: 0x000CA960
			public ReadOnlySpan<int> Vector128LutLow
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).Vector128LutLow;
				}
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x06003D3A RID: 15674 RVA: 0x000CC77C File Offset: 0x000CA97C
			public ReadOnlySpan<uint> Vector128LutShift
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).Vector128LutShift;
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x06003D3B RID: 15675 RVA: 0x000CC798 File Offset: 0x000CA998
			public ReadOnlySpan<uint> AdvSimdLutOne3
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).AdvSimdLutOne3;
				}
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x06003D3C RID: 15676 RVA: 0x000CC7B4 File Offset: 0x000CA9B4
			public uint AdvSimdLutTwo3Uint1
			{
				get
				{
					return default(Base64Url.Base64UrlDecoderByte).AdvSimdLutTwo3Uint1;
				}
			}

			// Token: 0x06003D3D RID: 15677 RVA: 0x000CC7D0 File Offset: 0x000CA9D0
			public int GetMaxDecodedLength(int sourceLength)
			{
				return default(Base64Url.Base64UrlDecoderByte).GetMaxDecodedLength(sourceLength);
			}

			// Token: 0x06003D3E RID: 15678 RVA: 0x000CC7EC File Offset: 0x000CA9EC
			public bool IsInvalidLength(int bufferLength)
			{
				return default(Base64Url.Base64UrlDecoderByte).IsInvalidLength(bufferLength);
			}

			// Token: 0x06003D3F RID: 15679 RVA: 0x000CC808 File Offset: 0x000CAA08
			public bool IsValidPadding(uint padChar)
			{
				return default(Base64Url.Base64UrlDecoderByte).IsValidPadding(padChar);
			}

			// Token: 0x06003D40 RID: 15680 RVA: 0x000CC824 File Offset: 0x000CAA24
			public int SrcLength(bool isFinalBlock, int sourceLength)
			{
				return default(Base64Url.Base64UrlDecoderByte).SrcLength(isFinalBlock, sourceLength);
			}

			// Token: 0x06003D41 RID: 15681 RVA: 0x000CC844 File Offset: 0x000CAA44
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryDecode128Core(Vector128<byte> str, Vector128<byte> hiNibbles, Vector128<byte> maskSlashOrUnderscore, Vector128<byte> mask8F, Vector128<byte> lutLow, Vector128<byte> lutHigh, Vector128<sbyte> lutShift, Vector128<byte> shiftForUnderscore, out Vector128<byte> result)
			{
				return default(Base64Url.Base64UrlDecoderByte).TryDecode128Core(str, hiNibbles, maskSlashOrUnderscore, mask8F, lutLow, lutHigh, lutShift, shiftForUnderscore, out result);
			}

			// Token: 0x06003D42 RID: 15682 RVA: 0x000CC870 File Offset: 0x000CAA70
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryDecode256Core(Vector256<sbyte> str, Vector256<sbyte> hiNibbles, Vector256<sbyte> maskSlashOrUnderscore, Vector256<sbyte> lutLow, Vector256<sbyte> lutHigh, Vector256<sbyte> lutShift, Vector256<sbyte> shiftForUnderscore, out Vector256<sbyte> result)
			{
				return default(Base64Url.Base64UrlDecoderByte).TryDecode256Core(str, hiNibbles, maskSlashOrUnderscore, lutLow, lutHigh, lutShift, shiftForUnderscore, out result);
			}

			// Token: 0x06003D43 RID: 15683 RVA: 0x000CC898 File Offset: 0x000CAA98
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadVector512(ushort* src, ushort* srcStart, int sourceLength, out Vector512<sbyte> str)
			{
				Vector512<ushort> vector = Vector512.Load<ushort>(src);
				Vector512<ushort> vector2 = Vector512.Load<ushort>(src + 32);
				if (Ascii.VectorContainsNonAsciiChar(vector | vector2))
				{
					str = default(Vector512<sbyte>);
					return false;
				}
				str = Vector512.Narrow(vector, vector2).AsSByte<byte>();
				return true;
			}

			// Token: 0x06003D44 RID: 15684 RVA: 0x000CC8E8 File Offset: 0x000CAAE8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadAvxVector256(ushort* src, ushort* srcStart, int sourceLength, out Vector256<sbyte> str)
			{
				Vector256<ushort> vector = Avx.LoadVector256(src);
				Vector256<ushort> vector2 = Avx.LoadVector256(src + 16);
				if (Ascii.VectorContainsNonAsciiChar(vector | vector2))
				{
					str = default(Vector256<sbyte>);
					return false;
				}
				str = Vector256.Narrow(vector, vector2).AsSByte<byte>();
				return true;
			}

			// Token: 0x06003D45 RID: 15685 RVA: 0x000CC938 File Offset: 0x000CAB38
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadVector128(ushort* src, ushort* srcStart, int sourceLength, out Vector128<byte> str)
			{
				Vector128<ushort> vector = Vector128.LoadUnsafe<ushort>(ref *src);
				Vector128<ushort> vector2 = Vector128.LoadUnsafe<ushort>(ref *src, (UIntPtr)((IntPtr)8));
				if (Ascii.VectorContainsNonAsciiChar(vector | vector2))
				{
					str = default(Vector128<byte>);
					return false;
				}
				str = Ascii.ExtractAsciiVector(vector, vector2);
				return true;
			}

			// Token: 0x06003D46 RID: 15686 RVA: 0x000CC97C File Offset: 0x000CAB7C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadArmVector128x4(ushort* src, ushort* srcStart, int sourceLength, out Vector128<byte> str1, out Vector128<byte> str2, out Vector128<byte> str3, out Vector128<byte> str4)
			{
				ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> valueTuple = AdvSimd.Arm64.Load4xVector128AndUnzip(src);
				Vector128<ushort> item = valueTuple.Item1;
				Vector128<ushort> item2 = valueTuple.Item2;
				Vector128<ushort> item3 = valueTuple.Item3;
				Vector128<ushort> item4 = valueTuple.Item4;
				ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>> valueTuple2 = AdvSimd.Arm64.Load4xVector128AndUnzip(src + 32);
				Vector128<ushort> item5 = valueTuple2.Item1;
				Vector128<ushort> item6 = valueTuple2.Item2;
				Vector128<ushort> item7 = valueTuple2.Item3;
				Vector128<ushort> item8 = valueTuple2.Item4;
				if (Ascii.VectorContainsNonAsciiChar(item | item2 | item3 | item4 | item5 | item6 | item7 | item8))
				{
					str1 = (str2 = (str3 = (str4 = default(Vector128<byte>))));
					return false;
				}
				str1 = Ascii.ExtractAsciiVector(item, item5);
				str2 = Ascii.ExtractAsciiVector(item2, item6);
				str3 = Ascii.ExtractAsciiVector(item3, item7);
				str4 = Ascii.ExtractAsciiVector(item4, item8);
				return true;
			}

			// Token: 0x06003D47 RID: 15687 RVA: 0x000CCA80 File Offset: 0x000CAC80
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int DecodeFourElements(ushort* source, ref sbyte decodingMap)
			{
				uint num = (uint)(*source);
				uint num2 = (uint)source[1];
				uint num3 = (uint)source[2];
				uint num4 = (uint)source[3];
				if (((num | num2 | num3 | num4) & 4294967040U) != 0U)
				{
					return -1;
				}
				int num5 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)num));
				int num6 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)num2));
				int num7 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)num3));
				int num8 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)num4));
				int num9 = num5 << 18;
				num6 <<= 12;
				num7 <<= 6;
				int num10 = num9 | num8;
				num6 |= num7;
				return num10 | num6;
			}

			// Token: 0x06003D48 RID: 15688 RVA: 0x000CCAFC File Offset: 0x000CACFC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int DecodeRemaining(ushort* srcEnd, ref sbyte decodingMap, long remaining, out uint t2, out uint t3)
			{
				t2 = 61U;
				t3 = 61U;
				long num = remaining - 2L;
				if (num <= 2L)
				{
					uint num2;
					uint num3;
					switch ((uint)num)
					{
					case 0U:
						num2 = (uint)srcEnd[-2];
						num3 = (uint)srcEnd[-1];
						break;
					case 1U:
						num2 = (uint)srcEnd[-3];
						num3 = (uint)srcEnd[-2];
						t2 = (uint)srcEnd[-1];
						break;
					case 2U:
						num2 = (uint)srcEnd[-4];
						num3 = (uint)srcEnd[-3];
						t2 = (uint)srcEnd[-2];
						t3 = (uint)srcEnd[-1];
						break;
					default:
						return -1;
					}
					if (((num2 | num3 | t2 | t3) & 4294967040U) != 0U)
					{
						return -1;
					}
					int num4 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (IntPtr)((UIntPtr)num2)));
					int num5 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (IntPtr)((UIntPtr)num3)));
					int num6 = num4 << 18;
					num5 <<= 12;
					return num6 | num5;
				}
				return -1;
			}

			// Token: 0x06003D49 RID: 15689 RVA: 0x000CCBC4 File Offset: 0x000CADC4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int IndexOfAnyExceptWhiteSpace(ReadOnlySpan<ushort> span)
			{
				for (int i = 0; i < span.Length; i++)
				{
					if (!Base64Helper.IsWhiteSpace((int)(*span[i])))
					{
						return i;
					}
				}
				return -1;
			}

			// Token: 0x06003D4A RID: 15690 RVA: 0x000CCBF6 File Offset: 0x000CADF6
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public OperationStatus DecodeWithWhiteSpaceBlockwiseWrapper<TBase64Decoder>(TBase64Decoder decoder, ReadOnlySpan<ushort> source, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock = true) where TBase64Decoder : Base64Helper.IBase64Decoder<ushort>
			{
				return Base64Url.DecodeWithWhiteSpaceBlockwise<TBase64Decoder>(decoder, source, bytes, ref bytesConsumed, ref bytesWritten, isFinalBlock);
			}
		}

		// Token: 0x020003A8 RID: 936
		private readonly struct Base64UrlEncoderByte : Base64Helper.IBase64Encoder<byte>
		{
			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x06003D4B RID: 15691 RVA: 0x000CCC06 File Offset: 0x000CAE06
			public unsafe ReadOnlySpan<byte> EncodingMap
			{
				get
				{
					return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.315CDEC2A8135FB5E2DE0DA4F4D5A2E949445B35242AB4A61FB32516F0D514B5), 64);
				}
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x06003D4C RID: 15692 RVA: 0x00059BE2 File Offset: 0x00057DE2
			public sbyte Avx2LutChar62
			{
				get
				{
					return -17;
				}
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x06003D4D RID: 15693 RVA: 0x0001A499 File Offset: 0x00018699
			public sbyte Avx2LutChar63
			{
				get
				{
					return 32;
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x06003D4E RID: 15694 RVA: 0x000CCC14 File Offset: 0x000CAE14
			public unsafe ReadOnlySpan<byte> AdvSimdLut4
			{
				get
				{
					return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.CCBD35E09BFFE193216F3D98BC2DF808DFC73128ED8C8B13BD9DCC090DBE5B63), 16);
				}
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x06003D4F RID: 15695 RVA: 0x000CCC22 File Offset: 0x000CAE22
			public uint Ssse3AdvSimdLutE3
			{
				get
				{
					return 8431U;
				}
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06003D50 RID: 15696 RVA: 0x000201B4 File Offset: 0x0001E3B4
			public int IncrementPadTwo
			{
				get
				{
					return 2;
				}
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06003D51 RID: 15697 RVA: 0x0001FC46 File Offset: 0x0001DE46
			public int IncrementPadOne
			{
				get
				{
					return 3;
				}
			}

			// Token: 0x06003D52 RID: 15698 RVA: 0x000CCC29 File Offset: 0x000CAE29
			public int GetMaxSrcLength(int srcLength, int destLength)
			{
				if (srcLength > 1610612733 || destLength < Base64Url.GetEncodedLength(srcLength))
				{
					return Base64Url.GetMaxDecodedLength(destLength);
				}
				return srcLength;
			}

			// Token: 0x06003D53 RID: 15699 RVA: 0x000CCC44 File Offset: 0x000CAE44
			public uint GetInPlaceDestinationLength(int encodedLength, int leftOver)
			{
				if (leftOver <= 0)
				{
					return (uint)(encodedLength - 4);
				}
				return (uint)(encodedLength - leftOver - 1);
			}

			// Token: 0x06003D54 RID: 15700 RVA: 0x000CCC53 File Offset: 0x000CAE53
			public int GetMaxEncodedLength(int srcLength)
			{
				return Base64Url.GetEncodedLength(srcLength);
			}

			// Token: 0x06003D55 RID: 15701 RVA: 0x000CCC5C File Offset: 0x000CAE5C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeOneOptionallyPadTwo(byte* oneByte, byte* dest, ref byte encodingMap)
			{
				uint num = (uint)((uint)(*oneByte) << 8);
				byte b = *Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num >> 10)));
				byte b2 = *Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num >> 4 & 63U)));
				bool isLittleEndian = BitConverter.IsLittleEndian;
				ushort value = (ushort)((int)b | (int)b2 << 8);
				Unsafe.WriteUnaligned<ushort>((void*)dest, value);
			}

			// Token: 0x06003D56 RID: 15702 RVA: 0x000CCCA0 File Offset: 0x000CAEA0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeTwoOptionallyPadOne(byte* twoBytes, byte* dest, ref byte encodingMap)
			{
				uint num = (uint)(*twoBytes);
				uint num2 = (uint)twoBytes[1];
				uint num3 = num << 16 | num2 << 8;
				byte b = *Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 18)));
				byte b2 = *Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 12 & 63U)));
				byte b3 = *Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 6 & 63U)));
				*dest = b;
				dest[1] = b2;
				dest[2] = b3;
			}

			// Token: 0x06003D57 RID: 15703 RVA: 0x000CCCF8 File Offset: 0x000CAEF8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector512ToDestination(byte* dest, byte* destStart, int destLength, Vector512<byte> str)
			{
				default(Base64Helper.Base64EncoderByte).StoreVector512ToDestination(dest, destStart, destLength, str);
			}

			// Token: 0x06003D58 RID: 15704 RVA: 0x000CCD18 File Offset: 0x000CAF18
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector256ToDestination(byte* dest, byte* destStart, int destLength, Vector256<byte> str)
			{
				default(Base64Helper.Base64EncoderByte).StoreVector256ToDestination(dest, destStart, destLength, str);
			}

			// Token: 0x06003D59 RID: 15705 RVA: 0x000CCD38 File Offset: 0x000CAF38
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector128ToDestination(byte* dest, byte* destStart, int destLength, Vector128<byte> str)
			{
				default(Base64Helper.Base64EncoderByte).StoreVector128ToDestination(dest, destStart, destLength, str);
			}

			// Token: 0x06003D5A RID: 15706 RVA: 0x000CCD58 File Offset: 0x000CAF58
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreArmVector128x4ToDestination(byte* dest, byte* destStart, int destLength, Vector128<byte> res1, Vector128<byte> res2, Vector128<byte> res3, Vector128<byte> res4)
			{
				default(Base64Helper.Base64EncoderByte).StoreArmVector128x4ToDestination(dest, destStart, destLength, res1, res2, res3, res4);
			}

			// Token: 0x06003D5B RID: 15707 RVA: 0x000CCD80 File Offset: 0x000CAF80
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeThreeAndWrite(byte* threeBytes, byte* destination, ref byte encodingMap)
			{
				default(Base64Helper.Base64EncoderByte).EncodeThreeAndWrite(threeBytes, destination, ref encodingMap);
			}
		}

		// Token: 0x020003A9 RID: 937
		private readonly struct Base64UrlEncoderChar : Base64Helper.IBase64Encoder<ushort>
		{
			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06003D5C RID: 15708 RVA: 0x000CCDA0 File Offset: 0x000CAFA0
			public ReadOnlySpan<byte> EncodingMap
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).EncodingMap;
				}
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x06003D5D RID: 15709 RVA: 0x000CCDBC File Offset: 0x000CAFBC
			public sbyte Avx2LutChar62
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).Avx2LutChar62;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x06003D5E RID: 15710 RVA: 0x000CCDD8 File Offset: 0x000CAFD8
			public sbyte Avx2LutChar63
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).Avx2LutChar63;
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06003D5F RID: 15711 RVA: 0x000CCDF4 File Offset: 0x000CAFF4
			public ReadOnlySpan<byte> AdvSimdLut4
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).AdvSimdLut4;
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06003D60 RID: 15712 RVA: 0x000CCE10 File Offset: 0x000CB010
			public uint Ssse3AdvSimdLutE3
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).Ssse3AdvSimdLutE3;
				}
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x06003D61 RID: 15713 RVA: 0x000CCE2C File Offset: 0x000CB02C
			public int IncrementPadTwo
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).IncrementPadTwo;
				}
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x06003D62 RID: 15714 RVA: 0x000CCE48 File Offset: 0x000CB048
			public int IncrementPadOne
			{
				get
				{
					return default(Base64Url.Base64UrlEncoderByte).IncrementPadOne;
				}
			}

			// Token: 0x06003D63 RID: 15715 RVA: 0x000CCE64 File Offset: 0x000CB064
			public int GetMaxSrcLength(int srcLength, int destLength)
			{
				return default(Base64Url.Base64UrlEncoderByte).GetMaxSrcLength(srcLength, destLength);
			}

			// Token: 0x06003D64 RID: 15716 RVA: 0x00007B65 File Offset: 0x00005D65
			public uint GetInPlaceDestinationLength(int encodedLength, int _)
			{
				return 0U;
			}

			// Token: 0x06003D65 RID: 15717 RVA: 0x00007B65 File Offset: 0x00005D65
			public int GetMaxEncodedLength(int _)
			{
				return 0;
			}

			// Token: 0x06003D66 RID: 15718 RVA: 0x000CCE84 File Offset: 0x000CB084
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeOneOptionallyPadTwo(byte* oneByte, ushort* dest, ref byte encodingMap)
			{
				uint num = (uint)((uint)(*oneByte) << 8);
				uint num2 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num >> 10))));
				uint num3 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num >> 4 & 63U))));
				bool isLittleEndian = BitConverter.IsLittleEndian;
				uint value = num2 | num3 << 16;
				Unsafe.WriteUnaligned<uint>((void*)dest, value);
			}

			// Token: 0x06003D67 RID: 15719 RVA: 0x000CCEC8 File Offset: 0x000CB0C8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeTwoOptionallyPadOne(byte* twoBytes, ushort* dest, ref byte encodingMap)
			{
				uint num = (uint)(*twoBytes);
				uint num2 = (uint)twoBytes[1];
				uint num3 = num << 16 | num2 << 8;
				ushort num4 = (ushort)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 18))));
				ushort num5 = (ushort)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 12 & 63U))));
				ushort num6 = (ushort)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 6 & 63U))));
				*dest = num4;
				dest[1] = num5;
				dest[2] = num6;
			}

			// Token: 0x06003D68 RID: 15720 RVA: 0x000CCF24 File Offset: 0x000CB124
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector512ToDestination(ushort* dest, ushort* destStart, int destLength, Vector512<byte> str)
			{
				ValueTuple<Vector512<ushort>, Vector512<ushort>> valueTuple = Vector512.Widen(str);
				Vector512<ushort> item = valueTuple.Item1;
				Vector512<ushort> item2 = valueTuple.Item2;
				item.Store(dest);
				item2.Store(dest + Vector512<ushort>.Count);
			}

			// Token: 0x06003D69 RID: 15721 RVA: 0x000CCF5C File Offset: 0x000CB15C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector256ToDestination(ushort* dest, ushort* destStart, int destLength, Vector256<byte> str)
			{
				ValueTuple<Vector256<ushort>, Vector256<ushort>> valueTuple = Vector256.Widen(str);
				Vector256<ushort> item = valueTuple.Item1;
				Vector256<ushort> item2 = valueTuple.Item2;
				item.Store(dest);
				item2.Store(dest + Vector256<ushort>.Count);
			}

			// Token: 0x06003D6A RID: 15722 RVA: 0x000CCF94 File Offset: 0x000CB194
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector128ToDestination(ushort* dest, ushort* destStart, int destLength, Vector128<byte> str)
			{
				ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple = Vector128.Widen(str);
				Vector128<ushort> item = valueTuple.Item1;
				Vector128<ushort> item2 = valueTuple.Item2;
				item.Store(dest);
				item2.Store(dest + Vector128<ushort>.Count);
			}

			// Token: 0x06003D6B RID: 15723 RVA: 0x000CCFCC File Offset: 0x000CB1CC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreArmVector128x4ToDestination(ushort* dest, ushort* destStart, int destLength, Vector128<byte> res1, Vector128<byte> res2, Vector128<byte> res3, Vector128<byte> res4)
			{
				ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple = Vector128.Widen(res1);
				Vector128<ushort> item = valueTuple.Item1;
				Vector128<ushort> item2 = valueTuple.Item2;
				ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple2 = Vector128.Widen(res2);
				Vector128<ushort> item3 = valueTuple2.Item1;
				Vector128<ushort> item4 = valueTuple2.Item2;
				ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple3 = Vector128.Widen(res3);
				Vector128<ushort> item5 = valueTuple3.Item1;
				Vector128<ushort> item6 = valueTuple3.Item2;
				ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple4 = Vector128.Widen(res4);
				Vector128<ushort> item7 = valueTuple4.Item1;
				Vector128<ushort> item8 = valueTuple4.Item2;
				AdvSimd.Arm64.StoreVectorAndZip(dest, new ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>(item, item3, item5, item7));
				AdvSimd.Arm64.StoreVectorAndZip(dest + 32, new ValueTuple<Vector128<ushort>, Vector128<ushort>, Vector128<ushort>, Vector128<ushort>>(item2, item4, item6, item8));
			}

			// Token: 0x06003D6C RID: 15724 RVA: 0x000CD058 File Offset: 0x000CB258
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeThreeAndWrite(byte* threeBytes, ushort* destination, ref byte encodingMap)
			{
				uint num = (uint)(*threeBytes);
				uint num2 = (uint)threeBytes[1];
				uint num3 = (uint)threeBytes[2];
				uint num4 = num << 16 | num2 << 8 | num3;
				ulong num5 = (ulong)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 >> 18))));
				ulong num6 = (ulong)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 >> 12 & 63U))));
				ulong num7 = (ulong)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 >> 6 & 63U))));
				ulong num8 = (ulong)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 & 63U))));
				bool isLittleEndian = BitConverter.IsLittleEndian;
				ulong value = num5 | num6 << 16 | num7 << 32 | num8 << 48;
				Unsafe.WriteUnaligned<ulong>((void*)destination, value);
			}
		}

		// Token: 0x020003AA RID: 938
		private readonly struct Base64UrlCharValidatable : Base64Helper.IBase64Validatable<char>
		{
			// Token: 0x06003D6D RID: 15725 RVA: 0x000CD0E0 File Offset: 0x000CB2E0
			public int IndexOfAnyExcept(ReadOnlySpan<char> span)
			{
				return span.IndexOfAnyExcept(Base64Url.Base64UrlCharValidatable.s_validBase64UrlChars);
			}

			// Token: 0x06003D6E RID: 15726 RVA: 0x000CB9AF File Offset: 0x000C9BAF
			public bool IsWhiteSpace(char value)
			{
				return Base64Helper.IsWhiteSpace((int)value);
			}

			// Token: 0x06003D6F RID: 15727 RVA: 0x000CD0ED File Offset: 0x000CB2ED
			public bool IsEncodingPad(char value)
			{
				return value == '=' || value == '%';
			}

			// Token: 0x06003D70 RID: 15728 RVA: 0x000CD0FC File Offset: 0x000CB2FC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool ValidateAndDecodeLength(char lastChar, int length, int paddingCount, out int decodedLength)
			{
				return default(Base64Url.Base64UrlByteValidatable).ValidateAndDecodeLength((byte)lastChar, length, paddingCount, out decodedLength);
			}

			// Token: 0x04000CC9 RID: 3273
			private static readonly SearchValues<char> s_validBase64UrlChars = SearchValues.Create("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_");
		}

		// Token: 0x020003AB RID: 939
		private readonly struct Base64UrlByteValidatable : Base64Helper.IBase64Validatable<byte>
		{
			// Token: 0x06003D72 RID: 15730 RVA: 0x000CD133 File Offset: 0x000CB333
			public int IndexOfAnyExcept(ReadOnlySpan<byte> span)
			{
				return span.IndexOfAnyExcept(Base64Url.Base64UrlByteValidatable.s_validBase64UrlChars);
			}

			// Token: 0x06003D73 RID: 15731 RVA: 0x000CB9AF File Offset: 0x000C9BAF
			public bool IsWhiteSpace(byte value)
			{
				return Base64Helper.IsWhiteSpace((int)value);
			}

			// Token: 0x06003D74 RID: 15732 RVA: 0x000CD0ED File Offset: 0x000CB2ED
			public bool IsEncodingPad(byte value)
			{
				return value == 61 || value == 37;
			}

			// Token: 0x06003D75 RID: 15733 RVA: 0x000CD140 File Offset: 0x000CB340
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool ValidateAndDecodeLength(byte lastChar, int length, int paddingCount, out int decodedLength)
			{
				int num = length % 4;
				if (paddingCount != 0)
				{
					length -= paddingCount;
					num = length % 4;
					if (num == 0 || num + paddingCount > 4)
					{
						decodedLength = 0;
						return false;
					}
				}
				decodedLength = (length >> 2) * 3 + ((num > 0) ? (num - 1) : 0);
				if (num > 0)
				{
					int num2 = (int)(*default(Base64Url.Base64UrlDecoderByte).DecodingMap[(int)lastChar]);
					switch (num)
					{
					case 1:
						return false;
					case 2:
						return (num2 & 15) == 0;
					case 3:
						return (num2 & 3) == 0;
					}
				}
				return true;
			}

			// Token: 0x04000CCA RID: 3274
			private static readonly SearchValues<byte> s_validBase64UrlChars = SearchValues.Create(default(Base64Url.Base64UrlEncoderByte).EncodingMap);
		}
	}
}
