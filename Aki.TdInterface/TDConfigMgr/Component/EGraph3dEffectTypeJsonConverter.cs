using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000953 RID: 2387
	public class EGraph3dEffectTypeJsonConverter : JsonConverter<EGraph3dEffectType>
	{
		// Token: 0x060035A8 RID: 13736 RVA: 0x0008BEB8 File Offset: 0x0008A0B8
		public override EGraph3dEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGraph3dEffectType.FireBoxFish;
			}
			return EGraph3dEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x0008BEDC File Offset: 0x0008A0DC
		public override void Write(Utf8JsonWriter writer, EGraph3dEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
