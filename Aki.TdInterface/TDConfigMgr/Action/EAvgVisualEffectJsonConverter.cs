using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002523 RID: 9507
	public class EAvgVisualEffectJsonConverter : JsonConverter<EAvgVisualEffect>
	{
		// Token: 0x0600CE79 RID: 52857 RVA: 0x001DF094 File Offset: 0x001DD294
		public override EAvgVisualEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgVisualEffect.Default;
			}
			return EAvgVisualEffectExtensions.FromString(@string);
		}

		// Token: 0x0600CE7A RID: 52858 RVA: 0x001DF0B8 File Offset: 0x001DD2B8
		public override void Write(Utf8JsonWriter writer, EAvgVisualEffect value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
