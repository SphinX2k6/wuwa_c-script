using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001391 RID: 5009
	public class EKurotatoSystemVarTypeJsonConverter : JsonConverter<EKurotatoSystemVarType>
	{
		// Token: 0x06007068 RID: 28776 RVA: 0x0010C224 File Offset: 0x0010A424
		public override EKurotatoSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EKurotatoSystemVarType.Gold;
			}
			return EKurotatoSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x0010C248 File Offset: 0x0010A448
		public override void Write(Utf8JsonWriter writer, EKurotatoSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
