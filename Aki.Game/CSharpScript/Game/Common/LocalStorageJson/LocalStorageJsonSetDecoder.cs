using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x02007293 RID: 29331
	[NullableContext(1)]
	[Nullable(0)]
	internal static class LocalStorageJsonSetDecoder
	{
		// Token: 0x06047E1F RID: 294431 RVA: 0x012659D4 File Offset: 0x01263BD4
		public static bool TryDecode<[Nullable(2)] T>(JsonElement contentArray, Type targetType, JsonSerializerOptions elementOptions, [Nullable(2)] out T result)
		{
			if (targetType == typeof(HashSet<EMapNoteId>))
			{
				result = (T)((object)LocalStorageJsonSetDecoder.DecodeHashSet<EMapNoteId>(contentArray, elementOptions));
				return true;
			}
			if (targetType == typeof(HashSet<int>))
			{
				result = (T)((object)LocalStorageJsonSetDecoder.DecodeHashSet<int>(contentArray, elementOptions));
				return true;
			}
			result = default(T);
			return false;
		}

		// Token: 0x06047E20 RID: 294432 RVA: 0x01265A38 File Offset: 0x01263C38
		private static HashSet<TElement> DecodeHashSet<[Nullable(2)] TElement>(JsonElement contentArray, JsonSerializerOptions elementOptions)
		{
			HashSet<TElement> hashSet = new HashSet<TElement>();
			foreach (JsonElement element in contentArray.EnumerateArray())
			{
				TElement telement = element.Deserialize(elementOptions);
				if (telement != null)
				{
					hashSet.Add(telement);
				}
			}
			return hashSet;
		}
	}
}
