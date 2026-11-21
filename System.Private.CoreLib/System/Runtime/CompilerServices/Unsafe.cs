using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006DD RID: 1757
	[NullableContext(1)]
	[Nullable(0)]
	public static class Unsafe
	{
		// Token: 0x060074C2 RID: 29890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void* AsPointer<[Nullable(2)] T>([Nullable(1)] ref T value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00115F3B File Offset: 0x0011413B
		[NullableContext(2)]
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SizeOf<T>()
		{
			return sizeof(T);
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(2)]
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		[return: NotNullIfNotNull("o")]
		public static T As<T>(object o) where T : class
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref TTo As<[Nullable(2)] TFrom, [Nullable(2)] TTo>(ref TFrom source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x00115F43 File Offset: 0x00114143
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Add<[Nullable(2)] T>(ref T source, int elementOffset)
		{
			return Unsafe.AddByteOffset<T>(ref source, (IntPtr)elementOffset * (IntPtr)sizeof(T));
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x00115F55 File Offset: 0x00114155
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Add<[Nullable(2)] T>(ref T source, IntPtr elementOffset)
		{
			return Unsafe.AddByteOffset<T>(ref source, elementOffset * (IntPtr)sizeof(T));
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x00115F66 File Offset: 0x00114166
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void* Add<[Nullable(2)] T>(void* source, int elementOffset)
		{
			return (void*)((byte*)source + (long)((IntPtr)elementOffset * (IntPtr)sizeof(T)));
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x00115F76 File Offset: 0x00114176
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Add<[Nullable(2)] T>(ref T source, UIntPtr elementOffset)
		{
			return Unsafe.AddByteOffset<T>(ref source, elementOffset * (UIntPtr)((IntPtr)sizeof(T)));
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x00115F87 File Offset: 0x00114187
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T AddByteOffset<[Nullable(2)] T>(ref T source, UIntPtr byteOffset)
		{
			return Unsafe.AddByteOffset<T>(ref source, (IntPtr)byteOffset);
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AreSame<[Nullable(2)] T>([RequiresLocation] [AllowNull] [In] ref T left, [RequiresLocation] [AllowNull] [In] ref T right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x00115F90 File Offset: 0x00114190
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TTo BitCast<[Nullable(2)] TFrom, [Nullable(2)] TTo>(TFrom source)
		{
			if (sizeof(TFrom) != sizeof(TTo) || default(TFrom) == null || default(TTo) == null)
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return Unsafe.ReadUnaligned<TTo>(Unsafe.As<TFrom, byte>(ref source));
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void Copy<[Nullable(2)] T>(void* destination, [RequiresLocation] [Nullable(1)] [In] ref T source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void Copy<[Nullable(2)] T>([Nullable(1)] ref T destination, void* source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CopyBlock(void* destination, void* source, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyBlock(ref byte destination, [RequiresLocation] [In] ref byte source, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void CopyBlockUnaligned(void* destination, void* source, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyBlockUnaligned(ref byte destination, [RequiresLocation] [In] ref byte source, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsAddressGreaterThan<[Nullable(2)] T>([RequiresLocation] [AllowNull] [In] ref T left, [RequiresLocation] [AllowNull] [In] ref T right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsAddressLessThan<[Nullable(2)] T>([RequiresLocation] [AllowNull] [In] ref T left, [RequiresLocation] [AllowNull] [In] ref T right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void InitBlock(void* startAddress, byte value, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InitBlock(ref byte startAddress, byte value, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void InitBlockUnaligned(void* startAddress, byte value, uint byteCount)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00115FDC File Offset: 0x001141DC
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
		{
			for (uint num = 0U; num < byteCount; num += 1U)
			{
				*Unsafe.AddByteOffset<byte>(ref startAddress, (UIntPtr)num) = value;
			}
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x00115FFF File Offset: 0x001141FF
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		public unsafe static T ReadUnaligned<[Nullable(2)] T>(void* source)
		{
			return *(T*)source;
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x00116007 File Offset: 0x00114207
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static T ReadUnaligned<[Nullable(2)] T>([ScopedRef] [RequiresLocation] [In] ref byte source)
		{
			return *Unsafe.As<byte, T>(Unsafe.AsRef<byte>(ref source));
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00116019 File Offset: 0x00114219
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteUnaligned<[Nullable(2)] T>(void* destination, [Nullable(1)] T value)
		{
			*(T*)destination = value;
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00116022 File Offset: 0x00114222
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteUnaligned<[Nullable(2)] T>(ref byte destination, T value)
		{
			*Unsafe.As<byte, T>(ref destination) = value;
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T AddByteOffset<[Nullable(2)] T>(ref T source, IntPtr byteOffset)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00115FFF File Offset: 0x001141FF
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		public unsafe static T Read<[Nullable(2)] T>(void* source)
		{
			return *(T*)source;
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x00116019 File Offset: 0x00114219
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void Write<[Nullable(2)] T>(void* destination, [Nullable(1)] T value)
		{
			*(T*)destination = value;
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00007B62 File Offset: 0x00005D62
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(1)]
		public unsafe static ref T AsRef<[Nullable(2)] T>(void* source)
		{
			return ref *(T*)source;
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T AsRef<[Nullable(2)] T>([ScopedRef] [RequiresLocation] [In] ref T source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr ByteOffset<[Nullable(2)] T>([RequiresLocation] [AllowNull] [In] ref T origin, [RequiresLocation] [AllowNull] [In] ref T target)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00116030 File Offset: 0x00114230
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T NullRef<[Nullable(2)] T>()
		{
			return Unsafe.AsRef<T>(null);
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00116039 File Offset: 0x00114239
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNullRef<[Nullable(2)] T>([RequiresLocation] [In] ref T source)
		{
			return Unsafe.AsPointer<T>(Unsafe.AsRef<T>(ref source)) == null;
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SkipInit<[Nullable(2)] T>(out T value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x0011604A File Offset: 0x0011424A
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Subtract<[Nullable(2)] T>(ref T source, int elementOffset)
		{
			return Unsafe.SubtractByteOffset<T>(ref source, (IntPtr)elementOffset * (IntPtr)sizeof(T));
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x0011605C File Offset: 0x0011425C
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void* Subtract<[Nullable(2)] T>(void* source, int elementOffset)
		{
			return (void*)((byte*)source - (long)((IntPtr)elementOffset * (IntPtr)sizeof(T)));
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x0011606C File Offset: 0x0011426C
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Subtract<[Nullable(2)] T>(ref T source, IntPtr elementOffset)
		{
			return Unsafe.SubtractByteOffset<T>(ref source, elementOffset * (IntPtr)sizeof(T));
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x0011607D File Offset: 0x0011427D
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Subtract<[Nullable(2)] T>(ref T source, UIntPtr elementOffset)
		{
			return Unsafe.SubtractByteOffset<T>(ref source, elementOffset * (UIntPtr)((IntPtr)sizeof(T)));
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T SubtractByteOffset<[Nullable(2)] T>(ref T source, IntPtr byteOffset)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x0011608E File Offset: 0x0011428E
		[Intrinsic]
		[NonVersionable]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T SubtractByteOffset<[Nullable(2)] T>(ref T source, UIntPtr byteOffset)
		{
			return Unsafe.SubtractByteOffset<T>(ref source, (IntPtr)byteOffset);
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[NullableContext(0)]
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T Unbox<T>([Nullable(1)] object box) where T : struct
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00116097 File Offset: 0x00114297
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static UIntPtr OpportunisticMisalignment<T>([RequiresLocation] [In] ref T address, UIntPtr alignment)
		{
			return Unsafe.AsPointer<T>(Unsafe.AsRef<T>(ref address)) & alignment - 1;
		}
	}
}
