using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B4 RID: 8884
	public class EAvgVisualEffectJsonConverter : JsonConverter<EAvgVisualEffect>
	{
		// Token: 0x0600C2AA RID: 49834 RVA: 0x001C728C File Offset: 0x001C548C
		public override EAvgVisualEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAvgVisualEffect.Default;
			}
			return EAvgVisualEffectExtensions.FromString(@string);
		}

		// Token: 0x0600C2AB RID: 49835 RVA: 0x001C72B0 File Offset: 0x001C54B0
		public override void Write(Utf8JsonWriter writer, EAvgVisualEffect value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
