using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200138F RID: 5007
	public class EKurotatoConditionStepJsonConverter : JsonConverter<EKurotatoConditionStep>
	{
		// Token: 0x0600705F RID: 28767 RVA: 0x0010BDA4 File Offset: 0x00109FA4
		public override EKurotatoConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKurotatoConditionStep.Prepare;
			}
			return EKurotatoConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06007060 RID: 28768 RVA: 0x0010BDC8 File Offset: 0x00109FC8
		public override void Write(Utf8JsonWriter writer, EKurotatoConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
