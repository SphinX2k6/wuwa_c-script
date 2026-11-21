using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025EB RID: 9707
	public class ELiveDanmakuLinkTypeJsonConverter : JsonConverter<ELiveDanmakuLinkType>
	{
		// Token: 0x0600D1FD RID: 53757 RVA: 0x001E87B0 File Offset: 0x001E69B0
		public override ELiveDanmakuLinkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiveDanmakuLinkType.KeepCurrent;
			}
			return ELiveDanmakuLinkTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D1FE RID: 53758 RVA: 0x001E87D4 File Offset: 0x001E69D4
		public override void Write(Utf8JsonWriter writer, ELiveDanmakuLinkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
