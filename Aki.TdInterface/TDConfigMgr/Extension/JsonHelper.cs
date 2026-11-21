using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Aki.TDConfigMgr.Extension
{
	// Token: 0x02000F61 RID: 3937
	[NullableContext(1)]
	[Nullable(0)]
	public static class JsonHelper
	{
		// Token: 0x06005830 RID: 22576 RVA: 0x000D79D4 File Offset: 0x000D5BD4
		public static T ParseObject<[Nullable(2)] T>(string json, Func<JsonElement, T> factory)
		{
			JsonDocument jsonDocument = JsonDocument.Parse(json, default(JsonDocumentOptions));
			return factory(jsonDocument.RootElement);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x000D7A00 File Offset: 0x000D5C00
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

		// Token: 0x06005832 RID: 22578 RVA: 0x000D7A84 File Offset: 0x000D5C84
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

		// Token: 0x06005833 RID: 22579 RVA: 0x000D7B10 File Offset: 0x000D5D10
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
