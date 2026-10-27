using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Aki.Define.Serialize
{
	// Token: 0x02000028 RID: 40
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonConverterUtil
	{
		// Token: 0x060000FF RID: 255 RVA: 0x0000B444 File Offset: 0x00009644
		public static string GetPropertyValue(Utf8JsonReader reader, string propName)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new JsonException("该Json结点必须是对象: " + propName);
			}
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.GetString() != propName)
				{
					reader.Skip();
				}
				else
				{
					reader.Read();
					if (reader.TokenType != JsonTokenType.String)
					{
						throw new JsonException();
					}
					return reader.GetString();
				}
			}
			throw new JsonException("找不到属性值: " + propName);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000B4C8 File Offset: 0x000096C8
		[return: Nullable(2)]
		public static string GetPropertyValueEx(Utf8JsonReader reader, string propName)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				return null;
			}
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.GetString() != propName)
				{
					reader.Skip();
				}
				else
				{
					reader.Read();
					if (reader.TokenType != JsonTokenType.String)
					{
						return null;
					}
					return reader.GetString();
				}
			}
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000B52C File Offset: 0x0000972C
		public static int? GetPropertyValueInt(Utf8JsonReader reader, string propName)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				return null;
			}
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.GetString() != propName)
				{
					reader.Skip();
				}
				else
				{
					reader.Read();
					if (reader.TokenType != JsonTokenType.Number)
					{
						return null;
					}
					return new int?(reader.GetInt32());
				}
			}
			return null;
		}
	}
}
