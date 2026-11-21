using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000077 RID: 119
	[NullableContext(1)]
	[Nullable(0)]
	public static class Buffer
	{
		// Token: 0x06000311 RID: 785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void __ZeroMemory(void* b, UIntPtr byteLength);

		// Token: 0x06000312 RID: 786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void __Memmove(byte* dest, byte* src, UIntPtr len);

		// Token: 0x06000313 RID: 787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BulkMoveWithWriteBarrier(ref byte dmem, ref byte smem, UIntPtr len, IntPtr type_handle);

		// Token: 0x06000314 RID: 788 RVA: 0x00009E74 File Offset: 0x00008074
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void Memmove<T>(ref T destination, ref T source, UIntPtr elementCount)
		{
			if (!RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				SpanHelpers.Memmove(Unsafe.As<T, byte>(ref destination), Unsafe.As<T, byte>(ref source), elementCount * (UIntPtr)((IntPtr)sizeof(T)));
				return;
			}
			if (elementCount > (UIntPtr)((IntPtr)0))
			{
				Buffer.BulkMoveWithWriteBarrier(Unsafe.As<T, byte>(ref destination), Unsafe.As<T, byte>(ref source), elementCount, typeof(T).TypeHandle.Value);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00009ED4 File Offset: 0x000080D4
		public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
		{
			ArgumentNullException.ThrowIfNull(src, "src");
			ArgumentNullException.ThrowIfNull(dst, "dst");
			UIntPtr uintPtr = src.NativeLength;
			if (src.GetType() != typeof(byte[]))
			{
				if (!src.GetCorElementTypeOfElementType().IsPrimitiveType())
				{
					throw new ArgumentException(SR.Arg_MustBePrimArray, "src");
				}
				uintPtr *= (UIntPtr)((IntPtr)src.GetElementSize());
			}
			UIntPtr uintPtr2 = uintPtr;
			if (src != dst)
			{
				uintPtr2 = dst.NativeLength;
				if (dst.GetType() != typeof(byte[]))
				{
					if (!dst.GetCorElementTypeOfElementType().IsPrimitiveType())
					{
						throw new ArgumentException(SR.Arg_MustBePrimArray, "dst");
					}
					uintPtr2 *= (UIntPtr)((IntPtr)dst.GetElementSize());
				}
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(srcOffset, "srcOffset");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(dstOffset, "dstOffset");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			UIntPtr uintPtr3 = (UIntPtr)((IntPtr)count);
			UIntPtr uintPtr4 = (UIntPtr)((IntPtr)srcOffset);
			UIntPtr uintPtr5 = (UIntPtr)((IntPtr)dstOffset);
			if (uintPtr < uintPtr4 + uintPtr3 || uintPtr2 < uintPtr5 + uintPtr3)
			{
				throw new ArgumentException(SR.Argument_InvalidOffLen);
			}
			Buffer.Memmove<byte>(Unsafe.AddByteOffset<byte>(MemoryMarshal.GetArrayDataReference(dst), uintPtr5), Unsafe.AddByteOffset<byte>(MemoryMarshal.GetArrayDataReference(src), uintPtr4), uintPtr3);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00009FEB File Offset: 0x000081EB
		public static int ByteLength(Array array)
		{
			ArgumentNullException.ThrowIfNull(array, "array");
			if (!array.GetCorElementTypeOfElementType().IsPrimitiveType())
			{
				throw new ArgumentException(SR.Arg_MustBePrimArray, "array");
			}
			return checked((int)(unchecked(array.NativeLength * (UIntPtr)((IntPtr)array.GetElementSize()))));
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000A024 File Offset: 0x00008224
		public unsafe static byte GetByte(Array array, int index)
		{
			if (index >= Buffer.ByteLength(array))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return *Unsafe.Add<byte>(MemoryMarshal.GetArrayDataReference(array), index);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000A043 File Offset: 0x00008243
		public unsafe static void SetByte(Array array, int index, byte value)
		{
			if (index >= Buffer.ByteLength(array))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			*Unsafe.Add<byte>(MemoryMarshal.GetArrayDataReference(array), index) = value;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000A063 File Offset: 0x00008263
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
		{
			if (sourceBytesToCopy > destinationSizeInBytes)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.sourceBytesToCopy);
			}
			Buffer.Memmove<byte>(ref *(byte*)destination, ref *(byte*)source, checked((UIntPtr)sourceBytesToCopy));
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000A079 File Offset: 0x00008279
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void MemoryCopy(void* source, void* destination, ulong destinationSizeInBytes, ulong sourceBytesToCopy)
		{
			if (sourceBytesToCopy > destinationSizeInBytes)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.sourceBytesToCopy);
			}
			Buffer.Memmove<byte>(ref *(byte*)destination, ref *(byte*)source, checked((UIntPtr)sourceBytesToCopy));
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000A090 File Offset: 0x00008290
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _Memmove(ref byte dest, ref byte src, UIntPtr len)
		{
			fixed (byte* ptr = &dest)
			{
				byte* dest2 = ptr;
				fixed (byte* ptr2 = &src)
				{
					byte* src2 = ptr2;
					Buffer.__Memmove(dest2, src2, len);
				}
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000A0B4 File Offset: 0x000082B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static void _ZeroMemory(ref byte b, UIntPtr byteLength)
		{
			fixed (byte* ptr = &b)
			{
				Buffer.__ZeroMemory((void*)ptr, byteLength);
			}
		}
	}
}
