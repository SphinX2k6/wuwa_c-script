using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200265F RID: 9823
	public class EPhotographCameraTransformJsonConverter : JsonConverter<EPhotographCameraTransform>
	{
		// Token: 0x0600D407 RID: 54279 RVA: 0x001ECCB8 File Offset: 0x001EAEB8
		public override EPhotographCameraTransform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhotographCameraTransform.Absolute;
			}
			return EPhotographCameraTransformExtensions.FromString(@string);
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x001ECCDC File Offset: 0x001EAEDC
		public override void Write(Utf8JsonWriter writer, EPhotographCameraTransform value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
