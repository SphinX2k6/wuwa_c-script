using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B5 RID: 9909
	public class EShowTalkCameraMotionTypeJsonConverter : JsonConverter<EShowTalkCameraMotionType>
	{
		// Token: 0x0600D58A RID: 54666 RVA: 0x001EFF98 File Offset: 0x001EE198
		public override EShowTalkCameraMotionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EShowTalkCameraMotionType.Preset;
			}
			return EShowTalkCameraMotionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x001EFFBC File Offset: 0x001EE1BC
		public override void Write(Utf8JsonWriter writer, EShowTalkCameraMotionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
