using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124F RID: 4687
	public class EKurotatoConditionStepJsonConverter : JsonConverter<EKurotatoConditionStep>
	{
		// Token: 0x06006A0C RID: 27148 RVA: 0x000FE178 File Offset: 0x000FC378
		public override EKurotatoConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKurotatoConditionStep.Prepare;
			}
			return EKurotatoConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x000FE19C File Offset: 0x000FC39C
		public override void Write(Utf8JsonWriter writer, EKurotatoConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
