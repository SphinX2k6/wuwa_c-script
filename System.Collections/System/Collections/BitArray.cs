using System;
using System.Buffers.Binary;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace System.Collections
{
	// Token: 0x02000004 RID: 4
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class BitArray : ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000022F5 File Offset: 0x000004F5
		public BitArray(int length) : this(length, false)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002300 File Offset: 0x00000500
		public BitArray(int length, bool defaultValue)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			this.m_array = new int[BitArray.GetInt32ArrayLengthFromBitLength(length)];
			this.m_length = length;
			if (defaultValue)
			{
				Array.Fill<int>(this.m_array, -1);
				int num;
				BitArray.Div32Rem(length, out num);
				if (num > 0)
				{
					int[] array = this.m_array;
					array[array.Length - 1] = (1 << num) - 1;
				}
			}
			this._version = 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002370 File Offset: 0x00000570
		public unsafe BitArray(byte[] bytes)
		{
			ArgumentNullException.ThrowIfNull(bytes, "bytes");
			if (bytes.Length > 268435455)
			{
				throw new ArgumentException(SR.Format(SR.Argument_ArrayTooLarge, 8), "bytes");
			}
			this.m_array = new int[BitArray.GetInt32ArrayLengthFromByteLength(bytes.Length)];
			this.m_length = bytes.Length * 8;
			uint num = (uint)(bytes.Length / 4);
			ReadOnlySpan<byte> source = bytes;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				this.m_array[num2] = BinaryPrimitives.ReadInt32LittleEndian(source);
				source = source.Slice(4);
				num2++;
			}
			int num3 = 0;
			switch (source.Length)
			{
			case 1:
				goto IL_C3;
			case 2:
				break;
			case 3:
				num3 = (int)(*source[2]) << 16;
				break;
			default:
				goto IL_D6;
			}
			num3 |= (int)(*source[1]) << 8;
			IL_C3:
			this.m_array[(int)num] = (num3 | (int)(*source[0]));
			IL_D6:
			this._version = 0;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000245C File Offset: 0x0000065C
		public BitArray(bool[] values)
		{
			ArgumentNullException.ThrowIfNull(values, "values");
			this.m_array = new int[BitArray.GetInt32ArrayLengthFromBitLength(values.Length)];
			this.m_length = values.Length;
			uint num = 0U;
			if (values.Length >= Vector256<byte>.Count)
			{
				ref byte source = ref Unsafe.As<bool, byte>(MemoryMarshal.GetArrayDataReference<bool>(values));
				if (Vector512.IsHardwareAccelerated)
				{
					while ((ulong)num <= (ulong)values.Length - (ulong)((long)Vector512<byte>.Count))
					{
						ulong num2 = Vector512.Equals<byte>(Vector512.LoadUnsafe<byte>(ref source, (UIntPtr)num), Vector512<byte>.Zero).ExtractMostSignificantBits<byte>();
						this.m_array[(int)(num / 32U)] = (int)(~num2 & (ulong)-1);
						this.m_array[(int)(num / 32U + 1U)] = (int)(~num2 >> 32 & (ulong)-1);
						num += (uint)Vector512<byte>.Count;
					}
				}
				else if (Vector256.IsHardwareAccelerated)
				{
					while ((ulong)num <= (ulong)values.Length - (ulong)((long)Vector256<byte>.Count))
					{
						uint num3 = Vector256.Equals<byte>(Vector256.LoadUnsafe<byte>(ref source, (UIntPtr)num), Vector256<byte>.Zero).ExtractMostSignificantBits<byte>();
						this.m_array[(int)(num / 32U)] = (int)(~(int)num3);
						num += (uint)Vector256<byte>.Count;
					}
				}
				else if (Vector128.IsHardwareAccelerated)
				{
					while ((ulong)num <= (ulong)values.Length - (ulong)((long)Vector128<byte>.Count * 2L))
					{
						uint num4 = Vector128.Equals<byte>(Vector128.LoadUnsafe<byte>(ref source, (UIntPtr)num), Vector128<byte>.Zero).ExtractMostSignificantBits<byte>();
						uint num5 = Vector128.Equals<byte>(Vector128.LoadUnsafe<byte>(ref source, (UIntPtr)(num + (uint)Vector128<byte>.Count)), Vector128<byte>.Zero).ExtractMostSignificantBits<byte>();
						this.m_array[(int)(num / 32U)] = (int)(~(int)(num5 << 16 | num4));
						num += (uint)(Vector128<byte>.Count * 2);
					}
				}
			}
			while (num < (uint)values.Length)
			{
				if (values[(int)num])
				{
					int num7;
					int num6 = BitArray.Div32Rem((int)num, out num7);
					this.m_array[num6] |= 1 << num7;
				}
				num += 1U;
			}
			this._version = 0;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002610 File Offset: 0x00000810
		public BitArray(int[] values)
		{
			ArgumentNullException.ThrowIfNull(values, "values");
			if (values.Length > 67108863)
			{
				throw new ArgumentException(SR.Format(SR.Argument_ArrayTooLarge, 32), "values");
			}
			this.m_array = new int[values.Length];
			Array.Copy(values, this.m_array, values.Length);
			this.m_length = values.Length * 32;
			this._version = 0;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002684 File Offset: 0x00000884
		public BitArray(BitArray bits)
		{
			ArgumentNullException.ThrowIfNull(bits, "bits");
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(bits.m_length);
			this.m_array = new int[int32ArrayLengthFromBitLength];
			Array.Copy(bits.m_array, this.m_array, int32ArrayLengthFromBitLength);
			this.m_length = bits.m_length;
			this._version = bits._version;
		}

		// Token: 0x17000024 RID: 36
		public bool this[int index]
		{
			get
			{
				return this.Get(index);
			}
			set
			{
				this.Set(index, value);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000026F7 File Offset: 0x000008F7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Get(int index)
		{
			if (index >= this.m_length)
			{
				BitArray.ThrowArgumentOutOfRangeException(index);
			}
			return (this.m_array[index >> 5] & 1 << index) != 0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000271C File Offset: 0x0000091C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(int index, bool value)
		{
			if (index >= this.m_length)
			{
				BitArray.ThrowArgumentOutOfRangeException(index);
			}
			int num = 1 << index;
			ref int ptr = ref this.m_array[index >> 5];
			if (value)
			{
				ptr |= num;
			}
			else
			{
				ptr &= ~num;
			}
			this._version++;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002770 File Offset: 0x00000970
		public unsafe void SetAll(bool value)
		{
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(this.Length);
			Span<int> span = this.m_array.AsSpan(0, int32ArrayLengthFromBitLength);
			if (value)
			{
				span.Fill(-1);
				int num;
				BitArray.Div32Rem(this.m_length, out num);
				if (num > 0)
				{
					*span[span.Length - 1] &= (1 << num) - 1;
				}
			}
			else
			{
				span.Clear();
			}
			this._version++;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000027E8 File Offset: 0x000009E8
		public BitArray And(BitArray value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			int[] array = this.m_array;
			int[] array2 = value.m_array;
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(this.Length);
			if (this.Length != value.Length || int32ArrayLengthFromBitLength > array.Length || int32ArrayLengthFromBitLength > array2.Length)
			{
				throw new ArgumentException(SR.Arg_ArrayLengthsDiffer);
			}
			switch (int32ArrayLengthFromBitLength)
			{
			case 0:
				goto IL_1EB;
			case 1:
				goto IL_C6;
			case 2:
				goto IL_B8;
			case 3:
				goto IL_AA;
			case 4:
				goto IL_9C;
			case 5:
				goto IL_8E;
			case 6:
				break;
			case 7:
				array[6] &= array2[6];
				break;
			default:
			{
				uint num = 0U;
				ref int arrayDataReference = ref MemoryMarshal.GetArrayDataReference<int>(array);
				ref int arrayDataReference2 = ref MemoryMarshal.GetArrayDataReference<int>(array2);
				if (Vector512.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector512<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector512<int>.Count - 1L))
					{
						(Vector512.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) & Vector512.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector512<int>.Count;
					}
				}
				else if (Vector256.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector256<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector256<int>.Count - 1L))
					{
						(Vector256.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) & Vector256.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector256<int>.Count;
					}
				}
				else if (Vector128.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector128<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector128<int>.Count - 1L))
					{
						(Vector128.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) & Vector128.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector128<int>.Count;
					}
				}
				while (num < (uint)int32ArrayLengthFromBitLength)
				{
					array[(int)num] &= array2[(int)num];
					num += 1U;
				}
				goto IL_1EB;
			}
			}
			array[5] &= array2[5];
			IL_8E:
			array[4] &= array2[4];
			IL_9C:
			array[3] &= array2[3];
			IL_AA:
			array[2] &= array2[2];
			IL_B8:
			array[1] &= array2[1];
			IL_C6:
			array[0] &= array2[0];
			IL_1EB:
			this._version++;
			return this;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000029F0 File Offset: 0x00000BF0
		public BitArray Or(BitArray value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			int[] array = this.m_array;
			int[] array2 = value.m_array;
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(this.Length);
			if (this.Length != value.Length || int32ArrayLengthFromBitLength > array.Length || int32ArrayLengthFromBitLength > array2.Length)
			{
				throw new ArgumentException(SR.Arg_ArrayLengthsDiffer);
			}
			switch (int32ArrayLengthFromBitLength)
			{
			case 0:
				goto IL_1EB;
			case 1:
				goto IL_C6;
			case 2:
				goto IL_B8;
			case 3:
				goto IL_AA;
			case 4:
				goto IL_9C;
			case 5:
				goto IL_8E;
			case 6:
				break;
			case 7:
				array[6] |= array2[6];
				break;
			default:
			{
				uint num = 0U;
				ref int arrayDataReference = ref MemoryMarshal.GetArrayDataReference<int>(array);
				ref int arrayDataReference2 = ref MemoryMarshal.GetArrayDataReference<int>(array2);
				if (Vector512.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector512<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector512<int>.Count - 1L))
					{
						(Vector512.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) | Vector512.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector512<int>.Count;
					}
				}
				else if (Vector256.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector256<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector256<int>.Count - 1L))
					{
						(Vector256.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) | Vector256.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector256<int>.Count;
					}
				}
				else if (Vector128.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector128<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector128<int>.Count - 1L))
					{
						(Vector128.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) | Vector128.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector128<int>.Count;
					}
				}
				while (num < (uint)int32ArrayLengthFromBitLength)
				{
					array[(int)num] |= array2[(int)num];
					num += 1U;
				}
				goto IL_1EB;
			}
			}
			array[5] |= array2[5];
			IL_8E:
			array[4] |= array2[4];
			IL_9C:
			array[3] |= array2[3];
			IL_AA:
			array[2] |= array2[2];
			IL_B8:
			array[1] |= array2[1];
			IL_C6:
			array[0] |= array2[0];
			IL_1EB:
			this._version++;
			return this;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public BitArray Xor(BitArray value)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			int[] array = this.m_array;
			int[] array2 = value.m_array;
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(this.Length);
			if (this.Length != value.Length || int32ArrayLengthFromBitLength > array.Length || int32ArrayLengthFromBitLength > array2.Length)
			{
				throw new ArgumentException(SR.Arg_ArrayLengthsDiffer);
			}
			switch (int32ArrayLengthFromBitLength)
			{
			case 0:
				goto IL_1EB;
			case 1:
				goto IL_C6;
			case 2:
				goto IL_B8;
			case 3:
				goto IL_AA;
			case 4:
				goto IL_9C;
			case 5:
				goto IL_8E;
			case 6:
				break;
			case 7:
				array[6] ^= array2[6];
				break;
			default:
			{
				uint num = 0U;
				ref int arrayDataReference = ref MemoryMarshal.GetArrayDataReference<int>(array);
				ref int arrayDataReference2 = ref MemoryMarshal.GetArrayDataReference<int>(array2);
				if (Vector512.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector512<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector512<int>.Count - 1L))
					{
						(Vector512.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) ^ Vector512.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector512<int>.Count;
					}
				}
				else if (Vector256.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector256<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector256<int>.Count - 1L))
					{
						(Vector256.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) ^ Vector256.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector256<int>.Count;
					}
				}
				else if (Vector128.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector128<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector128<int>.Count - 1L))
					{
						(Vector128.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num) ^ Vector128.LoadUnsafe<int>(ref arrayDataReference2, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector128<int>.Count;
					}
				}
				while (num < (uint)int32ArrayLengthFromBitLength)
				{
					array[(int)num] ^= array2[(int)num];
					num += 1U;
				}
				goto IL_1EB;
			}
			}
			array[5] ^= array2[5];
			IL_8E:
			array[4] ^= array2[4];
			IL_9C:
			array[3] ^= array2[3];
			IL_AA:
			array[2] ^= array2[2];
			IL_B8:
			array[1] ^= array2[1];
			IL_C6:
			array[0] ^= array2[0];
			IL_1EB:
			this._version++;
			return this;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002E00 File Offset: 0x00001000
		public BitArray Not()
		{
			int[] array = this.m_array;
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(this.Length);
			switch (int32ArrayLengthFromBitLength)
			{
			case 0:
				goto IL_152;
			case 1:
				goto IL_65;
			case 2:
				goto IL_5E;
			case 3:
				goto IL_57;
			case 4:
				goto IL_50;
			case 5:
				goto IL_49;
			case 6:
				break;
			case 7:
				array[6] = ~array[6];
				break;
			default:
			{
				uint num = 0U;
				ref int arrayDataReference = ref MemoryMarshal.GetArrayDataReference<int>(array);
				if (Vector512.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector512<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector512<int>.Count - 1L))
					{
						(~Vector512.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector512<int>.Count;
					}
				}
				else if (Vector256.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector256<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector256<int>.Count - 1L))
					{
						(~Vector256.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector256<int>.Count;
					}
				}
				else if (Vector128.IsHardwareAccelerated && (ulong)int32ArrayLengthFromBitLength >= (ulong)((long)Vector128<int>.Count))
				{
					while ((ulong)num < (ulong)int32ArrayLengthFromBitLength - (ulong)((long)Vector128<int>.Count - 1L))
					{
						(~Vector128.LoadUnsafe<int>(ref arrayDataReference, (UIntPtr)num)).StoreUnsafe(ref arrayDataReference, (UIntPtr)num);
						num += (uint)Vector128<int>.Count;
					}
				}
				while (num < (uint)int32ArrayLengthFromBitLength)
				{
					array[(int)num] = ~array[(int)num];
					num += 1U;
				}
				goto IL_152;
			}
			}
			array[5] = ~array[5];
			IL_49:
			array[4] = ~array[4];
			IL_50:
			array[3] = ~array[3];
			IL_57:
			array[2] = ~array[2];
			IL_5E:
			array[1] = ~array[1];
			IL_65:
			array[0] = ~array[0];
			IL_152:
			this._version++;
			return this;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002F70 File Offset: 0x00001170
		public BitArray RightShift(int count)
		{
			if (count <= 0)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				this._version++;
				return this;
			}
			int num = 0;
			int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(this.m_length);
			if (count < this.m_length)
			{
				int num2;
				int i = BitArray.Div32Rem(count, out num2);
				int num3;
				BitArray.Div32Rem(this.m_length, out num3);
				if (num2 == 0)
				{
					uint num4 = uint.MaxValue >> 32 - num3;
					this.m_array[int32ArrayLengthFromBitLength - 1] &= (int)num4;
					Array.Copy(this.m_array, i, this.m_array, 0, int32ArrayLengthFromBitLength - i);
					num = int32ArrayLengthFromBitLength - i;
				}
				else
				{
					int num5 = int32ArrayLengthFromBitLength - 1;
					while (i < num5)
					{
						uint num6 = (uint)this.m_array[i] >> num2;
						int num7 = this.m_array[++i] << (32 - num2 & 31);
						this.m_array[num++] = (num7 | (int)num6);
					}
					uint num8 = uint.MaxValue >> 32 - num3;
					num8 &= (uint)this.m_array[i];
					this.m_array[num++] = (int)(num8 >> num2);
				}
			}
			this.m_array.AsSpan(num, int32ArrayLengthFromBitLength - num).Clear();
			this._version++;
			return this;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000030A4 File Offset: 0x000012A4
		public BitArray LeftShift(int count)
		{
			if (count <= 0)
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
				this._version++;
				return this;
			}
			int num2;
			if (count < this.m_length)
			{
				int num = this.m_length - 1 >> 5;
				int num3;
				num2 = BitArray.Div32Rem(count, out num3);
				if (num3 == 0)
				{
					Array.Copy(this.m_array, 0, this.m_array, num2, num + 1 - num2);
				}
				else
				{
					int i = num - num2;
					while (i > 0)
					{
						int num4 = this.m_array[i] << num3;
						uint num5 = (uint)this.m_array[--i] >> (32 - num3 & 31);
						this.m_array[num] = (num4 | (int)num5);
						num--;
					}
					this.m_array[num] = this.m_array[i] << num3;
				}
			}
			else
			{
				num2 = BitArray.GetInt32ArrayLengthFromBitLength(this.m_length);
			}
			this.m_array.AsSpan(0, num2).Clear();
			this._version++;
			return this;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003195 File Offset: 0x00001395
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000031A0 File Offset: 0x000013A0
		public int Length
		{
			get
			{
				return this.m_length;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(value, "value");
				int int32ArrayLengthFromBitLength = BitArray.GetInt32ArrayLengthFromBitLength(value);
				if (int32ArrayLengthFromBitLength > this.m_array.Length || int32ArrayLengthFromBitLength + 256 < this.m_array.Length)
				{
					Array.Resize<int>(ref this.m_array, int32ArrayLengthFromBitLength);
				}
				if (value > this.m_length)
				{
					int num = this.m_length - 1 >> 5;
					int num2;
					BitArray.Div32Rem(this.m_length, out num2);
					if (num2 > 0)
					{
						this.m_array[num] &= (1 << num2) - 1;
					}
					this.m_array.AsSpan(num + 1, int32ArrayLengthFromBitLength - num - 1).Clear();
				}
				this.m_length = value;
				this._version++;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003258 File Offset: 0x00001458
		public unsafe void CopyTo(Array array, int index)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(index, "index");
			if (array.Rank != 1)
			{
				throw new ArgumentException(SR.Arg_RankMultiDimNotSupported, "array");
			}
			int[] array2 = array as int[];
			if (array2 != null)
			{
				if (array.Length - index < BitArray.GetInt32ArrayLengthFromBitLength(this.m_length))
				{
					throw new ArgumentException(SR.Argument_InvalidOffLen);
				}
				int num2;
				int num = BitArray.Div32Rem(this.m_length, out num2);
				Array.Copy(this.m_array, 0, array2, index, num);
				if (num2 > 0)
				{
					array2[index + num] = (this.m_array[num] & (1 << num2) - 1);
					return;
				}
				return;
			}
			else
			{
				byte[] array3 = array as byte[];
				if (array3 != null)
				{
					int num3 = BitArray.GetByteArrayLengthFromBitLength(this.m_length);
					if (array.Length - index < num3)
					{
						throw new ArgumentException(SR.Argument_InvalidOffLen);
					}
					uint num4 = (uint)(this.m_length & 7);
					if (num4 > 0U)
					{
						num3--;
					}
					Span<byte> destination = array3.AsSpan(index);
					int num6;
					int num5 = BitArray.Div4Rem(num3, out num6);
					for (int i = 0; i < num5; i++)
					{
						BinaryPrimitives.WriteInt32LittleEndian(destination, this.m_array[i]);
						destination = destination.Slice(4);
					}
					if (num4 > 0U)
					{
						*destination[num6] = (byte)(this.m_array[num5] >> num6 * 8 & (1 << (int)num4) - 1);
					}
					switch (num6)
					{
					case 1:
						goto IL_185;
					case 2:
						break;
					case 3:
						*destination[2] = (byte)(this.m_array[num5] >> 16);
						break;
					default:
						return;
					}
					*destination[1] = (byte)(this.m_array[num5] >> 8);
					IL_185:
					*destination[0] = (byte)this.m_array[num5];
					return;
				}
				else
				{
					bool[] array4 = array as bool[];
					if (array4 == null)
					{
						throw new ArgumentException(SR.Arg_BitArrayTypeUnsupported, "array");
					}
					if (array.Length - index < this.m_length)
					{
						throw new ArgumentException(SR.Argument_InvalidOffLen);
					}
					uint num7 = 0U;
					if (this.m_length >= 32)
					{
						Vector128<byte> vector = Vector128.Create(0L, 72340172838076673L).AsByte<long>();
						Vector128<byte> vector2 = Vector128.Create(144680345676153346L, 217020518514230019L).AsByte<long>();
						if (Avx512F.IsSupported && (ulong)this.m_length >= (ulong)((long)Vector512<byte>.Count))
						{
							Vector256<byte> upper = Vector256.Create(289360691352306692L, 361700864190383365L, 434041037028460038L, 506381209866536711L).AsByte<long>();
							Vector512<byte> mask = Vector512.Create(Vector256.Create(vector, vector2), upper);
							Vector512<byte> right = Vector512.Create(9241421688590303745UL).AsByte<ulong>();
							Vector512<byte> right2 = Vector512.Create(1);
							fixed (bool* ptr = &array4[index])
							{
								bool* ptr2 = ptr;
								while ((ulong)num7 + (ulong)((long)Vector512<byte>.Count) <= (ulong)this.m_length)
								{
									Vector512<byte> source = Avx512BW.Min(Avx512F.And(Avx512BW.Shuffle(Vector512.Create((ulong)this.m_array[(int)(num7 / 32U)] + (ulong)((ulong)((long)this.m_array[(int)(num7 / 32U + 1U)]) << 32)).AsByte<ulong>(), mask), right), right2);
									Avx512F.Store((byte*)(ptr2 + num7), source);
									num7 += (uint)Vector512<byte>.Count;
								}
							}
						}
						else if (Avx2.IsSupported && (ulong)this.m_length >= (ulong)((long)Vector256<byte>.Count))
						{
							Vector256<byte> mask2 = Vector256.Create(vector, vector2);
							Vector256<byte> right3 = Vector256.Create(9241421688590303745UL).AsByte<ulong>();
							Vector256<byte> right4 = Vector256.Create(1);
							fixed (bool* ptr = &array4[index])
							{
								bool* ptr3 = ptr;
								while ((ulong)num7 + (ulong)((long)Vector256<byte>.Count) <= (ulong)this.m_length)
								{
									Vector256<byte> source2 = Avx2.Min(Avx2.And(Avx2.Shuffle(Vector256.Create(this.m_array[(int)(num7 / 32U)]).AsByte<int>(), mask2), right3), right4);
									Avx.Store((byte*)(ptr3 + num7), source2);
									num7 += (uint)Vector256<byte>.Count;
								}
							}
						}
						else if (Ssse3.IsSupported && (ulong)this.m_length >= (ulong)((long)Vector512<byte>.Count * 2L))
						{
							Vector128<byte> mask3 = vector;
							Vector128<byte> mask4 = vector2;
							Vector128<byte> right5 = Vector128.Create(1);
							Vector128<byte> right6 = BitConverter.IsLittleEndian ? Vector128.Create(9241421688590303745UL).AsByte<ulong>() : Vector128.Create(72624976668147840L).AsByte<long>();
							fixed (bool* ptr = &array4[index])
							{
								bool* ptr4 = ptr;
								while ((ulong)num7 + (ulong)((long)Vector128<byte>.Count * 2L) <= (ulong)this.m_length)
								{
									Vector128<int> vector3 = Vector128.CreateScalarUnsafe(this.m_array[(int)(num7 / 32U)]);
									Vector128<byte> source3 = Sse2.Min(Sse2.And(Ssse3.Shuffle(vector3.AsByte<int>(), mask3), right6), right5);
									Sse2.Store((byte*)(ptr4 + num7), source3);
									Vector128<byte> source4 = Sse2.Min(Sse2.And(Ssse3.Shuffle(vector3.AsByte<int>(), mask4), right6), right5);
									Sse2.Store((byte*)(ptr4 + num7 + Vector128<byte>.Count), source4);
									num7 += (uint)(Vector128<byte>.Count * 2);
								}
							}
						}
						else if (AdvSimd.Arm64.IsSupported)
						{
							Vector128<byte> right7 = Vector128.Create(1);
							Vector128<byte> right8 = BitConverter.IsLittleEndian ? Vector128.Create(9241421688590303745UL).AsByte<ulong>() : Vector128.Create(72624976668147840L).AsByte<long>();
							fixed (bool* ptr = &array4[index])
							{
								bool* ptr5 = ptr;
								while ((ulong)num7 + (ulong)((long)Vector128<byte>.Count * 2L) <= (ulong)this.m_length)
								{
									int value = this.m_array[(int)(num7 / 32U)];
									if (!BitConverter.IsLittleEndian)
									{
										value = BinaryPrimitives.ReverseEndianness(value);
									}
									Vector128<byte> vector4 = Vector128.Create(value).AsByte<int>();
									Vector128<byte> vector5 = AdvSimd.Arm64.ZipLow(vector4, vector4);
									Vector128<byte> vector6 = AdvSimd.Arm64.ZipLow(vector5, vector5);
									Vector128<byte> value2 = AdvSimd.Min(AdvSimd.And(AdvSimd.Arm64.ZipLow(vector6, vector6), right8), right7);
									Vector128<byte> value3 = AdvSimd.Min(AdvSimd.And(AdvSimd.Arm64.ZipHigh(vector6, vector6), right8), right7);
									AdvSimd.Arm64.StorePair((byte*)(ptr5 + num7), value2, value3);
									num7 += (uint)(Vector128<byte>.Count * 2);
								}
							}
						}
					}
					while (num7 < (uint)this.m_length)
					{
						int num9;
						int num8 = BitArray.Div32Rem((int)num7, out num9);
						array4[index + (int)num7] = ((this.m_array[num8] >> num9 & 1) != 0);
						num7 += 1U;
					}
					return;
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003864 File Offset: 0x00001A64
		public bool HasAllSet()
		{
			int num;
			BitArray.Div32Rem(this.m_length, out num);
			int num2 = BitArray.GetInt32ArrayLengthFromBitLength(this.m_length);
			if (num != 0)
			{
				num2--;
			}
			if (this.m_array.AsSpan(0, num2).ContainsAnyExcept(-1))
			{
				return false;
			}
			if (num == 0)
			{
				return true;
			}
			int num3 = (1 << num) - 1;
			return (this.m_array[num2] & num3) == num3;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000038C4 File Offset: 0x00001AC4
		public bool HasAnySet()
		{
			int num;
			BitArray.Div32Rem(this.m_length, out num);
			int num2 = BitArray.GetInt32ArrayLengthFromBitLength(this.m_length);
			if (num != 0)
			{
				num2--;
			}
			return this.m_array.AsSpan(0, num2).ContainsAnyExcept(0) || (num != 0 && (this.m_array[num2] & (1 << num) - 1) != 0);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003195 File Offset: 0x00001395
		public int Count
		{
			get
			{
				return this.m_length;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003922 File Offset: 0x00001B22
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003925 File Offset: 0x00001B25
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003925 File Offset: 0x00001B25
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003928 File Offset: 0x00001B28
		public object Clone()
		{
			return new BitArray(this);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003930 File Offset: 0x00001B30
		public IEnumerator GetEnumerator()
		{
			return new BitArray.BitArrayEnumeratorSimple(this);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003938 File Offset: 0x00001B38
		private static int GetInt32ArrayLengthFromBitLength(int n)
		{
			return (int)((uint)(n - 1 + 32) >> 5);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003942 File Offset: 0x00001B42
		private static int GetInt32ArrayLengthFromByteLength(int n)
		{
			return (int)((uint)(n - 1 + 4) >> 2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000394B File Offset: 0x00001B4B
		private static int GetByteArrayLengthFromBitLength(int n)
		{
			return (int)((uint)(n - 1 + 8) >> 3);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003954 File Offset: 0x00001B54
		private static int Div32Rem(int number, out int remainder)
		{
			int result = number / 32;
			remainder = (number & 31);
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003960 File Offset: 0x00001B60
		private static int Div4Rem(int number, out int remainder)
		{
			int result = number / 4;
			remainder = (number & 3);
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000396A File Offset: 0x00001B6A
		private static void ThrowArgumentOutOfRangeException(int index)
		{
			throw new ArgumentOutOfRangeException("index", index, SR.ArgumentOutOfRange_IndexMustBeLess);
		}

		// Token: 0x04000003 RID: 3
		private int[] m_array;

		// Token: 0x04000004 RID: 4
		private int m_length;

		// Token: 0x04000005 RID: 5
		private int _version;

		// Token: 0x02000005 RID: 5
		private sealed class BitArrayEnumeratorSimple : IEnumerator, ICloneable
		{
			// Token: 0x0600004B RID: 75 RVA: 0x00003981 File Offset: 0x00001B81
			internal BitArrayEnumeratorSimple(BitArray bitArray)
			{
				this._bitArray = bitArray;
				this._index = -1;
				this._version = bitArray._version;
			}

			// Token: 0x0600004C RID: 76 RVA: 0x000039A3 File Offset: 0x00001BA3
			public object Clone()
			{
				return base.MemberwiseClone();
			}

			// Token: 0x0600004D RID: 77 RVA: 0x000039AC File Offset: 0x00001BAC
			public bool MoveNext()
			{
				if (this._version != this._bitArray._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				if (this._index < this._bitArray.m_length - 1)
				{
					this._index++;
					this._currentElement = this._bitArray.Get(this._index);
					return true;
				}
				this._index = this._bitArray.m_length;
				return false;
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00003A25 File Offset: 0x00001C25
			public object Current
			{
				get
				{
					if (this._index >= this._bitArray.m_length)
					{
						throw this.GetInvalidOperationException(this._index);
					}
					return this._currentElement;
				}
			}

			// Token: 0x0600004F RID: 79 RVA: 0x00003A52 File Offset: 0x00001C52
			public void Reset()
			{
				if (this._version != this._bitArray._version)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumFailedVersion);
				}
				this._index = -1;
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00003A79 File Offset: 0x00001C79
			private InvalidOperationException GetInvalidOperationException(int index)
			{
				if (index == -1)
				{
					return new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
				}
				return new InvalidOperationException(SR.InvalidOperation_EnumEnded);
			}

			// Token: 0x04000006 RID: 6
			private readonly BitArray _bitArray;

			// Token: 0x04000007 RID: 7
			private int _index;

			// Token: 0x04000008 RID: 8
			private readonly int _version;

			// Token: 0x04000009 RID: 9
			private bool _currentElement;
		}
	}
}
