using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B7 RID: 9655
	public class EGamepadShakeAttenuationFunctionJsonConverter : JsonConverter<EGamepadShakeAttenuationFunction>
	{
		// Token: 0x0600D113 RID: 53523 RVA: 0x001E4A88 File Offset: 0x001E2C88
		public override EGamepadShakeAttenuationFunction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGamepadShakeAttenuationFunction.Linear;
			}
			return EGamepadShakeAttenuationFunctionExtensions.FromString(@string);
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x001E4AAC File Offset: 0x001E2CAC
		public override void Write(Utf8JsonWriter writer, EGamepadShakeAttenuationFunction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
