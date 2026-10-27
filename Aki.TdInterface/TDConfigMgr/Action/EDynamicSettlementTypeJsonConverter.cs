using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002310 RID: 8976
	public class EDynamicSettlementTypeJsonConverter : JsonConverter<EDynamicSettlementType>
	{
		// Token: 0x0600C448 RID: 50248 RVA: 0x001CA744 File Offset: 0x001C8944
		public override EDynamicSettlementType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDynamicSettlementType.Battle;
			}
			return EDynamicSettlementTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x001CA768 File Offset: 0x001C8968
		public override void Write(Utf8JsonWriter writer, EDynamicSettlementType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
