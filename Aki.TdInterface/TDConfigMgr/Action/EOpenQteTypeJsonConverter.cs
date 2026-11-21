using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002649 RID: 9801
	public class EOpenQteTypeJsonConverter : JsonConverter<EOpenQteType>
	{
		// Token: 0x0600D3A4 RID: 54180 RVA: 0x001EBFA8 File Offset: 0x001EA1A8
		public override EOpenQteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOpenQteType.PanelQte;
			}
			return EOpenQteTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x001EBFCC File Offset: 0x001EA1CC
		public override void Write(Utf8JsonWriter writer, EOpenQteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
