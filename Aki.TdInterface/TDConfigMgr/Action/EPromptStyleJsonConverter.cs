using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002679 RID: 9849
	public class EPromptStyleJsonConverter : JsonConverter<EPromptStyle>
	{
		// Token: 0x0600D47C RID: 54396 RVA: 0x001EDDE0 File Offset: 0x001EBFE0
		public override EPromptStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPromptStyle.Default;
			}
			return EPromptStyleExtensions.FromString(@string);
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x001EDE04 File Offset: 0x001EC004
		public override void Write(Utf8JsonWriter writer, EPromptStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
