using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125F RID: 4703
	public class EPhoneMessageProgressTypeJsonConverter : JsonConverter<EPhoneMessageProgressType>
	{
		// Token: 0x06006A54 RID: 27220 RVA: 0x000FEDC4 File Offset: 0x000FCFC4
		public override EPhoneMessageProgressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneMessageProgressType.CompleteMessage;
			}
			return EPhoneMessageProgressTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x000FEDE8 File Offset: 0x000FCFE8
		public override void Write(Utf8JsonWriter writer, EPhoneMessageProgressType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
