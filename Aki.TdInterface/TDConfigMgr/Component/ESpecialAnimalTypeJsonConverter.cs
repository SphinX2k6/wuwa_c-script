using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ADC RID: 2780
	public class ESpecialAnimalTypeJsonConverter : JsonConverter<ESpecialAnimalType>
	{
		// Token: 0x06003CF2 RID: 15602 RVA: 0x0009C074 File Offset: 0x0009A274
		public override ESpecialAnimalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialAnimalType.CollectAnimal;
			}
			return ESpecialAnimalTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x0009C098 File Offset: 0x0009A298
		public override void Write(Utf8JsonWriter writer, ESpecialAnimalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
