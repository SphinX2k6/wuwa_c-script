using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002446 RID: 9286
	public class ESwitchSubLevelsTypeJsonConverter : JsonConverter<ESwitchSubLevelsType>
	{
		// Token: 0x0600C9BB RID: 51643 RVA: 0x001D8844 File Offset: 0x001D6A44
		public override ESwitchSubLevelsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwitchSubLevelsType.Directly;
			}
			return ESwitchSubLevelsTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9BC RID: 51644 RVA: 0x001D8868 File Offset: 0x001D6A68
		public override void Write(Utf8JsonWriter writer, ESwitchSubLevelsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
