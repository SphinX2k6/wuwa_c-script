using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B0C RID: 2828
	public class ETurntableConnectorGameplayTypeJsonConverter : JsonConverter<ETurntableConnectorGameplayType>
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x0009DF84 File Offset: 0x0009C184
		public override ETurntableConnectorGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETurntableConnectorGameplayType.CircuitConnect;
			}
			return ETurntableConnectorGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x0009DFA8 File Offset: 0x0009C1A8
		public override void Write(Utf8JsonWriter writer, ETurntableConnectorGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
