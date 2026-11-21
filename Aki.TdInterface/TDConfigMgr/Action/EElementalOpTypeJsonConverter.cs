using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002587 RID: 9607
	public class EElementalOpTypeJsonConverter : JsonConverter<EElementalOpType>
	{
		// Token: 0x0600D03B RID: 53307 RVA: 0x001E2B44 File Offset: 0x001E0D44
		public override EElementalOpType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalOpType.Grant;
			}
			return EElementalOpTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D03C RID: 53308 RVA: 0x001E2B68 File Offset: 0x001E0D68
		public override void Write(Utf8JsonWriter writer, EElementalOpType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
