using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Misc
{
	// Token: 0x020054AC RID: 21676
	[NullableContext(1)]
	[Nullable(0)]
	public static class MapLogger
	{
		// Token: 0x0603761B RID: 226843 RVA: 0x00D27788 File Offset: 0x00D25988
		public static void Clear()
		{
			MapLogger.LogCounterMap.Clear();
		}

		// Token: 0x0603761C RID: 226844 RVA: 0x00D27794 File Offset: 0x00D25994
		public static void Debug(ELogAuthor author, string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			2
		})] ReadOnlySpan<ValueTuple<string, object>> pairs)
		{
		}

		// Token: 0x0603761D RID: 226845 RVA: 0x00D27796 File Offset: 0x00D25996
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

		// Token: 0x0603761E RID: 226846 RVA: 0x00D277B0 File Offset: 0x00D259B0
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

		// Token: 0x0603761F RID: 226847 RVA: 0x00D277C1 File Offset: 0x00D259C1
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

		// Token: 0x06037620 RID: 226848 RVA: 0x00D277DB File Offset: 0x00D259DB
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

		// Token: 0x06037621 RID: 226849 RVA: 0x00D277EC File Offset: 0x00D259EC
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

		// Token: 0x06037622 RID: 226850 RVA: 0x00D27806 File Offset: 0x00D25A06
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

		// Token: 0x06037623 RID: 226851 RVA: 0x00D27817 File Offset: 0x00D25A17
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

		// Token: 0x06037624 RID: 226852 RVA: 0x00D27834 File Offset: 0x00D25A34
		private static bool IsLogExceedsLimit(object key, int limit = 1)
		{
			int num;
			return MapLogger.LogCounterMap.TryGetValue(key, out num) && num >= limit;
		}

		// Token: 0x06037625 RID: 226853 RVA: 0x00D2785C File Offset: 0x00D25A5C
		private static void CountLog(object key)
		{
			int valueOrDefault = MapLogger.LogCounterMap.GetValueOrDefault(key, 0);
			MapLogger.LogCounterMap[key] = valueOrDefault + 1;
		}

		// Token: 0x0401D2C7 RID: 119495
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<object, int> LogCounterMap = new Dictionary<object, int>();
	}
}
