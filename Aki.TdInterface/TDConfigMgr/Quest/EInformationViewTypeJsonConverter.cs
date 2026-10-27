using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124D RID: 4685
	public class EInformationViewTypeJsonConverter : JsonConverter<EInformationViewType>
	{
		// Token: 0x06006A03 RID: 27139 RVA: 0x000FDE98 File Offset: 0x000FC098
		public override EInformationViewType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInformationViewType.LevelPlay;
			}
			return EInformationViewTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x000FDEBC File Offset: 0x000FC0BC
		public override void Write(Utf8JsonWriter writer, EInformationViewType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
