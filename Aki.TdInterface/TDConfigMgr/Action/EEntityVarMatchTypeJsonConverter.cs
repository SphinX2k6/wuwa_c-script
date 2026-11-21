using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002597 RID: 9623
	public class EEntityVarMatchTypeJsonConverter : JsonConverter<EEntityVarMatchType>
	{
		// Token: 0x0600D083 RID: 53379 RVA: 0x001E3380 File Offset: 0x001E1580
		public override EEntityVarMatchType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEntityVarMatchType.EntityId;
			}
			return EEntityVarMatchTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D084 RID: 53380 RVA: 0x001E33A4 File Offset: 0x001E15A4
		public override void Write(Utf8JsonWriter writer, EEntityVarMatchType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
