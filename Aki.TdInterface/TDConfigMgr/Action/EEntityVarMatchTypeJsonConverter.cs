using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002326 RID: 8998
	public class EEntityVarMatchTypeJsonConverter : JsonConverter<EEntityVarMatchType>
	{
		// Token: 0x0600C4AB RID: 50347 RVA: 0x001CB3A4 File Offset: 0x001C95A4
		public override EEntityVarMatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityVarMatchType.EntityId;
			}
			return EEntityVarMatchTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x001CB3C8 File Offset: 0x001C95C8
		public override void Write(Utf8JsonWriter writer, EEntityVarMatchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
