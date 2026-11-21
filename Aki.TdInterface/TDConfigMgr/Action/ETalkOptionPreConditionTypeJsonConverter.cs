using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026FF RID: 9983
	public class ETalkOptionPreConditionTypeJsonConverter : JsonConverter<ETalkOptionPreConditionType>
	{
		// Token: 0x0600D6D7 RID: 54999 RVA: 0x001F5EE0 File Offset: 0x001F40E0
		public override ETalkOptionPreConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkOptionPreConditionType.PreOption;
			}
			return ETalkOptionPreConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6D8 RID: 55000 RVA: 0x001F5F04 File Offset: 0x001F4104
		public override void Write(Utf8JsonWriter writer, ETalkOptionPreConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
