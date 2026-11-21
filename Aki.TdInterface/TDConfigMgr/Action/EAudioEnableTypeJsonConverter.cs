using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002515 RID: 9493
	public class EAudioEnableTypeJsonConverter : JsonConverter<EAudioEnableType>
	{
		// Token: 0x0600CE3A RID: 52794 RVA: 0x001DE5E0 File Offset: 0x001DC7E0
		public override EAudioEnableType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioEnableType.Enable;
			}
			return EAudioEnableTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x001DE604 File Offset: 0x001DC804
		public override void Write(Utf8JsonWriter writer, EAudioEnableType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
