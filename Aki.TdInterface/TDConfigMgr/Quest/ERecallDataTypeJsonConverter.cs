using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001279 RID: 4729
	public class ERecallDataTypeJsonConverter : JsonConverter<ERecallDataType>
	{
		// Token: 0x06006AC9 RID: 27337 RVA: 0x001001BC File Offset: 0x000FE3BC
		public override ERecallDataType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERecallDataType.LevelPlay;
			}
			return ERecallDataTypeExtensions.FromString(@string);
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x001001E0 File Offset: 0x000FE3E0
		public override void Write(Utf8JsonWriter writer, ERecallDataType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
