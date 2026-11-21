using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A6 RID: 2470
	public class EAudioRangeTypeJsonConverter : JsonConverter<EAudioRangeType>
	{
		// Token: 0x0600377F RID: 14207 RVA: 0x0008CCB4 File Offset: 0x0008AEB4
		public override EAudioRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioRangeType.SceneActorRefComp;
			}
			return EAudioRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x0008CCD8 File Offset: 0x0008AED8
		public override void Write(Utf8JsonWriter writer, EAudioRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
