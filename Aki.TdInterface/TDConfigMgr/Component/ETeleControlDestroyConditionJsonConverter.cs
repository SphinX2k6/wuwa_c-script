using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF4 RID: 2804
	public class ETeleControlDestroyConditionJsonConverter : JsonConverter<ETeleControlDestroyCondition>
	{
		// Token: 0x06003D5E RID: 15710 RVA: 0x0009D218 File Offset: 0x0009B418
		public override ETeleControlDestroyCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETeleControlDestroyCondition.LetGo;
			}
			return ETeleControlDestroyConditionExtensions.FromString(@string);
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x0009D23C File Offset: 0x0009B43C
		public override void Write(Utf8JsonWriter writer, ETeleControlDestroyCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
