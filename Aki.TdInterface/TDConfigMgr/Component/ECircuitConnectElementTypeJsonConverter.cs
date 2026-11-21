using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B4 RID: 2484
	public class ECircuitConnectElementTypeJsonConverter : JsonConverter<ECircuitConnectElementType>
	{
		// Token: 0x060037BE RID: 14270 RVA: 0x0008D4F4 File Offset: 0x0008B6F4
		public override ECircuitConnectElementType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECircuitConnectElementType.Straight;
			}
			return ECircuitConnectElementTypeExtensions.FromString(@string);
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x0008D518 File Offset: 0x0008B718
		public override void Write(Utf8JsonWriter writer, ECircuitConnectElementType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
