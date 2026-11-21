using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace System.Text
{
	// Token: 0x02000232 RID: 562
	internal static class Latin1Utility
	{
		// Token: 0x06002AF1 RID: 10993 RVA: 0x0008623B File Offset: 0x0008443B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static UIntPtr GetIndexOfFirstNonLatin1Char(char* pBuffer, UIntPtr bufferLength)
		{
			if (!Sse2.IsSupported)
			{
				return Latin1Utility.GetIndexOfFirstNonLatin1Char_Default(pBuffer, bufferLength);
			}
			return Latin1Utility.GetIndexOfFirstNonLatin1Char_Sse2(pBuffer, bufferLength);
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00086254 File Offset: 0x00084454
		private unsafe static UIntPtr GetIndexOfFirstNonLatin1Char_Default(char* pBuffer, UIntPtr bufferLength)
		{
			char* ptr = pBuffer;
			if (Vector.IsHardwareAccelerated && bufferLength >= (UIntPtr)(2 * Vector<ushort>.Count))
			{
				uint count = (uint)Vector<ushort>.Count;
				uint count2 = (uint)Vector<byte>.Count;
				Vector<ushort> right = new Vector<ushort>(255);
				if (Vector.LessThanOrEqualAll<ushort>(Unsafe.ReadUnaligned<Vector<ushort>>((void*)pBuffer), right))
				{
					char* ptr2 = pBuffer + (ulong)bufferLength * 2UL / 2UL - (ulong)count * 2UL / 2UL;
					pBuffer = (pBuffer + count2 / 2U & ~(count2 - 1U));
					while (!Vector.GreaterThanAny<ushort>(Unsafe.Read<Vector<ushort>>((void*)pBuffer), right))
					{
						pBuffer += (ulong)count * 2UL / 2UL;
						if (pBuffer != ptr2)
						{
							break;
						}
					}
					bufferLength -= (UIntPtr)((pBuffer - ptr) / (IntPtr)2);
				}
			}
			while (bufferLength >= (UIntPtr)((IntPtr)4))
			{
				uint num = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
				uint num2 = Unsafe.ReadUnaligned<uint>((void*)(pBuffer + 2));
				if (!Latin1Utility.AllCharsInUInt32AreLatin1(num | num2))
				{
					if (Latin1Utility.AllCharsInUInt32AreLatin1(num))
					{
						num = num2;
						pBuffer += 2;
					}
					IL_10A:
					if (Latin1Utility.FirstCharInUInt32IsLatin1(num))
					{
						pBuffer++;
					}
					IL_103:
					return (UIntPtr)((pBuffer - ptr) / (IntPtr)2);
				}
				pBuffer += 4;
				bufferLength -= (UIntPtr)((IntPtr)4);
			}
			if ((bufferLength & (UIntPtr)((IntPtr)2)) != 0)
			{
				uint num = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
				if (!Latin1Utility.AllCharsInUInt32AreLatin1(num))
				{
					goto IL_10A;
				}
				pBuffer += 2;
			}
			if ((bufferLength & (UIntPtr)((IntPtr)1)) != 0 && *pBuffer <= 'ÿ')
			{
				pBuffer++;
				goto IL_103;
			}
			goto IL_103;
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x0008637C File Offset: 0x0008457C
		private unsafe static UIntPtr GetIndexOfFirstNonLatin1Char_Sse2(char* pBuffer, UIntPtr bufferLength)
		{
			if (bufferLength == 0)
			{
				return (UIntPtr)((IntPtr)0);
			}
			uint num = (uint)sizeof(Vector128<byte>);
			uint num2 = num / 2U;
			char* ptr = pBuffer;
			if (bufferLength >= (UIntPtr)num2)
			{
				Vector128<ushort> right = Vector128.Create(65280);
				Vector128<ushort> right2 = Vector128.Create(32512);
				Vector128<ushort> left = Sse2.LoadVector128((ushort*)pBuffer);
				uint num3 = (uint)Sse2.MoveMask(Sse2.AddSaturate(left, right2).AsByte<ushort>());
				if ((num3 & 43690U) == 0U)
				{
					bufferLength <<= 1;
					if (bufferLength >= (UIntPtr)(2U * num))
					{
						pBuffer = (pBuffer + num / 2U & ~(num - 1U));
						bufferLength = bufferLength / 2 + ptr;
						bufferLength -= pBuffer;
						if (bufferLength >= (UIntPtr)(2U * num))
						{
							char* ptr2 = pBuffer + bufferLength / 2 - 2U * num / 2U;
							Vector128<ushort> vector;
							for (;;)
							{
								left = Sse2.LoadAlignedVector128((ushort*)pBuffer);
								vector = Sse2.LoadAlignedVector128((ushort*)(pBuffer + (ulong)num2 * 2UL / 2UL));
								Vector128<ushort> left2 = Sse2.Or(left, vector);
								if (Sse41.IsSupported)
								{
									if (!Sse41.TestZ(left2, right))
									{
										break;
									}
								}
								else
								{
									num3 = (uint)Sse2.MoveMask(Sse2.AddSaturate(left2, right2).AsByte<ushort>());
									if ((num3 & 43690U) != 0U)
									{
										break;
									}
								}
								pBuffer += (ulong)(2U * num2) * 2UL / 2UL;
								if (pBuffer != ptr2)
								{
									goto IL_FB;
								}
							}
							if (Sse41.IsSupported)
							{
								if (!Sse41.TestZ(left, right))
								{
									goto IL_1E7;
								}
							}
							else
							{
								num3 = (uint)Sse2.MoveMask(Sse2.AddSaturate(left, right2).AsByte<ushort>());
								if ((num3 & 43690U) != 0U)
								{
									goto IL_1FB;
								}
							}
							pBuffer += (ulong)num2 * 2UL / 2UL;
							left = vector;
							goto IL_1E7;
						}
						IL_FB:
						if ((bufferLength & (UIntPtr)num) == 0)
						{
							goto IL_149;
						}
						left = Sse2.LoadAlignedVector128((ushort*)pBuffer);
						if (Sse41.IsSupported)
						{
							if (!Sse41.TestZ(left, right))
							{
								goto IL_1E7;
							}
						}
						else
						{
							num3 = (uint)Sse2.MoveMask(Sse2.AddSaturate(left, right2).AsByte<ushort>());
							if ((num3 & 43690U) != 0U)
							{
								goto IL_1FB;
							}
						}
					}
					pBuffer += (ulong)num2 * 2UL / 2UL;
					IL_149:
					if (((uint)((byte)bufferLength) & num - 1U) != 0U)
					{
						pBuffer = pBuffer + (ulong)(bufferLength & (UIntPtr)(num - 1U)) / 2UL - num / 2U;
						left = Sse2.LoadVector128((ushort*)pBuffer);
						if (Sse41.IsSupported)
						{
							if (!Sse41.TestZ(left, right))
							{
								goto IL_1E7;
							}
						}
						else
						{
							num3 = (uint)Sse2.MoveMask(Sse2.AddSaturate(left, right2).AsByte<ushort>());
							if ((num3 & 43690U) != 0U)
							{
								goto IL_1FB;
							}
						}
						pBuffer += (ulong)num2 * 2UL / 2UL;
						goto IL_1A2;
					}
					goto IL_1A2;
					IL_1E7:
					num3 = (uint)Sse2.MoveMask(Sse2.AddSaturate(left, right2).AsByte<ushort>());
				}
				IL_1FB:
				num3 &= 43690U;
				pBuffer = (char*)((byte*)(pBuffer + BitOperations.TrailingZeroCount(num3) / 2) - 1);
			}
			else
			{
				uint num5;
				if ((bufferLength & (UIntPtr)((IntPtr)4)) != 0)
				{
					if (Bmi1.X64.IsSupported)
					{
						ulong num4 = Unsafe.ReadUnaligned<ulong>((void*)pBuffer);
						if (!Latin1Utility.AllCharsInUInt64AreLatin1(num4))
						{
							num4 &= 18374966859414961920UL;
							pBuffer += (ulong)((UIntPtr)(Bmi1.X64.TrailingZeroCount(num4) / 8UL) & (UIntPtr)(~(UIntPtr)((IntPtr)1))) / 2UL;
							goto IL_1A2;
						}
					}
					else
					{
						num5 = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
						uint num6 = Unsafe.ReadUnaligned<uint>((void*)(pBuffer + 2));
						if (!Latin1Utility.AllCharsInUInt32AreLatin1(num5 | num6))
						{
							if (Latin1Utility.AllCharsInUInt32AreLatin1(num5))
							{
								num5 = num6;
								pBuffer += 2;
								goto IL_215;
							}
							goto IL_215;
						}
					}
					pBuffer += 4;
					goto IL_2B7;
				}
				goto IL_2B7;
				IL_215:
				if (Latin1Utility.FirstCharInUInt32IsLatin1(num5))
				{
					pBuffer++;
					goto IL_1A2;
				}
				goto IL_1A2;
				IL_2B7:
				if ((bufferLength & (UIntPtr)((IntPtr)2)) != 0)
				{
					num5 = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
					if (!Latin1Utility.AllCharsInUInt32AreLatin1(num5))
					{
						goto IL_215;
					}
					pBuffer += 2;
				}
				if ((bufferLength & (UIntPtr)((IntPtr)1)) != 0 && *pBuffer <= 'ÿ')
				{
					pBuffer++;
				}
			}
			IL_1A2:
			return (UIntPtr)((pBuffer - ptr) / (IntPtr)2);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00086680 File Offset: 0x00084880
		public unsafe static UIntPtr NarrowUtf16ToLatin1(char* pUtf16Buffer, byte* pLatin1Buffer, UIntPtr elementCount)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			ulong num;
			if (Sse2.IsSupported)
			{
				if (elementCount >= (UIntPtr)(2 * sizeof(Vector128<byte>)))
				{
					num = Unsafe.ReadUnaligned<ulong>((void*)pUtf16Buffer);
					if (!Latin1Utility.AllCharsInUInt64AreLatin1(num))
					{
						goto IL_193;
					}
					uintPtr = Latin1Utility.NarrowUtf16ToLatin1_Sse2(pUtf16Buffer, pLatin1Buffer, elementCount);
				}
			}
			else if (Vector.IsHardwareAccelerated)
			{
				uint num2 = (uint)sizeof(Vector<byte>);
				if (elementCount >= (UIntPtr)(2U * num2))
				{
					num = Unsafe.ReadUnaligned<ulong>((void*)pUtf16Buffer);
					if (!Latin1Utility.AllCharsInUInt64AreLatin1(num))
					{
						goto IL_193;
					}
					Vector<ushort> right = new Vector<ushort>(255);
					UIntPtr uintPtr2 = elementCount - (UIntPtr)(2U * num2);
					do
					{
						Vector<ushort> vector = Unsafe.ReadUnaligned<Vector<ushort>>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL));
						Vector<ushort> vector2 = Unsafe.ReadUnaligned<Vector<ushort>>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL + Vector<ushort>.Count));
						if (Vector.GreaterThanAny<ushort>(Vector.BitwiseOr<ushort>(vector, vector2), right))
						{
							break;
						}
						Vector<byte> value = Vector.Narrow(vector, vector2);
						Unsafe.WriteUnaligned<Vector<byte>>((void*)(pLatin1Buffer + (ulong)uintPtr), value);
						uintPtr += (UIntPtr)num2;
					}
					while (uintPtr <= uintPtr2);
				}
			}
			UIntPtr uintPtr3 = elementCount - uintPtr;
			if (uintPtr3 >= (UIntPtr)((IntPtr)4))
			{
				UIntPtr uintPtr4 = uintPtr + uintPtr3 - (UIntPtr)((IntPtr)4);
				do
				{
					num = Unsafe.ReadUnaligned<ulong>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL));
					if (!Latin1Utility.AllCharsInUInt64AreLatin1(num))
					{
						goto IL_193;
					}
					Latin1Utility.NarrowFourUtf16CharsToLatin1AndWriteToBuffer(ref pLatin1Buffer[(ulong)uintPtr], num);
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (uintPtr <= uintPtr4);
			}
			uint num3;
			if (((uint)uintPtr3 & 2U) != 0U)
			{
				num3 = Unsafe.ReadUnaligned<uint>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL));
				if (!Latin1Utility.AllCharsInUInt32AreLatin1(num3))
				{
					goto IL_1CC;
				}
				Latin1Utility.NarrowTwoUtf16CharsToLatin1AndWriteToBuffer(ref pLatin1Buffer[(ulong)uintPtr], num3);
				uintPtr += (UIntPtr)((IntPtr)2);
			}
			if (((uint)uintPtr3 & 1U) != 0U)
			{
				num3 = (uint)pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL];
				if (num3 <= 255U)
				{
					pLatin1Buffer[(ulong)uintPtr] = (byte)num3;
					uintPtr++;
				}
			}
			return uintPtr;
			IL_193:
			bool isLittleEndian = BitConverter.IsLittleEndian;
			num3 = (uint)num;
			if (Latin1Utility.AllCharsInUInt32AreLatin1(num3))
			{
				Latin1Utility.NarrowTwoUtf16CharsToLatin1AndWriteToBuffer(ref pLatin1Buffer[(ulong)uintPtr], num3);
				bool isLittleEndian2 = BitConverter.IsLittleEndian;
				num3 = (uint)(num >> 32);
				uintPtr += (UIntPtr)((IntPtr)2);
			}
			IL_1CC:
			if (Latin1Utility.FirstCharInUInt32IsLatin1(num3))
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				pLatin1Buffer[(ulong)uintPtr] = (byte)num3;
				return uintPtr + 1;
			}
			return uintPtr;
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00086878 File Offset: 0x00084A78
		private unsafe static UIntPtr NarrowUtf16ToLatin1_Sse2(char* pUtf16Buffer, byte* pLatin1Buffer, UIntPtr elementCount)
		{
			uint num = (uint)sizeof(Vector128<byte>);
			UIntPtr uintPtr = (UIntPtr)(num - 1U);
			Vector128<short> right = Vector128.Create(-256);
			Vector128<ushort> right2 = Vector128.Create(32512);
			Vector128<short> vector = Sse2.LoadVector128((short*)pUtf16Buffer);
			if (Sse41.IsSupported)
			{
				if (!Sse41.TestZ(vector, right))
				{
					return (UIntPtr)((IntPtr)0);
				}
			}
			else if ((Sse2.MoveMask(Sse2.AddSaturate(vector.AsUInt16<short>(), right2).AsByte<ushort>()) & 43690) != 0)
			{
				return (UIntPtr)((IntPtr)0);
			}
			Vector128<byte> vector2 = Sse2.PackUnsignedSaturate(vector, vector);
			Sse2.StoreScalar((ulong*)pLatin1Buffer, vector2.AsUInt64<byte>());
			UIntPtr uintPtr2 = (UIntPtr)(num / 2U);
			if ((pLatin1Buffer & num / 2U) == 0U)
			{
				vector = Sse2.LoadVector128((short*)(pUtf16Buffer + (ulong)uintPtr2 * 2UL / 2UL));
				if (Sse41.IsSupported)
				{
					if (!Sse41.TestZ(vector, right))
					{
						return uintPtr2;
					}
				}
				else if ((Sse2.MoveMask(Sse2.AddSaturate(vector.AsUInt16<short>(), right2).AsByte<ushort>()) & 43690) != 0)
				{
					return uintPtr2;
				}
				vector2 = Sse2.PackUnsignedSaturate(vector, vector);
				Sse2.StoreScalar((ulong*)(pLatin1Buffer + (ulong)uintPtr2), vector2.AsUInt64<byte>());
			}
			uintPtr2 = num - (pLatin1Buffer & uintPtr);
			UIntPtr uintPtr3 = elementCount - (UIntPtr)num;
			for (;;)
			{
				vector = Sse2.LoadVector128((short*)(pUtf16Buffer + (ulong)uintPtr2 * 2UL / 2UL));
				Vector128<short> right3 = Sse2.LoadVector128((short*)(pUtf16Buffer + (ulong)uintPtr2 * 2UL / 2UL + (ulong)(num / 2U) * 2UL / 2UL));
				Vector128<short> vector3 = Sse2.Or(vector, right3);
				if (Sse41.IsSupported)
				{
					if (!Sse41.TestZ(vector3, right))
					{
						break;
					}
				}
				else if ((Sse2.MoveMask(Sse2.AddSaturate(vector3.AsUInt16<short>(), right2).AsByte<ushort>()) & 43690) != 0)
				{
					break;
				}
				vector2 = Sse2.PackUnsignedSaturate(vector, right3);
				Sse2.StoreAligned(pLatin1Buffer + (ulong)uintPtr2, vector2);
				uintPtr2 += (UIntPtr)num;
				if (uintPtr2 > uintPtr3)
				{
					return uintPtr2;
				}
			}
			if (Sse41.IsSupported)
			{
				if (!Sse41.TestZ(vector, right))
				{
					return uintPtr2;
				}
			}
			else if ((Sse2.MoveMask(Sse2.AddSaturate(vector.AsUInt16<short>(), right2).AsByte<ushort>()) & 43690) != 0)
			{
				return uintPtr2;
			}
			vector2 = Sse2.PackUnsignedSaturate(vector, vector);
			Sse2.StoreScalar((ulong*)(pLatin1Buffer + (ulong)uintPtr2), vector2.AsUInt64<byte>());
			uintPtr2 += (UIntPtr)(num / 2U);
			return uintPtr2;
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00086A68 File Offset: 0x00084C68
		public unsafe static void WidenLatin1ToUtf16(byte* pLatin1Buffer, char* pUtf16Buffer, UIntPtr elementCount)
		{
			if (Sse2.IsSupported)
			{
				Latin1Utility.WidenLatin1ToUtf16_Sse2(pLatin1Buffer, pUtf16Buffer, elementCount);
				return;
			}
			Latin1Utility.WidenLatin1ToUtf16_Fallback(pLatin1Buffer, pUtf16Buffer, elementCount);
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x00086A84 File Offset: 0x00084C84
		private unsafe static void WidenLatin1ToUtf16_Sse2(byte* pLatin1Buffer, char* pUtf16Buffer, UIntPtr elementCount)
		{
			uint num = (uint)sizeof(Vector128<byte>);
			UIntPtr uintPtr = (UIntPtr)(num - 1U);
			UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0);
			Vector128<byte> zero = Vector128<byte>.Zero;
			if (elementCount >= (UIntPtr)num)
			{
				Vector128<byte> left = Sse2.LoadScalarVector128((ulong*)pLatin1Buffer).AsByte<ulong>();
				Sse2.Store((byte*)pUtf16Buffer, Sse2.UnpackLow(left, zero));
				uintPtr2 = (num >> 1) - (pUtf16Buffer >> 1 & uintPtr >> 1);
				char* ptr = pUtf16Buffer + (ulong)uintPtr2 * 2UL / 2UL;
				UIntPtr uintPtr3 = elementCount - (UIntPtr)num;
				while (uintPtr2 <= uintPtr3)
				{
					left = Sse2.LoadVector128(pLatin1Buffer + (ulong)uintPtr2);
					Vector128<byte> source = Sse2.UnpackLow(left, zero);
					Sse2.StoreAligned((byte*)ptr, source);
					Vector128<byte> source2 = Sse2.UnpackHigh(left, zero);
					Sse2.StoreAligned((byte*)(ptr + num / 2U), source2);
					uintPtr2 += (UIntPtr)num;
					ptr += (ulong)num * 2UL / 2UL;
				}
			}
			uint num2 = (uint)elementCount - (uint)uintPtr2;
			if ((num2 & 8U) != 0U)
			{
				Vector128<byte> left = Sse2.LoadScalarVector128((ulong*)(pLatin1Buffer + (ulong)uintPtr2)).AsByte<ulong>();
				Sse2.Store((byte*)(pUtf16Buffer + (ulong)uintPtr2 * 2UL / 2UL), Sse2.UnpackLow(left, zero));
				uintPtr2 += (UIntPtr)((IntPtr)8);
			}
			if ((num2 & 4U) != 0U)
			{
				Vector128<byte> left = Sse2.LoadScalarVector128((uint*)(pLatin1Buffer + (ulong)uintPtr2)).AsByte<uint>();
				Sse2.StoreScalar((ulong*)(pUtf16Buffer + (ulong)uintPtr2 * 2UL / 2UL), Sse2.UnpackLow(left, zero).AsUInt64<byte>());
				uintPtr2 += (UIntPtr)((IntPtr)4);
			}
			if ((num2 & 3U) != 0U)
			{
				pUtf16Buffer[(ulong)uintPtr2 * 2UL / 2UL] = (char)pLatin1Buffer[(ulong)uintPtr2];
				if ((num2 & 2U) != 0U)
				{
					pUtf16Buffer[(ulong)(uintPtr2 + (UIntPtr)((IntPtr)1)) * 2UL / 2UL] = (char)pLatin1Buffer[(ulong)(uintPtr2 + (UIntPtr)((IntPtr)1))];
					if ((num2 & 1U) != 0U)
					{
						pUtf16Buffer[(ulong)(uintPtr2 + (UIntPtr)((IntPtr)2)) * 2UL / 2UL] = (char)pLatin1Buffer[(ulong)(uintPtr2 + (UIntPtr)((IntPtr)2))];
					}
				}
			}
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x00086BEC File Offset: 0x00084DEC
		private unsafe static void WidenLatin1ToUtf16_Fallback(byte* pLatin1Buffer, char* pUtf16Buffer, UIntPtr elementCount)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			if (Vector.IsHardwareAccelerated)
			{
				uint count = (uint)Vector<byte>.Count;
				if (elementCount >= (UIntPtr)count)
				{
					UIntPtr uintPtr2 = elementCount - (UIntPtr)count;
					do
					{
						Vector<ushort> value;
						Vector<ushort> value2;
						Vector.Widen(Vector.AsVectorByte<byte>(Unsafe.ReadUnaligned<Vector<byte>>((void*)(pLatin1Buffer + (ulong)uintPtr))), out value, out value2);
						Unsafe.WriteUnaligned<Vector<ushort>>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL), value);
						Unsafe.WriteUnaligned<Vector<ushort>>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL + Vector<ushort>.Count), value2);
						uintPtr += (UIntPtr)count;
					}
					while (uintPtr <= uintPtr2);
				}
			}
			while (uintPtr < elementCount)
			{
				pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL] = (char)pLatin1Buffer[(ulong)uintPtr];
				uintPtr++;
			}
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x00086C73 File Offset: 0x00084E73
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInUInt32AreLatin1(uint value)
		{
			return (value & 4278255360U) == 0U;
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x00086C7F File Offset: 0x00084E7F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInUInt64AreLatin1(ulong value)
		{
			return (value & 18374966859414961920UL) == 0UL;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00086C90 File Offset: 0x00084E90
		private static bool FirstCharInUInt32IsLatin1(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 65280U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x00086CAC File Offset: 0x00084EAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void NarrowFourUtf16CharsToLatin1AndWriteToBuffer(ref byte outputBuffer, ulong value)
		{
			if (Sse2.X64.IsSupported)
			{
				Vector128<short> vector = Sse2.X64.ConvertScalarToVector128UInt64(value).AsInt16<ulong>();
				Vector128<uint> value2 = Sse2.PackUnsignedSaturate(vector, vector).AsUInt32<byte>();
				Unsafe.WriteUnaligned<uint>(ref outputBuffer, Sse2.ConvertToUInt32(value2));
				return;
			}
			bool isLittleEndian = BitConverter.IsLittleEndian;
			outputBuffer = (byte)value;
			value >>= 16;
			*Unsafe.Add<byte>(ref outputBuffer, 1) = (byte)value;
			value >>= 16;
			*Unsafe.Add<byte>(ref outputBuffer, 2) = (byte)value;
			value >>= 16;
			*Unsafe.Add<byte>(ref outputBuffer, 3) = (byte)value;
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0007F8C9 File Offset: 0x0007DAC9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void NarrowTwoUtf16CharsToLatin1AndWriteToBuffer(ref byte outputBuffer, uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			outputBuffer = (byte)value;
			*Unsafe.Add<byte>(ref outputBuffer, 1) = (byte)(value >> 16);
		}
	}
}
