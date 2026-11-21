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
		// Token: 0x06000188 RID: 392 RVA: 0x000094DA File Offset: 0x000076DA
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

		// Token: 0x06000189 RID: 393 RVA: 0x00009510 File Offset: 0x00007710
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

		// Token: 0x0600018A RID: 394 RVA: 0x00009541 File Offset: 0x00007741
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

		// Token: 0x0600018B RID: 395 RVA: 0x00009569 File Offset: 0x00007769
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

		// Token: 0x0600018C RID: 396 RVA: 0x0000958C File Offset: 0x0000778C
		public static void Swap<[Nullable(2)] T>(this IList<T> list, int indexA, int indexB)
		{
			T value = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = value;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000095B8 File Offset: 0x000077B8
		[NullableContext(2)]
		public static T GetValueOrDefault<T>([Nullable(1)] this IReadOnlyList<T> list, int index)
		{
			if (index >= 0 && index < list.Count)
			{
				return list[index];
			}
			return default(T);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000095E3 File Offset: 0x000077E3
		public static T GetValueOrDefault<[Nullable(2)] T>(this IReadOnlyList<T> list, int index, T defaultValue)
		{
			if (index >= 0 && index < list.Count)
			{
				return list[index];
			}
			return defaultValue;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000095FC File Offset: 0x000077FC
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

		// Token: 0x06000190 RID: 400 RVA: 0x0000962C File Offset: 0x0000782C
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

		// Token: 0x06000191 RID: 401 RVA: 0x00009654 File Offset: 0x00007854
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

		// Token: 0x06000192 RID: 402 RVA: 0x0000967F File Offset: 0x0000787F
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

		// Token: 0x06000193 RID: 403 RVA: 0x00009698 File Offset: 0x00007898
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

		// Token: 0x06000194 RID: 404 RVA: 0x000096F8 File Offset: 0x000078F8
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

		// Token: 0x06000195 RID: 405 RVA: 0x0000973C File Offset: 0x0000793C
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

		// Token: 0x06000196 RID: 406 RVA: 0x0000977C File Offset: 0x0000797C
		public static int ParseInt(this IReadOnlyList<string> list, int index, int defaultValue)
		{
			int result;
			if (index >= 0 && index < list.Count && int.TryParse(list[index], out result))
			{
				return result;
			}
			return defaultValue;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000097A9 File Offset: 0x000079A9
		public static bool TryParseInt(this IReadOnlyList<string> list, int index, out int value)
		{
			if (index >= 0 && index < list.Count && int.TryParse(list[index], out value))
			{
				return true;
			}
			value = 0;
			return false;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000097D0 File Offset: 0x000079D0
		public static int? ParseInt(this IReadOnlyList<string> list, int index)
		{
			int value;
			if (index >= 0 && index < list.Count && int.TryParse(list[index], out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000980C File Offset: 0x00007A0C
		public static float ParseFloat(this IReadOnlyList<string> list, int index, float defaultValue)
		{
			float result;
			if (index >= 0 && index < list.Count && float.TryParse(list[index], out result))
			{
				return result;
			}
			return defaultValue;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009839 File Offset: 0x00007A39
		public static bool TryParseFloat(this IReadOnlyList<string> list, int index, out float value)
		{
			if (index >= 0 && index < list.Count && float.TryParse(list[index], out value))
			{
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009864 File Offset: 0x00007A64
		public static float? ParseFloat(this IReadOnlyList<string> list, int index)
		{
			float value;
			if (index >= 0 && index < list.Count && float.TryParse(list[index], out value))
			{
				return new float?(value);
			}
			return null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000989E File Offset: 0x00007A9E
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
