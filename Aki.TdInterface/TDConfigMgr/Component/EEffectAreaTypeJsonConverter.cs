using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092B RID: 2347
	public class EEffectAreaTypeJsonConverter : JsonConverter<EEffectAreaType>
	{
		// Token: 0x060034F4 RID: 13556 RVA: 0x0008A5D8 File Offset: 0x000887D8
		public override EEffectAreaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEffectAreaType.BuffArea;
			}
			return EEffectAreaTypeExtensions.FromString(@string);
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x0008A5FC File Offset: 0x000887FC
		public override void Write(Utf8JsonWriter writer, EEffectAreaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
