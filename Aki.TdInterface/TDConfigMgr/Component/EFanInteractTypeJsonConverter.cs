using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F6 RID: 2550
	public class EFanInteractTypeJsonConverter : JsonConverter<EFanInteractType>
	{
		// Token: 0x060038E7 RID: 14567 RVA: 0x000935D8 File Offset: 0x000917D8
		public override EFanInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFanInteractType.Hit;
			}
			return EFanInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x000935FC File Offset: 0x000917FC
		public override void Write(Utf8JsonWriter writer, EFanInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
