using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Core.Common
{
	// Token: 0x02000173 RID: 371
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IntMapStringConverter : JsonConverter<Dictionary<int, int>>
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003BDDC File Offset: 0x00039FDC
		public override Dictionary<int, int> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			if (reader.TokenType != JsonTokenType.String)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Expected String token, got ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonTokenType>(reader.TokenType);
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			string @string = reader.GetString();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (string.IsNullOrEmpty(@string))
			{
				return dictionary;
			}
			string[] array = @string.Replace("[", "").Replace("]", "").Split(',', StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(':', StringSplitOptions.None);
				if (array2.Length == 2)
				{
					dictionary[int.Parse(array2[0])] = int.Parse(array2[1]);
				}
			}
			return dictionary;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0003BEAD File Offset: 0x0003A0AD
		public override void Write(Utf8JsonWriter writer, Dictionary<int, int> value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<Dictionary<int, int>>(writer, value, options);
		}
	}
}
