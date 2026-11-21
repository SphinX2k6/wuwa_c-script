using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Aki.Define.Serialize
{
	// Token: 0x02000029 RID: 41
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonConverterUtil
	{
		// Token: 0x0600016C RID: 364 RVA: 0x0000EC10 File Offset: 0x0000CE10
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

		// Token: 0x0600016D RID: 365 RVA: 0x0000EC94 File Offset: 0x0000CE94
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

		// Token: 0x0600016E RID: 366 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
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
