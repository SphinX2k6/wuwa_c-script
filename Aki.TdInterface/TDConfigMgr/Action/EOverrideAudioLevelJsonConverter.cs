using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200264F RID: 9807
	public class EOverrideAudioLevelJsonConverter : JsonConverter<EOverrideAudioLevel>
	{
		// Token: 0x0600D3BF RID: 54207 RVA: 0x001EC394 File Offset: 0x001EA594
		public override EOverrideAudioLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOverrideAudioLevel.LevelA;
			}
			return EOverrideAudioLevelExtensions.FromString(@string);
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x001EC3B8 File Offset: 0x001EA5B8
		public override void Write(Utf8JsonWriter writer, EOverrideAudioLevel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
