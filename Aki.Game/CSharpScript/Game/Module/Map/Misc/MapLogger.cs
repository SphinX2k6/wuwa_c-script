using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Misc
{
	// Token: 0x0200448F RID: 17551
	[NullableContext(1)]
	[Nullable(0)]
	public static class MapLogger
	{
		// Token: 0x0602C571 RID: 181617 RVA: 0x00C77504 File Offset: 0x00C75704
		public static void Clear()
		{
			MapLogger.LogCounterMap.Clear();
		}

		// Token: 0x0602C572 RID: 181618 RVA: 0x00C77510 File Offset: 0x00C75710
		public static void Debug(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0602C573 RID: 181619 RVA: 0x00C77512 File Offset: 0x00C75712
		public static void DebugOnce(object key, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (MapLogger.IsLogExceedsLimit(key, 1))
			{
				return;
			}
			MapLogger.Debug(author, message, pairs);
			MapLogger.CountLog(key);
		}

		// Token: 0x0602C574 RID: 181620 RVA: 0x00C7752C File Offset: 0x00C7572C
		public static void Info(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			Log.Instance.Info(ELogModule.Map, author, message, pairs);
		}

		// Token: 0x0602C575 RID: 181621 RVA: 0x00C7753D File Offset: 0x00C7573D
		public static void InfoOnce(object key, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (MapLogger.IsLogExceedsLimit(key, 1))
			{
				return;
			}
			MapLogger.Info(author, message, pairs);
			MapLogger.CountLog(key);
		}

		// Token: 0x0602C576 RID: 181622 RVA: 0x00C77557 File Offset: 0x00C75757
		public static void Warn(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			Log.Instance.Warn(ELogModule.Map, author, message, pairs);
		}

		// Token: 0x0602C577 RID: 181623 RVA: 0x00C77568 File Offset: 0x00C75768
		public static void WarnOnce(object key, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (MapLogger.IsLogExceedsLimit(key, 1))
			{
				return;
			}
			MapLogger.Warn(author, message, pairs);
			MapLogger.CountLog(key);
		}

		// Token: 0x0602C578 RID: 181624 RVA: 0x00C77582 File Offset: 0x00C75782
		public static void Error(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			Log.Instance.Error(ELogModule.Map, author, message, pairs);
		}

		// Token: 0x0602C579 RID: 181625 RVA: 0x00C77593 File Offset: 0x00C75793
		public static void ErrorOnce(object key, ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
			if (MapLogger.IsLogExceedsLimit(key, 1))
			{
				return;
			}
			MapLogger.Error(author, message, pairs);
			MapLogger.CountLog(key);
		}

		// Token: 0x0602C57A RID: 181626 RVA: 0x00C775B0 File Offset: 0x00C757B0
		private static bool IsLogExceedsLimit(object key, int limit = 1)
		{
			int num;
			return MapLogger.LogCounterMap.TryGetValue(key, out num) && num >= limit;
		}

		// Token: 0x0602C57B RID: 181627 RVA: 0x00C775D8 File Offset: 0x00C757D8
		private static void CountLog(object key)
		{
			int valueOrDefault = MapLogger.LogCounterMap.GetValueOrDefault(key, 0);
			MapLogger.LogCounterMap[key] = valueOrDefault + 1;
		}

		// Token: 0x04017D63 RID: 97635
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<object, int> LogCounterMap = new Dictionary<object, int>();
	}
}
