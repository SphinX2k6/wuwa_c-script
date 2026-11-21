using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200138D RID: 5005
	public class EInformationViewTypeJsonConverter : JsonConverter<EInformationViewType>
	{
		// Token: 0x06007056 RID: 28758 RVA: 0x0010BAC4 File Offset: 0x00109CC4
		public override EInformationViewType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInformationViewType.LevelPlay;
			}
			return EInformationViewTypeExtensions.FromString(@string);
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x0010BAE8 File Offset: 0x00109CE8
		public override void Write(Utf8JsonWriter writer, EInformationViewType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
