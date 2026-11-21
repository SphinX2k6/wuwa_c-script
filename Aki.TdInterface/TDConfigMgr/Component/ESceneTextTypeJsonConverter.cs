using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ACC RID: 2764
	public class ESceneTextTypeJsonConverter : JsonConverter<ESceneTextType>
	{
		// Token: 0x06003CAA RID: 15530 RVA: 0x0009B770 File Offset: 0x00099970
		public override ESceneTextType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESceneTextType.SubtitleWithVoice;
			}
			return ESceneTextTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x0009B794 File Offset: 0x00099994
		public override void Write(Utf8JsonWriter writer, ESceneTextType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
