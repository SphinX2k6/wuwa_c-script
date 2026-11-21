using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000228 RID: 552
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ResFileInfoConverter : JsonConverter<ResFileInfo>
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x0005751C File Offset: 0x0005571C
		public override ResFileInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return new ResFileInfo();
			}
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Expected StartObject, found ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonTokenType>(reader.TokenType);
				throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			ResFileInfo resFileInfo = new ResFileInfo();
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					return resFileInfo;
				}
				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Expected PropertyName, found ");
					defaultInterpolatedStringHandler.AppendFormatted<JsonTokenType>(reader.TokenType);
					throw new JsonException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				string @string = reader.GetString();
				reader.Read();
				if (!(@string == "Name"))
				{
					if (!(@string == "Size"))
					{
						if (!(@string == "Hash"))
						{
							reader.Skip();
						}
						else
						{
							resFileInfo.Hash = ((reader.TokenType == JsonTokenType.Null) ? "" : (reader.GetString() ?? ""));
						}
					}
					else if (reader.TokenType == JsonTokenType.Number)
					{
						resFileInfo.Size = reader.GetInt64();
					}
					else if (reader.TokenType == JsonTokenType.String)
					{
						string string2 = reader.GetString();
						if (!string.IsNullOrEmpty(string2) && string2.StartsWith("__kr_long__"))
						{
							long size;
							long.TryParse(string2.AsSpan("__kr_long__".Length), out size);
							resFileInfo.Size = size;
						}
					}
					else
					{
						resFileInfo.Size = 0L;
					}
				}
				else
				{
					resFileInfo.Name = ((reader.TokenType == JsonTokenType.Null) ? "" : (reader.GetString() ?? ""));
				}
			}
			throw new JsonException("Unexpected end of JSON input");
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000576D4 File Offset: 0x000558D4
		public override void Write(Utf8JsonWriter writer, ResFileInfo value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("Name");
			writer.WriteStringValue(value.Name ?? "");
			writer.WritePropertyName("Size");
			writer.WriteStringValue("__kr_long__" + value.Size);
			writer.WritePropertyName("Hash");
			writer.WriteStringValue(value.Hash ?? "");
			writer.WriteEndObject();
		}
	}
}
