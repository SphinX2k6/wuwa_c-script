using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CA RID: 9162
	public class EPhotographCameraTransformJsonConverter : JsonConverter<EPhotographCameraTransform>
	{
		// Token: 0x0600C78D RID: 51085 RVA: 0x001D3620 File Offset: 0x001D1820
		public override EPhotographCameraTransform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhotographCameraTransform.Absolute;
			}
			return EPhotographCameraTransformExtensions.FromString(@string);
		}

		// Token: 0x0600C78E RID: 51086 RVA: 0x001D3644 File Offset: 0x001D1844
		public override void Write(Utf8JsonWriter writer, EPhotographCameraTransform value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
