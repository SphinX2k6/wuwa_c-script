using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B1 RID: 9649
	public class EFlowTemplateTransitionEffectTypeJsonConverter : JsonConverter<EFlowTemplateTransitionEffectType>
	{
		// Token: 0x0600D0F8 RID: 53496 RVA: 0x001E4694 File Offset: 0x001E2894
		public override EFlowTemplateTransitionEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlowTemplateTransitionEffectType.Blur;
			}
			return EFlowTemplateTransitionEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x001E46B8 File Offset: 0x001E28B8
		public override void Write(Utf8JsonWriter writer, EFlowTemplateTransitionEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
