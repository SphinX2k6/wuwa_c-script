using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002458 RID: 9304
	public class ETalkItemTypeJsonConverter : JsonConverter<ETalkItemType>
	{
		// Token: 0x0600CA0C RID: 51724 RVA: 0x001DB964 File Offset: 0x001D9B64
		public override ETalkItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETalkItemType.Talk;
			}
			return ETalkItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA0D RID: 51725 RVA: 0x001DB988 File Offset: 0x001D9B88
		public override void Write(Utf8JsonWriter writer, ETalkItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
