using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA2 RID: 2722
	public class EPortalTypeJsonConverter : JsonConverter<EPortalType>
	{
		// Token: 0x06003BED RID: 15341 RVA: 0x0009A068 File Offset: 0x00098268
		public override EPortalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPortalType.Static;
			}
			return EPortalTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BEE RID: 15342 RVA: 0x0009A08C File Offset: 0x0009828C
		public override void Write(Utf8JsonWriter writer, EPortalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
