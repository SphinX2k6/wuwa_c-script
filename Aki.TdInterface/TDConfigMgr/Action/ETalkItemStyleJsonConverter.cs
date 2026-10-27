using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002456 RID: 9302
	public class ETalkItemStyleJsonConverter : JsonConverter<ETalkItemStyle>
	{
		// Token: 0x0600CA03 RID: 51715 RVA: 0x001DB3AC File Offset: 0x001D95AC
		public override ETalkItemStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkItemStyle.InnerVoice;
			}
			return ETalkItemStyleExtensions.FromString(@string);
		}

		// Token: 0x0600CA04 RID: 51716 RVA: 0x001DB3D0 File Offset: 0x001D95D0
		public override void Write(Utf8JsonWriter writer, ETalkItemStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
