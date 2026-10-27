using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094D RID: 2381
	public class EFollowDecorationTypeJsonConverter : JsonConverter<EFollowDecorationType>
	{
		// Token: 0x0600358D RID: 13709 RVA: 0x0008BBEC File Offset: 0x00089DEC
		public override EFollowDecorationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFollowDecorationType.Chair;
			}
			return EFollowDecorationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0008BC10 File Offset: 0x00089E10
		public override void Write(Utf8JsonWriter writer, EFollowDecorationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
