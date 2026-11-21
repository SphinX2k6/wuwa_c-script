using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FC RID: 2556
	public class EFollowDecorationTypeJsonConverter : JsonConverter<EFollowDecorationType>
	{
		// Token: 0x06003902 RID: 14594 RVA: 0x000938A4 File Offset: 0x00091AA4
		public override EFollowDecorationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFollowDecorationType.Chair;
			}
			return EFollowDecorationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x000938C8 File Offset: 0x00091AC8
		public override void Write(Utf8JsonWriter writer, EFollowDecorationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
