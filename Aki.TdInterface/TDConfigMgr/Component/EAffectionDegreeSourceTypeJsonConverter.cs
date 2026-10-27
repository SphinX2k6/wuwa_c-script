using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008ED RID: 2285
	public class EAffectionDegreeSourceTypeJsonConverter : JsonConverter<EAffectionDegreeSourceType>
	{
		// Token: 0x060033DD RID: 13277 RVA: 0x00084A3C File Offset: 0x00082C3C
		public override EAffectionDegreeSourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAffectionDegreeSourceType.CyberpunkCollaboration;
			}
			return EAffectionDegreeSourceTypeExtensions.FromString(@string);
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00084A60 File Offset: 0x00082C60
		public override void Write(Utf8JsonWriter writer, EAffectionDegreeSourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
