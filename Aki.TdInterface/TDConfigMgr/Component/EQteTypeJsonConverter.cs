using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E7 RID: 2535
	public class EQteTypeJsonConverter : JsonConverter<EQteType>
	{
		// Token: 0x06003842 RID: 14402 RVA: 0x00091D08 File Offset: 0x0008FF08
		public override EQteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQteType.SingleBtn;
			}
			return EQteTypeExtensions.FromString(@string);
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00091D2C File Offset: 0x0008FF2C
		public override void Write(Utf8JsonWriter writer, EQteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
