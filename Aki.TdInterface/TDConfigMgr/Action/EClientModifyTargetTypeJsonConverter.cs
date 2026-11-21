using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002557 RID: 9559
	public class EClientModifyTargetTypeJsonConverter : JsonConverter<EClientModifyTargetType>
	{
		// Token: 0x0600CF63 RID: 53091 RVA: 0x001E1074 File Offset: 0x001DF274
		public override EClientModifyTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientModifyTargetType.Self;
			}
			return EClientModifyTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x001E1098 File Offset: 0x001DF298
		public override void Write(Utf8JsonWriter writer, EClientModifyTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
