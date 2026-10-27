using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129B RID: 4763
	public class ESystemPromptTypeJsonConverter : JsonConverter<ESystemPromptType>
	{
		// Token: 0x06006B62 RID: 27490 RVA: 0x00102034 File Offset: 0x00100234
		public override ESystemPromptType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemPromptType.AreaName;
			}
			return ESystemPromptTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x00102058 File Offset: 0x00100258
		public override void Write(Utf8JsonWriter writer, ESystemPromptType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
