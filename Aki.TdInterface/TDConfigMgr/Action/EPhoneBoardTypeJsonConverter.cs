using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002657 RID: 9815
	public class EPhoneBoardTypeJsonConverter : JsonConverter<EPhoneBoardType>
	{
		// Token: 0x0600D3E3 RID: 54243 RVA: 0x001EC7B8 File Offset: 0x001EA9B8
		public override EPhoneBoardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneBoardType.MessageBoard;
			}
			return EPhoneBoardTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3E4 RID: 54244 RVA: 0x001EC7DC File Offset: 0x001EA9DC
		public override void Write(Utf8JsonWriter writer, EPhoneBoardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
