using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F7 RID: 9975
	public class ETalkItemStyleJsonConverter : JsonConverter<ETalkItemStyle>
	{
		// Token: 0x0600D6B3 RID: 54963 RVA: 0x001F5460 File Offset: 0x001F3660
		public override ETalkItemStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkItemStyle.InnerVoice;
			}
			return ETalkItemStyleExtensions.FromString(@string);
		}

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x001F5484 File Offset: 0x001F3684
		public override void Write(Utf8JsonWriter writer, ETalkItemStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
