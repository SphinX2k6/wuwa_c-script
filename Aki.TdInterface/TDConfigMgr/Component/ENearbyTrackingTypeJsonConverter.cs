using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AD RID: 2477
	public class ENearbyTrackingTypeJsonConverter : JsonConverter<ENearbyTrackingType>
	{
		// Token: 0x0600373D RID: 14141 RVA: 0x0008FB74 File Offset: 0x0008DD74
		public override ENearbyTrackingType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENearbyTrackingType.Icon;
			}
			return ENearbyTrackingTypeExtensions.FromString(@string);
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x0008FB98 File Offset: 0x0008DD98
		public override void Write(Utf8JsonWriter writer, ENearbyTrackingType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
