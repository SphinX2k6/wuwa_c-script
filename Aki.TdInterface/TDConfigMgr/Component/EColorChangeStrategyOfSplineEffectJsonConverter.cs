using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090D RID: 2317
	public class EColorChangeStrategyOfSplineEffectJsonConverter : JsonConverter<EColorChangeStrategyOfSplineEffect>
	{
		// Token: 0x0600346D RID: 13421 RVA: 0x00085CB4 File Offset: 0x00083EB4
		public override EColorChangeStrategyOfSplineEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EColorChangeStrategyOfSplineEffect.RGB;
			}
			return EColorChangeStrategyOfSplineEffectExtensions.FromString(@string);
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00085CD8 File Offset: 0x00083ED8
		public override void Write(Utf8JsonWriter writer, EColorChangeStrategyOfSplineEffect value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
