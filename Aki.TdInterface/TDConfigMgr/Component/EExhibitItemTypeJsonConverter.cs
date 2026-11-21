using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EA RID: 2538
	public class EExhibitItemTypeJsonConverter : JsonConverter<EExhibitItemType>
	{
		// Token: 0x060038B1 RID: 14513 RVA: 0x00092C00 File Offset: 0x00090E00
		public override EExhibitItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExhibitItemType.Phantom;
			}
			return EExhibitItemTypeExtensions.FromString(@string);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00092C24 File Offset: 0x00090E24
		public override void Write(Utf8JsonWriter writer, EExhibitItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
