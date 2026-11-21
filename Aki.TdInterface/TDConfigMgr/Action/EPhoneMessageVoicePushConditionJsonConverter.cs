using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200265B RID: 9819
	public class EPhoneMessageVoicePushConditionJsonConverter : JsonConverter<EPhoneMessageVoicePushCondition>
	{
		// Token: 0x0600D3F5 RID: 54261 RVA: 0x001ECA54 File Offset: 0x001EAC54
		public override EPhoneMessageVoicePushCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneMessageVoicePushCondition.PlayVoice;
			}
			return EPhoneMessageVoicePushConditionExtensions.FromString(@string);
		}

		// Token: 0x0600D3F6 RID: 54262 RVA: 0x001ECA78 File Offset: 0x001EAC78
		public override void Write(Utf8JsonWriter writer, EPhoneMessageVoicePushCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
