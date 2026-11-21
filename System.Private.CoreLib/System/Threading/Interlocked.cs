using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Threading
{
	// Token: 0x020003B9 RID: 953
	[NullableContext(1)]
	[Nullable(0)]
	public static class Interlocked
	{
		// Token: 0x06003E5F RID: 15967
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int CompareExchange(ref int location1, int value, int comparand);

		// Token: 0x06003E60 RID: 15968
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void CompareExchange(ref object location1, ref object value, ref object comparand, [NotNullIfNotNull("location1")] ref object result);

		// Token: 0x06003E61 RID: 15969 RVA: 0x000D29A8 File Offset: 0x000D0BA8
		[NullableContext(2)]
		[Intrinsic]
		[return: NotNullIfNotNull("location1")]
		public static object CompareExchange(ref object location1, object value, object comparand)
		{
			object result = null;
			Interlocked.CompareExchange(ref location1, ref value, ref comparand, ref result);
			return result;
		}

		// Token: 0x06003E62 RID: 15970
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Decrement(ref int location);

		// Token: 0x06003E63 RID: 15971
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Decrement(ref long location);

		// Token: 0x06003E64 RID: 15972
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Increment(ref int location);

		// Token: 0x06003E65 RID: 15973
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Increment(ref long location);

		// Token: 0x06003E66 RID: 15974
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Exchange(ref int location1, int value);

		// Token: 0x06003E67 RID: 15975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Exchange([NotNullIfNotNull("value")] ref object location1, ref object value, [NotNullIfNotNull("location1")] ref object result);

		// Token: 0x06003E68 RID: 15976 RVA: 0x000D29C4 File Offset: 0x000D0BC4
		[NullableContext(2)]
		[return: NotNullIfNotNull("location1")]
		public static object Exchange([NotNullIfNotNull("value")] ref object location1, object value)
		{
			object result = null;
			Interlocked.Exchange(ref location1, ref value, ref result);
			return result;
		}

		// Token: 0x06003E69 RID: 15977
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long CompareExchange(ref long location1, long value, long comparand);

		// Token: 0x06003E6A RID: 15978
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Exchange(ref long location1, long value);

		// Token: 0x06003E6B RID: 15979
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Read(ref long location);

		// Token: 0x06003E6C RID: 15980
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Add(ref int location1, int value);

		// Token: 0x06003E6D RID: 15981
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Add(ref long location1, long value);

		// Token: 0x06003E6E RID: 15982
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MemoryBarrierProcessWide();

		// Token: 0x06003E6F RID: 15983 RVA: 0x000D29DE File Offset: 0x000D0BDE
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Increment(ref uint location)
		{
			return Interlocked.Add(ref location, 1U);
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x000D29E7 File Offset: 0x000D0BE7
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Increment(ref ulong location)
		{
			return Interlocked.Add(ref location, 1UL);
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x000D29F1 File Offset: 0x000D0BF1
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Decrement(ref uint location)
		{
			return (uint)Interlocked.Add(Unsafe.As<uint, int>(ref location), -1);
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x000D29FF File Offset: 0x000D0BFF
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Decrement(ref ulong location)
		{
			return (ulong)Interlocked.Add(Unsafe.As<ulong, long>(ref location), -1L);
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x000D2A0E File Offset: 0x000D0C0E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte Exchange(ref sbyte location1, sbyte value)
		{
			return (sbyte)Interlocked.Exchange(Unsafe.As<sbyte, byte>(ref location1), (byte)value);
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x000D2A1E File Offset: 0x000D0C1E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short Exchange(ref short location1, short value)
		{
			return (short)Interlocked.Exchange(Unsafe.As<short, ushort>(ref location1), (ushort)value);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x000D2A2E File Offset: 0x000D0C2E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Exchange(ref byte location1, byte value)
		{
			return Interlocked.Exchange(ref location1, value);
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x000D2A37 File Offset: 0x000D0C37
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort Exchange(ref ushort location1, ushort value)
		{
			return Interlocked.Exchange(ref location1, value);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x000D2A40 File Offset: 0x000D0C40
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Exchange(ref uint location1, uint value)
		{
			return (uint)Interlocked.Exchange(Unsafe.As<uint, int>(ref location1), (int)value);
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x000D2A4E File Offset: 0x000D0C4E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Exchange(ref ulong location1, ulong value)
		{
			return (ulong)Interlocked.Exchange(Unsafe.As<ulong, long>(ref location1), (long)value);
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x000D2A5C File Offset: 0x000D0C5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Exchange(ref float location1, float value)
		{
			return Unsafe.BitCast<int, float>(Interlocked.Exchange(Unsafe.As<float, int>(ref location1), Unsafe.BitCast<float, int>(value)));
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x000D2A74 File Offset: 0x000D0C74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Exchange(ref double location1, double value)
		{
			return Unsafe.BitCast<long, double>(Interlocked.Exchange(Unsafe.As<double, long>(ref location1), Unsafe.BitCast<double, long>(value)));
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x000D2A8C File Offset: 0x000D0C8C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr Exchange(ref IntPtr location1, IntPtr value)
		{
			return (IntPtr)Interlocked.Exchange(Unsafe.As<IntPtr, long>(ref location1), (long)value);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x000D2A9C File Offset: 0x000D0C9C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr Exchange(ref UIntPtr location1, UIntPtr value)
		{
			return (UIntPtr)Interlocked.Exchange(Unsafe.As<UIntPtr, long>(ref location1), (long)((ulong)value));
		}

		// Token: 0x06003E7D RID: 15997 RVA: 0x000D2AAC File Offset: 0x000D0CAC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: NotNullIfNotNull("location1")]
		public unsafe static T Exchange<[Nullable(2)] T>([NotNullIfNotNull("value")] ref T location1, T value)
		{
			if (!typeof(T).IsValueType)
			{
				object obj = Interlocked.Exchange(Unsafe.As<T, object>(ref location1), value);
				return *Unsafe.As<object, T>(ref obj);
			}
			if (!typeof(T).IsPrimitive && !typeof(T).IsEnum)
			{
				throw new NotSupportedException(SR.NotSupported_ReferenceEnumOrPrimitiveTypeRequired);
			}
			if (sizeof(T) == 1)
			{
				return Unsafe.BitCast<byte, T>(Interlocked.Exchange(Unsafe.As<T, byte>(ref location1), Unsafe.BitCast<T, byte>(value)));
			}
			if (sizeof(T) == 2)
			{
				return Unsafe.BitCast<ushort, T>(Interlocked.Exchange(Unsafe.As<T, ushort>(ref location1), Unsafe.BitCast<T, ushort>(value)));
			}
			if (sizeof(T) == 4)
			{
				return Unsafe.BitCast<int, T>(Interlocked.Exchange(Unsafe.As<T, int>(ref location1), Unsafe.BitCast<T, int>(value)));
			}
			return Unsafe.BitCast<long, T>(Interlocked.Exchange(Unsafe.As<T, long>(ref location1), Unsafe.BitCast<T, long>(value)));
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x000D2B8C File Offset: 0x000D0D8C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte CompareExchange(ref sbyte location1, sbyte value, sbyte comparand)
		{
			return (sbyte)Interlocked.CompareExchange(Unsafe.As<sbyte, byte>(ref location1), (byte)value, (byte)comparand);
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x000D2B9E File Offset: 0x000D0D9E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short CompareExchange(ref short location1, short value, short comparand)
		{
			return (short)Interlocked.CompareExchange(Unsafe.As<short, ushort>(ref location1), (ushort)value, (ushort)comparand);
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x000D2BB0 File Offset: 0x000D0DB0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CompareExchange(ref byte location1, byte value, byte comparand)
		{
			return Interlocked.CompareExchange(ref location1, value, comparand);
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x000D2BBA File Offset: 0x000D0DBA
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort CompareExchange(ref ushort location1, ushort value, ushort comparand)
		{
			return Interlocked.CompareExchange(ref location1, value, comparand);
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x000D2BC4 File Offset: 0x000D0DC4
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CompareExchange(ref uint location1, uint value, uint comparand)
		{
			return (uint)Interlocked.CompareExchange(Unsafe.As<uint, int>(ref location1), (int)value, (int)comparand);
		}

		// Token: 0x06003E83 RID: 16003 RVA: 0x000D2BD3 File Offset: 0x000D0DD3
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong CompareExchange(ref ulong location1, ulong value, ulong comparand)
		{
			return (ulong)Interlocked.CompareExchange(Unsafe.As<ulong, long>(ref location1), (long)value, (long)comparand);
		}

		// Token: 0x06003E84 RID: 16004 RVA: 0x000D2BE2 File Offset: 0x000D0DE2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CompareExchange(ref float location1, float value, float comparand)
		{
			return Unsafe.BitCast<int, float>(Interlocked.CompareExchange(Unsafe.As<float, int>(ref location1), Unsafe.BitCast<float, int>(value), Unsafe.BitCast<float, int>(comparand)));
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000D2C00 File Offset: 0x000D0E00
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double CompareExchange(ref double location1, double value, double comparand)
		{
			return Unsafe.BitCast<long, double>(Interlocked.CompareExchange(Unsafe.As<double, long>(ref location1), Unsafe.BitCast<double, long>(value), Unsafe.BitCast<double, long>(comparand)));
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x000D2C1E File Offset: 0x000D0E1E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
		{
			return (IntPtr)Interlocked.CompareExchange(Unsafe.As<IntPtr, long>(ref location1), (long)value, (long)comparand);
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x000D2C30 File Offset: 0x000D0E30
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr CompareExchange(ref UIntPtr location1, UIntPtr value, UIntPtr comparand)
		{
			return (UIntPtr)Interlocked.CompareExchange(Unsafe.As<UIntPtr, long>(ref location1), (long)((ulong)value), (long)((ulong)comparand));
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x000D2C44 File Offset: 0x000D0E44
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: NotNullIfNotNull("location1")]
		public unsafe static T CompareExchange<[Nullable(2)] T>(ref T location1, T value, T comparand)
		{
			if (!typeof(T).IsValueType)
			{
				object obj = Interlocked.CompareExchange(Unsafe.As<T, object>(ref location1), value, comparand);
				return *Unsafe.As<object, T>(ref obj);
			}
			if (!typeof(T).IsPrimitive && !typeof(T).IsEnum)
			{
				throw new NotSupportedException(SR.NotSupported_ReferenceEnumOrPrimitiveTypeRequired);
			}
			if (sizeof(T) == 1)
			{
				return Unsafe.BitCast<byte, T>(Interlocked.CompareExchange(Unsafe.As<T, byte>(ref location1), Unsafe.BitCast<T, byte>(value), Unsafe.BitCast<T, byte>(comparand)));
			}
			if (sizeof(T) == 2)
			{
				return Unsafe.BitCast<ushort, T>(Interlocked.CompareExchange(Unsafe.As<T, ushort>(ref location1), Unsafe.BitCast<T, ushort>(value), Unsafe.BitCast<T, ushort>(comparand)));
			}
			if (sizeof(T) == 4)
			{
				return Unsafe.BitCast<int, T>(Interlocked.CompareExchange(Unsafe.As<T, int>(ref location1), Unsafe.BitCast<T, int>(value), Unsafe.BitCast<T, int>(comparand)));
			}
			return Unsafe.BitCast<long, T>(Interlocked.CompareExchange(Unsafe.As<T, long>(ref location1), Unsafe.BitCast<T, long>(value), Unsafe.BitCast<T, long>(comparand)));
		}

		// Token: 0x06003E89 RID: 16009 RVA: 0x000D2D42 File Offset: 0x000D0F42
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Add(ref uint location1, uint value)
		{
			return (uint)Interlocked.Add(Unsafe.As<uint, int>(ref location1), (int)value);
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x000D2D50 File Offset: 0x000D0F50
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Add(ref ulong location1, ulong value)
		{
			return (ulong)Interlocked.Add(Unsafe.As<ulong, long>(ref location1), (long)value);
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x000D2D5E File Offset: 0x000D0F5E
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Read([RequiresLocation] [In] ref ulong location)
		{
			return Interlocked.CompareExchange(Unsafe.AsRef<ulong>(ref location), 0UL, 0UL);
		}

		// Token: 0x06003E8C RID: 16012 RVA: 0x000D2D70 File Offset: 0x000D0F70
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int And(ref int location1, int value)
		{
			int num = location1;
			int num2;
			for (;;)
			{
				int value2 = num & value;
				num2 = Interlocked.CompareExchange(ref location1, value2, num);
				if (num2 == num)
				{
					break;
				}
				num = num2;
			}
			return num2;
		}

		// Token: 0x06003E8D RID: 16013 RVA: 0x000D2D96 File Offset: 0x000D0F96
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint And(ref uint location1, uint value)
		{
			return (uint)Interlocked.And(Unsafe.As<uint, int>(ref location1), (int)value);
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x000D2DA4 File Offset: 0x000D0FA4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long And(ref long location1, long value)
		{
			long num = location1;
			long num2;
			for (;;)
			{
				long value2 = num & value;
				num2 = Interlocked.CompareExchange(ref location1, value2, num);
				if (num2 == num)
				{
					break;
				}
				num = num2;
			}
			return num2;
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x000D2DCA File Offset: 0x000D0FCA
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong And(ref ulong location1, ulong value)
		{
			return (ulong)Interlocked.And(Unsafe.As<ulong, long>(ref location1), (long)value);
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x000D2DD8 File Offset: 0x000D0FD8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Or(ref int location1, int value)
		{
			int num = location1;
			int num2;
			for (;;)
			{
				int value2 = num | value;
				num2 = Interlocked.CompareExchange(ref location1, value2, num);
				if (num2 == num)
				{
					break;
				}
				num = num2;
			}
			return num2;
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x000D2DFE File Offset: 0x000D0FFE
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Or(ref uint location1, uint value)
		{
			return (uint)Interlocked.Or(Unsafe.As<uint, int>(ref location1), (int)value);
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x000D2E0C File Offset: 0x000D100C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Or(ref long location1, long value)
		{
			long num = location1;
			long num2;
			for (;;)
			{
				long value2 = num | value;
				num2 = Interlocked.CompareExchange(ref location1, value2, num);
				if (num2 == num)
				{
					break;
				}
				num = num2;
			}
			return num2;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x000D2E32 File Offset: 0x000D1032
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong Or(ref ulong location1, ulong value)
		{
			return (ulong)Interlocked.Or(Unsafe.As<ulong, long>(ref location1), (long)value);
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x000D2E40 File Offset: 0x000D1040
		[Intrinsic]
		public static void MemoryBarrier()
		{
			Interlocked.MemoryBarrier();
		}
	}
}
