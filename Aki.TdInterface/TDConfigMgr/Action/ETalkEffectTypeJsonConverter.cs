using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F5 RID: 9973
	public class ETalkEffectTypeJsonConverter : JsonConverter<ETalkEffectType>
	{
		// Token: 0x0600D6AA RID: 54954 RVA: 0x001F5308 File Offset: 0x001F3508
		public override ETalkEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkEffectType.Effect;
			}
			return ETalkEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D6AB RID: 54955 RVA: 0x001F532C File Offset: 0x001F352C
		public override void Write(Utf8JsonWriter writer, ETalkEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
