using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002318 RID: 8984
	public class EElementalOpTypeJsonConverter : JsonConverter<EElementalOpType>
	{
		// Token: 0x0600C46C RID: 50284 RVA: 0x001CAC7C File Offset: 0x001C8E7C
		public override EElementalOpType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalOpType.Grant;
			}
			return EElementalOpTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x001CACA0 File Offset: 0x001C8EA0
		public override void Write(Utf8JsonWriter writer, EElementalOpType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
