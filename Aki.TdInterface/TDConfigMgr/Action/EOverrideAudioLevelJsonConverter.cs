using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BC RID: 9148
	public class EOverrideAudioLevelJsonConverter : JsonConverter<EOverrideAudioLevel>
	{
		// Token: 0x0600C74E RID: 51022 RVA: 0x001D2DD8 File Offset: 0x001D0FD8
		public override EOverrideAudioLevel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOverrideAudioLevel.LevelA;
			}
			return EOverrideAudioLevelExtensions.FromString(@string);
		}

		// Token: 0x0600C74F RID: 51023 RVA: 0x001D2DFC File Offset: 0x001D0FFC
		public override void Write(Utf8JsonWriter writer, EOverrideAudioLevel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
