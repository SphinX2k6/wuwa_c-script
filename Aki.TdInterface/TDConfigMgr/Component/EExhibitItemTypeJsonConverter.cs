using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093D RID: 2365
	public class EExhibitItemTypeJsonConverter : JsonConverter<EExhibitItemType>
	{
		// Token: 0x06003545 RID: 13637 RVA: 0x0008B080 File Offset: 0x00089280
		public override EExhibitItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExhibitItemType.Phantom;
			}
			return EExhibitItemTypeExtensions.FromString(@string);
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x0008B0A4 File Offset: 0x000892A4
		public override void Write(Utf8JsonWriter writer, EExhibitItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
