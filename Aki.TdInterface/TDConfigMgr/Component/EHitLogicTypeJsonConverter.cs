using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A16 RID: 2582
	public class EHitLogicTypeJsonConverter : JsonConverter<EHitLogicType>
	{
		// Token: 0x06003977 RID: 14711 RVA: 0x000948B8 File Offset: 0x00092AB8
		public override EHitLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHitLogicType.ChangeNextState;
			}
			return EHitLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x000948DC File Offset: 0x00092ADC
		public override void Write(Utf8JsonWriter writer, EHitLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
