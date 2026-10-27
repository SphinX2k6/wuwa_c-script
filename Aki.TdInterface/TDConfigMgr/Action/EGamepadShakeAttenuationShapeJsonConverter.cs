using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002346 RID: 9030
	public class EGamepadShakeAttenuationShapeJsonConverter : JsonConverter<EGamepadShakeAttenuationShape>
	{
		// Token: 0x0600C53B RID: 50491 RVA: 0x001CC998 File Offset: 0x001CAB98
		public override EGamepadShakeAttenuationShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGamepadShakeAttenuationShape.Sphere;
			}
			return EGamepadShakeAttenuationShapeExtensions.FromString(@string);
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x001CC9BC File Offset: 0x001CABBC
		public override void Write(Utf8JsonWriter writer, EGamepadShakeAttenuationShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
