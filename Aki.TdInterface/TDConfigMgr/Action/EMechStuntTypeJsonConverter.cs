using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002382 RID: 9090
	public class EMechStuntTypeJsonConverter : JsonConverter<EMechStuntType>
	{
		// Token: 0x0600C649 RID: 50761 RVA: 0x001D0C60 File Offset: 0x001CEE60
		public override EMechStuntType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechStuntType.Dive;
			}
			return EMechStuntTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x001D0C84 File Offset: 0x001CEE84
		public override void Write(Utf8JsonWriter writer, EMechStuntType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
