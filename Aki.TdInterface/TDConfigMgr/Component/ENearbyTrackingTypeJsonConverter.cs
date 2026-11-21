using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A62 RID: 2658
	public class ENearbyTrackingTypeJsonConverter : JsonConverter<ENearbyTrackingType>
	{
		// Token: 0x06003ACD RID: 15053 RVA: 0x00097C68 File Offset: 0x00095E68
		public override ENearbyTrackingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENearbyTrackingType.Icon;
			}
			return ENearbyTrackingTypeExtensions.FromString(@string);
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x00097C8C File Offset: 0x00095E8C
		public override void Write(Utf8JsonWriter writer, ENearbyTrackingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
