using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002454 RID: 9300
	public class ETalkEffectTypeJsonConverter : JsonConverter<ETalkEffectType>
	{
		// Token: 0x0600C9FA RID: 51706 RVA: 0x001DB298 File Offset: 0x001D9498
		public override ETalkEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkEffectType.Effect;
			}
			return ETalkEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9FB RID: 51707 RVA: 0x001DB2BC File Offset: 0x001D94BC
		public override void Write(Utf8JsonWriter writer, ETalkEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
