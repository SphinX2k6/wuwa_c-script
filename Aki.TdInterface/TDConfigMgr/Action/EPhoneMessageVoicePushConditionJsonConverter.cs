using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C6 RID: 9158
	public class EPhoneMessageVoicePushConditionJsonConverter : JsonConverter<EPhoneMessageVoicePushCondition>
	{
		// Token: 0x0600C77B RID: 51067 RVA: 0x001D33BC File Offset: 0x001D15BC
		public override EPhoneMessageVoicePushCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneMessageVoicePushCondition.PlayVoice;
			}
			return EPhoneMessageVoicePushConditionExtensions.FromString(@string);
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x001D33E0 File Offset: 0x001D15E0
		public override void Write(Utf8JsonWriter writer, EPhoneMessageVoicePushCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
