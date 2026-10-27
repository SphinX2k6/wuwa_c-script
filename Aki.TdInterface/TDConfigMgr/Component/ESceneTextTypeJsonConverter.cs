using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A07 RID: 2567
	public class ESceneTextTypeJsonConverter : JsonConverter<ESceneTextType>
	{
		// Token: 0x060038D2 RID: 14546 RVA: 0x00092E80 File Offset: 0x00091080
		public override ESceneTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneTextType.SubtitleWithVoice;
			}
			return ESceneTextTypeExtensions.FromString(@string);
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00092EA4 File Offset: 0x000910A4
		public override void Write(Utf8JsonWriter writer, ESceneTextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
