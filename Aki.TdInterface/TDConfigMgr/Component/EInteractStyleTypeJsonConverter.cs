using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097B RID: 2427
	public class EInteractStyleTypeJsonConverter : JsonConverter<EInteractStyleType>
	{
		// Token: 0x0600365C RID: 13916 RVA: 0x0008DB90 File Offset: 0x0008BD90
		public override EInteractStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractStyleType.Panorama;
			}
			return EInteractStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0008DBB4 File Offset: 0x0008BDB4
		public override void Write(Utf8JsonWriter writer, EInteractStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
