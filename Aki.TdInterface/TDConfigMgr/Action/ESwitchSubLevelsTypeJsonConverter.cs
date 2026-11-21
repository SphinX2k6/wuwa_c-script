using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E7 RID: 9959
	public class ESwitchSubLevelsTypeJsonConverter : JsonConverter<ESwitchSubLevelsType>
	{
		// Token: 0x0600D66B RID: 54891 RVA: 0x001F270C File Offset: 0x001F090C
		public override ESwitchSubLevelsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwitchSubLevelsType.Directly;
			}
			return ESwitchSubLevelsTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x001F2730 File Offset: 0x001F0930
		public override void Write(Utf8JsonWriter writer, ESwitchSubLevelsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
