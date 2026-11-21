using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200269D RID: 9885
	public class ESceneUiSubtitleTextTypeJsonConverter : JsonConverter<ESceneUiSubtitleTextType>
	{
		// Token: 0x0600D51E RID: 54558 RVA: 0x001EF2C8 File Offset: 0x001ED4C8
		public override ESceneUiSubtitleTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneUiSubtitleTextType.Flow;
			}
			return ESceneUiSubtitleTextTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x001EF2EC File Offset: 0x001ED4EC
		public override void Write(Utf8JsonWriter writer, ESceneUiSubtitleTextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
