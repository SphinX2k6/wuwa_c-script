using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126D RID: 4717
	public class EProgressBarLeftTypeJsonConverter : JsonConverter<EProgressBarLeftType>
	{
		// Token: 0x06006A93 RID: 27283 RVA: 0x000FF7CC File Offset: 0x000FD9CC
		public override EProgressBarLeftType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProgressBarLeftType.UseCount;
			}
			return EProgressBarLeftTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x000FF7F0 File Offset: 0x000FD9F0
		public override void Write(Utf8JsonWriter writer, EProgressBarLeftType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
