using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002581 RID: 9601
	public class EEditFlagJsonConverter : JsonConverter<EEditFlag>
	{
		// Token: 0x0600D020 RID: 53280 RVA: 0x001E2764 File Offset: 0x001E0964
		public override EEditFlag Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEditFlag.Add;
			}
			return EEditFlagExtensions.FromString(@string);
		}

		// Token: 0x0600D021 RID: 53281 RVA: 0x001E2788 File Offset: 0x001E0988
		public override void Write(Utf8JsonWriter writer, EEditFlag value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
