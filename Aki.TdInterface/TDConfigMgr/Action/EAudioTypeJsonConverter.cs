using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002517 RID: 9495
	public class EAudioTypeJsonConverter : JsonConverter<EAudioType>
	{
		// Token: 0x0600CE43 RID: 52803 RVA: 0x001DE6BC File Offset: 0x001DC8BC
		public override EAudioType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioType.RoleSceneVoice;
			}
			return EAudioTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE44 RID: 52804 RVA: 0x001DE6E0 File Offset: 0x001DC8E0
		public override void Write(Utf8JsonWriter writer, EAudioType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
