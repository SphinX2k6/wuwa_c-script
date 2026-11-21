using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A32 RID: 2610
	public class EInterruptMontageTypeJsonConverter : JsonConverter<EInterruptMontageType>
	{
		// Token: 0x060039F5 RID: 14837 RVA: 0x00095D68 File Offset: 0x00093F68
		public override EInterruptMontageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInterruptMontageType.InterruptAtEnd;
			}
			return EInterruptMontageTypeExtensions.FromString(@string);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00095D8C File Offset: 0x00093F8C
		public override void Write(Utf8JsonWriter writer, EInterruptMontageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
