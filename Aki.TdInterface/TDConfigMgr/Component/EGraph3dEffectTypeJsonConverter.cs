using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A06 RID: 2566
	public class EGraph3dEffectTypeJsonConverter : JsonConverter<EGraph3dEffectType>
	{
		// Token: 0x0600392F RID: 14639 RVA: 0x00093E0C File Offset: 0x0009200C
		public override EGraph3dEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGraph3dEffectType.FireBoxFish;
			}
			return EGraph3dEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x00093E30 File Offset: 0x00092030
		public override void Write(Utf8JsonWriter writer, EGraph3dEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
