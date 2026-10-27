using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EA RID: 8938
	public class ECollectibleMarkerTypeJsonConverter : JsonConverter<ECollectibleMarkerType>
	{
		// Token: 0x0600C39D RID: 50077 RVA: 0x001C933C File Offset: 0x001C753C
		public override ECollectibleMarkerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECollectibleMarkerType.Placeholder;
			}
			return ECollectibleMarkerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x001C9360 File Offset: 0x001C7560
		public override void Write(Utf8JsonWriter writer, ECollectibleMarkerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
