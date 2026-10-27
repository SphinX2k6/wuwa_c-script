using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002340 RID: 9024
	public class EFlowTemplateTransitionEffectTypeJsonConverter : JsonConverter<EFlowTemplateTransitionEffectType>
	{
		// Token: 0x0600C520 RID: 50464 RVA: 0x001CC5DC File Offset: 0x001CA7DC
		public override EFlowTemplateTransitionEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlowTemplateTransitionEffectType.Blur;
			}
			return EFlowTemplateTransitionEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C521 RID: 50465 RVA: 0x001CC600 File Offset: 0x001CA800
		public override void Write(Utf8JsonWriter writer, EFlowTemplateTransitionEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
