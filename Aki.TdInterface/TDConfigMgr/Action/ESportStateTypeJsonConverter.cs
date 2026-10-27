using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242E RID: 9262
	public class ESportStateTypeJsonConverter : JsonConverter<ESportStateType>
	{
		// Token: 0x0600C94F RID: 51535 RVA: 0x001D7A54 File Offset: 0x001D5C54
		public override ESportStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESportStateType.Slide;
			}
			return ESportStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x001D7A78 File Offset: 0x001D5C78
		public override void Write(Utf8JsonWriter writer, ESportStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
