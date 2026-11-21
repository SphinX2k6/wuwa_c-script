using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System.Threading
{
	// Token: 0x02000450 RID: 1104
	[NullableContext(1)]
	[Nullable(0)]
	public static class Volatile
	{
		// Token: 0x060042D5 RID: 17109 RVA: 0x000DF0FC File Offset: 0x000DD2FC
		[Intrinsic]
		[NonVersionable]
		public static bool Read([RequiresLocation] [In] ref bool location)
		{
			return Unsafe.As<bool, Volatile.VolatileBoolean>(Unsafe.AsRef<bool>(ref location)).Value;
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x000DF110 File Offset: 0x000DD310
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref bool location, bool value)
		{
			Unsafe.As<bool, Volatile.VolatileBoolean>(ref location).Value = value;
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x000DF120 File Offset: 0x000DD320
		[Intrinsic]
		[NonVersionable]
		public static byte Read([RequiresLocation] [In] ref byte location)
		{
			return Unsafe.As<byte, Volatile.VolatileByte>(Unsafe.AsRef<byte>(ref location)).Value;
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x000DF134 File Offset: 0x000DD334
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref byte location, byte value)
		{
			Unsafe.As<byte, Volatile.VolatileByte>(ref location).Value = value;
		}

		// Token: 0x060042D9 RID: 17113 RVA: 0x000DF144 File Offset: 0x000DD344
		[Intrinsic]
		[NonVersionable]
		public static double Read([RequiresLocation] [In] ref double location)
		{
			return BitConverter.Int64BitsToDouble(Volatile.Read(Unsafe.As<double, long>(Unsafe.AsRef<double>(ref location))));
		}

		// Token: 0x060042DA RID: 17114 RVA: 0x000DF15B File Offset: 0x000DD35B
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref double location, double value)
		{
			Volatile.Write(Unsafe.As<double, long>(ref location), BitConverter.DoubleToInt64Bits(value));
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x000DF16E File Offset: 0x000DD36E
		[Intrinsic]
		[NonVersionable]
		public static short Read([RequiresLocation] [In] ref short location)
		{
			return Unsafe.As<short, Volatile.VolatileInt16>(Unsafe.AsRef<short>(ref location)).Value;
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x000DF182 File Offset: 0x000DD382
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref short location, short value)
		{
			Unsafe.As<short, Volatile.VolatileInt16>(ref location).Value = value;
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x000DF192 File Offset: 0x000DD392
		[Intrinsic]
		[NonVersionable]
		public static int Read([RequiresLocation] [In] ref int location)
		{
			return Unsafe.As<int, Volatile.VolatileInt32>(Unsafe.AsRef<int>(ref location)).Value;
		}

		// Token: 0x060042DE RID: 17118 RVA: 0x000DF1A6 File Offset: 0x000DD3A6
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref int location, int value)
		{
			Unsafe.As<int, Volatile.VolatileInt32>(ref location).Value = value;
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x000DF1B6 File Offset: 0x000DD3B6
		[Intrinsic]
		[NonVersionable]
		public static long Read([RequiresLocation] [In] ref long location)
		{
			return (long)Unsafe.As<long, Volatile.VolatileIntPtr>(Unsafe.AsRef<long>(ref location)).Value;
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000DF1CB File Offset: 0x000DD3CB
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref long location, long value)
		{
			Unsafe.As<long, Volatile.VolatileIntPtr>(ref location).Value = (IntPtr)value;
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000DF1DC File Offset: 0x000DD3DC
		[Intrinsic]
		[NonVersionable]
		public static IntPtr Read([RequiresLocation] [In] ref IntPtr location)
		{
			return Unsafe.As<IntPtr, Volatile.VolatileIntPtr>(Unsafe.AsRef<IntPtr>(ref location)).Value;
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x000DF1F0 File Offset: 0x000DD3F0
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref IntPtr location, IntPtr value)
		{
			Unsafe.As<IntPtr, Volatile.VolatileIntPtr>(ref location).Value = value;
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x000DF200 File Offset: 0x000DD400
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static sbyte Read([RequiresLocation] [In] ref sbyte location)
		{
			return Unsafe.As<sbyte, Volatile.VolatileSByte>(Unsafe.AsRef<sbyte>(ref location)).Value;
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x000DF214 File Offset: 0x000DD414
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref sbyte location, sbyte value)
		{
			Unsafe.As<sbyte, Volatile.VolatileSByte>(ref location).Value = value;
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x000DF224 File Offset: 0x000DD424
		[Intrinsic]
		[NonVersionable]
		public static float Read([RequiresLocation] [In] ref float location)
		{
			return Unsafe.As<float, Volatile.VolatileSingle>(Unsafe.AsRef<float>(ref location)).Value;
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x000DF238 File Offset: 0x000DD438
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref float location, float value)
		{
			Unsafe.As<float, Volatile.VolatileSingle>(ref location).Value = value;
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x000DF248 File Offset: 0x000DD448
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static ushort Read([RequiresLocation] [In] ref ushort location)
		{
			return Unsafe.As<ushort, Volatile.VolatileUInt16>(Unsafe.AsRef<ushort>(ref location)).Value;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000DF25C File Offset: 0x000DD45C
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref ushort location, ushort value)
		{
			Unsafe.As<ushort, Volatile.VolatileUInt16>(ref location).Value = value;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x000DF26C File Offset: 0x000DD46C
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static uint Read([RequiresLocation] [In] ref uint location)
		{
			return Unsafe.As<uint, Volatile.VolatileUInt32>(Unsafe.AsRef<uint>(ref location)).Value;
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x000DF280 File Offset: 0x000DD480
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref uint location, uint value)
		{
			Unsafe.As<uint, Volatile.VolatileUInt32>(ref location).Value = value;
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x000DF290 File Offset: 0x000DD490
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static ulong Read([RequiresLocation] [In] ref ulong location)
		{
			return (ulong)Volatile.Read(Unsafe.As<ulong, long>(Unsafe.AsRef<ulong>(ref location)));
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x000DF2A2 File Offset: 0x000DD4A2
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref ulong location, ulong value)
		{
			Volatile.Write(Unsafe.As<ulong, long>(ref location), (long)value);
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x000DF2B0 File Offset: 0x000DD4B0
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static UIntPtr Read([RequiresLocation] [In] ref UIntPtr location)
		{
			return Unsafe.As<UIntPtr, Volatile.VolatileUIntPtr>(Unsafe.AsRef<UIntPtr>(ref location)).Value;
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x000DF2C4 File Offset: 0x000DD4C4
		[CLSCompliant(false)]
		[Intrinsic]
		[NonVersionable]
		public static void Write(ref UIntPtr location, UIntPtr value)
		{
			Unsafe.As<UIntPtr, Volatile.VolatileUIntPtr>(ref location).Value = value;
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x000DF2D4 File Offset: 0x000DD4D4
		[Intrinsic]
		[NonVersionable]
		[return: NotNullIfNotNull("location")]
		public static T Read<[Nullable(2)] T>([RequiresLocation] [NotNullIfNotNull("location")] [In] ref T location) where T : class
		{
			return Unsafe.As<T>(Unsafe.As<T, Volatile.VolatileObject>(Unsafe.AsRef<T>(ref location)).Value);
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x000DF2ED File Offset: 0x000DD4ED
		[Intrinsic]
		[NonVersionable]
		public static void Write<[Nullable(2)] T>([NotNullIfNotNull("value")] ref T location, T value) where T : class
		{
			Unsafe.As<T, Volatile.VolatileObject>(ref location).Value = value;
		}

		// Token: 0x02000451 RID: 1105
		private struct VolatileBoolean
		{
			// Token: 0x04000EAB RID: 3755
			public volatile bool Value;
		}

		// Token: 0x02000452 RID: 1106
		private struct VolatileByte
		{
			// Token: 0x04000EAC RID: 3756
			public volatile byte Value;
		}

		// Token: 0x02000453 RID: 1107
		private struct VolatileInt16
		{
			// Token: 0x04000EAD RID: 3757
			public volatile short Value;
		}

		// Token: 0x02000454 RID: 1108
		private struct VolatileInt32
		{
			// Token: 0x04000EAE RID: 3758
			public volatile int Value;
		}

		// Token: 0x02000455 RID: 1109
		private struct VolatileIntPtr
		{
			// Token: 0x04000EAF RID: 3759
			public volatile IntPtr Value;
		}

		// Token: 0x02000456 RID: 1110
		private struct VolatileSByte
		{
			// Token: 0x04000EB0 RID: 3760
			public volatile sbyte Value;
		}

		// Token: 0x02000457 RID: 1111
		private struct VolatileSingle
		{
			// Token: 0x04000EB1 RID: 3761
			public volatile float Value;
		}

		// Token: 0x02000458 RID: 1112
		private struct VolatileUInt16
		{
			// Token: 0x04000EB2 RID: 3762
			public volatile ushort Value;
		}

		// Token: 0x02000459 RID: 1113
		private struct VolatileUInt32
		{
			// Token: 0x04000EB3 RID: 3763
			public volatile uint Value;
		}

		// Token: 0x0200045A RID: 1114
		private struct VolatileUIntPtr
		{
			// Token: 0x04000EB4 RID: 3764
			public volatile UIntPtr Value;
		}

		// Token: 0x0200045B RID: 1115
		private struct VolatileObject
		{
			// Token: 0x04000EB5 RID: 3765
			public volatile object Value;
		}
	}
}
