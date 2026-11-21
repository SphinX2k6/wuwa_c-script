using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE6 RID: 2790
	public class EStateRepPerfTypeJsonConverter : JsonConverter<EStateRepPerfType>
	{
		// Token: 0x06003D1F RID: 15647 RVA: 0x0009C9C8 File Offset: 0x0009ABC8
		public override EStateRepPerfType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStateRepPerfType.SkillId;
			}
			return EStateRepPerfTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x0009C9EC File Offset: 0x0009ABEC
		public override void Write(Utf8JsonWriter writer, EStateRepPerfType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
