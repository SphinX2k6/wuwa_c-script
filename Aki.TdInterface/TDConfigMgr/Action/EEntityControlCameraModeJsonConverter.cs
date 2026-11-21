using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002593 RID: 9619
	public class EEntityControlCameraModeJsonConverter : JsonConverter<EEntityControlCameraMode>
	{
		// Token: 0x0600D071 RID: 53361 RVA: 0x001E3158 File Offset: 0x001E1358
		public override EEntityControlCameraMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityControlCameraMode.UseSequenceCamera;
			}
			return EEntityControlCameraModeExtensions.FromString(@string);
		}

		// Token: 0x0600D072 RID: 53362 RVA: 0x001E317C File Offset: 0x001E137C
		public override void Write(Utf8JsonWriter writer, EEntityControlCameraMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
