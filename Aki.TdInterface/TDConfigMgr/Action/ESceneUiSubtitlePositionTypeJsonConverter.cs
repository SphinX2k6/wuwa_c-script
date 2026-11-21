using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002699 RID: 9881
	public class ESceneUiSubtitlePositionTypeJsonConverter : JsonConverter<ESceneUiSubtitlePositionType>
	{
		// Token: 0x0600D50C RID: 54540 RVA: 0x001EF0A0 File Offset: 0x001ED2A0
		public override ESceneUiSubtitlePositionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneUiSubtitlePositionType.Position;
			}
			return ESceneUiSubtitlePositionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x001EF0C4 File Offset: 0x001ED2C4
		public override void Write(Utf8JsonWriter writer, ESceneUiSubtitlePositionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
