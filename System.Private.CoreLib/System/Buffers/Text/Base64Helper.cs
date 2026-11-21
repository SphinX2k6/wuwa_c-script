using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace System.Buffers.Text
{
	// Token: 0x0200039C RID: 924
	internal static class Base64Helper
	{
		// Token: 0x06003C7E RID: 15486 RVA: 0x000CA330 File Offset: 0x000C8530
		internal unsafe static OperationStatus DecodeFrom<TBase64Decoder, [IsUnmanaged] T>(TBase64Decoder decoder, ReadOnlySpan<T> source, Span<byte> bytes, out int bytesConsumed, out int bytesWritten, bool isFinalBlock, bool ignoreWhiteSpace) where TBase64Decoder : Base64Helper.IBase64Decoder<T> where T : struct, ValueType
		{
			if (source.IsEmpty)
			{
				bytesConsumed = 0;
				bytesWritten = 0;
				return OperationStatus.Done;
			}
			fixed (T* reference = MemoryMarshal.GetReference<T>(source))
			{
				T* ptr = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(bytes))
				{
					byte* ptr2 = reference2;
					ref TBase64Decoder ptr3 = ref decoder;
					if (default(TBase64Decoder) == null)
					{
						TBase64Decoder tbase64Decoder = decoder;
						ptr3 = ref tbase64Decoder;
					}
					int num = ptr3.SrcLength(isFinalBlock, source.Length);
					int length = bytes.Length;
					int num2 = num;
					int maxDecodedLength = decoder.GetMaxDecodedLength(num);
					if (length < maxDecodedLength - 2)
					{
						num2 = length / 3 * 4;
					}
					T* ptr4 = ptr;
					byte* ptr5 = ptr2;
					T* ptr6 = ptr + (ulong)num * (ulong)((long)sizeof(T)) / (ulong)sizeof(T);
					T* ptr7 = ptr + (ulong)num2 * (ulong)((long)sizeof(T)) / (ulong)sizeof(T);
					if (num2 >= 24)
					{
						T* ptr8 = ptr7 - (IntPtr)88 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
						if (false)
						{
						}
						ptr8 = ptr7 - (IntPtr)45 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
						if (false)
						{
						}
						ptr8 = ptr7 - (IntPtr)66 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
						if (false)
						{
						}
						ptr8 = ptr7 - (IntPtr)24 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
						if (Ssse3.IsSupported || false)
						{
							bool isLittleEndian = BitConverter.IsLittleEndian;
							if (ptr8 >= ptr4)
							{
								Base64Helper.Vector128Decode<TBase64Decoder, T>(decoder, ref ptr4, ref ptr5, ptr8, num2, length, ptr, ptr2);
								if (ptr4 == ptr6)
								{
									goto IL_35D;
								}
							}
						}
					}
					int num3 = isFinalBlock ? 4 : 0;
					if (length >= maxDecodedLength)
					{
						num2 = num - num3;
					}
					else
					{
						ValueTuple<int, int> valueTuple = int.DivRem(length, 3);
						num2 = valueTuple.Item1;
						int item = valueTuple.Item2;
						num2 *= 4;
						if (isFinalBlock && item > 0)
						{
							num &= -4;
						}
					}
					ref sbyte reference3 = ref MemoryMarshal.GetReference<sbyte>(decoder.DecodingMap);
					ptr7 = ptr + (IntPtr)num2 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
					while (ptr4 < ptr7)
					{
						int num4 = decoder.DecodeFourElements(ptr4, ref reference3);
						if (num4 >= 0)
						{
							Base64Helper.WriteThreeLowOrderBytes(ptr5, num4);
							ptr4 += (IntPtr)4 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
							ptr5 += 3;
						}
						else
						{
							IL_3C4:
							bytesConsumed = (int)((long)((ptr4 - ptr) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
							bytesWritten = (int)((long)(ptr5 - ptr2));
							if (!ignoreWhiteSpace)
							{
								return OperationStatus.InvalidData;
							}
							return Base64Helper.<DecodeFrom>g__InvalidDataFallback|0_0<TBase64Decoder, T>(decoder, source, bytes, ref bytesConsumed, ref bytesWritten, isFinalBlock);
						}
					}
					if (num2 == num - num3)
					{
						if (ptr4 == ptr6)
						{
							if (isFinalBlock)
							{
								goto IL_3C4;
							}
							if (ptr4 == ptr + (IntPtr)source.Length * (IntPtr)sizeof(T) / (IntPtr)sizeof(T))
							{
								goto IL_35D;
							}
							bytesConsumed = (int)((long)((ptr4 - ptr) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
							bytesWritten = (int)((long)(ptr5 - ptr2));
							return OperationStatus.NeedMoreData;
						}
						else
						{
							long num5 = (long)((ptr6 - ptr4) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T));
							uint num7;
							uint num8;
							int num6 = decoder.DecodeRemaining(ptr6, ref reference3, num5, out num7, out num8);
							byte* ptr9 = ptr2 + length;
							if (!decoder.IsValidPadding(num8))
							{
								int num9 = (int)(*Unsafe.Add<sbyte>(ref reference3, (IntPtr)((UIntPtr)num7)));
								int num10 = (int)(*Unsafe.Add<sbyte>(ref reference3, (IntPtr)((UIntPtr)num8)));
								num9 <<= 6;
								num6 |= num10;
								num6 |= num9;
								if (num6 < 0)
								{
									goto IL_3C4;
								}
								if (ptr5 + 3 != ptr9)
								{
									goto IL_379;
								}
								Base64Helper.WriteThreeLowOrderBytes(ptr5, num6);
								ptr5 += 3;
								ptr4 += (IntPtr)4 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
							}
							else if (!decoder.IsValidPadding(num7))
							{
								int num11 = (int)(*Unsafe.Add<sbyte>(ref reference3, (IntPtr)((UIntPtr)num7)));
								num11 <<= 6;
								num6 |= num11;
								if (((long)num6 & (long)((ulong)-2147483456)) != 0L)
								{
									goto IL_3C4;
								}
								if (ptr5 + 2 != ptr9)
								{
									goto IL_379;
								}
								*ptr5 = (byte)(num6 >> 16);
								ptr5[1] = (byte)(num6 >> 8);
								ptr5 += 2;
								ptr4 += num5 * (long)sizeof(T) / (long)sizeof(T);
							}
							else
							{
								if (((long)num6 & (long)((ulong)-2147422208)) != 0L)
								{
									goto IL_3C4;
								}
								if (ptr5 + 1 != ptr9)
								{
									goto IL_379;
								}
								*ptr5 = (byte)(num6 >> 16);
								ptr5++;
								ptr4 += num5 * (long)sizeof(T) / (long)sizeof(T);
							}
							if (num == source.Length)
							{
								goto IL_35D;
							}
							goto IL_3C4;
						}
					}
					IL_379:
					if (num == source.Length || !isFinalBlock)
					{
						bytesConsumed = (int)((long)((ptr4 - ptr) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
						bytesWritten = (int)((long)(ptr5 - ptr2));
						return OperationStatus.DestinationTooSmall;
					}
					goto IL_3C4;
					IL_35D:
					bytesConsumed = (int)((long)((ptr4 - ptr) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
					bytesWritten = (int)((long)(ptr5 - ptr2));
					return OperationStatus.Done;
				}
			}
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x000CA730 File Offset: 0x000C8930
		internal unsafe static OperationStatus DecodeFromUtf8InPlace<TBase64Decoder>(TBase64Decoder decoder, Span<byte> buffer, out int bytesWritten, bool ignoreWhiteSpace) where TBase64Decoder : Base64Helper.IBase64Decoder<byte>
		{
			if (buffer.IsEmpty)
			{
				bytesWritten = 0;
				return OperationStatus.Done;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* ptr = reference;
				uint length = (uint)buffer.Length;
				uint num = 0U;
				uint num2 = 0U;
				ref TBase64Decoder ptr2 = ref decoder;
				if (default(TBase64Decoder) == null)
				{
					TBase64Decoder tbase64Decoder = decoder;
					ptr2 = ref tbase64Decoder;
				}
				if (!ptr2.IsInvalidLength(buffer.Length))
				{
					ref sbyte reference2 = ref MemoryMarshal.GetReference<sbyte>(decoder.DecodingMap);
					if (length > 4U)
					{
						while (num < length - 4U)
						{
							int num3 = decoder.DecodeFourElements(ptr + num, ref reference2);
							if (num3 < 0)
							{
								goto IL_22C;
							}
							Base64Helper.WriteThreeLowOrderBytes(ptr + num2, num3);
							num2 += 3U;
							num += 4U;
						}
					}
					uint elementOffset;
					uint elementOffset2;
					uint num4;
					uint num5;
					switch (length - num)
					{
					case 2U:
						elementOffset = (uint)ptr[length - 2U];
						elementOffset2 = (uint)ptr[length - 1U];
						num4 = 61U;
						num5 = 61U;
						break;
					case 3U:
						elementOffset = (uint)ptr[length - 3U];
						elementOffset2 = (uint)ptr[length - 2U];
						num4 = (uint)ptr[length - 1U];
						num5 = 61U;
						break;
					case 4U:
						elementOffset = (uint)ptr[length - 4U];
						elementOffset2 = (uint)ptr[length - 3U];
						num4 = (uint)ptr[length - 2U];
						num5 = (uint)ptr[length - 1U];
						break;
					default:
						goto IL_22C;
					}
					int num6 = (int)(*Unsafe.Add<sbyte>(ref reference2, (int)elementOffset));
					int num7 = (int)(*Unsafe.Add<sbyte>(ref reference2, (int)elementOffset2));
					num6 <<= 18;
					num7 <<= 12;
					num6 |= num7;
					if (!decoder.IsValidPadding(num5))
					{
						int num8 = (int)(*Unsafe.Add<sbyte>(ref reference2, (int)num4));
						int num9 = (int)(*Unsafe.Add<sbyte>(ref reference2, (int)num5));
						num8 <<= 6;
						num6 |= num9;
						num6 |= num8;
						if (num6 < 0)
						{
							goto IL_22C;
						}
						Base64Helper.WriteThreeLowOrderBytes(ptr + num2, num6);
						num2 += 3U;
					}
					else if (!decoder.IsValidPadding(num4))
					{
						int num10 = (int)(*Unsafe.Add<sbyte>(ref reference2, (int)num4));
						num10 <<= 6;
						num6 |= num10;
						if (((long)num6 & (long)((ulong)-2147483456)) != 0L)
						{
							goto IL_22C;
						}
						ptr[num2] = (byte)(num6 >> 16);
						ptr[num2 + 1U] = (byte)(num6 >> 8);
						num2 += 2U;
					}
					else
					{
						if (((long)num6 & (long)((ulong)-2147422208)) != 0L)
						{
							goto IL_22C;
						}
						ptr[num2] = (byte)(num6 >> 16);
						num2 += 1U;
					}
					bytesWritten = (int)num2;
					return OperationStatus.Done;
				}
				IL_22C:
				bytesWritten = (int)num2;
				if (!ignoreWhiteSpace)
				{
					return OperationStatus.InvalidData;
				}
				return Base64Helper.DecodeWithWhiteSpaceFromUtf8InPlace<TBase64Decoder>(decoder, buffer, ref bytesWritten, num);
			}
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x000CA97C File Offset: 0x000C8B7C
		internal unsafe static OperationStatus DecodeWithWhiteSpaceBlockwise<TBase64Decoder>(TBase64Decoder decoder, ReadOnlySpan<byte> source, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock = true) where TBase64Decoder : Base64Helper.IBase64Decoder<byte>
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)4], 4);
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
					if (typeof(TBase64Decoder) == typeof(Base64Helper.Base64DecoderByte))
					{
						flag = (source.Length >= 4);
					}
					else
					{
						flag = (source.Length > 1);
					}
					bool flag2 = !flag;
					if (flag && Base64Helper.GetPaddingCount<TBase64Decoder>(decoder, span[3]) > 0)
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
					operationStatus = Base64Helper.DecodeFrom<TBase64Decoder, byte>(decoder, span.Slice(0, num2), bytes, out num4, out num5, flag2, false);
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

		// Token: 0x06003C81 RID: 15489 RVA: 0x000CAAF8 File Offset: 0x000C8CF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static int GetPaddingCount<TBase64Decoder>(TBase64Decoder decoder, ref byte ptrToLastElement) where TBase64Decoder : Base64Helper.IBase64Decoder<byte>
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
			if (ptr.IsValidPadding((uint)(*Unsafe.Subtract<byte>(ref ptrToLastElement, 1))))
			{
				num++;
			}
			return num;
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x000CAB50 File Offset: 0x000C8D50
		private unsafe static OperationStatus DecodeWithWhiteSpaceFromUtf8InPlace<TBase64Decoder>(TBase64Decoder decoder, Span<byte> source, ref int destIndex, uint sourceIndex) where TBase64Decoder : Base64Helper.IBase64Decoder<byte>
		{
			int num = Math.Min(source.Length - (int)sourceIndex, 4);
			int num2 = num;
			Span<byte> buffer = new Span<byte>(stackalloc byte[(UIntPtr)num2], num2);
			OperationStatus operationStatus = OperationStatus.Done;
			int num3 = destIndex;
			bool flag = false;
			int num4 = 0;
			while (sourceIndex < (uint)source.Length)
			{
				int i = 0;
				while (i < num && sourceIndex < (uint)source.Length)
				{
					if (!Base64Helper.IsWhiteSpace((int)(*source[(int)sourceIndex])))
					{
						*buffer[i] = *source[(int)sourceIndex];
						i++;
					}
					sourceIndex += 1U;
				}
				if (i != 0)
				{
					if (i != 4)
					{
						if (decoder is Base64Helper.Base64DecoderByte || i == 1)
						{
							operationStatus = OperationStatus.InvalidData;
							break;
						}
						while (i < num)
						{
							*buffer[i++] = 61;
						}
					}
					if (flag)
					{
						num3 -= num4;
						operationStatus = OperationStatus.InvalidData;
						break;
					}
					operationStatus = Base64Helper.DecodeFromUtf8InPlace<TBase64Decoder>(decoder, buffer, out num4, false);
					num3 += num4;
					flag = (num4 < 3);
					if (operationStatus != OperationStatus.Done)
					{
						break;
					}
					for (int j = 0; j < num4; j++)
					{
						*source[num3 - num4 + j] = *buffer[j];
					}
				}
			}
			destIndex = num3;
			return operationStatus;
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x000CAC69 File Offset: 0x000C8E69
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> SimdShuffle(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask8F)
		{
			if (false)
			{
			}
			return Vector128.ShuffleUnsafe(left, right);
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x000CAC78 File Offset: 0x000C8E78
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void Vector128Decode<TBase64Decoder, [IsUnmanaged] T>(TBase64Decoder decoder, ref T* srcBytes, ref byte* destBytes, T* srcEnd, int sourceLength, int destLength, T* srcStart, byte* destStart) where TBase64Decoder : Base64Helper.IBase64Decoder<T> where T : struct, ValueType
		{
			Vector128<byte> lutHigh = Vector128.Create<int>(decoder.Vector128LutHigh).AsByte<int>();
			Vector128<byte> lutLow = Vector128.Create<int>(decoder.Vector128LutLow).AsByte<int>();
			Vector128<sbyte> lutShift = Vector128.Create<uint>(decoder.Vector128LutShift).AsSByte<uint>();
			Vector128<sbyte> vector = Vector128.Create(100663554U, 151651333U, 202182152U, uint.MaxValue).AsSByte<uint>();
			Vector128<byte> vector2 = Vector128.Create(20971840).AsByte<int>();
			Vector128<short> right = Vector128.Create(69632).AsInt16<int>();
			Vector128<byte> vector3 = Vector128.Create(1);
			Vector128<byte> vector4 = Vector128.Create(decoder.MaskSlashOrUnderscore);
			Vector128<byte> mask8F = Vector128.Create(143);
			Vector128<byte> shiftForUnderscore = Vector128.Create(33);
			T* ptr = srcBytes;
			byte* ptr2 = destBytes;
			Vector128<byte> vector5;
			while (decoder.TryLoadVector128(ptr, srcStart, sourceLength, out vector5))
			{
				Vector128<byte> hiNibbles = Vector128.ShiftRightLogical(vector5.AsInt32<byte>(), 4).AsByte<int>() & vector4;
				if (!decoder.TryDecode128Core(vector5, hiNibbles, vector4, mask8F, lutLow, lutHigh, lutShift, shiftForUnderscore, out vector5))
				{
					break;
				}
				Vector128<short> left;
				if (Ssse3.IsSupported)
				{
					left = Ssse3.MultiplyAddAdjacent(vector5.AsByte<byte>(), vector2.AsSByte<byte>());
				}
				else
				{
					Vector128<ushort> left2 = AdvSimd.ShiftLeftLogicalWideningLower(AdvSimd.Arm64.UnzipEven(vector5, vector3).GetLower<byte>(), 6);
					Vector128<ushort> right2 = AdvSimd.Arm64.TransposeOdd(vector5, Vector128<byte>.Zero).AsUInt16<byte>();
					left = Vector128.Add<ushort>(left2, right2).AsInt16<ushort>();
				}
				Vector128<int> vector6;
				if (Ssse3.IsSupported)
				{
					vector6 = Sse2.MultiplyAddAdjacent(left, right);
				}
				else
				{
					Vector128<int> left3 = AdvSimd.ShiftLeftLogicalWideningLower(AdvSimd.Arm64.UnzipEven(left, vector3.AsInt16<byte>()).GetLower<short>(), 12);
					Vector128<int> right3 = AdvSimd.Arm64.TransposeOdd(left, Vector128<short>.Zero).AsInt32<short>();
					vector6 = Vector128.Add<int>(left3, right3).AsInt32<int>();
				}
				vector5 = Base64Helper.SimdShuffle(vector6.AsByte<int>(), vector.AsByte<sbyte>(), mask8F);
				vector5.Store(ptr2);
				ptr += (IntPtr)16 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
				ptr2 += 12;
				if (ptr != srcEnd)
				{
					break;
				}
			}
			srcBytes = ptr;
			destBytes = ptr2;
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x000CAE84 File Offset: 0x000C9084
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WriteThreeLowOrderBytes(byte* destination, int value)
		{
			*destination = (byte)(value >> 16);
			destination[1] = (byte)(value >> 8);
			destination[2] = (byte)value;
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x000CAE9C File Offset: 0x000C909C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsWhiteSpace(int value)
		{
			uint num;
			return (3355443456U << (int)((short)(num = (uint)((ushort)(value - 9)))) & num - 32U) < 0U;
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x000CAEC4 File Offset: 0x000C90C4
		internal unsafe static bool IsValid<T, TBase64Validatable>(TBase64Validatable validatable, ReadOnlySpan<T> base64Text, out int decodedLength) where T : struct where TBase64Validatable : Base64Helper.IBase64Validatable<T>
		{
			int num = 0;
			int num2 = 0;
			T lastChar = default(T);
			if (base64Text.IsEmpty)
			{
				decodedLength = 0;
				return true;
			}
			while (!base64Text.IsEmpty)
			{
				int num3 = validatable.IndexOfAnyExcept(base64Text);
				if (num3 >= base64Text.Length)
				{
					num += base64Text.Length;
					lastChar = *base64Text[base64Text.Length - 1];
					break;
				}
				num += num3;
				if (num3 != 0)
				{
					lastChar = *base64Text[num3 - 1];
				}
				T value = *base64Text[num3];
				base64Text = base64Text.Slice(num3 + 1);
				if (!validatable.IsWhiteSpace(value))
				{
					if (validatable.IsEncodingPad(value))
					{
						num2 = 1;
						ReadOnlySpan<T> readOnlySpan = base64Text;
						for (int i = 0; i < readOnlySpan.Length; i++)
						{
							T value2 = *readOnlySpan[i];
							if (validatable.IsEncodingPad(value2))
							{
								if (num2 >= 2)
								{
									goto IL_185;
								}
								num2++;
							}
							else if (!validatable.IsWhiteSpace(value2))
							{
								goto IL_185;
							}
						}
						num += num2;
						break;
					}
					IL_185:
					decodedLength = 0;
					return false;
				}
				while (!base64Text.IsEmpty)
				{
					ref TBase64Validatable ptr = ref validatable;
					if (default(TBase64Validatable) == null)
					{
						TBase64Validatable tbase64Validatable = validatable;
						ptr = ref tbase64Validatable;
					}
					if (!ptr.IsWhiteSpace(*base64Text[0]))
					{
						break;
					}
					base64Text = base64Text.Slice(1);
				}
			}
			if (validatable.ValidateAndDecodeLength(lastChar, num, num2, out decodedLength))
			{
				return true;
			}
			goto IL_185;
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x000CB05C File Offset: 0x000C925C
		internal unsafe static OperationStatus EncodeTo<TBase64Encoder, [IsUnmanaged] T>(TBase64Encoder encoder, ReadOnlySpan<byte> source, Span<T> destination, out int bytesConsumed, out int bytesWritten, bool isFinalBlock = true) where TBase64Encoder : Base64Helper.IBase64Encoder<T> where T : struct, ValueType
		{
			if (source.IsEmpty)
			{
				bytesConsumed = 0;
				bytesWritten = 0;
				return OperationStatus.Done;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(source))
			{
				byte* ptr = reference;
				fixed (T* reference2 = MemoryMarshal.GetReference<T>(destination))
				{
					T* ptr2 = reference2;
					int length = source.Length;
					int length2 = destination.Length;
					int maxSrcLength = encoder.GetMaxSrcLength(length, length2);
					byte* ptr3 = ptr;
					T* ptr4 = ptr2;
					byte* ptr5 = ptr + length;
					byte* ptr6 = ptr + maxSrcLength;
					if (maxSrcLength >= 16)
					{
						byte* ptr7 = ptr6 - 64;
						if (false)
						{
						}
						ptr7 = ptr6 - 32;
						if (false)
						{
						}
						ptr7 = ptr6 - 48;
						if (false)
						{
						}
						ptr7 = ptr6 - 16;
						if (Ssse3.IsSupported || false)
						{
							bool isLittleEndian = BitConverter.IsLittleEndian;
							if (ptr7 >= ptr3)
							{
								Base64Helper.Vector128Encode<TBase64Encoder, T>(encoder, ref ptr3, ref ptr4, ptr7, maxSrcLength, length2, ptr, ptr2);
								if (ptr3 == ptr5)
								{
									goto IL_199;
								}
							}
						}
					}
					ref byte reference3 = ref MemoryMarshal.GetReference<byte>(encoder.EncodingMap);
					ptr6 -= 2;
					while (ptr3 < ptr6)
					{
						encoder.EncodeThreeAndWrite(ptr3, ptr4, ref reference3);
						ptr3 += 3;
						ptr4 += (IntPtr)4 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
					}
					if (ptr6 + 2 != ptr5)
					{
						bytesConsumed = (int)((long)(ptr3 - ptr));
						bytesWritten = (int)((long)((ptr4 - ptr2) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
						return OperationStatus.DestinationTooSmall;
					}
					if (!isFinalBlock)
					{
						if (ptr3 != ptr5)
						{
							bytesConsumed = (int)((long)(ptr3 - ptr));
							bytesWritten = (int)((long)((ptr4 - ptr2) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
							return OperationStatus.NeedMoreData;
						}
					}
					else if (ptr3 + 1 == ptr5)
					{
						encoder.EncodeOneOptionallyPadTwo(ptr3, ptr4, ref reference3);
						ptr3++;
						ptr4 += (IntPtr)encoder.IncrementPadTwo * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
					}
					else if (ptr3 + 2 == ptr5)
					{
						encoder.EncodeTwoOptionallyPadOne(ptr3, ptr4, ref reference3);
						ptr3 += 2;
						ptr4 += (IntPtr)encoder.IncrementPadOne * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
					}
					IL_199:
					bytesConsumed = (int)((long)(ptr3 - ptr));
					bytesWritten = (int)((long)((ptr4 - ptr2) / (IntPtr)sizeof(T) * (IntPtr)sizeof(T)));
					return OperationStatus.Done;
				}
			}
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x000CB258 File Offset: 0x000C9458
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void Vector128Encode<TBase64Encoder, [IsUnmanaged] T>(TBase64Encoder encoder, ref byte* srcBytes, ref T* destBytes, byte* srcEnd, int sourceLength, int destLength, byte* srcStart, T* destStart) where TBase64Encoder : Base64Helper.IBase64Encoder<T> where T : struct, ValueType
		{
			Vector128<byte> right = Vector128.Create(16908289, 67437316, 117966343, 168495370).AsByte<int>();
			Vector128<byte> left = Vector128.Create(4244391745U, 4244438268U, 4244438268U, encoder.Ssse3AdvSimdLutE3).AsByte<uint>();
			Vector128<byte> right2 = Vector128.Create(264305664).AsByte<int>();
			Vector128<byte> right3 = Vector128.Create(4129776).AsByte<int>();
			Vector128<ushort> right4 = Vector128.Create(67108928).AsUInt16<int>();
			Vector128<short> right5 = Vector128.Create(16777232).AsInt16<int>();
			Vector128<byte> right6 = Vector128.Create(51);
			Vector128<sbyte> right7 = Vector128.Create(25);
			Vector128<byte> mask8F = Vector128.Create(143);
			byte* ptr = srcBytes;
			T* ptr2 = destBytes;
			do
			{
				Vector128<byte> vector = Vector128.LoadUnsafe<byte>(ref *ptr);
				vector = Base64Helper.SimdShuffle(vector, right, mask8F);
				Vector128<byte> vector2 = vector & right2;
				Vector128<byte> vector3 = vector & right3;
				Vector128<ushort> vector4;
				if (Ssse3.IsSupported)
				{
					vector4 = Sse2.MultiplyHigh(vector2.AsUInt16<byte>(), right4);
				}
				else
				{
					Vector128<ushort> right8 = Vector128.ShiftRightLogical(AdvSimd.Arm64.UnzipOdd(vector2.AsUInt16<byte>(), vector2.AsUInt16<byte>()), 6);
					vector4 = AdvSimd.Arm64.ZipLow(Vector128.ShiftRightLogical(AdvSimd.Arm64.UnzipEven(vector2.AsUInt16<byte>(), vector2.AsUInt16<byte>()), 10), right8);
				}
				Vector128<short> vector5 = vector3.AsInt16<byte>() * right5;
				vector = (vector4.AsByte<ushort>() | vector5.AsByte<short>());
				Vector128<byte> vector6;
				if (Ssse3.IsSupported)
				{
					vector6 = Sse2.SubtractSaturate(vector.AsByte<byte>(), right6);
				}
				else
				{
					vector6 = AdvSimd.SubtractSaturate(vector.AsByte<byte>(), right6);
				}
				Vector128<sbyte> right9 = Vector128.GreaterThan<sbyte>(vector.AsSByte<byte>(), right7);
				Vector128<sbyte> vector7 = vector6.AsSByte<byte>() - right9;
				vector += Base64Helper.SimdShuffle(left, vector7.AsByte<sbyte>(), mask8F);
				encoder.StoreVector128ToDestination(ptr2, destStart, destLength, vector);
				ptr += 12;
				ptr2 += (IntPtr)16 * (IntPtr)sizeof(T) / (IntPtr)sizeof(T);
			}
			while (ptr == srcEnd);
			srcBytes = ptr;
			destBytes = ptr2;
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x000CB450 File Offset: 0x000C9650
		internal unsafe static OperationStatus EncodeToUtf8InPlace<TBase64Encoder>(TBase64Encoder encoder, Span<byte> buffer, int dataLength, out int bytesWritten) where TBase64Encoder : Base64Helper.IBase64Encoder<byte>
		{
			if (buffer.IsEmpty)
			{
				bytesWritten = 0;
				return OperationStatus.Done;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(buffer))
			{
				byte* ptr = reference;
				int maxEncodedLength = encoder.GetMaxEncodedLength(dataLength);
				if (buffer.Length < maxEncodedLength)
				{
					bytesWritten = 0;
					return OperationStatus.DestinationTooSmall;
				}
				int num = dataLength % 3;
				uint num2 = encoder.GetInPlaceDestinationLength(maxEncodedLength, num);
				uint num3 = (uint)(dataLength - num);
				ref byte reference2 = ref MemoryMarshal.GetReference<byte>(encoder.EncodingMap);
				if (num != 0)
				{
					if (num == 1)
					{
						encoder.EncodeOneOptionallyPadTwo(ptr + num3, ptr + num2, ref reference2);
					}
					else
					{
						encoder.EncodeTwoOptionallyPadOne(ptr + num3, ptr + num2, ref reference2);
					}
					num2 -= 4U;
				}
				for (num3 -= 3U; num3 >= 0U; num3 -= 3U)
				{
					uint value = Base64Helper.Encode(ptr + num3, ref reference2);
					Unsafe.WriteUnaligned<uint>((void*)(ptr + num2), value);
					num2 -= 4U;
				}
				bytesWritten = maxEncodedLength;
				return OperationStatus.Done;
			}
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x000CB53C File Offset: 0x000C973C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static uint Encode(byte* threeBytes, ref byte encodingMap)
		{
			uint num = (uint)(*threeBytes);
			uint num2 = (uint)threeBytes[1];
			uint num3 = (uint)threeBytes[2];
			uint num4 = num << 16 | num2 << 8 | num3;
			uint i = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 >> 18))));
			uint i2 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 >> 12 & 63U))));
			uint i3 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 >> 6 & 63U))));
			uint i4 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num4 & 63U))));
			return Base64Helper.ConstructResult(i, i2, i3, i4);
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x000CB5A3 File Offset: 0x000C97A3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ConstructResult(uint i0, uint i1, uint i2, uint i3)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return i0 | i1 << 8 | i2 << 16 | i3 << 24;
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x000CB5BC File Offset: 0x000C97BC
		[CompilerGenerated]
		internal static OperationStatus <DecodeFrom>g__InvalidDataFallback|0_0<TBase64Decoder, [IsUnmanaged] T>(TBase64Decoder decoder, ReadOnlySpan<T> source, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock) where TBase64Decoder : Base64Helper.IBase64Decoder<T> where T : struct, ValueType
		{
			source = source.Slice(bytesConsumed);
			bytes = bytes.Slice(bytesWritten);
			for (;;)
			{
				int num = decoder.IndexOfAnyExceptWhiteSpace(source);
				if (num < 0)
				{
					break;
				}
				if (num == 0)
				{
					goto Block_2;
				}
				bytesConsumed += num;
				source = source.Slice(num);
				int num2;
				OperationStatus operationStatus = Base64Helper.DecodeFrom<TBase64Decoder, T>(decoder, source, bytes, out num, out num2, isFinalBlock, false);
				bytesConsumed += num;
				bytesWritten += num2;
				if (operationStatus != OperationStatus.InvalidData)
				{
					return operationStatus;
				}
				source = source.Slice(num);
				bytes = bytes.Slice(num2);
				if (source.IsEmpty)
				{
					return operationStatus;
				}
			}
			bytesConsumed += source.Length;
			return OperationStatus.Done;
			Block_2:
			return decoder.DecodeWithWhiteSpaceBlockwiseWrapper<TBase64Decoder>(decoder, source, bytes, ref bytesConsumed, ref bytesWritten, isFinalBlock);
		}

		// Token: 0x0200039D RID: 925
		internal readonly struct Base64DecoderByte : Base64Helper.IBase64Decoder<byte>
		{
			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06003C8E RID: 15502 RVA: 0x00022AD4 File Offset: 0x00020CD4
			public unsafe ReadOnlySpan<sbyte> DecodingMap
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8), 256);
				}
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06003C8F RID: 15503 RVA: 0x000CB66F File Offset: 0x000C986F
			public ReadOnlySpan<uint> VbmiLookup0
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.CD7008D69D9732959A97CFCD70323B91052A095B1248E0EB5600B508CE7BD9AD4).FieldHandle);
				}
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x06003C90 RID: 15504 RVA: 0x000CB67B File Offset: 0x000C987B
			public ReadOnlySpan<uint> VbmiLookup1
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.050BF193A45B429F9889F3B1F88214AB95A502925A943236F6736054352DB2FF4).FieldHandle);
				}
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06003C91 RID: 15505 RVA: 0x000CB687 File Offset: 0x000C9887
			public unsafe ReadOnlySpan<sbyte> Avx2LutHigh
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.3498E9CE226F29A7866DFE222B914FA81EA1B8F372E926D1893F4C60C0E1707B), 32);
				}
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06003C92 RID: 15506 RVA: 0x000CB695 File Offset: 0x000C9895
			public unsafe ReadOnlySpan<sbyte> Avx2LutLow
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.8585AB26CCFC493E36A6E29A23E52706504D97953E05D7E31466F2923D5F19A7), 32);
				}
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06003C93 RID: 15507 RVA: 0x000CB6A3 File Offset: 0x000C98A3
			public unsafe ReadOnlySpan<sbyte> Avx2LutShift
			{
				get
				{
					return new ReadOnlySpan<sbyte>((void*)(&<PrivateImplementationDetails>.D7F6E93B77A60FD832E64592E1163AB4AEA652A591958C4D7B19BA3761A64BA0), 32);
				}
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06003C94 RID: 15508 RVA: 0x000CB6B1 File Offset: 0x000C98B1
			public byte MaskSlashOrUnderscore
			{
				get
				{
					return 47;
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06003C95 RID: 15509 RVA: 0x000CB6B5 File Offset: 0x000C98B5
			public ReadOnlySpan<int> Vector128LutHigh
			{
				get
				{
					return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.08D9BD0A289F0DFB74DE80079A53A949A18CCA43224E33FA6B6EA1E54B3628A74).FieldHandle);
				}
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x06003C96 RID: 15510 RVA: 0x000CB6C1 File Offset: 0x000C98C1
			public ReadOnlySpan<int> Vector128LutLow
			{
				get
				{
					return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.0154546DE17EC86DE0C74B0CA2D6FC1A9F52981E61ECEB054E3B382DBD0EC1AF4).FieldHandle);
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06003C97 RID: 15511 RVA: 0x000CB6CD File Offset: 0x000C98CD
			public ReadOnlySpan<uint> Vector128LutShift
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.64D5C1B02682318BF93BD9D5B03350E701D32588D2C8293EE4B5430745C34CE14).FieldHandle);
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06003C98 RID: 15512 RVA: 0x000CB6D9 File Offset: 0x000C98D9
			public ReadOnlySpan<uint> AdvSimdLutOne3
			{
				get
				{
					return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.C2EA013ED11EED390B91C8A713F2F37A9504CA632C8EA1A181B9915792AE2D694).FieldHandle);
				}
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06003C99 RID: 15513 RVA: 0x000CB6E5 File Offset: 0x000C98E5
			public uint AdvSimdLutTwo3Uint1
			{
				get
				{
					return 454754303U;
				}
			}

			// Token: 0x06003C9A RID: 15514 RVA: 0x000CB6EC File Offset: 0x000C98EC
			public int GetMaxDecodedLength(int utf8Length)
			{
				return Base64.GetMaxDecodedFromUtf8Length(utf8Length);
			}

			// Token: 0x06003C9B RID: 15515 RVA: 0x000CB6F4 File Offset: 0x000C98F4
			public bool IsInvalidLength(int bufferLength)
			{
				return bufferLength % 4 != 0;
			}

			// Token: 0x06003C9C RID: 15516 RVA: 0x000CB6FC File Offset: 0x000C98FC
			public bool IsValidPadding(uint padChar)
			{
				return padChar == 61U;
			}

			// Token: 0x06003C9D RID: 15517 RVA: 0x000CB703 File Offset: 0x000C9903
			public int SrcLength(bool _, int utf8Length)
			{
				return utf8Length & -4;
			}

			// Token: 0x06003C9E RID: 15518 RVA: 0x000CB70C File Offset: 0x000C990C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryDecode128Core(Vector128<byte> str, Vector128<byte> hiNibbles, Vector128<byte> maskSlashOrUnderscore, Vector128<byte> mask8F, Vector128<byte> lutLow, Vector128<byte> lutHigh, Vector128<sbyte> lutShift, Vector128<byte> _, out Vector128<byte> result)
			{
				Vector128<byte> right = str & maskSlashOrUnderscore;
				Vector128<byte> right2 = Base64Helper.SimdShuffle(lutHigh, hiNibbles, mask8F);
				if ((Base64Helper.SimdShuffle(lutLow, right, mask8F) & right2) != Vector128<byte>.Zero)
				{
					result = default(Vector128<byte>);
					return false;
				}
				Vector128<byte> left = Vector128.Equals<byte>(str, maskSlashOrUnderscore);
				Vector128<byte> right3 = Base64Helper.SimdShuffle(lutShift.AsByte<sbyte>(), left + hiNibbles, mask8F);
				result = str + right3;
				return true;
			}

			// Token: 0x06003C9F RID: 15519 RVA: 0x000CB780 File Offset: 0x000C9980
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool TryDecode256Core(Vector256<sbyte> str, Vector256<sbyte> hiNibbles, Vector256<sbyte> maskSlashOrUnderscore, Vector256<sbyte> lutLow, Vector256<sbyte> lutHigh, Vector256<sbyte> lutShift, Vector256<sbyte> _, out Vector256<sbyte> result)
			{
				Vector256<sbyte> mask = Avx2.And(str, maskSlashOrUnderscore);
				Vector256<sbyte> right = Avx2.Shuffle(lutHigh, hiNibbles);
				if (!Avx.TestZ(Avx2.Shuffle(lutLow, mask), right))
				{
					result = default(Vector256<sbyte>);
					return false;
				}
				Vector256<sbyte> left = Avx2.CompareEqual(str, maskSlashOrUnderscore);
				Vector256<sbyte> right2 = Avx2.Shuffle(lutShift, Avx2.Add(left, hiNibbles));
				result = Avx2.Add(str, right2);
				return true;
			}

			// Token: 0x06003CA0 RID: 15520 RVA: 0x000CB7DE File Offset: 0x000C99DE
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadVector512(byte* src, byte* srcStart, int sourceLength, out Vector512<sbyte> str)
			{
				str = Vector512.Load<byte>(src).AsSByte<byte>();
				return true;
			}

			// Token: 0x06003CA1 RID: 15521 RVA: 0x000CB7F3 File Offset: 0x000C99F3
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadAvxVector256(byte* src, byte* srcStart, int sourceLength, out Vector256<sbyte> str)
			{
				str = Avx.LoadVector256(src).AsSByte<byte>();
				return true;
			}

			// Token: 0x06003CA2 RID: 15522 RVA: 0x000CB808 File Offset: 0x000C9A08
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadVector128(byte* src, byte* srcStart, int sourceLength, out Vector128<byte> str)
			{
				str = Vector128.LoadUnsafe<byte>(ref *src);
				return true;
			}

			// Token: 0x06003CA3 RID: 15523 RVA: 0x000CB818 File Offset: 0x000C9A18
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool TryLoadArmVector128x4(byte* src, byte* srcStart, int sourceLength, out Vector128<byte> str1, out Vector128<byte> str2, out Vector128<byte> str3, out Vector128<byte> str4)
			{
				ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>> valueTuple = AdvSimd.Arm64.Load4xVector128AndUnzip(src);
				str1 = valueTuple.Item1;
				str2 = valueTuple.Item2;
				str3 = valueTuple.Item3;
				str4 = valueTuple.Item4;
				return true;
			}

			// Token: 0x06003CA4 RID: 15524 RVA: 0x000CB864 File Offset: 0x000C9A64
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int DecodeFourElements(byte* source, ref sbyte decodingMap)
			{
				uint elementOffset = (uint)(*source);
				uint elementOffset2 = (uint)source[1];
				uint elementOffset3 = (uint)source[2];
				uint elementOffset4 = (uint)source[3];
				int num = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)elementOffset));
				int num2 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)elementOffset2));
				int num3 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)elementOffset3));
				int num4 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (int)elementOffset4));
				int num5 = num << 18;
				num2 <<= 12;
				num3 <<= 6;
				int num6 = num5 | num4;
				num2 |= num3;
				return num6 | num2;
			}

			// Token: 0x06003CA5 RID: 15525 RVA: 0x000CB8C8 File Offset: 0x000C9AC8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int DecodeRemaining(byte* srcEnd, ref sbyte decodingMap, long remaining, out uint t2, out uint t3)
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
					int num4 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (IntPtr)((UIntPtr)num2)));
					int num5 = (int)(*Unsafe.Add<sbyte>(ref decodingMap, (IntPtr)((UIntPtr)num3)));
					int num6 = num4 << 18;
					num5 <<= 12;
					return num6 | num5;
				}
				return -1;
			}

			// Token: 0x06003CA6 RID: 15526 RVA: 0x000CB960 File Offset: 0x000C9B60
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe int IndexOfAnyExceptWhiteSpace(ReadOnlySpan<byte> span)
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

			// Token: 0x06003CA7 RID: 15527 RVA: 0x000CB992 File Offset: 0x000C9B92
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public OperationStatus DecodeWithWhiteSpaceBlockwiseWrapper<TBase64Decoder>(TBase64Decoder decoder, ReadOnlySpan<byte> utf8, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock = true) where TBase64Decoder : Base64Helper.IBase64Decoder<byte>
			{
				return Base64Helper.DecodeWithWhiteSpaceBlockwise<TBase64Decoder>(decoder, utf8, bytes, ref bytesConsumed, ref bytesWritten, isFinalBlock);
			}
		}

		// Token: 0x0200039E RID: 926
		internal interface IBase64Encoder<[IsUnmanaged] T> where T : struct, ValueType
		{
			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06003CA8 RID: 15528
			ReadOnlySpan<byte> EncodingMap { get; }

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x06003CA9 RID: 15529
			sbyte Avx2LutChar62 { get; }

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x06003CAA RID: 15530
			sbyte Avx2LutChar63 { get; }

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x06003CAB RID: 15531
			ReadOnlySpan<byte> AdvSimdLut4 { get; }

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06003CAC RID: 15532
			uint Ssse3AdvSimdLutE3 { get; }

			// Token: 0x06003CAD RID: 15533
			int GetMaxSrcLength(int srcLength, int destLength);

			// Token: 0x06003CAE RID: 15534
			int GetMaxEncodedLength(int srcLength);

			// Token: 0x06003CAF RID: 15535
			uint GetInPlaceDestinationLength(int encodedLength, int leftOver);

			// Token: 0x06003CB0 RID: 15536
			unsafe void EncodeOneOptionallyPadTwo(byte* oneByte, T* dest, ref byte encodingMap);

			// Token: 0x06003CB1 RID: 15537
			unsafe void EncodeTwoOptionallyPadOne(byte* oneByte, T* dest, ref byte encodingMap);

			// Token: 0x06003CB2 RID: 15538
			unsafe void EncodeThreeAndWrite(byte* threeBytes, T* destination, ref byte encodingMap);

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06003CB3 RID: 15539
			int IncrementPadTwo { get; }

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06003CB4 RID: 15540
			int IncrementPadOne { get; }

			// Token: 0x06003CB5 RID: 15541
			unsafe void StoreVector512ToDestination(T* dest, T* destStart, int destLength, Vector512<byte> str);

			// Token: 0x06003CB6 RID: 15542
			unsafe void StoreVector256ToDestination(T* dest, T* destStart, int destLength, Vector256<byte> str);

			// Token: 0x06003CB7 RID: 15543
			unsafe void StoreVector128ToDestination(T* dest, T* destStart, int destLength, Vector128<byte> str);

			// Token: 0x06003CB8 RID: 15544
			unsafe void StoreArmVector128x4ToDestination(T* dest, T* destStart, int destLength, Vector128<byte> res1, Vector128<byte> res2, Vector128<byte> res3, Vector128<byte> res4);
		}

		// Token: 0x0200039F RID: 927
		internal interface IBase64Decoder<[IsUnmanaged] T> where T : struct, ValueType
		{
			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06003CB9 RID: 15545
			ReadOnlySpan<sbyte> DecodingMap { get; }

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x06003CBA RID: 15546
			ReadOnlySpan<uint> VbmiLookup0 { get; }

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x06003CBB RID: 15547
			ReadOnlySpan<uint> VbmiLookup1 { get; }

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06003CBC RID: 15548
			ReadOnlySpan<sbyte> Avx2LutHigh { get; }

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06003CBD RID: 15549
			ReadOnlySpan<sbyte> Avx2LutLow { get; }

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x06003CBE RID: 15550
			ReadOnlySpan<sbyte> Avx2LutShift { get; }

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x06003CBF RID: 15551
			byte MaskSlashOrUnderscore { get; }

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06003CC0 RID: 15552
			ReadOnlySpan<int> Vector128LutHigh { get; }

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06003CC1 RID: 15553
			ReadOnlySpan<int> Vector128LutLow { get; }

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06003CC2 RID: 15554
			ReadOnlySpan<uint> Vector128LutShift { get; }

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06003CC3 RID: 15555
			ReadOnlySpan<uint> AdvSimdLutOne3 { get; }

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06003CC4 RID: 15556
			uint AdvSimdLutTwo3Uint1 { get; }

			// Token: 0x06003CC5 RID: 15557
			int SrcLength(bool isFinalBlock, int sourceLength);

			// Token: 0x06003CC6 RID: 15558
			int GetMaxDecodedLength(int sourceLength);

			// Token: 0x06003CC7 RID: 15559
			bool IsInvalidLength(int bufferLength);

			// Token: 0x06003CC8 RID: 15560
			bool IsValidPadding(uint padChar);

			// Token: 0x06003CC9 RID: 15561
			bool TryDecode128Core(Vector128<byte> str, Vector128<byte> hiNibbles, Vector128<byte> maskSlashOrUnderscore, Vector128<byte> mask8F, Vector128<byte> lutLow, Vector128<byte> lutHigh, Vector128<sbyte> lutShift, Vector128<byte> shiftForUnderscore, out Vector128<byte> result);

			// Token: 0x06003CCA RID: 15562
			bool TryDecode256Core(Vector256<sbyte> str, Vector256<sbyte> hiNibbles, Vector256<sbyte> maskSlashOrUnderscore, Vector256<sbyte> lutLow, Vector256<sbyte> lutHigh, Vector256<sbyte> lutShift, Vector256<sbyte> shiftForUnderscore, out Vector256<sbyte> result);

			// Token: 0x06003CCB RID: 15563
			unsafe bool TryLoadVector512(T* src, T* srcStart, int sourceLength, out Vector512<sbyte> str);

			// Token: 0x06003CCC RID: 15564
			unsafe bool TryLoadAvxVector256(T* src, T* srcStart, int sourceLength, out Vector256<sbyte> str);

			// Token: 0x06003CCD RID: 15565
			unsafe bool TryLoadVector128(T* src, T* srcStart, int sourceLength, out Vector128<byte> str);

			// Token: 0x06003CCE RID: 15566
			unsafe bool TryLoadArmVector128x4(T* src, T* srcStart, int sourceLength, out Vector128<byte> str1, out Vector128<byte> str2, out Vector128<byte> str3, out Vector128<byte> str4);

			// Token: 0x06003CCF RID: 15567
			unsafe int DecodeFourElements(T* source, ref sbyte decodingMap);

			// Token: 0x06003CD0 RID: 15568
			unsafe int DecodeRemaining(T* srcEnd, ref sbyte decodingMap, long remaining, out uint t2, out uint t3);

			// Token: 0x06003CD1 RID: 15569
			int IndexOfAnyExceptWhiteSpace(ReadOnlySpan<T> span);

			// Token: 0x06003CD2 RID: 15570
			OperationStatus DecodeWithWhiteSpaceBlockwiseWrapper<TTBase64Decoder>(TTBase64Decoder decoder, ReadOnlySpan<T> source, Span<byte> bytes, ref int bytesConsumed, ref int bytesWritten, bool isFinalBlock = true) where TTBase64Decoder : Base64Helper.IBase64Decoder<T>;
		}

		// Token: 0x020003A0 RID: 928
		internal interface IBase64Validatable<T>
		{
			// Token: 0x06003CD3 RID: 15571
			int IndexOfAnyExcept(ReadOnlySpan<T> span);

			// Token: 0x06003CD4 RID: 15572
			bool IsWhiteSpace(T value);

			// Token: 0x06003CD5 RID: 15573
			bool IsEncodingPad(T value);

			// Token: 0x06003CD6 RID: 15574
			bool ValidateAndDecodeLength(T lastChar, int length, int paddingCount, out int decodedLength);
		}

		// Token: 0x020003A1 RID: 929
		internal readonly struct Base64CharValidatable : Base64Helper.IBase64Validatable<char>
		{
			// Token: 0x06003CD7 RID: 15575 RVA: 0x000CB9A2 File Offset: 0x000C9BA2
			public int IndexOfAnyExcept(ReadOnlySpan<char> span)
			{
				return span.IndexOfAnyExcept(Base64Helper.Base64CharValidatable.s_validBase64Chars);
			}

			// Token: 0x06003CD8 RID: 15576 RVA: 0x000CB9AF File Offset: 0x000C9BAF
			public bool IsWhiteSpace(char value)
			{
				return Base64Helper.IsWhiteSpace((int)value);
			}

			// Token: 0x06003CD9 RID: 15577 RVA: 0x000CB6FC File Offset: 0x000C98FC
			public bool IsEncodingPad(char value)
			{
				return value == '=';
			}

			// Token: 0x06003CDA RID: 15578 RVA: 0x000CB9B8 File Offset: 0x000C9BB8
			public bool ValidateAndDecodeLength(char lastChar, int length, int paddingCount, out int decodedLength)
			{
				return default(Base64Helper.Base64ByteValidatable).ValidateAndDecodeLength((byte)lastChar, length, paddingCount, out decodedLength);
			}

			// Token: 0x04000CC7 RID: 3271
			private static readonly SearchValues<char> s_validBase64Chars = SearchValues.Create("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/");
		}

		// Token: 0x020003A2 RID: 930
		internal readonly struct Base64ByteValidatable : Base64Helper.IBase64Validatable<byte>
		{
			// Token: 0x06003CDC RID: 15580 RVA: 0x000CB9EF File Offset: 0x000C9BEF
			public int IndexOfAnyExcept(ReadOnlySpan<byte> span)
			{
				return span.IndexOfAnyExcept(Base64Helper.Base64ByteValidatable.s_validBase64Chars);
			}

			// Token: 0x06003CDD RID: 15581 RVA: 0x000CB9AF File Offset: 0x000C9BAF
			public bool IsWhiteSpace(byte value)
			{
				return Base64Helper.IsWhiteSpace((int)value);
			}

			// Token: 0x06003CDE RID: 15582 RVA: 0x000CB6FC File Offset: 0x000C98FC
			public bool IsEncodingPad(byte value)
			{
				return value == 61;
			}

			// Token: 0x06003CDF RID: 15583 RVA: 0x000CB9FC File Offset: 0x000C9BFC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe bool ValidateAndDecodeLength(byte lastChar, int length, int paddingCount, out int decodedLength)
			{
				if (length % 4 != 0)
				{
					decodedLength = 0;
					return false;
				}
				int num = (int)(*default(Base64Helper.Base64DecoderByte).DecodingMap[(int)lastChar]);
				if ((paddingCount == 1 && (num & 3) != 0) || (paddingCount == 2 && (num & 15) != 0))
				{
					decodedLength = 0;
					return false;
				}
				decodedLength = length / 4 * 3 - paddingCount;
				return true;
			}

			// Token: 0x04000CC8 RID: 3272
			private static readonly SearchValues<byte> s_validBase64Chars = SearchValues.Create(default(Base64Helper.Base64EncoderByte).EncodingMap);
		}

		// Token: 0x020003A3 RID: 931
		internal readonly struct Base64EncoderByte : Base64Helper.IBase64Encoder<byte>
		{
			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x000CBA79 File Offset: 0x000C9C79
			public unsafe ReadOnlySpan<byte> EncodingMap
			{
				get
				{
					return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.B549D027496B9C80494809966F74EBF09C8A21512D7F2152230A26AC65016653), 64);
				}
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06003CE2 RID: 15586 RVA: 0x000CBA87 File Offset: 0x000C9C87
			public sbyte Avx2LutChar62
			{
				get
				{
					return -19;
				}
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x000CBA8B File Offset: 0x000C9C8B
			public sbyte Avx2LutChar63
			{
				get
				{
					return -16;
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x000CBA8F File Offset: 0x000C9C8F
			public unsafe ReadOnlySpan<byte> AdvSimdLut4
			{
				get
				{
					return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.E7D01F8ABFC5A2B5A246E6C3A68EFEB3FD67D6EAADBFC2070CFB645CDD9134F2), 16);
				}
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x000CBA9D File Offset: 0x000C9C9D
			public uint Ssse3AdvSimdLutE3
			{
				get
				{
					return 61677U;
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06003CE6 RID: 15590 RVA: 0x000211FB File Offset: 0x0001F3FB
			public int IncrementPadTwo
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x000211FB File Offset: 0x0001F3FB
			public int IncrementPadOne
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x06003CE8 RID: 15592 RVA: 0x000CBAA4 File Offset: 0x000C9CA4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public int GetMaxSrcLength(int srcLength, int destLength)
			{
				if (srcLength > 1610612733 || destLength < Base64.GetMaxEncodedToUtf8Length(srcLength))
				{
					return (destLength >> 2) * 3;
				}
				return srcLength;
			}

			// Token: 0x06003CE9 RID: 15593 RVA: 0x000CBABE File Offset: 0x000C9CBE
			public uint GetInPlaceDestinationLength(int encodedLength, int _)
			{
				return (uint)(encodedLength - 4);
			}

			// Token: 0x06003CEA RID: 15594 RVA: 0x000CBAC3 File Offset: 0x000C9CC3
			public int GetMaxEncodedLength(int srcLength)
			{
				return Base64.GetMaxEncodedToUtf8Length(srcLength);
			}

			// Token: 0x06003CEB RID: 15595 RVA: 0x000CBACC File Offset: 0x000C9CCC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeOneOptionallyPadTwo(byte* oneByte, byte* dest, ref byte encodingMap)
			{
				uint num = (uint)((uint)(*oneByte) << 8);
				uint i = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num >> 10))));
				uint i2 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num >> 4 & 63U))));
				uint value = Base64Helper.ConstructResult(i, i2, 61U, 61U);
				Unsafe.WriteUnaligned<uint>((void*)dest, value);
			}

			// Token: 0x06003CEC RID: 15596 RVA: 0x000CBB0C File Offset: 0x000C9D0C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeTwoOptionallyPadOne(byte* twoBytes, byte* dest, ref byte encodingMap)
			{
				uint num = (uint)(*twoBytes);
				uint num2 = (uint)twoBytes[1];
				uint num3 = num << 16 | num2 << 8;
				uint i = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 18))));
				uint i2 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 12 & 63U))));
				uint i3 = (uint)(*Unsafe.Add<byte>(ref encodingMap, (IntPtr)((UIntPtr)(num3 >> 6 & 63U))));
				uint value = Base64Helper.ConstructResult(i, i2, i3, 61U);
				Unsafe.WriteUnaligned<uint>((void*)dest, value);
			}

			// Token: 0x06003CED RID: 15597 RVA: 0x000CBB66 File Offset: 0x000C9D66
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector512ToDestination(byte* dest, byte* destStart, int destLength, Vector512<byte> str)
			{
				str.Store(dest);
			}

			// Token: 0x06003CEE RID: 15598 RVA: 0x000CBB70 File Offset: 0x000C9D70
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector256ToDestination(byte* dest, byte* destStart, int destLength, Vector256<byte> str)
			{
				Avx.Store(dest, str.AsByte<byte>());
			}

			// Token: 0x06003CEF RID: 15599 RVA: 0x000CBB7F File Offset: 0x000C9D7F
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreVector128ToDestination(byte* dest, byte* destStart, int destLength, Vector128<byte> str)
			{
				str.Store(dest);
			}

			// Token: 0x06003CF0 RID: 15600 RVA: 0x000CBB89 File Offset: 0x000C9D89
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void StoreArmVector128x4ToDestination(byte* dest, byte* destStart, int destLength, Vector128<byte> res1, Vector128<byte> res2, Vector128<byte> res3, Vector128<byte> res4)
			{
				AdvSimd.Arm64.StoreVectorAndZip(dest, new ValueTuple<Vector128<byte>, Vector128<byte>, Vector128<byte>, Vector128<byte>>(res1, res2, res3, res4));
			}

			// Token: 0x06003CF1 RID: 15601 RVA: 0x000CBBA0 File Offset: 0x000C9DA0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe void EncodeThreeAndWrite(byte* threeBytes, byte* destination, ref byte encodingMap)
			{
				uint value = Base64Helper.Encode(threeBytes, ref encodingMap);
				Unsafe.WriteUnaligned<uint>((void*)destination, value);
			}
		}
	}
}
