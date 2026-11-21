using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025BB RID: 9659
	public class EGamepadShakeTypeJsonConverter : JsonConverter<EGamepadShakeType>
	{
		// Token: 0x0600D125 RID: 53541 RVA: 0x001E4CEC File Offset: 0x001E2EEC
		public override EGamepadShakeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGamepadShakeType.Onetime;
			}
			return EGamepadShakeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D126 RID: 53542 RVA: 0x001E4D10 File Offset: 0x001E2F10
		public override void Write(Utf8JsonWriter writer, EGamepadShakeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
