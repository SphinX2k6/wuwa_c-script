using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E9 RID: 5097
	public class ETetrisLogicTypeJsonConverter : JsonConverter<ETetrisLogicType>
	{
		// Token: 0x060071F4 RID: 29172 RVA: 0x00110BEC File Offset: 0x0010EDEC
		public override ETetrisLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisLogicType.I块;
			}
			return ETetrisLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00110C10 File Offset: 0x0010EE10
		public override void Write(Utf8JsonWriter writer, ETetrisLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
