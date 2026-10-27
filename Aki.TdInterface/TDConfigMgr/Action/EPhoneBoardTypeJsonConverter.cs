using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C2 RID: 9154
	public class EPhoneBoardTypeJsonConverter : JsonConverter<EPhoneBoardType>
	{
		// Token: 0x0600C769 RID: 51049 RVA: 0x001D3120 File Offset: 0x001D1320
		public override EPhoneBoardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneBoardType.MessageBoard;
			}
			return EPhoneBoardTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C76A RID: 51050 RVA: 0x001D3144 File Offset: 0x001D1344
		public override void Write(Utf8JsonWriter writer, EPhoneBoardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
