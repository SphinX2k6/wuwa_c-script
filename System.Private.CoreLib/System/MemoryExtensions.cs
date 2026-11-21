using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Text;

namespace System
{
	// Token: 0x02000169 RID: 361
	public static class MemoryExtensions
	{
		// Token: 0x06001776 RID: 6006 RVA: 0x00047020 File Offset: 0x00045220
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, int start)
		{
			if (array == null)
			{
				if (start != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException();
				}
				return default(Span<T>);
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			if (start > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Span<T>(Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), (IntPtr)((UIntPtr)start)), array.Length - start);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00047094 File Offset: 0x00045294
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, Index startIndex)
		{
			if (array == null)
			{
				if (!startIndex.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				return default(Span<T>);
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			int offset = startIndex.GetOffset(array.Length);
			if (offset > array.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new Span<T>(Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), (IntPtr)((UIntPtr)offset)), array.Length - offset);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0004711C File Offset: 0x0004531C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, Range range)
		{
			if (array == null)
			{
				Index start = range.Start;
				Index end = range.End;
				if (!start.Equals(Index.Start) || !end.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				return default(Span<T>);
			}
			if (!typeof(T).IsValueType && array.GetType() != typeof(T[]))
			{
				ThrowHelper.ThrowArrayTypeMismatchException();
			}
			ValueTuple<int, int> offsetAndLength = range.GetOffsetAndLength(array.Length);
			int item = offsetAndLength.Item1;
			int item2 = offsetAndLength.Item2;
			return new Span<T>(Unsafe.Add<T>(MemoryMarshal.GetArrayDataReference<T>(array), (IntPtr)((UIntPtr)item)), item2);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000471C0 File Offset: 0x000453C0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<char> AsSpan([Nullable(2)] this string text)
		{
			if (text == null)
			{
				return default(ReadOnlySpan<char>);
			}
			return new ReadOnlySpan<char>(text.GetRawStringData(), text.Length);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000471EC File Offset: 0x000453EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<char> AsSpan([Nullable(2)] this string text, int start)
		{
			if (text == null)
			{
				if (start != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
				}
				return default(ReadOnlySpan<char>);
			}
			if (start > text.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new ReadOnlySpan<char>(Unsafe.Add<char>(text.GetRawStringData(), (IntPtr)((UIntPtr)start)), text.Length - start);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0004723C File Offset: 0x0004543C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<char> AsSpan([Nullable(2)] this string text, Index startIndex)
		{
			if (text == null)
			{
				if (!startIndex.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex);
				}
				return default(ReadOnlySpan<char>);
			}
			int offset = startIndex.GetOffset(text.Length);
			if (offset > text.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex);
			}
			return new ReadOnlySpan<char>(Unsafe.Add<char>(text.GetRawStringData(), (IntPtr)((UIntPtr)offset)), text.Length - offset);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x000472A4 File Offset: 0x000454A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<char> AsSpan([Nullable(2)] this string text, Range range)
		{
			if (text == null)
			{
				Index start = range.Start;
				Index end = range.End;
				if (!start.Equals(Index.Start) || !end.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.text);
				}
				return default(ReadOnlySpan<char>);
			}
			ValueTuple<int, int> offsetAndLength = range.GetOffsetAndLength(text.Length);
			int item = offsetAndLength.Item1;
			int item2 = offsetAndLength.Item2;
			return new ReadOnlySpan<char>(Unsafe.Add<char>(text.GetRawStringData(), (IntPtr)((UIntPtr)item)), item2);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00047320 File Offset: 0x00045520
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<char> AsSpan([Nullable(2)] this string text, int start, int length)
		{
			if (text == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
				}
				return default(ReadOnlySpan<char>);
			}
			if ((ulong)start + (ulong)length > (ulong)text.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new ReadOnlySpan<char>(Unsafe.Add<char>(text.GetRawStringData(), (IntPtr)((UIntPtr)start)), length);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00047370 File Offset: 0x00045570
		public static ReadOnlyMemory<char> AsMemory([Nullable(2)] this string text)
		{
			if (text == null)
			{
				return default(ReadOnlyMemory<char>);
			}
			return new ReadOnlyMemory<char>(text, 0, text.Length);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00047398 File Offset: 0x00045598
		public static ReadOnlyMemory<char> AsMemory([Nullable(2)] this string text, int start)
		{
			if (text == null)
			{
				if (start != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
				}
				return default(ReadOnlyMemory<char>);
			}
			if (start > text.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new ReadOnlyMemory<char>(text, start, text.Length - start);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000473DC File Offset: 0x000455DC
		public static ReadOnlyMemory<char> AsMemory([Nullable(2)] this string text, Index startIndex)
		{
			if (text == null)
			{
				if (!startIndex.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.text);
				}
				return default(ReadOnlyMemory<char>);
			}
			int offset = startIndex.GetOffset(text.Length);
			if (offset > text.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException();
			}
			return new ReadOnlyMemory<char>(text, offset, text.Length - offset);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00047438 File Offset: 0x00045638
		public static ReadOnlyMemory<char> AsMemory([Nullable(2)] this string text, int start, int length)
		{
			if (text == null)
			{
				if (start != 0 || length != 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
				}
				return default(ReadOnlyMemory<char>);
			}
			if ((ulong)start + (ulong)length > (ulong)text.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new ReadOnlyMemory<char>(text, start, length);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0004747C File Offset: 0x0004567C
		public static ReadOnlyMemory<char> AsMemory([Nullable(2)] this string text, Range range)
		{
			if (text == null)
			{
				Index start = range.Start;
				Index end = range.End;
				if (!start.Equals(Index.Start) || !end.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.text);
				}
				return default(ReadOnlyMemory<char>);
			}
			ValueTuple<int, int> offsetAndLength = range.GetOffsetAndLength(text.Length);
			int item = offsetAndLength.Item1;
			int item2 = offsetAndLength.Item2;
			return new ReadOnlyMemory<char>(text, item, item2);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000474EC File Offset: 0x000456EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Contains<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.ContainsValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.ContainsValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.ContainsValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.ContainsValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.Contains<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000475B4 File Offset: 0x000457B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Contains<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.ContainsValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.ContainsValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.ContainsValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.ContainsValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.Contains<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0004767A File Offset: 0x0004587A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1) where T : IEquatable<T>
		{
			return span.ContainsAny(value0, value1);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00047689 File Offset: 0x00045889
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			return span.ContainsAny(value0, value1, value2);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00047699 File Offset: 0x00045899
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.ContainsAny(values);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x000476A7 File Offset: 0x000458A7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			return span.ContainsAny(values);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x000476B5 File Offset: 0x000458B5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny(this Span<char> span, [Nullable(1)] SearchValues<string> values)
		{
			return span.ContainsAny(values);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000476C3 File Offset: 0x000458C3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			return span.ContainsAnyExcept(value);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000476D1 File Offset: 0x000458D1
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1) where T : IEquatable<T>
		{
			return span.ContainsAnyExcept(value0, value1);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x000476E0 File Offset: 0x000458E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			return span.ContainsAnyExcept(value0, value1, value2);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000476F0 File Offset: 0x000458F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.ContainsAnyExcept(values);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x000476FE File Offset: 0x000458FE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			return span.ContainsAnyExcept(values);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0004770C File Offset: 0x0004590C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.ContainsAnyInRange(lowInclusive, highInclusive);
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0004771B File Offset: 0x0004591B
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExceptInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.ContainsAnyExceptInRange(lowInclusive, highInclusive);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0004772A File Offset: 0x0004592A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>
		{
			return span.IndexOfAny(value0, value1) >= 0;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0004773A File Offset: 0x0004593A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			return span.IndexOfAny(value0, value1, value2) >= 0;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0004774B File Offset: 0x0004594B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.IndexOfAny(values) >= 0;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0004775A File Offset: 0x0004595A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.ContainsAny(span);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0004776C File Offset: 0x0004596C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAny(this ReadOnlySpan<char> span, [Nullable(1)] SearchValues<string> values)
		{
			return span.IndexOfAny(values) >= 0;
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0004777B File Offset: 0x0004597B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(value) >= 0;
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x0004778A File Offset: 0x0004598A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(value0, value1) >= 0;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0004779A File Offset: 0x0004599A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(value0, value1, value2) >= 0;
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000477AB File Offset: 0x000459AB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(values) >= 0;
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000477BA File Offset: 0x000459BA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.ContainsAnyExcept(span);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x000477CC File Offset: 0x000459CC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.IndexOfAnyInRange(lowInclusive, highInclusive) >= 0;
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x000477DC File Offset: 0x000459DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsAnyExceptInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.IndexOfAnyExceptInRange(lowInclusive, highInclusive) >= 0;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000477EC File Offset: 0x000459EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.IndexOfValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.IndexOfValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.IndexOf<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000478B4 File Offset: 0x00045AB4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOf(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOf(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
			}
			return SpanHelpers.IndexOf<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(value), value.Length);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00047950 File Offset: 0x00045B50
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.LastIndexOfValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.LastIndexOfValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.LastIndexOf<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00047A18 File Offset: 0x00045C18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOf(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOf(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
			}
			return SpanHelpers.LastIndexOf<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(value), value.Length);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00047AB1 File Offset: 0x00045CB1
		public static int IndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(value);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00047ABF File Offset: 0x00045CBF
		[NullableContext(1)]
		public static int IndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(value0, value1);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00047ACE File Offset: 0x00045CCE
		[NullableContext(1)]
		public static int IndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(value0, value1, value2);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00047ADE File Offset: 0x00045CDE
		public static int IndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(values);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00047AEC File Offset: 0x00045CEC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			return span.IndexOfAnyExcept(values);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00047AFC File Offset: 0x00045CFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.IndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00047BC4 File Offset: 0x00045DC4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), span.Length);
				}
			}
			return SpanHelpers.IndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value0, value1, span.Length);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00047C48 File Offset: 0x00045E48
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), span.Length);
				}
			}
			return SpanHelpers.IndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, span.Length);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00047CD8 File Offset: 0x00045ED8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int IndexOfAnyExcept<T>(this ReadOnlySpan<T> span, T value0, T value1, T value2, T value3) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), Unsafe.BitCast<T, byte>(value3), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), Unsafe.BitCast<T, short>(value3), span.Length);
				}
			}
			return SpanHelpers.IndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, value3, span.Length);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00047D78 File Offset: 0x00045F78
		public unsafe static int IndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			switch (values.Length)
			{
			case 0:
				if (!span.IsEmpty)
				{
					return 0;
				}
				return -1;
			case 1:
				return span.IndexOfAnyExcept(*values[0]);
			case 2:
				return span.IndexOfAnyExcept(*values[0], *values[1]);
			case 3:
				return span.IndexOfAnyExcept(*values[0], *values[1], *values[2]);
			case 4:
				return span.IndexOfAnyExcept(*values[0], *values[1], *values[2], *values[3]);
			default:
				if (RuntimeHelpers.IsBitwiseEquatable<T>())
				{
					if (sizeof(T) == 1 && values.Length == 5)
					{
						ref byte ptr = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values));
						return SpanHelpers.IndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), *Unsafe.Add<byte>(ref ptr, 3), *Unsafe.Add<byte>(ref ptr, 4), span.Length);
					}
					if (sizeof(T) == 2 && values.Length == 5)
					{
						ref short ptr2 = ref Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(values));
						return SpanHelpers.IndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), ptr2, *Unsafe.Add<short>(ref ptr2, 1), *Unsafe.Add<short>(ref ptr2, 2), *Unsafe.Add<short>(ref ptr2, 3), *Unsafe.Add<short>(ref ptr2, 4), span.Length);
					}
				}
				if (RuntimeHelpers.IsBitwiseEquatable<T>() && sizeof(T) == 2)
				{
					return ProbabilisticMap.IndexOfAnyExcept(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(values)), values.Length);
				}
				for (int i = 0; i < span.Length; i++)
				{
					if (!values.Contains(*span[i]))
					{
						return i;
					}
				}
				return -1;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00047F77 File Offset: 0x00046177
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.IndexOfAnyExcept(span);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00047F89 File Offset: 0x00046189
		public static int LastIndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			return span.LastIndexOfAnyExcept(value);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00047F97 File Offset: 0x00046197
		[NullableContext(1)]
		public static int LastIndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1) where T : IEquatable<T>
		{
			return span.LastIndexOfAnyExcept(value0, value1);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00047FA6 File Offset: 0x000461A6
		[NullableContext(1)]
		public static int LastIndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			return span.LastIndexOfAnyExcept(value0, value1, value2);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00047FB6 File Offset: 0x000461B6
		public static int LastIndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.LastIndexOfAnyExcept(values);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00047FC4 File Offset: 0x000461C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			return span.LastIndexOfAnyExcept(values);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00047FD4 File Offset: 0x000461D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0004809C File Offset: 0x0004629C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value0, value1, span.Length);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00048120 File Offset: 0x00046320
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExcept<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, span.Length);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000481B0 File Offset: 0x000463B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LastIndexOfAnyExcept<T>(this ReadOnlySpan<T> span, T value0, T value1, T value2, T value3) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), Unsafe.BitCast<T, byte>(value3), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), Unsafe.BitCast<T, short>(value3), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAnyExcept<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, value3, span.Length);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00048250 File Offset: 0x00046450
		public unsafe static int LastIndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			switch (values.Length)
			{
			case 0:
				return span.Length - 1;
			case 1:
				return span.LastIndexOfAnyExcept(*values[0]);
			case 2:
				return span.LastIndexOfAnyExcept(*values[0], *values[1]);
			case 3:
				return span.LastIndexOfAnyExcept(*values[0], *values[1], *values[2]);
			case 4:
				return span.LastIndexOfAnyExcept(*values[0], *values[1], *values[2], *values[3]);
			default:
				if (RuntimeHelpers.IsBitwiseEquatable<T>())
				{
					if (sizeof(T) == 1 && values.Length == 5)
					{
						ref byte ptr = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values));
						return SpanHelpers.LastIndexOfAnyExceptValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), *Unsafe.Add<byte>(ref ptr, 3), *Unsafe.Add<byte>(ref ptr, 4), span.Length);
					}
					if (sizeof(T) == 2 && values.Length == 5)
					{
						ref short ptr2 = ref Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(values));
						return SpanHelpers.LastIndexOfAnyExceptValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), ptr2, *Unsafe.Add<short>(ref ptr2, 1), *Unsafe.Add<short>(ref ptr2, 2), *Unsafe.Add<short>(ref ptr2, 3), *Unsafe.Add<short>(ref ptr2, 4), span.Length);
					}
				}
				if (RuntimeHelpers.IsBitwiseEquatable<T>() && sizeof(T) == 2)
				{
					return ProbabilisticMap.LastIndexOfAnyExcept(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(values)), values.Length);
				}
				for (int i = span.Length - 1; i >= 0; i--)
				{
					if (!values.Contains(*span[i]))
					{
						return i;
					}
				}
				return -1;
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0004844E File Offset: 0x0004664E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExcept<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.LastIndexOfAnyExcept(span);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00048460 File Offset: 0x00046660
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.IndexOfAnyInRange(lowInclusive, highInclusive);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00048470 File Offset: 0x00046670
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			if (lowInclusive == null || highInclusive == null)
			{
				MemoryExtensions.ThrowNullLowHighInclusive<T>(lowInclusive, highInclusive);
			}
			if (Vector128.IsHardwareAccelerated)
			{
				bool flag = lowInclusive is byte || lowInclusive is sbyte;
				if (flag)
				{
					return SpanHelpers.IndexOfAnyInRangeUnsignedNumber<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(lowInclusive), Unsafe.BitCast<T, byte>(highInclusive), span.Length);
				}
				flag = (lowInclusive is short || lowInclusive is ushort || lowInclusive is char);
				if (flag)
				{
					return SpanHelpers.IndexOfAnyInRangeUnsignedNumber<ushort>(Unsafe.As<T, ushort>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ushort>(lowInclusive), Unsafe.BitCast<T, ushort>(highInclusive), span.Length);
				}
				flag = (lowInclusive is int || lowInclusive is uint);
				bool flag2 = flag;
				if (!flag2)
				{
					bool flag3 = 8 == 4;
					if (flag3)
					{
					}
					flag2 = flag3;
				}
				if (flag2)
				{
					return SpanHelpers.IndexOfAnyInRangeUnsignedNumber<uint>(Unsafe.As<T, uint>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, uint>(lowInclusive), Unsafe.BitCast<T, uint>(highInclusive), span.Length);
				}
				flag2 = (lowInclusive is long || lowInclusive is ulong);
				flag = flag2;
				if (!flag)
				{
					bool flag3 = 8 == 8;
					bool flag4 = lowInclusive is IntPtr || lowInclusive is UIntPtr;
					flag3 = flag4;
					flag = flag3;
				}
				if (flag)
				{
					return SpanHelpers.IndexOfAnyInRangeUnsignedNumber<ulong>(Unsafe.As<T, ulong>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ulong>(lowInclusive), Unsafe.BitCast<T, ulong>(highInclusive), span.Length);
				}
			}
			return SpanHelpers.IndexOfAnyInRange<T>(MemoryMarshal.GetReference<T>(span), lowInclusive, highInclusive, span.Length);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00048622 File Offset: 0x00046822
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExceptInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.IndexOfAnyExceptInRange(lowInclusive, highInclusive);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00048634 File Offset: 0x00046834
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExceptInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			if (lowInclusive == null || highInclusive == null)
			{
				MemoryExtensions.ThrowNullLowHighInclusive<T>(lowInclusive, highInclusive);
			}
			if (Vector128.IsHardwareAccelerated)
			{
				bool flag = lowInclusive is byte || lowInclusive is sbyte;
				if (flag)
				{
					return SpanHelpers.IndexOfAnyExceptInRangeUnsignedNumber<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(lowInclusive), Unsafe.BitCast<T, byte>(highInclusive), span.Length);
				}
				flag = (lowInclusive is short || lowInclusive is ushort || lowInclusive is char);
				if (flag)
				{
					return SpanHelpers.IndexOfAnyExceptInRangeUnsignedNumber<ushort>(Unsafe.As<T, ushort>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ushort>(lowInclusive), Unsafe.BitCast<T, ushort>(highInclusive), span.Length);
				}
				flag = (lowInclusive is int || lowInclusive is uint);
				bool flag2 = flag;
				if (!flag2)
				{
					bool flag3 = 8 == 4;
					if (flag3)
					{
					}
					flag2 = flag3;
				}
				if (flag2)
				{
					return SpanHelpers.IndexOfAnyExceptInRangeUnsignedNumber<uint>(Unsafe.As<T, uint>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, uint>(lowInclusive), Unsafe.BitCast<T, uint>(highInclusive), span.Length);
				}
				flag2 = (lowInclusive is long || lowInclusive is ulong);
				flag = flag2;
				if (!flag)
				{
					bool flag3 = 8 == 8;
					bool flag4 = lowInclusive is IntPtr || lowInclusive is UIntPtr;
					flag3 = flag4;
					flag = flag3;
				}
				if (flag)
				{
					return SpanHelpers.IndexOfAnyExceptInRangeUnsignedNumber<ulong>(Unsafe.As<T, ulong>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ulong>(lowInclusive), Unsafe.BitCast<T, ulong>(highInclusive), span.Length);
				}
			}
			return SpanHelpers.IndexOfAnyExceptInRange<T>(MemoryMarshal.GetReference<T>(span), lowInclusive, highInclusive, span.Length);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000487E6 File Offset: 0x000469E6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.LastIndexOfAnyInRange(lowInclusive, highInclusive);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000487F8 File Offset: 0x000469F8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			if (lowInclusive == null || highInclusive == null)
			{
				MemoryExtensions.ThrowNullLowHighInclusive<T>(lowInclusive, highInclusive);
			}
			if (Vector128.IsHardwareAccelerated)
			{
				bool flag = lowInclusive is byte || lowInclusive is sbyte;
				if (flag)
				{
					return SpanHelpers.LastIndexOfAnyInRangeUnsignedNumber<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(lowInclusive), Unsafe.BitCast<T, byte>(highInclusive), span.Length);
				}
				flag = (lowInclusive is short || lowInclusive is ushort || lowInclusive is char);
				if (flag)
				{
					return SpanHelpers.LastIndexOfAnyInRangeUnsignedNumber<ushort>(Unsafe.As<T, ushort>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ushort>(lowInclusive), Unsafe.BitCast<T, ushort>(highInclusive), span.Length);
				}
				flag = (lowInclusive is int || lowInclusive is uint);
				bool flag2 = flag;
				if (!flag2)
				{
					bool flag3 = 8 == 4;
					if (flag3)
					{
					}
					flag2 = flag3;
				}
				if (flag2)
				{
					return SpanHelpers.LastIndexOfAnyInRangeUnsignedNumber<uint>(Unsafe.As<T, uint>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, uint>(lowInclusive), Unsafe.BitCast<T, uint>(highInclusive), span.Length);
				}
				flag2 = (lowInclusive is long || lowInclusive is ulong);
				flag = flag2;
				if (!flag)
				{
					bool flag3 = 8 == 8;
					bool flag4 = lowInclusive is IntPtr || lowInclusive is UIntPtr;
					flag3 = flag4;
					flag = flag3;
				}
				if (flag)
				{
					return SpanHelpers.LastIndexOfAnyInRangeUnsignedNumber<ulong>(Unsafe.As<T, ulong>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ulong>(lowInclusive), Unsafe.BitCast<T, ulong>(highInclusive), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAnyInRange<T>(MemoryMarshal.GetReference<T>(span), lowInclusive, highInclusive, span.Length);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x000489AA File Offset: 0x00046BAA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExceptInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			return span.LastIndexOfAnyExceptInRange(lowInclusive, highInclusive);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x000489BC File Offset: 0x00046BBC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAnyExceptInRange<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T lowInclusive, T highInclusive) where T : IComparable<T>
		{
			if (lowInclusive == null || highInclusive == null)
			{
				MemoryExtensions.ThrowNullLowHighInclusive<T>(lowInclusive, highInclusive);
			}
			if (Vector128.IsHardwareAccelerated)
			{
				bool flag = lowInclusive is byte || lowInclusive is sbyte;
				if (flag)
				{
					return SpanHelpers.LastIndexOfAnyExceptInRangeUnsignedNumber<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(lowInclusive), Unsafe.BitCast<T, byte>(highInclusive), span.Length);
				}
				flag = (lowInclusive is short || lowInclusive is ushort || lowInclusive is char);
				if (flag)
				{
					return SpanHelpers.LastIndexOfAnyExceptInRangeUnsignedNumber<ushort>(Unsafe.As<T, ushort>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ushort>(lowInclusive), Unsafe.BitCast<T, ushort>(highInclusive), span.Length);
				}
				flag = (lowInclusive is int || lowInclusive is uint);
				bool flag2 = flag;
				if (!flag2)
				{
					bool flag3 = 8 == 4;
					if (flag3)
					{
					}
					flag2 = flag3;
				}
				if (flag2)
				{
					return SpanHelpers.LastIndexOfAnyExceptInRangeUnsignedNumber<uint>(Unsafe.As<T, uint>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, uint>(lowInclusive), Unsafe.BitCast<T, uint>(highInclusive), span.Length);
				}
				flag2 = (lowInclusive is long || lowInclusive is ulong);
				flag = flag2;
				if (!flag)
				{
					bool flag3 = 8 == 8;
					bool flag4 = lowInclusive is IntPtr || lowInclusive is UIntPtr;
					flag3 = flag4;
					flag = flag3;
				}
				if (flag)
				{
					return SpanHelpers.LastIndexOfAnyExceptInRangeUnsignedNumber<ulong>(Unsafe.As<T, ulong>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, ulong>(lowInclusive), Unsafe.BitCast<T, ulong>(highInclusive), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAnyExceptInRange<T>(MemoryMarshal.GetReference<T>(span), lowInclusive, highInclusive, span.Length);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00048B6E File Offset: 0x00046D6E
		[DoesNotReturn]
		private static void ThrowNullLowHighInclusive<T>(T lowInclusive, T highInclusive)
		{
			throw new ArgumentNullException((lowInclusive == null) ? "lowInclusive" : "highInclusive");
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00048B8C File Offset: 0x00046D8C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool SequenceEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other) where T : IEquatable<T>
		{
			int length = span.Length;
			int length2 = other.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return length == length2 && SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(other)), (UIntPtr)length2 * (UIntPtr)((IntPtr)sizeof(T)));
			}
			return length == length2 && SpanHelpers.SequenceEqual<T>(MemoryMarshal.GetReference<T>(span), MemoryMarshal.GetReference<T>(other), length);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00048BF4 File Offset: 0x00046DF4
		public static int SequenceCompareTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other) where T : IComparable<T>
		{
			if (typeof(T) == typeof(byte))
			{
				return SpanHelpers.SequenceCompareTo(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(other)), other.Length);
			}
			if (typeof(T) == typeof(char))
			{
				return SpanHelpers.SequenceCompareTo(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(other)), other.Length);
			}
			return SpanHelpers.SequenceCompareTo<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(other), other.Length);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00048CAC File Offset: 0x00046EAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.IndexOfValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.IndexOfValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.IndexOf<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00048D74 File Offset: 0x00046F74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOf(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOf(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
			}
			return SpanHelpers.IndexOf<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(value), value.Length);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00048E10 File Offset: 0x00047010
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.LastIndexOfValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.LastIndexOfValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.LastIndexOf<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00048ED8 File Offset: 0x000470D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOf<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOf(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOf(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(value)), value.Length);
				}
			}
			return SpanHelpers.LastIndexOf<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(value), value.Length);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00048F74 File Offset: 0x00047174
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), span.Length);
				}
			}
			return SpanHelpers.IndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, span.Length);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00048FF8 File Offset: 0x000471F8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), span.Length);
				}
			}
			return SpanHelpers.IndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, span.Length);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00049087 File Offset: 0x00047287
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.IndexOfAny(values);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00049095 File Offset: 0x00047295
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			return span.IndexOfAny(values);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x000490A3 File Offset: 0x000472A3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny(this Span<char> span, [Nullable(1)] SearchValues<string> values)
		{
			return span.IndexOfAny(values);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x000490B4 File Offset: 0x000472B4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), span.Length);
				}
			}
			return SpanHelpers.IndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, span.Length);
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00049138 File Offset: 0x00047338
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.IndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.IndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), span.Length);
				}
			}
			return SpanHelpers.IndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, span.Length);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x000491C8 File Offset: 0x000473C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int IndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					ref byte searchSpace = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span));
					ref byte ptr = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values));
					switch (values.Length)
					{
					case 0:
						return -1;
					case 1:
						return SpanHelpers.IndexOfValueType<byte>(ref searchSpace, ptr, span.Length);
					case 2:
						return SpanHelpers.IndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), span.Length);
					case 3:
						return SpanHelpers.IndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), span.Length);
					case 4:
						return SpanHelpers.IndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), *Unsafe.Add<byte>(ref ptr, 3), span.Length);
					case 5:
						return SpanHelpers.IndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), *Unsafe.Add<byte>(ref ptr, 3), *Unsafe.Add<byte>(ref ptr, 4), span.Length);
					}
				}
				if (sizeof(T) == 2)
				{
					ref short ptr2 = ref Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span));
					ref short ptr3 = ref Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(values));
					int result;
					switch (values.Length)
					{
					case 0:
						result = -1;
						break;
					case 1:
						result = SpanHelpers.IndexOfValueType<short>(ref ptr2, ptr3, span.Length);
						break;
					case 2:
						result = SpanHelpers.IndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), span.Length);
						break;
					case 3:
						result = SpanHelpers.IndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), *Unsafe.Add<short>(ref ptr3, 2), span.Length);
						break;
					case 4:
						result = SpanHelpers.IndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), *Unsafe.Add<short>(ref ptr3, 2), *Unsafe.Add<short>(ref ptr3, 3), span.Length);
						break;
					case 5:
						result = SpanHelpers.IndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), *Unsafe.Add<short>(ref ptr3, 2), *Unsafe.Add<short>(ref ptr3, 3), *Unsafe.Add<short>(ref ptr3, 4), span.Length);
						break;
					default:
						result = ProbabilisticMap.IndexOfAny(Unsafe.As<short, char>(ref ptr2), span.Length, Unsafe.As<short, char>(ref ptr3), values.Length);
						break;
					}
					return result;
				}
			}
			return SpanHelpers.IndexOfAny<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(values), values.Length);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0004942D File Offset: 0x0004762D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.IndexOfAny(span);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0004943F File Offset: 0x0004763F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny(this ReadOnlySpan<char> span, [Nullable(1)] SearchValues<string> values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.IndexOfAnyMultiString(span);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00049454 File Offset: 0x00047654
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, span.Length);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000494D8 File Offset: 0x000476D8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, span.Length);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00049567 File Offset: 0x00047767
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			return span.LastIndexOfAny(values);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00049575 File Offset: 0x00047775
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			return span.LastIndexOfAny(values);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00049584 File Offset: 0x00047784
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, span.Length);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00049608 File Offset: 0x00047808
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value0, T value1, T value2) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.LastIndexOfAnyValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value0), Unsafe.BitCast<T, byte>(value1), Unsafe.BitCast<T, byte>(value2), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.LastIndexOfAnyValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value0), Unsafe.BitCast<T, short>(value1), Unsafe.BitCast<T, short>(value2), span.Length);
				}
			}
			return SpanHelpers.LastIndexOfAny<T>(MemoryMarshal.GetReference<T>(span), value0, value1, value2, span.Length);
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00049698 File Offset: 0x00047898
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int LastIndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					ref byte searchSpace = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span));
					ref byte ptr = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values));
					switch (values.Length)
					{
					case 0:
						return -1;
					case 1:
						return SpanHelpers.LastIndexOfValueType<byte>(ref searchSpace, ptr, span.Length);
					case 2:
						return SpanHelpers.LastIndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), span.Length);
					case 3:
						return SpanHelpers.LastIndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), span.Length);
					case 4:
						return SpanHelpers.LastIndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), *Unsafe.Add<byte>(ref ptr, 3), span.Length);
					case 5:
						return SpanHelpers.LastIndexOfAnyValueType<byte>(ref searchSpace, ptr, *Unsafe.Add<byte>(ref ptr, 1), *Unsafe.Add<byte>(ref ptr, 2), *Unsafe.Add<byte>(ref ptr, 3), *Unsafe.Add<byte>(ref ptr, 4), span.Length);
					}
				}
				if (sizeof(T) == 2)
				{
					ref short ptr2 = ref Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span));
					ref short ptr3 = ref Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(values));
					int result;
					switch (values.Length)
					{
					case 0:
						result = -1;
						break;
					case 1:
						result = SpanHelpers.LastIndexOfValueType<short>(ref ptr2, ptr3, span.Length);
						break;
					case 2:
						result = SpanHelpers.LastIndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), span.Length);
						break;
					case 3:
						result = SpanHelpers.LastIndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), *Unsafe.Add<short>(ref ptr3, 2), span.Length);
						break;
					case 4:
						result = SpanHelpers.LastIndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), *Unsafe.Add<short>(ref ptr3, 2), *Unsafe.Add<short>(ref ptr3, 3), span.Length);
						break;
					case 5:
						result = SpanHelpers.LastIndexOfAnyValueType<short>(ref ptr2, ptr3, *Unsafe.Add<short>(ref ptr3, 1), *Unsafe.Add<short>(ref ptr3, 2), *Unsafe.Add<short>(ref ptr3, 3), *Unsafe.Add<short>(ref ptr3, 4), span.Length);
						break;
					default:
						result = ProbabilisticMap.LastIndexOfAny(Unsafe.As<short, char>(ref ptr2), span.Length, Unsafe.As<short, char>(ref ptr3), values.Length);
						break;
					}
					return result;
				}
			}
			return SpanHelpers.LastIndexOfAny<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(values), values.Length);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000498FD File Offset: 0x00047AFD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LastIndexOfAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] SearchValues<T> values) where T : IEquatable<T>
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return values.LastIndexOfAny(span);
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00049910 File Offset: 0x00047B10
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool SequenceEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other) where T : IEquatable<T>
		{
			int length = span.Length;
			int length2 = other.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return length == length2 && SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(other)), (UIntPtr)length2 * (UIntPtr)((IntPtr)sizeof(T)));
			}
			return length == length2 && SpanHelpers.SequenceEqual<T>(MemoryMarshal.GetReference<T>(span), MemoryMarshal.GetReference<T>(other), length);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00049978 File Offset: 0x00047B78
		[NullableContext(2)]
		public static bool SequenceEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer = null)
		{
			return span.SequenceEqual(other, comparer);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00049988 File Offset: 0x00047B88
		[NullableContext(2)]
		public unsafe static bool SequenceEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer = null)
		{
			if (span.Length != other.Length)
			{
				return false;
			}
			if (!typeof(T).IsValueType || (comparer != null && comparer != EqualityComparer<T>.Default))
			{
				if (comparer == null)
				{
					comparer = EqualityComparer<T>.Default;
				}
				for (int i = 0; i < span.Length; i++)
				{
					if (!comparer.Equals(*span[i], *other[i]))
					{
						return false;
					}
				}
				return true;
			}
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(other)), (UIntPtr)span.Length * (UIntPtr)((IntPtr)sizeof(T)));
			}
			for (int j = 0; j < span.Length; j++)
			{
				if (!EqualityComparer<T>.Default.Equals(*span[j], *other[j]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00049A74 File Offset: 0x00047C74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int SequenceCompareTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other) where T : IComparable<T>
		{
			if (typeof(T) == typeof(byte))
			{
				return SpanHelpers.SequenceCompareTo(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(other)), other.Length);
			}
			if (typeof(T) == typeof(char))
			{
				return SpanHelpers.SequenceCompareTo(Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(span)), span.Length, Unsafe.As<T, char>(MemoryMarshal.GetReference<T>(other)), other.Length);
			}
			return SpanHelpers.SequenceCompareTo<T>(MemoryMarshal.GetReference<T>(span), span.Length, MemoryMarshal.GetReference<T>(other), other.Length);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00049B2C File Offset: 0x00047D2C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool StartsWith<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = value.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return length <= span.Length && SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), (UIntPtr)length * (UIntPtr)((IntPtr)sizeof(T)));
			}
			return length <= span.Length && SpanHelpers.SequenceEqual<T>(MemoryMarshal.GetReference<T>(span), MemoryMarshal.GetReference<T>(value), length);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00049B98 File Offset: 0x00047D98
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool StartsWith<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = value.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return length <= span.Length && SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), (UIntPtr)length * (UIntPtr)((IntPtr)sizeof(T)));
			}
			return length <= span.Length && SpanHelpers.SequenceEqual<T>(MemoryMarshal.GetReference<T>(span), MemoryMarshal.GetReference<T>(value), length);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00049C04 File Offset: 0x00047E04
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EndsWith<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = span.Length;
			int length2 = value.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return length2 <= length && SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(Unsafe.Add<T>(MemoryMarshal.GetReference<T>(span), (IntPtr)((UIntPtr)(length - length2)))), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), (UIntPtr)length2 * (UIntPtr)((IntPtr)sizeof(T)));
			}
			return length2 <= length && SpanHelpers.SequenceEqual<T>(Unsafe.Add<T>(MemoryMarshal.GetReference<T>(span), (IntPtr)((UIntPtr)(length - length2))), MemoryMarshal.GetReference<T>(value), length2);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00049C80 File Offset: 0x00047E80
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EndsWith<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = span.Length;
			int length2 = value.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				return length2 <= length && SpanHelpers.SequenceEqual(Unsafe.As<T, byte>(Unsafe.Add<T>(MemoryMarshal.GetReference<T>(span), (IntPtr)((UIntPtr)(length - length2)))), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(value)), (UIntPtr)length2 * (UIntPtr)((IntPtr)sizeof(T)));
			}
			return length2 <= length && SpanHelpers.SequenceEqual<T>(Unsafe.Add<T>(MemoryMarshal.GetReference<T>(span), (IntPtr)((UIntPtr)(length - length2))), MemoryMarshal.GetReference<T>(value), length2);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00049CFC File Offset: 0x00047EFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static bool StartsWith<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (span.Length == 0)
			{
				return false;
			}
			T t = *span[0];
			if (t == null)
			{
				return value == null;
			}
			return t.Equals(value);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00049D48 File Offset: 0x00047F48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static bool EndsWith<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (span.Length == 0)
			{
				return false;
			}
			T t = *span[span.Length - 1];
			if (t == null)
			{
				return value == null;
			}
			return t.Equals(value);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00049D9B File Offset: 0x00047F9B
		[NullableContext(2)]
		public static void Reverse<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span)
		{
			if (span.Length > 1)
			{
				SpanHelpers.Reverse<T>(MemoryMarshal.GetReference<T>(span), (UIntPtr)((IntPtr)span.Length));
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00049DBA File Offset: 0x00047FBA
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array)
		{
			return new Span<T>(array);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00049DC2 File Offset: 0x00047FC2
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, int start, int length)
		{
			return new Span<T>(array, start, length);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00049DCC File Offset: 0x00047FCC
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment)
		{
			return new Span<T>(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00049DE8 File Offset: 0x00047FE8
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment, int start)
		{
			if (start > segment.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new Span<T>(segment.Array, segment.Offset + start, segment.Count - start);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00049E1C File Offset: 0x0004801C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment, Index startIndex)
		{
			int offset = startIndex.GetOffset(segment.Count);
			return segment.AsSpan(offset);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00049E3F File Offset: 0x0004803F
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment, int start, int length)
		{
			if (start > segment.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			if (length > segment.Count - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			return new Span<T>(segment.Array, segment.Offset + start, length);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00049E7C File Offset: 0x0004807C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> AsSpan<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment, Range range)
		{
			ValueTuple<int, int> offsetAndLength = range.GetOffsetAndLength(segment.Count);
			int item = offsetAndLength.Item1;
			int item2 = offsetAndLength.Item2;
			return new Span<T>(segment.Array, segment.Offset + item, item2);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00049EBA File Offset: 0x000480BA
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array)
		{
			return new Memory<T>(array);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00049EC2 File Offset: 0x000480C2
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, int start)
		{
			return new Memory<T>(array, start);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00049ECC File Offset: 0x000480CC
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, Index startIndex)
		{
			if (array == null)
			{
				if (!startIndex.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				return default(Memory<T>);
			}
			int offset = startIndex.GetOffset(array.Length);
			return new Memory<T>(array, offset);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00049F0C File Offset: 0x0004810C
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, int start, int length)
		{
			return new Memory<T>(array, start, length);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00049F18 File Offset: 0x00048118
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] array, Range range)
		{
			if (array == null)
			{
				Index start = range.Start;
				Index end = range.End;
				if (!start.Equals(Index.Start) || !end.Equals(Index.Start))
				{
					ThrowHelper.ThrowArgumentNullException(ExceptionArgument.array);
				}
				return default(Memory<T>);
			}
			ValueTuple<int, int> offsetAndLength = range.GetOffsetAndLength(array.Length);
			int item = offsetAndLength.Item1;
			int item2 = offsetAndLength.Item2;
			return new Memory<T>(array, item, item2);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00049F84 File Offset: 0x00048184
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment)
		{
			return new Memory<T>(segment.Array, segment.Offset, segment.Count);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00049FA0 File Offset: 0x000481A0
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment, int start)
		{
			if (start > segment.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			return new Memory<T>(segment.Array, segment.Offset + start, segment.Count - start);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00049FD1 File Offset: 0x000481D1
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> AsMemory<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ArraySegment<T> segment, int start, int length)
		{
			if (start > segment.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.start);
			}
			if (length > segment.Count - start)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.length);
			}
			return new Memory<T>(segment.Array, segment.Offset + start, length);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0004A010 File Offset: 0x00048210
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] source, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			new ReadOnlySpan<T>(source).CopyTo(destination);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0004A02C File Offset: 0x0004822C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<T>([Nullable(new byte[]
		{
			2,
			1
		})] this T[] source, [Nullable(new byte[]
		{
			0,
			1
		})] Memory<T> destination)
		{
			source.CopyTo(destination.Span);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0004A03B File Offset: 0x0004823B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Overlaps<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other)
		{
			return span.Overlaps(other);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0004A049 File Offset: 0x00048249
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool Overlaps<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other, out int elementOffset)
		{
			return span.Overlaps(other, out elementOffset);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0004A058 File Offset: 0x00048258
		[NullableContext(2)]
		public static bool Overlaps<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other)
		{
			if (span.IsEmpty || other.IsEmpty)
			{
				return false;
			}
			IntPtr intPtr = Unsafe.ByteOffset<T>(MemoryMarshal.GetReference<T>(span), MemoryMarshal.GetReference<T>(other));
			return intPtr < (IntPtr)span.Length * (IntPtr)sizeof(T) || intPtr > -((IntPtr)other.Length * (IntPtr)sizeof(T));
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0004A0B4 File Offset: 0x000482B4
		[NullableContext(2)]
		public static bool Overlaps<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other, out int elementOffset)
		{
			if (span.IsEmpty || other.IsEmpty)
			{
				elementOffset = 0;
				return false;
			}
			IntPtr intPtr = Unsafe.ByteOffset<T>(MemoryMarshal.GetReference<T>(span), MemoryMarshal.GetReference<T>(other));
			if (intPtr < (IntPtr)span.Length * (IntPtr)sizeof(T) || intPtr > -((IntPtr)other.Length * (IntPtr)sizeof(T)))
			{
				if (intPtr % (IntPtr)sizeof(T) != 0)
				{
					ThrowHelper.ThrowArgumentException_OverlapAlignmentMismatch();
				}
				elementOffset = (int)(intPtr / (IntPtr)sizeof(T));
				return true;
			}
			elementOffset = 0;
			return false;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x0004A133 File Offset: 0x00048333
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, IComparable<T> comparable)
		{
			return span.BinarySearch(comparable);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0004A13C File Offset: 0x0004833C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<[Nullable(2)] T, [Nullable(0)] TComparable>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, TComparable comparable) where TComparable : IComparable<T>
		{
			return span.BinarySearch(comparable);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0004A14A File Offset: 0x0004834A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<[Nullable(2)] T, [Nullable(0)] TComparer>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T value, TComparer comparer) where TComparer : IComparer<T>
		{
			return span.BinarySearch(value, comparer);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0004A159 File Offset: 0x00048359
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, IComparable<T> comparable)
		{
			return span.BinarySearch(comparable);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0004A162 File Offset: 0x00048362
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<[Nullable(2)] T, [Nullable(0)] TComparable>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, TComparable comparable) where TComparable : IComparable<T>
		{
			return span.BinarySearch(comparable);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0004A16C File Offset: 0x0004836C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<[Nullable(2)] T, [Nullable(0)] TComparer>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, T value, TComparer comparer) where TComparer : IComparer<T>
		{
			if (comparer == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparer);
			}
			SpanHelpers.ComparerComparable<T, TComparer> comparable = new SpanHelpers.ComparerComparable<T, TComparer>(value, comparer);
			return span.BinarySearch(comparable);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0004A198 File Offset: 0x00048398
		[NullableContext(2)]
		public static void Sort<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span)
		{
			span.Sort(null);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0004A1A1 File Offset: 0x000483A1
		public static void Sort<[Nullable(2)] T, TComparer>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] TComparer comparer) where TComparer : IComparer<T>
		{
			if (span.Length > 1)
			{
				ArraySortHelper<T>.Default.Sort(span, comparer);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0004A1BE File Offset: 0x000483BE
		[NullableContext(1)]
		public static void Sort<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, Comparison<T> comparison)
		{
			if (comparison == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparison);
			}
			if (span.Length > 1)
			{
				ArraySortHelper<T>.Sort(span, comparison);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0004A1DB File Offset: 0x000483DB
		[NullableContext(2)]
		public static void Sort<TKey, TValue>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<TKey> keys, [Nullable(new byte[]
		{
			0,
			1
		})] Span<TValue> items)
		{
			keys.Sort(items, null);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0004A1E5 File Offset: 0x000483E5
		[NullableContext(2)]
		public static void Sort<TKey, TValue, [Nullable(0)] TComparer>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<TKey> keys, [Nullable(new byte[]
		{
			0,
			1
		})] Span<TValue> items, [Nullable(1)] TComparer comparer) where TComparer : IComparer<TKey>
		{
			if (keys.Length != items.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_SpansMustHaveSameLength);
			}
			if (keys.Length > 1)
			{
				ArraySortHelper<TKey, TValue>.Default.Sort(keys, items, comparer);
			}
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0004A21A File Offset: 0x0004841A
		[NullableContext(2)]
		public static void Sort<TKey, TValue>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<TKey> keys, [Nullable(new byte[]
		{
			0,
			1
		})] Span<TValue> items, [Nullable(1)] Comparison<TKey> comparison)
		{
			if (comparison == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparison);
			}
			if (keys.Length != items.Length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Argument_SpansMustHaveSameLength);
			}
			if (keys.Length > 1)
			{
				ArraySortHelper<TKey, TValue>.Default.Sort(keys, items, new ComparisonComparer<TKey>(comparison));
			}
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0004A25C File Offset: 0x0004845C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Replace<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, T oldValue, T newValue) where T : IEquatable<T>
		{
			UIntPtr length = (UIntPtr)span.Length;
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					ref byte ptr = ref Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span));
					SpanHelpers.ReplaceValueType<byte>(ref ptr, ref ptr, Unsafe.BitCast<T, byte>(oldValue), Unsafe.BitCast<T, byte>(newValue), length);
					return;
				}
				if (sizeof(T) == 2)
				{
					ref ushort ptr2 = ref Unsafe.As<T, ushort>(MemoryMarshal.GetReference<T>(span));
					SpanHelpers.ReplaceValueType<ushort>(ref ptr2, ref ptr2, Unsafe.BitCast<T, ushort>(oldValue), Unsafe.BitCast<T, ushort>(newValue), length);
					return;
				}
				if (sizeof(T) == 4)
				{
					ref int ptr3 = ref Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span));
					SpanHelpers.ReplaceValueType<int>(ref ptr3, ref ptr3, Unsafe.BitCast<T, int>(oldValue), Unsafe.BitCast<T, int>(newValue), length);
					return;
				}
				if (sizeof(T) == 8)
				{
					ref long ptr4 = ref Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span));
					SpanHelpers.ReplaceValueType<long>(ref ptr4, ref ptr4, Unsafe.BitCast<T, long>(oldValue), Unsafe.BitCast<T, long>(newValue), length);
					return;
				}
			}
			ref T reference = ref MemoryMarshal.GetReference<T>(span);
			SpanHelpers.Replace<T>(ref reference, ref reference, oldValue, newValue, length);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0004A32C File Offset: 0x0004852C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Replace<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination, T oldValue, T newValue) where T : IEquatable<T>
		{
			UIntPtr uintPtr = (UIntPtr)source.Length;
			if (uintPtr == 0)
			{
				return;
			}
			if (uintPtr > (UIntPtr)destination.Length)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			ref T reference = ref MemoryMarshal.GetReference<T>(source);
			ref T reference2 = ref MemoryMarshal.GetReference<T>(destination);
			IntPtr intPtr = Unsafe.ByteOffset<T>(ref reference, ref reference2);
			if (intPtr != 0 && (intPtr < (IntPtr)source.Length * (IntPtr)sizeof(T) || intPtr > -((IntPtr)destination.Length * (IntPtr)sizeof(T))))
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					SpanHelpers.ReplaceValueType<byte>(Unsafe.As<T, byte>(ref reference), Unsafe.As<T, byte>(ref reference2), Unsafe.BitCast<T, byte>(oldValue), Unsafe.BitCast<T, byte>(newValue), uintPtr);
					return;
				}
				if (sizeof(T) == 2)
				{
					SpanHelpers.ReplaceValueType<ushort>(Unsafe.As<T, ushort>(ref reference), Unsafe.As<T, ushort>(ref reference2), Unsafe.BitCast<T, ushort>(oldValue), Unsafe.BitCast<T, ushort>(newValue), uintPtr);
					return;
				}
				if (sizeof(T) == 4)
				{
					SpanHelpers.ReplaceValueType<int>(Unsafe.As<T, int>(ref reference), Unsafe.As<T, int>(ref reference2), Unsafe.BitCast<T, int>(oldValue), Unsafe.BitCast<T, int>(newValue), uintPtr);
					return;
				}
				if (sizeof(T) == 8)
				{
					SpanHelpers.ReplaceValueType<long>(Unsafe.As<T, long>(ref reference), Unsafe.As<T, long>(ref reference2), Unsafe.BitCast<T, long>(oldValue), Unsafe.BitCast<T, long>(newValue), uintPtr);
					return;
				}
			}
			SpanHelpers.Replace<T>(ref reference, ref reference2, oldValue, newValue, uintPtr);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0004A451 File Offset: 0x00048651
		[NullableContext(2)]
		public static int CommonPrefixLength<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other)
		{
			return span.CommonPrefixLength(other);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x0004A45F File Offset: 0x0004865F
		[NullableContext(2)]
		public static int CommonPrefixLength<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer)
		{
			return span.CommonPrefixLength(other, comparer);
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0004A470 File Offset: 0x00048670
		[NullableContext(2)]
		public unsafe static int CommonPrefixLength<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other)
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				UIntPtr uintPtr = Math.Min((UIntPtr)span.Length, (UIntPtr)other.Length);
				UIntPtr uintPtr2 = (UIntPtr)sizeof(T);
				return (int)(SpanHelpers.CommonPrefixLength(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(other)), uintPtr * uintPtr2) / uintPtr2);
			}
			MemoryExtensions.SliceLongerSpanToMatchShorterLength<T>(ref span, ref other);
			for (int i = 0; i < span.Length; i++)
			{
				if (!EqualityComparer<T>.Default.Equals(*span[i], *other[i]))
				{
					return i;
				}
			}
			return span.Length;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0004A510 File Offset: 0x00048710
		[NullableContext(2)]
		public unsafe static int CommonPrefixLength<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> other, [Nullable(new byte[]
		{
			2,
			1
		})] IEqualityComparer<T> comparer)
		{
			if (typeof(T).IsValueType && (comparer == null || comparer == EqualityComparer<T>.Default))
			{
				return span.CommonPrefixLength(other);
			}
			MemoryExtensions.SliceLongerSpanToMatchShorterLength<T>(ref span, ref other);
			if (comparer == null)
			{
				comparer = EqualityComparer<T>.Default;
			}
			for (int i = 0; i < span.Length; i++)
			{
				if (!comparer.Equals(*span[i], *other[i]))
				{
					return i;
				}
			}
			return span.Length;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x0004A594 File Offset: 0x00048794
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void SliceLongerSpanToMatchShorterLength<T>(ref ReadOnlySpan<T> span, ref ReadOnlySpan<T> other)
		{
			if (other.Length > span.Length)
			{
				other = other.Slice(0, span.Length);
				return;
			}
			if (span.Length > other.Length)
			{
				span = span.Slice(0, other.Length);
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0004A5E4 File Offset: 0x000487E4
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static MemoryExtensions.SpanSplitEnumerator<T> Split<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> source, T separator) where T : IEquatable<T>
		{
			return new MemoryExtensions.SpanSplitEnumerator<T>(source, separator);
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0004A5ED File Offset: 0x000487ED
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static MemoryExtensions.SpanSplitEnumerator<T> Split<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> separator) where T : IEquatable<T>
		{
			return new MemoryExtensions.SpanSplitEnumerator<T>(source, separator, true);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0004A5F7 File Offset: 0x000487F7
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static MemoryExtensions.SpanSplitEnumerator<T> SplitAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> source, [ParamCollection] [Nullable(new byte[]
		{
			0,
			1
		})] [UnscopedRef] ReadOnlySpan<T> separators) where T : IEquatable<T>
		{
			return new MemoryExtensions.SpanSplitEnumerator<T>(source, separators);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0004A600 File Offset: 0x00048800
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static MemoryExtensions.SpanSplitEnumerator<T> SplitAny<[Nullable(0)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> source, SearchValues<T> separators) where T : IEquatable<T>
		{
			return new MemoryExtensions.SpanSplitEnumerator<T>(source, separators);
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x0004A60C File Offset: 0x0004880C
		public static int Split(this ReadOnlySpan<char> source, Span<Range> destination, char separator, StringSplitOptions options = StringSplitOptions.None)
		{
			string.CheckStringSplitOptions(options);
			return MemoryExtensions.SplitCore(source, destination, new ReadOnlySpan<char>(ref separator), default(ReadOnlySpan<string>), true, options);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0004A638 File Offset: 0x00048838
		public unsafe static int Split(this ReadOnlySpan<char> source, Span<Range> destination, ReadOnlySpan<char> separator, StringSplitOptions options = StringSplitOptions.None)
		{
			string.CheckStringSplitOptions(options);
			if (separator.IsEmpty)
			{
				if (!destination.IsEmpty)
				{
					int num = 0;
					int num2 = source.Length;
					if ((options & StringSplitOptions.TrimEntries) != StringSplitOptions.None)
					{
						ValueTuple<int, int> valueTuple = MemoryExtensions.TrimSplitEntry(source, num, num2);
						num = valueTuple.Item1;
						num2 = valueTuple.Item2;
					}
					if (num != num2 || (options & StringSplitOptions.RemoveEmptyEntries) == StringSplitOptions.None)
					{
						*destination[0] = new Range(num, num2);
						return 1;
					}
				}
				return 0;
			}
			return MemoryExtensions.SplitCore(source, destination, separator, default(ReadOnlySpan<string>), false, options);
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x0004A6C0 File Offset: 0x000488C0
		public static int SplitAny(this ReadOnlySpan<char> source, Span<Range> destination, ReadOnlySpan<char> separators, StringSplitOptions options = StringSplitOptions.None)
		{
			string.CheckStringSplitOptions(options);
			if (separators.IsEmpty && destination.Length > source.Length)
			{
				options &= ~StringSplitOptions.TrimEntries;
			}
			return MemoryExtensions.SplitCore(source, destination, separators, default(ReadOnlySpan<string>), true, options);
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0004A708 File Offset: 0x00048908
		public static int SplitAny(this ReadOnlySpan<char> source, Span<Range> destination, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<string> separators, StringSplitOptions options = StringSplitOptions.None)
		{
			string.CheckStringSplitOptions(options);
			if (separators.IsEmpty && destination.Length > source.Length)
			{
				options &= ~StringSplitOptions.TrimEntries;
			}
			return MemoryExtensions.SplitCore(source, destination, default(ReadOnlySpan<char>), separators, true, options);
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0004A750 File Offset: 0x00048950
		private unsafe static int SplitCore(ReadOnlySpan<char> source, Span<Range> destination, ReadOnlySpan<char> separatorOrSeparators, ReadOnlySpan<string> stringSeparators, bool isAny, StringSplitOptions options)
		{
			if (destination.IsEmpty)
			{
				return 0;
			}
			bool flag = (options & StringSplitOptions.RemoveEmptyEntries) == StringSplitOptions.None;
			bool flag2 = (options & StringSplitOptions.TrimEntries) > StringSplitOptions.None;
			if (source.Length == 0)
			{
				if (flag)
				{
					*destination[0] = default(Range);
					return 1;
				}
				return 0;
			}
			else
			{
				int num = 0;
				int num5;
				if (destination.Length != 1)
				{
					Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
					ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
					ValueListBuilder<int> valueListBuilder2 = default(ValueListBuilder<int>);
					int num2 = 0;
					int num3;
					if (!stringSeparators.IsEmpty)
					{
						initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
						valueListBuilder2 = new ValueListBuilder<int>(initialSpan);
						string.MakeSeparatorListAny(source, stringSeparators, ref valueListBuilder, ref valueListBuilder2);
						num3 = -1;
					}
					else if (isAny)
					{
						string.MakeSeparatorListAny(source, separatorOrSeparators, ref valueListBuilder);
						num3 = 1;
					}
					else
					{
						string.MakeSeparatorList(source, separatorOrSeparators, ref valueListBuilder);
						num3 = separatorOrSeparators.Length;
					}
					int num4 = 0;
					Span<Range> span = destination.Slice(0, destination.Length - 1);
					while (num4 < valueListBuilder.Length && (num2 < span.Length || !flag))
					{
						num5 = *valueListBuilder[num4];
						if (num4 < valueListBuilder2.Length)
						{
							num3 = *valueListBuilder2[num4];
						}
						num4++;
						int num6 = num5;
						if (flag2)
						{
							ValueTuple<int, int> valueTuple = MemoryExtensions.TrimSplitEntry(source, num, num5);
							num = valueTuple.Item1;
							num5 = valueTuple.Item2;
						}
						if (num != num5 || flag)
						{
							if (num2 >= span.Length)
							{
								break;
							}
							*span[num2] = new Range(num, num5);
							num2++;
						}
						num = num6 + num3;
					}
					valueListBuilder.Dispose();
					valueListBuilder2.Dispose();
					if (num2 < destination.Length)
					{
						num5 = source.Length;
						if (flag2)
						{
							ValueTuple<int, int> valueTuple2 = MemoryExtensions.TrimSplitEntry(source, num, num5);
							num = valueTuple2.Item1;
							num5 = valueTuple2.Item2;
						}
						if (num != num5 || flag)
						{
							*destination[num2] = new Range(num, num5);
							num2++;
						}
					}
					return num2;
				}
				num5 = source.Length;
				if (flag2)
				{
					ValueTuple<int, int> valueTuple3 = MemoryExtensions.TrimSplitEntry(source, num, num5);
					num = valueTuple3.Item1;
					num5 = valueTuple3.Item2;
				}
				if (num != num5 || flag)
				{
					*destination[0] = new Range(num, num5);
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0004A99C File Offset: 0x00048B9C
		[return: TupleElementNames(new string[]
		{
			"StartInclusive",
			"EndExclusive"
		})]
		private unsafe static ValueTuple<int, int> TrimSplitEntry(ReadOnlySpan<char> source, int startInclusive, int endExclusive)
		{
			while (startInclusive < endExclusive)
			{
				if (!char.IsWhiteSpace((char)(*source[startInclusive])))
				{
					break;
				}
				startInclusive++;
			}
			while (endExclusive > startInclusive && char.IsWhiteSpace((char)(*source[endExclusive - 1])))
			{
				endExclusive--;
			}
			return new ValueTuple<int, int>(startInclusive, endExclusive);
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		public static int Count<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			return span.Count(value);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x0004A9F8 File Offset: 0x00048BF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Count<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T value) where T : IEquatable<T>
		{
			if (RuntimeHelpers.IsBitwiseEquatable<T>())
			{
				if (sizeof(T) == 1)
				{
					return SpanHelpers.CountValueType<byte>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, byte>(value), span.Length);
				}
				if (sizeof(T) == 2)
				{
					return SpanHelpers.CountValueType<short>(Unsafe.As<T, short>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, short>(value), span.Length);
				}
				if (sizeof(T) == 4)
				{
					return SpanHelpers.CountValueType<int>(Unsafe.As<T, int>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, int>(value), span.Length);
				}
				if (sizeof(T) == 8)
				{
					return SpanHelpers.CountValueType<long>(Unsafe.As<T, long>(MemoryMarshal.GetReference<T>(span)), Unsafe.BitCast<T, long>(value), span.Length);
				}
			}
			return SpanHelpers.Count<T>(MemoryMarshal.GetReference<T>(span), value, span.Length);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0004AABE File Offset: 0x00048CBE
		public static int Count<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			return span.Count(value);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0004AACC File Offset: 0x00048CCC
		public unsafe static int Count<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> value) where T : IEquatable<T>
		{
			int length = value.Length;
			if (length == 0)
			{
				return 0;
			}
			if (length != 1)
			{
				int num = 0;
				int num2;
				while ((num2 = span.IndexOf(value)) >= 0)
				{
					span = span.Slice(num2 + value.Length);
					num++;
				}
				return num;
			}
			return span.Count(*value[0]);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0004AB27 File Offset: 0x00048D27
		public static bool TryWrite(this Span<char> destination, [InterpolatedStringHandlerArgument("destination")] ref MemoryExtensions.TryWriteInterpolatedStringHandler handler, out int charsWritten)
		{
			if (handler._success)
			{
				charsWritten = handler._pos;
				return true;
			}
			charsWritten = 0;
			return false;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0004AB3F File Offset: 0x00048D3F
		public static bool TryWrite(this Span<char> destination, [Nullable(2)] IFormatProvider provider, [InterpolatedStringHandlerArgument(new string[]
		{
			"destination",
			"provider"
		})] ref MemoryExtensions.TryWriteInterpolatedStringHandler handler, out int charsWritten)
		{
			return destination.TryWrite(ref handler, out charsWritten);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0004AB4C File Offset: 0x00048D4C
		[NullableContext(1)]
		public static bool TryWrite<[Nullable(2)] TArg0>([Nullable(0)] this Span<char> destination, [Nullable(2)] IFormatProvider provider, CompositeFormat format, out int charsWritten, TArg0 arg0)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(1);
			return MemoryExtensions.TryWrite<TArg0, int, int>(destination, provider, format, out charsWritten, arg0, 0, 0, default(ReadOnlySpan<object>));
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0004AB84 File Offset: 0x00048D84
		[NullableContext(1)]
		public static bool TryWrite<[Nullable(2)] TArg0, [Nullable(2)] TArg1>([Nullable(0)] this Span<char> destination, [Nullable(2)] IFormatProvider provider, CompositeFormat format, out int charsWritten, TArg0 arg0, TArg1 arg1)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(2);
			return MemoryExtensions.TryWrite<TArg0, TArg1, int>(destination, provider, format, out charsWritten, arg0, arg1, 0, default(ReadOnlySpan<object>));
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0004ABBC File Offset: 0x00048DBC
		[NullableContext(1)]
		public static bool TryWrite<[Nullable(2)] TArg0, [Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(0)] this Span<char> destination, [Nullable(2)] IFormatProvider provider, CompositeFormat format, out int charsWritten, TArg0 arg0, TArg1 arg1, TArg2 arg2)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(3);
			return MemoryExtensions.TryWrite<TArg0, TArg1, TArg2>(destination, provider, format, out charsWritten, arg0, arg1, arg2, default(ReadOnlySpan<object>));
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0004ABF3 File Offset: 0x00048DF3
		public static bool TryWrite(this Span<char> destination, [Nullable(2)] IFormatProvider provider, [Nullable(1)] CompositeFormat format, out int charsWritten, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			ArgumentNullException.ThrowIfNull(args, "args");
			return destination.TryWrite(provider, format, out charsWritten, args);
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0004AC1C File Offset: 0x00048E1C
		public unsafe static bool TryWrite(this Span<char> destination, [Nullable(2)] IFormatProvider provider, [Nullable(1)] CompositeFormat format, out int charsWritten, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(args.Length);
			bool result;
			switch (args.Length)
			{
			case 0:
				result = MemoryExtensions.TryWrite<int, int, int>(destination, provider, format, out charsWritten, 0, 0, 0, args);
				break;
			case 1:
				result = MemoryExtensions.TryWrite<object, int, int>(destination, provider, format, out charsWritten, *args[0], 0, 0, args);
				break;
			case 2:
				result = MemoryExtensions.TryWrite<object, object, int>(destination, provider, format, out charsWritten, *args[0], *args[1], 0, args);
				break;
			default:
				result = MemoryExtensions.TryWrite<object, object, object>(destination, provider, format, out charsWritten, *args[0], *args[1], *args[2], args);
				break;
			}
			return result;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0004ACD0 File Offset: 0x00048ED0
		private unsafe static bool TryWrite<TArg0, TArg1, TArg2>(Span<char> destination, IFormatProvider provider, CompositeFormat format, out int charsWritten, TArg0 arg0, TArg1 arg1, TArg2 arg2, ReadOnlySpan<object> args)
		{
			bool flag;
			MemoryExtensions.TryWriteInterpolatedStringHandler tryWriteInterpolatedStringHandler = new MemoryExtensions.TryWriteInterpolatedStringHandler(format._literalLength, format._formattedCount, destination, provider, ref flag);
			if (flag)
			{
				foreach (ValueTuple<string, int, int, string> valueTuple in format._segments)
				{
					string item = valueTuple.Item1;
					bool flag2;
					if (item != null)
					{
						flag2 = tryWriteInterpolatedStringHandler.AppendLiteral(item);
					}
					else
					{
						int item2 = valueTuple.Item2;
						switch (item2)
						{
						case 0:
							flag2 = tryWriteInterpolatedStringHandler.AppendFormatted<TArg0>(arg0, valueTuple.Item3, valueTuple.Item4);
							break;
						case 1:
							flag2 = tryWriteInterpolatedStringHandler.AppendFormatted<TArg1>(arg1, valueTuple.Item3, valueTuple.Item4);
							break;
						case 2:
							flag2 = tryWriteInterpolatedStringHandler.AppendFormatted<TArg2>(arg2, valueTuple.Item3, valueTuple.Item4);
							break;
						default:
							flag2 = tryWriteInterpolatedStringHandler.AppendFormatted(*args[item2], valueTuple.Item3, valueTuple.Item4);
							break;
						}
					}
					if (!flag2)
					{
						break;
					}
				}
			}
			return destination.TryWrite(provider, ref tryWriteInterpolatedStringHandler, out charsWritten);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0004ADD8 File Offset: 0x00048FD8
		public unsafe static bool IsWhiteSpace(this ReadOnlySpan<char> span)
		{
			for (int i = 0; i < span.Length; i++)
			{
				if (!char.IsWhiteSpace((char)(*span[i])))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0004AE0A File Offset: 0x0004900A
		public static bool Contains(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			return span.IndexOf(value, comparisonType) >= 0;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0004AE1C File Offset: 0x0004901C
		[Intrinsic]
		public static bool Equals(this ReadOnlySpan<char> span, ReadOnlySpan<char> other, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(span, other, string.GetCaseCompareOfComparisonCulture(comparisonType)) == 0;
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(span, other, string.GetCaseCompareOfComparisonCulture(comparisonType)) == 0;
			case StringComparison.Ordinal:
				return span.EqualsOrdinal(other);
			default:
				return span.EqualsOrdinalIgnoreCase(other);
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0004AE8B File Offset: 0x0004908B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EqualsOrdinal(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			return span.Length == value.Length && (value.Length == 0 || span.SequenceEqual(value));
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0004AEB1 File Offset: 0x000490B1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EqualsOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			return span.Length == value.Length && (value.Length == 0 || Ordinal.EqualsIgnoreCase(MemoryMarshal.GetReference<char>(span), MemoryMarshal.GetReference<char>(value), span.Length));
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0004AEE8 File Offset: 0x000490E8
		public static int CompareTo(this ReadOnlySpan<char> span, ReadOnlySpan<char> other, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.Compare(span, other, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.Compare(span, other, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				if (span.Length == 0 || other.Length == 0)
				{
					return span.Length - other.Length;
				}
				return string.CompareOrdinal(span, other);
			default:
				return Ordinal.CompareStringIgnoreCase(MemoryMarshal.GetReference<char>(span), span.Length, MemoryMarshal.GetReference<char>(other), other.Length);
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0004AF8C File Offset: 0x0004918C
		public static int IndexOf(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			if (comparisonType == StringComparison.Ordinal)
			{
				return SpanHelpers.IndexOf(MemoryMarshal.GetReference<char>(span), span.Length, MemoryMarshal.GetReference<char>(value), value.Length);
			}
			if (comparisonType <= StringComparison.CurrentCultureIgnoreCase)
			{
				return CultureInfo.CurrentCulture.CompareInfo.IndexOf(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			}
			if (comparisonType - StringComparison.InvariantCulture > 1)
			{
				return Ordinal.IndexOfOrdinalIgnoreCase(span, value);
			}
			return CompareInfo.Invariant.IndexOf(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0004B004 File Offset: 0x00049204
		public static int LastIndexOf(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			if (comparisonType == StringComparison.Ordinal)
			{
				return SpanHelpers.LastIndexOf(MemoryMarshal.GetReference<char>(span), span.Length, MemoryMarshal.GetReference<char>(value), value.Length);
			}
			if (comparisonType <= StringComparison.CurrentCultureIgnoreCase)
			{
				return CultureInfo.CurrentCulture.CompareInfo.LastIndexOf(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			}
			if (comparisonType - StringComparison.InvariantCulture > 1)
			{
				return Ordinal.LastIndexOfOrdinalIgnoreCase(span, value);
			}
			return CompareInfo.Invariant.LastIndexOf(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0004B07C File Offset: 0x0004927C
		public static int ToLower(this ReadOnlySpan<char> source, Span<char> destination, [Nullable(2)] CultureInfo culture)
		{
			if (source.Overlaps(destination))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			if (destination.Length < source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				InvariantModeCasing.ToLower(source, destination);
			}
			else
			{
				culture.TextInfo.ChangeCaseToLower(source, destination);
			}
			return source.Length;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x0004B0E0 File Offset: 0x000492E0
		public static int ToLowerInvariant(this ReadOnlySpan<char> source, Span<char> destination)
		{
			if (source.Overlaps(destination))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			if (destination.Length < source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				InvariantModeCasing.ToLower(source, destination);
			}
			else
			{
				TextInfo.Invariant.ChangeCaseToLower(source, destination);
			}
			return source.Length;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0004B138 File Offset: 0x00049338
		public static int ToUpper(this ReadOnlySpan<char> source, Span<char> destination, [Nullable(2)] CultureInfo culture)
		{
			if (source.Overlaps(destination))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			if (destination.Length < source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				InvariantModeCasing.ToUpper(source, destination);
			}
			else
			{
				culture.TextInfo.ChangeCaseToUpper(source, destination);
			}
			return source.Length;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0004B19C File Offset: 0x0004939C
		public static int ToUpperInvariant(this ReadOnlySpan<char> source, Span<char> destination)
		{
			if (source.Overlaps(destination))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			if (destination.Length < source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				InvariantModeCasing.ToUpper(source, destination);
			}
			else
			{
				TextInfo.Invariant.ChangeCaseToUpper(source, destination);
			}
			return source.Length;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0004B1F4 File Offset: 0x000493F4
		[Intrinsic]
		public static bool EndsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsSuffix(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsSuffix(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				return span.EndsWith(value);
			default:
				return span.EndsWithOrdinalIgnoreCase(value);
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0004B25D File Offset: 0x0004945D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EndsWithOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			return value.Length <= span.Length && Ordinal.EqualsIgnoreCase(Unsafe.Add<char>(MemoryMarshal.GetReference<char>(span), span.Length - value.Length), MemoryMarshal.GetReference<char>(value), value.Length);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0004B2A0 File Offset: 0x000494A0
		[Intrinsic]
		public static bool StartsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefix(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsPrefix(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				return span.StartsWith(value);
			default:
				return span.StartsWithOrdinalIgnoreCase(value);
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0004B309 File Offset: 0x00049509
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool StartsWithOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
		{
			return value.Length <= span.Length && Ordinal.EqualsIgnoreCase(MemoryMarshal.GetReference<char>(span), MemoryMarshal.GetReference<char>(value), value.Length);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0004B335 File Offset: 0x00049535
		public static SpanRuneEnumerator EnumerateRunes(this ReadOnlySpan<char> span)
		{
			return new SpanRuneEnumerator(span);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0004B33D File Offset: 0x0004953D
		public static SpanRuneEnumerator EnumerateRunes(this Span<char> span)
		{
			return new SpanRuneEnumerator(span);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0004B34A File Offset: 0x0004954A
		public static SpanLineEnumerator EnumerateLines(this ReadOnlySpan<char> span)
		{
			return new SpanLineEnumerator(span);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0004B352 File Offset: 0x00049552
		public static SpanLineEnumerator EnumerateLines(this Span<char> span)
		{
			return new SpanLineEnumerator(span);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0004B35F File Offset: 0x0004955F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EqualsOrdinalIgnoreCaseUtf8(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> value)
		{
			return (span.Length | value.Length) == 0 || Ordinal.EqualsIgnoreCaseUtf8(MemoryMarshal.GetReference<byte>(span), span.Length, MemoryMarshal.GetReference<byte>(value), value.Length);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0004B394 File Offset: 0x00049594
		internal static bool StartsWithUtf8(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> value, StringComparison comparisonType)
		{
			string.CheckStringComparison(comparisonType);
			switch (comparisonType)
			{
			case StringComparison.CurrentCulture:
			case StringComparison.CurrentCultureIgnoreCase:
				return CultureInfo.CurrentCulture.CompareInfo.IsPrefixUtf8(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.InvariantCulture:
			case StringComparison.InvariantCultureIgnoreCase:
				return CompareInfo.Invariant.IsPrefixUtf8(span, value, string.GetCaseCompareOfComparisonCulture(comparisonType));
			case StringComparison.Ordinal:
				return span.StartsWith(value);
			default:
				return span.StartsWithOrdinalIgnoreCaseUtf8(value);
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0004B3FD File Offset: 0x000495FD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool StartsWithOrdinalIgnoreCaseUtf8(this ReadOnlySpan<byte> span, ReadOnlySpan<byte> value)
		{
			return (span.Length | value.Length) == 0 || Ordinal.StartsWithIgnoreCaseUtf8(MemoryMarshal.GetReference<byte>(span), span.Length, MemoryMarshal.GetReference<byte>(value), value.Length);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0004B434 File Offset: 0x00049634
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Memory<T> memory, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			ReadOnlySpan<T> span = memory.Span;
			int start = MemoryExtensions.ClampStart<T>(span, trimElement);
			int length = MemoryExtensions.ClampEnd<T>(span, start, trimElement);
			return memory.Slice(start, length);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0004B466 File Offset: 0x00049666
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Memory<T> memory, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return memory.Slice(MemoryExtensions.ClampStart<T>(memory.Span, trimElement));
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0004B481 File Offset: 0x00049681
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Memory<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Memory<T> memory, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return memory.Slice(0, MemoryExtensions.ClampEnd<T>(memory.Span, 0, trimElement));
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0004B4A0 File Offset: 0x000496A0
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlyMemory<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlyMemory<T> memory, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			ReadOnlySpan<T> span = memory.Span;
			int start = MemoryExtensions.ClampStart<T>(span, trimElement);
			int length = MemoryExtensions.ClampEnd<T>(span, start, trimElement);
			return memory.Slice(start, length);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0004B4CD File Offset: 0x000496CD
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlyMemory<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlyMemory<T> memory, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return memory.Slice(MemoryExtensions.ClampStart<T>(memory.Span, trimElement));
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0004B4E3 File Offset: 0x000496E3
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlyMemory<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlyMemory<T> memory, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return memory.Slice(0, MemoryExtensions.ClampEnd<T>(memory.Span, 0, trimElement));
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0004B4FC File Offset: 0x000496FC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			int start = MemoryExtensions.ClampStart<T>(span, trimElement);
			int length = MemoryExtensions.ClampEnd<T>(span, start, trimElement);
			return span.Slice(start, length);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0004B52D File Offset: 0x0004972D
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return span.Slice(MemoryExtensions.ClampStart<T>(span, trimElement));
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0004B542 File Offset: 0x00049742
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Span<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return span.Slice(0, MemoryExtensions.ClampEnd<T>(span, 0, trimElement));
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0004B55C File Offset: 0x0004975C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			int start = MemoryExtensions.ClampStart<T>(span, trimElement);
			int length = MemoryExtensions.ClampEnd<T>(span, start, trimElement);
			return span.Slice(start, length);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0004B583 File Offset: 0x00049783
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return span.Slice(MemoryExtensions.ClampStart<T>(span, trimElement));
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0004B593 File Offset: 0x00049793
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ReadOnlySpan<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(1)] T trimElement) where T : IEquatable<T>
		{
			return span.Slice(0, MemoryExtensions.ClampEnd<T>(span, 0, trimElement));
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0004B5A8 File Offset: 0x000497A8
		private unsafe static int ClampStart<T>(ReadOnlySpan<T> span, T trimElement) where T : IEquatable<T>
		{
			int i = 0;
			if (trimElement != null)
			{
				while (i < span.Length)
				{
					ref T ptr = ref trimElement;
					if (default(T) == null)
					{
						T t = trimElement;
						ptr = ref t;
					}
					if (!ptr.Equals(*span[i]))
					{
						break;
					}
					i++;
				}
			}
			else
			{
				while (i < span.Length && *span[i] == null)
				{
					i++;
				}
			}
			return i;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0004B628 File Offset: 0x00049828
		private unsafe static int ClampEnd<T>(ReadOnlySpan<T> span, int start, T trimElement) where T : IEquatable<T>
		{
			int i = span.Length - 1;
			if (trimElement != null)
			{
				while (i >= start)
				{
					ref T ptr = ref trimElement;
					if (default(T) == null)
					{
						T t = trimElement;
						ptr = ref t;
					}
					if (!ptr.Equals(*span[i]))
					{
						break;
					}
					i--;
				}
			}
			else
			{
				while (i >= start && *span[i] == null)
				{
					i--;
				}
			}
			return i - start + 1;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0004B6A8 File Offset: 0x000498A8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Memory<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Memory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				ReadOnlySpan<T> span = memory.Span;
				int start = MemoryExtensions.ClampStart<T>(span, trimElements);
				int length = MemoryExtensions.ClampEnd<T>(span, start, trimElements);
				return memory.Slice(start, length);
			}
			if (trimElements.Length == 1)
			{
				return memory.Trim(*trimElements[0]);
			}
			return memory;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0004B704 File Offset: 0x00049904
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Memory<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Memory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return memory.Slice(MemoryExtensions.ClampStart<T>(memory.Span, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return memory.TrimStart(*trimElements[0]);
			}
			return memory;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0004B754 File Offset: 0x00049954
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Memory<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Memory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return memory.Slice(0, MemoryExtensions.ClampEnd<T>(memory.Span, 0, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return memory.TrimEnd(*trimElements[0]);
			}
			return memory;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0004B7A8 File Offset: 0x000499A8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static ReadOnlyMemory<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlyMemory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				ReadOnlySpan<T> span = memory.Span;
				int start = MemoryExtensions.ClampStart<T>(span, trimElements);
				int length = MemoryExtensions.ClampEnd<T>(span, start, trimElements);
				return memory.Slice(start, length);
			}
			if (trimElements.Length == 1)
			{
				return memory.Trim(*trimElements[0]);
			}
			return memory;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0004B7FF File Offset: 0x000499FF
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static ReadOnlyMemory<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlyMemory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return memory.Slice(MemoryExtensions.ClampStart<T>(memory.Span, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return memory.TrimStart(*trimElements[0]);
			}
			return memory;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0004B840 File Offset: 0x00049A40
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static ReadOnlyMemory<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlyMemory<T> memory, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return memory.Slice(0, MemoryExtensions.ClampEnd<T>(memory.Span, 0, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return memory.TrimEnd(*trimElements[0]);
			}
			return memory;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0004B890 File Offset: 0x00049A90
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Span<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				int start = MemoryExtensions.ClampStart<T>(span, trimElements);
				int length = MemoryExtensions.ClampEnd<T>(span, start, trimElements);
				return span.Slice(start, length);
			}
			if (trimElements.Length == 1)
			{
				return span.Trim(*trimElements[0]);
			}
			return span;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0004B8EB File Offset: 0x00049AEB
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Span<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return span.Slice(MemoryExtensions.ClampStart<T>(span, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return span.TrimStart(*trimElements[0]);
			}
			return span;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0004B92C File Offset: 0x00049B2C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Span<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Span<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return span.Slice(0, MemoryExtensions.ClampEnd<T>(span, 0, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return span.TrimEnd(*trimElements[0]);
			}
			return span;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0004B978 File Offset: 0x00049B78
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static ReadOnlySpan<T> Trim<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				int start = MemoryExtensions.ClampStart<T>(span, trimElements);
				int length = MemoryExtensions.ClampEnd<T>(span, start, trimElements);
				return span.Slice(start, length);
			}
			if (trimElements.Length == 1)
			{
				return span.Trim(*trimElements[0]);
			}
			return span;
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0004B9C9 File Offset: 0x00049BC9
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static ReadOnlySpan<T> TrimStart<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return span.Slice(MemoryExtensions.ClampStart<T>(span, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return span.TrimStart(*trimElements[0]);
			}
			return span;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0004BA03 File Offset: 0x00049C03
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static ReadOnlySpan<T> TrimEnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] this ReadOnlySpan<T> span, [Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			if (trimElements.Length > 1)
			{
				return span.Slice(0, MemoryExtensions.ClampEnd<T>(span, 0, trimElements));
			}
			if (trimElements.Length == 1)
			{
				return span.TrimEnd(*trimElements[0]);
			}
			return span;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0004BA40 File Offset: 0x00049C40
		private unsafe static int ClampStart<T>(ReadOnlySpan<T> span, ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			int num = 0;
			while (num < span.Length && trimElements.Contains(*span[num]))
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0004BA78 File Offset: 0x00049C78
		private unsafe static int ClampEnd<T>(ReadOnlySpan<T> span, int start, ReadOnlySpan<T> trimElements) where T : IEquatable<T>
		{
			int num = span.Length - 1;
			while (num >= start && trimElements.Contains(*span[num]))
			{
				num--;
			}
			return num - start + 1;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0004BAB4 File Offset: 0x00049CB4
		public static Memory<char> Trim(this Memory<char> memory)
		{
			ReadOnlySpan<char> span = memory.Span;
			int start = MemoryExtensions.ClampStart(span);
			int length = MemoryExtensions.ClampEnd(span, start);
			return memory.Slice(start, length);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		public static Memory<char> TrimStart(this Memory<char> memory)
		{
			return memory.Slice(MemoryExtensions.ClampStart(memory.Span));
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0004BAFE File Offset: 0x00049CFE
		public static Memory<char> TrimEnd(this Memory<char> memory)
		{
			return memory.Slice(0, MemoryExtensions.ClampEnd(memory.Span, 0));
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0004BB1C File Offset: 0x00049D1C
		public static ReadOnlyMemory<char> Trim(this ReadOnlyMemory<char> memory)
		{
			ReadOnlySpan<char> span = memory.Span;
			int start = MemoryExtensions.ClampStart(span);
			int length = MemoryExtensions.ClampEnd(span, start);
			return memory.Slice(start, length);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0004BB47 File Offset: 0x00049D47
		public static ReadOnlyMemory<char> TrimStart(this ReadOnlyMemory<char> memory)
		{
			return memory.Slice(MemoryExtensions.ClampStart(memory.Span));
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0004BB5C File Offset: 0x00049D5C
		public static ReadOnlyMemory<char> TrimEnd(this ReadOnlyMemory<char> memory)
		{
			return memory.Slice(0, MemoryExtensions.ClampEnd(memory.Span, 0));
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0004BB73 File Offset: 0x00049D73
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span)
		{
			if (span.Length == 0 || (!char.IsWhiteSpace((char)(*span[0])) && !char.IsWhiteSpace((char)(*span[span.Length - 1]))))
			{
				return span;
			}
			return MemoryExtensions.<Trim>g__TrimFallback|231_0(span);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0004BBB0 File Offset: 0x00049DB0
		public unsafe static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span)
		{
			int num = 0;
			while (num < span.Length && char.IsWhiteSpace((char)(*span[num])))
			{
				num++;
			}
			return span.Slice(num);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0004BBE8 File Offset: 0x00049DE8
		public unsafe static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span)
		{
			int num = span.Length - 1;
			while (num >= 0 && char.IsWhiteSpace((char)(*span[num])))
			{
				num--;
			}
			return span.Slice(0, num + 1);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0004BC24 File Offset: 0x00049E24
		public unsafe static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span, char trimChar)
		{
			int num = 0;
			while (num < span.Length && *span[num] == (ushort)trimChar)
			{
				num++;
			}
			int num2 = span.Length - 1;
			while (num2 > num && *span[num2] == (ushort)trimChar)
			{
				num2--;
			}
			return span.Slice(num, num2 - num + 1);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0004BC7C File Offset: 0x00049E7C
		public unsafe static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span, char trimChar)
		{
			int num = 0;
			while (num < span.Length && *span[num] == (ushort)trimChar)
			{
				num++;
			}
			return span.Slice(num);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0004BCB0 File Offset: 0x00049EB0
		public unsafe static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span, char trimChar)
		{
			int num = span.Length - 1;
			while (num >= 0 && *span[num] == (ushort)trimChar)
			{
				num--;
			}
			return span.Slice(0, num + 1);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0004BCE8 File Offset: 0x00049EE8
		public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span, ReadOnlySpan<char> trimChars)
		{
			return span.TrimStart(trimChars).TrimEnd(trimChars);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0004BCF8 File Offset: 0x00049EF8
		public unsafe static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span, ReadOnlySpan<char> trimChars)
		{
			if (trimChars.IsEmpty)
			{
				return span.TrimStart();
			}
			int i = 0;
			IL_40:
			while (i < span.Length)
			{
				for (int j = 0; j < trimChars.Length; j++)
				{
					if (*span[i] == *trimChars[j])
					{
						i++;
						goto IL_40;
					}
				}
				break;
			}
			return span.Slice(i);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0004BD58 File Offset: 0x00049F58
		public unsafe static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span, ReadOnlySpan<char> trimChars)
		{
			if (trimChars.IsEmpty)
			{
				return span.TrimEnd();
			}
			int i = span.Length - 1;
			IL_48:
			while (i >= 0)
			{
				for (int j = 0; j < trimChars.Length; j++)
				{
					if (*span[i] == *trimChars[j])
					{
						i--;
						goto IL_48;
					}
				}
				break;
			}
			return span.Slice(0, i + 1);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0004BDBC File Offset: 0x00049FBC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Span<char> Trim(this Span<char> span)
		{
			if (span.Length == 0 || (!char.IsWhiteSpace(*span[0]) && !char.IsWhiteSpace(*span[span.Length - 1])))
			{
				return span;
			}
			return MemoryExtensions.<Trim>g__TrimFallback|240_0(span);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0004BDF6 File Offset: 0x00049FF6
		public static Span<char> TrimStart(this Span<char> span)
		{
			return span.Slice(MemoryExtensions.ClampStart(span));
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0004BE0A File Offset: 0x0004A00A
		public static Span<char> TrimEnd(this Span<char> span)
		{
			return span.Slice(0, MemoryExtensions.ClampEnd(span, 0));
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0004BE20 File Offset: 0x0004A020
		private unsafe static int ClampStart(ReadOnlySpan<char> span)
		{
			int num = 0;
			while (num < span.Length && char.IsWhiteSpace((char)(*span[num])))
			{
				num++;
			}
			return num;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0004BE50 File Offset: 0x0004A050
		private unsafe static int ClampEnd(ReadOnlySpan<char> span, int start)
		{
			int num = span.Length - 1;
			while (num >= start && char.IsWhiteSpace((char)(*span[num])))
			{
				num--;
			}
			return num - start + 1;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0004BE88 File Offset: 0x0004A088
		internal static ReadOnlySpan<byte> TrimUtf8(this ReadOnlySpan<byte> span)
		{
			if (span.Length == 0)
			{
				return span;
			}
			Rune value;
			int num;
			Rune.DecodeFromUtf8(span, out value, out num);
			if (Rune.IsWhiteSpace(value))
			{
				ref ReadOnlySpan<byte> ptr = ref span;
				int num2 = num;
				span = ptr.Slice(num2, ptr.Length - num2);
				return MemoryExtensions.<TrimUtf8>g__TrimFallback|245_0(span);
			}
			Rune value2;
			int num3;
			Rune.DecodeLastFromUtf8(span, out value2, out num3);
			if (Rune.IsWhiteSpace(value2))
			{
				ref ReadOnlySpan<byte> ptr = ref span;
				int num2 = num3;
				span = ptr.Slice(0, ptr.Length - num2);
				return MemoryExtensions.<TrimUtf8>g__TrimFallback|245_0(span);
			}
			return span;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0004BF0C File Offset: 0x0004A10C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static ReadOnlySpan<char> <Trim>g__TrimFallback|231_0(ReadOnlySpan<char> span)
		{
			int num = 0;
			while (num < span.Length && char.IsWhiteSpace((char)(*span[num])))
			{
				num++;
			}
			int num2 = span.Length - 1;
			while (num2 > num && char.IsWhiteSpace((char)(*span[num2])))
			{
				num2--;
			}
			return span.Slice(num, num2 - num + 1);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0004BF6C File Offset: 0x0004A16C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static Span<char> <Trim>g__TrimFallback|240_0(Span<char> span)
		{
			int num = 0;
			while (num < span.Length && char.IsWhiteSpace(*span[num]))
			{
				num++;
			}
			int num2 = span.Length - 1;
			while (num2 > num && char.IsWhiteSpace(*span[num2]))
			{
				num2--;
			}
			return span.Slice(num, num2 - num + 1);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0004BFCC File Offset: 0x0004A1CC
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ReadOnlySpan<byte> <TrimUtf8>g__TrimFallback|245_0(ReadOnlySpan<byte> span)
		{
			while (span.Length != 0)
			{
				Rune value;
				int num;
				Rune.DecodeFromUtf8(span, out value, out num);
				ReadOnlySpan<byte> ptr;
				int num3;
				if (!Rune.IsWhiteSpace(value))
				{
					IL_61:
					while (span.Length != 0)
					{
						Rune value2;
						int num2;
						Rune.DecodeLastFromUtf8(span, out value2, out num2);
						if (!Rune.IsWhiteSpace(value2))
						{
							break;
						}
						ptr = ref span;
						num3 = num2;
						span = ptr.Slice(0, ptr.Length - num3);
					}
					return span;
				}
				ptr = ref span;
				num3 = num;
				span = ptr.Slice(num3, ptr.Length - num3);
			}
			goto IL_61;
		}

		// Token: 0x0200016A RID: 362
		[CompilerFeatureRequired("RefStructs")]
		public ref struct SpanSplitEnumerator<T> where T : IEquatable<T>
		{
			// Token: 0x0600186C RID: 6252 RVA: 0x0004C044 File Offset: 0x0004A244
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			public MemoryExtensions.SpanSplitEnumerator<T> GetEnumerator()
			{
				return this;
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x0600186D RID: 6253 RVA: 0x0004C04C File Offset: 0x0004A24C
			public Range Current
			{
				get
				{
					return new Range(this._startCurrent, this._endCurrent);
				}
			}

			// Token: 0x0600186E RID: 6254 RVA: 0x0004C06C File Offset: 0x0004A26C
			internal SpanSplitEnumerator(ReadOnlySpan<T> span, SearchValues<T> searchValues)
			{
				this._separatorBuffer = default(ReadOnlySpan<T>);
				this._separator = default(T);
				this._searchValues = null;
				this._startCurrent = 0;
				this._endCurrent = 0;
				this._startNext = 0;
				this._span = span;
				this._splitMode = MemoryExtensions.SpanSplitEnumeratorMode.SearchValues;
				this._searchValues = searchValues;
			}

			// Token: 0x0600186F RID: 6255 RVA: 0x0004C0C4 File Offset: 0x0004A2C4
			internal SpanSplitEnumerator(ReadOnlySpan<T> span, ReadOnlySpan<T> separators)
			{
				this._separatorBuffer = default(ReadOnlySpan<T>);
				this._separator = default(T);
				this._searchValues = null;
				this._startCurrent = 0;
				this._endCurrent = 0;
				this._startNext = 0;
				this._span = span;
				if (typeof(T) == typeof(char) && separators.Length == 0)
				{
					this._searchValues = Unsafe.As<SearchValues<T>>(string.SearchValuesStorage.WhiteSpaceChars);
					this._splitMode = MemoryExtensions.SpanSplitEnumeratorMode.SearchValues;
					return;
				}
				this._separatorBuffer = separators;
				this._splitMode = MemoryExtensions.SpanSplitEnumeratorMode.Any;
			}

			// Token: 0x06001870 RID: 6256 RVA: 0x0004C158 File Offset: 0x0004A358
			internal SpanSplitEnumerator(ReadOnlySpan<T> span, ReadOnlySpan<T> separator, bool treatAsSingleSeparator)
			{
				this._separator = default(T);
				this._searchValues = null;
				this._startCurrent = 0;
				this._endCurrent = 0;
				this._startNext = 0;
				this._span = span;
				this._separatorBuffer = separator;
				this._splitMode = ((separator.Length == 0) ? MemoryExtensions.SpanSplitEnumeratorMode.EmptySequence : MemoryExtensions.SpanSplitEnumeratorMode.Sequence);
			}

			// Token: 0x06001871 RID: 6257 RVA: 0x0004C1B0 File Offset: 0x0004A3B0
			internal SpanSplitEnumerator(ReadOnlySpan<T> span, T separator)
			{
				this._separatorBuffer = default(ReadOnlySpan<T>);
				this._separator = default(T);
				this._searchValues = null;
				this._startCurrent = 0;
				this._endCurrent = 0;
				this._startNext = 0;
				this._span = span;
				this._separator = separator;
				this._splitMode = MemoryExtensions.SpanSplitEnumeratorMode.SingleElement;
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x0004C208 File Offset: 0x0004A408
			public bool MoveNext()
			{
				int num;
				int num2;
				switch (this._splitMode)
				{
				case MemoryExtensions.SpanSplitEnumeratorMode.None:
					return false;
				case MemoryExtensions.SpanSplitEnumeratorMode.SingleElement:
					num = this._span.Slice(this._startNext).IndexOf(this._separator);
					num2 = 1;
					break;
				case MemoryExtensions.SpanSplitEnumeratorMode.Any:
					num = this._span.Slice(this._startNext).IndexOfAny(this._separatorBuffer);
					num2 = 1;
					break;
				case MemoryExtensions.SpanSplitEnumeratorMode.Sequence:
					num = this._span.Slice(this._startNext).IndexOf(this._separatorBuffer);
					num2 = this._separatorBuffer.Length;
					break;
				case MemoryExtensions.SpanSplitEnumeratorMode.EmptySequence:
					num = -1;
					num2 = 1;
					break;
				default:
					num = this._span.Slice(this._startNext).IndexOfAny(this._searchValues);
					num2 = 1;
					break;
				}
				this._startCurrent = this._startNext;
				if (num >= 0)
				{
					this._endCurrent = this._startCurrent + num;
					this._startNext = this._endCurrent + num2;
				}
				else
				{
					this._startNext = (this._endCurrent = this._span.Length);
					this._splitMode = MemoryExtensions.SpanSplitEnumeratorMode.None;
				}
				return true;
			}

			// Token: 0x040004F7 RID: 1271
			private readonly ReadOnlySpan<T> _span;

			// Token: 0x040004F8 RID: 1272
			private readonly T _separator;

			// Token: 0x040004F9 RID: 1273
			private readonly ReadOnlySpan<T> _separatorBuffer;

			// Token: 0x040004FA RID: 1274
			private readonly SearchValues<T> _searchValues;

			// Token: 0x040004FB RID: 1275
			private MemoryExtensions.SpanSplitEnumeratorMode _splitMode;

			// Token: 0x040004FC RID: 1276
			private int _startCurrent;

			// Token: 0x040004FD RID: 1277
			private int _endCurrent;

			// Token: 0x040004FE RID: 1278
			private int _startNext;
		}

		// Token: 0x0200016B RID: 363
		private enum SpanSplitEnumeratorMode
		{
			// Token: 0x04000500 RID: 1280
			None,
			// Token: 0x04000501 RID: 1281
			SingleElement,
			// Token: 0x04000502 RID: 1282
			Any,
			// Token: 0x04000503 RID: 1283
			Sequence,
			// Token: 0x04000504 RID: 1284
			EmptySequence,
			// Token: 0x04000505 RID: 1285
			SearchValues
		}

		// Token: 0x0200016C RID: 364
		[CompilerFeatureRequired("RefStructs")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public ref struct TryWriteInterpolatedStringHandler
		{
			// Token: 0x06001873 RID: 6259 RVA: 0x0004C31C File Offset: 0x0004A51C
			public TryWriteInterpolatedStringHandler(int literalLength, int formattedCount, Span<char> destination, out bool shouldAppend)
			{
				this._destination = destination;
				this._provider = null;
				this._pos = 0;
				this._success = (shouldAppend = (destination.Length >= literalLength));
				this._hasCustomFormatter = false;
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x0004C360 File Offset: 0x0004A560
			public TryWriteInterpolatedStringHandler(int literalLength, int formattedCount, Span<char> destination, [Nullable(2)] IFormatProvider provider, out bool shouldAppend)
			{
				this._destination = destination;
				this._provider = provider;
				this._pos = 0;
				this._success = (shouldAppend = (destination.Length >= literalLength));
				this._hasCustomFormatter = (provider != null && DefaultInterpolatedStringHandler.HasCustomFormatter(provider));
			}

			// Token: 0x06001875 RID: 6261 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
			[NullableContext(1)]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool AppendLiteral(string value)
			{
				if (value.TryCopyTo(this._destination.Slice(this._pos)))
				{
					this._pos += value.Length;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x0004C3E8 File Offset: 0x0004A5E8
			[NullableContext(1)]
			public bool AppendFormatted<[Nullable(2)] T>(T value)
			{
				if (this._hasCustomFormatter)
				{
					return this.AppendCustomFormatter<T>(value, null);
				}
				string text;
				if (value is IFormattable)
				{
					if (typeof(T).IsEnum)
					{
						int num;
						if (Enum.TryFormatUnconstrained<T>(value, this._destination.Slice(this._pos), out num, default(ReadOnlySpan<char>)))
						{
							this._pos += num;
							return true;
						}
						return this.Fail();
					}
					else if (value is ISpanFormattable)
					{
						int num2;
						if (((ISpanFormattable)((object)value)).TryFormat(this._destination.Slice(this._pos), out num2, default(ReadOnlySpan<char>), this._provider))
						{
							this._pos += num2;
							return true;
						}
						return this.Fail();
					}
					else
					{
						text = ((IFormattable)((object)value)).ToString(null, this._provider);
					}
				}
				else
				{
					ref T ptr = ref value;
					T t = default(T);
					string text2;
					if (t == null)
					{
						t = value;
						ptr = ref t;
						if (t == null)
						{
							text2 = null;
							goto IL_113;
						}
					}
					text2 = ptr.ToString();
					IL_113:
					text = text2;
				}
				return text == null || this.AppendLiteral(text);
			}

			// Token: 0x06001877 RID: 6263 RVA: 0x0004C518 File Offset: 0x0004A718
			[NullableContext(2)]
			public bool AppendFormatted<T>([Nullable(1)] T value, string format)
			{
				if (this._hasCustomFormatter)
				{
					return this.AppendCustomFormatter<T>(value, format);
				}
				string text;
				if (value is IFormattable)
				{
					if (typeof(T).IsEnum)
					{
						int num;
						if (Enum.TryFormatUnconstrained<T>(value, this._destination.Slice(this._pos), out num, format))
						{
							this._pos += num;
							return true;
						}
						return this.Fail();
					}
					else if (value is ISpanFormattable)
					{
						int num2;
						if (((ISpanFormattable)((object)value)).TryFormat(this._destination.Slice(this._pos), out num2, format, this._provider))
						{
							this._pos += num2;
							return true;
						}
						return this.Fail();
					}
					else
					{
						text = ((IFormattable)((object)value)).ToString(format, this._provider);
					}
				}
				else
				{
					ref T ptr = ref value;
					T t = default(T);
					string text2;
					if (t == null)
					{
						t = value;
						ptr = ref t;
						if (t == null)
						{
							text2 = null;
							goto IL_10A;
						}
					}
					text2 = ptr.ToString();
					IL_10A:
					text = text2;
				}
				return text == null || this.AppendLiteral(text);
			}

			// Token: 0x06001878 RID: 6264 RVA: 0x0004C63C File Offset: 0x0004A83C
			[NullableContext(1)]
			public bool AppendFormatted<[Nullable(2)] T>(T value, int alignment)
			{
				int pos = this._pos;
				if (this.AppendFormatted<T>(value))
				{
					return alignment == 0 || this.TryAppendOrInsertAlignmentIfNeeded(pos, alignment);
				}
				return this.Fail();
			}

			// Token: 0x06001879 RID: 6265 RVA: 0x0004C670 File Offset: 0x0004A870
			[NullableContext(2)]
			public bool AppendFormatted<T>([Nullable(1)] T value, int alignment, string format)
			{
				int pos = this._pos;
				if (this.AppendFormatted<T>(value, format))
				{
					return alignment == 0 || this.TryAppendOrInsertAlignmentIfNeeded(pos, alignment);
				}
				return this.Fail();
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x0004C6A2 File Offset: 0x0004A8A2
			public bool AppendFormatted([ScopedRef] ReadOnlySpan<char> value)
			{
				if (value.TryCopyTo(this._destination.Slice(this._pos)))
				{
					this._pos += value.Length;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x0600187B RID: 6267 RVA: 0x0004C6DC File Offset: 0x0004A8DC
			public bool AppendFormatted([ScopedRef] ReadOnlySpan<char> value, int alignment = 0, [Nullable(2)] string format = null)
			{
				bool flag = false;
				if (alignment < 0)
				{
					flag = true;
					alignment = -alignment;
				}
				int num = alignment - value.Length;
				if (num <= 0)
				{
					return this.AppendFormatted(value);
				}
				if (alignment <= this._destination.Length - this._pos)
				{
					if (flag)
					{
						value.CopyTo(this._destination.Slice(this._pos));
						this._pos += value.Length;
						this._destination.Slice(this._pos, num).Fill(' ');
						this._pos += num;
					}
					else
					{
						this._destination.Slice(this._pos, num).Fill(' ');
						this._pos += num;
						value.CopyTo(this._destination.Slice(this._pos));
						this._pos += value.Length;
					}
					return true;
				}
				return this.Fail();
			}

			// Token: 0x0600187C RID: 6268 RVA: 0x0004C7DC File Offset: 0x0004A9DC
			[NullableContext(2)]
			public bool AppendFormatted(string value)
			{
				if (this._hasCustomFormatter)
				{
					return this.AppendCustomFormatter<string>(value, null);
				}
				if (value == null)
				{
					return true;
				}
				if (value.TryCopyTo(this._destination.Slice(this._pos)))
				{
					this._pos += value.Length;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x0600187D RID: 6269 RVA: 0x0004C833 File Offset: 0x0004AA33
			[NullableContext(2)]
			public bool AppendFormatted(string value, int alignment = 0, string format = null)
			{
				return this.AppendFormatted<string>(value, alignment, format);
			}

			// Token: 0x0600187E RID: 6270 RVA: 0x0004C83E File Offset: 0x0004AA3E
			[NullableContext(2)]
			public bool AppendFormatted(object value, int alignment = 0, string format = null)
			{
				return this.AppendFormatted<object>(value, alignment, format);
			}

			// Token: 0x0600187F RID: 6271 RVA: 0x0004C84C File Offset: 0x0004AA4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool AppendCustomFormatter<T>(T value, string format)
			{
				ICustomFormatter customFormatter = (ICustomFormatter)this._provider.GetFormat(typeof(ICustomFormatter));
				if (customFormatter != null)
				{
					string text = customFormatter.Format(format, value, this._provider);
					if (text != null)
					{
						return this.AppendLiteral(text);
					}
				}
				return true;
			}

			// Token: 0x06001880 RID: 6272 RVA: 0x0004C898 File Offset: 0x0004AA98
			private bool TryAppendOrInsertAlignmentIfNeeded(int startingPos, int alignment)
			{
				int num = this._pos - startingPos;
				bool flag = false;
				if (alignment < 0)
				{
					flag = true;
					alignment = -alignment;
				}
				int num2 = alignment - num;
				if (num2 <= 0)
				{
					return true;
				}
				if (num2 <= this._destination.Length - this._pos)
				{
					if (flag)
					{
						this._destination.Slice(this._pos, num2).Fill(' ');
					}
					else
					{
						this._destination.Slice(startingPos, num).CopyTo(this._destination.Slice(startingPos + num2));
						this._destination.Slice(startingPos, num2).Fill(' ');
					}
					this._pos += num2;
					return true;
				}
				return this.Fail();
			}

			// Token: 0x06001881 RID: 6273 RVA: 0x0004C94A File Offset: 0x0004AB4A
			private bool Fail()
			{
				this._success = false;
				return false;
			}

			// Token: 0x04000506 RID: 1286
			private readonly Span<char> _destination;

			// Token: 0x04000507 RID: 1287
			private readonly IFormatProvider _provider;

			// Token: 0x04000508 RID: 1288
			internal int _pos;

			// Token: 0x04000509 RID: 1289
			internal bool _success;

			// Token: 0x0400050A RID: 1290
			private readonly bool _hasCustomFormatter;
		}
	}
}
