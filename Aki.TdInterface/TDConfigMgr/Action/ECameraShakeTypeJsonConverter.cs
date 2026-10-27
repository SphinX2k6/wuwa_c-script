using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CE RID: 8910
	public class ECameraShakeTypeJsonConverter : JsonConverter<ECameraShakeType>
	{
		// Token: 0x0600C31F RID: 49951 RVA: 0x001C83C8 File Offset: 0x001C65C8
		public override ECameraShakeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECameraShakeType.Constant;
			}
			return ECameraShakeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C320 RID: 49952 RVA: 0x001C83EC File Offset: 0x001C65EC
		public override void Write(Utf8JsonWriter writer, ECameraShakeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
