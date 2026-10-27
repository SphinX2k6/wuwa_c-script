using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002344 RID: 9028
	public class EGamepadShakeAttenuationFunctionJsonConverter : JsonConverter<EGamepadShakeAttenuationFunction>
	{
		// Token: 0x0600C532 RID: 50482 RVA: 0x001CC8BC File Offset: 0x001CAABC
		public override EGamepadShakeAttenuationFunction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGamepadShakeAttenuationFunction.Linear;
			}
			return EGamepadShakeAttenuationFunctionExtensions.FromString(@string);
		}

		// Token: 0x0600C533 RID: 50483 RVA: 0x001CC8E0 File Offset: 0x001CAAE0
		public override void Write(Utf8JsonWriter writer, EGamepadShakeAttenuationFunction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
