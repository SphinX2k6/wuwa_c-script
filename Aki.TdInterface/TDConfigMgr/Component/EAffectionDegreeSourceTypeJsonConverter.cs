using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000992 RID: 2450
	public class EAffectionDegreeSourceTypeJsonConverter : JsonConverter<EAffectionDegreeSourceType>
	{
		// Token: 0x06003725 RID: 14117 RVA: 0x0008C078 File Offset: 0x0008A278
		public override EAffectionDegreeSourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAffectionDegreeSourceType.CyberpunkCollaboration;
			}
			return EAffectionDegreeSourceTypeExtensions.FromString(@string);
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x0008C09C File Offset: 0x0008A29C
		public override void Write(Utf8JsonWriter writer, EAffectionDegreeSourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
