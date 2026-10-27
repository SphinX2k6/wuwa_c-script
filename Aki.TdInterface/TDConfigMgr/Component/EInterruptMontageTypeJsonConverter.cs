using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097F RID: 2431
	public class EInterruptMontageTypeJsonConverter : JsonConverter<EInterruptMontageType>
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x0008DDFC File Offset: 0x0008BFFC
		public override EInterruptMontageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInterruptMontageType.InterruptAtEnd;
			}
			return EInterruptMontageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x0008DE20 File Offset: 0x0008C020
		public override void Write(Utf8JsonWriter writer, EInterruptMontageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
