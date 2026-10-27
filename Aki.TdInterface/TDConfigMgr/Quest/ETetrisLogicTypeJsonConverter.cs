using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A3 RID: 4771
	public class ETetrisLogicTypeJsonConverter : JsonConverter<ETetrisLogicType>
	{
		// Token: 0x06006B86 RID: 27526 RVA: 0x00102C24 File Offset: 0x00100E24
		public override ETetrisLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisLogicType.I块;
			}
			return ETetrisLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x00102C48 File Offset: 0x00100E48
		public override void Write(Utf8JsonWriter writer, ETetrisLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
