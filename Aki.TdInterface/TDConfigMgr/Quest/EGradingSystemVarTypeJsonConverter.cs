using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001387 RID: 4999
	public class EGradingSystemVarTypeJsonConverter : JsonConverter<EGradingSystemVarType>
	{
		// Token: 0x0600703B RID: 28731 RVA: 0x0010B77C File Offset: 0x0010997C
		public override EGradingSystemVarType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGradingSystemVarType.Score;
			}
			return EGradingSystemVarTypeExtensions.FromString(@string);
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x0010B7A0 File Offset: 0x001099A0
		public override void Write(Utf8JsonWriter writer, EGradingSystemVarType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
