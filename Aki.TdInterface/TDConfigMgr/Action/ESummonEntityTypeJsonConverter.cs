using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243E RID: 9278
	public class ESummonEntityTypeJsonConverter : JsonConverter<ESummonEntityType>
	{
		// Token: 0x0600C997 RID: 51607 RVA: 0x001D83E8 File Offset: 0x001D65E8
		public override ESummonEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESummonEntityType.Vehicle;
			}
			return ESummonEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x001D840C File Offset: 0x001D660C
		public override void Write(Utf8JsonWriter writer, ESummonEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
