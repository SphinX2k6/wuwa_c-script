using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000029 RID: 41
	[NullableContext(1)]
	[Nullable(0)]
	public static class ListExtensions
	{
		// Token: 0x06000188 RID: 392 RVA: 0x000094A3 File Offset: 0x000076A3
		public static bool TryPop<[Nullable(2)] T>(this IList<T> list, [MaybeNullWhen(false)] out T result)
		{
			if (list.Count == 0)
			{
				result = default(T);
				return false;
			}
			result = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			return true;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000094D9 File Offset: 0x000076D9
		public static T Pop<[Nullable(2)] T>(this IList<T> list)
		{
			if (list.Count == 0)
			{
				throw new ArgumentOutOfRangeException("list");
			}
			T result = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			return result;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000950A File Offset: 0x0000770A
		public static bool TryShift<[Nullable(2)] T>(this IList<T> list, [MaybeNullWhen(false)] out T result)
		{
			if (list.Count == 0)
			{
				result = default(T);
				return false;
			}
			result = list[0];
			list.RemoveAt(0);
			return true;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009532 File Offset: 0x00007732
		public static T Shift<[Nullable(2)] T>(this IList<T> list)
		{
			if (list.Count == 0)
			{
				throw new ArgumentOutOfRangeException("list");
			}
			T result = list[0];
			list.RemoveAt(0);
			return result;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009558 File Offset: 0x00007758
		public static void Swap<[Nullable(2)] T>(this IList<T> list, int indexA, int indexB)
		{
			T value = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = value;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009584 File Offset: 0x00007784
		[NullableContext(2)]
		public static T GetValueOrDefault<T>([Nullable(1)] this IReadOnlyList<T> list, int index)
		{
			if (index >= 0 && index < list.Count)
			{
				return list[index];
			}
			return default(T);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000095AF File Offset: 0x000077AF
		public static T GetValueOrDefault<[Nullable(2)] T>(this IReadOnlyList<T> list, int index, T defaultValue)
		{
			if (index >= 0 && index < list.Count)
			{
				return list[index];
			}
			return defaultValue;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000095C8 File Offset: 0x000077C8
		[NullableContext(0)]
		public static T? GetValueOrNull<T>([Nullable(new byte[]
		{
			1,
			0
		})] this IReadOnlyList<T> list, int index) where T : struct
		{
			if (index >= 0 && index < list.Count)
			{
				return new T?(list[index]);
			}
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000095F8 File Offset: 0x000077F8
		public static bool TryGetValue<[Nullable(2)] T>(this IReadOnlyList<T> list, int index, [MaybeNullWhen(false)] out T value)
		{
			if (index >= 0 && index < list.Count)
			{
				value = list[index];
				return true;
			}
			value = default(T);
			return false;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009620 File Offset: 0x00007820
		[NullableContext(0)]
		public static T? FirstOrNull<T>([Nullable(new byte[]
		{
			1,
			0
		})] this IReadOnlyList<T> list) where T : struct
		{
			if (list.Count == 0)
			{
				return null;
			}
			return new T?(list[0]);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000964B File Offset: 0x0000784B
		[NullableContext(0)]
		public static T? FirstOrNull<T>([Nullable(new byte[]
		{
			1,
			0
		})] this IReadOnlyList<T> list, T? defaultValue) where T : struct
		{
			if (list.Count == 0)
			{
				return defaultValue;
			}
			return new T?(list[0]);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009664 File Offset: 0x00007864
		[NullableContext(0)]
		public static T? FirstOrNull<T>([Nullable(new byte[]
		{
			1,
			0
		})] this IReadOnlyList<T> list, [Nullable(new byte[]
		{
			1,
			0
		})] Func<T, bool> predicate) where T : struct
		{
			foreach (T t in list)
			{
				if (predicate(t))
				{
					return new T?(t);
				}
			}
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000096C4 File Offset: 0x000078C4
		public static int IndexOf<[Nullable(2)] T>(this IReadOnlyList<T> list, T obj)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				if (EqualityComparer<T>.Default.Equals(list[i], obj))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009708 File Offset: 0x00007908
		public static int IndexOf<[Nullable(2)] T>(this IReadOnlyList<T> list, Func<T, bool> predicate)
		{
			ArgumentNullException.ThrowIfNull(list, "list");
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				if (predicate(list[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009748 File Offset: 0x00007948
		public static int ParseInt(this IReadOnlyList<string> list, int index, int defaultValue)
		{
			int result;
			if (index >= 0 && index < list.Count && int.TryParse(list[index], out result))
			{
				return result;
			}
			return defaultValue;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009775 File Offset: 0x00007975
		public static bool TryParseInt(this IReadOnlyList<string> list, int index, out int value)
		{
			if (index >= 0 && index < list.Count && int.TryParse(list[index], out value))
			{
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000979C File Offset: 0x0000799C
		public static int? ParseInt(this IReadOnlyList<string> list, int index)
		{
			int value;
			if (index >= 0 && index < list.Count && int.TryParse(list[index], out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000097D8 File Offset: 0x000079D8
		public static float ParseFloat(this IReadOnlyList<string> list, int index, float defaultValue)
		{
			float result;
			if (index >= 0 && index < list.Count && float.TryParse(list[index], out result))
			{
				return result;
			}
			return defaultValue;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009805 File Offset: 0x00007A05
		public static bool TryParseFloat(this IReadOnlyList<string> list, int index, out float value)
		{
			if (index >= 0 && index < list.Count && float.TryParse(list[index], out value))
			{
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009830 File Offset: 0x00007A30
		public static float? ParseFloat(this IReadOnlyList<string> list, int index)
		{
			float value;
			if (index > list.Count && float.TryParse(list[index], out value))
			{
				return new float?(value);
			}
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00009866 File Offset: 0x00007A66
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
		})] this List<T> list)
		{
			return CollectionsMarshal.AsSpan<T>(list);
		}
	}
}
