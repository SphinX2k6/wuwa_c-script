using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001389 RID: 5001
	public class EHandInItemTypeJsonConverter : JsonConverter<EHandInItemType>
	{
		// Token: 0x06007044 RID: 28740 RVA: 0x0010B890 File Offset: 0x00109A90
		public override EHandInItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHandInItemType.ItemIds;
			}
			return EHandInItemTypeExtensions.FromString(@string);
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x0010B8B4 File Offset: 0x00109AB4
		public override void Write(Utf8JsonWriter writer, EHandInItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
