using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AF RID: 4783
	public class ETrackViewModeJsonConverter : JsonConverter<ETrackViewMode>
	{
		// Token: 0x06006BBC RID: 27580 RVA: 0x0010334C File Offset: 0x0010154C
		public override ETrackViewMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackViewMode.All;
			}
			return ETrackViewModeExtensions.FromString(@string);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00103370 File Offset: 0x00101570
		public override void Write(Utf8JsonWriter writer, ETrackViewMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
