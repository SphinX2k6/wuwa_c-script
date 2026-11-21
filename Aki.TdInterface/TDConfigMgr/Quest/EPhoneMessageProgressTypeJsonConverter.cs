using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200139F RID: 5023
	public class EPhoneMessageProgressTypeJsonConverter : JsonConverter<EPhoneMessageProgressType>
	{
		// Token: 0x060070A7 RID: 28839 RVA: 0x0010C9F0 File Offset: 0x0010ABF0
		public override EPhoneMessageProgressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneMessageProgressType.CompleteMessage;
			}
			return EPhoneMessageProgressTypeExtensions.FromString(@string);
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x0010CA14 File Offset: 0x0010AC14
		public override void Write(Utf8JsonWriter writer, EPhoneMessageProgressType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
