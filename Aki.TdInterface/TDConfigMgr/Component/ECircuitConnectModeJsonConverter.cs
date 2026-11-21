using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B6 RID: 2486
	public class ECircuitConnectModeJsonConverter : JsonConverter<ECircuitConnectMode>
	{
		// Token: 0x060037C7 RID: 14279 RVA: 0x0008D608 File Offset: 0x0008B808
		public override ECircuitConnectMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECircuitConnectMode.TwoRings;
			}
			return ECircuitConnectModeExtensions.FromString(@string);
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x0008D62C File Offset: 0x0008B82C
		public override void Write(Utf8JsonWriter writer, ECircuitConnectMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
