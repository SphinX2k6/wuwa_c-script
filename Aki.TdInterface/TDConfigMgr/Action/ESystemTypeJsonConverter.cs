using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244E RID: 9294
	public class ESystemTypeJsonConverter : JsonConverter<ESystemType>
	{
		// Token: 0x0600C9DF RID: 51679 RVA: 0x001DAEF0 File Offset: 0x001D90F0
		public override ESystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemType.Shop;
			}
			return ESystemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9E0 RID: 51680 RVA: 0x001DAF14 File Offset: 0x001D9114
		public override void Write(Utf8JsonWriter writer, ESystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
