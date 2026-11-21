using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B9 RID: 9657
	public class EGamepadShakeAttenuationShapeJsonConverter : JsonConverter<EGamepadShakeAttenuationShape>
	{
		// Token: 0x0600D11C RID: 53532 RVA: 0x001E4B64 File Offset: 0x001E2D64
		public override EGamepadShakeAttenuationShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGamepadShakeAttenuationShape.Sphere;
			}
			return EGamepadShakeAttenuationShapeExtensions.FromString(@string);
		}

		// Token: 0x0600D11D RID: 53533 RVA: 0x001E4B88 File Offset: 0x001E2D88
		public override void Write(Utf8JsonWriter writer, EGamepadShakeAttenuationShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
