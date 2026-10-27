using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E6 RID: 8934
	public class EClientModifyTargetTypeJsonConverter : JsonConverter<EClientModifyTargetType>
	{
		// Token: 0x0600C38B RID: 50059 RVA: 0x001C914C File Offset: 0x001C734C
		public override EClientModifyTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientModifyTargetType.Self;
			}
			return EClientModifyTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C38C RID: 50060 RVA: 0x001C9170 File Offset: 0x001C7370
		public override void Write(Utf8JsonWriter writer, EClientModifyTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
