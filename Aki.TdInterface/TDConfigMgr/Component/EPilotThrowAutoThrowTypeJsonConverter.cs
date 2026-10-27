using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D3 RID: 2515
	public class EPilotThrowAutoThrowTypeJsonConverter : JsonConverter<EPilotThrowAutoThrowType>
	{
		// Token: 0x060037E8 RID: 14312 RVA: 0x00091270 File Offset: 0x0008F470
		public override EPilotThrowAutoThrowType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPilotThrowAutoThrowType.LowAngle;
			}
			return EPilotThrowAutoThrowTypeExtensions.FromString(@string);
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x00091294 File Offset: 0x0008F494
		public override void Write(Utf8JsonWriter writer, EPilotThrowAutoThrowType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
