using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CSharpScript.Game.Module.SolarSchool;
using FilterDefine;

namespace CSharpScript.Game.Common.LocalStorageJson
{
	// Token: 0x02006411 RID: 25617
	[NullableContext(1)]
	[Nullable(0)]
	internal static class LocalStorageJsonMapDecoder
	{
		// Token: 0x0603E1DD RID: 254429 RVA: 0x01205E4C File Offset: 0x0120404C
		public static bool TryDecode<[Nullable(2)] T>(JsonElement contentArray, Type targetType, JsonSerializerOptions keyOptions, JsonSerializerOptions valueOptions, [Nullable(2)] out T result)
		{
			if (targetType == typeof(Dictionary<ESolarSchoolLocalRecordType, HashSet<int>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<ESolarSchoolLocalRecordType, HashSet<int>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<EFunction, int>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<EFunction, int>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<FilterDefine.EFilterType, List<int>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<FilterDefine.EFilterType, List<int>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, bool>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, bool>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, double>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, double>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, float>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, float>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, float[]>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, float[]>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, AbyssDangoOwnerData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, AbyssDangoOwnerData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, AreaExplorePlayState>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, AreaExplorePlayState>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, SolarSchoolActivityLocalData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, SolarSchoolActivityLocalData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, SolarSchoolRedDotLocalData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, SolarSchoolRedDotLocalData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, SolarSchoolSlotLocalData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, SolarSchoolSlotLocalData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, LocalFriendApplication>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, LocalFriendApplication>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, Dictionary<int, double>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, Dictionary<int, double>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, Dictionary<int, AbyssDangoOwnerData>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, Dictionary<int, AbyssDangoOwnerData>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, Dictionary<int, AreaExplorePlayState>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, Dictionary<int, AreaExplorePlayState>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, Dictionary<int, HashSet<int>>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, Dictionary<int, HashSet<int>>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, HashSet<int>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, HashSet<int>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, List<int>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, List<int>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, int>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, int>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, int[]>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, int[]>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, long>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, long>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<int, string>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<int, string>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, bool>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, bool>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, FilterStorageData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, FilterStorageData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, GamepadTypeUsage>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, GamepadTypeUsage>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, LocalPlayerIpLevelData[]>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, LocalPlayerIpLevelData[]>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, MarqueeStorageData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, MarqueeStorageData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, RegionAndIpSt>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, RegionAndIpSt>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, SortStorageData>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, SortStorageData>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, IList<IList<string>>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, IList<IList<string>>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, List<ActivityCacheData>>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, List<ActivityCacheData>>(contentArray, keyOptions, valueOptions));
				return true;
			}
			if (targetType == typeof(Dictionary<string, int>))
			{
				result = (T)((object)LocalStorageJsonMapDecoder.DecodeDictionary<string, int>(contentArray, keyOptions, valueOptions));
				return true;
			}
			result = default(T);
			return false;
		}

		// Token: 0x0603E1DE RID: 254430 RVA: 0x0120638C File Offset: 0x0120458C
		private static Dictionary<TKey, TValue> DecodeDictionary<TKey, [Nullable(2)] TValue>(JsonElement contentArray, JsonSerializerOptions keyOptions, JsonSerializerOptions valueOptions)
		{
			Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
			foreach (JsonElement jsonElement in contentArray.EnumerateArray())
			{
				if (jsonElement.ValueKind != JsonValueKind.Array)
				{
					throw new JsonException("Map.Content 元素不是 [k,v] 数组");
				}
				using (JsonElement.ArrayEnumerator enumerator2 = jsonElement.EnumerateArray().GetEnumerator())
				{
					if (!enumerator2.MoveNext())
					{
						throw new JsonException("Map.Content 元素缺少 key");
					}
					TKey tkey = enumerator2.Current.Deserialize(keyOptions);
					if (!enumerator2.MoveNext())
					{
						throw new JsonException("Map.Content 元素缺少 value");
					}
					TValue value = enumerator2.Current.Deserialize(valueOptions);
					if (tkey != null)
					{
						dictionary[tkey] = value;
					}
				}
			}
			return dictionary;
		}
	}
}
