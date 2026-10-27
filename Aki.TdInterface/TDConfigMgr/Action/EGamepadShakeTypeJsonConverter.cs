using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002348 RID: 9032
	public class EGamepadShakeTypeJsonConverter : JsonConverter<EGamepadShakeType>
	{
		// Token: 0x0600C544 RID: 50500 RVA: 0x001CCB20 File Offset: 0x001CAD20
		public override EGamepadShakeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGamepadShakeType.Onetime;
			}
			return EGamepadShakeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C545 RID: 50501 RVA: 0x001CCB44 File Offset: 0x001CAD44
		public override void Write(Utf8JsonWriter writer, EGamepadShakeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
