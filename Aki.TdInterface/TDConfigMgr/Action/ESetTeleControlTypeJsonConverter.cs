using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002410 RID: 9232
	public class ESetTeleControlTypeJsonConverter : JsonConverter<ESetTeleControlType>
	{
		// Token: 0x0600C8C8 RID: 51400 RVA: 0x001D6060 File Offset: 0x001D4260
		public override ESetTeleControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetTeleControlType.OpenGravity;
			}
			return ESetTeleControlTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8C9 RID: 51401 RVA: 0x001D6084 File Offset: 0x001D4284
		public override void Write(Utf8JsonWriter writer, ESetTeleControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
