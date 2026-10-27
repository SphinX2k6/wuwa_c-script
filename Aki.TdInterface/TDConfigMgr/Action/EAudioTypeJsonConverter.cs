using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A8 RID: 8872
	public class EAudioTypeJsonConverter : JsonConverter<EAudioType>
	{
		// Token: 0x0600C274 RID: 49780 RVA: 0x001C68B4 File Offset: 0x001C4AB4
		public override EAudioType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioType.RoleSceneVoice;
			}
			return EAudioTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C275 RID: 49781 RVA: 0x001C68D8 File Offset: 0x001C4AD8
		public override void Write(Utf8JsonWriter writer, EAudioType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
