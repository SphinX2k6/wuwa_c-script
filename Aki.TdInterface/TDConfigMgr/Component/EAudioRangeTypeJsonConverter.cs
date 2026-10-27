using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FD RID: 2301
	public class EAudioRangeTypeJsonConverter : JsonConverter<EAudioRangeType>
	{
		// Token: 0x06003425 RID: 13349 RVA: 0x00085444 File Offset: 0x00083644
		public override EAudioRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioRangeType.SceneActorRefComp;
			}
			return EAudioRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00085468 File Offset: 0x00083668
		public override void Write(Utf8JsonWriter writer, EAudioRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
