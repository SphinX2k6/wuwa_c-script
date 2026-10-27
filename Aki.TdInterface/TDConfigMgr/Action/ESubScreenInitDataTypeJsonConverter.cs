using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002434 RID: 9268
	public class ESubScreenInitDataTypeJsonConverter : JsonConverter<ESubScreenInitDataType>
	{
		// Token: 0x0600C96A RID: 51562 RVA: 0x001D7E04 File Offset: 0x001D6004
		public override ESubScreenInitDataType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenInitDataType.Preset;
			}
			return ESubScreenInitDataTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x001D7E28 File Offset: 0x001D6028
		public override void Write(Utf8JsonWriter writer, ESubScreenInitDataType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
