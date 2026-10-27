using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000931 RID: 2353
	public class EElementalWellEntryTypeJsonConverter : JsonConverter<EElementalWellEntryType>
	{
		// Token: 0x0600350F RID: 13583 RVA: 0x0008A914 File Offset: 0x00088B14
		public override EElementalWellEntryType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalWellEntryType.Entry;
			}
			return EElementalWellEntryTypeExtensions.FromString(@string);
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x0008A938 File Offset: 0x00088B38
		public override void Write(Utf8JsonWriter writer, EElementalWellEntryType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
