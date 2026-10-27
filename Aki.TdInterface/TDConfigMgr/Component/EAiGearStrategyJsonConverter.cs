using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008EF RID: 2287
	public class EAiGearStrategyJsonConverter : JsonConverter<EAiGearStrategy>
	{
		// Token: 0x060033E6 RID: 13286 RVA: 0x00084B50 File Offset: 0x00082D50
		public override EAiGearStrategy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAiGearStrategy.RenjuStrategy;
			}
			return EAiGearStrategyExtensions.FromString(@string);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00084B74 File Offset: 0x00082D74
		public override void Write(Utf8JsonWriter writer, EAiGearStrategy value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
