using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094F RID: 2383
	public class EFoxJumpInteractPointRelationTypeJsonConverter : JsonConverter<EFoxJumpInteractPointRelationType>
	{
		// Token: 0x06003596 RID: 13718 RVA: 0x0008BD00 File Offset: 0x00089F00
		public override EFoxJumpInteractPointRelationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFoxJumpInteractPointRelationType.ThisEntity;
			}
			return EFoxJumpInteractPointRelationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x0008BD24 File Offset: 0x00089F24
		public override void Write(Utf8JsonWriter writer, EFoxJumpInteractPointRelationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
