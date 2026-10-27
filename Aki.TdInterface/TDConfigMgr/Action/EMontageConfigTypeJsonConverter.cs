using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238A RID: 9098
	public class EMontageConfigTypeJsonConverter : JsonConverter<EMontageConfigType>
	{
		// Token: 0x0600C66D RID: 50797 RVA: 0x001D1040 File Offset: 0x001CF240
		public override EMontageConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMontageConfigType.Asset;
			}
			return EMontageConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x001D1064 File Offset: 0x001CF264
		public override void Write(Utf8JsonWriter writer, EMontageConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
