using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F5 RID: 5109
	public class ETrackViewModeJsonConverter : JsonConverter<ETrackViewMode>
	{
		// Token: 0x0600722A RID: 29226 RVA: 0x00111314 File Offset: 0x0010F514
		public override ETrackViewMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackViewMode.All;
			}
			return ETrackViewModeExtensions.FromString(@string);
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00111338 File Offset: 0x0010F538
		public override void Write(Utf8JsonWriter writer, ETrackViewMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
