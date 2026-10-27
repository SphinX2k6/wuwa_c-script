using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002416 RID: 9238
	public class EShowTalkCameraMotionTypeJsonConverter : JsonConverter<EShowTalkCameraMotionType>
	{
		// Token: 0x0600C8E3 RID: 51427 RVA: 0x001D639C File Offset: 0x001D459C
		public override EShowTalkCameraMotionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EShowTalkCameraMotionType.Preset;
			}
			return EShowTalkCameraMotionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x001D63C0 File Offset: 0x001D45C0
		public override void Write(Utf8JsonWriter writer, EShowTalkCameraMotionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
