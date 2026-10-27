using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Core.Common
{
	// Token: 0x0200016F RID: 367
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		0,
		1,
		1
	})]
	public class ArrayToKvpConverter<[Nullable(2)] TKey, [Nullable(2)] TValue> : JsonConverter<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x06000C9D RID: 3229 RVA: 0x0003B1FC File Offset: 0x000393FC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public override KeyValuePair<TKey, TValue> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartArray)
			{
				throw new JsonException("Expected array start");
			}
			reader.Read();
			TKey key = JsonSerializer.Deserialize<TKey>(ref reader, options);
			reader.Read();
			TValue value = JsonSerializer.Deserialize<TValue>(ref reader, options);
			reader.Read();
			if (reader.TokenType != JsonTokenType.EndArray)
			{
				throw new JsonException("Expected array end");
			}
			return new KeyValuePair<TKey, TValue>(key, value);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x0003B25B File Offset: 0x0003945B
		public override void Write(Utf8JsonWriter writer, [Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<TKey, TValue> value, JsonSerializerOptions options)
		{
			writer.WriteStartArray();
			JsonSerializer.Serialize<TKey>(writer, value.Key, options);
			JsonSerializer.Serialize<TValue>(writer, value.Value, options);
			writer.WriteEndArray();
		}
	}
}
