using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000994 RID: 2452
	public class EAiGearStrategyJsonConverter : JsonConverter<EAiGearStrategy>
	{
		// Token: 0x0600372E RID: 14126 RVA: 0x0008C18C File Offset: 0x0008A38C
		public override EAiGearStrategy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAiGearStrategy.RenjuStrategy;
			}
			return EAiGearStrategyExtensions.FromString(@string);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0008C1B0 File Offset: 0x0008A3B0
		public override void Write(Utf8JsonWriter writer, EAiGearStrategy value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
