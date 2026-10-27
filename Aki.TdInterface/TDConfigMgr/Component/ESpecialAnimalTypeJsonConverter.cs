using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A17 RID: 2583
	public class ESpecialAnimalTypeJsonConverter : JsonConverter<ESpecialAnimalType>
	{
		// Token: 0x0600391A RID: 14618 RVA: 0x00093784 File Offset: 0x00091984
		public override ESpecialAnimalType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialAnimalType.CollectAnimal;
			}
			return ESpecialAnimalTypeExtensions.FromString(@string);
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x000937A8 File Offset: 0x000919A8
		public override void Write(Utf8JsonWriter writer, ESpecialAnimalType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
