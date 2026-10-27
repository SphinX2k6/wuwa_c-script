using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245E RID: 9310
	public class ETalkOptionPreConditionTypeJsonConverter : JsonConverter<ETalkOptionPreConditionType>
	{
		// Token: 0x0600CA27 RID: 51751 RVA: 0x001DBE2C File Offset: 0x001DA02C
		public override ETalkOptionPreConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkOptionPreConditionType.PreOption;
			}
			return ETalkOptionPreConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x001DBE50 File Offset: 0x001DA050
		public override void Write(Utf8JsonWriter writer, ETalkOptionPreConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
