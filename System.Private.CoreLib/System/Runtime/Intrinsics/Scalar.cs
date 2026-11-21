using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000541 RID: 1345
	internal static class Scalar<T>
	{
		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060049D6 RID: 18902 RVA: 0x000F3950 File Offset: 0x000F1B50
		public static T AllBitsSet
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (typeof(T) == typeof(byte))
				{
					return (T)((object)byte.MaxValue);
				}
				if (typeof(T) == typeof(double))
				{
					return (T)((object)BitConverter.Int64BitsToDouble(-1L));
				}
				if (typeof(T) == typeof(short))
				{
					return (T)((object)-1);
				}
				if (typeof(T) == typeof(int))
				{
					return (T)((object)-1);
				}
				if (typeof(T) == typeof(long))
				{
					return (T)((object)-1L);
				}
				if (typeof(T) == typeof(IntPtr))
				{
					return (T)((object)((IntPtr)(-1)));
				}
				if (typeof(T) == typeof(UIntPtr))
				{
					return (T)((object)UIntPtr.MaxValue);
				}
				if (typeof(T) == typeof(sbyte))
				{
					return (T)((object)-1);
				}
				if (typeof(T) == typeof(float))
				{
					return (T)((object)BitConverter.Int32BitsToSingle(-1));
				}
				if (typeof(T) == typeof(ushort))
				{
					return (T)((object)ushort.MaxValue);
				}
				if (typeof(T) == typeof(uint))
				{
					return (T)((object)uint.MaxValue);
				}
				if (typeof(T) == typeof(ulong))
				{
					return (T)((object)ulong.MaxValue);
				}
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
				return default(T);
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060049D7 RID: 18903 RVA: 0x000F3B5C File Offset: 0x000F1D5C
		public static T One
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (typeof(T) == typeof(byte))
				{
					return (T)((object)1);
				}
				if (typeof(T) == typeof(double))
				{
					return (T)((object)1.0);
				}
				if (typeof(T) == typeof(short))
				{
					return (T)((object)1);
				}
				if (typeof(T) == typeof(int))
				{
					return (T)((object)1);
				}
				if (typeof(T) == typeof(long))
				{
					return (T)((object)1L);
				}
				if (typeof(T) == typeof(IntPtr))
				{
					return (T)((object)((IntPtr)1));
				}
				if (typeof(T) == typeof(UIntPtr))
				{
					return (T)((object)((UIntPtr)((IntPtr)1)));
				}
				if (typeof(T) == typeof(sbyte))
				{
					return (T)((object)1);
				}
				if (typeof(T) == typeof(float))
				{
					return (T)((object)1f);
				}
				if (typeof(T) == typeof(ushort))
				{
					return (T)((object)1);
				}
				if (typeof(T) == typeof(uint))
				{
					return (T)((object)1U);
				}
				if (typeof(T) == typeof(ulong))
				{
					return (T)((object)1UL);
				}
				ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
				return default(T);
			}
		}

		// Token: 0x060049D8 RID: 18904 RVA: 0x000F3D60 File Offset: 0x000F1F60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Abs(T value)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)Math.Abs((double)((object)value)));
			}
			if (typeof(T) == typeof(short))
			{
				short num = (short)((object)value);
				if (num < 0)
				{
					num = -num;
				}
				return (T)((object)num);
			}
			if (typeof(T) == typeof(int))
			{
				int num2 = (int)((object)value);
				if (num2 < 0)
				{
					num2 = -num2;
				}
				return (T)((object)num2);
			}
			if (typeof(T) == typeof(long))
			{
				long num3 = (long)((object)value);
				if (num3 < 0L)
				{
					num3 = -num3;
				}
				return (T)((object)num3);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				if (intPtr < (IntPtr)0)
				{
					intPtr = -intPtr;
				}
				return (T)((object)intPtr);
			}
			if (typeof(T) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				if (b < 0)
				{
					b = -b;
				}
				return (T)((object)b);
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)Math.Abs((float)((object)value)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049D9 RID: 18905 RVA: 0x000F3F18 File Offset: 0x000F2118
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Add(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((object)left) + (byte)((object)right)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)((double)((object)left) + (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((object)left) + (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)left) + (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)left) + (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)left) + (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)left) + (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((object)left) + (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)((float)((object)left) + (float)((object)right)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((object)left) + (ushort)((object)right)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)left) + (uint)((object)right)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)left) + (ulong)((object)right)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x000F4218 File Offset: 0x000F2418
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Ceiling(T value)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)Math.Ceiling((double)((object)value)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)MathF.Ceiling((float)((object)value)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x000F42A4 File Offset: 0x000F24A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Convert(int value)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)value));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)((double)value));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)value));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)value);
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)value));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)value));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((IntPtr)value)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)value));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)((float)value));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)value));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)value));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((long)value)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x000F44A0 File Offset: 0x000F26A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T CopySign(T value, T sign)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.CopySign((double)((object)value), (double)((object)sign)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)short.CopySign((short)((object)value), (short)((object)sign)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)int.CopySign((int)((object)value), (int)((object)sign)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)long.CopySign((long)((object)value), (long)((object)sign)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)IntPtr.CopySign((IntPtr)((object)value), (IntPtr)((object)sign)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)sbyte.CopySign((sbyte)((object)value), (sbyte)((object)sign)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.CopySign((float)((object)value), (float)((object)sign)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x000F4684 File Offset: 0x000F2884
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Divide(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((object)left) / (byte)((object)right)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)((double)((object)left) / (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((object)left) / (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)left) / (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)left) / (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)left) / (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)left) / (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((object)left) / (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)((float)((object)left) / (float)((object)right)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((object)left) / (ushort)((object)right)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)left) / (uint)((object)right)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)left) / (ulong)((object)right)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x000F4984 File Offset: 0x000F2B84
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Equals(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (byte)((object)left) == (byte)((object)right);
			}
			if (typeof(T) == typeof(double))
			{
				return (double)((object)left) == (double)((object)right);
			}
			if (typeof(T) == typeof(short))
			{
				return (short)((object)left) == (short)((object)right);
			}
			if (typeof(T) == typeof(int))
			{
				return (int)((object)left) == (int)((object)right);
			}
			if (typeof(T) == typeof(long))
			{
				return (long)((object)left) == (long)((object)right);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) == (IntPtr)((object)right);
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) == (UIntPtr)((object)right);
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (sbyte)((object)left) == (sbyte)((object)right);
			}
			if (typeof(T) == typeof(float))
			{
				return (float)((object)left) == (float)((object)right);
			}
			if (typeof(T) == typeof(ushort))
			{
				return (ushort)((object)left) == (ushort)((object)right);
			}
			if (typeof(T) == typeof(uint))
			{
				return (uint)((object)left) == (uint)((object)right);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (ulong)((object)left) == (ulong)((object)right);
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return false;
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x000F4C0C File Offset: 0x000F2E0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ExtractMostSignificantBit(T value)
		{
			if (typeof(T) == typeof(byte))
			{
				return (uint)((byte)((object)value)) >> 7;
			}
			if (typeof(T) == typeof(double))
			{
				return (uint)(BitConverter.DoubleToUInt64Bits((double)((object)value)) >> 63);
			}
			if (typeof(T) == typeof(short))
			{
				return (uint)((ushort)((short)((object)value))) >> 15;
			}
			if (typeof(T) == typeof(int))
			{
				return (uint)((int)((object)value)) >> 31;
			}
			if (typeof(T) == typeof(long))
			{
				return (uint)((ulong)((long)((object)value)) >> 63);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (uint)((ulong)((long)((IntPtr)((object)value))) >> 63);
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (uint)((ulong)((UIntPtr)((object)value)) >> 63);
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (uint)((byte)((sbyte)((object)value))) >> 7;
			}
			if (typeof(T) == typeof(float))
			{
				return BitConverter.SingleToUInt32Bits((float)((object)value)) >> 31;
			}
			if (typeof(T) == typeof(ushort))
			{
				return (uint)((ushort)((object)value)) >> 15;
			}
			if (typeof(T) == typeof(uint))
			{
				return (uint)((object)value) >> 31;
			}
			if (typeof(T) == typeof(ulong))
			{
				return (uint)((ulong)((object)value) >> 63);
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return 0U;
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x000F4E2C File Offset: 0x000F302C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Floor(T value)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)Math.Floor((double)((object)value)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)MathF.Floor((float)((object)value)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x000F4EB8 File Offset: 0x000F30B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThan(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (byte)((object)left) > (byte)((object)right);
			}
			if (typeof(T) == typeof(double))
			{
				return (double)((object)left) > (double)((object)right);
			}
			if (typeof(T) == typeof(short))
			{
				return (short)((object)left) > (short)((object)right);
			}
			if (typeof(T) == typeof(int))
			{
				return (int)((object)left) > (int)((object)right);
			}
			if (typeof(T) == typeof(long))
			{
				return (long)((object)left) > (long)((object)right);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) > (IntPtr)((object)right);
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) > (UIntPtr)((object)right);
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (sbyte)((object)left) > (sbyte)((object)right);
			}
			if (typeof(T) == typeof(float))
			{
				return (float)((object)left) > (float)((object)right);
			}
			if (typeof(T) == typeof(ushort))
			{
				return (ushort)((object)left) > (ushort)((object)right);
			}
			if (typeof(T) == typeof(uint))
			{
				return (uint)((object)left) > (uint)((object)right);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (ulong)((object)left) > (ulong)((object)right);
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return false;
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x000F5140 File Offset: 0x000F3340
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqual(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (byte)((object)left) >= (byte)((object)right);
			}
			if (typeof(T) == typeof(double))
			{
				return (double)((object)left) >= (double)((object)right);
			}
			if (typeof(T) == typeof(short))
			{
				return (short)((object)left) >= (short)((object)right);
			}
			if (typeof(T) == typeof(int))
			{
				return (int)((object)left) >= (int)((object)right);
			}
			if (typeof(T) == typeof(long))
			{
				return (long)((object)left) >= (long)((object)right);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) >= (IntPtr)((object)right);
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) >= (UIntPtr)((object)right);
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (sbyte)((object)left) >= (sbyte)((object)right);
			}
			if (typeof(T) == typeof(float))
			{
				return (float)((object)left) >= (float)((object)right);
			}
			if (typeof(T) == typeof(ushort))
			{
				return (ushort)((object)left) >= (ushort)((object)right);
			}
			if (typeof(T) == typeof(uint))
			{
				return (uint)((object)left) >= (uint)((object)right);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (ulong)((object)left) >= (ulong)((object)right);
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return false;
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x000F53EC File Offset: 0x000F35EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThan(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (byte)((object)left) < (byte)((object)right);
			}
			if (typeof(T) == typeof(double))
			{
				return (double)((object)left) < (double)((object)right);
			}
			if (typeof(T) == typeof(short))
			{
				return (short)((object)left) < (short)((object)right);
			}
			if (typeof(T) == typeof(int))
			{
				return (int)((object)left) < (int)((object)right);
			}
			if (typeof(T) == typeof(long))
			{
				return (long)((object)left) < (long)((object)right);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) < (IntPtr)((object)right);
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) < (UIntPtr)((object)right);
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (sbyte)((object)left) < (sbyte)((object)right);
			}
			if (typeof(T) == typeof(float))
			{
				return (float)((object)left) < (float)((object)right);
			}
			if (typeof(T) == typeof(ushort))
			{
				return (ushort)((object)left) < (ushort)((object)right);
			}
			if (typeof(T) == typeof(uint))
			{
				return (uint)((object)left) < (uint)((object)right);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (ulong)((object)left) < (ulong)((object)right);
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return false;
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x000F5674 File Offset: 0x000F3874
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqual(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (byte)((object)left) <= (byte)((object)right);
			}
			if (typeof(T) == typeof(double))
			{
				return (double)((object)left) <= (double)((object)right);
			}
			if (typeof(T) == typeof(short))
			{
				return (short)((object)left) <= (short)((object)right);
			}
			if (typeof(T) == typeof(int))
			{
				return (int)((object)left) <= (int)((object)right);
			}
			if (typeof(T) == typeof(long))
			{
				return (long)((object)left) <= (long)((object)right);
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (IntPtr)((object)left) <= (IntPtr)((object)right);
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (UIntPtr)((object)left) <= (UIntPtr)((object)right);
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (sbyte)((object)left) <= (sbyte)((object)right);
			}
			if (typeof(T) == typeof(float))
			{
				return (float)((object)left) <= (float)((object)right);
			}
			if (typeof(T) == typeof(ushort))
			{
				return (ushort)((object)left) <= (ushort)((object)right);
			}
			if (typeof(T) == typeof(uint))
			{
				return (uint)((object)left) <= (uint)((object)right);
			}
			if (typeof(T) == typeof(ulong))
			{
				return (ulong)((object)left) <= (ulong)((object)right);
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return false;
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x000F5920 File Offset: 0x000F3B20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Max(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)byte.Max((byte)((object)left), (byte)((object)right)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.Max((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)short.Max((short)((object)left), (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)int.Max((int)((object)left), (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)long.Max((long)((object)left), (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)IntPtr.Max((IntPtr)((object)left), (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)UIntPtr.Max((UIntPtr)((object)left), (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)sbyte.Max((sbyte)((object)left), (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.Max((float)((object)left), (float)((object)right)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)ushort.Max((ushort)((object)left), (ushort)((object)right)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)uint.Max((uint)((object)left), (uint)((object)right)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)ulong.Max((ulong)((object)left), (ulong)((object)right)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049E6 RID: 18918 RVA: 0x000F5C4C File Offset: 0x000F3E4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MaxMagnitude(T left, T right)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MaxMagnitude((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)short.MaxMagnitude((short)((object)left), (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)int.MaxMagnitude((int)((object)left), (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)long.MaxMagnitude((long)((object)left), (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)IntPtr.MaxMagnitude((IntPtr)((object)left), (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)UIntPtr.Max((UIntPtr)((object)left), (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)sbyte.MaxMagnitude((sbyte)((object)left), (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MaxMagnitude((float)((object)left), (float)((object)right)));
			}
			return Scalar<T>.Max(left, right);
		}

		// Token: 0x060049E7 RID: 18919 RVA: 0x000F5E68 File Offset: 0x000F4068
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MaxMagnitudeNumber(T left, T right)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MaxMagnitudeNumber((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MaxMagnitudeNumber((float)((object)left), (float)((object)right)));
			}
			return Scalar<T>.MaxMagnitude(left, right);
		}

		// Token: 0x060049E8 RID: 18920 RVA: 0x000F5F00 File Offset: 0x000F4100
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MaxNumber(T left, T right)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MaxNumber((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MaxNumber((float)((object)left), (float)((object)right)));
			}
			return Scalar<T>.Max(left, right);
		}

		// Token: 0x060049E9 RID: 18921 RVA: 0x000F5F98 File Offset: 0x000F4198
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Min(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)byte.Min((byte)((object)left), (byte)((object)right)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.Min((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)short.Min((short)((object)left), (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)int.Min((int)((object)left), (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)long.Min((long)((object)left), (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)IntPtr.Min((IntPtr)((object)left), (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)UIntPtr.Min((UIntPtr)((object)left), (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)sbyte.Min((sbyte)((object)left), (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.Min((float)((object)left), (float)((object)right)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)ushort.Min((ushort)((object)left), (ushort)((object)right)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)uint.Min((uint)((object)left), (uint)((object)right)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)ulong.Min((ulong)((object)left), (ulong)((object)right)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049EA RID: 18922 RVA: 0x000F62C4 File Offset: 0x000F44C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MinMagnitude(T left, T right)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MinMagnitude((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)short.MinMagnitude((short)((object)left), (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)int.MinMagnitude((int)((object)left), (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)long.MinMagnitude((long)((object)left), (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)IntPtr.MinMagnitude((IntPtr)((object)left), (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)UIntPtr.Min((UIntPtr)((object)left), (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)sbyte.MinMagnitude((sbyte)((object)left), (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MinMagnitude((float)((object)left), (float)((object)right)));
			}
			return Scalar<T>.Min(left, right);
		}

		// Token: 0x060049EB RID: 18923 RVA: 0x000F64E0 File Offset: 0x000F46E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MinMagnitudeNumber(T left, T right)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MinMagnitudeNumber((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MinMagnitudeNumber((float)((object)left), (float)((object)right)));
			}
			return Scalar<T>.MinMagnitude(left, right);
		}

		// Token: 0x060049EC RID: 18924 RVA: 0x000F6578 File Offset: 0x000F4778
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MinNumber(T left, T right)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MinNumber((double)((object)left), (double)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MinNumber((float)((object)left), (float)((object)right)));
			}
			return Scalar<T>.Min(left, right);
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x000F6610 File Offset: 0x000F4810
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Multiply(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((object)left) * (byte)((object)right)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)((double)((object)left) * (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((object)left) * (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)left) * (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)left) * (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)left) * (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)left) * (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((object)left) * (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)((float)((object)left) * (float)((object)right)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((object)left) * (ushort)((object)right)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)left) * (uint)((object)right)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)left) * (ulong)((object)right)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x000F6910 File Offset: 0x000F4B10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T MultiplyAddEstimate(T left, T right, T addend)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((object)left) * (byte)((object)right) + (byte)((object)addend)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)double.MultiplyAddEstimate((double)((object)left), (double)((object)right), (double)((object)addend)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((object)left) * (short)((object)right) + (short)((object)addend)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)left) * (int)((object)right) + (int)((object)addend)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)left) * (long)((object)right) + (long)((object)addend)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)left) * (IntPtr)((object)right) + (IntPtr)((object)addend)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)left) * (UIntPtr)((object)right) + (UIntPtr)((object)addend)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((object)left) * (sbyte)((object)right) + (sbyte)((object)addend)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)float.MultiplyAddEstimate((float)((object)left), (float)((object)right), (float)((object)addend)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((object)left) * (ushort)((object)right) + (ushort)((object)addend)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)left) * (uint)((object)right) + (uint)((object)addend)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)left) * (ulong)((object)right) + (ulong)((object)addend)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049EF RID: 18927 RVA: 0x000F6CA4 File Offset: 0x000F4EA4
		public static bool ObjectEquals(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return ((byte)((object)left)).Equals((byte)((object)right));
			}
			if (typeof(T) == typeof(double))
			{
				return ((double)((object)left)).Equals((double)((object)right));
			}
			if (typeof(T) == typeof(short))
			{
				return ((short)((object)left)).Equals((short)((object)right));
			}
			if (typeof(T) == typeof(int))
			{
				return ((int)((object)left)).Equals((int)((object)right));
			}
			if (typeof(T) == typeof(long))
			{
				return ((long)((object)left)).Equals((long)((object)right));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return ((IntPtr)((object)left)).Equals((IntPtr)((object)right));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return ((UIntPtr)((object)left)).Equals((UIntPtr)((object)right));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return ((sbyte)((object)left)).Equals((sbyte)((object)right));
			}
			if (typeof(T) == typeof(float))
			{
				return ((float)((object)left)).Equals((float)((object)right));
			}
			if (typeof(T) == typeof(ushort))
			{
				return ((ushort)((object)left)).Equals((ushort)((object)right));
			}
			if (typeof(T) == typeof(uint))
			{
				return ((uint)((object)left)).Equals((uint)((object)right));
			}
			if (typeof(T) == typeof(ulong))
			{
				return ((ulong)((object)left)).Equals((ulong)((object)right));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return false;
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x000F6F7C File Offset: 0x000F517C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Round(T value)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)Math.Round((double)((object)value)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)MathF.Round((float)((object)value)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x000F7008 File Offset: 0x000F5208
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ShiftLeft(T value, int shiftCount)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((byte)((object)value) << (shiftCount & 7))));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits((double)((object)value)) << shiftCount));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((short)((object)value) << (shiftCount & 15))));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)value) << shiftCount));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)value) << shiftCount));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)value) << (shiftCount & 8 * 8 - 1)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)value) << (shiftCount & 8 * 8 - 1)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((sbyte)((object)value) << (shiftCount & 7))));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits((float)((object)value)) << shiftCount));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((ushort)((object)value) << (shiftCount & 15))));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)value) << shiftCount));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)value) << shiftCount));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x000F72E0 File Offset: 0x000F54E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ShiftRightArithmetic(T value, int shiftCount)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((byte)((object)value) >> (shiftCount & 7))));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)BitConverter.Int64BitsToDouble(BitConverter.DoubleToInt64Bits((double)((object)value)) >> shiftCount));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((short)((object)value) >> (shiftCount & 15))));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)value) >> shiftCount));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)value) >> shiftCount));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)value) >> (shiftCount & 8 * 8 - 1)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)value) >> (shiftCount & 8 * 8 - 1)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((sbyte)((object)value) >> (shiftCount & 7))));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)BitConverter.Int32BitsToSingle(BitConverter.SingleToInt32Bits((float)((object)value)) >> shiftCount));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((ushort)((object)value) >> (shiftCount & 15))));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)value) >> shiftCount));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)value) >> shiftCount));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x000F75B8 File Offset: 0x000F57B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T ShiftRightLogical(T value, int shiftCount)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((uint)((byte)((object)value)) >> (shiftCount & 7))));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)BitConverter.Int64BitsToDouble((long)((ulong)BitConverter.DoubleToInt64Bits((double)((object)value)) >> shiftCount)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((uint)((ushort)((short)((object)value))) >> (shiftCount & 15))));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((uint)((int)((object)value)) >> shiftCount)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((ulong)((long)((object)value)) >> shiftCount)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)value) >> (shiftCount & 8 * 8 - 1)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)value) >> (shiftCount & 8 * 8 - 1)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((uint)((byte)((sbyte)((object)value))) >> (shiftCount & 7))));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)BitConverter.Int32BitsToSingle((int)((uint)BitConverter.SingleToInt32Bits((float)((object)value)) >> shiftCount)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((uint)((ushort)((object)value)) >> (shiftCount & 15))));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)value) >> shiftCount));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)value) >> shiftCount));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x000F7894 File Offset: 0x000F5A94
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Sqrt(T value)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)MathF.Sqrt((float)((byte)((object)value)))));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)Math.Sqrt((double)((object)value)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)MathF.Sqrt((float)((short)((object)value)))));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)Math.Sqrt((double)((int)((object)value)))));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)Math.Sqrt((double)((long)((object)value)))));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)Math.Sqrt((double)((IntPtr)((object)value)))));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)Math.Sqrt((UIntPtr)((object)value))));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)MathF.Sqrt((float)((sbyte)((object)value)))));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)MathF.Sqrt((float)((object)value)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)MathF.Sqrt((float)((ushort)((object)value)))));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)Math.Sqrt((uint)((object)value))));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)Math.Sqrt((ulong)((object)value))));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x000F7B54 File Offset: 0x000F5D54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Subtract(T left, T right)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)((object)((byte)((object)left) - (byte)((object)right)));
			}
			if (typeof(T) == typeof(double))
			{
				return (T)((object)((double)((object)left) - (double)((object)right)));
			}
			if (typeof(T) == typeof(short))
			{
				return (T)((object)((short)((object)left) - (short)((object)right)));
			}
			if (typeof(T) == typeof(int))
			{
				return (T)((object)((int)((object)left) - (int)((object)right)));
			}
			if (typeof(T) == typeof(long))
			{
				return (T)((object)((long)((object)left) - (long)((object)right)));
			}
			if (typeof(T) == typeof(IntPtr))
			{
				return (T)((object)((IntPtr)((object)left) - (IntPtr)((object)right)));
			}
			if (typeof(T) == typeof(UIntPtr))
			{
				return (T)((object)((UIntPtr)((object)left) - (UIntPtr)((object)right)));
			}
			if (typeof(T) == typeof(sbyte))
			{
				return (T)((object)((sbyte)((object)left) - (sbyte)((object)right)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)((float)((object)left) - (float)((object)right)));
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)((object)((ushort)((object)left) - (ushort)((object)right)));
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)((object)((uint)((object)left) - (uint)((object)right)));
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)((object)((ulong)((object)left) - (ulong)((object)right)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x000F7E54 File Offset: 0x000F6054
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Truncate(T value)
		{
			if (typeof(T) == typeof(double))
			{
				return (T)((object)Math.Truncate((double)((object)value)));
			}
			if (typeof(T) == typeof(float))
			{
				return (T)((object)MathF.Truncate((float)((object)value)));
			}
			ThrowHelper.ThrowNotSupportedException(ExceptionResource.Arg_TypeNotSupported);
			return default(T);
		}
	}
}
