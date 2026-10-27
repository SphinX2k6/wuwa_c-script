using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002324 RID: 8996
	public class EEntityControlCameraModeJsonConverter : JsonConverter<EEntityControlCameraMode>
	{
		// Token: 0x0600C4A2 RID: 50338 RVA: 0x001CB290 File Offset: 0x001C9490
		public override EEntityControlCameraMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityControlCameraMode.UseSequenceCamera;
			}
			return EEntityControlCameraModeExtensions.FromString(@string);
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x001CB2B4 File Offset: 0x001C94B4
		public override void Write(Utf8JsonWriter writer, EEntityControlCameraMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
