using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005A1 RID: 1441
	public static class MemoryMarshal
	{
		// Token: 0x06006F5D RID: 28509 RVA: 0x0010C53B File Offset: 0x0010A73B
		[NullableContext(1)]
		[Intrinsic]
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T GetArrayDataReference<[Nullable(2)] T>(T[] array)
		{
			return Unsafe.As<byte, T>(ref Unsafe.As<Array.RawData>(array).Data);
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x0010C54D File Offset: 0x0010A74D
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref byte GetArrayDataReference(Array array)
		{
			return ref Unsafe.As<Array.RawData>(array).Data;
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x0010C55A File Offset: 0x0010A75A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Span<byte> AsBytes<T>(Span<T> span) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			return new Span<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), checked(span.Length * sizeof(T)));
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x0010C590 File Offset: 0x0010A790
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			return new ReadOnlySpan<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), checked(span.Length * sizeof(T)));
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x0010C5C6 File Offset: 0x0010A7C6
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlyMemory<T> memory)
		{
			return *Unsafe.As<ReadOnlyMemory<T>, Memory<T>>(ref memory);
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x0010C5D4 File Offset: 0x0010A7D4
		[NullableContext(1)]
		public static ref T GetReference<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> span)
		{
			return span._reference;
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x0010C5DD File Offset: 0x0010A7DD
		[NullableContext(1)]
		public static ref T GetReference<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> span)
		{
			return span._reference;
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x0010C5E6 File Offset: 0x0010A7E6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref T GetNonNullPinnableReference<T>(Span<T> span)
		{
			if (span.Length == 0)
			{
				return Unsafe.AsRef<T>(1);
			}
			return Unsafe.AsRef<T>(span._reference);
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x0010C605 File Offset: 0x0010A805
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span)
		{
			if (span.Length == 0)
			{
				return Unsafe.AsRef<T>(1);
			}
			return Unsafe.AsRef<T>(span._reference);
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x0010C624 File Offset: 0x0010A824
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Span<TTo> Cast<TFrom, TTo>(Span<TFrom> span) where TFrom : struct where TTo : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TFrom>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(TFrom));
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TTo>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(TTo));
			}
			uint num = (uint)sizeof(TFrom);
			uint num2 = (uint)sizeof(TTo);
			uint length = (uint)span.Length;
			int length2;
			if (num == num2)
			{
				length2 = (int)length;
			}
			else if (num == 1U)
			{
				length2 = (int)(length / num2);
			}
			else
			{
				length2 = checked((int)(unchecked((ulong)length * (ulong)num / (ulong)num2)));
			}
			return new Span<TTo>(Unsafe.As<TFrom, TTo>(span._reference), length2);
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x0010C6A4 File Offset: 0x0010A8A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<TTo> Cast<TFrom, TTo>(ReadOnlySpan<TFrom> span) where TFrom : struct where TTo : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TFrom>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(TFrom));
			}
			if (RuntimeHelpers.IsReferenceOrContainsReferences<TTo>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(TTo));
			}
			uint num = (uint)sizeof(TFrom);
			uint num2 = (uint)sizeof(TTo);
			uint length = (uint)span.Length;
			int length2;
			if (num == num2)
			{
				length2 = (int)length;
			}
			else if (num == 1U)
			{
				length2 = (int)(length / num2);
			}
			else
			{
				length2 = checked((int)(unchecked((ulong)length * (ulong)num / (ulong)num2)));
			}
			return new ReadOnlySpan<TTo>(Unsafe.As<TFrom, TTo>(MemoryMarshal.GetReference<TFrom>(span)), length2);
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x0010C720 File Offset: 0x0010A920
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> CreateSpan<[Nullable(2)] T>([ScopedRef] ref T reference, int length)
		{
			return new Span<T>(Unsafe.AsRef<T>(ref reference), length);
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x0010C72E File Offset: 0x0010A92E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> CreateReadOnlySpan<[Nullable(2)] T>([ScopedRef] [RequiresLocation] [In] ref T reference, int length)
		{
			return new ReadOnlySpan<T>(Unsafe.AsRef<T>(ref reference), length);
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x0010C73C File Offset: 0x0010A93C
		[CLSCompliant(false)]
		public unsafe static ReadOnlySpan<char> CreateReadOnlySpanFromNullTerminated(char* value)
		{
			if (value == null)
			{
				return default(ReadOnlySpan<char>);
			}
			return new ReadOnlySpan<char>((void*)value, string.wcslen(value));
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x0010C764 File Offset: 0x0010A964
		[CLSCompliant(false)]
		public unsafe static ReadOnlySpan<byte> CreateReadOnlySpanFromNullTerminated(byte* value)
		{
			if (value == null)
			{
				return default(ReadOnlySpan<byte>);
			}
			return new ReadOnlySpan<byte>((void*)value, string.strlen(value));
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x0010C78C File Offset: 0x0010A98C
		[NullableContext(2)]
		public static bool TryGetArray<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlyMemory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] out ArraySegment<T> segment)
		{
			int num;
			int num2;
			object objectStartLength = memory.GetObjectStartLength(out num, out num2);
			if (objectStartLength != null && (!(typeof(T) == typeof(char)) || !(objectStartLength.GetType() == typeof(string))))
			{
				if (RuntimeHelpers.ObjectHasComponentSize(objectStartLength))
				{
					segment = new ArraySegment<T>(Unsafe.As<T[]>(objectStartLength), num & int.MaxValue, num2);
					return true;
				}
				ArraySegment<T> arraySegment;
				if (Unsafe.As<MemoryManager<T>>(objectStartLength).TryGetArray(out arraySegment))
				{
					segment = new ArraySegment<T>(arraySegment.Array, arraySegment.Offset + num, num2);
					return true;
				}
			}
			if (num2 == 0)
			{
				segment = ArraySegment<T>.Empty;
				return true;
			}
			segment = default(ArraySegment<T>);
			return false;
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x0010C848 File Offset: 0x0010AA48
		[NullableContext(2)]
		public static bool TryGetMemoryManager<T, [Nullable(0)] TManager>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlyMemory<T> memory, [NotNullWhen(true)] out TManager manager) where TManager : MemoryManager<T>
		{
			int num;
			int num2;
			return (manager = (memory.GetObjectStartLength(out num, out num2) as TManager)) != null;
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x0010C87C File Offset: 0x0010AA7C
		[NullableContext(2)]
		public static bool TryGetMemoryManager<T, [Nullable(0)] TManager>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlyMemory<T> memory, [NotNullWhen(true)] out TManager manager, out int start, out int length) where TManager : MemoryManager<T>
		{
			if ((manager = (memory.GetObjectStartLength(out start, out length) as TManager)) == null)
			{
				start = 0;
				length = 0;
				return false;
			}
			return true;
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x0010C8B8 File Offset: 0x0010AAB8
		[NullableContext(1)]
		public static IEnumerable<T> ToEnumerable<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlyMemory<T> memory)
		{
			int num;
			int num2;
			object objectStartLength = memory.GetObjectStartLength(out num, out num2);
			if (num2 == 0 || objectStartLength == null)
			{
				return Array.Empty<T>();
			}
			if (typeof(T) == typeof(char))
			{
				string text = objectStartLength as string;
				if (text != null)
				{
					IEnumerable<char> enumerable;
					if (num != 0 || num2 != text.Length)
					{
						enumerable = MemoryMarshal.<ToEnumerable>g__FromString|18_0<T>(text, num, num2);
					}
					else
					{
						IEnumerable<char> enumerable2 = text;
						enumerable = enumerable2;
					}
					return (IEnumerable<T>)enumerable;
				}
			}
			if (!RuntimeHelpers.ObjectHasComponentSize(objectStartLength))
			{
				return MemoryMarshal.<ToEnumerable>g__FromMemoryManager|18_1<T>(memory);
			}
			T[] array = Unsafe.As<T[]>(objectStartLength);
			num &= int.MaxValue;
			if (num != 0 || num2 != array.Length)
			{
				return MemoryMarshal.<ToEnumerable>g__FromArray|18_2<T>(array, num, num2);
			}
			return array;
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x0010C95C File Offset: 0x0010AB5C
		public static bool TryGetString(ReadOnlyMemory<char> memory, [Nullable(2)] [NotNullWhen(true)] out string text, out int start, out int length)
		{
			int num;
			int num2;
			string text2 = memory.GetObjectStartLength(out num, out num2) as string;
			if (text2 != null)
			{
				text = text2;
				start = num;
				length = num2;
				return true;
			}
			text = null;
			start = 0;
			length = 0;
			return false;
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x0010C992 File Offset: 0x0010AB92
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Read<T>(ReadOnlySpan<byte> source) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if (sizeof(T) > source.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			return Unsafe.ReadUnaligned<T>(MemoryMarshal.GetReference<byte>(source));
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x0010C9CC File Offset: 0x0010ABCC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryRead<T>(ReadOnlySpan<byte> source, out T value) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if ((long)sizeof(T) > (long)((ulong)source.Length))
			{
				value = default(T);
				return false;
			}
			value = Unsafe.ReadUnaligned<T>(MemoryMarshal.GetReference<byte>(source));
			return true;
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x0010CA1B File Offset: 0x0010AC1B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Write<T>(Span<byte> destination, in T value) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if (sizeof(T) > destination.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			Unsafe.WriteUnaligned<T>(MemoryMarshal.GetReference<byte>(destination), value);
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x0010CA5A File Offset: 0x0010AC5A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWrite<T>(Span<byte> destination, in T value) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if ((long)sizeof(T) > (long)((ulong)destination.Length))
			{
				return false;
			}
			Unsafe.WriteUnaligned<T>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x0010CA97 File Offset: 0x0010AC97
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T AsRef<T>(Span<byte> span) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if ((long)sizeof(T) > (long)((ulong)span.Length))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			return Unsafe.As<byte, T>(MemoryMarshal.GetReference<byte>(span));
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x0010CAD2 File Offset: 0x0010ACD2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref readonly T AsRef<T>(ReadOnlySpan<byte> span) where T : struct
		{
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				ThrowHelper.ThrowInvalidTypeWithPointersNotSupported(typeof(T));
			}
			if ((long)sizeof(T) > (long)((ulong)span.Length))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			return Unsafe.As<byte, T>(MemoryMarshal.GetReference<byte>(span));
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x0010CB10 File Offset: 0x0010AD10
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> CreateFromPinnedArray<T>([Nullable(new byte[]
		{
			2,
			1
		})] T[] array, int start, int length)
		{
			if (array == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				return default(Memory<T>);
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			if (start > array.Length || length > array.Length - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Memory<T>(array, start | int.MinValue, length);
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x0010CB83 File Offset: 0x0010AD83
		[CompilerGenerated]
		internal static IEnumerable<char> <ToEnumerable>g__FromString|18_0<T>(string s, int offset, int count)
		{
			int num;
			for (int i = 0; i < count; i = num + 1)
			{
				yield return s[offset + i];
				num = i;
			}
			yield break;
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x0010CBA1 File Offset: 0x0010ADA1
		[CompilerGenerated]
		internal static IEnumerable<T> <ToEnumerable>g__FromArray|18_2<T>(T[] array, int offset, int count)
		{
			int num;
			for (int i = 0; i < count; i = num + 1)
			{
				yield return array[offset + i];
				num = i;
			}
			yield break;
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x0010CBBF File Offset: 0x0010ADBF
		[CompilerGenerated]
		internal unsafe static IEnumerable<T> <ToEnumerable>g__FromMemoryManager|18_1<T>(ReadOnlyMemory<T> memory)
		{
			int num;
			for (int i = 0; i < memory.Length; i = num + 1)
			{
				yield return *memory.Span[i];
				num = i;
			}
			yield break;
		}
	}
}
