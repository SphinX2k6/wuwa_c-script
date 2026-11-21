using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026DF RID: 9951
	public class ESummonEntityTypeJsonConverter : JsonConverter<ESummonEntityType>
	{
		// Token: 0x0600D647 RID: 54855 RVA: 0x001F22B0 File Offset: 0x001F04B0
		public override ESummonEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESummonEntityType.Vehicle;
			}
			return ESummonEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D648 RID: 54856 RVA: 0x001F22D4 File Offset: 0x001F04D4
		public override void Write(Utf8JsonWriter writer, ESummonEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
