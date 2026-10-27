using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A21 RID: 2593
	public class EStateRepPerfTypeJsonConverter : JsonConverter<EStateRepPerfType>
	{
		// Token: 0x06003947 RID: 14663 RVA: 0x00094094 File Offset: 0x00092294
		public override EStateRepPerfType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStateRepPerfType.SkillId;
			}
			return EStateRepPerfTypeExtensions.FromString(@string);
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x000940B8 File Offset: 0x000922B8
		public override void Write(Utf8JsonWriter writer, EStateRepPerfType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
