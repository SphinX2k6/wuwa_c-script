using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A6 RID: 8870
	public class EAudioEnableTypeJsonConverter : JsonConverter<EAudioEnableType>
	{
		// Token: 0x0600C26B RID: 49771 RVA: 0x001C67D8 File Offset: 0x001C49D8
		public override EAudioEnableType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioEnableType.Enable;
			}
			return EAudioEnableTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x001C67FC File Offset: 0x001C49FC
		public override void Write(Utf8JsonWriter writer, EAudioEnableType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
