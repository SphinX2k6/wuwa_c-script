using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A00 RID: 2560
	public class EFoxJumpInteractPointRelationTypeJsonConverter : JsonConverter<EFoxJumpInteractPointRelationType>
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x00093ACC File Offset: 0x00091CCC
		public override EFoxJumpInteractPointRelationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFoxJumpInteractPointRelationType.ThisEntity;
			}
			return EFoxJumpInteractPointRelationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00093AF0 File Offset: 0x00091CF0
		public override void Write(Utf8JsonWriter writer, EFoxJumpInteractPointRelationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
