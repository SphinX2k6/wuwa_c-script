using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AD RID: 4781
	public class ETrackTypeJsonConverter : JsonConverter<ETrackType>
	{
		// Token: 0x06006BB3 RID: 27571 RVA: 0x00103238 File Offset: 0x00101438
		public override ETrackType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackType.Locations;
			}
			return ETrackTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BB4 RID: 27572 RVA: 0x0010325C File Offset: 0x0010145C
		public override void Write(Utf8JsonWriter writer, ETrackType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
