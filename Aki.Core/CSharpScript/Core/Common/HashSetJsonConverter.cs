using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000175 RID: 373
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	public class HashSetJsonConverter<[Nullable(2)] T> : JsonConverter<HashSet<T>>
	{
		// Token: 0x06000CFB RID: 3323 RVA: 0x0003BF54 File Offset: 0x0003A154
		public override HashSet<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartArray)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Expected StartArray, got ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonTokenType>(reader.TokenType);
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			HashSet<T> hashSet = new HashSet<T>();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
			{
				T t = JsonSerializer.Deserialize<T>(ref reader, options);
				if (t != null)
				{
					hashSet.Add(t);
				}
			}
			return hashSet;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0003BFCC File Offset: 0x0003A1CC
		public override void Write(Utf8JsonWriter writer, HashSet<T> value, JsonSerializerOptions options)
		{
			T[] array = new T[value.Count];
			value.CopyTo(array);
			JsonSerializer.Serialize<T[]>(writer, array, options);
		}
	}
}
