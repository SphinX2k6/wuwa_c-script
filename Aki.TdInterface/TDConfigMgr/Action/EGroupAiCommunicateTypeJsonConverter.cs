using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234C RID: 9036
	public class EGroupAiCommunicateTypeJsonConverter : JsonConverter<EGroupAiCommunicateType>
	{
		// Token: 0x0600C556 RID: 50518 RVA: 0x001CCDEC File Offset: 0x001CAFEC
		public override EGroupAiCommunicateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiCommunicateType.AddTag;
			}
			return EGroupAiCommunicateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C557 RID: 50519 RVA: 0x001CCE10 File Offset: 0x001CB010
		public override void Write(Utf8JsonWriter writer, EGroupAiCommunicateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
