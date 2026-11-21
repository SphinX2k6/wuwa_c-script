using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x02006412 RID: 25618
	[NullableContext(1)]
	[Nullable(0)]
	internal static class LocalStorageJsonSetDecoder
	{
		// Token: 0x0603E1DF RID: 254431 RVA: 0x01206484 File Offset: 0x01204684
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

		// Token: 0x0603E1E0 RID: 254432 RVA: 0x012064E8 File Offset: 0x012046E8
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
