using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F9 RID: 2297
	public class EAttachTypeJsonConverter : JsonConverter<EAttachType>
	{
		// Token: 0x06003413 RID: 13331 RVA: 0x000851D8 File Offset: 0x000833D8
		public override EAttachType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachType.Actor;
			}
			return EAttachTypeExtensions.FromString(@string);
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000851FC File Offset: 0x000833FC
		public override void Write(Utf8JsonWriter writer, EAttachType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
