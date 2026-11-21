using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A22 RID: 2594
	public class EInhaledPerResultTypeJsonConverter : JsonConverter<EInhaledPerResultType>
	{
		// Token: 0x060039AD RID: 14765 RVA: 0x00095450 File Offset: 0x00093650
		public override EInhaledPerResultType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInhaledPerResultType.DestroySelf;
			}
			return EInhaledPerResultTypeExtensions.FromString(@string);
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00095474 File Offset: 0x00093674
		public override void Write(Utf8JsonWriter writer, EInhaledPerResultType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
