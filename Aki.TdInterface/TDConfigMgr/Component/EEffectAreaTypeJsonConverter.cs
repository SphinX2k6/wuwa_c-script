using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D8 RID: 2520
	public class EEffectAreaTypeJsonConverter : JsonConverter<EEffectAreaType>
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x00092158 File Offset: 0x00090358
		public override EEffectAreaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEffectAreaType.BuffArea;
			}
			return EEffectAreaTypeExtensions.FromString(@string);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0009217C File Offset: 0x0009037C
		public override void Write(Utf8JsonWriter writer, EEffectAreaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
