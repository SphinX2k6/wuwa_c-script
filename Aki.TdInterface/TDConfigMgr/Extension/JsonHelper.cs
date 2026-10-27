using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Aki.TDConfigMgr.Extension
{
	// Token: 0x02000E50 RID: 3664
	[NullableContext(1)]
	[Nullable(0)]
	public static class JsonHelper
	{
		// Token: 0x060052B4 RID: 21172 RVA: 0x000CB82C File Offset: 0x000C9A2C
		public static T ParseObject<[Nullable(2)] T>(string json, Func<JsonElement, T> factory)
		{
			JsonDocument jsonDocument = JsonDocument.Parse(json, default(JsonDocumentOptions));
			return factory(jsonDocument.RootElement);
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x000CB858 File Offset: 0x000C9A58
		public static List<T> ParseArray<[Nullable(2)] T>(string json, Func<JsonElement, T> factory)
		{
			JsonElement rootElement = JsonDocument.Parse(json, default(JsonDocumentOptions)).RootElement;
			List<T> list = new List<T>();
			foreach (JsonElement jsonElement in rootElement.EnumerateArray())
			{
				list.Add(factory(jsonElement.Clone()));
			}
			return list;
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x000CB8DC File Offset: 0x000C9ADC
		public static List<T> ParseArray<[Nullable(2)] T>(string json, Func<JsonElement, T> factory, string rootPropertyName)
		{
			JsonElement property = JsonDocument.Parse(json, default(JsonDocumentOptions)).RootElement.GetProperty(rootPropertyName);
			List<T> list = new List<T>();
			foreach (JsonElement jsonElement in property.EnumerateArray())
			{
				list.Add(factory(jsonElement.Clone()));
			}
			return list;
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x000CB968 File Offset: 0x000C9B68
		public static List<T> ParseEnums<[Nullable(0)] T>(string json, Func<JsonElement, T> factory, string rootPropertyName = "") where T : Enum
		{
			JsonDocument jsonDocument = JsonDocument.Parse(json, default(JsonDocumentOptions));
			List<T> list = new List<T>();
			foreach (JsonElement arg in jsonDocument.RootElement.EnumerateArray())
			{
				list.Add(factory(arg));
			}
			return list;
		}
	}
}
