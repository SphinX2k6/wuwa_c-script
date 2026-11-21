using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BA RID: 2490
	public class EColorChangeStrategyOfSplineEffectJsonConverter : JsonConverter<EColorChangeStrategyOfSplineEffect>
	{
		// Token: 0x060037D9 RID: 14297 RVA: 0x0008D7C0 File Offset: 0x0008B9C0
		public override EColorChangeStrategyOfSplineEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EColorChangeStrategyOfSplineEffect.RGB;
			}
			return EColorChangeStrategyOfSplineEffectExtensions.FromString(@string);
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x0008D7E4 File Offset: 0x0008B9E4
		public override void Write(Utf8JsonWriter writer, EColorChangeStrategyOfSplineEffect value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
