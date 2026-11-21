using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200257F RID: 9599
	public class EDynamicSettlementTypeJsonConverter : JsonConverter<EDynamicSettlementType>
	{
		// Token: 0x0600D017 RID: 53271 RVA: 0x001E260C File Offset: 0x001E080C
		public override EDynamicSettlementType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicSettlementType.Battle;
			}
			return EDynamicSettlementTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D018 RID: 53272 RVA: 0x001E2630 File Offset: 0x001E0830
		public override void Write(Utf8JsonWriter writer, EDynamicSettlementType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
