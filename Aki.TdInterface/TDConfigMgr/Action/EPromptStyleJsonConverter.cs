using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E2 RID: 9186
	public class EPromptStyleJsonConverter : JsonConverter<EPromptStyle>
	{
		// Token: 0x0600C7F9 RID: 51193 RVA: 0x001D4634 File Offset: 0x001D2834
		public override EPromptStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPromptStyle.Default;
			}
			return EPromptStyleExtensions.FromString(@string);
		}

		// Token: 0x0600C7FA RID: 51194 RVA: 0x001D4658 File Offset: 0x001D2858
		public override void Write(Utf8JsonWriter writer, EPromptStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
