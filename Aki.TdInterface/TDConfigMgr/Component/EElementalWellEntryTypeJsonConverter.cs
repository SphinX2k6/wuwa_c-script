using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DE RID: 2526
	public class EElementalWellEntryTypeJsonConverter : JsonConverter<EElementalWellEntryType>
	{
		// Token: 0x0600387B RID: 14459 RVA: 0x00092494 File Offset: 0x00090694
		public override EElementalWellEntryType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalWellEntryType.Entry;
			}
			return EElementalWellEntryTypeExtensions.FromString(@string);
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x000924B8 File Offset: 0x000906B8
		public override void Write(Utf8JsonWriter writer, EElementalWellEntryType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
